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
    public partial class MusteriDuzenleForm : DevExpress.XtraEditors.XtraForm
    {
        public int id;
        kayit kayit = new kayit();

        public MusteriDuzenleForm()
        {
            InitializeComponent();
        }
        OptikDbEntities db = new OptikDbEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text != "")
            {  
                kayit.ad = textEdit1.Text;
                kayit.soyad = textEdit2.Text;
                kayit.telefon = textEdit3.Text;
          
                kayit.smsdurum = "";
                ///kayit.smsgonderim = 0;
                kayit.hak = "";
                kayit.alim = alimoffset.DateTimeOffset.DateTime;
                kayit.sonrakialim = kayit.alim.Value.AddYears(3);
                kayit.smsgonderim = DateTime.Now.AddYears(-3) > alimoffset.DateTimeOffset.DateTime ? comboBoxEdit1.SelectedIndex : 0;
                XtraMessageBox.Show(" Kişisi Düzenlendi ");
                db.SaveChanges();
                LogKayit log = new LogKayit();
                log.LogAdd("Kayit", 2, kayit.id);
                if (DateTime.Now.AddYears(-3) < alimoffset.DateTimeOffset.DateTime && comboBoxEdit1.SelectedIndex!=0) { MessageBox.Show("Sonraki alim tarihinden önce mesaj gönderimi yapılamaz.\nSms gönderimi sırasını bekliyor olarak değiştirilmiştir.!."); }
                this.Close();
            }
            else { XtraMessageBox.Show("İsim Girilmesi Zorunludur."); } 
           
        }

        private void MusteriDuzenleForm_Load(object sender, EventArgs e)
        {
            kayit = db.kayit.Where(x => x.id == id).FirstOrDefault();
            textEdit1.Text = kayit.ad;
           textEdit2.Text = kayit.soyad;
            textEdit3.Text = kayit.telefon ;
            alimoffset.DateTimeOffset = kayit.alim.Value;

            sonrakialimoffset.DateTimeOffset = kayit.sonrakialim.Value;
            comboBoxEdit1.SelectedIndex =Convert.ToInt32( kayit.smsgonderim);
        
        
        }

        private void alimoffset_EditValueChanged(object sender, EventArgs e)
        {
            sonrakialimoffset.EditValue= alimoffset.EditValue;
            if (DateTime.Now.AddYears(-3) > alimoffset.DateTimeOffset.DateTime) { textEdit4.Text = "Hak Var"; }
            else { textEdit4.Text = "Hak Yok"; }
        }
    }
}