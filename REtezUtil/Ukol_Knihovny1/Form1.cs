using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REtezUtil;

namespace Ukol_Knihovny1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vstup = textBox1.Text;
            if(vstup.Length != 0)
            {
                vstup = Class1.Smaz(vstup);
                label2.Text = Class1.Zobraz(vstup);
            }
            else
            {
                MessageBox.Show("Zadejte text!!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Minus x = new Minus(textBox1.Text);
                Minus y = new Minus(textBox2.Text);
                label5.Text = x - y;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LawnGreen;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Gold;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.LawnGreen;
        }
    }
}
