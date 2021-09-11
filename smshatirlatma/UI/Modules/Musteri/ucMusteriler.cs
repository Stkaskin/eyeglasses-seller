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
    public partial class ucMusteriler : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucMusteriler()
        {
            InitializeComponent();
        }

        private void ucMusteriler_Load(object sender, EventArgs e)
        {
            veri();
        }
        private void veri()
        {
            OptikDbEntities db = new OptikDbEntities();
            var List = from a in db.kayit 
                      where a.aktif==true 
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

        private void YeniMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MusteriEkleForm frm = new MusteriEkleForm();
            frm.ShowDialog();
            veri();
        }

        private void barLargeButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {MusteriSilForm frm = new MusteriSilForm();
            frm.id = frm.id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
            frm.ShowDialog();
            veri();
            }
            else
            {
                XtraMessageBox.Show("Silinecek Müşteri Bulanamadı.!.");
            }
            
        }

        private void barLargeButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {MusteriDuzenleForm frm = new MusteriDuzenleForm();
            frm.id= Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
            frm.ShowDialog();
            veri();
            }
            else
            {
                XtraMessageBox.Show("Düzenlenecek Müşteri Bulanamadı.!.");
            }


        }

        private void ucMusteriler_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)veri();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
