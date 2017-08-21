using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTrackingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSaat.Text = DateTime.Now.ToLongTimeString();
            labelTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            string id = null;
            string parametre = "0";
            FrmAddUser frm = new FrmAddUser(parametre,id);
            frm.ShowDialog();
        }

        private void btnUyeGoruntule_Click(object sender, EventArgs e)
        {
            FrmUyeGoruntule frm = new FrmUyeGoruntule();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = null;
            string parametre = "0"; // Ekleme işlemi için gönderilen parametre
            FrmKitapEkleDuzenle frm = new FrmKitapEkleDuzenle(parametre, id);
            frm.ShowDialog();
        }

        private void btnKitapGoruntule_Click(object sender, EventArgs e)
        {
            FrmKitapGoruntule frm = new FrmKitapGoruntule();
            frm.ShowDialog();
        }

        private void btnEmanetKitapIslemleri_Click(object sender, EventArgs e)
        {
            FrmEmanetler frm = new FrmEmanetler();
            frm.ShowDialog();
        }
    }
}
