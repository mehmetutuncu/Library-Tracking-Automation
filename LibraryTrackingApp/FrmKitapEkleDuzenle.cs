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
    public partial class FrmKitapEkleDuzenle : Form
    {
        string id, parametre,ad,yazar,sayfa_sayisi,yayim_evi,kitap_turu,stok_sayisi,temin_tarihi;
        db d = new db();
        private void txtKitapTuru_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtKitapYazari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtStokSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSayfaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void FrmKitapEkleDuzenle_Load(object sender, EventArgs e)
        {
            
            if(parametre == "0" || parametre == "1")
            {
                btnKaydetDuzenle.Text = "Kaydet";
            }
            else if(parametre == "2")
            {
                btnKaydetDuzenle.Text = "Güncelle";
                doldur();
            }
        }
        
        public void doldur()
        {
            try
            {
                
                d.myConnection.Open();
                String sql = "SELECT * FROM TBL_Kitaplar WHERE id = @id";
                SQLiteCommand select_kitaplar = new SQLiteCommand(sql, d.myConnection);
                select_kitaplar.Parameters.AddWithValue("@id", id);
                SQLiteDataReader dr = select_kitaplar.ExecuteReader();
                while (dr.Read())
                {
                    txtKitapAdi.Text = dr["kitap_adi"].ToString();
                    txtKitapYazari.Text = dr["yazar"].ToString();
                    txtSayfaSayisi.Text = dr["sayfa_sayisi"].ToString();
                    txtYayimEvi.Text = dr["yayim_evi"].ToString();
                    txtKitapTuru.Text = dr["kitap_turu"].ToString();
                    txtStokSayisi.Text = dr["stok_adedi"].ToString();
                    temin_tarihi = dr["temin_tarihi"].ToString();
                }
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
        
        

        private void btnKaydetDuzenle_Click(object sender, EventArgs e)
        {
            if(parametre == "0" || parametre == "1")
            {
                if(txtKitapAdi.Text == "")
                {
                    MessageBox.Show("Kitap adı kısmı boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if(txtKitapTuru.Text == "")
                {
                    MessageBox.Show("Kitap türü kısmı boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if(txtKitapYazari.Text == "")
                {
                    MessageBox.Show("Kitap yazarı kısmı boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if(txtSayfaSayisi.Text == "")
                {
                    MessageBox.Show("Sayfa sayısı kısmı boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if(txtStokSayisi.Text == "")
                {
                    MessageBox.Show("Stok sayısı kısmı boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if(txtYayimEvi.Text == "")
                {
                    MessageBox.Show("Yayım evi kısmı boş bırakılamaz lütfen kontrol ediniz.");
                }
                else
                {
                    ad = txtKitapAdi.Text;
                    yazar = txtKitapYazari.Text;
                    sayfa_sayisi = txtSayfaSayisi.Text;
                    yayim_evi = txtYayimEvi.Text;
                    kitap_turu = txtKitapTuru.Text;
                    stok_sayisi = txtStokSayisi.Text;
                    temin_tarihi = DateTime.Today.ToShortDateString();
                    try
                    {
                        d.myConnection.Open();
                        string sql = "INSERT INTO TBL_Kitaplar(kitap_adi,yazar,sayfa_sayisi,yayim_evi,kitap_turu,stok_adedi,temin_tarihi)" +
                            "VALUES(@ad,@yazar,@sayfa_sayisi,@yayim_evi,@kitap_turu,@stok_sayisi,@temin_tarihi)";
                        SQLiteCommand insert_kitaplar = new SQLiteCommand(sql, d.myConnection);
                        insert_kitaplar.Parameters.AddWithValue("@ad",ad);
                        insert_kitaplar.Parameters.AddWithValue("@yazar",yazar);
                        insert_kitaplar.Parameters.AddWithValue("@sayfa_sayisi",sayfa_sayisi);
                        insert_kitaplar.Parameters.AddWithValue("@yayim_evi",yayim_evi);
                        insert_kitaplar.Parameters.AddWithValue("@kitap_turu",kitap_turu);
                        insert_kitaplar.Parameters.AddWithValue("@stok_sayisi",stok_sayisi);
                        insert_kitaplar.Parameters.AddWithValue("@temin_tarihi",temin_tarihi);
                        insert_kitaplar.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarılı.");
                        if(parametre == "1")
                        {
                            FrmKitapGoruntule frm = (FrmKitapGoruntule)Application.OpenForms["FrmKitapGoruntule"];
                            string aranan = "";
                            frm.doldur(aranan);
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
            else if (parametre == "2")
            {
                //düzenleme işlemi için kullanılacak
                if (txtKitapAdi.Text == "")
                {
                    MessageBox.Show("Kitap adı kısmı boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtKitapTuru.Text == "")
                {
                    MessageBox.Show("Kitap türü kısmı boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtKitapYazari.Text == "")
                {
                    MessageBox.Show("Kitap yazarı kısmı boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtSayfaSayisi.Text == "")
                {
                    MessageBox.Show("Sayfa sayısı kısmı boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtStokSayisi.Text == "")
                {
                    MessageBox.Show("Stok sayısı kısmı boş bırakılamaz lütfen kontrol ediniz.");
                }
                else if (txtYayimEvi.Text == "")
                {
                    MessageBox.Show("Yayım evi kısmı boş bırakılamaz lütfen kontrol ediniz.");
                }
                else
                {
                    ad = txtKitapAdi.Text;
                    yazar = txtKitapYazari.Text;
                    sayfa_sayisi = txtSayfaSayisi.Text;
                    yayim_evi = txtYayimEvi.Text;
                    kitap_turu = txtKitapTuru.Text;
                    stok_sayisi = txtStokSayisi.Text;
                    try
                    {
                        d.myConnection.Open();
                        string sql = "UPDATE TBL_Kitaplar SET " +
                            "kitap_adi=@ad,yazar = @yazar,sayfa_sayisi = @sayfa_sayisi,yayim_evi = @yayim_evi," +
                            "kitap_turu = @kitap_turu,stok_adedi = @stok_sayisi,temin_tarihi = @temin_tarihi WHERE id = @id";
                        SQLiteCommand update_kitaplar = new SQLiteCommand(sql, d.myConnection);
                        update_kitaplar.Parameters.AddWithValue("@ad",ad);
                        update_kitaplar.Parameters.AddWithValue("@yazar",yazar);
                        update_kitaplar.Parameters.AddWithValue("@sayfa_sayisi",sayfa_sayisi);
                        update_kitaplar.Parameters.AddWithValue("@yayim_evi",yayim_evi);
                        update_kitaplar.Parameters.AddWithValue("@kitap_turu",kitap_turu);
                        update_kitaplar.Parameters.AddWithValue("@stok_sayisi",stok_sayisi);
                        update_kitaplar.Parameters.AddWithValue("@temin_tarihi",temin_tarihi);
                        update_kitaplar.Parameters.AddWithValue("@id",id);
                        update_kitaplar.ExecuteNonQuery();
                        FrmKitapGoruntule frm = (FrmKitapGoruntule)Application.OpenForms["FrmKitapGoruntule"];
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

        
        
        public FrmKitapEkleDuzenle(string gelen_parametre , string gelen_id)
        {
            InitializeComponent();
            parametre = gelen_parametre;
            id = gelen_id;
        }
    }
}
