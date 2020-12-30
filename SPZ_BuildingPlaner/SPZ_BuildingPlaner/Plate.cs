using System.Windows.Forms;
using System.Drawing;

namespace SPZ_BuildingPlaner
{
    class Plate : PictureBox
    {
        public Plate(int x, int y, int block)
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            Size = new Size(block * 2 - 1, block*2 - 1);
            Location = new Point(x, y);
            Image = Properties.Resources.plate;
        }
    }
}
