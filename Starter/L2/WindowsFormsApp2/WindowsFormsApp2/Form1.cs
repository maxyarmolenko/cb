using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class NumberSystem : Form
    {
        public NumberSystem()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From 0 till 255");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From 0 till 4,294,967,295");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From -128 till 127");
        }
       

        private void Button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("From -32 768 till 32 767");

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From 0 till 65 535");
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From -2,147,483,648 till 2,147,483,647");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From -9,223,372,036,854,775,808 till 9,223,372,036,854,775,807");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From 0 till 18,446,744,073,709,551,615");
        }
    }
}
