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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButonPaketServis_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            this.Close();
            frm.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void MasaSiparis_Click(object sender, EventArgs e)
        {
            FormMasa frm = new FormMasa();
            this.Close();
            frm.Show();
        }

        private void ButonRezervarsyon_Click(object sender, EventArgs e)
        {
            FormRezervasyon frm = new FormRezervasyon();
            this.Close();
            frm.Show();


        }

        private void ButonMüsteriler_Click(object sender, EventArgs e)
        {
            FormMusteriler frm = new FormMusteriler();
            this.Close();
            frm.Show();
        }

        private void ButonKasa_Click(object sender, EventArgs e)
        {
            FormKasaİslemleri frm = new FormKasaİslemleri();
            this.Close();
            frm.Show();
        }

        private void ButonMutfak_Click(object sender, EventArgs e)
        {
            FormMutfak frm = new FormMutfak();
            this.Close();
            frm.Show();

        }

        private void ButonRaporlar_Click(object sender, EventArgs e)
        {
            FormRaporlar frm = new FormRaporlar();
            this.Close();
            frm.Show();

        }

        private void ButonAyarlar_Click(object sender, EventArgs e)
        {
            FormAyarlar frm = new FormAyarlar();
            this.Close();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKilitle frm = new FormKilitle();
            this.Close();
            frm.Show();
        }

        private void ButonCıkıs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ButonKilitle_Load(object sender, EventArgs e)
        {

        }
    }
}
