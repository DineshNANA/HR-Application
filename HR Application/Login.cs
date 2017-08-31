using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using HR_Application.Role;
 
namespace HR_Application
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            fillrolecombo();
        }

        void fillrolecombo()
        {
            RoleClass role = new RoleClass();
            ArrayList arlist = new ArrayList();
            arlist=role.GetRoleList();

            foreach(var item in arlist){

                comboBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            Int16 result;
            string emp_id = textBox1.Text;
            string psswd = textBox2.Text;
            string role = comboBox1.Text;
            result = emp.Employee_Login(emp_id, psswd, role);
            if (result == 1)
            {
                this.Hide();

                if (role == "Administrator")
                {
                    AdminPanel adminPanel = new AdminPanel(emp_id,role);
                    adminPanel.Show();
                }
                else if(role == "Manager")
                {
                    ManagerPanel managePanel = new ManagerPanel(emp_id,role);
                    managePanel.Show();
                }
                else if (role == "User")
                {
                    EmployeePanel employeePanel = new EmployeePanel();
                    employeePanel.Show();
                }
                 
            }
            else if (result == 0)
                MessageBox.Show("selected role type is invalid");

            else
                MessageBox.Show("User name or password Incorrect");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
