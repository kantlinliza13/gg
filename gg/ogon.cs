using System;
using System.Drawing;
using System.Windows.Forms;

namespace gg
{
    public partial class ogon : Form
    {
        public ogon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Rotate the image
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            bitmap.RotateFlip(RotateFlipType.Rotate180FlipY);

            // Add text to the image
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawString("Текст", new Font("Arial", 16), Brushes.Black, new PointF(10, 10));
            }

            // Display the modified image in the picture box
            pictureBox1.Image = bitmap;
            pictureBox1.Invalidate();
        }
    }
}


