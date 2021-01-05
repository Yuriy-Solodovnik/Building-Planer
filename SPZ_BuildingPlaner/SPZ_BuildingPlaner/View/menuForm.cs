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
    public partial class menuForm : MetroForm
    {
        public menuForm()
        {
            InitializeComponent();
        }
        private void addBuildingBtn_Click(object sender, EventArgs e)
        {
            BuildingForm form = new BuildingForm();
            form.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
            }
        }
        private void buttonDeserializeBuilding_Click(object sender, EventArgs e)
        {
            if (Saver.open())
            {
                OpenBuildingForm form = new OpenBuildingForm();
                form.ShowDialog();
                if (DialogResult == DialogResult.OK)
                {
                }
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
