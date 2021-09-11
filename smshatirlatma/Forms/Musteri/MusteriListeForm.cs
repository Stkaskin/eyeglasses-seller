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
    public partial class MusteriListeForm : DevExpress.XtraEditors.XtraForm
    {
        kayit kayit = new kayit();
        Gozluk gozluk = new Gozluk();
        List<kayit> kayitlar = new List<kayit>();
        List<Gozluk> gozlukler = new List<Gozluk>();
        bool datas = false;
        public int islem;
        public int id;

        public MusteriListeForm()
        {
            InitializeComponent();
        }

        private void MusteriListeForm_Load(object sender, EventArgs e)
        {
            checkedComboBoxEdit1.SelectedIndex = 0;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.ActiveGlowColor = Color.Lime; this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormShadow.Opacity = 120;
            OptikDbEntities db = new OptikDbEntities();
            kayitlar = db.kayit.ToList();
            gozlukler = db.Gozluk.ToList();
            if (islem == 1) { dateTimeOffsetEdit1.DateTimeOffset = DateTime.Now; simpleButton7.Text = "Satış Yap"; }
            else if (islem == 2 || islem == 3)
            {
                satis satis = new satis();
                satis = db.satis.Find(id);
                textEdit1.Text = satis.kayit.ad;
                textEdit2.Text = satis.Gozluk.kod;
                gozluk= satis.Gozluk;
                dateTimeOffsetEdit1.EditValue = satis.zaman;
              
                   Borc borcs= db.Borc.Where(x => x.satisid == satis.id).FirstOrDefault();
                    if (borcs == null) { checkedComboBoxEdit1.SelectedIndex = 0; }
                    else { checkedComboBoxEdit1.SelectedIndex = 1; }


                simpleButton7.Text = "Satış Düzenle";
                textEdit4.Text = satis.tutar.ToString();
                textEdit1.Enabled = false;
                simpleButton1.Enabled = false;
                if (islem == 3)
                {
                    simpleButton7.Text = "Satış Sil";
                    textEdit2.Enabled = textEdit4.Enabled = dateTimeOffsetEdit1.Enabled = checkedComboBoxEdit1.Enabled = false;
                }
            }



        }
        private void veriMusteri()
        {
            OptikDbEntities db = new OptikDbEntities();
            var List = from a in db.kayit
                       where a.aktif == true
                       where a.aktif == true
                       select new
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


            gridControl1.DataSource = List.ToList();
        }
        private void veriGozluk()
        {
            OptikDbEntities db = new OptikDbEntities();
            var List = from a in db.Gozluk
                       join b in db.CamTipleri on a.camid equals b.id
                       join s in db.SekilTipi on a.sekilid equals s.id
                       join m in db.Marka on a.markaid equals m.id
                       where a.aktif == true
                       select new
                       {
                           İD = a.id,
                           Adı = a.kod,
                           Adet = a.adet,
                           Gönderim = a.gonderim == true ? "Mevcut" : "BİTTİ",
                           Cam = b.ad,
                           Şekil = s.ad,
                           Marka = m.ad

                       };
            gridControl1.DataSource = List.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.GroupPanelText = "Müşteriler";
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();

            panelControl1.Visible = true;

            veriMusteri();
            datas = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridView1.GroupPanelText = "Gözlükler";
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
            panelControl1.Visible = true;

            veriGozluk();
            datas = true;
        }

        private void Tarih_Click(object sender, EventArgs e)
        {
            dateTimeOffsetEdit1.ShowToolTips = true; ;
        }

        private void dateTimeOffsetEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
                if (datas)
                {
                    foreach (var item in gozlukler)
                    {
                        if (item.id == id) { gozluk = item; textEdit2.Text = gozluk.kod.ToString(); break; }
                    }

                }
                else
                {
                    foreach (var item in kayitlar)
                    {
                        if (item.id == id) { kayit = item; textEdit1.Text = kayit.ad + " " + kayit.soyad; break; }

                    }


                }


                panelControl1.Visible = false;
            }




        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            panelControl1.Visible = false;
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text != "" && textEdit2.Text != "" && checkedComboBoxEdit1.SelectedIndex > -1 && textEdit4.Text != "" && textEdit4.Text != "")
            {
                OptikDbEntities db = new OptikDbEntities(); 
                satis satis = new satis();
                if (islem == 1)
                {

                    satis.Gozlukid = gozluk.id;
                    satis.Kayitid = kayit.id;
                    satis.zaman = dateTimeOffsetEdit1.DateTimeOffset.DateTime;
                    int sayi = Convert.ToInt32(textEdit4.EditValue);
                    satis.tutar = sayi;

                    LogKayit log = new LogKayit();

                    db.satis.Add(satis);
                    db.SaveChanges();
                    kayit.alim = dateTimeOffsetEdit1.DateTimeOffset.DateTime;
                    kayit.sonrakialim = kayit.alim.Value.AddYears(3);
                    if (checkedComboBoxEdit1.SelectedIndex == 1)
                    {
                        Borc borc = new Borc();
                        borc.satisid = satis.id;
                        borc.kayitid = satis.Kayitid;
                        borc.islemturu = 1;
                        borc.alacakzaman = satis.zaman.Value.AddMonths(2);
                        borc.zaman = satis.zaman;
                        borc.tutar = satis.tutar;
                        db.Borc.Add(borc);
                        db.SaveChanges();
                        log.LogAdd("Borc", 1, borc.id);
                    }
                    log.LogAdd("Satis", 1, satis.id);
                    log.LogAdd("Kayit", 2, kayit.id);


                }
                else if (islem == 2)
                {
                    LogKayit log = new LogKayit();
                    satis = db.satis.Find(id);
                    satis.Gozlukid = gozluk.id;
                 //   satis.Kayitid = kayit.id;
                    satis.zaman = dateTimeOffsetEdit1.DateTimeOffset.DateTime;
                    int sayi = Convert.ToInt32(textEdit4.EditValue);
                    satis.tutar = sayi;

                    //  kayit kayid = new kayit();
                   
                  kayit=db.kayit.Where(x=>x.id==satis.Kayitid).FirstOrDefault();
                    kayit.alim = satis.zaman;
                    kayit.sonrakialim = kayit.alim.Value.AddYears(3);
                   // db.satis.Add(satis);
                    db.SaveChanges();
                 
                    log.LogAdd("Satis", 2, satis.id);
                    log.LogAdd("Kayit", 2, kayit.id);
                    if (checkedComboBoxEdit1.SelectedIndex == 1)
                    {
                        Borc borc = db.Borc.Where(x => x.satisid == satis.id).FirstOrDefault();
                        if (borc==null)
                        {
                             borc = new Borc();
                            borc.satisid = satis.id;
                            borc.kayitid = satis.Kayitid;
                            borc.islemturu = 1;
                            borc.alacakzaman = satis.zaman.Value.AddMonths(2);
                            borc.zaman = satis.zaman;
                            borc.tutar = satis.tutar;
                            db.Borc.Add(borc);
                            db.SaveChanges();
                            log.LogAdd("Borc", 1, borc.id);

                        }
                        else
                        {

                        //    borc.alacakzaman = satis.zaman.Value.AddMonths(2);
                            borc.zaman = satis.zaman;
                            borc.tutar = satis.tutar;
                            log.LogAdd("Borc", 2, borc.id);


                        }
                        db.SaveChanges();



                    }
                    else
                    {
                        Borc borc = db.Borc.Where(x => x.satisid == satis.id).FirstOrDefault();
                        if (borc != null) {
                            log.LogAdd("Borc", 20, borc.id);
                            db.Borc.Remove(borc);
                           
                            db.SaveChanges();
                        }

                    }
                    XtraMessageBox.Show("Düzenlendi");
                }
                else if (islem == 3)
                {
                    LogKayit log = new LogKayit();
                    Borc borc = new Borc();
                    borc = db.Borc.Where(x => x.satisid == id).FirstOrDefault();
                    satis = db.satis.Find(id);
                    if (borc != null) {    db.Borc.Remove(borc);
                        log.LogAdd("Borc", 20, borc.id);
                        db.SaveChanges(); }
                
                    db.satis.Remove(satis);
                    db.SaveChanges();
                    XtraMessageBox.Show("SİLİNDİ");
                  
                  
                    log.LogAdd("Satis", 20, satis.id);
                }

                this.Close();
            }
        }
    }
}