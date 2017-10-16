using System;
using System.Xml;
using System.Windows.Forms;
using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using LiveSplit.TimeFormatters;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace LiveSplit.RivaTuner.UI.Components
{
    public class RivaTunerComponent : LogicComponent, IDeactivatableComponent
    {
        LiveSplitState State { get; set; }
        RivaTunerSettings Settings { get; set; }
        RegularTimeFormatter TimeFormatter { get; set; }
        RegularSplitTimeFormatter SplitTimeFormatter { get; set; }
        DeltaSplitTimeFormatter DeltaFormatter { get; set; }
        PossibleTimeSaveFormatter PossibleTimeSaveFormatter { get; set; }

        public RivaTunerComponent(LiveSplitState state)
        {
            State = state;
            Settings = new RivaTunerSettings();
            TimeFormatter = new RegularTimeFormatter(TimeAccuracy.Hundredths);
            SplitTimeFormatter = new RegularSplitTimeFormatter(TimeAccuracy.Seconds);
            DeltaFormatter = new DeltaSplitTimeFormatter(TimeAccuracy.Tenths, true);
            PossibleTimeSaveFormatter = new PossibleTimeSaveFormatter();
        }

        private void updateRiva(string text)
        {
            try
            {
                RivaTuner.print(text);
            }
            catch (Exception e)
            {

            }
        }
        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            string text = $"<C0=00CC4B><C1=5CD689><C2=D65C5C><C3=CC0000><C4=FFD500><C5=999999><C6=666666><C7=4DA6FF><C8=4DA6FF><S0={Settings.FontSize}><S0>";

            foreach (string s in Settings.addedComponents)
            {
                switch (s)
                {
                    case "Title":
                        text += titleComponent();
                        break;
                    case "Splits":
                        text += splitsComponent();
                        break;
                    case "Timer":
                        text += timerComponent();
                        break;
                    case "Previous Segment":
                        text += previousSegmentComponent();
                        break;
                    case "Sum Of Best":
                        text += sumOfBestComponent();
                        break;
                    case "Possible Time Save":
                        text += possibleTimeSaveComponent();
                        break;
                    case "Space":
                        text += "\n";
                        break;
                    default:
                        break;
                }
            }

            text += "<S>";
            Task.Run(async () => updateRiva(text));
        }

        private string titleComponent()
        {
            var comparison = State.CurrentComparison;
            var method = State.CurrentTimingMethod;

            var game = centerString(State.Run.GameName, 35);
            var category = centerString(State.Run.CategoryName, 35);
            var attempts = String.Format("{0, 35}", State.Run.AttemptCount);
            var combined = String.Join("", category.ToCharArray().Zip(attempts.ToCharArray(), (c, a) =>
            {
                return char.IsWhiteSpace(a) ? c : a;
            }));

            return String.Format($"{game.Substring(0, 35)}\n{combined}\n");
        }

        private string splitsComponent()
        {
            var text = "";
            var comparison = State.CurrentComparison;
            var method = State.CurrentTimingMethod;

            for (int i = 0; i < State.Run.Count; i++)
            {
                ISegment segment = State.Run[i];
                TimeSpan? deltaTime = null;
                Color? color = null;
                var segName = (segment.Name.Length > 15) ? segment.Name.Substring(0, 15) : segment.Name;

                if(i < State.CurrentSplitIndex)
                {
                    deltaTime = segment.SplitTime[method] - segment.Comparisons[comparison][method];
                    color = LiveSplitStateHelper.GetSplitColor(State, deltaTime, i, true, true, comparison, method);
                }
                else
                {
                    //Live Delta
                    var bestDelta = LiveSplitStateHelper.CheckLiveDelta(State, true, comparison, method);
                    if (bestDelta != null && segment == State.CurrentSplit)
                    {
                        deltaTime = bestDelta;
                        color = State.LayoutSettings.TextColor;
                    }
                }

                text += String.Format("{0}{1, -15}<C> {2}{3, 9}<C> {4, 9}\n",
                    (State.CurrentSplit == segment) ? "<C8>" : "",
                    segName,
                    getColor(color),
                    DeltaFormatter.Format(deltaTime),
                    SplitTimeFormatter.Format(segment.Comparisons[comparison][method])
                    );
            }
            return text;
        }

        private string timerComponent()
        {
            var comparison = State.CurrentComparison;
            var method = State.CurrentTimingMethod;
            var TimerColor = Color.Transparent;
            if (State.CurrentPhase == TimerPhase.NotRunning || State.CurrentTime[method] < TimeSpan.Zero)
            {
                TimerColor = State.LayoutSettings.NotRunningColor;
            }
            else if (State.CurrentPhase == TimerPhase.Paused)
            {
                TimerColor = State.LayoutSettings.PausedColor;
            }
            else if (State.CurrentPhase == TimerPhase.Ended)
            {
                if (State.Run.Last().Comparisons[State.CurrentComparison][method] == null || State.CurrentTime[method] < State.Run.Last().Comparisons[State.CurrentComparison][method])
                {
                    TimerColor = State.LayoutSettings.PersonalBestColor;
                }
                else
                {
                    TimerColor = State.LayoutSettings.BehindLosingTimeColor;
                }
            }
            else if (State.CurrentPhase == TimerPhase.Running)
            {
                if (State.CurrentSplit.Comparisons[State.CurrentComparison][method] != null)
                {
                    TimerColor = LiveSplitStateHelper.GetSplitColor(State, State.CurrentTime[method] - State.CurrentSplit.Comparisons[State.CurrentComparison][method],
                        State.CurrentSplitIndex, true, false, State.CurrentComparison, method)
                        ?? State.LayoutSettings.AheadGainingTimeColor;
                }
                else
                    TimerColor = State.LayoutSettings.AheadGainingTimeColor;
            }
            return String.Format("{0}{1, 35}<C>\n",
                getColor(TimerColor),
                TimeFormatter.Format(State.CurrentTime[method]));

        }

        private string sumOfBestComponent()
        {
            var comparison = State.CurrentComparison;
            var method = State.CurrentTimingMethod;
            var sob = SumOfBest.CalculateSumOfBest(State.Run, State.Settings.SimpleSumOfBest, true, State.CurrentTimingMethod);
            return formatInfoText("Sum of Best", TimeFormatter.Format(sob)) + "\n";
        }

        private string previousSegmentComponent()
        {
            var comparison = State.CurrentComparison;
            var method = State.CurrentTimingMethod;
            var text = "Previous Segment";
            var time = "";
            Color? color = Color.Transparent;

            TimeSpan? timeChange = null;
            TimeSpan? timeSave = null;
            var liveSegment = LiveSplitStateHelper.CheckLiveDelta(State, false, comparison, method);
            if (State.CurrentPhase != TimerPhase.NotRunning)
            {
                if (liveSegment != null)
                {
                    timeChange = liveSegment;
                    timeSave = GetPossibleTimeSave(State, State.CurrentSplitIndex, comparison);
                    text = "Live Segment";
                }
                else if (State.CurrentSplitIndex > 0)
                {
                    timeChange = LiveSplitStateHelper.GetPreviousSegmentDelta(State, State.CurrentSplitIndex - 1, comparison, State.CurrentTimingMethod);
                    timeSave = GetPossibleTimeSave(State, State.CurrentSplitIndex - 1, comparison);
                }
                if (timeChange != null)
                {
                    if (liveSegment != null)
                        color = LiveSplitStateHelper.GetSplitColor(State, timeChange, State.CurrentSplitIndex, false, false, comparison, method).Value;
                    else
                        color = LiveSplitStateHelper.GetSplitColor(State, timeChange.Value, State.CurrentSplitIndex - 1, false, true, comparison, method).Value;
                }
                else
                {
                    color = LiveSplitStateHelper.GetSplitColor(State, null, State.CurrentSplitIndex - 1, true, true, comparison, State.CurrentTimingMethod);
                    if (color == null)
                        color = State.LayoutSettings.TextColor;
                }
            }
            else
            {
                color = State.LayoutSettings.TextColor;
            }

            var a = DeltaFormatter.Accuracy;
            DeltaFormatter.Accuracy = TimeAccuracy.Tenths;
            time = DeltaFormatter.Format(timeChange);
            DeltaFormatter.Accuracy = a;

            return formatInfoTextWithColor(text, time, color) + "\n";
        }

        private string possibleTimeSaveComponent()
        {
            var comparison = State.CurrentComparison;
            TimeSpan? time = null;

            if (State.CurrentPhase == TimerPhase.Running || State.CurrentPhase == TimerPhase.Paused)
            {
                time = GetPossibleTimeSave(State, State.CurrentSplitIndex, comparison);
            }
            else
            {
                time = null;
            }
            return formatInfoText("Possible Time Save", PossibleTimeSaveFormatter.Format(time)) + "\n";
        }

        private TimeSpan? GetPossibleTimeSave(LiveSplitState state, int splitIndex, string comparison)
        {
            var prevTime = TimeSpan.Zero;
            TimeSpan? bestSegments = state.Run[splitIndex].BestSegmentTime[state.CurrentTimingMethod];

            while (splitIndex > 0 && bestSegments != null)
            {
                var splitTime = state.Run[splitIndex - 1].Comparisons[comparison][state.CurrentTimingMethod];
                if (splitTime != null)
                {
                    prevTime = splitTime.Value;
                    break;
                }
                else
                {
                    splitIndex--;
                    bestSegments += state.Run[splitIndex].BestSegmentTime[state.CurrentTimingMethod];
                }
            }

            var time = state.Run[splitIndex].Comparisons[comparison][state.CurrentTimingMethod] - prevTime - bestSegments;

            if (time < TimeSpan.Zero)
                time = TimeSpan.Zero;

            return time;
        }

        private string formatInfoTextWithColor(string text, string time, Color? color)
        {
            if (text.Length > 35)
                text = text.Substring(0, 35);

            var length = text.Length;
            text += getColor(color);
            
            var add = 35 - length - time.Length;
            for(int i = 0; i < add; i++)
            {
                text += " ";
            }

            text += time;
            text += "<C>";
            return text;
        }

        private string formatInfoText(string text, string value)
        {
            text = String.Format("{0, -35}", text);
            value = String.Format("{0, 35}", value);
            return String.Join("", text.ToCharArray().Zip(value.ToCharArray(), (t, v) =>
            {
                return char.IsWhiteSpace(v) ? t : v;
            }));
        }

        private string getColor(Color? color)
        {
            if (color == null)
                return "";
            if (color == State.LayoutSettings.AheadGainingTimeColor)
                return "<C0>";
            if (color == State.LayoutSettings.AheadLosingTimeColor)
                return "<C1>";
            if (color == State.LayoutSettings.BehindGainingTimeColor)
                return "<C2>";
            if (color == State.LayoutSettings.BehindLosingTimeColor)
                return "<C3>";
            if (color == State.LayoutSettings.BestSegmentColor)
                return "<C4>";
            if (color == State.LayoutSettings.NotRunningColor)
                return "<C5>";
            if (color == State.LayoutSettings.PausedColor)
                return "<C6>";
            if (color == State.LayoutSettings.PersonalBestColor)
                return "<C7>";
            else
                return "";
        }

        private static string centerString(string s, int len)
        {
            return String.Format("{0," + -len + "}", String.Format("{0," + ((len + s.Length) / 2).ToString() + "}", s));
        }

        #region YES
        public bool Activated { get; set; } = true;
        public override string ComponentName => "RivaTuner";
        public override void Dispose()
        {
            try
            {
                RivaTuner.print("");
            }
            catch (Exception e)
            {

            }
        }
        public override XmlNode GetSettings(XmlDocument document) => Settings.GetSettings(document);
        public override Control GetSettingsControl(LayoutMode mode) => Settings;
        public override void SetSettings(XmlNode settings) => Settings.SetSettings(settings);
        public int GetSettingsHashCode() => Settings.GetSettingsHashCode();
        #endregion
    }
}
