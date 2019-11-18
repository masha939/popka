using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9090909
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl2_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((maskedTextBox1.Text=="")||(maskedTextBox2.Text=="")||(textBox1.Text=="")||(textBox2.Text=="")) {
                //button1.Visible = false;
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                tabControl2.SelectedIndex = tabControl2.SelectedIndex + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((maskedTextBox1.Text == "") || (maskedTextBox2.Text == "") || (textBox1.Text == "") || (textBox2.Text == ""))
            {
                //button1.Visible = false;
                MessageBox.Show("Заполните все поля");
               
            }
            else
            {
                tabControl2.SelectedIndex = tabControl2.SelectedIndex + 1;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        bool qwerty;

        private void label15_MouseUp(object sender, MouseEventArgs e)
        {
            qwerty = false;
        }

        private void label15_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (qwerty) {
                c.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void label15_MouseDown(object sender, MouseEventArgs e)
        {
            qwerty = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                tabControl2.SelectedIndex = tabControl2.SelectedIndex + 1;
            
        }

        private void label15_Click(object sender, EventArgs e)
        {
                
        }
    }
}
