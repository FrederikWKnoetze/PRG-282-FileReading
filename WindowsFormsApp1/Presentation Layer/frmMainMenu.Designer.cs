namespace WindowsFormsApp1
{
    partial class frmMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStudents.Location = new System.Drawing.Point(-30, -15);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(227, 96);
            this.btnViewStudents.TabIndex = 0;
            this.btnViewStudents.Text = "View Students";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // panel1
            // 

            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnViewStudents);
            this.panel1.Location = new System.Drawing.Point(130, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 68);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 

            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(483, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 68);
            this.panel2.TabIndex = 6;

            // 
            // btnAdd
            // 

            this.btnAdd.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(-29, -15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 96);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Location = new System.Drawing.Point(483, 308);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 68);
            this.panel3.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(-29, -16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(227, 96);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Location = new System.Drawing.Point(130, 308);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 68);
            this.panel4.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(-30, -16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(227, 96);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Turquoise;
            this.panel5.Controls.Add(this.lblTime);
            this.panel5.Controls.Add(this.lblDate);
            this.panel5.Controls.Add(this.lblMenu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 89);
            this.panel5.TabIndex = 9;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(327, 29);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(155, 31);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Main Menu";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(699, 36);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 25);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
    }
}

