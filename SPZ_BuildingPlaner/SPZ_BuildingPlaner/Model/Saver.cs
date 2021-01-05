using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SPZ_BuildingPlaner
{
    public static class Saver
    {
        static List<Bitmap> buildingInfo = new List<Bitmap>();
        public static Bitmap getScreanShoot(int margine, int size)
        {
            Bitmap printscreen = new Bitmap(size+1, size+1);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(margine, margine, 0, 0, new Size(size+1, size+1));
            return printscreen;
        }
        public static int getBuildingInfoLength()
        {
            return buildingInfo.Count;
        }
        public static void clearBuildingInfo()
        {
            buildingInfo.Clear();
        }
        public static Bitmap getFromBuildingInfo(int index)
        {
            try
            {
                return buildingInfo[index];
            }
            catch
            {
                return null;
            }
        }
        public static void update(int index, Bitmap printscreen)
        {
            buildingInfo[index] = printscreen;
        }
        public static void insret(Bitmap printscreen)
        {
            buildingInfo.Add(printscreen);
        }
        public static bool open()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Выберите путь для открытия проекта";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                int buildingSize = new DirectoryInfo(fbd.SelectedPath).GetFiles().Length;
                try
                {
                    for (int i = 1; i <= buildingSize; i++)
                    {
                        buildingInfo.Add(new Bitmap($@"{fbd.SelectedPath}\Floor_№ {i}.jpg"));
                    }
                    return true;
                }
                catch
                {
                    MessageBox.Show("Ошибка открытия файла");
                    return false;
                }
            }
            return false;
        }
        public static bool save(string name)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Выберите путь для сохранения проекта";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(fbd.SelectedPath + name);
                try
                {
                    if (!dirInfo.Exists)
                    {
                        dirInfo.Create();
                        foreach (var i in buildingInfo)
                        {
                            i.Save($@"{dirInfo.FullName}\Floor_№ {buildingInfo.IndexOf(i) + 1}.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Файл уже существует. Выберите другой");
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка доступа");
                    return false;
                }
            }
            return false;
        }
    }
}
