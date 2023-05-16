using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Şantiye_otomasyon_proje
{
    public partial class Formiststsk : Form
    {
        public Formiststsk()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MVAK1TR\\SQLEXPRESS;Initial Catalog=PersonelVeritabani;Integrated Security=True");
        private void Formiststsk_Load(object sender, EventArgs e)
        {
            //TOPLAM PERSONEL SAYISI
            baglanti.Open();
            SqlCommand kmt1 = new SqlCommand("Select Count(*) From Table_personel", baglanti);
            SqlDataReader dtrdr1 = kmt1.ExecuteReader(); //select için sorguyu çaliştirir>> Executereader:)

            while (dtrdr1.Read()) // tablo bitene kadar tüm değeleri okuyacak yani toplam personel sayına ulaşacağız

            {
                labeltoplampersonel.Text = dtrdr1[0].ToString(); // 0.İndeks yani ilk sütun (personelİD)
            }
            baglanti.Close();

            //EVLİ PERSONEL SAYISI
            baglanti.Open();
            SqlCommand kmt2 = new SqlCommand("Select Count(*) From Table_personel where personeldurum=1", baglanti);
            SqlDataReader dtrdr2 = kmt2.ExecuteReader();
            while (dtrdr2.Read())
            {
                labelevlipersonel.Text = dtrdr2[0].ToString();
            }
            baglanti.Close();

            //BEKAR PERSONEL SAYISI
            baglanti.Open();
            SqlCommand kmt3 = new SqlCommand("Select Count(*) From Table_personel where personeldurum=0", baglanti);
            SqlDataReader dtrdr3 = kmt3.ExecuteReader();
            while (dtrdr3.Read())
            {
                labelbekarpersonel.Text = dtrdr3[0].ToString();
            }
            baglanti.Close();

            //FARKLI ŞEHİR SAYISI
            baglanti.Open();
            SqlCommand kmt4 = new SqlCommand("Select Count(Distinct(personelsehir)) From table_personel", baglanti);
            SqlDataReader dtrdr4 = kmt4.ExecuteReader();
            while (dtrdr4.Read())
            {
                labelsehir.Text = dtrdr4[0].ToString();
            }
                
            baglanti.Close();

            //TOPLAM MAAŞ
            baglanti.Open();
            SqlCommand kmt5 = new SqlCommand("Select Sum(Personelmaas) from table_personel", baglanti);
            SqlDataReader dtrdr5 = kmt5.ExecuteReader();
            while (dtrdr5.Read())
            {
                labeltoplammaas.Text = dtrdr5[0].ToString();
            }
            baglanti.Close();

            //ORTALAMA MAAŞ
            baglanti.Open();
            SqlCommand kmt6 = new SqlCommand("Select Avg(personelmaas) from table_personel", baglanti);
            SqlDataReader dtrdr6 = kmt6.ExecuteReader();
            while (dtrdr6.Read())
            {
                labelortmaas.Text = dtrdr6[0].ToString();

            }
            baglanti.Close();

        }
    }
}
