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
using System.Text.RegularExpressions;


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

            foreach (var dept in deptList) { DepartmentSelect.Items.Add(dept); }
            foreach (var role in roleList) { RoleSelect.Items.Add(role); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string Gender;
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox5.Text) || String.IsNullOrEmpty(textBox5.Text) || String.IsNullOrEmpty(Gender) || String.IsNullOrEmpty(RoleSelect.Text) || String.IsNullOrEmpty(DepartmentSelect.Text))
            {
                MessageBox.Show("Please Fill The Values");
            }
            else{

                string emp_name = textBox2.Text;
                string nic = textBox4.Text;
                string contact = textBox1.Text;
                string dep_id = DepartmentSelect.Text.Substring(0, 6);
                string pswd = "ifs";
                string email = textBox5.Text;
                string gender = Gender;
                string status = "Active";
                string role_id = RoleSelect.Text.Substring(0, 6);
                string address = textBox3.Text;
                string role = RoleSelect.Text.Substring(0, 6);

                Employee emp_obj = new Employee();
                emp_obj.Emp_Register(emp_name, nic, contact,dep_id, pswd, email, gender, address,status,role_id);
                MessageBox.Show("Employee Successfully Added");
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        //Assingning Values to the Gender
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }


        //Employee Name Validation
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Please enter your Name");

            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }


        //Email Validation
        public bool NicValidate(string strIn)
        {
            // Return true if strIn is in valid NIC format.
            try
            {
                return Regex.IsMatch(strIn, "[0-9]{9}v", RegexOptions.IgnoreCase);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text == "" || NicValidate(textBox4.Text))
            {
                errorProvider1.SetError(textBox4, "Enter Correct NIC");

            }
            else
            {
                errorProvider1.SetError(textBox4, "");
            }
        }


        //Emial Validation
        public bool EmailValidate(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?                      (\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (textBox5.Text == "" || EmailValidate(textBox5.Text))
            {
                errorProvider1.SetError(textBox5, "Enter Correct Email");

            }
            else
            {
                errorProvider1.SetError(textBox5, "");
            }

        }

       
        //contact no validated

        public bool ContactValidate(string strtxt)
        {
            try
            {
                return Regex.IsMatch(strtxt, "[0-9]{10}", RegexOptions.IgnoreCase);
            }
            catch (Exception)
            {
                return false;
            }

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Eg:0771234567");

            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void RoleSelectValidating(object sender, CancelEventArgs e)
        {
            if (RoleSelect.Text == ""  )
            {
                errorProvider1.SetError(RoleSelect, "Select From Combo");

            }
            else
            {
                errorProvider1.SetError(RoleSelect, "");
            }

        }

        private void DepartmentSelect_Validating(object sender, CancelEventArgs e)
        {
            if (DepartmentSelect.Text == "")
            {
                errorProvider1.SetError(DepartmentSelect, "Select From Combo");

            }
            else
            {
                errorProvider1.SetError(DepartmentSelect, "");
            }

        }

    }

}
