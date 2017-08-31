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
    public partial class UnassignEmployee : Form
    {
        string taskId;
        Task task;

        public UnassignEmployee(string taskId)
        {
            InitializeComponent();
            this.taskId = taskId;

            task = new Task();
            ArrayList empList = task.GetAssignedEmployees(taskId);
            foreach (string employee in empList) { checkedListBox1.Items.Add(employee); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string employee in checkedListBox1.CheckedItems)
            {
                task.UnassignTask(taskId, employee.Substring(0, 6));
            }

            foreach (string employee in checkedListBox1.CheckedItems)
            {
                checkedListBox1.Items.Remove(employee);
            }

        }
    }
}
