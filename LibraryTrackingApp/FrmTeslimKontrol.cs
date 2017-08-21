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
    public partial class FrmTeslimKontrol : Form
    {
        string id;
        db d = new db();
        public FrmTeslimKontrol(string gelen_id)
        {
            InitializeComponent();
            id = gelen_id;
        }
        public void doldur()
        {
            try
            {
                d.myConnection.Open();
                string sql = "SELECT e.id,e.uye_id,u.ad,u.soyad,k.kitap_adi,e.alim_tarihi,e.teslim_tarihi,e.teslim_durumu FROM TBL_Uyeler u,TBL_Kitaplar k,TBL_Emanetler e WHERE e.uye_id = u.id and e.kitap_id = k.id and e.id = @id";
                SQLiteCommand select_emanetler = new SQLiteCommand(sql,d.myConnection);
                select_emanetler.Parameters.AddWithValue("@id", id);
                SQLiteDataAdapter da = new SQLiteDataAdapter(select_emanetler);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmanetler.DataSource = dt;
                dgvEmanetler.Columns["id"].Visible = false;
                dgvEmanetler.Columns["uye_id"].Visible = false;
                dgvEmanetler.Columns["ad"].HeaderText = "Ad";
                dgvEmanetler.Columns["soyad"].HeaderText = "Soyad";
                dgvEmanetler.Columns["kitap_adi"].HeaderText = "Kitap Adı";
                dgvEmanetler.Columns["alim_tarihi"].HeaderText = "Alım Tarihi";
                dgvEmanetler.Columns["teslim_tarihi"].HeaderText = "Teslim Tarihi";
                dgvEmanetler.Columns["teslim_durumu"].HeaderText = "Teslim Durumu";
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
        int ihlal;
        public void ihlal_kontrol()
        {
            if (dgvEmanetler.CurrentRow != null)
            {
                teslim_tarihi = dgvEmanetler.CurrentRow.Cells["teslim_tarihi"].Value.ToString();
                
                DateTime teslim = DateTime.Parse(teslim_tarihi);
                DateTime now = DateTime.Now;
                
                if (teslim < now)
                {
                    MessageBox.Show("Teslim süresi dolmuş.");
                    try
                    {
                        d.myConnection.Open();
                        string uye_id = dgvEmanetler.CurrentRow.Cells["uye_id"].Value.ToString();
                        string select_sql = "SELECT ihlal FROM TBL_Uyeler WHERE id = @id";
                        SQLiteCommand select_uyeler = new SQLiteCommand(select_sql, d.myConnection);
                        select_uyeler.Parameters.AddWithValue("@id",uye_id);
                        SQLiteDataReader dr = select_uyeler.ExecuteReader();
                        while (dr.Read())
                        {
                            ihlal = int.Parse(dr["ihlal"].ToString()) + 1;
                        }
                        dr.Close();
                        string update_sql = "UPDATE TBL_Uyeler SET ihlal = @ihlal WHERE id = @id";
                        SQLiteCommand update_uyeler = new SQLiteCommand(update_sql, d.myConnection);
                        update_uyeler.Parameters.AddWithValue("@ihlal",ihlal);
                        update_uyeler.Parameters.AddWithValue("@id",uye_id);
                        int a = update_uyeler.ExecuteNonQuery();
                        
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
                else
                {
                    MessageBox.Show("Teslim etme süresi bitmemiştir.");
                }
            }
        }
        string teslim_tarihi;
        private void FrmTeslimKontrol_Load(object sender, EventArgs e)
        {
            doldur();
            
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            ihlal_kontrol();
        }
        int kitap_id;
        int stok;
        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            try
            {
                d.myConnection.Open();
                string durum = "Teslim Edildi";
                string sql_update = "UPDATE TBL_Emanetler set teslim_durumu = @durum where id = @id";
                SQLiteCommand emanetler_update = new SQLiteCommand(sql_update, d.myConnection);
                emanetler_update.Parameters.AddWithValue("@durum", durum);
                emanetler_update.Parameters.AddWithValue("@id", id);
                int result = emanetler_update.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Teslim Edildi.");
                    string sql_select = "SELECT kitap_id FROM TBL_Emanetler WHERE id = @id";
                    SQLiteCommand emanetler_select = new SQLiteCommand(sql_select, d.myConnection);
                    emanetler_select.Parameters.AddWithValue("@id", id);
                    SQLiteDataReader dr = emanetler_select.ExecuteReader();
                    while (dr.Read())
                    {
                        kitap_id = int.Parse(dr["kitap_id"].ToString());
                    }
                    dr.Close();
                    string kitaplar_sql = "SELECT stok_adedi FROM TBL_Kitaplar WHERE id = @id";
                    SQLiteCommand kitaplar_select = new SQLiteCommand(kitaplar_sql, d.myConnection);
                    kitaplar_select.Parameters.AddWithValue("@id", kitap_id);
                    SQLiteDataReader dr2 = kitaplar_select.ExecuteReader();
                    while (dr2.Read())
                    {
                        stok = int.Parse(dr2["stok_adedi"].ToString());
                    }
                    dr2.Close();
                    stok = stok + 1;
                    string kitaplar_sql2 = "UPDATE TBL_Kitaplar set stok_adedi = @stok where id = @id";
                    SQLiteCommand kitaplar_update = new SQLiteCommand(kitaplar_sql2, d.myConnection);
                    kitaplar_update.Parameters.AddWithValue("@stok",stok);
                    kitaplar_update.Parameters.AddWithValue("@id", kitap_id);
                    kitaplar_update.ExecuteNonQuery();

                }
                string aranaacak = "";
                FrmEmanetler frm_emanetler = (FrmEmanetler)Application.OpenForms["FrmEmanetler"];
                frm_emanetler.doldur(aranaacak);
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
}
