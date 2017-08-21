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
    public partial class FrmUyeGoruntule : Form
    {
        db d = new db();
        
        public FrmUyeGoruntule()
        {
            InitializeComponent();
            
            
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            string id = null;
            string parametre = "1";
            FrmAddUser frm = new FrmAddUser(parametre,id);
            frm.ShowDialog();
        }
        public void doldur(string a)
        {
            string aranan = a;
            try
            {
                string sql;
                if (aranan != "")
                {
                    sql = "SELECT * FROM TBL_Uyeler where ad LIKE '"+aranan+"'";
                }
                else
                {
                    sql = "SELECT * FROM TBL_Uyeler";
                }
                d.myConnection.Open();
                
                SQLiteCommand select_uyeler = new SQLiteCommand(sql, d.myConnection);
                SQLiteDataAdapter da = new SQLiteDataAdapter(select_uyeler);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["ihlal"].Visible = false;
                dataGridView1.Columns["ad"].HeaderText = "Ad";
                dataGridView1.Columns["soyad"].HeaderText = "Soyad";
                dataGridView1.Columns["eposta"].HeaderText = "E-Posta";
                dataGridView1.Columns["tckno"].HeaderText = "TC No";
                dataGridView1.Columns["adres"].HeaderText = "Adres";
                dataGridView1.Columns["dogum_tarihi"].HeaderText = "Doğum Tarihi";
                dataGridView1.Columns["uyelik_tarihi"].HeaderText = "Kayıt Tarihi";
                dataGridView1.Columns["telefon"].HeaderText = "Cep No";
                dataGridView1.Columns["eposta"].Width = 200;
                dataGridView1.Columns["tckno"].Width = 80;
                dataGridView1.Columns["adres"].Width = 465;
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

        private void FrmUyeGoruntule_Load(object sender, EventArgs e)
        {
            string deger = "";
            doldur(deger);
            if (dataGridView1.Rows.Count == 0)
            {
                DialogResult result = MessageBox.Show("Kayıt bulunmuyor eklemek istiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string id = null;
                    string parametre = "1";
                    FrmAddUser frm = new FrmAddUser(parametre,id);
                    frm.ShowDialog();
                }
                else if(result == DialogResult.No)
                {
                    this.Close();
                }
                
            }
            doldur(deger);
            
        }

        private void btnUyeDuzenle_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seçili satır bulunmuyor.");

            }
            if(dataGridView1.Rows.Count == 0)
            {
                string id = null;
                string parametre = "2";
                FrmAddUser frm = new FrmAddUser(parametre, id);
                frm.ShowDialog();
            }
            else
            {
                string id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                string parametre = "2";
                FrmAddUser frm = new FrmAddUser(parametre, id);
                frm.ShowDialog();
            }
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {

                DialogResult result = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {

                    if(dataGridView1.CurrentRow != null)
                    {
                        string id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                        try
                        {
                            d.myConnection.Open();
                            SQLiteCommand delete = new SQLiteCommand("DELETE FROM TBL_Uyeler where id = '" + id + "'", d.myConnection);
                            delete.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            d.myConnection.Close();
                            string deger = "";
                            doldur(deger);
                        }
                    }
                    if(dataGridView1.Rows.Count == 0)
                    {
                        string id = null;
                        string parametre = "1";
                        FrmAddUser frm = new FrmAddUser(parametre, id);
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz.");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Kayıt bulunmadığı için silme isteğinizi gerçekleştiremiyoruz.");
            }
        }

        

        private void txtArama_KeyUp(object sender, KeyEventArgs e)
        {
            string aranacak = "";
            if (txtArama.Text != "")
            {
                aranacak = "%" + txtArama.Text + "%";
            }
            doldur(aranacak);
        }
    }
}
