using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace HR_Application
{
    public partial class Task_Assign : Form
    {
        Task tsk;
        public Task_Assign()
        {
            InitializeComponent();
            this.getemployee();
            //checkedListBox1.Items.Add("Dinesh");
            //checkedListBox1.Items.Add("Nana");
            
        }
        void getemployee()
        {
            tsk = new Task();
            ArrayList ar = new ArrayList();
            ar = tsk.GetEmployList("TSK001","DEP001");

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
    }
}
