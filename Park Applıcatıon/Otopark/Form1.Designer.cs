
namespace Otopark
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtotoparkadi = new System.Windows.Forms.Label();
            this.txtotoparkkapasitesi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbiletiade = new System.Windows.Forms.Button();
            this.btnbiletsat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbosyerogren = new System.Windows.Forms.Button();
            this.btnbakiyeogren = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnotoparkolustur = new System.Windows.Forms.Button();
            this.chkstandartarac = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtotoparkadi
            // 
            this.txtotoparkadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtotoparkadi.Location = new System.Drawing.Point(33, 54);
            this.txtotoparkadi.Name = "txtotoparkadi";
            this.txtotoparkadi.Size = new System.Drawing.Size(120, 18);
            this.txtotoparkadi.TabIndex = 0;
            this.txtotoparkadi.Text = "Otopark Adi";
            this.txtotoparkadi.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtotoparkkapasitesi
            // 
            this.txtotoparkkapasitesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtotoparkkapasitesi.Location = new System.Drawing.Point(33, 77);
            this.txtotoparkkapasitesi.Name = "txtotoparkkapasitesi";
            this.txtotoparkkapasitesi.Size = new System.Drawing.Size(185, 18);
            this.txtotoparkkapasitesi.TabIndex = 1;
            this.txtotoparkkapasitesi.Text = "Otoparkk Kapasitesi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkstandartarac);
            this.groupBox1.Controls.Add(this.btnbiletiade);
            this.groupBox1.Controls.Add(this.btnbiletsat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 149);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Satis-Iade";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnbiletiade
            // 
            this.btnbiletiade.Location = new System.Drawing.Point(115, 73);
            this.btnbiletiade.Name = "btnbiletiade";
            this.btnbiletiade.Size = new System.Drawing.Size(89, 70);
            this.btnbiletiade.TabIndex = 0;
            this.btnbiletiade.Text = "Bilet Iade";
            this.btnbiletiade.UseVisualStyleBackColor = true;
            this.btnbiletiade.Click += new System.EventHandler(this.btnbiletiade_Click);
            // 
            // btnbiletsat
            // 
            this.btnbiletsat.Location = new System.Drawing.Point(10, 73);
            this.btnbiletsat.Name = "btnbiletsat";
            this.btnbiletsat.Size = new System.Drawing.Size(93, 70);
            this.btnbiletsat.TabIndex = 0;
            this.btnbiletsat.Text = "Bilet Satis";
            this.btnbiletsat.UseVisualStyleBackColor = true;
            this.btnbiletsat.Click += new System.EventHandler(this.btnbiletsat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnbosyerogren);
            this.groupBox2.Controls.Add(this.btnbakiyeogren);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(302, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 149);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapor";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnbosyerogren
            // 
            this.btnbosyerogren.Location = new System.Drawing.Point(110, 73);
            this.btnbosyerogren.Name = "btnbosyerogren";
            this.btnbosyerogren.Size = new System.Drawing.Size(93, 70);
            this.btnbosyerogren.TabIndex = 0;
            this.btnbosyerogren.Text = "Bos Yer Ogren";
            this.btnbosyerogren.UseVisualStyleBackColor = true;
            this.btnbosyerogren.Click += new System.EventHandler(this.btnbosyerogren_Click);
            // 
            // btnbakiyeogren
            // 
            this.btnbakiyeogren.Location = new System.Drawing.Point(6, 73);
            this.btnbakiyeogren.Name = "btnbakiyeogren";
            this.btnbakiyeogren.Size = new System.Drawing.Size(84, 70);
            this.btnbakiyeogren.TabIndex = 0;
            this.btnbakiyeogren.Text = "Bakiye Ogren";
            this.btnbakiyeogren.UseVisualStyleBackColor = true;
            this.btnbakiyeogren.Click += new System.EventHandler(this.btnbakiyeogren_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblinfo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(37, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgi";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(6, 31);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(57, 20);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "label1";
            this.lblinfo.Visible = false;
            // 
            // btnotoparkolustur
            // 
            this.btnotoparkolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnotoparkolustur.Location = new System.Drawing.Point(393, 50);
            this.btnotoparkolustur.Name = "btnotoparkolustur";
            this.btnotoparkolustur.Size = new System.Drawing.Size(112, 51);
            this.btnotoparkolustur.TabIndex = 6;
            this.btnotoparkolustur.Text = "Otopark Olustur";
            this.btnotoparkolustur.UseVisualStyleBackColor = true;
            this.btnotoparkolustur.Click += new System.EventHandler(this.btnotoparkolustur_Click);
            // 
            // chkstandartarac
            // 
            this.chkstandartarac.AutoSize = true;
            this.chkstandartarac.Location = new System.Drawing.Point(26, 43);
            this.chkstandartarac.Name = "chkstandartarac";
            this.chkstandartarac.Size = new System.Drawing.Size(168, 24);
            this.chkstandartarac.TabIndex = 1;
            this.chkstandartarac.Text = "standart arac mi?";
            this.chkstandartarac.UseVisualStyleBackColor = true;
            this.chkstandartarac.CheckedChanged += new System.EventHandler(this.chkstandartarac_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnotoparkolustur);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtotoparkkapasitesi);
            this.Controls.Add(this.txtotoparkadi);
            this.Name = "Form1";
            this.Text = "Bilet Satis-Iade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtotoparkadi;
        private System.Windows.Forms.Label txtotoparkkapasitesi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnbiletiade;
        private System.Windows.Forms.Button btnbiletsat;
        private System.Windows.Forms.Button btnbosyerogren;
        private System.Windows.Forms.Button btnbakiyeogren;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnotoparkolustur;
        private System.Windows.Forms.CheckBox chkstandartarac;
    }
}

