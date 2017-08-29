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
                form_add_emp.FormClosed +=new FormClosedEventHandler(form_add_emp_FormClosed);
                form_add_emp.Show();
            }

        }
        private void form_add_emp_FormClosed(object sender, EventArgs e)
        {
            form_add_emp = null;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (login_form == null)
            //{
            //    login_form = new Login();
            //    login_form.MdiParent = this;
            //    login_form.FormClosed += new FormClosedEventHandler(login_form_FormClosed);
            //    login_form.Show();
            //}
            //else
            //{
            //    login_form.Activate();
            //}

        }
        private void login_form_FormClosed(object sender, EventArgs e)
        {
            login_form = null;
        }

        private void addNewDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditDepartment dept = new EditDepartment();
            dept.ShowDialog();
        }
    }
}
