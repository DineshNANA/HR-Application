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
    public partial class SelectDepartment : Form
    {
        string action;
        Department department;

        public SelectDepartment(string operation)
        {
            InitializeComponent();

            action = operation;
            
            department = new Department();
            ArrayList deptList = department.getDepartmentList();
            foreach(string dept in deptList)
            {
                comboBox1.Items.Add(dept);
            }

            if (action == "Delete")
            {
                this.Text = "Delete Department";
                button1.Text = "Delete";
            }
            else if (action == "Select")
            {
                this.Text = "Select Department";
                button1.Text = "Select";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result;
            string depId = comboBox1.Text.Substring(0,6);

            if (action == "Delete")
            {
                result = department.deleteDepartment(depId);
                if (result == "Success")
                {
                    MessageBox.Show("Department successfully deleted");
                    comboBox1.Items.Remove(comboBox1.Text);
                }
                else
                    MessageBox.Show("Unexpected error occured");
            
            }
            else if (action == "Select")
            {
                EditDepartment editDept = new EditDepartment("Edit", depId);
                editDept.Show();
                this.Close();
            }

        }

    }

}
