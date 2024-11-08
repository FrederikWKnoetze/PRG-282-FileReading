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
            this.radLesser = new System.Windows.Forms.RadioButton();
            this.edtAge = new System.Windows.Forms.TextBox();
            this.grpRadio = new System.Windows.Forms.GroupBox();
            this.radEqual = new System.Windows.Forms.RadioButton();
            this.radGreater = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.edtName = new System.Windows.Forms.TextBox();
            this.grpSortBy = new System.Windows.Forms.GroupBox();
            this.cmbCategorySortBy = new System.Windows.Forms.ComboBox();
            this.radAscending = new System.Windows.Forms.RadioButton();
            this.radDecending = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.edtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudents)).BeginInit();
            this.grpRadio.SuspendLayout();
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
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(626, 285);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(131, 21);
            this.cmbCourse.TabIndex = 4;
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
            this.lblAge.Location = new System.Drawing.Point(523, 153);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            // 
            // radLesser
            // 
            this.radLesser.AutoSize = true;
            this.radLesser.Location = new System.Drawing.Point(29, 19);
            this.radLesser.Name = "radLesser";
            this.radLesser.Size = new System.Drawing.Size(37, 17);
            this.radLesser.TabIndex = 7;
            this.radLesser.TabStop = true;
            this.radLesser.Text = "<=";
            this.radLesser.UseVisualStyleBackColor = true;
            // 
            // edtAge
            // 
            this.edtAge.Location = new System.Drawing.Point(640, 153);
            this.edtAge.Name = "edtAge";
            this.edtAge.Size = new System.Drawing.Size(100, 20);
            this.edtAge.TabIndex = 8;
            // 
            // grpRadio
            // 
            this.grpRadio.Controls.Add(this.radEqual);
            this.grpRadio.Controls.Add(this.radGreater);
            this.grpRadio.Controls.Add(this.radLesser);
            this.grpRadio.Location = new System.Drawing.Point(526, 179);
            this.grpRadio.Name = "grpRadio";
            this.grpRadio.Size = new System.Drawing.Size(200, 100);
            this.grpRadio.TabIndex = 9;
            this.grpRadio.TabStop = false;
            this.grpRadio.Text = "Age";
            // 
            // radEqual
            // 
            this.radEqual.AutoSize = true;
            this.radEqual.Location = new System.Drawing.Point(29, 65);
            this.radEqual.Name = "radEqual";
            this.radEqual.Size = new System.Drawing.Size(31, 17);
            this.radEqual.TabIndex = 9;
            this.radEqual.TabStop = true;
            this.radEqual.Text = "=";
            this.radEqual.UseVisualStyleBackColor = true;
            // 
            // radGreater
            // 
            this.radGreater.AutoSize = true;
            this.radGreater.Location = new System.Drawing.Point(29, 42);
            this.radGreater.Name = "radGreater";
            this.radGreater.Size = new System.Drawing.Size(37, 17);
            this.radGreater.TabIndex = 8;
            this.radGreater.TabStop = true;
            this.radGreater.Text = ">=";
            this.radGreater.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(521, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(606, 65);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(100, 20);
            this.edtName.TabIndex = 11;
            // 
            // grpSortBy
            // 
            this.grpSortBy.Controls.Add(this.cmbCategorySortBy);
            this.grpSortBy.Controls.Add(this.radAscending);
            this.grpSortBy.Controls.Add(this.radDecending);
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
            // 
            // radAscending
            // 
            this.radAscending.AutoSize = true;
            this.radAscending.Location = new System.Drawing.Point(104, 47);
            this.radAscending.Name = "radAscending";
            this.radAscending.Size = new System.Drawing.Size(76, 17);
            this.radAscending.TabIndex = 8;
            this.radAscending.TabStop = true;
            this.radAscending.Text = "Adcending";
            this.radAscending.UseVisualStyleBackColor = true;
            // 
            // radDecending
            // 
            this.radDecending.AutoSize = true;
            this.radDecending.Location = new System.Drawing.Point(21, 47);
            this.radDecending.Name = "radDecending";
            this.radDecending.Size = new System.Drawing.Size(77, 17);
            this.radDecending.TabIndex = 7;
            this.radDecending.TabStop = true;
            this.radDecending.Text = "Decending";
            this.radDecending.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(586, 415);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // edtID
            // 
            this.edtID.Location = new System.Drawing.Point(640, 111);
            this.edtID.Name = "edtID";
            this.edtID.Size = new System.Drawing.Size(100, 20);
            this.edtID.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(523, 111);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "Student ID";
            // 
            // frmViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpSortBy);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grpRadio);
            this.Controls.Add(this.edtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lnlParamaters);
            this.Controls.Add(this.btnReporty);
            this.Controls.Add(this.dgvViewStudents);
            this.Name = "frmViewStudents";
            this.Text = "frmViewStudents";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudents)).EndInit();
            this.grpRadio.ResumeLayout(false);
            this.grpRadio.PerformLayout();
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
        private System.Windows.Forms.RadioButton radLesser;
        private System.Windows.Forms.TextBox edtAge;
        private System.Windows.Forms.GroupBox grpRadio;
        private System.Windows.Forms.RadioButton radEqual;
        private System.Windows.Forms.RadioButton radGreater;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.GroupBox grpSortBy;
        private System.Windows.Forms.RadioButton radAscending;
        private System.Windows.Forms.RadioButton radDecending;
        private System.Windows.Forms.ComboBox cmbCategorySortBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox edtID;
        private System.Windows.Forms.Label lblID;
    }
}