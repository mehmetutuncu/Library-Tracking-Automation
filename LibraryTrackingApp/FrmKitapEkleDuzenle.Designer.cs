namespace LibraryTrackingApp
{
    partial class FrmKitapEkleDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapEkleDuzenle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKitapYazari = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtYayimEvi = new System.Windows.Forms.TextBox();
            this.txtKitapTuru = new System.Windows.Forms.TextBox();
            this.txtStokSayisi = new System.Windows.Forms.TextBox();
            this.btnKaydetDuzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı       :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Yazarı  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sayfa Sayısı  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yayım Evi      :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kitap Türü     :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(15, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stok Sayısı   :";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(139, 26);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(145, 20);
            this.txtKitapAdi.TabIndex = 6;
            // 
            // txtKitapYazari
            // 
            this.txtKitapYazari.Location = new System.Drawing.Point(139, 61);
            this.txtKitapYazari.Name = "txtKitapYazari";
            this.txtKitapYazari.Size = new System.Drawing.Size(145, 20);
            this.txtKitapYazari.TabIndex = 7;
            this.txtKitapYazari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapYazari_KeyPress);
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(139, 93);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(60, 20);
            this.txtSayfaSayisi.TabIndex = 8;
            this.txtSayfaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayfaSayisi_KeyPress);
            // 
            // txtYayimEvi
            // 
            this.txtYayimEvi.Location = new System.Drawing.Point(139, 126);
            this.txtYayimEvi.Name = "txtYayimEvi";
            this.txtYayimEvi.Size = new System.Drawing.Size(145, 20);
            this.txtYayimEvi.TabIndex = 9;
            // 
            // txtKitapTuru
            // 
            this.txtKitapTuru.Location = new System.Drawing.Point(139, 160);
            this.txtKitapTuru.Name = "txtKitapTuru";
            this.txtKitapTuru.Size = new System.Drawing.Size(145, 20);
            this.txtKitapTuru.TabIndex = 10;
            this.txtKitapTuru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapTuru_KeyPress);
            // 
            // txtStokSayisi
            // 
            this.txtStokSayisi.Location = new System.Drawing.Point(139, 196);
            this.txtStokSayisi.Name = "txtStokSayisi";
            this.txtStokSayisi.Size = new System.Drawing.Size(60, 20);
            this.txtStokSayisi.TabIndex = 11;
            this.txtStokSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStokSayisi_KeyPress);
            // 
            // btnKaydetDuzenle
            // 
            this.btnKaydetDuzenle.Location = new System.Drawing.Point(121, 239);
            this.btnKaydetDuzenle.Name = "btnKaydetDuzenle";
            this.btnKaydetDuzenle.Size = new System.Drawing.Size(95, 23);
            this.btnKaydetDuzenle.TabIndex = 12;
            this.btnKaydetDuzenle.Text = "button1";
            this.btnKaydetDuzenle.UseVisualStyleBackColor = true;
            this.btnKaydetDuzenle.Click += new System.EventHandler(this.btnKaydetDuzenle_Click);
            // 
            // FrmKitapEkleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 299);
            this.Controls.Add(this.btnKaydetDuzenle);
            this.Controls.Add(this.txtStokSayisi);
            this.Controls.Add(this.txtKitapTuru);
            this.Controls.Add(this.txtYayimEvi);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtKitapYazari);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKitapEkleDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library Tracking";
            this.Load += new System.EventHandler(this.FrmKitapEkleDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtKitapYazari;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtYayimEvi;
        private System.Windows.Forms.TextBox txtKitapTuru;
        private System.Windows.Forms.TextBox txtStokSayisi;
        private System.Windows.Forms.Button btnKaydetDuzenle;
    }
}