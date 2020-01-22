namespace المطبخ_الملكي
{
    partial class FrmUserDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.اضافةسندToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عقدجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رواتبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.PnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةسندToolStripMenuItem,
            this.عقدجديدToolStripMenuItem,
            this.رواتبToolStripMenuItem,
            this.خروجToolStripMenuItem,
            this.خروجToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripTop";
            // 
            // اضافةسندToolStripMenuItem
            // 
            this.اضافةسندToolStripMenuItem.Name = "اضافةسندToolStripMenuItem";
            this.اضافةسندToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.اضافةسندToolStripMenuItem.Text = "سند جديد";
            // 
            // عقدجديدToolStripMenuItem
            // 
            this.عقدجديدToolStripMenuItem.Name = "عقدجديدToolStripMenuItem";
            this.عقدجديدToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.عقدجديدToolStripMenuItem.Text = "عقد جديد";
            // 
            // رواتبToolStripMenuItem
            // 
            this.رواتبToolStripMenuItem.Name = "رواتبToolStripMenuItem";
            this.رواتبToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.رواتبToolStripMenuItem.Text = "رواتب";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.خروجToolStripMenuItem.Text = "الكشوفات";
            // 
            // خروجToolStripMenuItem1
            // 
            this.خروجToolStripMenuItem1.Name = "خروجToolStripMenuItem1";
            this.خروجToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.خروجToolStripMenuItem1.Text = "خروج";
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblLoggedInUser.Location = new System.Drawing.Point(81, 40);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(64, 17);
            this.lblLoggedInUser.TabIndex = 6;
            this.lblLoggedInUser.Text = "جمال ناصر";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 40);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(72, 17);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "المستخدم : ";
            // 
            // PnlFooter
            // 
            this.PnlFooter.BackColor = System.Drawing.Color.Teal;
            this.PnlFooter.Controls.Add(this.label1);
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PnlFooter.Location = new System.Drawing.Point(0, 406);
            this.PnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(800, 44);
            this.PnlFooter.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(624, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "تطوير : عبدالرحمن الحميقاني";
            // 
            // FrmUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.PnlFooter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUserDashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المطبخ الملكي";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlFooter.ResumeLayout(false);
            this.PnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اضافةسندToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عقدجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem رواتبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem1;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel PnlFooter;
        private System.Windows.Forms.Label label1;
    }
}