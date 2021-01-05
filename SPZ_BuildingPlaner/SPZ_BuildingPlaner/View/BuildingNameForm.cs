using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SPZ_BuildingPlaner
{
    public partial class BuildingNameForm : MetroForm
    {
        public BuildingNameForm()
        {
            InitializeComponent();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (Saver.save(textBoxBuildingName.Text))
            {
                Close();
                DialogResult = DialogResult.OK;
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
