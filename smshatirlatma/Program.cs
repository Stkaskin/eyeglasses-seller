using LoremNET;
using smshatirlatma.Forms;
using smshatirlatma.Model;
using smshatirlatma.UI.Modules.Musteri;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smshatirlatma
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {




            using (OptikDbEntities db = new OptikDbEntities())
            {
                //   db.Database.Delete();
                if (db.Database.CreateIfNotExists()) { tümislemler(db); }
                //     db.kayitlar.Add(new kayit() { ad = "selam felam" });
               //ekle(db);
                //duzenleadsoyad(db);
                //duzenlesmshak(db);
             //  tümislemler(db);
                 // db.SaveChanges();

            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Giris());
          //  Application.Run(new Giris());


        }
        private static void tümislemler(OptikDbEntities db) 
        {
           ekle(db);
           duzenleadsoyad(db);
           duzenlesmshak(db);
        }
            private static void duzenlesmshak(OptikDbEntities db)

        {
            List<kayit> kayits = new List<kayit>();
            kayits = db.kayit.ToList();
            foreach (var item in kayits)
            {
                if (DateTime.Now > item.sonrakialim)
                {
                    item.smsgonderim = 0;
                    if (item.smsgonderim == 0)
                    {

                        Random random = new Random();
                        int rnd;
                        rnd = random.Next(1, 1000) % 2;
                            if (rnd == 0) { rnd+=2; }
                 
                        item.smsgonderim = rnd;
                    
                    }
                 
                }
                else { item.smsgonderim = 0;   }
                item.hak = "";
                item.smsdurum = "";
              
            }
            db.SaveChanges();

        }
        private static void duzenleadsoyad(OptikDbEntities db)
        {
            string[] soyadlar = new string[9];
            string[] adlar = new string[10];

            adlar[0] = "ALİ";
            adlar[1] = "MAHMUT";
            adlar[2] = "GAMZE";
            adlar[3] = "KÜRŞAD";
            adlar[4] = "ÖZGÜR";
            adlar[5] = "BİRSEN";
            adlar[6] = "FATİH";
            adlar[7] = "EMRE";
            adlar[8] = "REZAN";
            adlar[9] = "GÖKHAN";

            soyadlar[0] = "Yücel";
            soyadlar[1] = "ASLAN";
            soyadlar[2] = "ERTEKİN";
            soyadlar[3] = "DEDE";
            soyadlar[4] = "VURAL";
            soyadlar[5] = "UYANIK";
            soyadlar[6] = "ÖZTÜRK";
            soyadlar[7] = "ÖZTÜRK";
            soyadlar[8] = "KANDEMİR";

            List<kayit> kayits = new List<kayit>();
            kayits = db.kayit.ToList();
            foreach (var item in kayits)
            {
                item.ad = Lorem.Random(adlar);
                //  item.soyad = Lorem.Random(soyadlar);
            }
            db.SaveChanges();

        }
        private static void ekle(OptikDbEntities db)
        {

            int[] sekiller = new int[8];
            int[] markalar = new int[8];
            int[] camlar = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Marka marka = new Marka();
                SekilTipi sekil = new SekilTipi();
                CamTipleri cam = new CamTipleri();
                marka.ad = Lorem.Paragraph(1, 1);
                sekil.ad = Lorem.Paragraph(1, 1);
                cam.ad = Lorem.Paragraph(1, 1);
                marka.aktif = true;
                cam.aktif = true;
                sekil.aktif = true;
                db.Marka.Add(marka);

                db.SekilTipi.Add(sekil);
                db.CamTipleri.Add(cam);
                db.SaveChanges();
                markalar[i] = marka.id;
                sekiller[i] = sekil.id;
                camlar[i] = cam.id;

            }

            for (int i = 0; i < 60; i++)
            {
                Gozluk gozluk = new Gozluk();
                gozluk.adet = (int)Lorem.Number(1, 50);
                gozluk.camid = Lorem.Random(camlar);
                gozluk.markaid = Lorem.Random(markalar);
                gozluk.sekilid = Lorem.Random(sekiller);
                gozluk.kod = Lorem.Paragraph(1, 1) + (int)Lorem.Number(100, 8008);
                gozluk.gonderim = true;
                gozluk.aktif = true;
                db.Gozluk.Add(gozluk);

            }

            for (int i = 0; i < 15; i++)
            {
                kayit kayit = new kayit();
                kayit.ad = Lorem.Paragraph(3, 2);
                kayit.alim = Lorem.DateTime(2010, 5, 10);
                kayit.sonrakialim = kayit.alim.Value.AddYears(3);
                //sorguya göre değer
                kayit.smsgonderim = 0;
                kayit.aktif = true;
                // MessageBox.Show(kayit.hak + "");
                db.kayit.Add(kayit);
            }
            db.SaveChanges();


        }


    }


}
