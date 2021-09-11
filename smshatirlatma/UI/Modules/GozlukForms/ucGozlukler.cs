using DevExpress.XtraEditors;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smshatirlatma.Model;
using smshatirlatma.Manager;
using smshatirlatma.Forms.Gozlukİslemleri;

namespace smshatirlatma.UI.Modules.GozlukForms
{
    public partial class ucGozlukler :DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucGozlukler()
        {
            InitializeComponent();
        }
     
        private void ucGozlukler_Load(object sender, EventArgs e)
        {

            veri();
        //   G mdl = new GozlukModel();
         
            //var List = from a in db.Gozluk
            //           join b in db.CamTipleri on a.EtaId equals b.EtaId
            //           join c in db.FruitInfo on a.FruitId equals c.FruitId
            //           where b.ReleasedDate == null
            //          where a.aktif==true  select new
            //           {
            //               FruitName = c.FruitName,
            //               EtaId = b.EtaId
            //           }.ToList();



        }
       void veri()
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            GozlukEkleForm frm = new GozlukEkleForm();
            frm.islem = 1;
            frm.ShowDialog();
            veri();
            
        }
        
        private void ucGozlukler_VisibleChanged(object sender, EventArgs e)
        {
            veri();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {GozlukEkleForm frm = new GozlukEkleForm();
            frm.islem =2;
                frm.id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
                frm.ShowDialog();
            veri();
            }
            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {GozlukEkleForm frm = new GozlukEkleForm();
            frm.islem = 3;
                frm.id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
                frm.ShowDialog();
            veri();
            }
            
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
