using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ÖğrenciNotUygulamasıBusinessLayer;
using ÖğrenciNotUygulamasıEntityLayer.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ÖğrenciNotUygulamasıUILayer
{
    public partial class DersEkle : Form
    {
        LessonManager lessonManager=new LessonManager();
        public DersEkle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDersAdiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Lesson l = new Lesson()
                {
                    LessonName = txtDersAdiEkle.Text.Trim(),
                    
                };
                if (lessonManager.AddLesson(l))
                {
                    MessageBox.Show($"Yeni ders eklendi!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmedik sorun oldu! {ex.Message}");
            }
        }
    }
}
