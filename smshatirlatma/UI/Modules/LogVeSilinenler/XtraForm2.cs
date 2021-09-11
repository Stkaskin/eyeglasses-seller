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


namespace smshatirlatma.UI.Modules.LogVeSilinenler
{
    public partial class XtraForm2 : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public XtraForm2()
        {
            InitializeComponent();
        }
        OptikDbEntities db = new OptikDbEntities();
        private void XtraForm2_Load(object sender, EventArgs e)

        {
       
         

         

          
            //chartControl1.DataSource = list.ToList();


         
      
        


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chartControl1.Series[0].Points.Clear();
            chartControl1.Series[1].Points.Clear();
            chartControl1.Series[2].Points.Clear();
            var list = from a in db.Marka

                       select new
                       {

                           a.ad,
                           top = db.Gozluk.Where(x => x.markaid == a.id).Count()
                       };
            foreach (var item in list)
            {
                try
                {
                    chartControl1.Series[0].Points.AddPoint(item.ad.ToString(), (double)item.top);
                }
                catch { }
                //  break;

            }
            chartControl1.SeriesNameTemplate.BeginText = "MARKA: ";
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chartControl1.Series[0].Points.Clear();
            chartControl1.Series[1].Points.Clear();
            chartControl1.Series[2].Points.Clear();
            var list1 = from a in db.SekilTipi

                        select new
                        {

                            a.ad,
                            top = db.Gozluk.Where(x => x.sekilid == a.id).Count()
                        };
            foreach (var item in list1)
            {
                try
                {
                    chartControl1.Series[1].Points.AddPoint(item.ad.ToString(), (double)item.top);
                }
                catch { }
                //  break;

            }
            chartControl1.SeriesNameTemplate.BeginText = "ŞEKİL: ";
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chartControl1.Series[0].Points.Clear();
            chartControl1.Series[1].Points.Clear();
            chartControl1.Series[2].Points.Clear();


            var list = from a in db.CamTipleri

                        select new
                        {

                            a.ad,
                            top = db.Gozluk.Where(x => x.camid == a.id).Count()
                        };
            foreach (var item in list)
            {
                try
                {
                    chartControl1.Series[2].Points.AddPoint(item.ad.ToString(), (double)item.top);
                    
                }
                catch { }
                //  break;

            }
            chartControl1.SeriesNameTemplate.BeginText = "CAM: ";
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}