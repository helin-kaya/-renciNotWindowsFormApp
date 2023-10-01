namespace ÖğrenciNotUygulamasıUILayer
{
    partial class OgrenciNotlariniEkle
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblDers = new Label();
            lblNot = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtDers = new TextBox();
            txtNot = new TextBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(113, 54);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(26, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "AD:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(113, 94);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(47, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "SOYAD:";
            // 
            // lblDers
            // 
            lblDers.AutoSize = true;
            lblDers.Location = new Point(113, 139);
            lblDers.Name = "lblDers";
            lblDers.Size = new Size(37, 15);
            lblDers.TabIndex = 2;
            lblDers.Text = "DERS:";
            // 
            // lblNot
            // 
            lblNot.AutoSize = true;
            lblNot.Location = new Point(113, 181);
            lblNot.Name = "lblNot";
            lblNot.Size = new Size(33, 15);
            lblNot.TabIndex = 3;
            lblNot.Text = "NOT:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(185, 51);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(185, 86);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 5;
            // 
            // txtDers
            // 
            txtDers.Location = new Point(185, 131);
            txtDers.Name = "txtDers";
            txtDers.Size = new Size(100, 23);
            txtDers.TabIndex = 6;
            // 
            // txtNot
            // 
            txtNot.Location = new Point(185, 173);
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(100, 23);
            txtNot.TabIndex = 7;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(210, 226);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // OgrenciNotlariniEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 298);
            Controls.Add(btnKaydet);
            Controls.Add(txtNot);
            Controls.Add(txtDers);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblNot);
            Controls.Add(lblDers);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "OgrenciNotlariniEkle";
            Text = "OgrenciNotlariniEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblDers;
        private Label lblNot;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtDers;
        private TextBox txtNot;
        private Button btnKaydet;
    }
}