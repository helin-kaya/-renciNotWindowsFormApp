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
    public partial class OgrenciEkle : Form
    {
        StudentManager studentManager = new StudentManager();
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student()
                {
                    Name=textBox1.Text.Trim(),
                    Surname=textBox2.Text.Trim(),
                    Sinif= Convert.ToInt32(textBox3.Text),
                };
                if(studentManager.AddStudent(s))
                {
                    MessageBox.Show($"Yeni öğrenci eklendi!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmedik sorun oldu! {ex.Message}");
            }
        }
    }
}
