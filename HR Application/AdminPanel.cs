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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        public AdminPanel(string empId)
        {
            InitializeComponent();
            label6.Text = "EMP118";
            label7.Text = "Dinesh Nana";
            label8.Text = "Training & Development";
            label9.Text = "ADMINISTRATOR";
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

        private void button9_Click(object sender, EventArgs e)
        {
            SelectDepartment selectDept = new SelectDepartment("EmpList");
            selectDept.Show();
        }
    }
}
