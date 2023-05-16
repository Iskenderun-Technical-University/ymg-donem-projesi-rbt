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
    public partial class grafikler : Form
    {
        public grafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MVAK1TR\\\\SQLEXPRESS;Initial Catalog=PersonelVeritabani;Integrated Security=True");
        private void grafikler_Load(object sender, EventArgs e)

        {
            //SEHİRLER
            baglanti.Open();
            SqlCommand kmtg1 = new SqlCommand("Select Personelsehir,Count(*) From table_personel Group By Personelsehir", baglanti);
            SqlDataReader dr1 = kmtg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Şehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();

            //ORTALAMA MAAŞ
            baglanti.Open();
            SqlCommand kmtg2 = new SqlCommand("Select Personelmeslek,Avg(Personelmaas) from table_personel group by personelmeslek", baglanti);
            SqlDataReader dr2 = kmtg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Maaş Ortalaması"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();
        }

    }
}
