using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 

namespace HR_Application
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
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
