using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Text_Spammer
{
    public partial class Form1 : Form
    {
        public bool pressed = false;
        string[] buttons = { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "f1", "f2", "f3", "f4", "f5", "f6", "f7", "f8", "f9", "f10", "f11", "f12" };
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.F8)
            {
                pressed = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void spam()
        {
            while (true)
            {

                if (pressed)
                {
                    
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            foreach (string x in buttons)
            {
                if (x.Contains(textBox3.Text.ToString()))
                {

                }
                else
                {
                    MessageBox.Show("You must enter a function key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
