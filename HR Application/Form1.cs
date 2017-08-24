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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AddEmployee form_add_emp;
        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_add_emp == null)
            {
                form_add_emp = new AddEmployee();
                form_add_emp.MdiParent = this;
                form_add_emp.Show();
            }
            else
            {
                form_add_emp.Activate();
            }
            
        }

        
        Login login_form;

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_form == null)
            {
                login_form = new Login();
                login_form.MdiParent = this;
                login_form.Show();
            }
            else
            {
                login_form.Activate();
            }
        }
    }
}
