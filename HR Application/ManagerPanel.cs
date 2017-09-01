﻿using System;
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
    public partial class ManagerPanel : Form
    {
        Employee me;
        string dep_id;

        public ManagerPanel(string emp_id, string role)
        {
            InitializeComponent();
            me = new Employee(emp_id);
            this.dep_id = me.Dep_id;
            roleValue.Text = role;
            Load +=new EventHandler(ManagerPanel_Load);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectTask selectTask = new SelectTask("Assign", dep_id);
            selectTask.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeList empList = new EmployeeList(dep_id);
            empList.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaskList taskList = new TaskList(dep_id);
            taskList.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {



            SelectTask selectTask = new SelectTask("Unassign", dep_id);
            selectTask.Show();
 
        }

        private void ManagerPanel_Load(object sender, EventArgs e)
        {
            ArrayList emp_data = new ArrayList();
            emp_data = me.Get_Profile();
            empIdValue.Text = emp_data[0].ToString();
            empNameValue.Text = emp_data[1].ToString();
            departmentValue.Text = emp_data[6].ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Dispose();
        }
    }
}
