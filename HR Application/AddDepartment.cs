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

            comboBox1.Items.Add("EMP001");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string depId = textBox1.Text;
            string depName = textBox2.Text;
            string address = textBox3.Text;
            string depHead = comboBox1.Text;

            MessageBox.Show(depId);
            MessageBox.Show(depName);
            MessageBox.Show(address);
            MessageBox.Show(depHead);

            Department dept = new Department();
            dept.createDepartment(depId, depName, address);
            Console.WriteLine("I'm here");
        }
    }
}
