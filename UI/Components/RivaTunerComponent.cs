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
using System.Runtime.InteropServices;
using LiveSplit.Options;
using LiveSplit.Web;
using System.Runtime.CompilerServices;


namespace LiveSplit.RivaTuner.UI.Components
{

    public class RivaTunerComponent : LogicComponent, IDeactivatableComponent
    {
        LiveSplitState State { get; set; }
        RivaTunerSettings Settings { get; set; }

        RegularTimeFormatter TimeFormatter { get; set; }
        RegularSplitTimeFormatter SplitTimeFormatter { get; set; }
        DeltaSplitTimeFormatter DeltaFormatter { get; set; }
        ShortTimeFormatter ShortFormatter { get; set; }
        PossibleTimeSaveFormatter PossibleTimeSaveFormatter { get; set; }

        TimeFormat CurrentTimeFormat { get; set; }
        TimeAccuracy CurrentAccuracy { get; set; }
        TimeFormat AlternateTimeFormat { get; set; }
        TimeAccuracy AlternateAccuracy { get; set; }

        public RivaTunerComponent(LiveSplitState state)
        {
            State = state;
            Settings = new RivaTunerSettings();
            TimeFormatter = new RegularTimeFormatter(TimeAccuracy.Hundredths);
            SplitTimeFormatter = new RegularSplitTimeFormatter(TimeAccuracy.Seconds);
            DeltaFormatter = new DeltaSplitTimeFormatter(TimeAccuracy.Tenths, true);
            ShortFormatter = new ShortTimeFormatter();
            PossibleTimeSaveFormatter = new PossibleTimeSaveFormatter();
        }

        private void updateRiva(string text)
        {
            try
            {
                RivaTuner.print(text);
            }
            catch (SEHException e)
            {
                Log.Error(e);
            }
            catch (Exception e)
            {
                Log.Error(e);
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
                    case "SubSplits":
                        text += subSplitsComponent();
                        break;
                    case "Timer":
                        text += timerComponent();
                        break;
                    case "Split Timer":
                        text += SplitTimerComponent();
                        break;
                    case "Previous Segment":
                        text += previousSegmentComponent();
                        break;
                    case "Sum Of Best":
                        text += sumOfBestComponent();
                        break;
                    case "Best Possible Time":
                        text += BPTComponent();
                        break;
                    case "Possible Time Save":
                        text += possibleTimeSaveComponent();
                        break;
                    case "Space":
                        text += "\n";
                        break;
                    case "Alternate Timing Method":
                        text += alternateTiming();
                        break;
                    case "Comparison":
                        text += comparingAgainstComponent();
                        break;
                    default:
                        break;
                }
            }

            updateRiva(text);
        }

        private string titleComponent()
        {
            string line1 = String.Format("{0," + Settings.CharacterWidth + "}", " ");
            string line2 = String.Format("{0," + Settings.CharacterWidth + "}", " ");

            if (Settings.ShowFinishedCount && Settings.ShowAttemptCount)
            {
                var temp = String.Format("{0}/{1}", State.Run.AttemptHistory.Where(x => x.Time.RealTime != null).Count(), State.Run.AttemptCount);
                line2 = String.Format("{0, " + Settings.CharacterWidth + "}", temp);
            }
            else if (Settings.ShowFinishedCount)
                line2 = String.Format("{0, " + Settings.CharacterWidth + "}", State.Run.AttemptHistory.Where(x => x.Time.RealTime != null).Count());
            else if (Settings.ShowAttemptCount)
                line2 = String.Format("{0, " + Settings.CharacterWidth + "}", State.Run.AttemptCount);
            
            if (Settings.ShowOneLine && Settings.ShowGameName && Settings.ShowCategoryName)
            {
                var text = string.Format("{0} - {1}", State.Run.GameName, State.Run.CategoryName);
                var gameAbbreviations = State.Run.GameName.GetAbbreviations();
                var shortestGameName = gameAbbreviations.Last();
                var abbreviations = gameAbbreviations.Select(x => string.Format("{0} - {1}", x, State.Run.CategoryName));
                line1 = centerString(abbreviations.Where(x => x.Length <= Settings.CharacterWidth).First(), Settings.CharacterWidth) + "\n";
            }
            else
            {
                if(Settings.ShowGameName)
                {
                    if(State.Run.GameName.Length > Settings.CharacterWidth)
                    {
                        line1 = centerString(State.Run.GameName.GetAbbreviations().Where(x => x.Length <= Settings.CharacterWidth).First(), Settings.CharacterWidth);
                    }
                    else
                    {
                        line1 = centerString(State.Run.GameName, Settings.CharacterWidth);
                    }
                }
                line1 += '\n';
                if (Settings.ShowCategoryName)
                {
                    line2 = String.Join("", centerString(State.Run.CategoryName, Settings.CharacterWidth).ToCharArray().Zip(line2.ToCharArray(), (c, a) =>
                    {
                        return char.IsWhiteSpace(a) ? c : a;
                    }));
                }
            }
            
            return $"{line1}{line2}\n";
        }

        private string splitsComponent()
        {
            var text = "";
            var comparison = State.CurrentComparison;
            var method = State.CurrentTimingMethod;
            var skipCount = Math.Min(
                Math.Max(
                    0,
                    State.CurrentSplitIndex - (Settings.VisualSplitCount - 2 - Settings.SplitPreviewCount + (Settings.AlwaysShowLastSplit ? 0 : 1))
                    ),
                State.Run.Count - Settings.VisualSplitCount);
            
            foreach (var split in State.Run.Skip(skipCount).Take(Settings.VisualSplitCount - 1 + (Settings.AlwaysShowLastSplit ? 0 : 1)))
            {
                text += splitComponent(split, comparison, method);
            }
            if (Settings.AlwaysShowLastSplit && State.Run.Count >= Settings.VisualSplitCount)
                text += splitComponent(State.Run.Last(), comparison, method);

            return text;
        }

        private string splitComponent(ISegment segment, string comparison, TimingMethod method)
        {
            TimeSpan? deltaTime = null;
            Color? color = null;
            var i = State.Run.IndexOf(segment);
            int delta = 4;
            int time = 9;
            int split = Settings.CharacterWidth - delta - time - 2;
            var segName = (segment.Name.Length > split) ? segment.Name.Substring(0, split) : segment.Name;

            if (i < State.CurrentSplitIndex)
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

            DeltaFormatter.DropDecimals = Settings.DropDecimals;
            DeltaFormatter.Accuracy = Settings.DeltasAccuracy;
            SplitTimeFormatter.Accuracy = Settings.SplitAccuracy;

            var splitTime = segment.SplitTime[method];
            if(splitTime == null && State.CurrentSplitIndex <= i)
            {
                splitTime = segment.Comparisons[comparison][method];
            }

            return String.Format("{0}{1, " + -split + "}<C> {2}{3, " + delta + "}<C> {4, " + time + "}\n",
                (State.CurrentSplit == segment) ? "<C8>" : "",
                segName,
                getColor(color),
                DeltaFormatter.Format(deltaTime),
                SplitTimeFormatter.Format(splitTime)
                );
        }

        // WORK IN PROGRESS---------------------------------------------

        private string subSplitsComponent()
        {
            var text = "";
            var comparison = State.CurrentComparison;
            var method = State.CurrentTimingMethod;
            bool isSubSplit = false;
            Int16 isSubSplitIterator = 0;
            Int16 Iterator = 0;

            var skipCount = Math.Min(
                Math.Max(
                    0,
                    State.CurrentSplitIndex - (Settings.VisualSplitCount - 2 - Settings.SplitPreviewCount + (Settings.AlwaysShowLastSplit ? 0 : 1))
                    ),
                State.Run.Count - Settings.VisualSplitCount);
            
            var splits = State.Run.Skip(skipCount).Take(Settings.VisualSplitCount - 1 + (Settings.AlwaysShowLastSplit ? 0 : 1));
            var numberOfSplits = splits.Count();

            string[] textArray = new string[numberOfSplits + 1];

            foreach (var split in splits)
            {
                string splitText = subSplitComponent(split, comparison, method);

                if (splitText.StartsWith("-"))
                {
                    isSubSplit = true;
                    splitText = splitText.Remove(0, 1);
                    splitText = splitText.Insert(0, "   ");
                    isSubSplitIterator++;
                    textArray[Iterator] = splitText;
                } 
                else if (splitText.StartsWith("<C8>-"))
                {
                    isSubSplit = true;
                    splitText = splitText.Remove(4, 1);
                    splitText = splitText.Insert(4, "   ");
                    isSubSplitIterator++;
                    textArray[Iterator] = splitText;
                } 
                else if (splitText.StartsWith("{") && isSubSplit == true)
                {
                    string name = "";
                    string splitName = "";
                    isSubSplit = false;
                    for(int i = 0; i < splitText.Length; i++)
                    {
                        if (splitText[i] == '{')
                        {
                            continue;
                        }
                        else if (splitText[i] == '}')
                        {
                            break;
                        }
                        else
                        {
                            name += splitText[i];
                        }
                    }
                    for(int i = name.Length + 2; i < splitText.Length; i++)
                    {
                        splitName += splitText[i];
                    }
                    textArray[Iterator] = splitName;
                    if (Iterator - isSubSplitIterator < 0)
                    {
                        textArray[0] = name + "\n";
                    }
                    else if (Iterator - isSubSplitIterator == 1)
                    {
                        textArray[0] = name + "\n";
                    } 
                    else
                    {
                        textArray[Iterator - isSubSplitIterator] = name + "\n";
                    }

                }
                else if (splitText.StartsWith("<C8>{") && isSubSplit == true)
                {
                    string name = "";
                    string splitName = "";
                    isSubSplit = false;
                    for (int i = 0;i < splitText.Length; i++)
                    {
                        if (splitText[i] == '{')
                        {
                            continue;
                        }
                        else if (splitText[i] == '}')
                        {
                            break;
                        }
                        else
                        {
                            name += splitText[i];
                        }
                    }
                    for (int i = name.Length + 2; i < splitText.Length; i++)
                    {
                        splitName += splitText[i];
                    }
                    textArray[Iterator] = splitName;
                    textArray[Iterator - 1] = name;
                } else if(isSubSplit == true)
                {
                    textArray[Iterator - isSubSplitIterator] = splitText;
                    isSubSplit = false;
                }
                else
                {
                    textArray[Iterator] = splitText;
                }
                text += splitText;
                Iterator++;
            }
            if (Settings.AlwaysShowLastSplit && State.Run.Count >= Settings.VisualSplitCount)
                textArray[numberOfSplits] = splitComponent(State.Run.Last(), comparison, method);

            var testSplits = State.Run.Skip(skipCount + Iterator).Take(20);
            if(isSubSplit == true)
            {
                isSubSplit = false;
                foreach (var split in testSplits)
                {
                    string splitText = subSplitComponent(split, comparison, method);
                    if (splitText.StartsWith("-"))
                    {
                        isSubSplitIterator++;
                    }
                    else if (splitText.StartsWith("{"))
                    {
                        string name = "";
                        for (int i = 0; i < splitText.Length; i++)
                        {
                            if (splitText[i] == '{')
                            {
                                continue;
                            }
                            else if (splitText[i] == '}')
                            {
                                break;
                            }
                            else
                            {
                                name += splitText[i];
                            }
                        }
                        for(int i = Settings.VisualSplitCount -1; i> Iterator - isSubSplitIterator - 1; i--)
                        {
                            textArray[i] = textArray[i - 1];
                        }
                        textArray[Iterator - isSubSplitIterator - 1] = name + "\n";
                        isSubSplit = false;
                        break;
                    } else
                    {
                        textArray[Iterator - isSubSplitIterator -1] = splitText;
                        isSubSplit = false;
                        break;
                    }

                    text += splitText;
                    Iterator++;
                }
            }
            

            text = string.Join("", textArray);

            return text;
        }

        private string subSplitComponent(ISegment segment, string comparison, TimingMethod method)
        {
            TimeSpan? deltaTime = null;
            Color? color = null;
            var i = State.Run.IndexOf(segment);
            int delta = 4;
            int time = 9;
            int split = Settings.CharacterWidth - delta - time - 2;
            var segName = (segment.Name.Length > split) ? segment.Name.Substring(0, split) : segment.Name;

            if (i < State.CurrentSplitIndex)
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

            DeltaFormatter.DropDecimals = Settings.DropDecimals;
            DeltaFormatter.Accuracy = Settings.DeltasAccuracy;
            SplitTimeFormatter.Accuracy = Settings.SplitAccuracy;

            var splitTime = segment.SplitTime[method];
            if (splitTime == null && State.CurrentSplitIndex <= i)
            {
                splitTime = segment.Comparisons[comparison][method];
            }

            return String.Format("{0}{1, " + -split + "}<C> {2}{3, " + delta + "}<C> {4, " + time + "}\n",
                (State.CurrentSplit == segment) ? "<C8>" : "",
                segName,
                getColor(color),
                DeltaFormatter.Format(deltaTime),
                SplitTimeFormatter.Format(splitTime)
                );
        }


        // END OF WORK IN PROGRESS--------------------------------------
        private string timerComponent()
        {
            UpdateTimeFormat();
            var timingMethod = State.CurrentTimingMethod;
            if (Settings.TimingMethod == "Real Time")
                timingMethod = TimingMethod.RealTime;
            else if (Settings.TimingMethod == "Game Time")
                timingMethod = TimingMethod.GameTime;

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

            var size = Settings.TimerSize;
            var sizeW = size.Remove(size.Length - 1);
            int sizeTimer = Settings.FontSize;
            if (sizeW == "100")
            {
                sizeTimer = Settings.FontSize;
            }
            else if (sizeW == "125")
            {
                sizeTimer = (int)(Settings.FontSize * 1.14);
            }
            else if (sizeW == "150")
            {
                sizeTimer = (int)(Settings.FontSize * 1.39);
            }
            else if (sizeW == "175")
            {
                sizeTimer = (int)(Settings.FontSize * 1.61);
            }
            else if (sizeW == "200")
            {
                sizeTimer = (int)(Settings.FontSize * 2);
            }
            var doubleWidthTimer = double.Parse(Settings.TimerPosition);
            var widthTimer = (int)(doubleWidthTimer * Settings.CharacterWidth / 100) ;

            var timeValue = State.CurrentTime[timingMethod];
            var timeString = ShortFormatter.Format(timeValue, CurrentTimeFormat);
            int dotIndex = timeString.IndexOf(".");
            var time = timeString.Substring(0, dotIndex);
            var fraction = String.Empty;
            if (CurrentAccuracy == TimeAccuracy.Hundredths)
                fraction = timeString.Substring(dotIndex);
            else if (CurrentAccuracy == TimeAccuracy.Tenths)
                fraction = timeString.Substring(dotIndex, 2);
            return String.Format("{0}<S=" + sizeTimer + ">{1, " + widthTimer.ToString() + "}<C>\n",
                getColor(TimerColor),
                String.Join("", time, fraction, "<S0>"));
        }

        private string SplitTimerComponent()
        {
            UpdateTimeFormat();
            var timingMethod = State.CurrentTimingMethod;
            if (Settings.TimingMethod == "Real Time")
                timingMethod = TimingMethod.RealTime;
            else if (Settings.TimingMethod == "Game Time")
                timingMethod = TimingMethod.GameTime;

            var comparison = State.CurrentComparison;
            var method = State.CurrentTimingMethod;
            var TimerColor = State.LayoutSettings.NotRunningColor;

            var size = Settings.SplitTimerSize;
            var sizeW = size.Remove(size.Length - 1);
            int sizeTimer = Settings.FontSize;
            if (sizeW == "100")
            {
                sizeTimer = Settings.FontSize;
            }
            else if (sizeW == "125")
            {
                sizeTimer = (int)(Settings.FontSize * 1.25);
            }
            else if (sizeW == "150")
            {
                sizeTimer = (int)(Settings.FontSize * 1.5);
            }
            else if (sizeW == "175")
            {
                sizeTimer = (int)(Settings.FontSize * 1.75);
            }
            else if (sizeW == "200")
            {
                sizeTimer = (int)(Settings.FontSize * 2);
            }
            
            TimeSpan? splitTime = null;
            string stringSplitTime = "Gold: 00:00:00.00";
            if (State.CurrentPhase != TimerPhase.NotRunning)
                splitTime = State.Run[State.CurrentSplitIndex].BestSegmentTime[State.CurrentTimingMethod];
            if (splitTime.HasValue)
            {
                stringSplitTime = "Gold: " + splitTime.ToString();
                if(stringSplitTime.Length > 17)
                {
                    stringSplitTime = stringSplitTime.Remove(17);
                }
            }
            var doubleWidthTimer = double.Parse(Settings.SplitTimerPosition);
            int widthTimer = (int)(doubleWidthTimer * Settings.CharacterWidth / 100 - stringSplitTime.Length);

            var timeValue = State.CurrentTime[method];
            TimeSpan? lastSplit = TimeSpan.Zero;
            var runEndedDelay = State.CurrentPhase == TimerPhase.Ended ? 1 : 0;
            if (State.CurrentSplitIndex > 0 + runEndedDelay)
            {
                if (State.Run[State.CurrentSplitIndex - 1 - runEndedDelay].SplitTime[method] != null)
                    lastSplit = State.Run[State.CurrentSplitIndex - 1 - runEndedDelay].SplitTime[method].Value;
                else
                    lastSplit = null;
            }
            if (State.CurrentPhase == TimerPhase.NotRunning)
                timeValue = State.Run.Offset;
            else
                timeValue = State.CurrentTime[method] - lastSplit;

            var timeString = ShortFormatter.Format(timeValue, CurrentTimeFormat);
            int dotIndex = timeString.IndexOf(".");
            var time = timeString.Substring(0, dotIndex);
            var fraction = String.Empty;
            if (CurrentAccuracy == TimeAccuracy.Hundredths)
                fraction = timeString.Substring(dotIndex);
            else if (CurrentAccuracy == TimeAccuracy.Tenths)
                fraction = timeString.Substring(dotIndex, 2);

            return String.Format("{0}{1}<S=" + sizeTimer + ">{2, " + widthTimer.ToString() + "}<C>\n",
                getColor(TimerColor),
                String.Join("<S=" + ((int)(Settings.FontSize/2)).ToString() + ">", stringSplitTime),
                String.Join("", time, fraction, "<S0>"));
        }

        private string alternateTiming()
        {
            UpdateTimeFormat();
            var timingMethod = State.CurrentTimingMethod;
            if (timingMethod == TimingMethod.GameTime)
                timingMethod = TimingMethod.RealTime;
            else if (timingMethod == TimingMethod.RealTime)
                timingMethod = TimingMethod.GameTime;

            var methodString = timingMethod == TimingMethod.GameTime ? "Game Time" : "Real Time";

            var timeValue = State.CurrentTime[timingMethod];
            var timeString = ShortFormatter.Format(timeValue, AlternateTimeFormat);
            int dotIndex = timeString.IndexOf(".");
            var time = timeString.Substring(0, dotIndex);
            var fraction = String.Empty;
            if (AlternateAccuracy == TimeAccuracy.Hundredths)
                fraction = timeString.Substring(dotIndex);
            else if (AlternateAccuracy == TimeAccuracy.Tenths)
                fraction = timeString.Substring(dotIndex, 2);

            return formatInfoText(methodString, String.Join("", time, fraction)) + "\n";
        }

        protected void UpdateTimeFormat()
        {
            if (Settings.DigitsFormat == "1")
                CurrentTimeFormat = TimeFormat.Seconds;
            else if (Settings.DigitsFormat == "00:01")
                CurrentTimeFormat = TimeFormat.Minutes;
            else if (Settings.DigitsFormat == "0:00:01")
                CurrentTimeFormat = TimeFormat.Hours;
            else
                CurrentTimeFormat = TimeFormat.TenHours;

            if (Settings.AlternateTimeFormat == "1")
                AlternateTimeFormat = TimeFormat.Seconds;
            else if (Settings.AlternateTimeFormat == "00:01")
                AlternateTimeFormat = TimeFormat.Minutes;
            else if (Settings.AlternateTimeFormat == "0:00:01")
                AlternateTimeFormat = TimeFormat.Hours;
            else
                CurrentTimeFormat = TimeFormat.TenHours;
            
            if (Settings.Accuracy == ".23")
                CurrentAccuracy = TimeAccuracy.Hundredths;
            else if (Settings.Accuracy == ".2")
                CurrentAccuracy = TimeAccuracy.Tenths;
            else
                CurrentAccuracy = TimeAccuracy.Seconds;

            if (Settings.AlternateAccuracy == ".23")
                AlternateAccuracy = TimeAccuracy.Hundredths;
            else if (Settings.AlternateAccuracy == ".2")
                AlternateAccuracy = TimeAccuracy.Tenths;
            else
                AlternateAccuracy = TimeAccuracy.Seconds;


        }

        private string sumOfBestComponent()
        {
            var comparison = State.CurrentComparison;
            var method = State.CurrentTimingMethod;
            var sob = SumOfBest.CalculateSumOfBest(State.Run, State.Settings.SimpleSumOfBest, true, State.CurrentTimingMethod);
            return formatInfoText("Sum of Best", TimeFormatter.Format(sob)) + "\n";
        }

        private string BPTComponent()
        {
            var method = State.CurrentTimingMethod;
            var comparison = LiveSplit.Model.Comparisons.BestSegmentsComparisonGenerator.ComparisonName;
            TimeSpan? bpt;

            if (State.CurrentPhase == TimerPhase.Running || State.CurrentPhase == TimerPhase.Paused)
            {
                TimeSpan? delta = LiveSplitStateHelper.GetLastDelta(State, State.CurrentSplitIndex, comparison, method) ?? TimeSpan.Zero;
                var liveDelta = State.CurrentTime[method] - State.CurrentSplit.Comparisons[comparison][method];
                if (liveDelta > delta)
                    delta = liveDelta;
                bpt = delta + State.Run.Last().Comparisons[comparison][method];
            }
            else if (State.CurrentPhase == TimerPhase.Ended)
            {
                bpt = State.Run.Last().SplitTime[method];
            }
            else
            {
                bpt = State.Run.Last().Comparisons[comparison][method];
            }

            return formatInfoText("Best Possible Time", TimeFormatter.Format(bpt)) + "\n";
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

        private string comparingAgainstComponent()
        {
            var line1 = State.CurrentComparison;
            return formatInfoText("Comparing Against", line1) + "\n";
        }

        private string formatInfoTextWithColor(string text, string time, Color? color)
        {
            if (text.Length > Settings.CharacterWidth)
                text = text.Substring(0, Settings.CharacterWidth);

            var length = text.Length;
            text += getColor(color);
            
            var add = Settings.CharacterWidth - length - time.Length;
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
            text = String.Format("{0, " + -Settings.CharacterWidth + "}", text);
            value = String.Format("{0, " + Settings.CharacterWidth + "}", value);
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
            updateRiva("");
        }
        public override XmlNode GetSettings(XmlDocument document) => Settings.GetSettings(document);
        public override Control GetSettingsControl(LayoutMode mode) => Settings;
        public override void SetSettings(XmlNode settings) => Settings.SetSettings(settings);
        public int GetSettingsHashCode() => Settings.GetSettingsHashCode();
        #endregion
    }
}
