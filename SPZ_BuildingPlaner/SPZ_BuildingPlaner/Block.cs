using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ_BuildingPlaner
{
    public class Block
    {
        public Block()
        {
            Content = null;
            Avaliable = true;
        }
        public bool Avaliable { get; set; }
        public Point Location { get; set; }
        public PictureBox Content {get; set;}
    }
}
