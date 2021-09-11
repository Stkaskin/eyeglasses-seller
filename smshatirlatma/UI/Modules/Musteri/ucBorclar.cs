using DevExpress.XtraEditors;
using smshatirlatma.Manager;
using smshatirlatma.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smshatirlatma.UI.Modules.Musteri
{
    public partial class ucBorclar : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucBorclar()
        {
            InitializeComponent();

            GetDataSource();
        }
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {

            if (e.Button.Properties.Caption == "Borç Ekle")
            {
                BorcEkleForm form = new BorcEkleForm();
                form.ShowDialog();

            }
            else if (e.Button.Properties.Caption == "Ödeme Ekle")
            {
                BorcÖdemesiAlForm form = new BorcÖdemesiAlForm();
                form.ShowDialog();

            }
            else if (e.Button.Properties.Caption == "Düzenle" )
            {
                if (listetur) { 
                OptikDbEntities db = new OptikDbEntities();
                int id = Convert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID").ToString());
                Borc borc = db.Borc.Find(id);
                    var maxborc = db.Borc.Where(n => n.kayitid == borc.kayitid).Sum(n => n.tutar);
                    int max = Convert.ToInt32(maxborc);
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                // set required Input Box options
                args.Caption = "Tutar Ayarı";
                args.Prompt = "Yeni Tutar Girin";
                args.DefaultButtonIndex = 0;
                args.Showing += Args_Showing;
                // initialize a DateEdit editor with custom settings
                TextEdit ed = new TextEdit();
                ed.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                ed.Properties.Mask.EditMask = "n";


                args.Editor = ed;
                // a default DateEdit value
                args.DefaultResponse = "";
                // display an Input Box with the custom editor
                var result = XtraInputBox.Show(args);
                if (result != null && Convert.ToInt32(result) > 0 )
                {
                    if (borc.islemturu == 1)
                    {
                        borc.tutar = Convert.ToInt32(result) ;  LogKayit log = new LogKayit();
                        log.LogAdd("Borc", 2, borc.id);
                    }
                    else if (borc.islemturu== 2 &&  max >= Convert.ToInt32(result))
                    { 
                        borc.tutar = Convert.ToInt32(result)*-1;   
                            LogKayit log = new LogKayit();
                        log.LogAdd("Borc", 2, borc.id);
                    }
                      

                    }

                db.SaveChanges();
                }
                else
                {
                    XtraMessageBox.Show("Sadece Detay Bölümünde Düzenleme İşlemi Yapabilirsiniz. Buradan Toplam Borç TUTARI değiştirildiğinde tutarsızlık olacağından yanlış hesap tutulduysa hesapları kontrol ediniz \n Borcu silmek için Sil butonunu kullanın.","Uyarı");
                }




            }
            else if (e.Button.Properties.Caption == "Satırı Sil")
            {

                if (XtraMessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    OptikDbEntities db = new OptikDbEntities();
                    int id = Convert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID").ToString());
                    if (listetur)
                    {
                       
                        Borc borc = db.Borc.Find(id);
                        LogKayit log = new LogKayit();
                        log.LogAdd("Borc", 20, borc.id);
                        db.Borc.Remove(borc);
                        db.SaveChanges();
                     
                    }
                else
                    {
                      
                        var borckaydı = from a in db.kayit
                                    where a.id==id
                                    select new
                                    {
                                       borc= a.Borc.Sum(x => x.tutar)
                                    };
                        Borc borc = new Borc();
                        borc.kayitid = id;
                        borc.islemturu = 2;
                        borc.tutar = borckaydı.FirstOrDefault().borc*-1;
                        borc.zaman = DateTime.Now;
                        db.Borc.Add(borc);
                        db.SaveChanges();
                        LogKayit log = new LogKayit();
                        log.LogAdd("Borc", 7, borc.id);

                    }


                };
            }
            else if (e.Button.Properties.Caption == "Yenile")
            {
                GridControlChanceDataSource();
            }
            else if (e.Button.Properties.Caption == "İşlemleri Listele")
            {
                listetur = true;
        
                e.Button.Properties.Caption = "Borçlu Listele";

             


            }
            else if (e.Button.Properties.Caption == "Borçlu Listele")
            {
                listetur = false;


                e.Button.Properties.Caption = "İşlemleri Listele";
           
            }
            else if (e.Button.Properties.Caption == "Görüntüle/Yazdır")
            {
                gridControl.ShowRibbonPrintPreview();
            }
            GridControlChanceDataSource();

        }
        bool listetur = true;
        private void GridControlChanceDataSource()
        {
            OptikDbEntities db = new OptikDbEntities();
            gridView.Columns.Clear();
            gridControl.DataSource = null;
          
            if (listetur)
            {

             
                var list = from a in db.Borc
                           join b in db.kayit on a.kayitid equals b.id
                           select new { ID = a.id, Kişi = b.ad + " " + b.soyad, İşlem = a.islemturu == 1 ? "Borç" : "Ödeme", Tutar = a.tutar, Zaman = a.zaman };
                gridControl.DataSource = list.ToList();
                labelControl.Text = "Tüm Borç İşlemleri";
               
            }
            else
            {

                labelControl.Text = "Borçlu Müşteriler ";
                var list = from a in db.kayit


                           where a.aktif == true && a.Borc.Sum(x => x.tutar)>0

                           select new
                           {
                               ID = a.id,
                               AD = a.ad,
                               TELEFON = a.telefon,
                               BORC = a.Borc.Sum(x => x.tutar)
                           };

                gridControl.DataSource = list.ToList();

            }
        }
        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {

        }
        public BindingList<Customer> GetDataSource()
        {

            OptikDbEntities db = new OptikDbEntities();
            BindingList<Customer> result = new BindingList<Customer>();
            result.Add(new Customer()
            {
                ID = 1,
                Name = "ACME",
                Address = "2525 E El Segundo Blvd",
                City = "El Segundo",
                State = "CA",
                ZipCode = "90245",
                Phone = "(310) 536-0611"
            });
            var list = from a in db.Borc
                       join b in db.kayit on a.kayitid equals b.id
                       select new { ID = a.id, Kişi = b.ad + " " + b.soyad, İşlem = a.islemturu == 1 ? "Borç" : "Ödeme", Tutar = a.tutar, Zaman = a.zaman };
            gridControl.DataSource = list.ToList();
            gridView.GroupPanelText = "Borçlu Listesi";
            return result;
        }
        public class Customer
        {
            [Key, Display(AutoGenerateField = false)]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            [Display(Name = "Zip Code")]
            public string ZipCode { get; set; }
            public string Phone { get; set; }
        }

        private void windowsUIButtonPanel_Click(object sender, EventArgs e)
        {


        }

        private void ucBorclar_Load(object sender, EventArgs e)
        {
            GridControlChanceDataSource();

        }

        private void ucBorclar_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible) { GridControlChanceDataSource(); }
        }
    }
}
