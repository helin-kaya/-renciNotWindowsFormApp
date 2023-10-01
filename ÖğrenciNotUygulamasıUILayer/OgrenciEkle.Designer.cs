namespace ÖğrenciNotUygulamasıUILayer
{
    partial class OgrenciEkle
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
            lblisim = new Label();
            lblSoyisim = new Label();
            lblsinif = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // lblisim
            // 
            lblisim.AutoSize = true;
            lblisim.Location = new Point(74, 46);
            lblisim.Name = "lblisim";
            lblisim.Size = new Size(33, 15);
            lblisim.TabIndex = 0;
            lblisim.Text = "İSİM:";
            // 
            // lblSoyisim
            // 
            lblSoyisim.AutoSize = true;
            lblSoyisim.Location = new Point(70, 83);
            lblSoyisim.Name = "lblSoyisim";
            lblSoyisim.Size = new Size(55, 15);
            lblSoyisim.TabIndex = 1;
            lblSoyisim.Text = "SOYİSİM:";
            // 
            // lblsinif
            // 
            lblsinif.AutoSize = true;
            lblsinif.Location = new Point(74, 130);
            lblsinif.Name = "lblsinif";
            lblsinif.Size = new Size(37, 15);
            lblsinif.TabIndex = 2;
            lblsinif.Text = "SINIF:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 127);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(156, 184);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // OgrenciEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 252);
            Controls.Add(btnKaydet);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblsinif);
            Controls.Add(lblSoyisim);
            Controls.Add(lblisim);
            Name = "OgrenciEkle";
            Text = "OgrenciEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblisim;
        private Label lblSoyisim;
        private Label lblsinif;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnKaydet;
    }
}