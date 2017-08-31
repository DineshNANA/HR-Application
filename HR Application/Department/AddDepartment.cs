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
        Department dept;

        public AddDepartment()
        {
            InitializeComponent();
            dept = new Department();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string depName = textBox1.Text;
            string address = textBox2.Text;
            string depHead;

            if (comboBox1.Text == "Not assigned")
                depHead = "NULL";
            else
                depHead = comboBox1.Text.Substring(0, 6);

            string result = dept.createDepartment(depName, address, depHead);

            if (result == "Success")
            {
                MessageBox.Show("Department successfully created");
                this.Close();
            }
            else
            {
                MessageBox.Show("Unexpected error occured");
                this.Close();
            }
        }
    }
}
