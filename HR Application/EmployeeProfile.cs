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
    public partial class EmployeeProfile : Form
    {
        Employee me;
        public EmployeeProfile(string emp_id)
        {
            InitializeComponent();
            me = new Employee(emp_id);
            Load += new EventHandler(EmployeeProfile_Load);
            
        }

        private void EmployeeProfile_Load(object sender, EventArgs e)
        {
            ArrayList emp_prof = new ArrayList();
            emp_prof = me.Get_Profile();
            label8.Text = emp_prof[0].ToString();
            label9.Text = emp_prof[1].ToString();
            label10.Text = emp_prof[2].ToString();
            label11.Text = emp_prof[3].ToString();
            label12.Text = emp_prof[4].ToString();
            label13.Text = emp_prof[5].ToString();
            label14.Text = emp_prof[6].ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
