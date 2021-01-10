using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace _471_Stepanenko_Lab_6
{
    public partial class UserControl1 : UserControl
    {
        int result;
        int a, b;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            result = a * b;
            if (result == 0)
            {
                MessageBox.Show("Ви не ввели параметри форми.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                var parent = this.Parent as Form1;
                parent.GetResult = GetResult;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                try
                {
                    b = Convert.ToInt32(textBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Для роботи программи необхідно вводити ціле число int", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Text = "";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    a = Convert.ToInt32(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Для роботи программи необхідно вводити ціле число int", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                }
            }
        }

        public int GetResult
        {
            get { return result; }
        }
    }
}
