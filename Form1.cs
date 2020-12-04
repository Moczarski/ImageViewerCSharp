using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad2_Mateusz_Moczarski
{
    public partial class Form1 : Form
    {
        Image image;
        double zoom = 1;
        string path;
        private int x;
        private int y;
        private bool dragged;

        public Form1()
        {
            InitializeComponent();
            this.pictureBox.MouseWheel += ZoomMouse;
        }

        private void OpenDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
            DialogResult result = openFolderDialog.ShowDialog();
            string pathToDir = openFolderDialog.SelectedPath;
            
            try
            {
                ImageList images = new ImageList
                {
                    ImageSize = new Size(50, 50)
                };

                string[] imagePath;
                imagePath = Directory.GetFiles(pathToDir);

                foreach (string temp in imagePath)
                {
                    images.Images.Add(Image.FromFile(temp));
                }

                listView.SmallImageList = images;

                int i = 0;

                foreach (string temp in imagePath)
                {
                    listView.Items.Add(temp, i);
                    i++;
                }
            } catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
                    
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" + "All files (*.*)|*.*";
                string file = openFileDialog1.FileName;
                path = file;
                Open(path);
            }
        }

        private void Open(string image)
        {
            try
            {
                if (System.IO.Path.GetExtension(image) == ".bmp" || System.IO.Path.GetExtension(image) == ".png" || System.IO.Path.GetExtension(image) == ".jpg" || System.IO.Path.GetExtension(image) == ".gif")
                {
                    this.path = image;
                    this.image = Image.FromFile(image);
                    Bitmap bmp = new Bitmap(this.image, Convert.ToInt32(pictureBox.Width * zoom), Convert.ToInt32(pictureBox.Height * zoom));
                    Graphics g = Graphics.FromImage(bmp);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    pictureBox.Image = bmp;
                    this.image = bmp;
                    toolStripStatusLabel1.Text = "Otwarto: " + path;
                }
                else
                {
                    toolStripStatusLabel1.Text = "Wybierz plik GIF JPG BMP PNG!";
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Problem z plikiem!" + ex;
            }
        }

        private void RotateToLeft(object sender, EventArgs e)
        {
            if (image != null)
            {
                image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox.Image = image;
            }
        }

        private void RotateToRight(object sender, EventArgs e)
        {
            if (image != null)
            {
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox.Image = image;
            }
        }

        private void ZoomMouse(object sender, MouseEventArgs e)
        {
            if(e.Delta > 0)
            {
                if (pictureBox.Image != null)
                {
                    if (zoom < 2) zoom += 0.05;
                    Open(path);
                }
            } else
            {
                if (pictureBox.Image != null)
                {
                    if (zoom > 0.5) zoom -= 0.05;
                    Open(path);
                }
            }
        }

        private void ZoomPlus(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                if (zoom < 3) zoom += 0.1;
                Open(path);
            }
        }

        private void ZoomMinus(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                if (zoom > 0.5) zoom -= 0.1;
                Open(path);
            }
        }

        private void ChangeSize(object sender, EventArgs e)
        {
            Open(path);
        }

        private void ImgDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            dragged = true;
            x = e.X;
            y = e.Y;
        }

        private void ImgMove(object sender, MouseEventArgs e)
        {
            if (!dragged || !(sender is PictureBox c)) return;
            c.Top = e.Y + c.Top - y;
            c.Left = e.X + c.Left - x;
        }

        private void ImgUp(object sender, MouseEventArgs e)
        {
            if (!(sender is PictureBox)) return;
            dragged = false;
        }

        private void SelectImage(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string path = listView.SelectedItems[0].Text;
                Open(path);
            }
        }
    }
}
