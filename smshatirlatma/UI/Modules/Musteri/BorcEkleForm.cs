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
    public partial class BorcEkleForm : DevExpress.XtraEditors.XtraForm
    {
        public Borc borc = new Borc();
        List<kayit> kayitlar = new List<kayit>();
        kayit kayit = new kayit();
        int kisiid = -1;

        public BorcEkleForm()
        {
            InitializeComponent();
        }
        OptikDbEntities db = new OptikDbEntities();
        //private void simpleButton2_Click(object sender, EventArgs e)
        //{
        //    Borc borc = new Borc();
        //    db.Borc.Add(borc);
        //    db.SaveChanges();
        //}

        private void BorcEkleForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(281, 366);
            var list = from a in db.kayit where a.aktif==true

                     
                      where a.aktif==true  select new { İd = a.id, AD = a.ad + " " + a.soyad, Tel = a.telefon, Borc = db.Borc.Where(n => n.kayitid == a.id).Sum(n => n.tutar) };
            gridControl1.DataSource = list.ToList();

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
       
            if (kisiid>0 && Convert.ToInt32(textEdit3.EditValue)>0) { 
            Borc borc = new Borc();
            borc.islemturu = 1;
            borc.kayitid = kisiid;
            borc.zaman = DateTime.Now;
            borc.tutar = Convert.ToInt32(textEdit3.EditValue);

            db.Borc.Add(borc);
              
                db.SaveChanges();
                LogKayit log = new LogKayit();
                log.LogAdd("Borc", 6, borc.id);
                this.Close();
            }
            else { XtraMessageBox.Show("Geçersiz kişi veya geçersiz borç Tutarı girdiniz .!.\n İşlem yapmak istemiyosanız iptal tuşuna basabilirsiniz.!."); }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Size = new Size(281, 366);
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İd").ToString());
            var list = from a in db.kayit where a.aktif==true
                      
                       where a.id == id
                      where a.aktif==true  select new
                       {
                           İd = a.id,
                           Ad = a.ad,
                           Borc = db.Borc.Where(n => n.kayitid == a.id).Sum(n => n.tutar)
                       };


            foreach (var item in list)
            {
                textEdit2.Text = item.Borc>=0?item.Borc.ToString():"0"; 
                textEdit1.Text = item.Ad;
                kisiid = item.İd;
                break;
            }


            panelControl1.Visible = false;

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            gridView1.GroupPanelText = "Müşteriler";
            this.Size=new Size(960, 560);
           
            panelControl1.Visible = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Size = new Size(281, 366);
            panelControl1.Visible = false;
        }

    }
}