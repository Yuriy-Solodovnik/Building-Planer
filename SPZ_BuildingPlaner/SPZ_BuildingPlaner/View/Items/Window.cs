using System.Windows.Forms;
using System.Drawing;

namespace SPZ_BuildingPlaner
{
    class Window : PictureBox
    {
        public Window(int x, int y, int block)
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            Size = new Size(block - 1, block - 1);
            Location = new Point(x, y);
            Image = Properties.Resources.window;
        }
    }
}
