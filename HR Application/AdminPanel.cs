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
        string emp_id;

        public AdminPanel()
        {
            InitializeComponent();
        }

        public AdminPanel(string empId)
        {
            InitializeComponent();
            this.emp_id = empId;
            me = new Employee(empId);
            Load +=new EventHandler(AdminPanel_Load);
            label10.Text = "Administrator";

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            ArrayList emp_data = new ArrayList();
            emp_data = me.Get_Profile();
            label6.Text = emp_data[0].ToString();
            label7.Text = emp_data[1].ToString();
            label8.Text = emp_data[6].ToString();
           
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


        private void button5_Click(object sender, EventArgs e)
        {
            EmployeeProfile empprofile = new EmployeeProfile(this.emp_id);
            empprofile.Show();

          }
        private void button14_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.Show();

        }
    }
}
