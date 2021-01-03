using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
namespace SPZ_BuildingPlaner
{
    public partial class menuForm : MetroForm
    {
        public menuForm()
        {
            InitializeComponent();
            MaximizeBox = false;
           

        }

        private void addBuildingBtn_Click(object sender, EventArgs e)
        {
            var form = new BuildingForm();
            form.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
            }
        }
    }
}
