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
            comboBoxMapSize.SelectedIndex = 0;
            MaximizeBox = false;
           

        }

        private void addFloorBtn_Click(object sender, EventArgs e)
        {
            var form = new floorForm(Int32.Parse(comboBoxMapSize.SelectedItem.ToString().Substring(0, 2))-2,
                Int32.Parse(comboBoxMapSize.SelectedItem.ToString().Substring(comboBoxMapSize.SelectedItem.ToString().Length - 2)));
            form.ShowDialog();
            if(DialogResult == DialogResult.OK)
            {
                comboBoxMapSize.Enabled = true;
            }
        }
    }
}
