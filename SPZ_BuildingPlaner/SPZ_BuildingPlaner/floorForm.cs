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
        Floor f;    
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
                Location = new Point(comboBoxItems.Location.X, comboBoxItems.Location.Y + 30),
                Cursor = Cursors.Hand
            };
            Sofa s = new Sofa(61, 61, _block);
            f = new Floor(size, block);
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
            for (int i = 30; i <= _size * _block + 30; i += _block)
            {
                Controls.Add(createLine(30, i, _size * _block, 1));
            }
            for (int j = 30; j <= _size * _block + 30; j += _block)
            {
                Controls.Add(createLine(j, 30, 1, _size * _block));
            }
        }
        private void takePosition(int width, int height, Point position)
        {
            ValueTuple<int, int> index = getIndex(position);
            if (f.blocks[index.Item1, index.Item2].Location == position)
            {
                for (int k = 0; k < (width + 1) / _block; k += 1)
                {
                    for (int l = 0; l < (height + 1) / _block; l += 1)
                    {
                        f.blocks[index.Item1 + k, index.Item2 + l].Avaliable = false;
                    }
                }
                
            }
        }
        private ValueTuple<int, int> getIndex(Point position)
        {
            ValueTuple<int, int> index = (
                         from i in Enumerable.Range(0, _size)
                         from j in Enumerable.Range(0, _size)
                         where f.blocks[i, j].Location == position
                         select (i, j)
                         ).FirstOrDefault();
            return index;
        }
        private bool checkPosition(int width, int height, Point position)
        {
            ValueTuple<int, int> index = getIndex(position);
            for (int k = 0; k < (width + 1) / _block; k += 1)
            {
                for (int l = 0; l < (height + 1) / _block; l += 1)
                {
                    if (f.blocks[index.Item1 + k, index.Item2 + l].Avaliable == false)
                        return false;
                }
            }
            return true;
        }
        private void addFloorBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedPicture.Size = new Size(100, 100);
            switch (comboBoxItems.SelectedIndex)
            {
                case 0:
                        selectedPicture.Image = Properties.Resources.wall;
                        break;
                case 1:
                        selectedPicture.Image = Properties.Resources.window;
                        break;
                case 2:
                        selectedPicture.Size = new Size(100, 50);
                        selectedPicture.Image = Properties.Resources.door;
                        break;
                case 3:
                        selectedPicture.Image = Properties.Resources.sofa;
                        selectedPicture.Size = new Size(99, 47);
                        break;
                case 4:
                        selectedPicture.Image = Properties.Resources.mychair;
                        break;
                case 5:
                        selectedPicture.Image = Properties.Resources.table;
                        break;
                case 6:
                        selectedPicture.Size = new Size(66, 99);
                        selectedPicture.Image = Properties.Resources.cupboard;
                        break;
                case 7:
                        selectedPicture.Image = Properties.Resources.fridge;
                        break;
                case 8:
                        selectedPicture.Image = Properties.Resources.plate;
                        break;
                case 9:
                        selectedPicture.Image = Properties.Resources.sink;
                        break;
                case 10:
                        selectedPicture.Image = Properties.Resources.kitchenTable;
                        break;
                case 11:
                        selectedPicture.Size = new Size(66, 99);
                        selectedPicture.Image = Properties.Resources.bath;
                        break;
                case 12:
                        selectedPicture.Image = Properties.Resources.toilet;
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
            if (currentItem != null && e.Button.ToString() == "Right" && (currentItem.Location.X > 30 
                && currentItem.Location.X <= _block * _size - currentItem.Size.Width + 31)
                && (currentItem.Location.Y > 30  && currentItem.Location.Y <= _block * _size - currentItem.Size.Height + 31))
            {
                currentItem.Location = new Point(X - ((X-31) % _block), Y - ((Y-31) % _block));
                if (checkPosition(currentItem.Size.Width, currentItem.Size.Height, currentItem.Location))
                {
                    takePosition(currentItem.Size.Width, currentItem.Size.Height, currentItem.Location);
                    currentItem = null;
                    Cursor.Show();
                }
            }
        }
        private void SelectedPicture_Click(object sender, EventArgs e)
        {
            if(currentItem == null)
            {
                switch (comboBoxItems.SelectedIndex)
                {
                    case 0:
                        Wall wall = new Wall(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = wall;
                        wall.MouseMove += floorForm_MouseMove;
                        wall.MouseClick += FloorForm_MouseClick;
                        Controls.Add(wall);
                        walls.Add(wall);
                        break;
                    case 1:
                        Window window = new Window(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = window;
                        window.MouseMove += floorForm_MouseMove;
                        window.MouseClick += FloorForm_MouseClick;
                        Controls.Add(window);
                        break;
                    case 2:
                        Door door = new Door(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = door;
                        door.MouseMove += floorForm_MouseMove;
                        door.MouseClick += FloorForm_MouseClick;
                        Controls.Add(door);
                        break;
                    case 3:
                        Sofa sofa = new Sofa(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = sofa;
                        sofa.MouseMove += floorForm_MouseMove;
                        sofa.MouseClick += FloorForm_MouseClick;
                        Controls.Add(sofa);
                        break;
                    case 4:
                        MyChair chair = new MyChair(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = chair;
                        chair.MouseMove += floorForm_MouseMove;
                        chair.MouseClick += FloorForm_MouseClick;
                        Controls.Add(chair);
                        break;
                    case 5:
                        Table table = new Table(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = table;
                        table.MouseMove += floorForm_MouseMove;
                        table.MouseClick += FloorForm_MouseClick;
                        Controls.Add(table);
                        break;
                    case 6:
                        Cupboard cupboard = new Cupboard(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = cupboard;
                        cupboard.MouseMove += floorForm_MouseMove;
                        cupboard.MouseClick += FloorForm_MouseClick;
                        Controls.Add(cupboard);
                        break;
                    case 7:
                        Fridge fridge = new Fridge(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = fridge;
                        fridge.MouseMove += floorForm_MouseMove;
                        fridge.MouseClick += FloorForm_MouseClick;
                        Controls.Add(fridge);
                        break;
                    case 8:
                        Plate plate = new Plate(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = plate;
                        plate.MouseMove += floorForm_MouseMove;
                        plate.MouseClick += FloorForm_MouseClick;
                        Controls.Add(plate);
                        break;
                    case 9:
                        Sink sink = new Sink(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = sink;
                        sink.MouseMove += floorForm_MouseMove;
                        sink.MouseClick += FloorForm_MouseClick;
                        Controls.Add(sink);
                        break;
                    case 10:
                        KitchenTable kTable = new KitchenTable(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = kTable;
                        kTable.MouseMove += floorForm_MouseMove;
                        kTable.MouseClick += FloorForm_MouseClick;
                        Controls.Add(kTable);
                        break;
                    case 11:
                        Bath bath = new Bath(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = bath;
                        bath.MouseMove += floorForm_MouseMove;
                        bath.MouseClick += FloorForm_MouseClick;
                        Controls.Add(bath);
                        break;
                    case 12:
                        Toilet toilet = new Toilet(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = toilet;
                        toilet.MouseMove += floorForm_MouseMove;
                        toilet.MouseClick += FloorForm_MouseClick;
                        Controls.Add(toilet);
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
