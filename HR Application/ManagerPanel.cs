﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
