using System.Windows.Forms;
using System.Drawing;

namespace SPZ_BuildingPlaner
{
    class Table : PictureBox
    {
        public Table(int x, int y, int block)
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            Size = new Size(block*3 - 1, block*3 - 1);
            Location = new Point(x, y);
            Image = Properties.Resources.table;
        }
    }
}
