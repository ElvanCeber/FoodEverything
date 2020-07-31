using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodEverything
{
    public partial class FormSiparis : Form
    {
        public FormSiparis()
        {
            InitializeComponent();
        }

        private void LabelMasaNo_Click(object sender, EventArgs e)
        {

        }

        private void ButonAnayemek_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        

        void İslem(Object sender,EventArgs e)
        {
            Button btn = sender as Button;
            switch(btn.Name)
            {
                case "HButon1":
                    TextAdet.Text += (1).ToString();
                    break;

                case "HButon2":
                    TextAdet.Text += (2).ToString();
                    break;

                case "HButon3":
                    TextAdet.Text += (3).ToString();
                    break;
                case "HButon4":
                    TextAdet.Text += (4).ToString();
                    break;

                case "HButon5":
                    TextAdet.Text += (5).ToString();
                    break;

                case "HButon6":
                    TextAdet.Text += (6).ToString();
                    break;
                case "HButon7":
                    TextAdet.Text += (7).ToString();
                    break;
                case "HButon8":
                    TextAdet.Text += (8).ToString();
                    break;
                case "HButon9":
                    TextAdet.Text += (9).ToString();
                    break;
                case "HButon0":
                    TextAdet.Text += (0).ToString();
                    break;
                default:
                    MessageBox.Show("Sayı gir");
                    break;

            }
        }


        int TableID; int AdditionID;
        private void FormSiparis_Load(object sender, EventArgs e)
        {

            LabelMasaNo.Text = Genel._ButtonValue;
            Masalar ms = new Masalar();
            TableID = ms.TableGetByNumber(Genel._ButtonName);

            if(ms.TableGetByState(TableID,2)==true || ms.TableGetByState(TableID,4)==true)
            {
                Adisyon Ad = new Adisyon();
                AdditionID = Ad.GetByAddition(TableID);
                Siparis Orders = new Siparis();
                Orders.GetByOrder(ListSiparisler, AdditionID);

            }
            



            HButon1.Click += new EventHandler(İslem);
            HButon2.Click += new EventHandler(İslem);
            HButon3.Click += new EventHandler(İslem);
            HButon4.Click += new EventHandler(İslem);
            HButon5.Click += new EventHandler(İslem);
            HButon6.Click += new EventHandler(İslem);
            HButon7.Click += new EventHandler(İslem);
            HButon8.Click += new EventHandler(İslem);
            HButon9.Click += new EventHandler(İslem);
            HButon0.Click += new EventHandler(İslem);

        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ButonCikis_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
        //Hesap İşlemi

        private void HButon1_Click(object sender, EventArgs e)
        {

        }

        private void ListSiparisler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        UrunCesitleri Uc = new UrunCesitleri();
        private void ButonAnayemek3_Click(object sender, EventArgs e)
        {
            Uc.GetByProductTypes(ListMenu, ButonAnayemek3);
        }

        private void Butonİcecekler8_Click(object sender, EventArgs e)
        {
            Uc.GetByProductTypes(ListMenu, Butonİcecekler8);
        }

        private void ButonTatlı7_Click(object sender, EventArgs e)
        {
            Uc.GetByProductTypes(ListMenu, ButonTatlı7);
        }

        private void ButonSalata6_Click(object sender, EventArgs e)
        {
            Uc.GetByProductTypes(ListMenu, ButonSalata6);
        }

        private void ButonFastFood5_Click(object sender, EventArgs e)
        {
            Uc.GetByProductTypes(ListMenu, ButonFastFood5);
        }

        private void ButonCorba1_Click(object sender, EventArgs e)
        {
            Uc.GetByProductTypes(ListMenu, ButonCorba1);
        }

        private void ButonMakarna4_Click(object sender, EventArgs e)
        {
            Uc.GetByProductTypes(ListMenu, ButonMakarna4);
        }

        private void ButonArasıcak2_Click(object sender, EventArgs e)
        {
            Uc.GetByProductTypes(ListMenu, ButonArasıcak2);
        }

        int sayac = 0; int sayac2 = 0;
        private void ListMenu_DoubleClick(object sender, EventArgs e)
        {
            if (TextAdet.Text == "")
            {
                TextAdet.Text = "1";
            }

            if (ListMenu.Items.Count > 0)
            {
                sayac = ListSiparisler.Items.Count;
                ListSiparisler.Items.Add(ListMenu.SelectedItems[0].Text);
                ListSiparisler.Items[sayac].SubItems.Add(TextAdet.Text);
                ListSiparisler.Items[sayac].SubItems.Add(ListMenu.SelectedItems[0].SubItems[2].Text);
                ListMenu.Items[sayac].SubItems.Add((Convert.ToDecimal(ListMenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal(TextAdet.Text)).ToString());
                ListMenu.Items[sayac].SubItems.Add("0");
                sayac2 = ListeYeniEklenenler.Items.Count;
                ListSiparisler.Items[sayac].SubItems.Add(sayac2.ToString());


                ListeYeniEklenenler.Items.Add(AdditionID.ToString());
                ListeYeniEklenenler.Items[sayac2].SubItems.Add(ListMenu.SelectedItems[0].SubItems[2].Text);
                ListeYeniEklenenler.Items[sayac2].SubItems.Add(TextAdet.Text);
                ListeYeniEklenenler.Items[sayac2].SubItems.Add(TableID.ToString());
                ListeYeniEklenenler.Items[sayac2].SubItems.Add(sayac2.ToString());

                sayac2++;
                TextAdet.Text = "";
                    
                

            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        ArrayList Silinenler = new ArrayList();
        private void BtnSiparis_Click(object sender, EventArgs e)
        {
            //1-MasaBoş,2-MasaDolu,3-Rezerve
           
            Masalar masa = new Masalar();
            FormMasa ms = new FormMasa();
            Adisyon newAddition = new Adisyon();
            Siparis SaveOrder = new Siparis();
            
            bool sonuc = false;

            if(masa.TableGetByState(TableID,1)==true)
            {
                newAddition.ServisTurNo = 1;
                newAddition.PersonelID = 1;
                newAddition.MasaID = TableID;
                newAddition.Tarih = DateTime.Now;
                sonuc = newAddition.SetByAdditionNew(newAddition);

                masa.SetChangeTableState(Genel._ButtonName, 2);

                if (ListSiparisler.Items.Count > 0)
                {
                    for(int i = 0; i < ListSiparisler.Items.Count; i++)
                    {
                        SaveOrder.MasaID = TableID;
                        SaveOrder.UrunID =Convert.ToInt32(ListSiparisler.Items[i].SubItems[2].Text);
                        SaveOrder.AdisyonID = newAddition.GetByAddition(TableID);
                        SaveOrder.Adet = Convert.ToInt32(ListSiparisler.Items[i].SubItems[1].Text);
                        SaveOrder.SetSaveOrder(SaveOrder);


                    }
                    this.Close();
                    ms.Show();
                }

                else if(masa.TableGetByState(TableID,2)==true)
                {
                    if (ListeYeniEklenenler.Items.Count > 0)
                    {
                        for (int i = 0; i < ListeYeniEklenenler.Items.Count; i++)
                        {
                            SaveOrder.MasaID = TableID;
                            SaveOrder.UrunID = Convert.ToInt32(ListeYeniEklenenler.Items[i].SubItems[1].Text);
                            SaveOrder.AdisyonID = newAddition.GetByAddition(TableID);
                            SaveOrder.Adet = Convert.ToInt32(ListeYeniEklenenler.Items[i].SubItems[2].Text);
                            SaveOrder.SetSaveOrder(SaveOrder);

                        }

                    }

                    if(Silinenler.Count>0)
                    {
                        foreach(string item in Silinenler)
                        {
                            SaveOrder.SetDeleteOrder(Convert.ToInt32(item));
                        }
                    }
                    this.Close();
                    ms.Show();
                }
            }


        }

        private void ListSiparisler_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ListSiparisler_DoubleClick(object sender, EventArgs e)
        {
            if(ListSiparisler.Items.Count>0)
            {
                if (ListSiparisler.SelectedItems[0].SubItems[4].Text != "0")
                {
                    Siparis SaveOrder = new Siparis();
                    SaveOrder.SetDeleteOrder(Convert.ToInt32(ListSiparisler.Items[0].SubItems[4].Text));
                }
                else
                {
                    for(int i = 0; i < ListeYeniEklenenler.Items.Count; i++)
                    {
                        if(ListeYeniEklenenler.Items[i].SubItems[4].Text==ListSiparisler.SelectedItems[0].SubItems[5].Text)
                        {
                            ListeYeniEklenenler.Items.RemoveAt(i);
                        }
                    }
                }
                ListSiparisler.Items.RemoveAt(ListSiparisler.SelectedItems[0].Index);
            }
        }

        private void HButon2_Click(object sender, EventArgs e)
        {

        }

        private void ListSiparisler_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
    }
}
