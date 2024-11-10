namespace WindowsFormsApp1.Presentation_Layer
{
    partial class frmAddStudent
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.edtID = new System.Windows.Forms.TextBox();
            this.edtName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.edtAge = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.edtSurname = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.pnlID = new System.Windows.Forms.Panel();
            this.pnlName = new System.Windows.Forms.Panel();
            this.pnlSurname = new System.Windows.Forms.Panel();
            this.pnlAge = new System.Windows.Forms.Panel();
            this.pnlCourse = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlID.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlSurname.SuspendLayout();
            this.pnlAge.SuspendLayout();
            this.pnlCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(-19, -18);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(173, 84);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // edtID
            // 
            this.edtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtID.Location = new System.Drawing.Point(1, 1);
            this.edtID.Name = "edtID";
            this.edtID.Size = new System.Drawing.Size(291, 35);
            this.edtID.TabIndex = 1;
            // 
            // edtName
            // 
            this.edtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtName.Location = new System.Drawing.Point(1, 1);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(290, 35);
            this.edtName.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(155, 110);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(130, 29);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "Student ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(155, 167);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 29);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // cmbCourse
            // 
            this.cmbCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "Data Science",
            "Programming",
            "Cyber Security",
            "Tech Support",
            "Graphic Design"});
            this.cmbCourse.Location = new System.Drawing.Point(1, 1);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(290, 37);
            this.cmbCourse.TabIndex = 7;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(155, 329);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(97, 29);
            this.lblCourse.TabIndex = 8;
            this.lblCourse.Text = "Course:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(155, 274);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(62, 29);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "Age:";
            // 
            // edtAge
            // 
            this.edtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtAge.Location = new System.Drawing.Point(1, 1);
            this.edtAge.Name = "edtAge";
            this.edtAge.Size = new System.Drawing.Size(290, 35);
            this.edtAge.TabIndex = 9;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(155, 220);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(116, 29);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname:";
            // 
            // edtSurname
            // 
            this.edtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtSurname.Location = new System.Drawing.Point(1, 1);
            this.edtSurname.Name = "edtSurname";
            this.edtSurname.Size = new System.Drawing.Size(290, 35);
            this.edtSurname.TabIndex = 3;
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
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(290, 30);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(240, 31);
            this.lblView.TabIndex = 0;
            this.lblView.Text = "Add New Student";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Turquoise;
            this.panel5.Controls.Add(this.lblTime);
            this.panel5.Controls.Add(this.lblDate);
            this.panel5.Controls.Add(this.lblView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(801, 89);
            this.panel5.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Location = new System.Drawing.Point(336, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 54);
            this.panel1.TabIndex = 19;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(727, 404);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(61, 34);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pnlID
            // 
            this.pnlID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlID.Controls.Add(this.edtID);
            this.pnlID.Location = new System.Drawing.Point(326, 110);
            this.pnlID.Margin = new System.Windows.Forms.Padding(4);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(293, 37);
            this.pnlID.TabIndex = 21;
            // 
            // pnlName
            // 
            this.pnlName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlName.Controls.Add(this.edtName);
            this.pnlName.Location = new System.Drawing.Point(327, 167);
            this.pnlName.Margin = new System.Windows.Forms.Padding(4);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(293, 37);
            this.pnlName.TabIndex = 22;
            // 
            // pnlSurname
            // 
            this.pnlSurname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlSurname.Controls.Add(this.edtSurname);
            this.pnlSurname.Location = new System.Drawing.Point(327, 220);
            this.pnlSurname.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSurname.Name = "pnlSurname";
            this.pnlSurname.Size = new System.Drawing.Size(293, 37);
            this.pnlSurname.TabIndex = 23;
            // 
            // pnlAge
            // 
            this.pnlAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlAge.Controls.Add(this.edtAge);
            this.pnlAge.Location = new System.Drawing.Point(326, 274);
            this.pnlAge.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAge.Name = "pnlAge";
            this.pnlAge.Size = new System.Drawing.Size(293, 37);
            this.pnlAge.TabIndex = 24;
            // 
            // pnlCourse
            // 
            this.pnlCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCourse.Controls.Add(this.cmbCourse);
            this.pnlCourse.Location = new System.Drawing.Point(326, 329);
            this.pnlCourse.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCourse.Name = "pnlCourse";
            this.pnlCourse.Size = new System.Drawing.Size(293, 39);
            this.pnlCourse.TabIndex = 25;
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 451);
            this.Controls.Add(this.pnlCourse);
            this.Controls.Add(this.pnlAge);
            this.Controls.Add(this.pnlSurname);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.pnlID);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Name = "frmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddStudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddStudent_FormClosing);
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlSurname.ResumeLayout(false);
            this.pnlSurname.PerformLayout();
            this.pnlAge.ResumeLayout(false);
            this.pnlAge.PerformLayout();
            this.pnlCourse.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox edtID;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox edtAge;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox edtSurname;

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Panel pnlSurname;
        private System.Windows.Forms.Panel pnlAge;
        private System.Windows.Forms.Panel pnlCourse;
    }
}