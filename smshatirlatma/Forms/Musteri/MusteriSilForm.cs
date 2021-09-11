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

namespace smshatirlatma.Forms.Musteri
{
    public partial class MusteriSilForm : DevExpress.XtraEditors.XtraForm
    {
        public int id = -1;
        kayit kayit = new kayit();
        public MusteriSilForm()
        {
            InitializeComponent();
        }
        OptikDbEntities db = new OptikDbEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            kayit.aktif = false;
            db.SaveChanges();
            XtraMessageBox.Show(kayit.ad+ " "+ kayit.soyad +" Kişisi Silindi ");
            LogKayit log = new LogKayit();
            log.LogAdd("Kayit", 3, kayit.id);
            this.Close();
        }

        private void MusteriSilForm_Load(object sender, EventArgs e)
        {
        
            kayit = db.kayit.Where(x => x.id == id).FirstOrDefault();
            textEdit1.Text = kayit.ad + " " + kayit.soyad;
            textEdit2.Text = kayit.telefon;

        }
    }
}