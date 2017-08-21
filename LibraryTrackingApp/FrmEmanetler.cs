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
    public partial class FrmEmanetler : Form
    {
        db d = new db();
        public FrmEmanetler()
        {
            InitializeComponent();
        }

        private void FrmEmanetler_Load(object sender, EventArgs e)
        {
            string par = "";
            doldur(par);
        }
        string sql = "";
        string a = "";
        public void doldur(string aranacak)
        {
            
            try
            {
                
              
                if (aranacak != "")
                {
                    sql = "SELECT e.id,u.ad,u.soyad,k.kitap_adi,e.alim_tarihi,e.teslim_tarihi FROM TBL_Uyeler u,TBL_Kitaplar k,TBL_Emanetler e " +
                    "WHERE e.uye_id = u.id and e.kitap_id = k.id and u.ad LIKE '" + aranacak + "'";
                }
                else if(aranacak == "")
                {
                    a = "Teslim Edilmedi";
                    sql  = "SELECT e.id,u.ad,u.soyad,k.kitap_adi,e.alim_tarihi,e.teslim_tarihi FROM TBL_Uyeler u,TBL_Kitaplar k,TBL_Emanetler e " +
                    "WHERE e.uye_id = u.id and e.kitap_id = k.id and e.teslim_durumu = '"+a+"' ";
                }
                d.myConnection.Open();
                SQLiteCommand select_emanatler = new SQLiteCommand(sql, d.myConnection);
                SQLiteDataAdapter da = new SQLiteDataAdapter(select_emanatler);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmanetler.DataSource = dt;
                dgvEmanetler.Columns["id"].Visible = false;
                dgvEmanetler.Columns["ad"].HeaderText = "Ad";
                dgvEmanetler.Columns["soyad"].HeaderText = "Soyad";
                dgvEmanetler.Columns["kitap_adi"].HeaderText = "Kitap Adı";
                dgvEmanetler.Columns["kitap_adi"].Width = 150;
                dgvEmanetler.Columns["alim_tarihi"].HeaderText = "Alım Tarihi";
                dgvEmanetler.Columns["teslim_tarihi"].HeaderText = "Teslim Tarihi";
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
        private void txtAranan_KeyUp(object sender, KeyEventArgs e)
        {
            string aranacak = "";
            if(txtAranan.Text != "")
            {
                aranacak = "%"+txtAranan.Text+"%";
            }
            doldur(aranacak);
        }

        private void btnEmanetEkle_Click(object sender, EventArgs e)
        {
            FrmEmanetEkle frm = new FrmEmanetEkle();
            frm.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if(dgvEmanetler.CurrentRow != null)
            {
                string id = dgvEmanetler.CurrentRow.Cells["id"].Value.ToString();
                FrmEmanetDuzenle frm = new FrmEmanetDuzenle(id);
                frm.ShowDialog();
            }
            else if(dgvEmanetler.Rows.Count == 0)
            {
                DialogResult rs = MessageBox.Show("Kayıt bulunmadıgı için eklemek ister misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
                if(rs == DialogResult.Yes)
                {
                    FrmEmanetEkle frm = new FrmEmanetEkle();
                    frm.ShowDialog();
                }
            }
            
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            if(dgvEmanetler.CurrentRow != null)
            {
                string id = dgvEmanetler.CurrentRow.Cells["id"].Value.ToString();
                FrmTeslimKontrol frm = new FrmTeslimKontrol(id);
                frm.ShowDialog();
            }
           
        }
    }
    
}
