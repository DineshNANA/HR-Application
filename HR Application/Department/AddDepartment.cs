using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HR_Application
{
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string depId = textBox1.Text;
            string depName = textBox2.Text;
            string address = textBox3.Text;
            string depHead;

            if (comboBox1.Text == "Not assigned")
                depHead = null;
            else
                depHead = comboBox1.Text;
        }
    }
}
