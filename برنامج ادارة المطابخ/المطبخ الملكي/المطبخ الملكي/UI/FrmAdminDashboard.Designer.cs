namespace المطبخ_الملكي
{
    partial class FrmAdminDashboard
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
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.المستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المبيعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الخرجياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.PnlFooter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFooter
            // 
            this.PnlFooter.BackColor = System.Drawing.Color.Teal;
            this.PnlFooter.Controls.Add(this.label1);
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PnlFooter.Location = new System.Drawing.Point(0, 475);
            this.PnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(1067, 44);
            this.PnlFooter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(593, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "تطوير : عبدالرحمن الحميقاني";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.المستخدمينToolStripMenuItem,
            this.المبيعاتToolStripMenuItem,
            this.الخرجياتToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStripTop";
            // 
            // المستخدمينToolStripMenuItem
            // 
            this.المستخدمينToolStripMenuItem.Name = "المستخدمينToolStripMenuItem";
            this.المستخدمينToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.المستخدمينToolStripMenuItem.Text = "الحسابات";
            this.المستخدمينToolStripMenuItem.Click += new System.EventHandler(this.المستخدمينToolStripMenuItem_Click);
            // 
            // المبيعاتToolStripMenuItem
            // 
            this.المبيعاتToolStripMenuItem.Name = "المبيعاتToolStripMenuItem";
            this.المبيعاتToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.المبيعاتToolStripMenuItem.Text = "العمال";
            // 
            // الخرجياتToolStripMenuItem
            // 
            this.الخرجياتToolStripMenuItem.Name = "الخرجياتToolStripMenuItem";
            this.الخرجياتToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.الخرجياتToolStripMenuItem.Text = "المبيعات الشهريه";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.خروجToolStripMenuItem.Text = "خروج";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 46);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(72, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "المستخدم : ";
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblLoggedInUser.Location = new System.Drawing.Point(81, 46);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(64, 17);
            this.lblLoggedInUser.TabIndex = 3;
            this.lblLoggedInUser.Text = "جمال ناصر";
            this.lblLoggedInUser.Click += new System.EventHandler(this.lblLoggedInUser_Click);
            // 
            // FrmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.PnlFooter);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdminDashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " لوحة تحكم الادارة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlFooter.ResumeLayout(false);
            this.PnlFooter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlFooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem المستخدمينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المبيعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الخرجياتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLoggedInUser;
    }
}

