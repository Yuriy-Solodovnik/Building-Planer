using System.Windows.Forms;
using System.Drawing;

namespace SPZ_BuildingPlaner
{
    class Flower : PictureBox
    {
        public Flower(int x, int y, int block)
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            Size = new Size(block - 1, block - 1);
            Location = new Point(x, y);
            Image = Properties.Resources.flower;
        }
    }
}