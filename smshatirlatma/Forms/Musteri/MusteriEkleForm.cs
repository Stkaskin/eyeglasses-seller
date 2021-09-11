using DevExpress.XtraEditors;
using smshatirlatma.Manager;
using smshatirlatma.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smshatirlatma.Forms.Musteri
{
    public partial class MusteriEkleForm : DevExpress.XtraEditors.XtraForm
    {
        OptikDbEntities db = new OptikDbEntities();
        public MusteriEkleForm()
        {
            InitializeComponent();
        }
        private (string ad, string soyad) soyadbul(string gelentext)
        {
            int uzunluk = gelentext.Length;
            string[] spl = gelentext.Split(' ');
            string soyad = spl[spl.Count() - 1];
            string ad = gelentext.Substring(0, uzunluk - soyad.Length);

            if (spl.Count() == 1) { ad = soyad; soyad = null; }
            return (ad, soyad);

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text != "" && textEdit1.Text != "" && textEdit1.Text != "") { 
            kayit kayit = new kayit();
            kayit.ad = soyadbul(textEdit1.Text).ad;
            kayit.soyad = soyadbul(textEdit1.Text).soyad;
            kayit.alim = DateTime.Now;
            kayit.sonrakialim = DateTime.Now;
            kayit.telefon = textEdit2.OldEditValue.ToString();
            kayit.smsdurum = "";
            kayit.smsgonderim =0;
                kayit.aktif = true;
                db.kayit.Add(kayit);
            db.SaveChanges();
                LogKayit log = new LogKayit();
                log.LogAdd("Kayit",1, kayit.id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Boş Olan Metinleri Doldurun Lütfen");
            }
        }
      
    }
}