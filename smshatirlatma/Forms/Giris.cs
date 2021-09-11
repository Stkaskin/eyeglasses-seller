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

namespace smshatirlatma.Forms
{
    public partial class Giris : DevExpress.XtraEditors.XtraForm
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OptikDbEntities db = new OptikDbEntities();
            AdminGiris giris = db.AdminGiris.Where(x => x.kullaniciadi == textEdit1.Text && x.parola == textEdit2.Text).FirstOrDefault();
            if (giris != null || textEdit1.Text == "talas" & textEdit2.Text == "751")
            {
                AnaForm anaForm = new AnaForm();
                anaForm.Show();
                LogKayit log = new LogKayit();
               // log.LogAdd("Giris",0, giris.id);
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Bilgiler yanlış (veritabanından admin bilgilerini ekleyiniz.)", "Giriş Kontrol Sonucu \n" +
                    "Veritabansız giriş için Giris Adı:talas parola:751");
            }


        }
    }
}
