using System;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gg
{
    public partial class harakteristika : Form
    {
        public harakteristika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dataRojdenia = int.Parse(textBox2.Text);
            string[] taroFile = File.ReadAllLines(@"C:\sovmestimost\taro.txt");

            switch (dataRojdenia) 
            {
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources._1;
                    textBox1.Text = taroFile[0];
                    break;

                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources._2;
                    textBox1.Text = taroFile[1];
                    break;

                case 3: case 30:
                    pictureBox1.BackgroundImage = Properties.Resources._3_и_30;
                    textBox1.Text = taroFile[2];
                    break;

                case 4: 
                case 31:
                    pictureBox1.BackgroundImage = Properties.Resources._4_и_31;
                    textBox1.Text = taroFile[3];
                    break;

                case 5:
                case 23:
                    pictureBox1.BackgroundImage = Properties.Resources._5_и_23;
                    textBox1.Text = taroFile[4];
                    break;

                case 6:
                case 24:
                    pictureBox1.BackgroundImage = Properties.Resources._6_и_24;
                    textBox1.Text = taroFile[5];
                    break;

                case 7:
                case 25:
                    pictureBox1.BackgroundImage = Properties.Resources._7_и_25;
                    textBox1.Text = taroFile[6];
                    break;

                case 8:
                case 26:
                    pictureBox1.BackgroundImage = Properties.Resources._8_26;
                    textBox1.Text = taroFile[7];
                    break;

                case 9:
                case 27:
                    pictureBox1.BackgroundImage = Properties.Resources._9_и_27;
                    textBox1.Text = taroFile[8];
                    break;

                case 10:
                case 28:
                    pictureBox1.BackgroundImage = Properties.Resources._10_и_28;
                    textBox1.Text = taroFile[9];
                    break;

                case 11:
                case 29:
                    pictureBox1.BackgroundImage = Properties.Resources._11_и_29;
                    textBox1.Text = taroFile[10];
                    break;

                case 12:
                    pictureBox1.BackgroundImage = Properties.Resources._12;
                    textBox1.Text = taroFile[11];
                    break;

                case 13:
                    pictureBox1.BackgroundImage = Properties.Resources._13;
                    textBox1.Text = taroFile[12];
                    break;

                case 14:
                    pictureBox1.BackgroundImage = Properties.Resources._14;
                    textBox1.Text = taroFile[13];
                    break;

                case 15:
                    pictureBox1.BackgroundImage = Properties.Resources._15;
                    textBox1.Text = taroFile[14];
                    break;

                case 16:
                    pictureBox1.BackgroundImage = Properties.Resources._16;
                    textBox1.Text = taroFile[15];
                    break;

                case 17:
                    pictureBox1.BackgroundImage = Properties.Resources._17;
                    textBox1.Text = taroFile[16];
                    break;

                case 18:
                    pictureBox1.BackgroundImage = Properties.Resources._17;
                    textBox1.Text = taroFile[17];
                    break;

                case 19:
                    pictureBox1.BackgroundImage = Properties.Resources._19;
                    textBox1.Text = taroFile[18];
                    break;

                case 20:
                    pictureBox1.BackgroundImage = Properties.Resources._20;
                    textBox1.Text = taroFile[19];
                    break;

                case 21:
                    pictureBox1.BackgroundImage = Properties.Resources._21;
                    textBox1.Text = taroFile[20];
                    break;

                case 22:
                    pictureBox1.BackgroundImage = Properties.Resources._22;
                    textBox1.Text = taroFile[21];
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            this.Hide();
            this.Close();
        }
    }
}
