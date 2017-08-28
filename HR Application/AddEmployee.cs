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

             foreach (var item in ob)
             {
                 comboBox3.Items.Add(item);
             }
            //while (ob.Read())
            //{
                 
            //         string item = ob [1].ToString();
            //         comboBox3.Items.Add(item);
                
                 
                
            //}
             
            comboBox2.Items.Add("Manager");
            comboBox2.Items.Add("Administrator");
            comboBox2.Items.Add("Labour");
           
             
             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string emp_name = textBox2.Text;
            string nic = textBox4.Text;
            string address = "GALLE";
            string contact = textBox5.Text;
           
            string designation = "ADMINISTRATOR";
            string dep_id = "DEP008";
            string pswd = "DINESH";
 
            Employee emp_obj = new Employee();
            emp_obj.Emp_Register(emp_name,nic, address,contact,designation,dep_id,pswd);

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        

        
    }
}
