using System.Windows.Forms;
using System;

namespace gg
{
    public partial class main : Form
    {
        int questionNumber = 1;
        string elementChoice; // Переменная для хранения выбранной стихии

        public main()
        {
            InitializeComponent();
            askQuestion(questionNumber);
        }

        private void checkAnswerevent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (questionNumber == 1)
            {
                switch (buttonTag)
                {
                    case 1:
                        elementChoice = "огонь";
                        break;

                    case 2:
                        elementChoice = "земля";
                        break;

                    case 3:
                        elementChoice = "воздух";
                        break;

                    case 4:
                        elementChoice = "вода";
                        break;
                }

                button5.Text = "Назад";
            }

            if (questionNumber == 9)
            {
                button5.Text = "Заново";
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (questionNumber >= 10)
            {
                questionNumber = 1;
            }
            else
            {
                if (questionNumber != 1)
                {
                    questionNumber--;
                }
            }

            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    lblQuestion.Text = "Какую стихию вы выберете?";
                    button1.Text = "огонь";
                    button2.Text = "земля";
                    button3.Text = "воздух";
                    button4.Text = "вода";
                    break;

                case 2:
                    lblQuestion.Text = "Какое время года вы выберете";
                    button1.Text = "весна";
                    button2.Text = "зима";
                    button3.Text = "лето";
                    button4.Text = "осень";
                    break;

                case 3:
                    lblQuestion.Text = "Какое время суток вы выберете?";
                    button1.Text = "ночь";
                    button2.Text = "день";
                    button3.Text = "утро";
                    button4.Text = "вечер";
                    break;

                case 4:
                    lblQuestion.Text = "Какой вкус вы больше предпочитаете?";
                    button1.Text = "горький";
                    button2.Text = "сладкий";
                    button3.Text = "кислый";
                    button4.Text = "соленый";
                    break;

                case 5:
                    lblQuestion.Text = "Какой темперамент вам ближе?";
                    button1.Text = "меланхолик";
                    button2.Text = "флегматик";
                    button3.Text = "холерик";
                    button4.Text = "сангвиник";
                    break;

                case 6:
                    lblQuestion.Text = "Какие планеты по вашему мнению больше подходят вам?";
                    button1.Text = "марс, солнце, юпитер";
                    button2.Text = "меркурий, венера, уран";
                    button3.Text = "венера, меркурий, сатурн";
                    button4.Text = "луна, марс, нептун";
                    break;

                case 7:
                    lblQuestion.Text = "Какой принцип вам больше подходит??";
                    button1.Text = "обмен, контакт";
                    button2.Text = "стабильность";
                    button3.Text = "постоянство внутреннего при внешней изменчивости";
                    button4.Text = "действие, активность, энергия";
                    break;

                case 8:
                    lblQuestion.Text = "Какая характеристика вам больше откликается?";
                    button1.Text = "практичность, надежность,упорство,трудолюбие,последовательность.";
                    button2.Text = "динамичность, разговорчивость, доброта и оптимистичность, отважность, деятельность, привлекательность.";
                    button3.Text = "чувствительность, доброжелательность, идеализм, общительность, спокойствие.";
                    button4.Text = "здравый смысл, рассудительность. объективность, приспособляемость, беспристрастность.";
                    break;

                case 9:
                    lblQuestion.Text = " Какая особенность вам больше подходит?";
                    button1.Text = "холод и влажность";
                    button2.Text = "тепло и влажность";
                    button3.Text = "холод и сухость";
                    button4.Text = "тепло и сухость";
                    break;

                case 10:

                    if (elementChoice == "огонь")
                    {
                        ogon form = new ogon();
                        form.Show();
                    }
                    else if (elementChoice == "вода")
                    {
                        voda form = new voda();
                        form.Show();
                    }
                    else if (elementChoice == "земля")
                    {
                        zemlya form = new zemlya();
                        form.Show();
                    }
                    else
                    {
                        vozduh form = new vozduh();
                        form.Show();
                    }

                    button5.Visible = true;
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            this.Hide();
            this.Close();
        }
    }
}
