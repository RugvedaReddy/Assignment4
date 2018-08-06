namespace StudentProfile
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
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblrollno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldateofjoining = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.CbDepartment = new System.Windows.Forms.ComboBox();
            this.CbCourse = new System.Windows.Forms.ComboBox();
            this.CbSemester = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rbFind = new System.Windows.Forms.Button();
            this.lbselect = new System.Windows.Forms.ListBox();
            this.dtpDOJ = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(220, 36);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(100, 20);
            this.txtRollNo.TabIndex = 0;
            this.txtRollNo.TextChanged += new System.EventHandler(this.txtRollNo_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(220, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblrollno
            // 
            this.lblrollno.AutoSize = true;
            this.lblrollno.Location = new System.Drawing.Point(38, 39);
            this.lblrollno.Name = "lblrollno";
            this.lblrollno.Size = new System.Drawing.Size(42, 13);
            this.lblrollno.TabIndex = 3;
            this.lblrollno.Text = "Roll No";
            this.lblrollno.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // lbldateofjoining
            // 
            this.lbldateofjoining.AutoSize = true;
            this.lbldateofjoining.Location = new System.Drawing.Point(38, 128);
            this.lbldateofjoining.Name = "lbldateofjoining";
            this.lbldateofjoining.Size = new System.Drawing.Size(28, 13);
            this.lbldateofjoining.TabIndex = 5;
            this.lbldateofjoining.Text = "DOJ";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(38, 180);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(42, 13);
            this.lblgender.TabIndex = 6;
            this.lblgender.Text = "Gender";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(38, 232);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(62, 13);
            this.lbldepartment.TabIndex = 7;
            this.lbldepartment.Text = "Department";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Location = new System.Drawing.Point(38, 271);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(40, 13);
            this.lblcourse.TabIndex = 8;
            this.lblcourse.Text = "Course";
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Location = new System.Drawing.Point(38, 312);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(51, 13);
            this.lblsemester.TabIndex = 9;
            this.lblsemester.Text = "Semester";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(38, 352);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(45, 13);
            this.lbladdress.TabIndex = 10;
            this.lbladdress.Text = "Address";
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Location = new System.Drawing.Point(38, 392);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(75, 13);
            this.lblphonenumber.TabIndex = 11;
            this.lblphonenumber.Text = "PhoneNumber";
            this.lblphonenumber.Click += new System.EventHandler(this.lblphonenumber_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(38, 83);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Name";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(220, 180);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 13;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(389, 180);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 14;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // CbDepartment
            // 
            this.CbDepartment.FormattingEnabled = true;
            this.CbDepartment.Items.AddRange(new object[] {
            "Civil Engineering",
            "Computer Science",
            "Mechanical Engineering",
            "IT"});
            this.CbDepartment.Location = new System.Drawing.Point(220, 224);
            this.CbDepartment.Name = "CbDepartment";
            this.CbDepartment.Size = new System.Drawing.Size(121, 21);
            this.CbDepartment.TabIndex = 15;
            // 
            // CbCourse
            // 
            this.CbCourse.FormattingEnabled = true;
            this.CbCourse.Items.AddRange(new object[] {
            "ENGINEERING",
            "BSC",
            "BCA"});
            this.CbCourse.Location = new System.Drawing.Point(220, 263);
            this.CbCourse.Name = "CbCourse";
            this.CbCourse.Size = new System.Drawing.Size(121, 21);
            this.CbCourse.TabIndex = 16;
            // 
            // CbSemester
            // 
            this.CbSemester.FormattingEnabled = true;
            this.CbSemester.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII"});
            this.CbSemester.Location = new System.Drawing.Point(220, 312);
            this.CbSemester.Name = "CbSemester";
            this.CbSemester.Size = new System.Drawing.Size(121, 21);
            this.CbSemester.TabIndex = 17;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(220, 352);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 18;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(220, 392);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 19;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(37, 421);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 20;
            this.btnAddNew.Text = "ADD NEW";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(172, 421);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 21;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(339, 421);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(512, 421);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rbFind
            // 
            this.rbFind.Location = new System.Drawing.Point(441, 34);
            this.rbFind.Name = "rbFind";
            this.rbFind.Size = new System.Drawing.Size(75, 23);
            this.rbFind.TabIndex = 24;
            this.rbFind.Text = "Find";
            this.rbFind.UseVisualStyleBackColor = true;
            this.rbFind.Click += new System.EventHandler(this.rbFind_Click);
            // 
            // lbselect
            // 
            this.lbselect.FormattingEnabled = true;
            this.lbselect.Location = new System.Drawing.Point(609, 129);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(247, 303);
            this.lbselect.TabIndex = 25;
            // 
            // dtpDOJ
            // 
            this.dtpDOJ.Location = new System.Drawing.Point(214, 128);
            this.dtpDOJ.Name = "dtpDOJ";
            this.dtpDOJ.Size = new System.Drawing.Size(200, 20);
            this.dtpDOJ.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 465);
            this.Controls.Add(this.dtpDOJ);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.rbFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.CbSemester);
            this.Controls.Add(this.CbCourse);
            this.Controls.Add(this.CbDepartment);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblphonenumber);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lblcourse);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbldateofjoining);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblrollno);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRollNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblrollno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldateofjoining;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ComboBox CbDepartment;
        private System.Windows.Forms.ComboBox CbCourse;
        private System.Windows.Forms.ComboBox CbSemester;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button rbFind;
        private System.Windows.Forms.ListBox lbselect;
        private System.Windows.Forms.DateTimePicker dtpDOJ;
    }
}

