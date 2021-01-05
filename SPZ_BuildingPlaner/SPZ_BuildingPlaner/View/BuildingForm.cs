using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SPZ_BuildingPlaner
{
    public partial class BuildingForm : MetroForm
    {
        public BuildingForm()
        {
            InitializeComponent();
            comboBoxMapSize.SelectedIndex = 0;
            MaximizeBox = false;
            buttonSaveBuilding.Enabled = false;
            if (comboBoxFloorsList.Items.Count <= 0)
            {
                comboBoxFloorsList.Text = "Нету ни одного этажа";
            }

        }

        private void addFloorBtn_Click(object sender, EventArgs e)
        {
            floorForm form = new floorForm(Storage.building.Count + 1, Int32.Parse(comboBoxMapSize.SelectedItem.ToString().Substring(0, 2)) - 2,
               Int32.Parse(comboBoxMapSize.SelectedItem.ToString().Substring(comboBoxMapSize.SelectedItem.ToString().Length - 2)), null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                comboBoxMapSize.Enabled = false;
                comboBoxFloorsList.Items.Add("Этаж № " + (Storage.building.Count).ToString());
                try
                {
                    comboBoxFloorsList.SelectedIndex = Storage.building.Count - 1;
                }
                catch
                {
                    comboBoxFloorsList.SelectedIndex = 0;
                }
                buttonSaveBuilding.Enabled = true;
            }
        }
        private void buttonChangeFloor_Click(object sender, EventArgs e)
        {
            if (comboBoxFloorsList.SelectedIndex > -1)
            {
                floorForm form = new floorForm(comboBoxFloorsList.SelectedIndex + 1, Int32.Parse(comboBoxMapSize.SelectedItem.ToString().Substring(0, 2)) - 2,
               Int32.Parse(comboBoxMapSize.SelectedItem.ToString().Substring(comboBoxMapSize.SelectedItem.ToString().Length - 2)), Storage.building[comboBoxFloorsList.SelectedIndex]);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    buttonSaveBuilding.Enabled = true;
                }
            }
            else
                MessageBox.Show("Неверно выбран этаж");
        }
        private void buttonSaveBuilding_Click(object sender, EventArgs e)
        {
            BuildingNameForm form = new BuildingNameForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Close();
                Saver.clearBuildingInfo();
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.OK;
        }
    }
}
