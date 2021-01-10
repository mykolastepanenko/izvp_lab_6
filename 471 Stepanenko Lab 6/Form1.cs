using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _471_Stepanenko_Lab_6
{
    public partial class Form1 : Form
    {
        public int parentResult;
        public Form1()
        {
            InitializeComponent();
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Файл");

            fileItem.DropDownItems.Add("Закрити");
            fileItem.DropDownItems[0].Click += aboutItem_Click;
            menuStrip1.Items.Add(fileItem);

            ToolStripMenuItem aboutItem = new ToolStripMenuItem("О программе");
            aboutItem.DropDownItems.Add("Автор: Степаненко М.І. 471");
            menuStrip1.Items.Add(aboutItem);
        }
        private void aboutItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            
        }
        public int GetResult
        {
            set
            {
                label3.Text = "Результат: ";
                label3.Text = label3.Text + value.ToString();
            }
        }
    }
}
