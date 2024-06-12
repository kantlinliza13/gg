using System;
using System.IO;
using System.Windows.Forms;

namespace gg
{
    public partial class sovmestimost : Form
    {
        public sovmestimost()
        {
            InitializeComponent();
        }

        string man, woman;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem)
            {
                case "Овен":
                    woman = "oven";
                    break;

                case "Телец":
                    woman = "telets";
                    break;

                case "Близнецы":
                    woman = "bliznetsy" +
                        "";
                    break;

                case "Рак":
                    woman = "rak";
                    break;

                case "Лев":
                    woman = "lev";
                    break;

                case "Дева":
                    woman = "deva";
                    break;

                case "Весы":
                    woman = "vesi";
                    break;

                case "Скорпион":
                    woman = "skorpion";
                    break;

                case "Стрелец":
                    woman = "strelec";
                    break;

                case "Козерог":
                    woman = "kozerog";
                    break;

                case "Водолей":
                    woman = "vodoley";
                    break;

                case "Рыбы":
                    woman = "ribi";
                    break;
            }

            switch (comboBox1.SelectedItem)
            {
                case "Овен":
                    man = "oven";
                    break;

                case "Телец":
                    man = "telets";
                    break;

                case "Близнецы":
                    man = "bliznetsy" +
                        "";
                    break;

                case "Рак":
                    man = "rak";
                    break;

                case "Лев":
                    man = "lev";
                    break;

                case "Дева":
                    man = "deva";
                    break;

                case "Весы":
                    man = "vesi";
                    break;

                case "Скорпион":
                    man = "skorpion";
                    break;

                case "Стрелец":
                    man = "strelec";
                    break;

                case "Козерог":
                    man = "kozerog";
                    break;

                case "Водолей":
                    man = "vodoley";
                    break;

                case "Рыбы":
                    man = "ribi";
                    break;
            }

            textBox1.Text = File.ReadAllText($@"C:\sovmestimost\{woman}\{man}\{woman}{man}drujba.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem)
            {
                case "Овен":
                    woman = "oven";
                    break;

                case "Телец":
                    woman = "telets";
                    break;

                case "Близнецы":
                    woman = "bliznetsy" +
                        "";
                    break;

                case "Рак":
                    woman = "rak";
                    break;

                case "Лев":
                    woman = "lev";
                    break;

                case "Дева":
                    woman = "deva";
                    break;

                case "Весы":
                    woman = "vesi";
                    break;

                case "Скорпион":
                    woman = "skorpion";
                    break;

                case "Стрелец":
                    woman = "strelec";
                    break;

                case "Козерог":
                    woman = "kozerog";
                    break;

                case "Водолей":
                    woman = "vodoley";
                    break;

                case "Рыбы":
                    woman = "ribi";
                    break;
            }

            switch (comboBox1.SelectedItem)
            {
                case "Овен":
                    man = "oven";
                    break;

                case "Телец":
                    man = "telets";
                    break;

                case "Близнецы":
                    man = "bliznetsy" +
                        "";
                    break;

                case "Рак":
                    man = "rak";
                    break;

                case "Лев":
                    man = "lev";
                    break;

                case "Дева":
                    man = "deva";
                    break;

                case "Весы":
                    man = "vesi";
                    break;

                case "Скорпион":
                    man = "skorpion";
                    break;

                case "Стрелец":
                    man = "strelec";
                    break;

                case "Козерог":
                    man = "kozerog";
                    break;

                case "Водолей":
                    man = "vodoley";
                    break;

                case "Рыбы":
                    man = "ribi";
                    break;
            }

            textBox1.Text = File.ReadAllText($@"C:\sovmestimost\{woman}\{man}\{woman}{man}love.txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            this.Hide();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem)
            {
                case "Овен":
                    woman = "oven";
                    break;

                case "Телец":
                    woman = "telets";
                    break;

                case "Близнецы":
                    woman = "bliznetsy" +
                        "";
                    break;

                case "Рак":
                    woman = "rak";
                    break;

                case "Лев":
                    woman = "lev";
                    break;

                case "Дева":
                    woman = "deva";
                    break;

                case "Весы":
                    woman = "vesi";
                    break;

                case "Скорпион":
                    woman = "skorpion";
                    break;

                case "Стрелец":
                    woman = "strelec";
                    break;

                case "Козерог":
                    woman = "kozerog";
                    break;

                case "Водолей":
                    woman = "vodoley";
                    break;

                case "Рыбы":
                    woman = "ribi";
                    break;
            }

            switch (comboBox1.SelectedItem)
            {
                case "Овен":
                    man = "oven";
                    break;

                case "Телец":
                    man = "telets";
                    break;

                case "Близнецы":
                    man = "bliznetsy" +
                        "";
                    break;

                case "Рак":
                    man = "rak";
                    break;

                case "Лев":
                    man = "lev";
                    break;

                case "Дева":
                    man = "deva";
                    break;

                case "Весы":
                    man = "vesi";
                    break;

                case "Скорпион":
                    man = "skorpion";
                    break;

                case "Стрелец":
                    man = "strelec";
                    break;

                case "Козерог":
                    man = "kozerog";
                    break;

                case "Водолей":
                    man = "vodoley";
                    break;

                case "Рыбы":
                    man = "ribi";
                    break;
            }

            textBox1.Text = File.ReadAllText($@"C:\sovmestimost\{woman}\{man}\{woman}{man}work.txt");
        }
    }
}
