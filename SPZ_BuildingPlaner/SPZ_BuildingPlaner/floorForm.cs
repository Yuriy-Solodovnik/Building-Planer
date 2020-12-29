using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using MetroFramework.Forms;

namespace SPZ_BuildingPlaner
{
    public partial class floorForm : MetroForm
    {
        PictureBox currentItem = null;
        PictureBox selectedPicture;
        List<Wall> walls;
        int _size, _block, X, Y;
        public floorForm(int size, int block)
        {
            InitializeComponent();
            MaximizeBox = false;
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
            Sofa s = new Sofa(61, 61, _block);
            Floor f = new Floor(size, block);
            createField();
            Controls.Add(selectedPicture);
            comboBoxItems.SelectedIndex = 0;
            comboBoxItems.DropDownStyle = ComboBoxStyle.DropDownList;
            selectedPicture.MouseMove += floorForm_MouseMove;
            selectedPicture.MouseDown += SelectedPicture_Click;
            MouseClick += FloorForm_MouseClick;
            KeyDown += new KeyEventHandler(key_Click);
            KeyPreview = true;
        }
        void createField()
        {
            /*for (int i = 0; i <= _size * _block + 0; i += _block)
            {
                Controls.Add(createLine(0, i, _size * _block, 1));
            }
            for (int j = 0; j <= _size * _block + 0; j += _block)
            {
                Controls.Add(createLine(j, 0, 1, _size * _block));
            }*/
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
            if(walls.Count > 0)
                switch (e.KeyCode)
                {
                    case Keys.W:
                        Wall nww = new Wall(walls[walls.Count - 1].Location.X, walls[walls.Count - 1].Location.Y - _block, _block);
                        nww.MouseMove += floorForm_MouseMove;
                        nww.MouseClick += FloorForm_MouseClick;
                        walls.Add(nww);
                        Controls.Add(nww);
                        this.Update();
                        break;
                    case Keys.S:
                        Wall nws = new Wall(walls[walls.Count - 1].Location.X, walls[walls.Count - 1].Location.Y + _block, _block);
                        nws.MouseMove += floorForm_MouseMove;
                        nws.MouseClick += FloorForm_MouseClick;
                        walls.Add(nws);
                        Controls.Add(nws);
                        this.Update();
                        break;
                    case Keys.A:
                        Wall nwa = new Wall(walls[walls.Count - 1].Location.X - _block, walls[walls.Count - 1].Location.Y, _block);
                        nwa.MouseMove += floorForm_MouseMove;
                        nwa.MouseClick += FloorForm_MouseClick;
                        walls.Add(nwa);
                        Controls.Add(nwa);
                        this.Update();
                        break;
                    case Keys.D:
                        Wall nwd = new Wall(walls[walls.Count - 1].Location.X + _block, walls[walls.Count - 1].Location.Y, _block);
                        nwd.MouseMove += floorForm_MouseMove;
                        nwd.MouseClick += FloorForm_MouseClick;
                        walls.Add(nwd);
                        Controls.Add(nwd);
                        this.Update();
                        break;
                    case Keys.R:
                        if (currentItem != null)
                        {
                            currentItem.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            if (currentItem.Width != currentItem.Height)
                            {
                                int temp = currentItem.Width;
                                currentItem.Width = currentItem.Height;
                                currentItem.Height = temp;
                            }
                            currentItem.Refresh();
                            this.Update();
                        }
                        break;
            }
        }
        private void floorForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentItem != null)
            {
                X = Cursor.Position.X-20;
                Y = Cursor.Position.Y-45;
                currentItem.GetType().GetProperty("Location").SetValue(currentItem, new Point(X, Y));
            }
        }
        private void FloorForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentItem != null && e.Button.ToString() == "Right" && (currentItem.Location.X > 30 && currentItem.Location.X <= _block * _size +31)
                && (currentItem.Location.Y > 30  && currentItem.Location.Y <= _block * _size + 31))
            {
                currentItem.Location = new Point((X) - ((X-31) % _block),
                    (Y) - ((Y-31) % _block));
                currentItem = null;
                Cursor.Show();
            }
        }

        private void SelectedPicture_Click(object sender, EventArgs e)
        {
            if(currentItem == null)
            {
                switch (comboBoxItems.SelectedIndex)
                {
                    case 0:
                        Wall w = new Wall(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = w;
                        w.MouseMove += floorForm_MouseMove;
                        w.MouseClick += FloorForm_MouseClick;
                        Controls.Add(w);
                        walls.Add(w);
                        break;
                    case 1:
                        Window win = new Window(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = win;
                        win.MouseMove += floorForm_MouseMove;
                        win.MouseClick += FloorForm_MouseClick;
                        Controls.Add(win);
                        break;
                    case 2:
                        Door d = new Door(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = d;
                        d.MouseMove += floorForm_MouseMove;
                        d.MouseClick += FloorForm_MouseClick;
                        Controls.Add(d);
                        break;
                    case 3:
                        Sofa s = new Sofa(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = s;
                        s.MouseMove += floorForm_MouseMove;
                        s.MouseClick += FloorForm_MouseClick;
                        Controls.Add(s);
                        break;
                    case 4:
                        MyChair c = new MyChair(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = c;
                        c.MouseMove += floorForm_MouseMove;
                        c.MouseClick += FloorForm_MouseClick;
                        Controls.Add(c);
                        break;
                    case 5:
                        Table t = new Table(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = t;
                        t.MouseMove += floorForm_MouseMove;
                        t.MouseClick += FloorForm_MouseClick;
                        Controls.Add(t);
                        break;
                }
                Cursor.Hide();
            }
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
