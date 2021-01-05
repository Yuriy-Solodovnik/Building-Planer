using MetroFramework.Forms;
using System;

namespace SPZ_BuildingPlaner
{
    public partial class OpenBuildingForm : MetroForm
    {
        int currentFloor;
        public OpenBuildingForm()
        {
            InitializeComponent();
            currentFloor = 1;
        }
        private bool checkFloor(int floor)
        {
            if (floor > 0 && floor <= Saver.getBuildingInfoLength())
                return true;
            else
                return false;
        }
        private void buttonFloorDown_Click(object sender, EventArgs e)
        {
            if(checkFloor(currentFloor - 1))
            {
                currentFloor--;
                pictureBoxFloorContent.Image = Saver.getFromBuildingInfo(currentFloor-1);
                labelFloor.Text = "Этаж № " + currentFloor.ToString();
            }
        }
        private void OpenBuildingForm_Load(object sender, EventArgs e)
        {
            if (Saver.getFromBuildingInfo(currentFloor-1) != null)
            {
                pictureBoxFloorContent.Image = Saver.getFromBuildingInfo(currentFloor-1);
                labelFloor.Text = "Этаж № " + currentFloor.ToString();
            }
        }
        private void buttonFloorUp_Click(object sender, EventArgs e)
        {
            if (checkFloor(currentFloor + 1))
            {
                currentFloor++;
                pictureBoxFloorContent.Image = Saver.getFromBuildingInfo(currentFloor-1);
                labelFloor.Text = "Этаж № " + currentFloor.ToString();
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Saver.clearBuildingInfo();
            Close();
        }
    }
}
