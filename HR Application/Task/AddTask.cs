using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace HR_Application
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();

            Department department = new Department();
            ArrayList deptList = department.getDepartmentList();
            foreach (string dept in deptList) { comboBox1.Items.Add(dept); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            string taskName = textBox2.Text;
            decimal maxEmployees = numericUpDown1.Value;
            string depId = comboBox1.Text.Substring(0, 6);
            string status = comboBox2.Text;

            Task task = new Task();
            task.CreateTask(taskName, maxEmployees, depId, status);
            MessageBox.Show("Successfully Created the Task");
        }
    }
}
