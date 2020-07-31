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

namespace FoodEverything
{
    public partial class FormMasa : Form
    {
        public FormMasa()
        {
            InitializeComponent();
        }
        Genel gnl = new Genel();
        private void Masa_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(gnl.ConString);
            SqlCommand cmd = new SqlCommand("Select Durum,ID from Masalar",baglanti);
            SqlDataReader dr = null;

            if(baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
            }
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if(true)
                {
                    foreach(Control item in this.Controls)
                    {
                        if(item is Button)
                        {
                            if(item.Name=="ButonMasa"+dr["ID"].ToString() && dr["Durum"].ToString()=="1")
                            {
                                
                                item.BackgroundImage = (System.Drawing.Image)(Properties.Resource1.bos);

                            }
                            else if(item.Name=="ButonMasa"+dr["ID"].ToString()&& dr["Durum"].ToString() == "2")
                            {
                                Masalar ms = new Masalar();
                                DateTime dt1 = Convert.ToDateTime(ms.SessionSum(2,dr["ID"].ToString()));
                                DateTime dt2 = DateTime.Now;
                                string st1 = Convert.ToDateTime(ms.SessionSum(2,dr["ID"].ToString())).ToShortTimeString();
                                string st2 = DateTime.Now.ToShortTimeString();

                                DateTime t1 = dt1.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                                DateTime t2=  dt2.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);

                                var fark = t2 - t1;

                                 item.Text = String.Format("{0}{1}{2}",
                                   fark.Days > 0 ? string.Format("{0} gün", fark.Days):" ",
                                 fark.Hours > 0 ? string.Format("{0} Saat", fark.Hours) : " ",
                                fark.Minutes > 0 ? string.Format("{0} Dakika", fark.Minutes) : " ").Trim() +"\n\n\nMasa" + dr["ID"].ToString() ;

                                item.BackgroundImage = (System.Drawing.Image)(Properties.Resource1.dolu);

                            }

                            else if (item.Name == "ButonMasa" + dr["ID"].ToString() && dr["Durum"].ToString() == "3")
                            {
                                item.BackgroundImage = (System.Drawing.Image)(Properties.Resource1.AcıkRezerve);
                            }
                            else if (item.Name == "ButonMasa" + dr["ID"].ToString() && dr["Durum"].ToString() == "4")
                            {
                                item.BackgroundImage = (System.Drawing.Image)(Properties.Resource1.Rezerve);
                            }

                        }
                    }
                }
            }


          

            
            


        }

        private void ButonCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ButonGeriDon_Click(object sender, EventArgs e)
        {
            FormMenu frm = new FormMenu();
            this.Close();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButonMasa1_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = ButonMasa1.Text.Length;

            Genel._ButtonValue = ButonMasa1.Text.Substring(uzunluk-6,6);
            Genel._ButtonName = ButonMasa1.Name;
            this.Close();
            frm.ShowDialog();

        }

        private void ButonMasa2_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = ButonMasa2.Text.Length;

            Genel._ButtonValue = ButonMasa2.Text.Substring(uzunluk - 6, 6);
            Genel._ButtonName = ButonMasa2.Name;
            this.Close();
            frm.ShowDialog();

        }

        private void ButonMasa3_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = ButonMasa3.Text.Length;

            Genel._ButtonValue = ButonMasa3.Text.Substring(uzunluk - 6, 6);
            Genel._ButtonName = ButonMasa3.Name;
            this.Close();
            frm.ShowDialog();

        }

        private void ButonMasa4_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = ButonMasa4.Text.Length;

            Genel._ButtonValue = ButonMasa4.Text.Substring(uzunluk - 6, 6);
            Genel._ButtonName = ButonMasa4.Name;
            this.Close();
            frm.ShowDialog();

        }

        private void ButonMasa5_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = ButonMasa5.Text.Length;

            Genel._ButtonValue = ButonMasa5.Text.Substring(uzunluk - 6, 6);
            Genel._ButtonName = ButonMasa5.Name;
            this.Close();
            frm.ShowDialog();

        }

        private void ButonMasa6_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = ButonMasa6.Text.Length;

            Genel._ButtonValue = ButonMasa6.Text.Substring(uzunluk - 6, 6);
            Genel._ButtonName = ButonMasa6.Name;
            this.Close();
            frm.ShowDialog();

        }

        private void ButonMasa7_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = ButonMasa7.Text.Length;

            Genel._ButtonValue = ButonMasa7.Text.Substring(uzunluk - 6, 6);
            Genel._ButtonName = ButonMasa7.Name;
            this.Close();
            frm.ShowDialog();

        }

        private void ButonMasa8_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = ButonMasa8.Text.Length;

            Genel._ButtonValue = ButonMasa8.Text.Substring(uzunluk - 6, 6);
            Genel._ButtonName = ButonMasa8.Name;
            this.Close();
            frm.ShowDialog();

        }

        private void ButonMasa9_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = ButonMasa9.Text.Length;

            Genel._ButtonValue = ButonMasa9.Text.Substring(uzunluk - 6, 6);
            Genel._ButtonName = ButonMasa9.Name;
            this.Close();
            frm.ShowDialog();

        }

        private void ButonMasa10_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = ButonMasa10.Text.Length;

            Genel._ButtonValue = ButonMasa10.Text.Substring(uzunluk - 6, 6);
            Genel._ButtonName = ButonMasa10.Name;
            this.Close();
            frm.ShowDialog();

        }
    }
}
