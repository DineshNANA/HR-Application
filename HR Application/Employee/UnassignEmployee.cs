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
        List<Task> num = new List<Task>();

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


            num = task.GetTask(taskId);
            int curr = Int32.Parse(num[0].CurrentEmployees.ToString());
            int checkedCount = checkedListBox1.CheckedItems.Count;
            string newcuremp = (curr - checkedCount).ToString();
            task.Update_Current_emp(taskId, newcuremp);
            foreach (string employee in checkedListBox1.CheckedItems)
            {
                task.UnassignTask(taskId, employee.Substring(0, 6));
            }

            //foreach (string employee in checkedListBox1.CheckedItems)
            //{
            //    checkedListBox1.Items.Remove(employee);
            //}

        }
    }
}
