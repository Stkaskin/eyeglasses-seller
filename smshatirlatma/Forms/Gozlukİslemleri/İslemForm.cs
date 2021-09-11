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
    public partial class İslemForm : DevExpress.XtraEditors.XtraForm
    {//MARKA=1 CAM =2 SEKİL=3 
        public int form;
        //NEW 1 EDİT 2 DELETE 3
        public int islem;
        public int id;
        Marka item;
        public İslemForm()
        {
            InitializeComponent();
        }
        OptikDbEntities db = new OptikDbEntities();

        private void İslemForm_Load(object sender, EventArgs e)
        {
            
            if (form == 1)

            {
                this.Text = "";
                item = new Marka();

                labelControl2.Text = "MARKA ADI";
                labelControl1.Text = "İD";
                labelControl3.Text = "MARKA KODU";
                textEdit3.Visible = true;

                labelControl3.Visible = true;
                if (islem == 1)
                {
                    this.Text = "Marka Ekle";

                    labelControl1.Visible = false;
                    textEdit1.Visible = false;




                    simpleButton1.Text = "EKLE";

                }
                else if (islem == 2)
                {
                    this.Text = "Marka Düzenle";
                    textEdit1.Enabled = false;
                    simpleButton1.Text = "DÜZENLE";
                    item = db.Marka.Where(x => x.id == id).FirstOrDefault();

                    textEdit2.Text = item.ad;
                    textEdit1.Text = item.id.ToString();
                    textEdit3.Text = item.Markakodu.ToString();


                }
                else if (islem == 3)
                {
                    this.Text = "Marka Sil";
                    textEdit1.Enabled = textEdit2.Enabled = textEdit3.Enabled = false;
                    textEdit1.Enabled = false;
                    simpleButton1.Text = "SİL";

                    item = db.Marka.Where(x => x.id == id).FirstOrDefault();
                    textEdit2.Text = item.ad;
                    textEdit1.Text = item.id.ToString();
                    textEdit3.Text = item.Markakodu.ToString();


                }
                db.SaveChanges();
            }
            else if (form == 2)
            {
                CamTipleri cam = new CamTipleri();
               

                labelControl2.Text = "Cam ADI";
                labelControl1.Text = "İD";
                labelControl3.Text = "Cam KODU";
            

                labelControl3.Visible = true;
                if (islem == 1)
                {
                    this.Text = "Cam Ekle";

                    labelControl1.Visible = false;
                    textEdit1.Visible = false;




                    simpleButton1.Text = "EKLE";

                }
                else if (islem == 2)
                {
                    this.Text = "Cam Düzenle";
                    textEdit1.Enabled = false;
                    simpleButton1.Text = "DÜZENLE";
                    cam = db.CamTipleri.Where(x => x.id == id).FirstOrDefault();

                    textEdit2.Text = cam.ad;
                    textEdit1.Text = cam.id.ToString();
                    textEdit3.Text = cam.CamKodu.ToString();


                }
                else if (islem == 3)
                {
                    this.Text = "Cam Sil";
                    textEdit1.Enabled = textEdit2.Enabled = textEdit3.Enabled = false;
      
                    simpleButton1.Text = "SİL";

                    cam = db.CamTipleri.Where(x => x.id == id).FirstOrDefault();
                    textEdit2.Text = cam.ad;
                    textEdit1.Text = cam.id.ToString();
                    textEdit3.Text = cam.CamKodu.ToString();


                }
                db.SaveChanges();
            }
            else if (form == 3)
            {
                SekilTipi sekil = new SekilTipi();


                labelControl2.Text = "Sekil ADI";
                labelControl1.Text = "İD";
                labelControl3.Visible = textEdit3.Visible = false;


                if (islem == 1)
                {

                    this.Text = "Sekil Ekle";
                    labelControl1.Visible = false;
                    textEdit1.Visible = false;




                    simpleButton1.Text = "EKLE";

                }
                else if (islem == 2)
                {
                    this.Text = "Sekil Düzenle";
                    textEdit1.Enabled = false;
                    simpleButton1.Text = "DÜZENLE";
                    sekil = db.SekilTipi.Where(x => x.id == id).FirstOrDefault();

                    textEdit2.Text = sekil.ad;
                    textEdit1.Text = sekil.id.ToString();
                


                }
                else if (islem == 3)
                {
                    this.Text = "Sekil Sil";
                    textEdit1.Enabled = textEdit2.Enabled = textEdit3.Enabled = false;

                    simpleButton1.Text = "SİL";

                    sekil = db.SekilTipi.Where(x => x.id == id).FirstOrDefault();
                    textEdit2.Text = sekil.ad;
                    textEdit1.Text = sekil.id.ToString();
             


                }
                db.SaveChanges();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
            if (form == 1)

            { string tabloadi, aciklama; int logid, islems;
                tabloadi = "Marka";
                //string tabloadi, aciklama; int logid, islems;  LogKayit log = new LogKayit();
                //tabloadi = "MARKA";
                //logid = gozluk.id;
                //islems = 3;
                //aciklama = " Gözlük Silindi  \n" + id + "\n Ad =" + gozluk.kod;
                //log.LogAdd(aciklama, tabloadi, islems, logid);

                islems = islem;
                if (islem == 1)
                {
                  
                    item.ad = textEdit2.Text;
                    item.Markakodu = textEdit3.Text != "" ? Convert.ToInt32(textEdit3.Text) : id;
                    item.aktif = true;
                    db.Marka.Add(item);
                
                  
              

                }
                else if (islem == 2)
                {


                   
                     item = db.Marka.Where(x => x.id == id).FirstOrDefault();
                   item.Markakodu =textEdit3.Text!=""?  Convert.ToInt32(textEdit3.Text):id ;
                    item.ad = textEdit2.Text;

                   
                 
                }
                else if (islem == 3)
                {
             
                    item = db.Marka.Where(x => x.id == id).FirstOrDefault();
                    item.aktif = false;


                }
                db.SaveChanges();
                logid = item.id;
                LogKayit log = new LogKayit();
                log.LogAdd(tabloadi, islems, logid);
            }
            else if (form == 2)
            {
                string tabloadi = "Cam";
                int islems = islem;
                CamTipleri cam = new CamTipleri();

                if (islem == 1)
                {

                    cam.ad = textEdit2.Text;
                    cam.CamKodu = textEdit3.Text != "" ? Convert.ToInt32(textEdit3.Text) : id;
                    cam.aktif = true;
                    db.CamTipleri.Add(cam);
                }
                else if (islem == 2)
                {



                    cam = db.CamTipleri.Where(x => x.id == id).FirstOrDefault();
                    cam.CamKodu = textEdit3.Text != "" ? Convert.ToInt32(textEdit3.Text) : id;
                    cam.ad = textEdit2.Text;



                }
                else if (islem == 3)
                {

                    cam = db.CamTipleri.Where(x => x.id == id).FirstOrDefault();
                    cam.aktif = false;


                }
                db.SaveChanges();
                LogKayit log = new LogKayit();
                log.LogAdd(tabloadi, islems, cam.id);
            }
            else if (form == 3)
            {

                string tabloadi = "Şekil";
                int islems = islem;
                SekilTipi sekil = new SekilTipi();
                labelControl3.Visible = textEdit3.Visible = false;
                if (islem == 1)
                {

                    sekil.ad = textEdit2.Text;
                    sekil.aktif = true;
                    db.SekilTipi.Add(sekil);
                }
                else if (islem == 2)
                {



                    sekil = db.SekilTipi.Where(x => x.id == id).FirstOrDefault();

                    sekil.ad = textEdit2.Text;



                }
                else if (islem == 3)
                {

                    sekil = db.SekilTipi.Where(x => x.id == id).FirstOrDefault();
                    sekil.aktif = false;


                }
                db.SaveChanges(); LogKayit log = new LogKayit();
                log.LogAdd(tabloadi, islems, sekil.id);
            }
            XtraMessageBox.Show("İşlem Bitişi", "İşleminiz Onaylandı.!.");
            this.Close();
        }
    }
}