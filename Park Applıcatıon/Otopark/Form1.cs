using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        otopark otopark1 = null;
        private void btnotoparkolustur_Click(object sender, EventArgs e)
        {
            // tostring ifadesine yeni anlamlar yukleyebiliriz. tostring`i ovveride edebiliriz.
            if (txtotoparkadi.Text == "")
            {
                MessageBox.Show("otopark adi zorunlu");
                return; // bu satir kodun calismasini durdurur.
            }

            // kapasite alanina integer deger girilmeli.

            int cevirilendeger = 0;
            bool cevirmesonucu = Int32.TryParse(txtotoparkkapasitesi.Text, out cevirilendeger);

            //cevirirse in degeri cevirilendeger`in icine yazar ve sonucu true doner
            //ceviremezse sonucu false doner ve cevrilendeger 0 olarak kalir

            //if (!cevirmesonucu)
            //{
            //    MessageBox.Show("girilen deger sayisal olmalidir");
            //    return; //Bu satir calismasini durdurur
            //}


            otopark1 = new otopark(txtotoparkadi.Text, cevirilendeger);
            lblinfo.Text = "otopark olusturuldu";

            btnotoparkolustur.Enabled = false;
            btnbakiyeogren.Enabled = true;
            btnbiletsat.Enabled = true;
            btnbiletiade.Enabled = true;
            btnbosyerogren.Enabled = true;
        }

        private void btnbakiyeogren_Click(object sender, EventArgs e)
        {
            lblinfo.Text = "guncel baliye" + otopark1.bakiyeogren();
        }

        private void chkstandartarac_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnbiletsat_Click(object sender, EventArgs e)
        {
            otopark1.biletsat(chkstandartarac.Checked);
            lblinfo.Text = "bilet satildi";
        }

        private void btnbiletiade_Click(object sender, EventArgs e)
        {
            otopark1.biletiade(chkstandartarac.Checked);
            lblinfo.Text = "bilet iade edildi";
        }

        private void btnbosyerogren_Click(object sender, EventArgs e)
        {
            lblinfo.Text = "kalan arac kapasitesi" + otopark1.bosyersayisiogren();
        }
        public override string ToString()
        {
            //eger nesneadi.tostring yapilirsa gel benim ovveride ettigim metodu yani bu metodu calistir
            return "otopark adi:" + this.txtotoparkadi + "; kapasite:" + this.txtotoparkkapasitesi +"; bos yer sayisi:" +
                this.btnbosyerogren + "; bakiye:" + this.btnbakiyeogren;
        }
    }
}
