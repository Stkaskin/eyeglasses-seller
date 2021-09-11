using DevExpress.XtraEditors;
using smshatirlatma.Forms.Gozlukİslemleri;
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

namespace smshatirlatma.UI.Modules.GozlukForms
{
    public partial class ucMarka : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucMarka()
        {
            InitializeComponent();
        }

        private void ucMarka_Load(object sender, EventArgs e)
        {
            veri();
        }
        private void veri (){
            OptikDbEntities db = new OptikDbEntities();
            var list = from a in db.Marka
                      where a.aktif==true  select new
                       {
                           İD = a.id,
                           Ad = a.ad,
                           MarkaKodu= a.Markakodu


                       };
            gridControl1.DataSource = list.ToList();
            
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            İslemForm form = new İslemForm();
            form.islem = 1;
            form.form = 1;
         //   form.id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
            form.ShowDialog();
            veri();
           
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {İslemForm form = new İslemForm();
            form.islem = 2;
            form.form = 1;
            form.id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
            form.ShowDialog();
            veri();
            }
            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {İslemForm form = new İslemForm();
            form.islem =3;
            form.form = 1;
            form.id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "İD").ToString());
            form.ShowDialog();
            veri();
            }
            
        }

        private void ucMarka_VisibleChanged(object sender, EventArgs e)
        {
            veri();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
