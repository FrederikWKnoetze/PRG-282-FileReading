namespace WindowsFormsApp1.Presentation_Layer
{
    partial class frmUpdateStudent
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.edtSearchID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.edtAge = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.edtSurname = new System.Windows.Forms.TextBox();
            this.edtName = new System.Windows.Forms.TextBox();
            this.edtID = new System.Windows.Forms.TextBox();
            this.dgvUpdate = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(36, 45);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(133, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Enter Student ID to search";
            // 
            // edtSearchID
            // 
            this.edtSearchID.Location = new System.Drawing.Point(197, 42);
            this.edtSearchID.Name = "edtSearchID";
            this.edtSearchID.Size = new System.Drawing.Size(100, 20);
            this.edtSearchID.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(346, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(513, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(532, 218);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 20;
            this.lblAge.Text = "Age";
            // 
            // edtAge
            // 
            this.edtAge.Location = new System.Drawing.Point(503, 234);
            this.edtAge.Name = "edtAge";
            this.edtAge.Size = new System.Drawing.Size(100, 20);
            this.edtAge.TabIndex = 19;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(527, 277);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 18;
            this.lblCourse.Text = "Course";
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
            this.cmbCourse.Location = new System.Drawing.Point(503, 293);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(121, 21);
            this.cmbCourse.TabIndex = 17;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(531, 160);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 16;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(532, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(532, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(56, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "Student Id";
            // 
            // edtSurname
            // 
            this.edtSurname.Location = new System.Drawing.Point(503, 193);
            this.edtSurname.Name = "edtSurname";
            this.edtSurname.Size = new System.Drawing.Size(100, 20);
            this.edtSurname.TabIndex = 13;
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(503, 120);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(100, 20);
            this.edtName.TabIndex = 12;
            // 
            // edtID
            // 
            this.edtID.Location = new System.Drawing.Point(503, 60);
            this.edtID.Name = "edtID";
            this.edtID.Size = new System.Drawing.Size(100, 20);
            this.edtID.TabIndex = 11;
            // 
            // dgvUpdate
            // 
            this.dgvUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdate.Location = new System.Drawing.Point(57, 120);
            this.dgvUpdate.Name = "dgvUpdate";
            this.dgvUpdate.Size = new System.Drawing.Size(364, 221);
            this.dgvUpdate.TabIndex = 21;
            // 
            // frmUpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUpdate);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.edtAge);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.edtSurname);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.edtID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.edtSearchID);
            this.Controls.Add(this.lblSearch);
            this.Name = "frmUpdateStudent";
            this.Text = "frmUpdateStudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdateStudent_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdateStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox edtSearchID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox edtAge;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox edtSurname;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.TextBox edtID;
        private System.Windows.Forms.DataGridView dgvUpdate;
    }
}