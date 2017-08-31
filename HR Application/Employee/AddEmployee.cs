using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;


namespace HR_Application
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();

            Department department = new Department();
            ArrayList deptList = department.getDepartmentList();

            Role_Class role_class = new Role_Class();
            ArrayList roleList = role_class.GetRoleDetails();

            foreach (var dept in deptList) { comboBox3.Items.Add(dept); }
            foreach (var role in roleList) { comboBox2.Items.Add(role); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string Gender;
        private void button2_Click(object sender, EventArgs e)
        {
            string emp_name = textBox2.Text;
            string nic = textBox4.Text;
            string contact = textBox1.Text;
            string dep_id = comboBox3.Text.Substring(0, 6);
            string pswd = "ifs";
            string email = textBox5.Text;
            string gender = Gender;
            string status = "Active";
            string role_id = comboBox2.Text.Substring(0, 6);
            string address = textBox3.Text;
            string role = comboBox2.Text.Substring(0, 6);

            Employee emp_obj = new Employee();
            emp_obj.Emp_Register(emp_name, nic, contact,dep_id, pswd, email, gender, address,status,role_id);
            MessageBox.Show("Employee Successfully Added");
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

    }

}
