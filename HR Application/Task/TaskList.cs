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
    public partial class TaskList : Form
    {
        public TaskList()
        {
            InitializeComponent();
            Employee employee = new Employee();
            List<Employee> empList = employee.GetEmployeeListNew();
            dataGridView1.DataSource = empList;
        }

        public TaskList(string depId)
        {
            InitializeComponent();
            Department dept = new Department();
            List<Employee> empList = dept.GetEmployeeList(depId);
            dataGridView1.DataSource = empList;
        }
    }
}
