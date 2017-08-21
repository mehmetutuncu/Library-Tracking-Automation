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
    public partial class FrmEmanetEkle : Form
    {
        db d = new db();
        public FrmEmanetEkle()
        {
            InitializeComponent();
        }

        private void txtUyeAranan_KeyUp(object sender, KeyEventArgs e)
        {
            string aranan = "";
            if(txtUyeAranan.Text != "")
            {
                aranan = "%"+txtUyeAranan.Text+"%";
            }
            uye_doldur(aranan);
        }
        private void txtKitapArama_KeyPress(object sender, KeyPressEventArgs e)
        {
            string aranan = "";
            if (txtKitapArama.Text != "")
            {
                aranan = "%" + txtKitapArama.Text + "%";
            }
            kitap_doldur(aranan);
        }
        string uye_sql;
        public void uye_doldur(string aranan)
        {
            try
            {
                if(aranan == "")
                {
                    uye_sql = "SELECT id,ad,soyad FROM TBL_Uyeler WHERE ihlal < 3";
                }
                else if(aranan != "")
                {
                    uye_sql = "SELECT id,ad,soyad FROM TBL_Uyeler WHERE ihlal < 3 and ad LIKE '" + aranan + "'";
                }
                d.myConnection.Open();
                SQLiteCommand select_uyeler = new SQLiteCommand(uye_sql, d.myConnection);
                SQLiteDataAdapter da = new SQLiteDataAdapter(select_uyeler);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUyeler.DataSource = dt;
                dgvUyeler.Columns["id"].Visible = false;
                dgvUyeler.Columns["ad"].HeaderText = "Ad";
                dgvUyeler.Columns["ad"].Width = 120;
                dgvUyeler.Columns["soyad"].HeaderText = "Soyad";
                dgvUyeler.Columns["soyad"].Width = 116;
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
        string kitap_sql;
        public void kitap_doldur(string aranan)
        {
            
            try
            {
                if (aranan == "")
                {
                    kitap_sql = "SELECT id,kitap_adi,stok_adedi FROM TBL_Kitaplar WHERE stok_adedi > 0";
                }
                else if (aranan != "")
                {
                    kitap_sql = "SELECT id,kitap_adi,stok_adedi FROM TBL_Kitaplar WHERE stok_adedi > 0 and kitap_adi LIKE '" + aranan + "'";
                }
                d.myConnection.Open();
                SQLiteCommand select_kitaplar = new SQLiteCommand(kitap_sql, d.myConnection);
                SQLiteDataAdapter da = new SQLiteDataAdapter(select_kitaplar);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitaplar.DataSource = dt;
                dgvKitaplar.Columns["id"].Visible = false;
                dgvKitaplar.Columns["kitap_adi"].HeaderText = "Kitap Adı";
                dgvKitaplar.Columns["stok_adedi"].HeaderText = "Stok Adedi";
                dgvKitaplar.Columns["kitap_adi"].Width = 136;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                d.myConnection.Close();
            }
        }

        private void FrmEmanetEkle_Load(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToShortDateString();
            string aranan = "";
            uye_doldur(aranan);
            kitap_doldur(aranan);
        }
        int stok;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(dgvKitaplar.CurrentRow != null && dgvUyeler.CurrentRow != null)
            {
                string uye_id = dgvUyeler.CurrentRow.Cells["id"].Value.ToString();
                string kitap_id = dgvKitaplar.CurrentRow.Cells["id"].Value.ToString();
                int k_id =  int.Parse(dgvKitaplar.CurrentRow.Cells["id"].Value.ToString());
                
                DateTime alim_tarihi = DateTime.Now;
                DateTime teslim_tarihi = txtTeslimTarihi.Value.Date;
                string alim = alim_tarihi.ToShortDateString();
                string teslim = teslim_tarihi.ToShortDateString();
                if (teslim_tarihi <= alim_tarihi)
                {
                    MessageBox.Show("Teslim tarihi alım tarihinden daha ileri olmalıdır.");
                }
                else
                {
                    try
                    {
                        d.myConnection.Open();
                        string sql = "INSERT INTO TBL_Emanetler(uye_id,kitap_id,alim_tarihi,teslim_tarihi) " +
                            "VALUES(@uye_id,@kitap_id,@alim_tarihi,@teslim_tarihi)";
                        SQLiteCommand insert_emanetler = new SQLiteCommand(sql, d.myConnection);
                        insert_emanetler.Parameters.AddWithValue("@uye_id",uye_id);
                        insert_emanetler.Parameters.AddWithValue("@kitap_id",kitap_id);
                        insert_emanetler.Parameters.AddWithValue("@alim_tarihi",alim);
                        insert_emanetler.Parameters.AddWithValue("@teslim_tarihi",teslim);
                        int a = insert_emanetler.ExecuteNonQuery();
                        
                        if (a > 0)
                        {
                            string sql2 = "SELECT stok_adedi FROM TBL_Kitaplar WHERE id = '"+k_id+"'";
                            SQLiteCommand select_kitaplar = new SQLiteCommand(sql2, d.myConnection);
                            SQLiteDataReader dr = select_kitaplar.ExecuteReader();
                            while (dr.Read())
                            {
                                stok = int.Parse(dr["stok_adedi"].ToString());
                            }
                            dr.Close();
                            if(stok != 0)
                            {
                                stok = stok - 1;
                                string sql3 = "UPDATE TBL_Kitaplar set stok_adedi = @stok where id = @id";
                                SQLiteCommand update_kitaplar = new SQLiteCommand(sql3, d.myConnection);
                                update_kitaplar.Parameters.AddWithValue("@stok", stok);
                                update_kitaplar.Parameters.AddWithValue("@id", k_id);
                                update_kitaplar.ExecuteNonQuery();
                            }
                            FrmEmanetler frm = (FrmEmanetler)Application.OpenForms["FrmEmanetler"];
                            string aranacak = "";
                            frm.doldur(aranacak);
                            frm.Refresh();
                            
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        d.myConnection.Close();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen kayıt seçiniz.");
            }
      
            
            
            
        }
    }
}
