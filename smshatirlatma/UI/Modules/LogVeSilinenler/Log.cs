using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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

namespace smshatirlatma.UI.Modules.LogVeSilinenler
{
    public partial class Log : DevExpress.DXperience.Demos.TutorialControlBase
    {//log da islem 1 ekleme 2 düzenleme 3 silme
        //tablo adı 
        public Log()
        {
            InitializeComponent();

          
          

        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
     
      
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        OptikDbEntities db = new OptikDbEntities();
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            GridDataSourceControl("Kayit");

        }
        private void GridDataSourceControl(string tablo)
        {
            gridView.Columns.Clear();
            var list = from a in db.GenelLog
                       where a.tablo == tablo
                       select new
                       {
                      LogİD=a.id,
                      Tablo=a.tablo,
                      Tablo_İD=a.tablo_id,
                      İşlem = a.islem == 1 ? "Eklendi" : a.islem == 2 ? "Düzenlendi" : a.islem == 3 ? "Silindi" : a.islem == 4 ? "Geri Yüklendi" : a.islem == 5 ? "Aktarıldı" : a.islem == 6 ? " Borç Eklendi" : a.islem == 7 ? " Borç Ödedi" : a.islem == 20 ? " Kalıcı Olarak Silindi" : "Giriş Yaptı", 
         
                          Zaman =a.zaman,
                      


                       };
            gridControl.DataSource = list.ToList();
            sonliste = tablo;
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            GridDataSourceControl("Gözlük");
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            GridDataSourceControl("Marka");
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            GridDataSourceControl("Şekil");
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            GridDataSourceControl("Cam");
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            GridDataSourceControl("SMS");
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            GridDataSourceControl("Satis");
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            GridDataSourceControl("Borc");
        }
        string sonliste = "";
        private void Log_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && sonliste!="")
            {
                
                GridDataSourceControl(sonliste);

            }
        }
    }
}
