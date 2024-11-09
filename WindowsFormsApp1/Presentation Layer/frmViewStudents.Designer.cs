namespace WindowsFormsApp1.Presentation_Layer
{
    partial class frmViewStudents
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
            this.dgvViewStudents = new System.Windows.Forms.DataGridView();
            this.btnReporty = new System.Windows.Forms.Button();
            this.lnlParamaters = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpSortBy = new System.Windows.Forms.GroupBox();
            this.cmbCategorySortBy = new System.Windows.Forms.ComboBox();
            this.radAscending = new System.Windows.Forms.RadioButton();
            this.radDescending = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudents)).BeginInit();
            this.grpSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewStudents
            // 
            this.dgvViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStudents.Location = new System.Drawing.Point(58, 38);
            this.dgvViewStudents.Name = "dgvViewStudents";
            this.dgvViewStudents.Size = new System.Drawing.Size(389, 248);
            this.dgvViewStudents.TabIndex = 0;
            // 
            // btnReporty
            // 
            this.btnReporty.Location = new System.Drawing.Point(58, 319);
            this.btnReporty.Name = "btnReporty";
            this.btnReporty.Size = new System.Drawing.Size(179, 56);
            this.btnReporty.TabIndex = 1;
            this.btnReporty.Text = "Generate Summary Report";
            this.btnReporty.UseVisualStyleBackColor = true;
            // 
            // lnlParamaters
            // 
            this.lnlParamaters.AutoSize = true;
            this.lnlParamaters.Location = new System.Drawing.Point(601, 19);
            this.lnlParamaters.Name = "lnlParamaters";
            this.lnlParamaters.Size = new System.Drawing.Size(60, 13);
            this.lnlParamaters.TabIndex = 2;
            this.lnlParamaters.Text = "Paramaters";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(268, 319);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(179, 56);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print Data";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "Data Science",
            "Programming",
            "Cyber Security",
            "Tech Support",
            "Graphic Design"});
            this.cmbCourse.Location = new System.Drawing.Point(626, 285);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(131, 21);
            this.cmbCourse.TabIndex = 4;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Course";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(513, 143);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(630, 143);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 8;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(513, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(630, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // grpSortBy
            // 
            this.grpSortBy.Controls.Add(this.cmbCategorySortBy);
            this.grpSortBy.Controls.Add(this.radAscending);
            this.grpSortBy.Controls.Add(this.radDescending);
            this.grpSortBy.Location = new System.Drawing.Point(526, 330);
            this.grpSortBy.Name = "grpSortBy";
            this.grpSortBy.Size = new System.Drawing.Size(214, 70);
            this.grpSortBy.TabIndex = 10;
            this.grpSortBy.TabStop = false;
            this.grpSortBy.Text = "Sort By";
            // 
            // cmbCategorySortBy
            // 
            this.cmbCategorySortBy.FormattingEnabled = true;
            this.cmbCategorySortBy.Location = new System.Drawing.Point(43, 20);
            this.cmbCategorySortBy.Name = "cmbCategorySortBy";
            this.cmbCategorySortBy.Size = new System.Drawing.Size(121, 21);
            this.cmbCategorySortBy.TabIndex = 13;
            this.cmbCategorySortBy.SelectedIndexChanged += new System.EventHandler(this.cmbCategorySortBy_SelectedIndexChanged);
            // 
            // radAscending
            // 
            this.radAscending.AutoSize = true;
            this.radAscending.Location = new System.Drawing.Point(18, 47);
            this.radAscending.Name = "radAscending";
            this.radAscending.Size = new System.Drawing.Size(75, 17);
            this.radAscending.TabIndex = 8;
            this.radAscending.Text = "Ascending";
            this.radAscending.UseVisualStyleBackColor = true;
            this.radAscending.CheckedChanged += new System.EventHandler(this.radAscending_CheckedChanged);
            // 
            // radDescending
            // 
            this.radDescending.AutoSize = true;
            this.radDescending.Location = new System.Drawing.Point(118, 47);
            this.radDescending.Name = "radDescending";
            this.radDescending.Size = new System.Drawing.Size(82, 17);
            this.radDescending.TabIndex = 7;
            this.radDescending.Text = "Descending";
            this.radDescending.UseVisualStyleBackColor = true;
            this.radDescending.CheckedChanged += new System.EventHandler(this.radDescending_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(630, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 14;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(513, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "Student ID";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(630, 115);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 16;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(513, 115);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 15;
            this.lblSurname.Text = "Surname";
            // 
            // frmViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.grpSortBy);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lnlParamaters);
            this.Controls.Add(this.btnReporty);
            this.Controls.Add(this.dgvViewStudents);
            this.Name = "frmViewStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewStudents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewStudents_FormClosing);
            this.Load += new System.EventHandler(this.frmViewStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudents)).EndInit();
            this.grpSortBy.ResumeLayout(false);
            this.grpSortBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewStudents;
        private System.Windows.Forms.Button btnReporty;
        private System.Windows.Forms.Label lnlParamaters;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpSortBy;
        private System.Windows.Forms.RadioButton radAscending;
        private System.Windows.Forms.RadioButton radDescending;
        private System.Windows.Forms.ComboBox cmbCategorySortBy;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
    }
}