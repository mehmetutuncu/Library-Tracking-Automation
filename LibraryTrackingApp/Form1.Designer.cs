namespace LibraryTrackingApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTarih = new System.Windows.Forms.Label();
            this.btnUyeGoruntule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKitapGoruntule = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEmanetKitapIslemleri = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeEkle.Image")));
            this.btnUyeEkle.Location = new System.Drawing.Point(24, 37);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(92, 93);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni Üye";
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaat.ForeColor = System.Drawing.Color.Red;
            this.labelSaat.Location = new System.Drawing.Point(534, 197);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(66, 26);
            this.labelSaat.TabIndex = 2;
            this.labelSaat.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarih.ForeColor = System.Drawing.Color.Red;
            this.labelTarih.Location = new System.Drawing.Point(455, 159);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(66, 26);
            this.labelTarih.TabIndex = 3;
            this.labelTarih.Text = "label2";
            // 
            // btnUyeGoruntule
            // 
            this.btnUyeGoruntule.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeGoruntule.Image")));
            this.btnUyeGoruntule.Location = new System.Drawing.Point(153, 37);
            this.btnUyeGoruntule.Name = "btnUyeGoruntule";
            this.btnUyeGoruntule.Size = new System.Drawing.Size(92, 93);
            this.btnUyeGoruntule.TabIndex = 4;
            this.btnUyeGoruntule.UseVisualStyleBackColor = true;
            this.btnUyeGoruntule.Click += new System.EventHandler(this.btnUyeGoruntule_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(131, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "  Üye Görüntüle";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(284, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 93);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(272, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = " Yeni Kitap";
            // 
            // btnKitapGoruntule
            // 
            this.btnKitapGoruntule.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapGoruntule.Image")));
            this.btnKitapGoruntule.Location = new System.Drawing.Point(413, 37);
            this.btnKitapGoruntule.Name = "btnKitapGoruntule";
            this.btnKitapGoruntule.Size = new System.Drawing.Size(92, 93);
            this.btnKitapGoruntule.TabIndex = 8;
            this.btnKitapGoruntule.UseVisualStyleBackColor = true;
            this.btnKitapGoruntule.Click += new System.EventHandler(this.btnKitapGoruntule_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(408, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kitap Görüntüle";
            // 
            // btnEmanetKitapIslemleri
            // 
            this.btnEmanetKitapIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("btnEmanetKitapIslemleri.Image")));
            this.btnEmanetKitapIslemleri.Location = new System.Drawing.Point(551, 37);
            this.btnEmanetKitapIslemleri.Name = "btnEmanetKitapIslemleri";
            this.btnEmanetKitapIslemleri.Size = new System.Drawing.Size(92, 93);
            this.btnEmanetKitapIslemleri.TabIndex = 10;
            this.btnEmanetKitapIslemleri.UseVisualStyleBackColor = true;
            this.btnEmanetKitapIslemleri.Click += new System.EventHandler(this.btnEmanetKitapIslemleri_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(527, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Emanet Kitap İşlemleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 232);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEmanetKitapIslemleri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKitapGoruntule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUyeGoruntule);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.labelSaat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUyeEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Tracking ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Button btnUyeGoruntule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKitapGoruntule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEmanetKitapIslemleri;
        private System.Windows.Forms.Label label5;
    }
}

