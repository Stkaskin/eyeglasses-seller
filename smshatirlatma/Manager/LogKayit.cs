using smshatirlatma.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smshatirlatma.Manager
{
   public class LogKayit
    {
        public int MyProperty { get; set; }
        // 0 giris 1 ekle 2 düzenle 3 sil 4 geri 5 sms 6 borc 7 borc sil 20 erişilmez sekilde silindi
        public void LogAdd( string tablo, int islem, int id)
        {
            string aciklama;
            OptikDbEntities db = new OptikDbEntities();
            GenelLog log = new GenelLog();
            log.islem = islem;
            log.tablo = tablo;
            string islemkomut = islem == 1 ? "Eklendi" : islem == 2 ? "Düzenlendi" : islem ==3 ? "Silindi" : islem == 4 ? "Geri Yüklendi" : islem == 5 ? "Aktarıldı" : islem == 6 ? " Borç Eklendi" : islem == 7 ? " Borç Ödedi" : islem == 20? " Kalıcı Olarak Silindi" :"Giriş Yaptı";
            log.aciklama = tablo+" İsimli Tablodan \n İD:"+id+" olan veri " + islemkomut ;
            log.zaman = DateTime.Now;
            log.tablo_id = id;
            db.GenelLog.Add(log);
            db.SaveChanges();
        }
    }

}
