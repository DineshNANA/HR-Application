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
    public partial class EmployeeTaskList : Form
    {
        public EmployeeTaskList(ArrayList ar)
        {
            InitializeComponent();
            dataGridView1.DataSource = ar;
        }
    }
}
