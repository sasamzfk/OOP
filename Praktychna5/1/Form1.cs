using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ініціалізація значень за замовчуванням
            textBoxUSD.Text = "25,2";
            textBoxCourse.Text = "26,72";
            labelResult.Text = "0,00 ₴";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double usd = double.Parse(textBoxUSD.Text);
                double course = double.Parse(textBoxCourse.Text);
                double uah = usd * course;
                labelResult.Text = uah.ToString("N2") + " ₴";
            }
            catch (Exception)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}