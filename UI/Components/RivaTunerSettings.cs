using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.UI;
using LiveSplit.TimeFormatters;

namespace LiveSplit.RivaTuner.UI.Components
{
    public partial class RivaTunerSettings : UserControl
    {
        // Splits
        private int _VisualSplitCount { get; set; } = 8;
        public int VisualSplitCount
        {
            get { return _VisualSplitCount; }
            set
            {
                _VisualSplitCount = value;
                var max = Math.Max(0, _VisualSplitCount - (AlwaysShowLastSplit ? 2 : 1));
                if (nudUpcomingSegments.Value > max)
                    nudUpcomingSegments.Value = max;
                nudUpcomingSegments.Maximum = max;
            }
        }
        public int SplitPreviewCount { get; set; } = 1;
        public bool AlwaysShowLastSplit { get; set; } = true;
        public bool DropDecimals { get; set; } = true;
        public TimeAccuracy DeltasAccuracy { get; set; } = TimeAccuracy.Tenths;
        public TimeAccuracy SplitAccuracy { get; set; } = TimeAccuracy.Seconds;

        // Title
        public bool ShowGameName { get; set; } = true;
        public bool ShowCategoryName { get; set; } = true;
        public bool ShowOneLine { get; set; } = false;
        public bool ShowFinishedCount { get; set; } = true;
        public bool ShowAttemptCount { get; set; } = true;

        // Timer
        public string TimingMethod { get; set; } = "Current Timing Method";
        public string DigitsFormat { get; set; } = "1";
        public string Accuracy { get; set; } = ".23";
        private string timerFormat
        {
            get
            {
                return DigitsFormat + Accuracy;
            }
            set
            {
                var decimalIndex = value.IndexOf('.');
                if (decimalIndex < 0)
                {
                    DigitsFormat = value;
                    Accuracy = "";
                }
                else
                {
                    DigitsFormat = value.Substring(0, decimalIndex);
                    Accuracy = value.Substring(decimalIndex);
                }
            }
        }

        // Alternate Timing Method
        public string AlternateTimeFormat { get; set; } = "1";
        public string AlternateAccuracy { get; set; } = ".23";
        private string alternateTimerFormat
        {
            get
            {
                return AlternateTimeFormat + AlternateAccuracy;
            }
            set
            {
                var decimalIndex = value.IndexOf('.');
                if (decimalIndex < 0)
                {
                    AlternateTimeFormat = value;
                    AlternateAccuracy = "";
                }
                else
                {
                    AlternateTimeFormat = value.Substring(0, decimalIndex);
                    AlternateAccuracy = value.Substring(decimalIndex);
                }
            }
        }


        public int CharacterWidth { get; set; } = 35;
        public int FontSize { get; protected set; } = 70;


        private List<string> availableComponents;
        public BindingList<string> addedComponents;

        public RivaTunerSettings()
        {
            InitializeComponent();
            availableComponents = new List<string>()
            {
                "Title",
                "Splits",
                "Timer",
                "Previous Segment",
                "Sum Of Best",
                "Possible Time Save",
                "Space",
                "Alternate Timing Method"
            };
            addedComponents = new BindingList<string>();

            lbComponents.DataSource = availableComponents;
            lbAddedComponents.DataSource = addedComponents;

            nudFontSize.DataBindings.Add("Value", this, "FontSize", false, DataSourceUpdateMode.OnPropertyChanged);
            nudCharacters.DataBindings.Add("Value", this, "CharacterWidth", false, DataSourceUpdateMode.OnPropertyChanged);

            // Splits
            nudTotalSegments.DataBindings.Add("Value", this, "VisualSplitCount", false, DataSourceUpdateMode.OnPropertyChanged);
            nudUpcomingSegments.DataBindings.Add("Value", this, "SplitPreviewCount", false, DataSourceUpdateMode.OnPropertyChanged);
            chkLockLastSplit.DataBindings.Add("Checked", this, "AlwaysShowLastSplit", false, DataSourceUpdateMode.OnPropertyChanged);
            chkDeltaDropDecimals.DataBindings.Add("Checked", this, "DropDecimals", false, DataSourceUpdateMode.OnPropertyChanged);

            // Title
            chkShowAttempt.DataBindings.Add("Checked", this, "ShowAttemptCount", false, DataSourceUpdateMode.OnPropertyChanged);
            chkShowFinished.DataBindings.Add("Checked", this, "ShowFinishedCount", false, DataSourceUpdateMode.OnPropertyChanged);
            chkShowGameName.DataBindings.Add("Checked", this, "ShowGameName", false, DataSourceUpdateMode.OnPropertyChanged);
            chkShowCategoryName.DataBindings.Add("Checked", this, "ShowCategoryName", false, DataSourceUpdateMode.OnPropertyChanged);
            chkOneLine.DataBindings.Add("Checked", this, "ShowOneLine", false, DataSourceUpdateMode.OnPropertyChanged);

            // Timer
            cbTimingMethod.DataBindings.Add("SelectedItem", this, "TimingMethod", false, DataSourceUpdateMode.OnPropertyChanged);
            cbTimerFormatValue.DataBindings.Add("SelectedItem", this, "DigitsFormat", false, DataSourceUpdateMode.OnPropertyChanged);
            cbTimerFormatFraction.DataBindings.Add("SelectedItem", this, "Accuracy", false, DataSourceUpdateMode.OnPropertyChanged);

            //Alternate
            cbAlternateFormatValue.DataBindings.Add("SelectedItem", this, "AlternateTimeFormat", false, DataSourceUpdateMode.OnPropertyChanged);
            cbAlternateFormatFraction.DataBindings.Add("SelectedItem", this, "AlternateAccuracy", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        public void SetSettings(XmlNode settings)
        {
            var element = (XmlElement)settings;
            // Splits
            VisualSplitCount = SettingsHelper.ParseInt(element["VisualSplitCount"], 8);
            SplitPreviewCount = SettingsHelper.ParseInt(element["SplitPreviewCount"], 1);
            AlwaysShowLastSplit = SettingsHelper.ParseBool(element["AlwaysShowLastSplit"], true);
            DropDecimals = SettingsHelper.ParseBool(element["DropDecimals"], true);
            DeltasAccuracy = SettingsHelper.ParseEnum(element["DeltasAccuracy"], TimeAccuracy.Tenths);
            SplitAccuracy = SettingsHelper.ParseEnum(element["SplitAccuracy"], TimeAccuracy.Seconds);
            // Title
            ShowGameName = SettingsHelper.ParseBool(element["ShowGameName"], true);
            ShowCategoryName = SettingsHelper.ParseBool(element["ShowCategoryName"], true);
            ShowOneLine = SettingsHelper.ParseBool(element["ShowOneLine"], false);
            ShowFinishedCount = SettingsHelper.ParseBool(element["ShowFinishedCount"], true);
            ShowAttemptCount = SettingsHelper.ParseBool(element["ShowAttemptCount"], true);
            // Timer
            TimingMethod = SettingsHelper.ParseString(element["TimingMethod"], "Current Timing Method");
            timerFormat = SettingsHelper.ParseString(element["TimerFormat"], "1.23");
            // Alternate Timing Method
            alternateTimerFormat = SettingsHelper.ParseString(element["AlternateTimerFormat"], "1.23");
            // General
            CharacterWidth = SettingsHelper.ParseInt(element["CharacterWidth"], 35);
            FontSize = SettingsHelper.ParseInt(element["FontSize"], 70);
            var elementsCSV = SettingsHelper.ParseString(element["Elements"]);

            if (string.IsNullOrEmpty(elementsCSV))
                return;

            addedComponents.Clear();
            foreach(var e in elementsCSV.Split(','))
            {
                addedComponents.Add(e);
            }
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.0") ^
            // Splits
            SettingsHelper.CreateSetting(document, parent, "VisualSplitCount", VisualSplitCount) ^
            SettingsHelper.CreateSetting(document, parent, "SplitPreviewCount", SplitPreviewCount) ^
            SettingsHelper.CreateSetting(document, parent, "AlwaysShowLastSplit", AlwaysShowLastSplit) ^
            SettingsHelper.CreateSetting(document, parent, "DropDecimals", DropDecimals) ^
            SettingsHelper.CreateSetting(document, parent, "DeltasAccuracy", DeltasAccuracy) ^
            SettingsHelper.CreateSetting(document, parent, "SplitAccuracy", SplitAccuracy) ^
            // Title
            SettingsHelper.CreateSetting(document, parent, "ShowGameName", ShowGameName) ^
            SettingsHelper.CreateSetting(document, parent, "ShowCategoryName", ShowCategoryName) ^
            SettingsHelper.CreateSetting(document, parent, "ShowOneLine", ShowOneLine) ^
            SettingsHelper.CreateSetting(document, parent, "ShowFinishedCount", ShowFinishedCount) ^
            SettingsHelper.CreateSetting(document, parent, "ShowAttemptCount", ShowAttemptCount) ^
            // Timer
            SettingsHelper.CreateSetting(document, parent, "TimingMethod", TimingMethod) ^
            SettingsHelper.CreateSetting(document, parent, "TimerFormat", timerFormat) ^
            // Alternate Timing Method
            SettingsHelper.CreateSetting(document, parent, "AlternateTimerFormat", alternateTimerFormat) ^
            // General
            SettingsHelper.CreateSetting(document, parent, "CharacterWidth", CharacterWidth) ^
            SettingsHelper.CreateSetting(document, parent, "FontSize", FontSize) ^
            SettingsHelper.CreateSetting(document, parent, "Elements", elements());
        }

        private string elements()
        {
            return String.Join(",", addedComponents);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var item = lbComponents.SelectedItem;
            if(item != null)
            {
                addedComponents.Add((string)item);
            }
            lbAddedComponents.SelectedIndex = addedComponents.Count - 1;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var index = lbAddedComponents.SelectedIndex;
            var item = lbComponents.SelectedItem;
            if (item != null)
            {
                addedComponents.Insert(index, (string)item);
            }
            lbAddedComponents.SelectedIndex = index;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var index = lbAddedComponents.SelectedIndex;
            if (index >= 0)
            {
                addedComponents.RemoveAt(index);
            }
            lbAddedComponents_SelectedIndexChanged(null, null);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            var index = lbAddedComponents.SelectedIndex;
            var last = addedComponents.Count - 1;
            if(index < last)
            {
                var item = addedComponents[index];
                addedComponents.RemoveAt(index);
                if (index < last)
                    addedComponents.Insert(index + 1, item);
                else
                    addedComponents.Add(item);

                lbAddedComponents.SelectedIndex = index + 1;
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            var index = lbAddedComponents.SelectedIndex;
            if(index > 0)
            {
                var item = addedComponents[index];
                addedComponents.RemoveAt(index);
                addedComponents.Insert(index - 1, item);

                lbAddedComponents.SelectedIndex = index - 1;
            }
        }

        private void lbAddedComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = lbAddedComponents.SelectedIndex;
            var count = addedComponents.Count;
            btnMoveUp.Enabled = count > 1 && index != 0;
            btnMoveDown.Enabled = count > 1 && index != count - 1;
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            var value = nudFontSize.Value;
            if (value > int.MaxValue)
            {
                nudFontSize.Value = int.MaxValue;
                FontSize = int.MaxValue;
            }
            else if (value < 50)
            {
                nudFontSize.Value = 50;
                FontSize = 50;
            }
            else
            {
                FontSize = (int)value;
            }
        }

        private void SplitAccuracy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSplitAccuracy();
        }
        
        private void DeltaAccuracy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDeltaAccuracy();
        }

        void UpdateDeltaAccuracy()
        {
            if (rbDeltaAccuracySeconds.Checked)
                DeltasAccuracy = TimeAccuracy.Seconds;
            else if (rbDeltaAccuracyTenths.Checked)
                DeltasAccuracy = TimeAccuracy.Tenths;
            else
                DeltasAccuracy = TimeAccuracy.Hundredths;
        }
        void UpdateSplitAccuracy()
        {
            if (rbSplitAccuracySeconds.Checked)
                SplitAccuracy = TimeAccuracy.Seconds;
            else if (rbSplitAccuracyTenths.Checked)
                SplitAccuracy = TimeAccuracy.Tenths;
            else
                SplitAccuracy = TimeAccuracy.Hundredths;
        }

        private void RivaTunerSettings_Load(object sender, EventArgs e)
        {
            // Splits Settings
            rbSplitAccuracySeconds.Checked = SplitAccuracy == TimeAccuracy.Seconds;
            rbSplitAccuracyTenths.Checked = SplitAccuracy == TimeAccuracy.Tenths;
            rbSplitAccuracyHundreths.Checked = SplitAccuracy == TimeAccuracy.Hundredths;
            rbDeltaAccuracySeconds.Checked = DeltasAccuracy == TimeAccuracy.Seconds;
            rbDeltaAccuracyTenths.Checked = DeltasAccuracy == TimeAccuracy.Tenths;
            rbDeltaAccuracyHundreths.Checked = DeltasAccuracy == TimeAccuracy.Hundredths;
        }

        void cmbTimerFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DigitsFormat = cbTimerFormatValue.SelectedItem.ToString();
        }

        private void cmbAccuracy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Accuracy = cbTimerFormatFraction.SelectedItem.ToString();
        }

        void cmbTimingMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimingMethod = cbTimingMethod.SelectedItem.ToString();
        }

        private void cbAlternateFormatValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlternateTimeFormat = cbAlternateFormatValue.SelectedItem.ToString();
        }

        private void cbAlternateFormatFraction_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlternateAccuracy = cbAlternateFormatFraction.SelectedItem.ToString();
        }
    }
}
