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
            ComboboxValue();
        }

        void ComboboxValue()
        {
            Department dep = new Department();
            ArrayList ob = dep.getDepartmentList();
            Role_Class role = new Role_Class();
            ArrayList res = role.GetRoleDetails();

             foreach (var item in ob)
             {
                 comboBox3.Items.Add(item);
             }
             foreach (var item in res)
             {
                 comboBox2.Items.Add(item);
             }
            //while (ob.Read())
            //{
                 
            //         string item = ob [1].ToString();
            //         comboBox3.Items.Add(item);
                
                 
                
            //}
             
            //comboBox2.Items.Add("Manager");
            //comboBox2.Items.Add("Administrator");
            //comboBox2.Items.Add("Labour");
           
             
             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string emp_name = textBox2.Text;
            string nic = textBox4.Text;
            string contact = textBox1.Text;
            string dep_id = comboBox3.Text.Substring(0, 6);
            string pswd = "ifs";
            string email = textBox5.Text;
            string gender = "M";
            string status = "Active";
            string role_id = comboBox2.Text.Substring(0, 6);
            string address = textBox3.Text;
            
            
           
           
 
            Employee emp_obj = new Employee();
            emp_obj.Emp_Register(emp_name, nic, contact,dep_id, pswd, email, gender, address,status,role_id);
            MessageBox.Show("Employee Successfully Added");

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        

        
    }
}
