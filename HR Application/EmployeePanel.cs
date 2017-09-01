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
    public partial class EmployeePanel : Form
    {
        Employee me;
        string emp_id;
        public EmployeePanel(string empId, string role)
        {
            InitializeComponent();
            this.emp_id = empId;
            me = new Employee(empId);
            Load +=new EventHandler(EmployeePanel_Load);
            roleValue.Text = role;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeePanel_Load(object sender, EventArgs e)
        {
            ArrayList emp_data = new ArrayList();
            emp_data = me.Get_Profile();
            empIdValue.Text = emp_data[0].ToString();
            empNameValue.Text = emp_data[1].ToString();
            departmentName.Text = emp_data[6].ToString();
        }

        private void empViewTask_Click(object sender, EventArgs e)
        {
            ArrayList rest = new ArrayList();
            rest = me.Get_Task_List(emp_id);
            EmployeeTaskList emptsklist = new EmployeeTaskList(rest);
            emptsklist.Show();
             
        }
    }
}
