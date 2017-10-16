using System;
using System.Xml;
using System.Windows.Forms;
using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;

namespace LiveSplit.RivaTuner.UI.Components
{
    public class RivaTunerComponent : LogicComponent, IDeactivatableComponent
    {
        LiveSplitState State { get; set; }
        RivaTunerSettings Settings { get; set; }
        TimeFormatters.RegularTimeFormatter Formatter { get; set; }

        public RivaTunerComponent(LiveSplitState state)
        {
            State = state;
            Settings = new RivaTunerSettings();
            Formatter = new TimeFormatters.RegularTimeFormatter();
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {

            var time = state.CurrentTime[state.CurrentTimingMethod].Value;
            try
            {
                RivaTuner.print(Formatter.Format(time));
            }
            catch(Exception e)
            {

            }
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
