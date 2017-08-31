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
        string dep_id;
        public SelectTask()
        {
            InitializeComponent();

            Task task = new Task();
            List<Task> taskList = task.GetTaskList();
            foreach (Task item in taskList) { comboBox1.Items.Add(item.TaskId + " - " + item.TaskName); }
        }

        public SelectTask(string depId)
        {
            InitializeComponent();
            this.dep_id = depId;
            Task task = new Task();
            List<Task> taskList = task.GetTaskList(depId);
            MessageBox.Show(depId);
            foreach (Task item in taskList) { comboBox1.Items.Add(item.TaskId + " - " + item.TaskName); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taskId = comboBox1.Text.Substring(0, 6);
            Task_Assign ts = new Task_Assign(dep_id,taskId);
            this.Hide();
            ts.Show();
        }
    }
}
