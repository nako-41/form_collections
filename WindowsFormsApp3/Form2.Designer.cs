
namespace WindowsFormsApp3
{
    partial class Form2
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
            this.musteriGirisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriGirisToolStripMenuItem,
            this.listelemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // musteriGirisToolStripMenuItem
            // 
            this.musteriGirisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.denemeToolStripMenuItem});
            this.musteriGirisToolStripMenuItem.Name = "musteriGirisToolStripMenuItem";
            this.musteriGirisToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.musteriGirisToolStripMenuItem.Text = "Musteri Giris";
            this.musteriGirisToolStripMenuItem.Click += new System.EventHandler(this.musteriGirisToolStripMenuItem_Click);
            // 
            // denemeToolStripMenuItem
            // 
            this.denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            this.denemeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.denemeToolStripMenuItem.Text = "deneme";
            // 
            // listelemeToolStripMenuItem
            // 
            this.listelemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriListeleToolStripMenuItem});
            this.listelemeToolStripMenuItem.Name = "listelemeToolStripMenuItem";
            this.listelemeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.listelemeToolStripMenuItem.Text = "listeleme";
            this.listelemeToolStripMenuItem.Click += new System.EventHandler(this.listelemeToolStripMenuItem_Click);
            // 
            // müşteriListeleToolStripMenuItem
            // 
            this.müşteriListeleToolStripMenuItem.Name = "müşteriListeleToolStripMenuItem";
            this.müşteriListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müşteriListeleToolStripMenuItem.Text = "müşteri listele";
            this.müşteriListeleToolStripMenuItem.Click += new System.EventHandler(this.müşteriListeleToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 437);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem musteriGirisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem denemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListeleToolStripMenuItem;
    }
}