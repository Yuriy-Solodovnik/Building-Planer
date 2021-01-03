using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MetroFramework.Forms;

namespace SPZ_BuildingPlaner
{
    public partial class floorForm : MetroForm
    {
        PictureBox currentItem = null;
        PictureBox selectedPicture;
        Floor f;    
        const int _margine = 60;
        int _size, _block, floorNumber, X, Y;
        bool _change = false;
        public floorForm(int floorNumber, int size, int block, Floor floor)
        {
            InitializeComponent();
            this.floorNumber = floorNumber;
            labelFloorNumber.Text = "Этаж № " + (this.floorNumber).ToString();
            _size = size;
            _block = block;
            if (floor != null)
            {
                _change = true;
                f = floor;
                read(f);
                addFloorBtn.Text = "Изменить";
            }
            else
                f = new Floor(size, block, _margine);
            selectedPicture = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(comboBoxItems.Location.X, comboBoxItems.Location.Y + 30),
                Cursor = Cursors.Hand
            };
            MaximizeBox = false;
            Controls.Add(selectedPicture);
            comboBoxItems.SelectedIndex = 0;
            comboBoxItems.DropDownStyle = ComboBoxStyle.DropDownList;
            selectedPicture.MouseMove += floorForm_MouseMove;
            selectedPicture.MouseClick += SelectedPicture_Click;
            MouseClick += FloorForm_MouseClick;
            KeyDown += new KeyEventHandler(key_Click);
            KeyPreview = true;
            createField();
        }
        private void read(Floor f)
        {
            foreach (Block i in f.blocks)
            {
                if(i.Content!=null)
                {
                    var item = i.Content;
                    takePosition(item);
                    item.BringToFront();
                    Controls.Add(item);
                }
            }
        }
        private void createField()
        {
            for (int i = _margine; i <= _size * _block + _margine; i += _block)
            {
                Controls.Add(createLine(_margine, i, _size * _block, 1));
            }
            for (int j = _margine; j <= _size * _block + _margine; j += _block)
            {
                Controls.Add(createLine(j, _margine, 1, _size * _block));
            }
        }
        private void takePosition(PictureBox item)
        {
            ValueTuple<int, int> index = getIndex(item.Location);
            if (f.blocks[index.Item1, index.Item2].Location == item.Location)
            {
                for (int k = 0; k < (item.Size.Width + 1) / _block; k += 1)
                {
                    for (int l = 0; l < (item.Size.Height + 1) / _block; l += 1)
                    {
                        f.blocks[index.Item1 + k, index.Item2 + l].Avaliable = false;
                    }
                }
                f.blocks[index.Item1, index.Item2].Content = item;
                f.blocks[index.Item1, index.Item2].Content.MouseClick += Content_MouseClick;
                f.blocks[index.Item1, index.Item2].Content.MouseMove += floorForm_MouseMove;
                f.blocks[index.Item1, index.Item2].Content.MouseClick += FloorForm_MouseClick;
            }
        }
        private void leavePosition(PictureBox item)
        {
            ValueTuple<int, int> index = getIndex(item.Location);
            if (f.blocks[index.Item1, index.Item2].Location == item.Location)
            {
                for (int k = 0; k < (item.Size.Width + 1) / _block; k += 1)
                {
                    for (int l = 0; l < (item.Size.Height + 1) / _block; l += 1)
                    {
                        f.blocks[index.Item1 + k, index.Item2 + l].Avaliable = true;
                    }
                }
                f.blocks[index.Item1, index.Item2].Content = null;
            }
        }
        private void Content_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentItem == null && e.Button.ToString() == "Left")
            {
                currentItem = sender as PictureBox;
                currentItem.BringToFront();
                Cursor.Hide();
                leavePosition(currentItem);
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
        private async void getErrorProvider(Control contorl)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.SetIconPadding(contorl, -contorl.Width-1);
            errorProvider.SetError(contorl, "No");
            await (Task.Delay(200));
            errorProvider.Clear();
        }
        private bool checkPosition(int width, int height, Point position)
        {
            ValueTuple<int, int> index = getIndex(position);
            if ((position.X > _margine && position.X <= _block * _size - width + _margine+1)
                && (position.Y > _margine && position.Y <= _block * _size - height + _margine+1))
                {
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
            else if((position.X > pictureBoxRecycleBin.Location.X && position.X <= pictureBoxRecycleBin.Location.X + pictureBoxRecycleBin.Size.Width)
                && (position.Y > pictureBoxRecycleBin.Location.Y && position.Y <= pictureBoxRecycleBin.Location.Y + pictureBoxRecycleBin.Size.Height))
                 {
                      if (currentItem.GetType().Name == "Wall")
                        f.walls.Remove(currentItem);
                     Controls.Remove(currentItem);
                     return true;
                 }
            else
                return false;
        }
        private void addFloorBtn_Click(object sender, EventArgs e)
        {
            if (_change)
            {
                Storage.building[floorNumber-1] = f;
            }
            else
                Storage.building.Add(f);
            Close();
            DialogResult = DialogResult.OK;
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
                        selectedPicture.Image = Properties.Resources.nightstand;
                        break;
                case 8:
                        selectedPicture.Image = Properties.Resources.bed;
                        selectedPicture.Size = new Size(66, 99);
                        break;
                case 9:
                        selectedPicture.Image = Properties.Resources.flower;
                        break;
                case 10:
                        selectedPicture.Image = Properties.Resources.fridge;
                        break;
                case 11:
                        selectedPicture.Image = Properties.Resources.plate;
                        break;
                case 12:
                        selectedPicture.Image = Properties.Resources.sink;
                        break;
                case 13:
                        selectedPicture.Image = Properties.Resources.kitchenTable;
                        break;
                case 14:
                        selectedPicture.Size = new Size(66, 99);
                        selectedPicture.Image = Properties.Resources.bath;
                        break;
                case 15:
                        selectedPicture.Image = Properties.Resources.toilet;
                        break;
            }
        }
        private void key_Click(object sender, KeyEventArgs e)
        {
            if(f.walls.Count > 0 && currentItem == null)
            {
                Point newLocation;
                switch (e.KeyCode)
                {
                    case Keys.W:
                        newLocation = new Point(f.walls[f.walls.Count - 1].Location.X, f.walls[f.walls.Count - 1].Location.Y - _block);
                        if (checkPosition(_block - 1, _block - 1, newLocation))
                        {
                            Wall nww = new Wall(newLocation.X, newLocation.Y, _block);
                            nww.MouseMove += floorForm_MouseMove;
                            nww.MouseClick += FloorForm_MouseClick;
                            f.walls.Add(nww);
                            Controls.Add(nww);
                            takePosition(nww);
                        }
                        else
                            getErrorProvider(f.walls[f.walls.Count - 1]);
                        break;
                    case Keys.S:
                        newLocation = new Point(f.walls[f.walls.Count - 1].Location.X, f.walls[f.walls.Count - 1].Location.Y + _block);
                        if (checkPosition(_block - 1, _block - 1, newLocation))
                        {
                            Wall nws = new Wall(newLocation.X, newLocation.Y, _block);
                            nws.MouseMove += floorForm_MouseMove;
                            nws.MouseClick += FloorForm_MouseClick;
                            f.walls.Add(nws);
                            Controls.Add(nws);
                            takePosition(nws);
                        }
                        else
                            getErrorProvider(f.walls[f.walls.Count - 1]);
                        break;
                    case Keys.A:
                        newLocation = new Point(f.walls[f.walls.Count - 1].Location.X - _block, f.walls[f.walls.Count - 1].Location.Y);
                        if (checkPosition(_block - 1, _block - 1, newLocation))
                        {
                            Wall nwa = new Wall(newLocation.X, newLocation.Y, _block);
                            nwa.MouseMove += floorForm_MouseMove;
                            nwa.MouseClick += FloorForm_MouseClick;
                            f.walls.Add(nwa);
                            Controls.Add(nwa);
                            takePosition(nwa);
                        }
                        else
                            getErrorProvider(f.walls[f.walls.Count - 1]);
                        break;
                    case Keys.D:
                        newLocation = new Point(f.walls[f.walls.Count - 1].Location.X + _block, f.walls[f.walls.Count - 1].Location.Y);
                        if (checkPosition(_block - 1, _block - 1, newLocation))
                        {
                            Wall nwd = new Wall(newLocation.X, newLocation.Y, _block);
                            nwd.MouseMove += floorForm_MouseMove;
                            nwd.MouseClick += FloorForm_MouseClick;
                            f.walls.Add(nwd);
                            Controls.Add(nwd);
                            takePosition(nwd);
                        }
                        else
                            getErrorProvider(f.walls[f.walls.Count - 1]);
                        break;
                }
            }
            if (e.KeyCode == Keys.R)
            {
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
                }
            }
        }
        private void floorForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentItem != null)
            {
                X = Cursor.Position.X;
                Y = Cursor.Position.Y;
                currentItem.GetType().GetProperty("Location").SetValue(currentItem, new Point(X, Y));
            }
        }
        private void FloorForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentItem != null && e.Button.ToString() == "Right")
            {
                currentItem.Location = new Point(X - ((X- _margine - 1) % _block), Y - ((Y - _margine - 1) % _block));
                if (checkPosition(currentItem.Size.Width, currentItem.Size.Height, currentItem.Location))
                {
                    takePosition(currentItem);
                    currentItem = null;
                    Cursor.Show();
                }
                else
                    getErrorProvider(currentItem);
            }
        }
        private void SelectedPicture_Click(object sender, MouseEventArgs e)
        {
            if(currentItem == null && e.Button.ToString() == "Left")
            {
                switch (comboBoxItems.SelectedIndex)
                {
                    case 0:
                        Wall wall = new Wall(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = wall;
                        wall.MouseMove += floorForm_MouseMove;
                        wall.MouseClick += FloorForm_MouseClick;
                        Controls.Add(wall);
                        f.walls.Add(wall);
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
                        Nightstand nightstand = new Nightstand(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = nightstand;
                        nightstand.MouseMove += floorForm_MouseMove;
                        nightstand.MouseClick += FloorForm_MouseClick;
                        Controls.Add(nightstand);
                        break;
                    case 8:
                        Bed bed = new Bed(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = bed;
                        bed.MouseMove += floorForm_MouseMove;
                        bed.MouseClick += FloorForm_MouseClick;
                        Controls.Add(bed);
                        break;
                    case 9:
                        Flower flower = new Flower(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = flower;
                        flower.MouseMove += floorForm_MouseMove;
                        flower.MouseClick += FloorForm_MouseClick;
                        Controls.Add(flower);
                        break;
                    case 10:
                        Fridge fridge = new Fridge(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = fridge;
                        fridge.MouseMove += floorForm_MouseMove;
                        fridge.MouseClick += FloorForm_MouseClick;
                        Controls.Add(fridge);
                        break;
                    case 11:
                        Plate plate = new Plate(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = plate;
                        plate.MouseMove += floorForm_MouseMove;
                        plate.MouseClick += FloorForm_MouseClick;
                        Controls.Add(plate);
                        break;
                    case 12:
                        Sink sink = new Sink(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = sink;
                        sink.MouseMove += floorForm_MouseMove;
                        sink.MouseClick += FloorForm_MouseClick;
                        Controls.Add(sink);
                        break;
                    case 13:
                        KitchenTable kTable = new KitchenTable(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = kTable;
                        kTable.MouseMove += floorForm_MouseMove;
                        kTable.MouseClick += FloorForm_MouseClick;
                        Controls.Add(kTable);
                        break;
                    case 14:
                        Bath bath = new Bath(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = bath;
                        bath.MouseMove += floorForm_MouseMove;
                        bath.MouseClick += FloorForm_MouseClick;
                        Controls.Add(bath);
                        break;
                    case 15:
                        Toilet toilet = new Toilet(selectedPicture.Location.X, selectedPicture.Location.Y, _block);
                        currentItem = toilet;
                        toilet.MouseMove += floorForm_MouseMove;
                        toilet.MouseClick += FloorForm_MouseClick;
                        Controls.Add(toilet);
                        break;
                }
                currentItem.BringToFront();
                Cursor.Hide();
            }
        }
        PictureBox createLine(int i, int j, int s1, int s2)
        {
            PictureBox line = new PictureBox
            {
                BackColor = Color.Black,
                Location = new Point(i, j),
                Size = new Size(s1, s2)
            };
            line.MouseMove += floorForm_MouseMove;
            return line;
        }
    }
}
