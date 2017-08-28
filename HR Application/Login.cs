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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            fillrolecombo();
        }

        void fillrolecombo()
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Manager");
            comboBox1.Items.Add("labor");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
