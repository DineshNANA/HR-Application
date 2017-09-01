namespace HR_Application
{
    partial class EmployeePanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.empViewTask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.empIdValue = new System.Windows.Forms.Label();
            this.empNameValue = new System.Windows.Forms.Label();
            this.departmentName = new System.Windows.Forms.Label();
            this.roleValue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 74);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Panel";
            // 
            // empViewTask
            // 
            this.empViewTask.Location = new System.Drawing.Point(40, 144);
            this.empViewTask.Name = "empViewTask";
            this.empViewTask.Size = new System.Drawing.Size(183, 117);
            this.empViewTask.TabIndex = 1;
            this.empViewTask.Text = "View Task List";
            this.empViewTask.UseVisualStyleBackColor = true;
            this.empViewTask.Click += new System.EventHandler(this.empViewTask_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // empIdValue
            // 
            this.empIdValue.AutoSize = true;
            this.empIdValue.Location = new System.Drawing.Point(347, 230);
            this.empIdValue.Name = "empIdValue";
            this.empIdValue.Size = new System.Drawing.Size(35, 13);
            this.empIdValue.TabIndex = 7;
            this.empIdValue.Text = "label7";
            // 
            // empNameValue
            // 
            this.empNameValue.AutoSize = true;
            this.empNameValue.Location = new System.Drawing.Point(347, 258);
            this.empNameValue.Name = "empNameValue";
            this.empNameValue.Size = new System.Drawing.Size(35, 13);
            this.empNameValue.TabIndex = 8;
            this.empNameValue.Text = "label8";
            // 
            // departmentName
            // 
            this.departmentName.AutoSize = true;
            this.departmentName.Location = new System.Drawing.Point(350, 288);
            this.departmentName.Name = "departmentName";
            this.departmentName.Size = new System.Drawing.Size(35, 13);
            this.departmentName.TabIndex = 9;
            this.departmentName.Text = "label9";
            // 
            // roleValue
            // 
            this.roleValue.AutoSize = true;
            this.roleValue.Location = new System.Drawing.Point(350, 320);
            this.roleValue.Name = "roleValue";
            this.roleValue.Size = new System.Drawing.Size(41, 13);
            this.roleValue.TabIndex = 10;
            this.roleValue.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(350, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "label11";
            // 
            // EmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 423);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.roleValue);
            this.Controls.Add(this.departmentName);
            this.Controls.Add(this.empNameValue);
            this.Controls.Add(this.empIdValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empViewTask);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeePanel";
            this.Text = "EmployeePanel";
            this.Load += new System.EventHandler(this.EmployeePanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button empViewTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label empIdValue;
        private System.Windows.Forms.Label empNameValue;
        private System.Windows.Forms.Label departmentName;
        private System.Windows.Forms.Label roleValue;
        private System.Windows.Forms.Label label11;
    }
}