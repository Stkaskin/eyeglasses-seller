using DevExpress.XtraEditors;
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

namespace smshatirlatma.UI.Modules.Sms
{
    public partial class ucSmsListesi : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucSmsListesi()
        {
            InitializeComponent();
        }

        private void SmsListesi_Load(object sender, EventArgs e)
        {
            veri();

        }
        private void veri()
        {
            OptikDbEntities db = new OptikDbEntities();
            var list= from a in db.Sms
                   select new
                      {
                          İD = a.id,
                          AD = a.kisiadı,
                          Telefon = a.kisitel,
                          Zaman=a.zaman,
                          MesajTürü = a.özel == true ? "ÖZEL" : "STANDART",
                          Mesaj = a.mesajmetni
                      };
            gridControl1.DataSource = list.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            veri();
        }

        private void ucSmsListesi_VisibleChanged(object sender, EventArgs e)
        {
            veri();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
        }

        private void Getir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
  
                string[] veri = new string[6];
                veri[0] = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString();
                veri[1] = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AD").ToString();
                veri[2] = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Telefon") != null ? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Telefon").ToString() : ""; 
                veri[3] = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Zaman") != null ? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Zaman").ToString() : ""; 
                veri[4] = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MesajTürü") != null ? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MesajTürü").ToString() : "";
                veri[5] = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mesaj") != null ? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mesaj").ToString() : "";
              




                string mesajmetni = " ZAMAN " + veri[3] + " tarihinde \n İDSİ " + veri[0] + " \nTELEFON " + veri[2] + " olan \n Ad Soyad " + veri[1] + " \n kişisine \n MESAJ TÜRÜ " + veri[4] + "   olarak şu mesaj atılmıştır . \n MESAJ :\n " + veri[5];
                XtraMessageBox.Show(mesajmetni,"Bilgi");
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
