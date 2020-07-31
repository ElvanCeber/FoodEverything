using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEverything
{
    class PersonelHareketleri
    {
        Genel gnl = new Genel();
        #region Fieds
        private int _ID;
        private int _PersonalID;
        private string _İslem;
        private DateTime _Tarih;
        private bool _Durum;

       

        
        #endregion
        #region Properties

        public int ID { get { return _ID; } set { _ID = value; } }
        public int PersonalID { get { return _PersonalID; } set { _PersonalID = value; } }
        public string İslem { get { return _İslem; } set { _İslem = value; } }
        public DateTime Tarih { get { return _Tarih; } set { _Tarih = value; } }
        public bool Durum { get { return _Durum; } set { _Durum = value; } }

        #endregion

        public bool PersonelAktiviteKaydet(PersonelHareketleri ph  )
        {
            bool result = false;

            SqlConnection baglanti = new SqlConnection(gnl.ConString);
            SqlCommand cmd = new SqlCommand("Insert into PersonelHareketleri(PersonelID,İslem,Tarih)Values(@PersonelID, @İslem,@Tarih)", baglanti);

            try
            {
                if(baglanti.State==ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = ph._PersonalID;
                cmd.Parameters.Add("@İslem", SqlDbType.VarChar).Value = ph._İslem;
                cmd.Parameters.Add("@Tarih", SqlDbType.Date).Value = ph._Tarih;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }


            catch(SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return result;

        }


    }
}
