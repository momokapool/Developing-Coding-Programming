namespace Coursework_Student_Management
{
    partial class ModifyTeacherForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.teacherGender = new System.Windows.Forms.ComboBox();
            this.teacherTelephone = new System.Windows.Forms.TextBox();
            this.teacherPassword = new System.Windows.Forms.TextBox();
            this.teacherEmail = new System.Windows.Forms.TextBox();
            this.teacherName = new System.Windows.Forms.TextBox();
            this.teacherID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teacherDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.subjectID = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.subjectID);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Clear);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.Update);
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.teacherGender);
            this.panel2.Controls.Add(this.teacherTelephone);
            this.panel2.Controls.Add(this.teacherPassword);
            this.panel2.Controls.Add(this.teacherEmail);
            this.panel2.Controls.Add(this.teacherName);
            this.panel2.Controls.Add(this.teacherID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(10, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 189);
            this.panel2.TabIndex = 4;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(618, 138);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(104, 35);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(618, 96);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(104, 35);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(618, 55);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(104, 35);
            this.Update.TabIndex = 13;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(618, 14);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(104, 35);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // teacherGender
            // 
            this.teacherGender.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female "});
            this.teacherGender.FormattingEnabled = true;
            this.teacherGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.teacherGender.Location = new System.Drawing.Point(91, 135);
            this.teacherGender.Name = "teacherGender";
            this.teacherGender.Size = new System.Drawing.Size(121, 21);
            this.teacherGender.TabIndex = 11;
            // 
            // teacherTelephone
            // 
            this.teacherTelephone.Location = new System.Drawing.Point(358, 105);
            this.teacherTelephone.Multiline = true;
            this.teacherTelephone.Name = "teacherTelephone";
            this.teacherTelephone.Size = new System.Drawing.Size(169, 33);
            this.teacherTelephone.TabIndex = 10;
            // 
            // teacherPassword
            // 
            this.teacherPassword.Location = new System.Drawing.Point(358, 56);
            this.teacherPassword.Multiline = true;
            this.teacherPassword.Name = "teacherPassword";
            this.teacherPassword.Size = new System.Drawing.Size(169, 33);
            this.teacherPassword.TabIndex = 9;
            // 
            // teacherEmail
            // 
            this.teacherEmail.Location = new System.Drawing.Point(358, 14);
            this.teacherEmail.Multiline = true;
            this.teacherEmail.Name = "teacherEmail";
            this.teacherEmail.Size = new System.Drawing.Size(169, 33);
            this.teacherEmail.TabIndex = 8;
            // 
            // teacherName
            // 
            this.teacherName.Location = new System.Drawing.Point(91, 73);
            this.teacherName.Multiline = true;
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(169, 33);
            this.teacherName.TabIndex = 7;
            // 
            // teacherID
            // 
            this.teacherID.Location = new System.Drawing.Point(91, 14);
            this.teacherID.Multiline = true;
            this.teacherID.Name = "teacherID";
            this.teacherID.Size = new System.Drawing.Size(84, 35);
            this.teacherID.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Teacher email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Teacher name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TeacherID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.teacherDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 337);
            this.panel1.TabIndex = 3;
            // 
            // teacherDataGridView
            // 
            this.teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataGridView.Location = new System.Drawing.Point(12, 30);
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.Size = new System.Drawing.Size(755, 295);
            this.teacherDataGridView.TabIndex = 1;
            this.teacherDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Subjects";
            // 
            // subjectID
            // 
            this.subjectID.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female "});
            this.subjectID.FormattingEnabled = true;
            this.subjectID.Items.AddRange(new object[] {
            "Programming Foundation",
            "Database",
            "OOP",
            "Networking",
            "DSA",
            "Operating System",
            "Math",
            "English"});
            this.subjectID.Location = new System.Drawing.Point(358, 152);
            this.subjectID.Name = "subjectID";
            this.subjectID.Size = new System.Drawing.Size(121, 21);
            this.subjectID.TabIndex = 17;
            // 
            // ModifyTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ModifyTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyTeacherForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox teacherGender;
        private System.Windows.Forms.TextBox teacherTelephone;
        private System.Windows.Forms.TextBox teacherPassword;
        private System.Windows.Forms.TextBox teacherEmail;
        private System.Windows.Forms.TextBox teacherName;
        private System.Windows.Forms.TextBox teacherID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView teacherDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox subjectID;
        private System.Windows.Forms.Label label8;
    }
}