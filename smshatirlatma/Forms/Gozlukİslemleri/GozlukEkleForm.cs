using DevExpress.Xpo.Logger;
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

namespace smshatirlatma.Forms.Gozlukİslemleri
{
    public partial class GozlukEkleForm : DevExpress.XtraEditors.XtraForm
    {
        int markaid, camid, sekilid;
      public  byte islem = 0;
        public int id;

        byte secili = 1; 
        OptikDbEntities db = new OptikDbEntities();
        public GozlukEkleForm()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridView1.GroupPanelText = "Markalar";
            gridView1.Columns.Clear();
            secili = 1;
            markaveri();
            panelControl1.Visible = true;
        }
        private void markaveri()
        {
             db = new OptikDbEntities();
            var list = from a in db.Marka
                       where a.aktif == true
                       select new
                       {
                           İD = a.id,
                           Ad = a.ad,
                           MarkaKodu = a.Markakodu


                       };
            gridControl1.DataSource = list.ToList();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gridView1.GroupPanelText = "Camlar";
            gridView1.Columns.Clear();
            panelControl1.Visible = true; secili = 2;
            camveri();
        }
        private void camveri()
        {
             db = new OptikDbEntities();
            var list = from a in db.CamTipleri
                       where a.aktif == true
                       select new
                       {
                           İD = a.id,
                           Ad = a.ad,
                           CamKodu = a.CamKodu


                       };
            gridControl1.DataSource = list.ToList();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            gridView1.GroupPanelText = "Şekiller";
            gridView1.Columns.Clear();
            panelControl1.Visible = true; secili =3;
            sekilveri();
           
        }

        private void sekilveri()
        {
             db = new OptikDbEntities();
            var list = from a in db.SekilTipi
                       where a.aktif == true
                       select new
                       {
                           İD = a.id,
                           Ad = a.ad,



                       };
            gridControl1.DataSource = list.ToList();
            
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            panelControl1.Visible = false;
        }

        private void GozlukEkleForm_Load(object sender, EventArgs e)
        {
            if (islem!=1)
            {
                var list = from a in db.Gozluk
                           join b in db.Marka on a.markaid equals b.id
                           join d in db.SekilTipi on a.sekilid equals d.id
                           join c in db.CamTipleri on a.camid equals c.id
                           where a.id==id
                           select new
                           {
                               Ad = a.kod,
                               camid = c.id,
                               cam = c.ad,
                               sekilid =d.id,
                               sekil = d.ad,
                               markaid = b.id,
                               marka = b.ad
                           };


                textEdit1.Text = list.FirstOrDefault().Ad;
                textEdit2.Text = list.FirstOrDefault().marka;
                textEdit3.Text = list.FirstOrDefault().cam;
                textEdit4.Text = list.FirstOrDefault().sekil;
                markaid = list.FirstOrDefault().markaid;
                sekilid = list.FirstOrDefault().sekilid;
                camid = list.FirstOrDefault().camid;
                if (islem == 3) {textEdit1.Enabled= simpleButton2.Enabled = simpleButton3.Enabled = simpleButton4.Enabled = false; simpleButton7.Text = "Sil"; }
                else simpleButton7.Text = "Değiştir";

            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            
            if (secili == 1) 
            {
            markaid = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
                textEdit2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ad").ToString();
            }
            else if (secili == 2)
            {
             camid=   Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
                textEdit3.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ad").ToString();
            }
            else {
             sekilid=   Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
                textEdit4.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ad").ToString();
            }
            panelControl1.Visible = false;
          
        }

       
        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text != "" && textEdit1.Text != ""&& textEdit1.Text != ""&& textEdit1.Text != "" && markaid > 0 && sekilid > 0 && camid > 0)
            {

                string aciklama = ""; int logid; string tabloadi; int islems; LogKayit log = new LogKayit();
                
                KayitManager mnd = new KayitManager();
             
                if (islem==1) { 

                Gozluk gozluk = new Gozluk();
                gozluk.kod =textEdit1.Text ;
                gozluk.markaid = markaid;
                gozluk.sekilid = sekilid;
                gozluk.camid = camid;
                    gozluk.aktif = true;
                db.Gozluk.Add(gozluk);
                    db.SaveChanges();

                     logid = gozluk.id;
                    islems = 1;
                    tabloadi = "Gözlük";

                  
                    
                }
                else if (islem==2) {
                    Gozluk gozluk = db.Gozluk.Where(x=>x.id==id).FirstOrDefault();
                   
                    gozluk.kod = textEdit1.Text;
                    gozluk.markaid = markaid;
                    gozluk.sekilid = sekilid;
                    gozluk.camid = camid;
                    db.SaveChanges();
                    tabloadi = "Gözlük";
                    logid = gozluk.id;
                    islems = 2;
                 



                }
                else { Gozluk gozluk = db.Gozluk.Where(x => x.id == id).FirstOrDefault();
                    gozluk.aktif = false;
                    db.SaveChanges();
                    tabloadi = "Gözlük";
                    logid = gozluk.id;
                    islems = 3;
            

                }
                log.LogAdd( tabloadi, islems, logid);
             
                this.Close();
            }
        }
    }
}