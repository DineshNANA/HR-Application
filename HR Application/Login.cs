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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            fillrolecombo();
        }

        void fillrolecombo()
        {
            Role_Class role = new Role_Class();
            ArrayList arlist = new ArrayList();
            arlist=role.Get_Role_Details();

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
                MessageBox.Show("Login ok");
                this.Hide();

                if (role == "Administrator")
                {
                    AdminPanel adminPanel = new AdminPanel(emp_id);
                    adminPanel.Show();
                }
                else
                {
                    Form1 f1 = new Form1();
                    f1.Show();
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
