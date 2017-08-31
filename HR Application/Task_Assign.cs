using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
//using Oracle.DataAccess.Client;
//using Oracle.DataAccess.Types;
using System.Windows.Forms;

namespace HR_Application
{
    public partial class Task_Assign : Form
    {
        Task tsk;
        string dep_id;
        string task_id;
        List<Task> num = new List<Task>();
        public Task_Assign(string dep_id, string task_id)
        {
            InitializeComponent();
            this.dep_id = dep_id;
            this.task_id = task_id;
            this.getemployee();
            //checkedListBox1.Items.Add("Dinesh");
            //checkedListBox1.Items.Add("Nana");

        }
        void getemployee()
        {
            tsk = new Task();
           
            num = tsk.GetTask(task_id);
            label5.Text = num[0].MaxEmployees.ToString();
            label4.Text = num[0].CurrentEmployees.ToString();
             
            ArrayList ar = new ArrayList();
            ar = tsk.GetEmployList(task_id,dep_id);

            foreach (var item in ar)
            {
                //string s = (string)__o;
                checkedListBox1.Items.Add(item.ToString());
                // loop body
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxemp = Int32.Parse(num[0].MaxEmployees.ToString());
            int curr = Int32.Parse(num[0].CurrentEmployees.ToString());
            int available = maxemp - curr;
            int checkedCount = checkedListBox1.CheckedItems.Count;
            Console.WriteLine(checkedCount);

            if (checkedCount > available)
            {
                MessageBox.Show("You selected more than Max Employees");
            }

            else {

                string newcuremp = (curr + checkedCount).ToString();
                tsk.Update_Current_emp(task_id, newcuremp);
                foreach (string s in checkedListBox1.CheckedItems)
                {
                    string emp_id = s.Substring(0, 6);
                    tsk.Assign_Employee(task_id, emp_id);

                }
                MessageBox.Show("Employees are assigned to the Task");
                this.Hide();
            }
            
        }
    }
}
