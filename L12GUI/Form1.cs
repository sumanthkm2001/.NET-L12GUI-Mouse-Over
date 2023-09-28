using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L12GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            double dblNum1 = Convert.ToDouble(tbxNumber1.Text);
            double dblNum2 = Convert.ToDouble(tbxNumber2.Text);
            double dblNum3 = Convert.ToDouble(tbxNumber3.Text);

            double dblSum = dblNum1 + dblNum2 + dblNum3;

            lblOutput.Text = dblSum.ToString();


        }

        private void cmdGo_MouseEnter(object sender, EventArgs e)
        {
            lblOutput.Text = "You have placed the Mouse on Go Button";
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            lblOutput.Text = "You have placed the Mouse on Label3 ";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lblEvent.Text = string.Format("({0},{1})",e.X.ToString(),e.Y.ToString());
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(string.Format("You pressed {0} key ", e.KeyChar.ToString()), "Key Pressed");
        }
    }
}
