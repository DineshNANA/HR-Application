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
    public partial class EditDepartment : Form
    {
        string depId, depName, address, depHead;
        Employee emp;
        Department department;

        public EditDepartment()
        {
            InitializeComponent();
            
            department = new Department();
            ArrayList deptList = department.getDepartmentList();

            foreach (string dept in deptList) { comboBox2.Items.Add(dept); }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            depName = textBox2.Text;
            address = textBox3.Text;
            depHead = comboBox1.Text;

            department.editDetails(depId, depName, address, depHead);
            MessageBox.Show("Department details successfully updated");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = depName;
            textBox3.Text = address;
            comboBox1.Text = depHead;
        }

        private void EditDepartment_Load(object sender, EventArgs e) { }

        private void GetDepartmentDetails(object sender, EventArgs e)
        {
            depId = comboBox2.Text.Substring(0, 6);

            ArrayList deptDetails = new ArrayList();
            deptDetails = department.GetDepartment(depId);

            depName = deptDetails[1].ToString();
            address = deptDetails[2].ToString();
            depHead = deptDetails[3].ToString();

            textBox2.Text = depName;
            textBox3.Text = address;
            comboBox1.Items.Clear();

            if (depHead == "NULL")
                comboBox1.Text = "Not Assigned";
            else
                comboBox1.Text = depHead;

            emp = new Employee();
            ArrayList empList = emp.GetEmployeeList();
            foreach (string employee in empList)
            {
                comboBox1.Items.Add(employee);
            }

        }
    }
}
