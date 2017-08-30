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
    public partial class EmployeeList : Form
    {
        public EmployeeList(string depId)
        {
            InitializeComponent();
            Department dept = new Department();
            List<Employee> empList = dept.GetEmployeeList(depId);
            dataGridView1.DataSource = empList;
        }
    }
}
