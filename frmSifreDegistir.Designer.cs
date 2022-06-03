namespace NTP
{
    partial class frmSifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifreDegistir));
            this.tbYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btIptal = new System.Windows.Forms.Button();
            this.btSifreDegistir = new System.Windows.Forms.Button();
            this.tbYeniSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEskiSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbYeniSifreTekrar
            // 
            this.tbYeniSifreTekrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbYeniSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbYeniSifreTekrar.Location = new System.Drawing.Point(210, 78);
            this.tbYeniSifreTekrar.Margin = new System.Windows.Forms.Padding(2);
            this.tbYeniSifreTekrar.Name = "tbYeniSifreTekrar";
            this.tbYeniSifreTekrar.PasswordChar = '*';
            this.tbYeniSifreTekrar.Size = new System.Drawing.Size(121, 30);
            this.tbYeniSifreTekrar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(0, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Şifreniz(tekrar):";
            // 
            // btIptal
            // 
            this.btIptal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btIptal.Image = ((System.Drawing.Image)(resources.GetObject("btIptal.Image")));
            this.btIptal.Location = new System.Drawing.Point(146, 126);
            this.btIptal.Margin = new System.Windows.Forms.Padding(2);
            this.btIptal.Name = "btIptal";
            this.btIptal.Size = new System.Drawing.Size(86, 54);
            this.btIptal.TabIndex = 5;
            this.btIptal.UseVisualStyleBackColor = false;
            this.btIptal.Click += new System.EventHandler(this.btIptal_Click);
            // 
            // btSifreDegistir
            // 
            this.btSifreDegistir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btSifreDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSifreDegistir.Image = ((System.Drawing.Image)(resources.GetObject("btSifreDegistir.Image")));
            this.btSifreDegistir.Location = new System.Drawing.Point(245, 126);
            this.btSifreDegistir.Margin = new System.Windows.Forms.Padding(2);
            this.btSifreDegistir.Name = "btSifreDegistir";
            this.btSifreDegistir.Size = new System.Drawing.Size(86, 54);
            this.btSifreDegistir.TabIndex = 4;
            this.btSifreDegistir.UseVisualStyleBackColor = false;
            this.btSifreDegistir.Click += new System.EventHandler(this.btSifreDegistir_Click);
            // 
            // tbYeniSifre
            // 
            this.tbYeniSifre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbYeniSifre.Location = new System.Drawing.Point(210, 42);
            this.tbYeniSifre.Margin = new System.Windows.Forms.Padding(2);
            this.tbYeniSifre.Name = "tbYeniSifre";
            this.tbYeniSifre.PasswordChar = '*';
            this.tbYeniSifre.Size = new System.Drawing.Size(121, 30);
            this.tbYeniSifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Şifreniz:";
            // 
            // tbEskiSifre
            // 
            this.tbEskiSifre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbEskiSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbEskiSifre.Location = new System.Drawing.Point(210, 11);
            this.tbEskiSifre.Margin = new System.Windows.Forms.Padding(2);
            this.tbEskiSifre.Name = "tbEskiSifre";
            this.tbEskiSifre.PasswordChar = '*';
            this.tbEskiSifre.Size = new System.Drawing.Size(121, 30);
            this.tbEskiSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eski şifreniz:";
            // 
            // frmSifreDegistir
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 215);
            this.Controls.Add(this.tbYeniSifreTekrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSifreDegistir);
            this.Controls.Add(this.btIptal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEskiSifre);
            this.Controls.Add(this.tbYeniSifre);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştir";
            this.Load += new System.EventHandler(this.frmSifreDegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIptal;
        private System.Windows.Forms.Button btSifreDegistir;
        private System.Windows.Forms.TextBox tbYeniSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEskiSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbYeniSifreTekrar;
        private System.Windows.Forms.Label label3;
    }
}