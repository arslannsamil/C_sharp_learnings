using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //herhangi bir kutuyu ctrl`e basip suruklersek cogaltmis oluruz.
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //enabled ozelliginde ise false durumunda cikti ekraninda buton silik bi sekilde gozukur dokunulamaz.
            //autosize kismini false yaparsak label`i istedigimiz gibi kucultup buyultebiliriz.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // visible ozelligi false iken form ekraninda gordugumuz butonun cikti ekraninda gozukmemesini saglar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("selam"); // tiklandigi zaman ne yazmasi gerektigini soyluyosun.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("selam2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text); //tectbox1 de yazani goster. bu guncel olarak cikti ekrani acikken de yazdiklarimizi 
            // gosterir.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*f4 yaptigimizda name seklinde yazilan kisim kod tarafinda ulasmak istedigimizde yazmamiz gereken kisin 
              eger form ekraninda gormek istedigimiz seyi yazmak istiyorsak text kismina yazmamiz gerekir.
            text kismina onceden de bisey yazabiliiriz sonradan cikti aldigimiz zaman da ekleme yapabiliriz. */

            /*button1`e tikladigimda textbox da ne yaziyosa onu gostermesini istedigimde hangi butona tikladigimda gostermesini
            istiyom o butonun kod satiurina yazmam gerekli.*/
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //cheked kismi true olursa tik atar false olursa tiki kaldirir.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //checkbox`in cek edilip edilmedigini kontrol et

            MessageBox.Show(checkBox1.Checked.ToString()); /*checkbox1.checked dedigimiz zaman onu yanlis anlamasinin nedeni 
                                                  messagebox.show() yaptigimizda bizdeen string bir sey yazmamizi istiyor ama biz 
                                                  ona bool turunde deger veriyoruz ya true yada false. O yuzden ek olarak 
                                                  .tostring() yapmamiz gerekiyo */
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // textbox in readonly propertysini true yaparsak textbox`a form ekraninda mudehale imkanini kapatmis oluyoruz.
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textbox2.Text);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("merhaba ben samil"); /*butonlara tikladigimizda ayni seyi yazmasini istedigimizde hepsini secip f4`e
                                              basip click kisminda istedigimiz seyi yazarsak yeni bir toplu mesaj olusturmus oluruz.*/
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(textBox3.Text);
            int g = Convert.ToInt32(textBox4.Text);
            int b = Convert.ToInt32(textBox5.Text);
            this.BackColor = Color.FromArgb(r,g,b);

        }
    }
} 
