using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodEverything
{
    class Personeller
    {
        Genel gnl = new Genel();
        #region Fields
        private int _PersonalID;
        private int _PersonelGorevID;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private bool _PersonelDurum;
        #endregion

        #region Properties

        public int PersonalID { get { return _PersonalID; } set { _PersonalID = value; } }
        public int PersonelGorevID { get { return _PersonelGorevID; } set { _PersonelGorevID = value; } }
        public string PersonelAd { get { return _PersonelAd; } set { _PersonelAd = value; } }
        public string PersonelSoyad { get { return _PersonelSoyad; } set { _PersonelSoyad = value; } }
        public string PersonelParola { get { return _PersonelParola; } set { _PersonelParola = value; } }
        public string PersonelKullaniciAdi { get { return _PersonelKullaniciAdi; } set { _ = value; } }
        public bool PersonelDurum { get { return _PersonelDurum; } set { _PersonelDurum = value; } }

        #endregion

        public bool PersonelGirisControl(string Password, int UserID)

        {
            bool result = false;

            SqlConnection baglanti = new SqlConnection(gnl.ConString);
            SqlCommand cmd = new SqlCommand("Select*from Personeller where ID=@ıd and Parola=@password", baglanti);
            cmd.Parameters.Add("@ıd", SqlDbType.VarChar).Value = UserID;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = Password;



            try
            {
                if(baglanti.State==ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());

            }

            catch(SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }




            return result;

        }


        public void PersonelBilgileriniGetir(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection baglanti = new SqlConnection(gnl.ConString);
            SqlCommand cmd = new SqlCommand("Select*from Personeller", baglanti);
            if(baglanti.State==ConnectionState.Closed)

            {
                baglanti.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Personeller p = new Personeller();
                p.PersonalID = Convert.ToInt32(dr["ID"]);
                p.PersonelGorevID = Convert.ToInt32(dr["GorevID"]);
                p.PersonelAd = Convert.ToString(dr["Ad"]);
                p.PersonelSoyad = Convert.ToString(dr["Soyad"]);
                p.PersonelParola = Convert.ToString(dr["Parola"]);
                p._PersonelKullaniciAdi = Convert.ToString(dr["KullaniciAdi"]);
                p._PersonelDurum = Convert.ToBoolean(dr["Durum"]);
                cb.Items.Add(p);
            }
            dr.Close();
            baglanti.Close();

        }

        public override string ToString()
        {
            return PersonelAd +" "+ PersonelSoyad;
        }
    }
}


