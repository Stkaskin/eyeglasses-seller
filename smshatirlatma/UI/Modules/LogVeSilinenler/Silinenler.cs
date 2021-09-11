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

namespace smshatirlatma.UI.Modules.LogVeSilinenler
{
    public partial class Silinenler : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public Silinenler()
        {
            InitializeComponent();
        }




        OptikDbEntities db = new OptikDbEntities();

        int islem = 0;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            veri1(); control(); gridView1.GroupPanelText = "Silinen Müşteri Listesi";
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            veri2(); control(); gridView1.GroupPanelText = "Silinen Gözlük Listesi";
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            veri3(); control();
            gridView1.GroupPanelText = "Silinen Marka Listesi";
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            veri4(); control();
            gridView1.GroupPanelText = "Silinen Şekil Listesi";
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            veri5();
            control();
            gridView1.GroupPanelText = "Silinen Cam Listesi";
        }
        void control()
        {
            if (islem==1)
            {
                ribbonPageGroup2.Alignment = (DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment)Alignment.Default;
            }
            else { ribbonPageGroup2.Alignment = (DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment)Alignment.Center; }
             if (islem == 2) { ribbonPageGroup1.Alignment = (DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment)Alignment.Default; }
            else { ribbonPageGroup1.Alignment = (DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment)Alignment.Center; }
            if (islem == 3) { ribbonPageGroup5.Alignment = (DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment)Alignment.Default; }
            else { ribbonPageGroup5.Alignment = (DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment)Alignment.Center; }
            if (islem == 4) { ribbonPageGroup6.Alignment = (DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment)Alignment.Default; }
            else { ribbonPageGroup6.Alignment = (DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment)Alignment.Center; }
            if (islem == 5) { ribbonPageGroup7.Alignment = (DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment)Alignment.Default; }
            else { ribbonPageGroup7.Alignment = (DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment)Alignment.Center; }


        }
        void veri1()
        {
            islem = 1;
            gridView1.Columns.Clear();
            var list = from a in db.kayit

                       where a.aktif == false
                       select new
                       {
                           İD = a.id,
                           Ad = a.ad + " " + a.soyad,
                           Telefon = a.telefon,

                       };
            gridControl1.DataSource = list.ToList();
        }
        void veri2()
        {
            islem = 2;
            gridView1.Columns.Clear();
            var list = from a in db.Gozluk
                       join b in db.CamTipleri on a.camid equals b.id
                       join s in db.SekilTipi on a.sekilid equals s.id
                       join m in db.Marka on a.markaid equals m.id
                       where a.aktif == false
                       select new
                       {
                           İD = a.id,
                           Adı = a.kod,
                           //    Adet = a.adet,
                           //    Gönderim = a.gonderim == true ? "Mevcut" : "BİTTİ",
                           Cam = b.ad,
                           Şekil = s.ad,
                           Marka = m.ad

                       };

            gridControl1.DataSource = list.ToList();
        }
        void veri3()
        {
            islem = 3;
            gridView1.Columns.Clear();
            var list = from a in db.Marka

                       where a.aktif == false
                       select new
                       {
                           İD = a.id,
                           Ad = a.ad,
                           Kod = a.Markakodu,

                       };
            gridControl1.DataSource = list.ToList();
        }
        void veri4()
        {
            islem = 4;
            gridView1.Columns.Clear();
            var list = from a in db.SekilTipi

                       where a.aktif == false
                       select new
                       {
                           İD = a.id,
                           Ad = a.ad,


                       };
            gridControl1.DataSource = list.ToList();
        }
        void veri5()
        {
            islem = 5;
            gridView1.Columns.Clear();
            var list = from a in db.CamTipleri

                       where a.aktif == false
                       select new
                       {
                           İD = a.id,
                           Ad = a.ad,
                           Kod = a.CamKodu,

                       };
            gridControl1.DataSource = list.ToList();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                LogKayit log = new LogKayit();
              
                var result = XtraMessageBox.Show("Geri Yüklemek İstiyor Musunuz?", "Geri Yükleme Onayı", MessageBoxButtons.YesNo);
                int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
                if (result == DialogResult.Yes)
                {
                    db = new OptikDbEntities();
                    string mesaj = "";
                    if (islem == 1)
                    {
                        kayit item = db.kayit.Find(id);
                        item.aktif = true;
                        mesaj = "Kayıt " + item.id;
                     
                        db.SaveChanges();
                        log.LogAdd("Kayit", 4, item.id);
                        veri1();

                    }
                    else if (islem == 2)
                    {
                        Gozluk item = db.Gozluk.Find(id);
                        item.aktif = true;
                        mesaj = "Gözlük " + item.id;
               
                        db.SaveChanges();
                        log.LogAdd("Gözlük", 4, item.id);
                        veri2();
                    }
                    else if (islem == 3)
                    {
                        Marka item = db.Marka.Find(id);
                        item.aktif = true; mesaj = "Marka " + item.id;
              
                        db.SaveChanges();
                        log.LogAdd("Marka", 4, item.id);
                        veri3();
                    }
                    else if (islem == 4)
                    {
                        SekilTipi item = db.SekilTipi.Find(id);
                        item.aktif = true;
                        mesaj = "Şekil " + item.id;
                        log.LogAdd("Şekil", 4, item.id);
                        db.SaveChanges();
                        veri4();

                    }
                    else if (islem == 5)
                    {
                        CamTipleri item = db.CamTipleri.Find(id);
                        item.aktif = true;
                        mesaj = "Cam " + item.id;
                        log.LogAdd("Cam", 4, item.id);
                        db.SaveChanges();
                        veri5();

                    }

                  
                    mesaj += " Başarıyla Geri Yüklendi";

                }

            }
        }

        private void Silinenler_Load(object sender, EventArgs e)
        {
            control();
        }
    }
}
