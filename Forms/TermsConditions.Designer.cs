namespace Sortify
{
    partial class TermsConditions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermsConditions));
            panel1 = new Panel();
            label_dashboard = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(96, 69, 142);
            panel1.Controls.Add(label_dashboard);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 89);
            panel1.TabIndex = 0;
            // 
            // label_dashboard
            // 
            label_dashboard.AutoSize = true;
            label_dashboard.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_dashboard.ForeColor = SystemColors.ControlLightLight;
            label_dashboard.Location = new Point(97, 27);
            label_dashboard.Name = "label_dashboard";
            label_dashboard.Size = new Size(323, 36);
            label_dashboard.TabIndex = 16;
            label_dashboard.Text = "Terms and Conditions";
            label_dashboard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(21, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 663);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(15, 11);
            label1.Name = "label1";
            label1.Size = new Size(445, 640);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // TermsConditions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 242, 250);
            ClientSize = new Size(519, 801);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TermsConditions";
            Text = "TermsConditions";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_dashboard;
        private Panel panel2;
        private Label label1;
    }
}