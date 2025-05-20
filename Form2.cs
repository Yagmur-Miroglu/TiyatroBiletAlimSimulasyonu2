﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace PROJE0101
{
    public partial class Form2 : Form
    {
        private List<Button> SeciliButonlar = new List<Button>();
        Dictionary<string, bool> durumlar = new Dictionary<string, bool>();//dizi oluşturmuş gibi ama her üyenin 0 ya da 1 değeri var 
        string connectionString = "Data Source = DESKTOP-JEA5RNF; Initial Catalog = BMT110; Integrated Security = True";

        public Form2()
        {
            InitializeComponent();
        }
        public static int FilmNo = Form1.filmNo;

        private void buttonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //BUtona bir kere tıkladığında seçer bir kere daha tıkladığında seçimden çıkarır
            #region
            bool seciliMi = false;

            // BUtonların tag durumunu kontrol et seciliMi ye at
            if (btn.Tag != null)
                seciliMi = Convert.ToBoolean(btn.Tag);


            if (seciliMi)
            {
                // Seçili ise, çıkar
                btn.Tag = false;

                btn.BackColor = SystemColors.ActiveCaption;

                // Listeden çıkar

                if (SeciliButonlar.Contains(btn))
                    SeciliButonlar.Remove(btn);
                Top_Ucret -= 250;//iptal edince ücreti azalt

            }
            else
            {
                // Seçili değil, seç
                btn.Tag = true;
                btn.BackColor = Color.IndianRed;

                // Listeye ekle
                if (!SeciliButonlar.Contains(btn))
                    SeciliButonlar.Add(btn);
                Top_Ucret += 250;//seçince ücreti artır
            }

            // Listeyi güncelle
            Goster();
            Hesapla();
            #endregion
        }

        private void Goster()

        {

            SecilenKoltuklar.Items.Clear();//sadece son bastığımızı eklesin diye

            foreach (Button btn in SeciliButonlar)
            {

                SecilenKoltuklar.Items.Add(btn.Text);

            }
        }
        private void Hesapla()
        {
            ToplamUcret.Text = Top_Ucret + " TL";
        }

        public static int Top_Ucret = 0;//toplam ücreti tutacak değişken
        int doluluk = 0;//koltuk doluluğunu tutacak değişken

        private void Form2_Load(object sender, EventArgs e) //koltuk seçme
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT KoltukNo, Secilme_Durumu{FilmNo} FROM dbo.TiyatroKoltuk";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string koltukNo = reader["KoltukNo"].ToString();
                            bool isSelected = reader[$"Secilme_Durumu{FilmNo}"] != DBNull.Value && Convert.ToBoolean(reader[$"Secilme_Durumu{FilmNo}"]);
                            durumlar[koltukNo] = isSelected;
                            if (isSelected) doluluk++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri alınırken sorun oluştu: " + ex.Message);
            }

            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    if (durumlar.ContainsKey(btn.Text) && durumlar[btn.Text])
                    {
                        btn.Enabled = false;
                        btn.BackColor = Color.DarkGray;
                    }
                }
            }

        }

        private void button24_Click(object sender, EventArgs e) //ödeme butonu
        {
            Form4 frm = new Form4();
            frm.ShowDialog(); // formu aç
        }

        
    }
}
