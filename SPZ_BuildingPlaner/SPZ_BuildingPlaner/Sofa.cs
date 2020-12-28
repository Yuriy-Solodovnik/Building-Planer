using System.Windows.Forms;
using System.Drawing;

namespace SPZ_BuildingPlaner
{
    class Sofa : PictureBox
    {
        public Sofa(int x, int y, int block)
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            Size = new Size(block*8-1, block*4-1);
            Location = new Point(x, y);
            Image = Properties.Resources.sofa;
        }
    }
}