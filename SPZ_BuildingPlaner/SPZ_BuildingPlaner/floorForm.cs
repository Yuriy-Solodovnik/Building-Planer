using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ_BuildingPlaner
{
    public partial class floorForm : Form
    {
        object currentItem = null;
        PictureBox selectedPicture;
        List<Wall> walls;
        int _size, _block;
        public floorForm(int size, int block)
        {
            InitializeComponent();
            _size = size;
            _block = block;
            walls = new List<Wall>();
            selectedPicture = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(100, 100),
                Location = new Point(comboBoxItems.Location.X, comboBoxItems.Location.Y + 100),
                Cursor = Cursors.Hand
            };
            Wall w = new Wall(_block* 2 + 31, _block*2 + 31, _block);
            Controls.Add(w);
            walls.Add(w);
            Sofa s = new Sofa(61, 61, _block);
            Floor f = new Floor(size, block);
            createField();
            Controls.Add(selectedPicture);
            comboBoxItems.SelectedIndex = 0;
            selectedPicture.MouseDown += SelectedPicture_Click;
            MouseClick += FloorForm_MouseClick;
            KeyDown += new KeyEventHandler(key_Click);
            KeyPreview = true;
        }
        void createField()
        {
            for (int i = 30; i <= _size * _block + 30; i += _block)
            {
                Controls.Add(createLine(30, i, _size * _block, 1));
            }
            for (int j = 30; j <= _size * _block + 30; j += _block)
            {
                Controls.Add(createLine(j, 30, 1, _size * _block));
            }
        }

        private void addFloorBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxItems.SelectedIndex)
            {
                case 0:
                        selectedPicture.Image = Properties.Resources.wall;
                        selectedPicture.Update();
                        break;
                case 1:
                        selectedPicture.Image = Properties.Resources.window;
                        selectedPicture.Update();
                        break;
                case 2:
                        selectedPicture.Image = Properties.Resources.door;
                        selectedPicture.Update();
                        break;
                case 3:
                        selectedPicture.Image = Properties.Resources.sofa;
                        selectedPicture.Update();
                        break;
                case 4:
                        selectedPicture.Image = Properties.Resources.mychair;
                        selectedPicture.Update();
                        break;
                case 5:
                        selectedPicture.Image = Properties.Resources.table;
                        selectedPicture.Update();
                        break;
            }
        }
        private void key_Click(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    Wall nww = new Wall(walls[walls.Count - 1].Location.X, walls[walls.Count - 1].Location.Y- _block, _block);
                    walls.Add(nww);
                    Controls.Add(nww);
                    this.Update();
                    break;
                case Keys.S:
                    Wall nws = new Wall(walls[walls.Count - 1].Location.X, walls[walls.Count - 1].Location.Y + _block, _block);
                    walls.Add(nws);
                    Controls.Add(nws);
                    this.Update();
                    break;
                case Keys.A:
                    Wall nwa = new Wall(walls[walls.Count - 1].Location.X - _block, walls[walls.Count - 1].Location.Y, _block);
                    walls.Add(nwa);
                    Controls.Add(nwa);
                    this.Update();
                    break;
                case Keys.D:
                    Wall nwd = new Wall(walls[walls.Count - 1].Location.X + _block, walls[walls.Count - 1].Location.Y, _block);
                    walls.Add(nwd);
                    Controls.Add(nwd);
                    this.Update();
                    break;
            }
        }
        private void floorForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentItem != null)
                currentItem.GetType().GetProperty("Location").SetValue(currentItem, new Point(Cursor.Position.X -7, Cursor.Position.Y - 30));
        }
        private void FloorForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Right")
                currentItem = null;
        }

        private void SelectedPicture_Click(object sender, EventArgs e)
        {
            currentItem = sender;
        }
        PictureBox createLine(int i, int j, int s1, int s2)
        {
            return new PictureBox
            {
                BackColor = Color.Black,
                Location = new Point(i, j),
                Size = new Size(s1, s2)
            };
        }
    }
}
