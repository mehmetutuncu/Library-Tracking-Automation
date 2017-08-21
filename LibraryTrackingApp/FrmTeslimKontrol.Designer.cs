namespace LibraryTrackingApp
{
    partial class FrmTeslimKontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeslimKontrol));
            this.dgvEmanetler = new System.Windows.Forms.DataGridView();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanetler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmanetler
            // 
            this.dgvEmanetler.AllowUserToAddRows = false;
            this.dgvEmanetler.AllowUserToDeleteRows = false;
            this.dgvEmanetler.AllowUserToResizeColumns = false;
            this.dgvEmanetler.AllowUserToResizeRows = false;
            this.dgvEmanetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmanetler.Location = new System.Drawing.Point(12, 12);
            this.dgvEmanetler.Name = "dgvEmanetler";
            this.dgvEmanetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmanetler.Size = new System.Drawing.Size(644, 45);
            this.dgvEmanetler.TabIndex = 0;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrol.ForeColor = System.Drawing.Color.Red;
            this.btnKontrol.Location = new System.Drawing.Point(12, 63);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(91, 30);
            this.btnKontrol.TabIndex = 1;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimAl.ForeColor = System.Drawing.Color.Red;
            this.btnTeslimAl.Location = new System.Drawing.Point(149, 63);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(91, 30);
            this.btnTeslimAl.TabIndex = 2;
            this.btnTeslimAl.Text = "Teslim Al";
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // FrmTeslimKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 112);
            this.Controls.Add(this.btnTeslimAl);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.dgvEmanetler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTeslimKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library Tracking";
            this.Load += new System.EventHandler(this.FrmTeslimKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanetler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmanetler;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Button btnTeslimAl;
    }
}