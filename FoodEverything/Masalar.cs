using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEverything
{
    class Masalar
    {
        #region Fields
        private int _ID;
        private int _Kapasite;
        private int _ServisTuru;
        private int _Durum;
        private int _Onay;
        #endregion


        #region Properties
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int Kapasite
        {
            get { return _Kapasite; }
            set { _Kapasite = value; }
        }

        public int ServisTuru
        {
            get { return _ServisTuru; }
            set { _ServisTuru = value; }
        }

        public int Durum
        {
            get { return _Durum; }
            set { _Durum = value; }
        }

        public int Onay
        {
            get { return _Onay; }
            set { _Onay = value; }
        }
        #endregion


        Genel gnl = new Genel();
        public string SessionSum(int state, string MasaID)
        {
            string dt = "";
            SqlConnection baglanti = new SqlConnection(gnl.ConString);
            SqlCommand cmd = new SqlCommand("Select Tarih,MasaID from Adisyon Right Join Masalar on Adisyon.MasaID=Masalar.ID  Where Masalar.Durum=@Durum and Adisyon.Durum=0 and Masalar.ID=@MasaID", baglanti);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@MasaID", SqlDbType.Int).Value = Convert.ToInt32(MasaID);


            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    dt = Convert.ToDateTime(dr["Tarih"]).ToString();
                }
            }

            catch(SqlException ex)
            {
                string hata = ex.Message;
                throw;

            }

            finally
            {
                dr.Close();
                baglanti.Dispose();
                baglanti.Close();
            }
            return dt;

        }


        public int TableGetByNumber(string TableValue)
        {
            string aa = TableValue;
            int length = aa.Length;

            return Convert.ToInt32(aa.Substring(length - 1, 1));
        }

        public bool TableGetByState(int ButtonName, int state)
        {
            bool result = false;
            SqlConnection baglanti = new SqlConnection(gnl.ConString);
            SqlCommand cmd = new SqlCommand("Select Durum from Masalar Where ID=@TableID and Durum=@Durum", baglanti);

            cmd.Parameters.Add("@TableID", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;

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
            }
            finally
            {
                baglanti.Dispose();
                baglanti.Close();
            }
            return result;

        }

        public void SetChangeTableState(string ButtonName, int state)
        {
            SqlConnection baglanti = new SqlConnection(gnl.ConString);
            SqlCommand cmd = new SqlCommand("Update Masalar Set Durum=@Durum where ID=@MasaNo", baglanti);

            if(baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();

            }
            string aa = ButtonName;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            cmd.ExecuteNonQuery();
            baglanti.Dispose();
            baglanti.Close();

        }

        

        }



    }

