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
    public partial class TaskList : Form
    {
        public TaskList(string depId)
        {
            InitializeComponent();
            Task task = new Task();
            List<Task> taskList = task.GetTaskList(depId);
            dataGridView1.DataSource = taskList;
        }
    }
}
