using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using HR_Application.Role;

namespace HR_Application.Role
{
    public partial class DeleteRole : Form
    {
        RoleClass role;

        public DeleteRole()
        {
            InitializeComponent();

            role = new RoleClass();
            ArrayList roleList = role.GetRoleListID();

            foreach (string item in roleList) { comboBox1.Items.Add(item); } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string roleId = comboBox1.Text.Substring(0, 6);
            role.DeleteRole(roleId);
            comboBox1.Items.Remove(comboBox1.Text);
        }
    }
}
