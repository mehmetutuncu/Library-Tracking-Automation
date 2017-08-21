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
    public partial class FrmEmanetDuzenle : Form
    {
        string id;
        db d = new db();
        public FrmEmanetDuzenle(string gelen_id)
        {
            InitializeComponent();
            id = gelen_id;
        }
        public void doldur()
        {
            try
            {
                d.myConnection.Open();
                string sql = "SELECT e.id,u.ad,u.soyad,k.kitap_adi,e.alim_tarihi,e.teslim_tarihi FROM TBL_Uyeler u,TBL_Kitaplar k,TBL_Emanetler e WHERE e.uye_id = u.id and e.kitap_id = k.id and e.id = @id";
                SQLiteCommand select_emanetler = new SQLiteCommand(sql, d.myConnection);
                select_emanetler.Parameters.AddWithValue("@id", id);
                SQLiteDataAdapter da = new SQLiteDataAdapter(select_emanetler);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmanet.DataSource = dt;
                dgvEmanet.Columns["id"].Visible = false;
                dgvEmanet.Columns["ad"].HeaderText = "Ad";
                dgvEmanet.Columns["soyad"].HeaderText = "Soyad";
                dgvEmanet.Columns["kitap_adi"].HeaderText = "Alınan Kitap";
                dgvEmanet.Columns["alim_tarihi"].HeaderText = "Alım Tarihi";
                dgvEmanet.Columns["teslim_tarihi"].HeaderText = "Teslim Tarihi";
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

        private void FrmEmanetDuzenle_Load(object sender, EventArgs e)
        {
            doldur();
        }
        string tarih;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(dgvEmanet.CurrentRow != null)
            {
                string tarih = dgvEmanet.CurrentRow.Cells["teslim_tarihi"].Value.ToString();
                DateTime a = DateTime.Parse(tarih);
                DateTime teslim_tarihi = dateTimePicker1.Value.Date;
                if(teslim_tarihi <= a)
                {
                    MessageBox.Show("Uzatılacak tarih daha ileri olmalıdır.");
                }
                else
                {
                    try
                    {
                        tarih = teslim_tarihi.ToShortDateString();
                        d.myConnection.Open();
                        string sql = "UPDATE TBL_Emanetler set teslim_tarihi = @teslim_tarihi WHERE id = @id";
                        SQLiteCommand update_emanetler = new SQLiteCommand(sql, d.myConnection);
                        update_emanetler.Parameters.AddWithValue("@teslim_tarihi",tarih);
                        update_emanetler.Parameters.AddWithValue("@id",id);
                        update_emanetler.ExecuteNonQuery();
                        FrmEmanetler frm = (FrmEmanetler)Application.OpenForms["FrmEmanetler"];
                        string aranan = "";
                        frm.doldur(aranan);
                        frm.Refresh();
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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
