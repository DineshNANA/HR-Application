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
        string action;
        Employee emp = new Employee();
        Department dept;

        public EditDepartment()
        {
            InitializeComponent();
        }

        public EditDepartment(string operation)
        {
            InitializeComponent();
            action = operation;

            if (action == "Add")
            {
                this.Text = "Add Department";
                button2.Text = "Add New";
            }

            ArrayList empList = emp.GetEmployeeList();
            foreach (string employee in empList)
            {
                comboBox1.Items.Add(employee);
            }
        }


        public EditDepartment(string operation, string depId)
        {
            InitializeComponent();
            action = operation;

            if (action == "Edit")
            {
                this.Text = "Edit Department";
                button2.Text = "Save Changes";
                textBox1.Text = depId;
                textBox1.Enabled = false;
            }

            ArrayList empList = emp.GetEmployeeList();
            foreach (string employee in empList)
            {
                comboBox1.Items.Add(employee);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string depId = textBox1.Text;
            string depName = textBox2.Text;
            string address = textBox3.Text;
            string depHead;

            if (comboBox1.Text == "Not assigned")
                depHead = "NULL";
            else
                depHead = comboBox1.Text.Substring(0, 6);

            dept = new Department();
            string result = dept.createDepartment(depId, depName, address, depHead);

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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "Not assigned";
        }

        private void EditDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
