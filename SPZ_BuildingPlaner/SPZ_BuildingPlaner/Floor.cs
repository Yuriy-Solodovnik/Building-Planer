using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ_BuildingPlaner
{
    class Floor
    {
        int _size, _block;
        public Block[,] blocks; 
        public Floor(int size, int block)
        {
            _size = size;
            _block = block;
            blocks = new Block[size, size];
            for(int i = 1; i <= _size; i += 1)
            {
                for (int j = 1; j <= _size; j += 1)
                {
                    blocks[i-1, j-1] = new Block()
                    { 
                        Avaliable = true,
                        X = i * _block + 31,
                        Y = j * _block + 31
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
