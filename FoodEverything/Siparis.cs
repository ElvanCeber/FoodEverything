using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace FoodEverything
{
    class Siparis
    {
        Genel gnl = new Genel();

        #region Fields
        private int _ID;
        private int _AdisyonID;
        private int _UrunID;
        private int _Adet;
        private int _MasaID;
        #endregion

        
        #region Properties
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }

        }

        public int AdisyonID
        {
            get { return _AdisyonID; }
            set { _AdisyonID = value; }

        }

        public int UrunID
        {
            get { return _UrunID; }
            set { _UrunID = value; }
        }

        public int Adet
        {
            get { return _Adet; }
            set { _Adet = value; }
        }

        public int MasaID
        {
            get { return _MasaID; }
            set { _MasaID = value; }
        }
        #endregion


        //Siparis Getir

        public void GetByOrder(ListView Lv, int AdisyonID)
        {
            SqlConnection baglanti = new SqlConnection(gnl.ConString);
            SqlCommand cmd = new SqlCommand("Select UrunAdi,Fiyat,Satislar.ID, UrunID, Satislar.Adet from Satislar Inner Join Urunler on Satislar.UrunID=Urunler.ID Where AdisyonID=@AdisyonID", baglanti);

            SqlDataReader dr=null ;
            cmd.Parameters.Add("@AdisyonID", SqlDbType.Int).Value = AdisyonID;
            try
            {
                if(baglanti.State==ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac=0;
                while (dr.Read())
                {
                    Lv.Items.Add(dr["UrunAdi"].ToString());
                    Lv.Items[sayac].SubItems.Add(dr["Adet"].ToString());
                    Lv.Items[sayac].SubItems.Add(dr["UrunID"].ToString());
                    Lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["Fiyat"]) * Convert.ToDecimal(dr["Adet"])));
                    Lv.Items[sayac].SubItems.Add(dr["ID"].ToString());

                    sayac++;
                }
            }

            catch(SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                baglanti.Dispose();
                baglanti.Close();
            }
        }

        public bool SetSaveOrder(Siparis Bilgiler)
        {
            bool sonuc = false;

            SqlConnection baglanti = new SqlConnection(gnl.ConString);
            SqlCommand cmd = new SqlCommand("İnsert into Satislar(AdisyonID,UrunID,Adet,MasaID) values(@AdisyonNo,@UrunID,@Adet,@MasaID)", baglanti);

            try
            {
                if(baglanti.State==ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                cmd.Parameters.Add("@AdisyonNo", SqlDbType.Int).Value = Bilgiler._AdisyonID;
                cmd.Parameters.Add("@UrunID", SqlDbType.Int).Value = Bilgiler._UrunID;
                cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = Bilgiler._Adet;
                cmd.Parameters.Add("@MasaID", SqlDbType.Int).Value = Bilgiler._MasaID;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }

            catch(SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                baglanti.Dispose();
                baglanti.Close();
            }
            return sonuc;
        }

        public void SetDeleteOrder(int SatisID)
        {
            SqlConnection baglanti = new SqlConnection(gnl.ConString);
            SqlCommand cmd = new SqlCommand("Delete from Satislar where ID=@SatisID", baglanti);

            cmd.Parameters.Add("@SatisID", SqlDbType.Int).Value = SatisID;
            if(baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();

            }
            cmd.ExecuteNonQuery();
            baglanti.Dispose();
            baglanti.Close();
            
        }
         
        






    }
}
