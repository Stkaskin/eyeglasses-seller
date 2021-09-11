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
    public partial class ucSmsGonderilecekler : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucSmsGonderilecekler()
        {
            InitializeComponent();
        }

        private void ucSmsGonderilecekler_VisibleChanged(object sender, EventArgs e)
        {
            veri();
        }

        private void ucSmsGonderilecekler_Load(object sender, EventArgs e)
        {
            veri();
        }
        private void veri()
        {
            OptikDbEntities db = new OptikDbEntities();
            var list = from a in db.kayit
                       where a.sonrakialim < DateTime.Now 
                       select new
                       {
                           İD = a.id,
                           AD = a.ad,
                           Telefon = a.telefon,

                           SmsTür = "Tekrar Alım Hakkı",
                        
                       };
            gridControl1.DataSource = list.ToList();
        }
    }
}
