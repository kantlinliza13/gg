using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gg
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            harakteristika form = new harakteristika();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sovmestimost form = new sovmestimost();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            main form = new main();
            form.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
