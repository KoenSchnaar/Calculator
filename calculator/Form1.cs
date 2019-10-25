using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Berekeningen berekeningen = new Berekeningen();
        public Form1()
        {
            InitializeComponent();
        }

        private void CijferWeergave(object sender, EventArgs e)
        {
            //string display = (sender as Button).Text;
            var button = (Button)sender;
            string display = button.Text;
            textBox1.Text += display;
            berekeningen.Cijfers(display);

        }
        private void OperatorWeergave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string display = button.Text;
            textBox1.Text += display;
            berekeningen.Operator(display);
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            textBox1.Text = berekeningen.Berekenen();
        }

        private void buttonClearEverything_Click(object sender, EventArgs e)
        {
            textBox1.Text = berekeningen.ClearEverything();
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            textBox1.Text = berekeningen.Backspace(textBox1.Text);
        }
    }
    

}
