using Microsoft.VisualBasic.Logging;

namespace Gra_zgadywanie_liczb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            textBox1.Enabled = false;
            checkBox1.Checked = true;
        }
        public int los = 0;
        public int myliczba = 0;
        public int nrpr = 0;
        public int high = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            los = 0;
            nrpr = 0;
            label1.Text = "BRAK";
            textBox1.Text = "";
            label5.Text = "Nr próby:";
            button3.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            button1.Enabled = false;
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (radioButton1.Checked)
            {
                los = rand.Next(0, 1000);
            }
            else if (radioButton2.Checked)
            {
                los = rand.Next(0, 100);
            }
            else if (radioButton3.Checked)
            {
                los = rand.Next(0, 10);
            }
            nrpr = 1;
            label5.Text = "Nr próby: " + nrpr;
            button3.Enabled = false;
            panel2.BackColor = Control.DefaultBackColor;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            button1.Enabled = true;
            textBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                myliczba = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception myliczba)
            {
                MessageBox.Show("B³¹d: " + myliczba.Message);
                textBox1.Clear();

            }

            int high = 0;

            if (checkBox1.Enabled == true)
            {
                if (myliczba < los)
                {
                    label1.Text = "Wiêksza";
                    nrpr++;
                    label5.Text = "Nr próby: " + nrpr;
                }
                else if (myliczba > los)
                {
                    label1.Text = "Mniejsza";
                    nrpr++;
                    label5.Text = "Nr próby: " + nrpr;
                }
                else if (myliczba == los)
                {
                    label8.Text = "Brawo, odgad³eœ liczbê! Spróbuj ponowanie.";
                    if (high < nrpr)
                    {
                        high = nrpr;
                    }
                    label2.Text = "Najmniejsza liczba prób: " + high;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}