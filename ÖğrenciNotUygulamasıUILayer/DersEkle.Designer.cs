namespace ÖğrenciNotUygulamasıUILayer
{
    partial class DersEkle
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
            lblDersAdiekle = new Label();
            txtDersAdiEkle = new TextBox();
            btnDersAdiEkle = new Button();
            SuspendLayout();
            // 
            // lblDersAdiekle
            // 
            lblDersAdiekle.AutoSize = true;
            lblDersAdiekle.Location = new Point(86, 57);
            lblDersAdiekle.Name = "lblDersAdiekle";
            lblDersAdiekle.Size = new Size(62, 15);
            lblDersAdiekle.TabIndex = 0;
            lblDersAdiekle.Text = "DERS ADI: ";
            // 
            // txtDersAdiEkle
            // 
            txtDersAdiEkle.Location = new Point(190, 54);
            txtDersAdiEkle.Name = "txtDersAdiEkle";
            txtDersAdiEkle.Size = new Size(100, 23);
            txtDersAdiEkle.TabIndex = 1;
            txtDersAdiEkle.TextChanged += textBox1_TextChanged;
            // 
            // btnDersAdiEkle
            // 
            btnDersAdiEkle.Location = new Point(86, 112);
            btnDersAdiEkle.Name = "btnDersAdiEkle";
            btnDersAdiEkle.Size = new Size(204, 23);
            btnDersAdiEkle.TabIndex = 2;
            btnDersAdiEkle.Text = "DERSİ EKLE";
            btnDersAdiEkle.UseVisualStyleBackColor = true;
            btnDersAdiEkle.Click += btnDersAdiEkle_Click;
            // 
            // DersEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 210);
            Controls.Add(btnDersAdiEkle);
            Controls.Add(txtDersAdiEkle);
            Controls.Add(lblDersAdiekle);
            Name = "DersEkle";
            Text = "DersEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDersAdiekle;
        private TextBox txtDersAdiEkle;
        private Button btnDersAdiEkle;
    }
}