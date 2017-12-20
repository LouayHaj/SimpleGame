using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_click(object sender, EventArgs e)
        {
           if (button2.Text == "" )
            {
                button2.Text = button1.Text;
                button1.Text = "";
            }

           if (button4.Text == "")
            {
                button4.Text = button1.Text;
                button1.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button2.Text;
                button2.Text = "";
            }

            if (button3.Text == "")
            {
                button3.Text = button2.Text;
                button2.Text = "";
            }

            if (button5.Text == "")
            {
                button5.Text = button2.Text;
                button2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
            }

            if (button6.Text == "")
            {
                button6.Text = button3.Text;
                button3.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button4.Text;
                button4.Text = "";
            }

            if (button7.Text == "")
            {
                button7.Text = button4.Text;
                button4.Text = "";
            }

            if (button5.Text == "")
            {
                button5.Text = button4.Text;
                button4.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button5.Text;
                button5.Text = "";
            }

            if (button4.Text == "")
            {
                button4.Text = button5.Text;
                button5.Text = "";
            }

            if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";
            }

            if (button8.Text == "")
            {
                button8.Text = button5.Text;
                button5.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button6.Text;
                button6.Text = "";
            }
            if (button9.Text == "")
            {
                button9.Text = button6.Text;
                button6.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button6.Text;
                button6.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = button7.Text;
                button7.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button7.Text;
                button7.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = button8.Text;
                button8.Text = "";
            }
            if (button7.Text == "")
            {
                button7.Text = button8.Text;
                button8.Text = "";
            }
            if (button9.Text == "")
            {
                button9.Text = button8.Text;
                button8.Text = "";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button9.Text;
                button9.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button9.Text;
                button9.Text = "";
            }
        }
    }
}
