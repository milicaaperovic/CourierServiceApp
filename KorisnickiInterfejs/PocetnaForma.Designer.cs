namespace KorisnickiInterfejs
{
    partial class PocetnaForma
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
            this.posiljkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dnevniRasporedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posiljkaToolStripMenuItem,
            this.dnevniRasporedToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // posiljkaToolStripMenuItem
            // 
            this.posiljkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.pregledToolStripMenuItem});
            this.posiljkaToolStripMenuItem.Name = "posiljkaToolStripMenuItem";
            this.posiljkaToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.posiljkaToolStripMenuItem.Text = "Posiljka";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.unosToolStripMenuItem.Text = "Unos";
            this.unosToolStripMenuItem.Click += new System.EventHandler(this.unosToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pregledToolStripMenuItem.Text = "Pregled";
            // 
            // dnevniRasporedToolStripMenuItem
            // 
            this.dnevniRasporedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem1,
            this.pregledToolStripMenuItem1});
            this.dnevniRasporedToolStripMenuItem.Name = "dnevniRasporedToolStripMenuItem";
            this.dnevniRasporedToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.dnevniRasporedToolStripMenuItem.Text = "Dnevni raspored";
            // 
            // unosToolStripMenuItem1
            // 
            this.unosToolStripMenuItem1.Name = "unosToolStripMenuItem1";
            this.unosToolStripMenuItem1.Size = new System.Drawing.Size(143, 26);
            this.unosToolStripMenuItem1.Text = "Unos";
            // 
            // pregledToolStripMenuItem1
            // 
            this.pregledToolStripMenuItem1.Name = "pregledToolStripMenuItem1";
            this.pregledToolStripMenuItem1.Size = new System.Drawing.Size(143, 26);
            this.pregledToolStripMenuItem1.Text = "Pregled";
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.krajToolStripMenuItem.Text = "Kraj";
            this.krajToolStripMenuItem.Click += new System.EventHandler(this.krajToolStripMenuItem_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PocetnaForma";
            this.Text = "PocetnaForma";
            this.Load += new System.EventHandler(this.PocetnaForma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem posiljkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dnevniRasporedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
    }
}

