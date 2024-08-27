namespace MasterDetailsCRUDAPP
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Print = new System.Windows.Forms.Button();
            this.dgvTrainee = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImageClear = new System.Windows.Forms.Button();
            this.btnImageBrowse = new System.Windows.Forms.Button();
            this.txtTraineeName = new System.Windows.Forms.TextBox();
            this.txtTraineeID = new System.Windows.Forms.TextBox();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.dgvEnrollCourse = new System.Windows.Forms.DataGridView();
            this.dgvtxtEnrollCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEnrollDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbCourse = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtEnrollFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainee)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollCourse)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.tabPage2.Controls.Add(this.Print);
            this.tabPage2.Controls.Add(this.dgvTrainee);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trainee Register";
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(293, 6);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(127, 36);
            this.Print.TabIndex = 13;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // dgvTrainee
            // 
            this.dgvTrainee.AllowUserToAddRows = false;
            this.dgvTrainee.AllowUserToDeleteRows = false;
            this.dgvTrainee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.dgvTrainee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrainee.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrainee.Location = new System.Drawing.Point(17, 45);
            this.dgvTrainee.Name = "dgvTrainee";
            this.dgvTrainee.ReadOnly = true;
            this.dgvTrainee.RowTemplate.Height = 30;
            this.dgvTrainee.Size = new System.Drawing.Size(729, 506);
            this.dgvTrainee.TabIndex = 3;
            this.dgvTrainee.DoubleClick += new System.EventHandler(this.dgvTrainee_DoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbCourse);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnImageClear);
            this.tabPage1.Controls.Add(this.btnImageBrowse);
            this.tabPage1.Controls.Add(this.txtTraineeName);
            this.tabPage1.Controls.Add(this.txtTraineeID);
            this.tabPage1.Controls.Add(this.pbxPhoto);
            this.tabPage1.Controls.Add(this.dgvEnrollCourse);
            this.tabPage1.Controls.Add(this.cmbGender);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dtpDOB);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trainee Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Course Name";
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "PHP",
            "JAVA",
            "WPF"});
            this.cmbCourse.Location = new System.Drawing.Point(127, 230);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(251, 28);
            this.cmbCourse.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(6, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 49);
            this.panel1.TabIndex = 11;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(96)))));
            this.btnReset.Location = new System.Drawing.Point(425, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 30);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(96)))));
            this.btnDelete.Location = new System.Drawing.Point(339, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(96)))));
            this.btnSave.Location = new System.Drawing.Point(253, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImageClear
            // 
            this.btnImageClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.btnImageClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(96)))));
            this.btnImageClear.Location = new System.Drawing.Point(648, 181);
            this.btnImageClear.Name = "btnImageClear";
            this.btnImageClear.Size = new System.Drawing.Size(87, 27);
            this.btnImageClear.TabIndex = 9;
            this.btnImageClear.Text = "Clear";
            this.btnImageClear.UseVisualStyleBackColor = false;
            this.btnImageClear.Click += new System.EventHandler(this.btnImageClear_Click);
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.btnImageBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(96)))));
            this.btnImageBrowse.Location = new System.Drawing.Point(460, 181);
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.Size = new System.Drawing.Size(92, 27);
            this.btnImageBrowse.TabIndex = 8;
            this.btnImageBrowse.Text = "Browse";
            this.btnImageBrowse.UseVisualStyleBackColor = false;
            this.btnImageBrowse.Click += new System.EventHandler(this.btnImageBrowse_Click);
            // 
            // txtTraineeName
            // 
            this.txtTraineeName.BackColor = System.Drawing.SystemColors.Window;
            this.txtTraineeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraineeName.Location = new System.Drawing.Point(127, 78);
            this.txtTraineeName.Name = "txtTraineeName";
            this.txtTraineeName.Size = new System.Drawing.Size(251, 26);
            this.txtTraineeName.TabIndex = 2;
            // 
            // txtTraineeID
            // 
            this.txtTraineeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraineeID.Location = new System.Drawing.Point(127, 30);
            this.txtTraineeID.Name = "txtTraineeID";
            this.txtTraineeID.Size = new System.Drawing.Size(251, 26);
            this.txtTraineeID.TabIndex = 1;
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Location = new System.Drawing.Point(460, 6);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(275, 169);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPhoto.TabIndex = 6;
            this.pbxPhoto.TabStop = false;
            // 
            // dgvEnrollCourse
            // 
            this.dgvEnrollCourse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.dgvEnrollCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtEnrollCourseID,
            this.dgvtxtEnrollDate,
            this.dgvcmbCourse,
            this.dgvtxtEnrollFee});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEnrollCourse.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEnrollCourse.Location = new System.Drawing.Point(6, 339);
            this.dgvEnrollCourse.Name = "dgvEnrollCourse";
            this.dgvEnrollCourse.Size = new System.Drawing.Size(754, 158);
            this.dgvEnrollCourse.TabIndex = 10;
            this.dgvEnrollCourse.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvTraineeTSP_UserDeletingRow);
            // 
            // dgvtxtEnrollCourseID
            // 
            this.dgvtxtEnrollCourseID.DataPropertyName = "EnrollCourseID";
            this.dgvtxtEnrollCourseID.HeaderText = "EnrollCourseID";
            this.dgvtxtEnrollCourseID.Name = "dgvtxtEnrollCourseID";
            this.dgvtxtEnrollCourseID.Visible = false;
            // 
            // dgvtxtEnrollDate
            // 
            this.dgvtxtEnrollDate.DataPropertyName = "EnrollDate";
            this.dgvtxtEnrollDate.HeaderText = "Enrollment Date";
            this.dgvtxtEnrollDate.Name = "dgvtxtEnrollDate";
            this.dgvtxtEnrollDate.Width = 300;
            // 
            // dgvcmbCourse
            // 
            this.dgvcmbCourse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcmbCourse.DataPropertyName = "CourseID";
            this.dgvcmbCourse.HeaderText = "Course Name";
            this.dgvcmbCourse.Name = "dgvcmbCourse";
            // 
            // dgvtxtEnrollFee
            // 
            this.dgvtxtEnrollFee.DataPropertyName = "EnrollFee";
            this.dgvtxtEnrollFee.HeaderText = "Fee";
            this.dgvtxtEnrollFee.Name = "dgvtxtEnrollFee";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(127, 178);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(251, 28);
            this.cmbGender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.label4.Location = new System.Drawing.Point(10, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MM-yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(127, 129);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(251, 26);
            this.dtpDOB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trainee ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trainee Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.label5.Location = new System.Drawing.Point(10, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(774, 606);
            this.tabControl.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(797, 626);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "C# Master Details CRUD APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainee)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollCourse)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTrainee;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImageClear;
        private System.Windows.Forms.Button btnImageBrowse;
        private System.Windows.Forms.TextBox txtTraineeName;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.DataGridView dgvEnrollCourse;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TextBox txtTraineeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEnrollCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEnrollDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEnrollFee;
    }
}

