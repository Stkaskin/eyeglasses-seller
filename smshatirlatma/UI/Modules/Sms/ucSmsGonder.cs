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



namespace smshatirlatma.UI.Modules.Sms
{
    public partial class ucSmsGonder : DevExpress.DXperience.Demos.TutorialControlBase  //DevExpress.XtraEditors.XtraUserControl
    {
        List<liste> MusteriSmsGonderilecekler = new List<liste>();
        List<liste> MusteriListesi = new List<liste>();
    

        public ucSmsGonder()
        {
            InitializeComponent();
        }

        private void ucSmsGonder_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.SelectedIndex = 0;
                veri();
            
            Yenile();
 
        }
        public class liste
        {
            public int İD { get; set; }
            public string Ad { get; set; }
            public string Telefon { get; set; }
            public DateTime? AlimTarihi { get; set; }
            public DateTime? SonrakiAlımTarihi { get; set; }
            public string Sms { get; set; }
            public string SmsDurum { get; set; }
            public string Hak { get; set; }
     
        }
        private void veri()
        {
            OptikDbEntities db = new OptikDbEntities();
            var List = from a in db.kayit where a.aktif==true
                       select  new liste
                       {
                           İD = a.id,
                           Ad = a.ad + " " + a.soyad,
                           Telefon = a.telefon,
                           AlimTarihi = a.alim,
                           SonrakiAlımTarihi = a.sonrakialim,
                           Hak = a.hak,
                           Sms = a.smsgonderim == 0 ? "Hak Yok" : a.smsgonderim == 1 ? "Sırada" : "Gönderildi",
                           SmsDurum = a.smsdurum
                       };

            MusteriListesi = List.ToList();

           // gridControl1.DataSource = List.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "İD").ToString());
            foreach (var item in MusteriListesi)
            {
                if (item.İD == id)
                {
                    MusteriSmsGonderilecekler.Add(item);
                    MusteriListesi.Remove(item);
                    Yenile();
                    break;

                }

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            foreach (var item in MusteriSmsGonderilecekler)
            {
                MusteriListesi.Add(item);
            }
            MusteriSmsGonderilecekler.Clear();
            Yenile();


        }
        private void Yenile()
        {
            gridControl1.DataSource = null;
            gridControl2.DataSource = null;
            gridControl1.DataSource = MusteriSmsGonderilecekler;
            gridControl2.DataSource = MusteriListesi;
            if (MusteriSmsGonderilecekler.Count > 0 && !SmsCikar.Enabled)
            {
                SmsCikar.Enabled = SmsTopluCikar.Enabled = true;

            }
            else if (MusteriSmsGonderilecekler.Count <= 0)
            {
                SmsCikar.Enabled = SmsTopluCikar.Enabled = false;
            }

            if (MusteriListesi.Count > 0 && !SmsEkle.Enabled)
            {
                SmsEkle.Enabled = SmsTopluEkle.Enabled = true;

            }
            else if (MusteriListesi.Count <= 0)
            {
                SmsEkle.Enabled = SmsTopluEkle.Enabled = false;
            }
        }

        private void SmsCikar_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
                foreach (var item in MusteriSmsGonderilecekler)
            {
                if (item.İD == id)
                {
                    MusteriListesi.Add(item);
                    MusteriSmsGonderilecekler.Remove(item);
                    Yenile();
                    break;

                }
                }
            }

        }

        private void SmsTopluEkle_Click(object sender, EventArgs e)
        {
            foreach (var item in MusteriListesi)
            {
                MusteriSmsGonderilecekler.Add(item);
            }
            MusteriListesi.Clear();
            Yenile();
        }
        bool onay= false;
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (!onay)
            {     if (gridView1.RowCount > 0) { 
                    
                    if (memoEdit1.Text!="") { 
                onay = true;
                panelControl1.Visible = false;
                simpleButton1.Text = "Gönder";
                simpleButton2.Visible = true;
                    }
                    else { XtraMessageBox.Show("Mesaj Metni Boş olamaz.!."); }
                }
            else { XtraMessageBox.Show("Mesaj Gönderilecek Kişi Listesi Boş"); }

            }
            else
            {
                
                List<Model.Sms> smsler = new List<Model.Sms>();
                OptikDbEntities db = new OptikDbEntities();
                foreach (var item in MusteriSmsGonderilecekler)
                {
                    Model.Sms sms = new Model.Sms();
                    sms.mesajmetni = memoEdit1.Text;
                    sms.kisiadı = item.Ad;
                    sms.kisitel = item.Telefon;
                    sms.özel = comboBoxEdit1.SelectedIndex == 0 ? false : true;
                    sms.zaman = DateTime.Now;

                    smsler.Add(sms);
                    //Model.SmsTurMesajları mesajtur = new Model.SmsTurMesajları();
                    //  mesajtur.Discriminator = "";
                    // mesajtur.kisiid = item.İD;
                    // mesajtur.mesaj = memoEdit1.Text;
                    LogKayit log = new LogKayit();
                    log.LogAdd("SMS", 5, item.İD);
                }
                db.Sms.AddRange(smsler);
                
                db.SaveChanges();
             

               onay = false;
                panelControl1.Visible = true;
                simpleButton1.Text = "Onay Ver";
                simpleButton2.Visible = false;
                MessageBox.Show("Mesajlar Gönderildi");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            onay = false;
            panelControl1.Visible = true;
            simpleButton1.Text = "Onay Ver";
            simpleButton2.Visible = false;
        }

        private void ucSmsGonder_VisibleChanged(object sender, EventArgs e)
        {
            veri();
        }
    }
}
