using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodEverything
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.PersonelBilgileriniGetir(ComboKullanici);

        }




        
        private void Label1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void ButonGiris_Click(object sender, EventArgs e)
        {
            Genel gnl = new Genel();
            Personeller p = new Personeller();
            bool result = p.PersonelGirisControl(TextSifre.Text, Genel._PersonelID);

            if (result)
            {
                PersonelHareketleri ch = new PersonelHareketleri();
                ch.PersonalID= Genel._PersonelID;
                ch.İslem = "Giris Yaptı.";
                ch.Tarih = DateTime.Now;
              
                ch.PersonelAktiviteKaydet(ch);
                this.Hide();
                FormMenu menu = new FormMenu();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Hatalı şifre girdiniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ComboKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personeller p = (Personeller)ComboKullanici.SelectedItem;
            Genel._PersonelID = p.PersonalID;
            Genel._GorevID = p.PersonelGorevID;
        }

        private void ButonCikis_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
