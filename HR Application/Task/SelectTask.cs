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
    public partial class SelectTask : Form
    {
        string action, dep_id;

        public SelectTask(string operation)
        {
            InitializeComponent();
            action = operation;

            Task task = new Task();
            List<Task> taskList = task.GetTaskList();
            foreach (Task item in taskList) { comboBox1.Items.Add(item.TaskId + " - " + item.TaskName); }
        }

        public SelectTask(string operation, string depId)
        {
            InitializeComponent();
            action = operation;
            this.dep_id = depId;

            Task task = new Task();
            List<Task> taskList = task.GetTaskList(depId);
            foreach (Task item in taskList) { comboBox1.Items.Add(item.TaskId + " - " + item.TaskName); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taskId = comboBox1.Text.Substring(0, 6);

            if (action == "Edit")
            {
                EditTask editTask = new EditTask(taskId);
                this.Close();
                editTask.Show();
            }
            else if (action == "Assign")
            {
                Task_Assign taskAssign = new Task_Assign(dep_id, taskId);
                this.Close();
                taskAssign.Show();
            }
            else if (action == "Unassign")
            {
                UnassignEmployee unassignEmp = new UnassignEmployee(taskId);
                this.Close();
                unassignEmp.Show();
            }
        }
    }
}
