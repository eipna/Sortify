namespace Sortify
{
    partial class AdminDashboard
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
            panel1 = new Panel();
            label_dashboard = new Label();
            panel2 = new Panel();
            radioButtonAge = new RadioButton();
            radioButtonID = new RadioButton();
            button3 = new Button();
            btnLogout = new Button();
            button2 = new Button();
            button1 = new Button();
            BTN_update = new Button();
            usersTable = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(96, 69, 142);
            panel1.Controls.Add(label_dashboard);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1539, 84);
            panel1.TabIndex = 0;
            // 
            // label_dashboard
            // 
            label_dashboard.AutoSize = true;
            label_dashboard.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_dashboard.ForeColor = SystemColors.ControlLightLight;
            label_dashboard.Location = new Point(636, 23);
            label_dashboard.Name = "label_dashboard";
            label_dashboard.Size = new Size(270, 36);
            label_dashboard.TabIndex = 15;
            label_dashboard.Text = "Admin Dashboard";
            label_dashboard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(radioButtonAge);
            panel2.Controls.Add(radioButtonID);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(BTN_update);
            panel2.Controls.Add(usersTable);
            panel2.Location = new Point(51, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(1442, 851);
            panel2.TabIndex = 1;
            // 
            // radioButtonAge
            // 
            radioButtonAge.AutoSize = true;
            radioButtonAge.Location = new Point(243, 23);
            radioButtonAge.Name = "radioButtonAge";
            radioButtonAge.Size = new Size(77, 24);
            radioButtonAge.TabIndex = 62;
            radioButtonAge.TabStop = true;
            radioButtonAge.Text = "By Age";
            radioButtonAge.UseVisualStyleBackColor = true;
            // 
            // radioButtonID
            // 
            radioButtonID.AutoSize = true;
            radioButtonID.Location = new Point(157, 25);
            radioButtonID.Name = "radioButtonID";
            radioButtonID.Size = new Size(65, 24);
            radioButtonID.TabIndex = 61;
            radioButtonID.TabStop = true;
            radioButtonID.Text = "By ID";
            radioButtonID.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(96, 69, 142);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(18, 23);
            button3.Name = "button3";
            button3.Size = new Size(109, 28);
            button3.TabIndex = 60;
            button3.Text = "SORT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.IndianRed;
            btnLogout.FlatAppearance.BorderSize = 3;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Transparent;
            btnLogout.Location = new Point(1225, 767);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(205, 65);
            btnLogout.TabIndex = 58;
            btnLogout.Text = "LOG OUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(96, 69, 142);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(434, 767);
            button2.Name = "button2";
            button2.Size = new Size(190, 65);
            button2.TabIndex = 57;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(96, 69, 142);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(225, 767);
            button1.Name = "button1";
            button1.Size = new Size(190, 65);
            button1.TabIndex = 56;
            button1.Text = "EDIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BTN_update
            // 
            BTN_update.BackColor = Color.FromArgb(96, 69, 142);
            BTN_update.Cursor = Cursors.Hand;
            BTN_update.FlatAppearance.BorderSize = 0;
            BTN_update.FlatStyle = FlatStyle.Flat;
            BTN_update.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTN_update.ForeColor = Color.White;
            BTN_update.Location = new Point(18, 767);
            BTN_update.Name = "BTN_update";
            BTN_update.Size = new Size(190, 65);
            BTN_update.TabIndex = 55;
            BTN_update.Text = "ADD";
            BTN_update.UseVisualStyleBackColor = false;
            BTN_update.Click += BTN_update_Click;
            // 
            // usersTable
            // 
            usersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            usersTable.BackgroundColor = Color.White;
            usersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersTable.Location = new Point(18, 63);
            usersTable.MultiSelect = false;
            usersTable.Name = "usersTable";
            usersTable.RowHeadersVisible = false;
            usersTable.RowHeadersWidth = 51;
            usersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersTable.Size = new Size(1412, 683);
            usersTable.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 242, 250);
            ClientSize = new Size(1539, 983);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_dashboard;
        private Panel panel2;
        private DataGridView usersTable;
        private Button BTN_update;
        private Button button2;
        private Button button1;
        private Button btnLogout;
        private Button button3;
        private RadioButton radioButtonAge;
        private RadioButton radioButtonID;
    }
}