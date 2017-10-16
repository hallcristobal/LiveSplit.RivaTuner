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

namespace LiveSplit.RivaTuner.UI.Components
{
    public partial class RivaTunerSettings : UserControl
    {
        private List<string> availableComponents;
        public BindingList<string> addedComponents;
        public int FontSize { get; protected set; } = 70;

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
                "Space"
            };
            addedComponents = new BindingList<string>();

            lbComponents.DataSource = availableComponents;
            lbAddedComponents.DataSource = addedComponents;
            nudFontSize.Value = FontSize;
        }

        public void SetSettings(XmlNode settings)
        {
            var element = (XmlElement)settings;
            FontSize = SettingsHelper.ParseInt(element["FontSize"], 70);
            var elementsCSV = SettingsHelper.ParseString(element["Elements"]);
            if (elementsCSV == null)
                return;

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
                SettingsHelper.CreateSetting(document, parent, "FontSize", FontSize) ^
                SettingsHelper.CreateSetting(document, parent, "Elements", elements());
        }

        private string elements()
        {
            return String.Join(",", addedComponents.Select(x => x));
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
    }
}
