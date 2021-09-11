using DevExpress.XtraEditors;
using smshatirlatma.Forms.Musteri;
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
    public partial class ucSatislar : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucSatislar()
        {
            InitializeComponent();
        }

        private void ucSatislar_Load(object sender, EventArgs e)
        {
            veri();
    
        }
private void veri()
        {
            OptikDbEntities db = new OptikDbEntities();
            var List = from a in db.satis
                       join b in db.Gozluk on a.Gozlukid equals b.id

                       join m in db.Marka on b.markaid equals m.id

                       join k in db.kayit on a.Kayitid equals k.id
                     select new
                       {
                           İD = a.id,

                           AlanKişi = k.ad + " " + k.soyad,
                           Gözlük = b.kod,
                           Marka = m.ad,
                           TUTAR = a.tutar,
                           ZAMAN = a.zaman


                       };
            gridControl1.DataSource = List.ToList();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
            MusteriListeForm musteri = new MusteriListeForm();
            musteri.islem = 1;
            musteri.ShowDialog();
            veri();
            
            

        }

        private void ucSatislar_Leave(object sender, EventArgs e)
        {
            veri();
        }

        private void ucSatislar_VisibleChanged(object sender, EventArgs e)
        {
            veri();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                MusteriListeForm musteri = new MusteriListeForm();
                musteri.id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
                musteri.islem = 3;
                musteri.ShowDialog();
                veri();
            }

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0) {
            MusteriListeForm musteri = new MusteriListeForm();
            musteri.id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
            musteri.islem = 2;
            musteri.ShowDialog();
            veri();
        }

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
