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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDepartment addDept = new AddDepartment();
            addDept.Show();
        }
    }
}
