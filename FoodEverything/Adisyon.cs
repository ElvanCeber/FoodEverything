using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Configuration;

namespace FoodEverything
{
    class Adisyon
    {
        Genel gnl = new Genel();

        #region Fields

        private int _ID;
        private int _ServisTurNo;
        private decimal _Tutar;
        private DateTime _Tarih;
        private int _PersonelID;
        private int _Durum;
        private int _MasaID;
        #endregion


        #region Properties
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int ServisTurNo
        {
            get { return _ServisTurNo; }
            set { _ServisTurNo = value; }
        }

        public decimal Tutar
        {
            get { return _Tutar; }
            set { _Tutar = value; }
        }

        public DateTime Tarih
        {
            get { return _Tarih; }
            set { _Tarih = value; }

        }

        public int PersonelID
        {
            get { return _PersonelID; }
            set { _PersonelID = value; }
        }

        public int Durum
        {
            get { return _Durum; }
            set { _Durum = value; }
        }

        public int MasaID
        {
            get { return _MasaID; }
            set { _MasaID = value; }
        }

        #endregion

        public int GetByAddition(int MasaID)
        {
            SqlConnection baglanti = new SqlConnection(gnl.ConString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID From Adisyon where MasaID=@MasaID Order by ID desc", baglanti);

            cmd.Parameters.Add("@MasaID", SqlDbType.Int).Value = MasaID;
            try
            {
                if(baglanti.State==ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                MasaID = Convert.ToInt32(cmd.ExecuteScalar());
            }

            catch(SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                baglanti.Close();
            }

            return MasaID;
        }

        public bool SetByAdditionNew(Adisyon Bilgiler)
        {
            bool sonuc = false;

            SqlConnection baglanti = new SqlConnection(gnl.ConString);
            SqlCommand cmd=new SqlCommand("Insert Into Adisyon(ServisTurNo,PersonelID,MasaID,Tarih,Durum) values(@ServisTurNo,@PersonelID,@MasaID,@Tarih,@Durum)",baglanti);

            try
            {
                if(baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = Bilgiler.ServisTurNo;
                cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = Bilgiler.PersonelID;              
                cmd.Parameters.Add("@MasaID", SqlDbType.Int).Value = Bilgiler.MasaID;
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Bilgiler.Tarih;
                cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = 0;
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











    }
}
