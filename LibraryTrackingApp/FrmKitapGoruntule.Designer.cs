namespace LibraryTrackingApp
{
    partial class FrmKitapGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapGoruntule));
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnKitapDuzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.AllowUserToAddRows = false;
            this.dgvKitaplar.AllowUserToDeleteRows = false;
            this.dgvKitaplar.AllowUserToResizeColumns = false;
            this.dgvKitaplar.AllowUserToResizeRows = false;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(12, 79);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.Size = new System.Drawing.Size(1025, 276);
            this.dgvKitaplar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(54, 39);
            this.txtArama.Multiline = true;
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(182, 24);
            this.txtArama.TabIndex = 6;
            this.txtArama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtArama_KeyUp);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.ForeColor = System.Drawing.Color.Red;
            this.btnKitapEkle.Location = new System.Drawing.Point(649, 12);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(119, 61);
            this.btnKitapEkle.TabIndex = 8;
            this.btnKitapEkle.Text = "Yeni Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapSil.ForeColor = System.Drawing.Color.Red;
            this.btnKitapSil.Location = new System.Drawing.Point(784, 12);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(119, 61);
            this.btnKitapSil.TabIndex = 9;
            this.btnKitapSil.Text = "Kitap Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // btnKitapDuzenle
            // 
            this.btnKitapDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapDuzenle.ForeColor = System.Drawing.Color.Red;
            this.btnKitapDuzenle.Location = new System.Drawing.Point(918, 12);
            this.btnKitapDuzenle.Name = "btnKitapDuzenle";
            this.btnKitapDuzenle.Size = new System.Drawing.Size(119, 61);
            this.btnKitapDuzenle.TabIndex = 10;
            this.btnKitapDuzenle.Text = "Düzenle";
            this.btnKitapDuzenle.UseVisualStyleBackColor = true;
            this.btnKitapDuzenle.Click += new System.EventHandler(this.btnKitapDuzenle_Click);
            // 
            // FrmKitapGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 367);
            this.Controls.Add(this.btnKitapDuzenle);
            this.Controls.Add(this.btnKitapSil);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.dgvKitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKitapGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library Tracking";
            this.Load += new System.EventHandler(this.FrmKitapGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Button btnKitapDuzenle;
    }
}