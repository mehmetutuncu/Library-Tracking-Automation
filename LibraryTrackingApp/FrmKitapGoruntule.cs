using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace LibraryTrackingApp
{
    public partial class FrmKitapGoruntule : Form
    {
        db d = new db();
        public FrmKitapGoruntule()
        {
            InitializeComponent();
        }
        private void FrmKitapGoruntule_Load(object sender, EventArgs e)
        {
            string aranan = "";
            doldur(aranan);
            if(dgvKitaplar.Rows.Count == 0)
            {
                DialogResult result = MessageBox.Show("Kitap kaydı bulunmuyor eklemek ister misiniz?","Dikkat!",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    string parametre = "0";
                    string id = null;
                    FrmKitapEkleDuzenle frm = new FrmKitapEkleDuzenle(parametre, id);
                    frm.ShowDialog();
                }
                else if(result == DialogResult.No)
                {
                    this.Close();
                }
            }
            doldur(aranan);
        }
        public void doldur(string a)
        {
            try
            {
                string sql;
                if (a == "")
                {
                    sql = "SELECT * FROM TBL_Kitaplar";
                }
                else
                {
                    sql = "SELECT * FROM TBL_Kitaplar WHERE kitap_adi LIKE '"+a+"'";
                }
                d.myConnection.Open();
                
                SQLiteCommand select_kitaplar = new SQLiteCommand(sql, d.myConnection);
                SQLiteDataAdapter da = new SQLiteDataAdapter(select_kitaplar);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitaplar.DataSource = dt;
                dgvKitaplar.Columns["id"].Visible = false;
                dgvKitaplar.Columns["kitap_adi"].HeaderText = "Kitap Adı";
                dgvKitaplar.Columns["kitap_adi"].Width = 200;
                dgvKitaplar.Columns["yazar"].HeaderText = "Yazar Adı";
                dgvKitaplar.Columns["yazar"].Width = 150;
                dgvKitaplar.Columns["sayfa_sayisi"].HeaderText = "Sayfa Sayısı";
                dgvKitaplar.Columns["yayim_evi"].HeaderText = "Yayım Evi";
                dgvKitaplar.Columns["yayim_evi"].Width = 150;
                dgvKitaplar.Columns["kitap_turu"].HeaderText = "Kitap Türü";
                dgvKitaplar.Columns["kitap_turu"].Width = 150;
                dgvKitaplar.Columns["stok_adedi"].HeaderText = "Stok Durumu";
                dgvKitaplar.Columns["temin_tarihi"].HeaderText = "Temin Edilme Tarihi";
                dgvKitaplar.Columns["temin_tarihi"].Width = 132;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                d.myConnection.Close();
            }
        }

        private void txtArama_KeyUp(object sender, KeyEventArgs e)
        {
            string aranan = "";
            if(txtArama.Text != "")
            {
                aranan = "%" + txtArama.Text + "%";
            }
            doldur(aranan);
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            string parametre = "1";
            string id = null;
            FrmKitapEkleDuzenle frm = new FrmKitapEkleDuzenle(parametre,id);
            frm.ShowDialog();
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Dikkat!", MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes)
            {
                if(dgvKitaplar.CurrentRow != null)
                {
                    try
                    {
                        string id = dgvKitaplar.CurrentRow.Cells["id"].Value.ToString();
                        d.myConnection.Open();
                        string sql = "DELETE FROM TBL_Kitaplar WHERE id = @id";
                        SQLiteCommand delete_kitaplar = new SQLiteCommand(sql, d.myConnection);
                        delete_kitaplar.Parameters.AddWithValue("@id", id);
                        delete_kitaplar.ExecuteNonQuery();
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        d.myConnection.Close();
                        string arama = "";
                        doldur(arama);
                    }
                    
                }
                else if(dgvKitaplar.Rows.Count == 0)
                {
                    MessageBox.Show("Kayıt bulunmadığı için silme işlemini gerçekleştiremiyorum.");
                }
                else
                {
                    MessageBox.Show("Kayıt bulunmadığı için silme işlemini gerçekleştiremiyorum.");
                }
            }
        }

        private void btnKitapDuzenle_Click(object sender, EventArgs e)
        {
            string parametre = "2";
            if(dgvKitaplar.CurrentRow != null)
            {
                string id = dgvKitaplar.CurrentRow.Cells["id"].Value.ToString();
                FrmKitapEkleDuzenle frm = new FrmKitapEkleDuzenle(parametre,id);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kayıt bulunmadığı için düzenleme işlemini gerçekleştiremiyorum.");
            }
            
        }
    }
}
