using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace HR_Application
{
    public partial class AdminPanel : Form
    {
        Employee me;
        public AdminPanel()
        {
            InitializeComponent();
        }

        public AdminPanel(string empId)
        {
            InitializeComponent();
            me = new Employee(empId);
            //label6.Text = "EMP118";
            //label7.Text = "Dinesh Nana";
            //label8.Text = "Training & Development";
            //label9.Text = "ADMINISTRATOR";
            label10.Text = "Administrator";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditDepartment addDept = new EditDepartment("Add");
            addDept.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SelectDepartment deleteDept = new SelectDepartment("Delete");
            deleteDept.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmp = new AddEmployee();
            addEmp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SelectDepartment selectDept = new SelectDepartment("Select");
            selectDept.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            ArrayList emp_data = new ArrayList();
            emp_data = me.Get_Profile();
            label6.Text = emp_data[0].ToString();
            label7.Text = emp_data[1].ToString();
            label8.Text = emp_data[6].ToString();
            label9.Text = emp_data[5].ToString();
        }
    }
}
