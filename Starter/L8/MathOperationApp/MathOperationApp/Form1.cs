using System;
using System.Windows.Forms;

namespace MathOperationApp
{
    public partial class MathApp : Form
    {
        public MathApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) % Convert.ToInt32(textBox2.Text));
            }
            if (radioButton2.Checked == true)
            {
                textBox3.Text = Convert.ToString(Math.Pow(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
            }
            if (radioButton3.Checked == true)
            {
                textBox3.Text = textBox1.Text + textBox2.Text;
            }
            if (radioButton4.Checked == true)
            {
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
            }
        }
    }
}
