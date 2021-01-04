using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Serialization;
using System.ComponentModel;
using Microsoft.VisualBasic.Compatibility.VB6;

namespace SPZ_BuildingPlaner
{
    [DataContract]
    class Wall : PictureBox
    {
        public Wall(int x, int y, int block)
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            Size = new Size(block-1, block-1);
            Location = new Point(x, y);
            Image = Properties.Resources.wall;
        }
    }
}
