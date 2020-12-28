using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ_BuildingPlaner
{
    public class Block
    {
        public bool Avaliable { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public PictureBox Content {get; set;}
    }
}
