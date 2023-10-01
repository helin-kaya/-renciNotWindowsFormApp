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

namespace ÖğrenciNotUygulamasıUILayer
{
    public partial class OgrenciNotlariniEkle : Form
    {
        NotlarManager nm = new NotlarManager();
        StudentManager s=new StudentManager();
        LessonManager l=new LessonManager();
        public OgrenciNotlariniEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
               string ad=txtAd.Text.Trim();
               string soyad=txtSoyad.Text.Trim();
                string dersAdi=txtDers.Text.Trim();
                int notu=Convert.ToInt32(txtNot.Text);

                List<Student> student = s.GetStudentsByNameSurname(ad, soyad);
                List<Lesson> lessons = l.GetLessonsByName(dersAdi);
                if (student.Count>0||lessons.Count>0)
                {
                    Student ogr = student[0];
                    Lesson les = lessons[0];
                    Notlar notlar = new Notlar()
                    {
                        OgrenciId= ogr.Id,
                        DersNotu=notu,
                        DersId=les.Id,
                    };

                    if (nm.AddNotlar(notlar))
                    {
                        MessageBox.Show($"Yeni not eklendi!");
                    }
                    else
                    {
                        MessageBox.Show("Not eklenirken bir hata oluştu!");
                    }
                }
                else
                {
                    MessageBox.Show("Öğrenci veya ders bulunamadı!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmedik sorun oldu! {ex.Message}");
            }
        }
    }
}
