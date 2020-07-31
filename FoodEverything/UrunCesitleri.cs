using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace FoodEverything
{
    class UrunCesitleri
    {

        Genel gnl = new Genel();

        #region Fields
        private int _UrunTurNo;
        private string _KategoriAdi;
        private string _Aciklama;
        #endregion

        #region Properties
        public int UrunTurNo
        {
            get { return _UrunTurNo; }
            set { _UrunTurNo = value; }
        }

        public string KategoriAdi
        {
            get { return _KategoriAdi; }
            set { _KategoriAdi = value; }
        }

        public string Aciklama
        {
            get { return _Aciklama; }
            set { _Aciklama = value; }
        }

        #endregion

        public void GetByProductTypes(ListView Cesitler, Button btn)
        {
            Cesitler.Items.Clear();
            SqlConnection baglanti = new SqlConnection(gnl.ConString);
            SqlCommand com = new SqlCommand("Select UrunAdi,Fiyat,Urunler.ID from Kategoriler Inner Join Urunler on Kategoriler.ID=Urunler.KategoriID where Urunler.KategoriID=@KategoriID", baglanti);

            string aa = btn.Name;
            int uzunluk = aa.Length;

            com.Parameters.Add("KategoriID", SqlDbType.Int).Value = aa.Substring(uzunluk - 1,1);
            if(baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();

            }
            SqlDataReader dr = com.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["UrunAdi"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["Fiyat"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;

            }
            dr.Close();
            baglanti.Dispose();
            baglanti.Close();
        }



    }
}
