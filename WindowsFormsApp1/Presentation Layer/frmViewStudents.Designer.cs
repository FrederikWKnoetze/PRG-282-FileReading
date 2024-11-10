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
            this.components = new System.ComponentModel.Container();
            this.dgvViewStudents = new System.Windows.Forms.DataGridView();
            this.btnReporty = new System.Windows.Forms.Button();
            this.lblParamaters = new System.Windows.Forms.Label();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudents)).BeginInit();
            this.grpSortBy.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewStudents
            // 
            this.dgvViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStudents.Location = new System.Drawing.Point(-1, 88);
            this.dgvViewStudents.Name = "dgvViewStudents";
            this.dgvViewStudents.Size = new System.Drawing.Size(489, 281);
            this.dgvViewStudents.TabIndex = 0;
            // 
            // btnReporty
            // 
            this.btnReporty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporty.Location = new System.Drawing.Point(-3, -4);
            this.btnReporty.Name = "btnReporty";
            this.btnReporty.Size = new System.Drawing.Size(165, 65);
            this.btnReporty.TabIndex = 1;
            this.btnReporty.Text = "Generate Summary Report";
            this.btnReporty.UseVisualStyleBackColor = true;
            // 
            // lblParamaters
            // 
            this.lblParamaters.AutoSize = true;
            this.lblParamaters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParamaters.Location = new System.Drawing.Point(598, 101);
            this.lblParamaters.Name = "lblParamaters";
            this.lblParamaters.Size = new System.Drawing.Size(104, 24);
            this.lblParamaters.TabIndex = 2;
            this.lblParamaters.Text = "Paramaters";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(-10, -3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(179, 61);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print Data";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(593, 290);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(195, 21);
            this.cmbCourse.TabIndex = 4;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Course";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(509, 217);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(593, 250);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(195, 20);
            this.txtAge.TabIndex = 8;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(509, 182);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(593, 179);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 20);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // grpSortBy
            // 
            this.grpSortBy.Controls.Add(this.cmbCategorySortBy);
            this.grpSortBy.Controls.Add(this.radAscending);
            this.grpSortBy.Controls.Add(this.radDescending);
            this.grpSortBy.Location = new System.Drawing.Point(504, 338);
            this.grpSortBy.Name = "grpSortBy";
            this.grpSortBy.Size = new System.Drawing.Size(284, 70);
            this.grpSortBy.TabIndex = 10;
            this.grpSortBy.TabStop = false;
            this.grpSortBy.Text = "Sort By";
            // 
            // cmbCategorySortBy
            // 
            this.cmbCategorySortBy.FormattingEnabled = true;
            this.cmbCategorySortBy.Location = new System.Drawing.Point(43, 20);
            this.cmbCategorySortBy.Name = "cmbCategorySortBy";
            this.cmbCategorySortBy.Size = new System.Drawing.Size(190, 21);
            this.cmbCategorySortBy.TabIndex = 13;
            this.cmbCategorySortBy.SelectedIndexChanged += new System.EventHandler(this.cmbCategorySortBy_SelectedIndexChanged);
            // 
            // radAscending
            // 
            this.radAscending.AutoSize = true;
            this.radAscending.Location = new System.Drawing.Point(43, 47);
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
            this.radDescending.Location = new System.Drawing.Point(151, 47);
            this.radDescending.Name = "radDescending";
            this.radDescending.Size = new System.Drawing.Size(82, 17);
            this.radDescending.TabIndex = 7;
            this.radDescending.Text = "Descending";
            this.radDescending.UseVisualStyleBackColor = true;
            this.radDescending.CheckedChanged += new System.EventHandler(this.radDescending_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(593, 144);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(195, 20);
            this.txtID.TabIndex = 14;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(509, 147);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "Student ID";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(593, 214);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(195, 20);
            this.txtSurname.TabIndex = 16;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(509, 253);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 15;
            this.lblSurname.Text = "Surname";
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
            this.panel5.Size = new System.Drawing.Size(800, 89);
            this.panel5.TabIndex = 17;
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
            this.lblView.Location = new System.Drawing.Point(307, 30);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(201, 31);
            this.lblView.TabIndex = 0;
            this.lblView.Text = "View Students";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReporty);
            this.panel1.Location = new System.Drawing.Point(42, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 53);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Location = new System.Drawing.Point(298, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 53);
            this.panel2.TabIndex = 19;
            // 
            // frmViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
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
            this.Controls.Add(this.lblParamaters);
            this.Controls.Add(this.dgvViewStudents);
            this.Name = "frmViewStudents";
            this.Text = "frmViewStudents";
            this.Load += new System.EventHandler(this.frmViewStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudents)).EndInit();
            this.grpSortBy.ResumeLayout(false);
            this.grpSortBy.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewStudents;
        private System.Windows.Forms.Button btnReporty;
        private System.Windows.Forms.Label lblParamaters;
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}