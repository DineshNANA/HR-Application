namespace HR_Application
{
    partial class ManagerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.empId = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.empIdValue = new System.Windows.Forms.Label();
            this.empNameValue = new System.Windows.Forms.Label();
            this.departmentValue = new System.Windows.Forms.Label();
            this.roleValue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Panel";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(29, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "Employee LIst";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(29, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 83);
            this.button2.TabIndex = 2;
            this.button2.Text = "Task List";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(162, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 83);
            this.button3.TabIndex = 3;
            this.button3.Text = "Assign Employees";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(162, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 83);
            this.button4.TabIndex = 4;
            this.button4.Text = "Unassign Employees";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // empId
            // 
            this.empId.AutoSize = true;
            this.empId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empId.Location = new System.Drawing.Point(329, 210);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(56, 16);
            this.empId.TabIndex = 5;
            this.empId.Text = "Emp Id";
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.Location = new System.Drawing.Point(329, 260);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(84, 16);
            this.empName.TabIndex = 6;
            this.empName.Text = "Emp Name";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.Location = new System.Drawing.Point(329, 305);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(88, 16);
            this.department.TabIndex = 7;
            this.department.Text = "Department";
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.Location = new System.Drawing.Point(329, 345);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(41, 16);
            this.role.TabIndex = 8;
            this.role.Text = "Role";
            // 
            // empIdValue
            // 
            this.empIdValue.AutoSize = true;
            this.empIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdValue.Location = new System.Drawing.Point(441, 210);
            this.empIdValue.Name = "empIdValue";
            this.empIdValue.Size = new System.Drawing.Size(51, 16);
            this.empIdValue.TabIndex = 9;
            this.empIdValue.Text = "label2";
            // 
            // empNameValue
            // 
            this.empNameValue.AutoSize = true;
            this.empNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameValue.Location = new System.Drawing.Point(441, 256);
            this.empNameValue.Name = "empNameValue";
            this.empNameValue.Size = new System.Drawing.Size(51, 16);
            this.empNameValue.TabIndex = 10;
            this.empNameValue.Text = "label3";
            // 
            // departmentValue
            // 
            this.departmentValue.AutoSize = true;
            this.departmentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentValue.Location = new System.Drawing.Point(441, 305);
            this.departmentValue.Name = "departmentValue";
            this.departmentValue.Size = new System.Drawing.Size(51, 16);
            this.departmentValue.TabIndex = 11;
            this.departmentValue.Text = "label4";
            // 
            // roleValue
            // 
            this.roleValue.AutoSize = true;
            this.roleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleValue.Location = new System.Drawing.Point(444, 344);
            this.roleValue.Name = "roleValue";
            this.roleValue.Size = new System.Drawing.Size(51, 16);
            this.roleValue.TabIndex = 12;
            this.roleValue.Text = "label5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 123);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(571, 414);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roleValue);
            this.Controls.Add(this.departmentValue);
            this.Controls.Add(this.empNameValue);
            this.Controls.Add(this.empIdValue);
            this.Controls.Add(this.role);
            this.Controls.Add(this.department);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.empId);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManagerPanel";
            this.Text = "ManagerPanel";
            this.Load += new System.EventHandler(this.ManagerPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label empId;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label empIdValue;
        private System.Windows.Forms.Label empNameValue;
        private System.Windows.Forms.Label departmentValue;
        private System.Windows.Forms.Label roleValue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
