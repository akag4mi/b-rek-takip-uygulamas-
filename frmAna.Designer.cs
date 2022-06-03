namespace NTP
{
    partial class frmAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAna));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btStokMalzemeleri = new System.Windows.Forms.Button();
            this.btStokGirisi = new System.Windows.Forms.Button();
            this.btSatisMalzemeleri = new System.Windows.Forms.Button();
            this.btSatis = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(547, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 29);
            this.toolStripMenuItem1.Text = "Güvenlik";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btStokMalzemeleri
            // 
            this.btStokMalzemeleri.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btStokMalzemeleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btStokMalzemeleri.Location = new System.Drawing.Point(21, 110);
            this.btStokMalzemeleri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btStokMalzemeleri.Name = "btStokMalzemeleri";
            this.btStokMalzemeleri.Size = new System.Drawing.Size(157, 67);
            this.btStokMalzemeleri.TabIndex = 1;
            this.btStokMalzemeleri.Text = "Stok Malzemeleri";
            this.btStokMalzemeleri.UseVisualStyleBackColor = false;
            this.btStokMalzemeleri.Click += new System.EventHandler(this.btStokMalzemeleri_Click);
            // 
            // btStokGirisi
            // 
            this.btStokGirisi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btStokGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btStokGirisi.Location = new System.Drawing.Point(21, 179);
            this.btStokGirisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btStokGirisi.Name = "btStokGirisi";
            this.btStokGirisi.Size = new System.Drawing.Size(157, 67);
            this.btStokGirisi.TabIndex = 2;
            this.btStokGirisi.Text = "Stok Girişi";
            this.btStokGirisi.UseVisualStyleBackColor = false;
            // 
            // btSatisMalzemeleri
            // 
            this.btSatisMalzemeleri.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btSatisMalzemeleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSatisMalzemeleri.Location = new System.Drawing.Point(21, 250);
            this.btSatisMalzemeleri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSatisMalzemeleri.Name = "btSatisMalzemeleri";
            this.btSatisMalzemeleri.Size = new System.Drawing.Size(157, 67);
            this.btSatisMalzemeleri.TabIndex = 3;
            this.btSatisMalzemeleri.Text = "Satış Malzemeleri";
            this.btSatisMalzemeleri.UseVisualStyleBackColor = false;
            // 
            // btSatis
            // 
            this.btSatis.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSatis.Location = new System.Drawing.Point(21, 54);
            this.btSatis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSatis.Name = "btSatis";
            this.btSatis.Size = new System.Drawing.Size(499, 41);
            this.btSatis.TabIndex = 4;
            this.btSatis.Text = "Satış (F7)";
            this.btSatis.UseVisualStyleBackColor = false;
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 338);
            this.Controls.Add(this.btSatis);
            this.Controls.Add(this.btSatisMalzemeleri);
            this.Controls.Add(this.btStokGirisi);
            this.Controls.Add(this.btStokMalzemeleri);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Takip Programı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAna_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btStokMalzemeleri;
        private System.Windows.Forms.Button btStokGirisi;
        private System.Windows.Forms.Button btSatisMalzemeleri;
        private System.Windows.Forms.Button btSatis;
    }
}