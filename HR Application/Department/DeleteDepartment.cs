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
    public partial class DeleteDepartment : Form
    {
        Department department;

        public DeleteDepartment()
        {
            InitializeComponent();
            department = new Department();
            ArrayList deptList = department.getDepartmentList();

            foreach(string dept in deptList)
            {
                comboBox1.Items.Add(dept);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string depId = comboBox1.Text.Substring(0,6);
            department.deleteDepartment(depId);
        }
    }
}
