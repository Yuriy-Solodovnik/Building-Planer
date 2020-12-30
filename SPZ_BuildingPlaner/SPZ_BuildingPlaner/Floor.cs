using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ_BuildingPlaner
{
    public class Floor
    {
        int _size, _block;
        public Block[,] blocks; 
        public Floor(int size, int block)
        {
            _size = size;
            _block = block;
            blocks = new Block[size, size];
            for(int i = 0; i < _size; i += 1)
            {
                for (int j = 0; j < _size; j += 1)
                {
                    blocks[i, j] = new Block()
                    {
                        Avaliable = true,
                        Location = new Point(i * _block + 31, j * _block + 31)
                    };
                }
            }
        }
        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
            }
        }
        public int Block
        {
            get
            {
                return _block;
            }
            set
            {
            }
        }
    }
}
