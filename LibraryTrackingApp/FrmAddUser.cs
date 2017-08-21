using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Data.SQLite;
namespace LibraryTrackingApp
{
    public partial class FrmAddUser : Form
    {
        db d = new db();
        string gelen;
        string uyelik_tarihi;
        string id;
        string kayit_tarihi = DateTime.Today.ToShortDateString();
        public FrmAddUser(string parametre,string gelen_id)
        {
            InitializeComponent();
            gelen = parametre;
            id = gelen_id;
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if(gelen == "0" || gelen == "1")
            {
                if (txtAd.Text == "")
                {
                    MessageBox.Show("Ad boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtSoyad.Text == "")
                {
                    MessageBox.Show("Soyad boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtTcNo.Text == "" || txtTcNo.TextLength < 11)
                {
                    MessageBox.Show("TC kimlik numarası 11 rakamı sağlamalı ve boş olmamalı lütfen kontrol ediniz.");
                }
                else if (txtEposta.Text == "")
                {
                    MessageBox.Show("E-Posta boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtDogumTarihi.Text.Length < 10 )
                {
                    MessageBox.Show("Doğum tarihi boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtCep.Text.Length < 14)
                {
                    MessageBox.Show("Cep Telefonu boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtAdres.Text == "")
                {
                    MessageBox.Show("Adres boş bırakılamaz lütfen kontrol ediniz.");
                }
                else 
                {
                    try
                    {
                        string ad = txtAd.Text;
                        string soyad = txtSoyad.Text;
                        string tcno = txtTcNo.Text;
                        string eposta = txtEposta.Text;
                        string dogumtarihi = txtDogumTarihi.Text;
                        string cepno = txtCep.Text;
                        string adres = txtAdres.Text;
                        
                        
                        d.myConnection.Open();

                        string sql = "insert into TBL_Uyeler(ad,soyad,eposta,tckno,adres,dogum_tarihi,uyelik_tarihi,telefon)" +
                            " values(@ad,@soyad,@eposta,@tckno,@adres,@dgt,@uyt,@tel)";
                        SQLiteCommand user_insert = new SQLiteCommand(sql, d.myConnection);
                        user_insert.Parameters.AddWithValue("@ad", ad);
                        user_insert.Parameters.AddWithValue("@soyad", soyad);
                        user_insert.Parameters.AddWithValue("@eposta", eposta);
                        user_insert.Parameters.AddWithValue("@tckno", tcno);
                        user_insert.Parameters.AddWithValue("@adres", adres);
                        user_insert.Parameters.AddWithValue("@dgt", dogumtarihi);
                        user_insert.Parameters.AddWithValue("@uyt", kayit_tarihi);
                        user_insert.Parameters.AddWithValue("@tel", cepno);
                        user_insert.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarılı.");
                        if (gelen == "1")
                        {
                            string deger = "";
                            FrmUyeGoruntule frm = (FrmUyeGoruntule)Application.OpenForms["FrmUyeGoruntule"];
                            frm.doldur(deger);
                            frm.Refresh();
                        }
                    }
                    catch (Exception ex)
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
            else if(gelen == "2")
            {
                MessageBox.Show("Sıkıntı yok");
                if (txtAd.Text == "")
                {
                    MessageBox.Show("Ad boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtSoyad.Text == "")
                {
                    MessageBox.Show("Soyad boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtTcNo.Text == "" || txtTcNo.TextLength < 11)
                {
                    MessageBox.Show("TC kimlik numarası 11 rakamı sağlamalı ve boş olmamalı lütfen kontrol ediniz.");
                }
                else if (txtEposta.Text == "")
                {
                    MessageBox.Show("E-Posta boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtDogumTarihi.Text == "")
                {
                    MessageBox.Show("Doğum tarihi boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtCep.Text == "")
                {
                    MessageBox.Show("Cep Telefonu boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtAdres.Text == "")
                {
                    MessageBox.Show("Adres boş bırakılamaz lütfen kontrol ediniz.");
                }
                else
                {
                    try
                    {
                        d.myConnection.Open();
                        
                        string update_sql = "UPDATE TBL_Uyeler SET " +
                            "ad = @ad , soyad = @soyad ,eposta = @eposta ,tckno = @tckno,adres=@adres,dogum_tarihi = @dogum_tarihi,uyelik_tarihi=@uyelik_tarihi,telefon = @telefon WHERE id = '"+id+"'";
                        SQLiteCommand update_uyeler = new SQLiteCommand(update_sql, d.myConnection);
                        update_uyeler.Parameters.AddWithValue("@ad", txtAd.Text);
                        update_uyeler.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                        update_uyeler.Parameters.AddWithValue("@eposta", txtEposta.Text);
                        update_uyeler.Parameters.AddWithValue("@tckno", txtTcNo.Text);
                        update_uyeler.Parameters.AddWithValue("@adres", txtAdres.Text);
                        update_uyeler.Parameters.AddWithValue("@dogum_tarihi", txtDogumTarihi.Text);
                        update_uyeler.Parameters.AddWithValue("@uyelik_tarihi",kayit_tarihi);
                        update_uyeler.Parameters.AddWithValue("@telefon", txtCep.Text);
                        update_uyeler.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarılı.");
                        if (gelen == "2")
                        {
                            string deger = "";
                            FrmUyeGoruntule frm = (FrmUyeGoruntule)Application.OpenForms["FrmUyeGoruntule"];
                            frm.doldur(deger);
                            frm.Refresh();
                        }

                    }
                    catch (Exception ex)
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

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Sadece numeric izin verir.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
        public void doldur()
        {
            if(id != null)
            {
                try
                {
                    d.myConnection.Open();
                    string select_sql = "select * from TBL_Uyeler where id = '" + id + "'";
                    SQLiteCommand select_uyeler = new SQLiteCommand(select_sql, d.myConnection);
                    SQLiteDataReader dr = select_uyeler.ExecuteReader();
                    while (dr.Read())
                    {
                        txtAd.Text = dr["ad"].ToString();
                        txtSoyad.Text = dr["soyad"].ToString();
                        txtTcNo.Text = dr["tckno"].ToString();
                        txtEposta.Text = dr["eposta"].ToString();
                        txtDogumTarihi.Text = dr["dogum_tarihi"].ToString();
                        txtCep.Text = dr["telefon"].ToString();
                        txtAdres.Text = dr["adres"].ToString();
                        uyelik_tarihi = dr["uyelik_tarihi"].ToString();
                    }
                    dr.Close();
                    
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
        }
        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            if(gelen == "2")
            {
                btnKaydet.Text = "Güncelle";
                doldur();
            }
        }
    }
}
