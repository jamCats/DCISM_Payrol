namespace HR_Admin
{
    partial class UpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.genderfield = new System.Windows.Forms.GroupBox();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.salaryfield = new System.Windows.Forms.TextBox();
            this.positionfield = new System.Windows.Forms.TextBox();
            this.dateofEmploymentfield = new System.Windows.Forms.DateTimePicker();
            this.emrgcyContactfield = new System.Windows.Forms.TextBox();
            this.perAddfield = new System.Windows.Forms.TextBox();
            this.currentAddfield = new System.Windows.Forms.TextBox();
            this.nationalityfield = new System.Windows.Forms.TextBox();
            this.maritalfield = new System.Windows.Forms.ComboBox();
            this.religionfield = new System.Windows.Forms.TextBox();
            this.contactfield = new System.Windows.Forms.TextBox();
            this.emailfield = new System.Windows.Forms.TextBox();
            this.bdayfield = new System.Windows.Forms.DateTimePicker();
            this.lNamefield = new System.Windows.Forms.TextBox();
            this.MIfield = new System.Windows.Forms.TextBox();
            this.fNamefield = new System.Windows.Forms.TextBox();
            this.IDfield = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.genderfield.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(740, 381);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 52;
            this.Create.Text = "Update";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Create_KeyPress);
            // 
            // genderfield
            // 
            this.genderfield.Controls.Add(this.Female);
            this.genderfield.Controls.Add(this.Male);
            this.genderfield.Location = new System.Drawing.Point(76, 302);
            this.genderfield.Name = "genderfield";
            this.genderfield.Size = new System.Drawing.Size(256, 52);
            this.genderfield.TabIndex = 51;
            this.genderfield.TabStop = false;
            this.genderfield.Text = "Gender";
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(172, 21);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(75, 21);
            this.Female.TabIndex = 1;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(6, 21);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(59, 21);
            this.Male.TabIndex = 0;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // salaryfield
            // 
            this.salaryfield.Location = new System.Drawing.Point(682, 205);
            this.salaryfield.Name = "salaryfield";
            this.salaryfield.Size = new System.Drawing.Size(196, 22);
            this.salaryfield.TabIndex = 50;
            this.salaryfield.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salaryfield_KeyPress);
            // 
            // positionfield
            // 
            this.positionfield.Location = new System.Drawing.Point(682, 145);
            this.positionfield.Name = "positionfield";
            this.positionfield.Size = new System.Drawing.Size(196, 22);
            this.positionfield.TabIndex = 49;
            // 
            // dateofEmploymentfield
            // 
            this.dateofEmploymentfield.Location = new System.Drawing.Point(407, 513);
            this.dateofEmploymentfield.Name = "dateofEmploymentfield";
            this.dateofEmploymentfield.Size = new System.Drawing.Size(241, 22);
            this.dateofEmploymentfield.TabIndex = 48;
            // 
            // emrgcyContactfield
            // 
            this.emrgcyContactfield.Location = new System.Drawing.Point(407, 443);
            this.emrgcyContactfield.Name = "emrgcyContactfield";
            this.emrgcyContactfield.Size = new System.Drawing.Size(196, 22);
            this.emrgcyContactfield.TabIndex = 47;
            this.emrgcyContactfield.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emrgcyContactfield_KeyPress);
            // 
            // perAddfield
            // 
            this.perAddfield.Location = new System.Drawing.Point(407, 383);
            this.perAddfield.Name = "perAddfield";
            this.perAddfield.Size = new System.Drawing.Size(196, 22);
            this.perAddfield.TabIndex = 46;
            // 
            // currentAddfield
            // 
            this.currentAddfield.Location = new System.Drawing.Point(407, 325);
            this.currentAddfield.Name = "currentAddfield";
            this.currentAddfield.Size = new System.Drawing.Size(196, 22);
            this.currentAddfield.TabIndex = 45;
            // 
            // nationalityfield
            // 
            this.nationalityfield.Location = new System.Drawing.Point(407, 266);
            this.nationalityfield.Name = "nationalityfield";
            this.nationalityfield.Size = new System.Drawing.Size(196, 22);
            this.nationalityfield.TabIndex = 44;
            // 
            // maritalfield
            // 
            this.maritalfield.FormattingEnabled = true;
            this.maritalfield.Items.AddRange(new object[] {
            "Married",
            "Single",
            "Divorced",
            "Widowed"});
            this.maritalfield.Location = new System.Drawing.Point(407, 203);
            this.maritalfield.Name = "maritalfield";
            this.maritalfield.Size = new System.Drawing.Size(196, 24);
            this.maritalfield.TabIndex = 43;
            // 
            // religionfield
            // 
            this.religionfield.Location = new System.Drawing.Point(407, 145);
            this.religionfield.Name = "religionfield";
            this.religionfield.Size = new System.Drawing.Size(196, 22);
            this.religionfield.TabIndex = 42;
            // 
            // contactfield
            // 
            this.contactfield.Location = new System.Drawing.Point(76, 513);
            this.contactfield.Name = "contactfield";
            this.contactfield.Size = new System.Drawing.Size(247, 22);
            this.contactfield.TabIndex = 41;
            this.contactfield.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactfield_KeyPress);
            // 
            // emailfield
            // 
            this.emailfield.Location = new System.Drawing.Point(76, 443);
            this.emailfield.Name = "emailfield";
            this.emailfield.Size = new System.Drawing.Size(247, 22);
            this.emailfield.TabIndex = 40;
            // 
            // bdayfield
            // 
            this.bdayfield.Location = new System.Drawing.Point(76, 383);
            this.bdayfield.Name = "bdayfield";
            this.bdayfield.Size = new System.Drawing.Size(247, 22);
            this.bdayfield.TabIndex = 39;
            // 
            // lNamefield
            // 
            this.lNamefield.Location = new System.Drawing.Point(76, 267);
            this.lNamefield.Name = "lNamefield";
            this.lNamefield.Size = new System.Drawing.Size(247, 22);
            this.lNamefield.TabIndex = 38;
            // 
            // MIfield
            // 
            this.MIfield.Location = new System.Drawing.Point(76, 205);
            this.MIfield.MaxLength = 1;
            this.MIfield.Name = "MIfield";
            this.MIfield.Size = new System.Drawing.Size(247, 22);
            this.MIfield.TabIndex = 37;
            // 
            // fNamefield
            // 
            this.fNamefield.Location = new System.Drawing.Point(76, 145);
            this.fNamefield.Name = "fNamefield";
            this.fNamefield.Size = new System.Drawing.Size(247, 22);
            this.fNamefield.TabIndex = 36;
            // 
            // IDfield
            // 
            this.IDfield.Location = new System.Drawing.Point(76, 63);
            this.IDfield.Name = "IDfield";
            this.IDfield.Size = new System.Drawing.Size(100, 22);
            this.IDfield.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Enter Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "First Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Middle Initial";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Last Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Birth Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Contact No.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 61;
            this.label9.Text = "Religion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(404, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 62;
            this.label10.Text = "Marital Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(404, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 63;
            this.label11.Text = "Nationality";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(404, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 64;
            this.label12.Text = "Current Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(404, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 17);
            this.label13.TabIndex = 65;
            this.label13.Text = "Permanent Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(404, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 17);
            this.label14.TabIndex = 66;
            this.label14.Text = "Emergency Contact";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(404, 493);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 17);
            this.label15.TabIndex = 67;
            this.label15.Text = "Date of Employment";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(679, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 17);
            this.label16.TabIndex = 68;
            this.label16.Text = "Position";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(679, 185);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 17);
            this.label17.TabIndex = 69;
            this.label17.Text = "Salary";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 596);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDfield);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.genderfield);
            this.Controls.Add(this.salaryfield);
            this.Controls.Add(this.positionfield);
            this.Controls.Add(this.dateofEmploymentfield);
            this.Controls.Add(this.emrgcyContactfield);
            this.Controls.Add(this.perAddfield);
            this.Controls.Add(this.currentAddfield);
            this.Controls.Add(this.nationalityfield);
            this.Controls.Add(this.maritalfield);
            this.Controls.Add(this.religionfield);
            this.Controls.Add(this.contactfield);
            this.Controls.Add(this.emailfield);
            this.Controls.Add(this.bdayfield);
            this.Controls.Add(this.lNamefield);
            this.Controls.Add(this.MIfield);
            this.Controls.Add(this.fNamefield);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.Text = "Form1";
            this.genderfield.ResumeLayout(false);
            this.genderfield.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.GroupBox genderfield;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.TextBox salaryfield;
        private System.Windows.Forms.TextBox positionfield;
        private System.Windows.Forms.DateTimePicker dateofEmploymentfield;
        private System.Windows.Forms.TextBox emrgcyContactfield;
        private System.Windows.Forms.TextBox perAddfield;
        private System.Windows.Forms.TextBox currentAddfield;
        private System.Windows.Forms.TextBox nationalityfield;
        private System.Windows.Forms.ComboBox maritalfield;
        private System.Windows.Forms.TextBox religionfield;
        private System.Windows.Forms.TextBox contactfield;
        private System.Windows.Forms.TextBox emailfield;
        private System.Windows.Forms.DateTimePicker bdayfield;
        private System.Windows.Forms.TextBox lNamefield;
        private System.Windows.Forms.TextBox MIfield;
        private System.Windows.Forms.TextBox fNamefield;
        private System.Windows.Forms.TextBox IDfield;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}