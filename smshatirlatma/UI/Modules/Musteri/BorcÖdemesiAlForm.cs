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

namespace smshatirlatma.UI.Modules.Musteri
{
    public partial class BorcÖdemesiAlForm : DevExpress.XtraEditors.XtraForm
    {
       public Borc borc = new Borc();
        List<kayit> kayitlar = new List<kayit>();
        kayit kayit = new kayit();
        int kisiid = -1;
       
    
        public BorcÖdemesiAlForm()
        {
            InitializeComponent();
        }

        private void BorcÖdemesiAlForm_Load(object sender, EventArgs e)
        {
            var list = from a in db.kayit where a.aktif==true
                      
                       where  db.Borc.Where(n => n.kayitid == a.id).Sum(n => n.tutar) > 0 
                      where a.aktif==true  select new { İd = a.id, AD =a.ad+" "+a.soyad,Tel=a.telefon, Borc = db.Borc.Where(n => n.kayitid == a.id).Sum(n => n.tutar) };
            gridControl1.DataSource = list.ToList();
        }
        OptikDbEntities db = new OptikDbEntities();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (kisiid > 0 && Convert.ToInt32(textEdit3.EditValue) <=Convert.ToInt32(textEdit2.EditValue))
            {
                Borc borc = new Borc();
                borc.islemturu = 2;
                borc.kayitid = kisiid;
                borc.zaman = DateTime.Now;
                borc.tutar = -Convert.ToInt32(textEdit3.EditValue);

                db.Borc.Add(borc);
                db.SaveChanges();
                LogKayit log = new LogKayit();
                log.LogAdd("Borc", 7, borc.id);
                this.Close();
            } else { XtraMessageBox.Show("Geçersiz kişi veya geçersiz ödene tutarı girdiniz .!.\n İşlem yapmak istemiyosanız iptal tuşuna basabilirsiniz.!."); }
          

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                
                    int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İd").ToString());
                    var list = from a in db.kayit
                           where a.aktif == true
                           join b in db.Borc on a.id equals b.kayitid
                           where a.id == id
                          where a.aktif==true  select new
                           {
                               İd = a.id,
                               Ad = a.ad,
                               Borc = db.Borc.Where(n => n.kayitid == a.id).Sum(n => n.tutar)
                           };

                    textEdit2.Text = list.FirstOrDefault().Borc.ToString();
                    textEdit1.Text = list.FirstOrDefault().Ad.ToString();
                    kisiid = list.FirstOrDefault().İd;
             


                panelControl1.Visible = false;
            }
            

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            gridView1.GroupPanelText = "Müşteriler";
            panelControl1.Visible = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            panelControl1.Visible = false;
        }
    }
}