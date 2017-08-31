using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HR_Application.Role
{
    public partial class AddRole : Form
    {
        public AddRole()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string roleName = textBox1.Text;
            string roleDescription = textBox2.Text;

            RoleClass role = new RoleClass();
            role.AddRole(roleName, roleDescription);

            MessageBox.Show("New role successfully added");
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
