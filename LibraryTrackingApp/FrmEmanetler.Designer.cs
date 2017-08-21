namespace LibraryTrackingApp
{
    partial class FrmEmanetler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmanetler));
            this.dgvEmanetler = new System.Windows.Forms.DataGridView();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmanetEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnKontrol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanetler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmanetler
            // 
            this.dgvEmanetler.AllowUserToAddRows = false;
            this.dgvEmanetler.AllowUserToDeleteRows = false;
            this.dgvEmanetler.AllowUserToResizeColumns = false;
            this.dgvEmanetler.AllowUserToResizeRows = false;
            this.dgvEmanetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmanetler.Location = new System.Drawing.Point(12, 63);
            this.dgvEmanetler.Name = "dgvEmanetler";
            this.dgvEmanetler.ReadOnly = true;
            this.dgvEmanetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmanetler.Size = new System.Drawing.Size(596, 238);
            this.dgvEmanetler.TabIndex = 1;
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(54, 24);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(153, 20);
            this.txtAranan.TabIndex = 2;
            this.txtAranan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAranan_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnEmanetEkle
            // 
            this.btnEmanetEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetEkle.ForeColor = System.Drawing.Color.Red;
            this.btnEmanetEkle.Location = new System.Drawing.Point(257, 11);
            this.btnEmanetEkle.Name = "btnEmanetEkle";
            this.btnEmanetEkle.Size = new System.Drawing.Size(112, 45);
            this.btnEmanetEkle.TabIndex = 9;
            this.btnEmanetEkle.Text = "Emanet Kitap Ekle";
            this.btnEmanetEkle.UseVisualStyleBackColor = true;
            this.btnEmanetEkle.Click += new System.EventHandler(this.btnEmanetEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ForeColor = System.Drawing.Color.Red;
            this.btnDuzenle.Location = new System.Drawing.Point(375, 12);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(112, 45);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "Süre Uzat";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnKontrol
            // 
            this.btnKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrol.ForeColor = System.Drawing.Color.Red;
            this.btnKontrol.Location = new System.Drawing.Point(493, 12);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(112, 45);
            this.btnKontrol.TabIndex = 11;
            this.btnKontrol.Text = "Teslim İşlemleri";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // FrmEmanetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 313);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEmanetEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.dgvEmanetler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmanetler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library Tracking";
            this.Load += new System.EventHandler(this.FrmEmanetler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanetler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEmanetler;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmanetEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnKontrol;
    }
}