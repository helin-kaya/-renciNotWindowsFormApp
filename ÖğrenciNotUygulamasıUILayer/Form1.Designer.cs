namespace ÖğrenciNotUygulamasıUILayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnögrnci = new Button();
            btnnot = new Button();
            btnDersEkle = new Button();
            SuspendLayout();
            // 
            // btnögrnci
            // 
            btnögrnci.Location = new Point(103, 46);
            btnögrnci.Name = "btnögrnci";
            btnögrnci.Size = new Size(199, 52);
            btnögrnci.TabIndex = 0;
            btnögrnci.Text = "ÖĞRENCİ EKLE";
            btnögrnci.UseVisualStyleBackColor = true;
            btnögrnci.Click += button1_Click;
            // 
            // btnnot
            // 
            btnnot.Location = new Point(103, 201);
            btnnot.Name = "btnnot";
            btnnot.Size = new Size(199, 54);
            btnnot.TabIndex = 1;
            btnnot.Text = "ÖĞRENCİNİN NOTUNU GİR";
            btnnot.UseVisualStyleBackColor = true;
            btnnot.Click += btnnot_Click;
            // 
            // btnDersEkle
            // 
            btnDersEkle.Location = new Point(103, 124);
            btnDersEkle.Name = "btnDersEkle";
            btnDersEkle.Size = new Size(199, 55);
            btnDersEkle.TabIndex = 2;
            btnDersEkle.Text = "DERS EKLE";
            btnDersEkle.UseVisualStyleBackColor = true;
            btnDersEkle.Click += btnDersEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 303);
            Controls.Add(btnDersEkle);
            Controls.Add(btnnot);
            Controls.Add(btnögrnci);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnögrnci;
        private Button btnnot;
        private Button btnDersEkle;
    }
}