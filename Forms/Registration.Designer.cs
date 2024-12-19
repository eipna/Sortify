namespace Sortify
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            panel1 = new Panel();
            label1 = new Label();
            BTN_back_login = new Button();
            pictureBox1 = new PictureBox();
            fieldFirstName = new RichTextBox();
            fieldMiddleName = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            label_login = new Label();
            fieldLastName = new RichTextBox();
            fieldAge = new RichTextBox();
            fieldPassword = new RichTextBox();
            fieldConfirmPassword = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            fieldAddress = new RichTextBox();
            label8 = new Label();
            fieldEmailAddress = new RichTextBox();
            label9 = new Label();
            BTN_register = new Button();
            fieldPhone = new RichTextBox();
            label10 = new Label();
            fieldGender = new RichTextBox();
            label11 = new Label();
            checkboxTermsConditions = new CheckBox();
            label_terms_condition = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(96, 69, 142);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BTN_back_login);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.FromArgb(96, 69, 142);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 924);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(92, 502);
            label1.Name = "label1";
            label1.Size = new Size(318, 54);
            label1.TabIndex = 28;
            label1.Text = "\"Please fill out the form below\r\nto create your account.\"";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTN_back_login
            // 
            BTN_back_login.BackColor = Color.White;
            BTN_back_login.Cursor = Cursors.Hand;
            BTN_back_login.FlatAppearance.BorderSize = 0;
            BTN_back_login.FlatStyle = FlatStyle.Flat;
            BTN_back_login.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTN_back_login.Location = new Point(82, 823);
            BTN_back_login.Name = "BTN_back_login";
            BTN_back_login.Size = new Size(331, 65);
            BTN_back_login.TabIndex = 8;
            BTN_back_login.Text = "BACK TO LOGIN";
            BTN_back_login.UseVisualStyleBackColor = false;
            BTN_back_login.Click += BTN_back_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 317);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // fieldFirstName
            // 
            fieldFirstName.BorderStyle = BorderStyle.None;
            fieldFirstName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldFirstName.Location = new Point(578, 199);
            fieldFirstName.Name = "fieldFirstName";
            fieldFirstName.Size = new Size(441, 49);
            fieldFirstName.TabIndex = 9;
            fieldFirstName.Text = "";
            fieldFirstName.KeyDown += fieldFirstName_KeyDown;
            // 
            // fieldMiddleName
            // 
            fieldMiddleName.BorderStyle = BorderStyle.None;
            fieldMiddleName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldMiddleName.Location = new Point(1077, 199);
            fieldMiddleName.Name = "fieldMiddleName";
            fieldMiddleName.Size = new Size(438, 49);
            fieldMiddleName.TabIndex = 10;
            fieldMiddleName.Text = "";
            fieldMiddleName.KeyDown += fieldMiddleName_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(578, 175);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 11;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(578, 294);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 12;
            label2.Text = "Last Name";
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Gadugi", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_login.Location = new Point(798, 62);
            label_login.Name = "label_login";
            label_login.Size = new Size(487, 52);
            label_login.TabIndex = 13;
            label_login.Text = "Register to get started";
            // 
            // fieldLastName
            // 
            fieldLastName.BorderStyle = BorderStyle.None;
            fieldLastName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldLastName.Location = new Point(578, 318);
            fieldLastName.Name = "fieldLastName";
            fieldLastName.Size = new Size(441, 49);
            fieldLastName.TabIndex = 14;
            fieldLastName.Text = "";
            fieldLastName.KeyDown += fieldLastName_KeyDown;
            // 
            // fieldAge
            // 
            fieldAge.BorderStyle = BorderStyle.None;
            fieldAge.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldAge.Location = new Point(1077, 546);
            fieldAge.Name = "fieldAge";
            fieldAge.Size = new Size(441, 49);
            fieldAge.TabIndex = 15;
            fieldAge.Text = "";
            fieldAge.KeyDown += fieldAge_KeyDown;
            // 
            // fieldPassword
            // 
            fieldPassword.BorderStyle = BorderStyle.None;
            fieldPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldPassword.Location = new Point(578, 427);
            fieldPassword.Name = "fieldPassword";
            fieldPassword.Size = new Size(441, 49);
            fieldPassword.TabIndex = 16;
            fieldPassword.Text = "";
            fieldPassword.KeyDown += fieldPassword_KeyDown;
            // 
            // fieldConfirmPassword
            // 
            fieldConfirmPassword.BorderStyle = BorderStyle.None;
            fieldConfirmPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldConfirmPassword.Location = new Point(1077, 427);
            fieldConfirmPassword.Name = "fieldConfirmPassword";
            fieldConfirmPassword.Size = new Size(441, 49);
            fieldConfirmPassword.TabIndex = 17;
            fieldConfirmPassword.Text = "";
            fieldConfirmPassword.KeyDown += fieldConfirmPassword_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1077, 294);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 18;
            label4.Text = "Email Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1077, 522);
            label5.Name = "label5";
            label5.Size = new Size(42, 21);
            label5.TabIndex = 19;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(578, 403);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 20;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(1077, 403);
            label7.Name = "label7";
            label7.Size = new Size(155, 21);
            label7.TabIndex = 21;
            label7.Text = "Confirm Password";
            // 
            // fieldAddress
            // 
            fieldAddress.BorderStyle = BorderStyle.None;
            fieldAddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldAddress.Location = new Point(578, 546);
            fieldAddress.Name = "fieldAddress";
            fieldAddress.Size = new Size(441, 49);
            fieldAddress.TabIndex = 22;
            fieldAddress.Text = "";
            fieldAddress.KeyDown += fieldAddress_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(578, 522);
            label8.Name = "label8";
            label8.Size = new Size(75, 21);
            label8.TabIndex = 23;
            label8.Text = "Address";
            // 
            // fieldEmailAddress
            // 
            fieldEmailAddress.BorderStyle = BorderStyle.None;
            fieldEmailAddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldEmailAddress.Location = new Point(1077, 318);
            fieldEmailAddress.Name = "fieldEmailAddress";
            fieldEmailAddress.Size = new Size(441, 49);
            fieldEmailAddress.TabIndex = 26;
            fieldEmailAddress.Text = ".";
            fieldEmailAddress.KeyDown += fieldEmailAddress_KeyDown;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(1077, 175);
            label9.Name = "label9";
            label9.Size = new Size(117, 21);
            label9.TabIndex = 27;
            label9.Text = "Middle Name";
            // 
            // BTN_register
            // 
            BTN_register.BackColor = Color.FromArgb(96, 69, 142);
            BTN_register.Cursor = Cursors.Hand;
            BTN_register.FlatAppearance.BorderSize = 0;
            BTN_register.FlatStyle = FlatStyle.Flat;
            BTN_register.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTN_register.ForeColor = Color.White;
            BTN_register.Location = new Point(578, 823);
            BTN_register.Name = "BTN_register";
            BTN_register.Size = new Size(331, 62);
            BTN_register.TabIndex = 9;
            BTN_register.Text = "REGISTER";
            BTN_register.UseVisualStyleBackColor = false;
            BTN_register.Click += BTN_register_Click;
            // 
            // fieldPhone
            // 
            fieldPhone.BorderStyle = BorderStyle.None;
            fieldPhone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldPhone.Location = new Point(578, 669);
            fieldPhone.Name = "fieldPhone";
            fieldPhone.Size = new Size(441, 49);
            fieldPhone.TabIndex = 28;
            fieldPhone.Text = "";
            fieldPhone.KeyDown += fieldPhone_KeyDown;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(578, 645);
            label10.Name = "label10";
            label10.Size = new Size(130, 21);
            label10.TabIndex = 29;
            label10.Text = "Phone Number";
            // 
            // fieldGender
            // 
            fieldGender.BorderStyle = BorderStyle.None;
            fieldGender.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldGender.Location = new Point(1077, 669);
            fieldGender.Name = "fieldGender";
            fieldGender.Size = new Size(441, 49);
            fieldGender.TabIndex = 30;
            fieldGender.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(1077, 645);
            label11.Name = "label11";
            label11.Size = new Size(247, 21);
            label11.TabIndex = 31;
            label11.Text = "Gender (Male/Female/Specify)";
            // 
            // checkboxTermsConditions
            // 
            checkboxTermsConditions.AutoSize = true;
            checkboxTermsConditions.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkboxTermsConditions.Location = new Point(578, 761);
            checkboxTermsConditions.Name = "checkboxTermsConditions";
            checkboxTermsConditions.Size = new Size(123, 25);
            checkboxTermsConditions.TabIndex = 32;
            checkboxTermsConditions.Text = "I accept the";
            checkboxTermsConditions.UseVisualStyleBackColor = true;
            // 
            // label_terms_condition
            // 
            label_terms_condition.AutoSize = true;
            label_terms_condition.Cursor = Cursors.Hand;
            label_terms_condition.Font = new Font("Gadugi", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_terms_condition.ForeColor = Color.FromArgb(96, 69, 142);
            label_terms_condition.Location = new Point(694, 762);
            label_terms_condition.Name = "label_terms_condition";
            label_terms_condition.Size = new Size(181, 21);
            label_terms_condition.TabIndex = 33;
            label_terms_condition.Text = "terms and condition";
            label_terms_condition.Click += label_terms_condition_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 242, 250);
            ClientSize = new Size(1576, 924);
            Controls.Add(label_terms_condition);
            Controls.Add(checkboxTermsConditions);
            Controls.Add(label11);
            Controls.Add(fieldGender);
            Controls.Add(label10);
            Controls.Add(fieldPhone);
            Controls.Add(BTN_register);
            Controls.Add(label9);
            Controls.Add(fieldEmailAddress);
            Controls.Add(label8);
            Controls.Add(fieldAddress);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(fieldConfirmPassword);
            Controls.Add(fieldPassword);
            Controls.Add(fieldAge);
            Controls.Add(fieldLastName);
            Controls.Add(label_login);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(fieldMiddleName);
            Controls.Add(fieldFirstName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Registration";
            Text = "Registration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BTN_back_login;
        private RichTextBox fieldFirstName;
        private RichTextBox fieldMiddleName;
        private Label label3;
        private Label label2;
        private Label label_login;
        private RichTextBox fieldLastName;
        private RichTextBox fieldAge;
        private RichTextBox fieldPassword;
        private RichTextBox fieldConfirmPassword;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox fieldAddress;
        private Label label8;
        private RichTextBox fieldEmailAddress;
        private Label label9;
        private Button BTN_register;
        private Label label1;
        private RichTextBox fieldPhone;
        private Label label10;
        private RichTextBox fieldGender;
        private Label label11;
        private CheckBox checkboxTermsConditions;
        private Label label_terms_condition;
    }
}