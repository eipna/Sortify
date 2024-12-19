namespace Sortify
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label_sortify = new Label();
            textboxPassword = new TextBox();
            label_login = new Label();
            label3 = new Label();
            label4 = new Label();
            textboxEmail = new RichTextBox();
            BTN_login = new Button();
            label5 = new Label();
            label6 = new Label();
            checkbox_as_admin = new CheckBox();
            checkboxShowPassword = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(96, 69, 142);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label_sortify);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 724);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(274, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(183, 446);
            label1.Name = "label1";
            label1.Size = new Size(321, 35);
            label1.TabIndex = 1;
            label1.Text = "Get sorted with Sortify!";
            // 
            // label_sortify
            // 
            label_sortify.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_sortify.AutoSize = true;
            label_sortify.Font = new Font("Impact", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_sortify.ForeColor = Color.Transparent;
            label_sortify.Location = new Point(117, 301);
            label_sortify.Name = "label_sortify";
            label_sortify.Size = new Size(453, 145);
            label_sortify.TabIndex = 0;
            label_sortify.Text = "SORTIFY";
            // 
            // textboxPassword
            // 
            textboxPassword.Location = new Point(772, 364);
            textboxPassword.Name = "textboxPassword";
            textboxPassword.Size = new Size(407, 27);
            textboxPassword.TabIndex = 4;
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Gadugi", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_login.Location = new Point(802, 137);
            label_login.Name = "label_login";
            label_login.Size = new Size(354, 44);
            label_login.TabIndex = 2;
            label_login.Text = "Login your account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(772, 268);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 5;
            label3.Text = "Email Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(772, 337);
            label4.Name = "label4";
            label4.Size = new Size(92, 24);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // textboxEmail
            // 
            textboxEmail.BorderStyle = BorderStyle.None;
            textboxEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxEmail.Location = new Point(772, 292);
            textboxEmail.Name = "textboxEmail";
            textboxEmail.Size = new Size(407, 27);
            textboxEmail.TabIndex = 3;
            textboxEmail.Text = "";
            // 
            // BTN_login
            // 
            BTN_login.BackColor = Color.FromArgb(96, 69, 142);
            BTN_login.Cursor = Cursors.Hand;
            BTN_login.FlatAppearance.BorderSize = 0;
            BTN_login.FlatStyle = FlatStyle.Flat;
            BTN_login.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTN_login.ForeColor = Color.Transparent;
            BTN_login.Location = new Point(772, 479);
            BTN_login.Name = "BTN_login";
            BTN_login.Size = new Size(407, 58);
            BTN_login.TabIndex = 7;
            BTN_login.Text = "LOGIN";
            BTN_login.UseVisualStyleBackColor = false;
            BTN_login.Click += BTN_login_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(820, 626);
            label5.Name = "label5";
            label5.Size = new Size(161, 21);
            label5.TabIndex = 8;
            label5.Text = "Not registered yet?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Gadugi", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(96, 69, 142);
            label6.Location = new Point(975, 626);
            label6.Name = "label6";
            label6.Size = new Size(145, 21);
            label6.TabIndex = 9;
            label6.Text = "REGISTER HERE";
            label6.Click += label6_Click;
            // 
            // checkbox_as_admin
            // 
            checkbox_as_admin.AutoSize = true;
            checkbox_as_admin.Cursor = Cursors.Hand;
            checkbox_as_admin.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkbox_as_admin.Location = new Point(772, 555);
            checkbox_as_admin.Name = "checkbox_as_admin";
            checkbox_as_admin.Size = new Size(156, 25);
            checkbox_as_admin.TabIndex = 10;
            checkbox_as_admin.Text = "Login as Admin";
            checkbox_as_admin.UseVisualStyleBackColor = true;
            // 
            // checkboxShowPassword
            // 
            checkboxShowPassword.AutoSize = true;
            checkboxShowPassword.Cursor = Cursors.Hand;
            checkboxShowPassword.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkboxShowPassword.Location = new Point(772, 403);
            checkboxShowPassword.Name = "checkboxShowPassword";
            checkboxShowPassword.Size = new Size(157, 25);
            checkboxShowPassword.TabIndex = 17;
            checkboxShowPassword.Text = "Show Password";
            checkboxShowPassword.UseVisualStyleBackColor = true;
            checkboxShowPassword.CheckedChanged += checkboxShowPassword_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 242, 250);
            ClientSize = new Size(1241, 724);
            Controls.Add(textboxPassword);
            Controls.Add(checkboxShowPassword);
            Controls.Add(checkbox_as_admin);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BTN_login);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textboxEmail);
            Controls.Add(label_login);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            Text = "Sortify";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label_login;
        private Label label_sortify;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private RichTextBox textboxEmail;
        private RichTextBox textbox_password;
        private Button BTN_login;
        private Label label5;
        private Label label6;
        private CheckBox checkbox_as_admin;
        private CheckBox checkboxShowPassword;
        private TextBox textboxPassword;
    }
}
