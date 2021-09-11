using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using smshatirlatma.UI.Modules;
using smshatirlatma.UI.Modules.Musteri;
using smshatirlatma.UI.Modules.GozlukForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using smshatirlatma.UI.Modules.LogVeSilinenler;

namespace smshatirlatma
{
    public partial class AnaForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
    public   class form
        {
            public TutorialControlBase forms { get; set; }
            public string ad { get; set; }
        }
        List<form> forms = new List<form>();
        public AnaForm()
        {
            InitializeComponent();
        }
        async Task LoadModulesAsync(ModuleInfo module) 
        {
            await Task.Factory.StartNew(() =>
            {
                if (!fluentDesignFormContainer.Controls.ContainsKey(module.Name) )
                {
                    TutorialControlBase control = module.TModule as TutorialControlBase;
                  
                    if (control != null)
                    {
                        form f = new form();
                        f.ad = module.Name;
                        f.forms = control;
                        forms.Add(f);

                        control.Dock = DockStyle.Fill;

                     
                        control.CreateWaitDialog();
                        fluentDesignFormContainer.Invoke(new  MethodInvoker (delegate () 
                        {
                            fluentDesignFormContainer.Controls.Add(control);
                            control.BringToFront();
                        }));
                    }
                }
                else
                {
                    var control = fluentDesignFormContainer.Controls.Find(module.Name,true);
                    if (control.Length == 1)
                    {
                        fluentDesignFormContainer.Invoke(new MethodInvoker(delegate () { control[0].BringToFront(); }));
                    }
                }
            });
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            cntrl("ucMusteriler", "Musteri.");

            //this.fluentDesignFormContainer.Controls.Add(new ucMusteriler() { Dock = DockStyle.Fill });
            //this.PageName.Caption = $"{accordionControlElementMusteriListesi.Text}";

        }

        private  void accordionControlElementMusteriListesi_Click(object sender, EventArgs e)
        {
            //   cntrl(accordionControlElementMusteriListesi, "ucMusteriler");
            cntrl("ucMusteriler", "Musteri.");
            //this.PageName.Caption = $"{accordionControlElementMusteriListesi.Text}";
            //if (ModulesInfo.GetItem("ucMusteriler") == null)
            //{
            //    ModulesInfo.Add(new ModuleInfo("ucMusteriler", "smshatirlatma.UI.Modules.ucMusteriler"));

            //}
            //await LoadModulesAsync(ModulesInfo.GetItem("ucMusteriler"));
        }
        private async void cntrl(string name,string part)
        {
         //   this.PageName.Caption = $"{element.Text}";
            if (ModulesInfo.GetItem(name) == null)
            {
                ModulesInfo.Add(new ModuleInfo(name, "smshatirlatma.UI.Modules."+part + name));

            }
            foreach (var item in forms)
            {
                if (item.ad == name) {
                    item.forms.Visible = false;
                      item.forms.Visible = true;
                  
               }
            }
            await LoadModulesAsync(ModulesInfo.GetItem(name));
        }

        private  void accordionControlSatis_Click(object sender, EventArgs e)
        {



            this.PageName.Caption = $"{accordionControlSmsSistemi.Text}/{accordionControlSatis.Text}";
       
            cntrl("ucSatislar","Musteri.");
          
        }

        private void accordionControlElementGozlukler_Click(object sender, EventArgs e)
        {

            this.PageName.Caption = $"{accordionControlGozlukCategory.Text}/{accordionControlElementGozlukler.Text}";
            cntrl("ucGozlukler", "GozlukForms.");
        }

        private void accordionControlMarkalar_Click(object sender, EventArgs e)
        {

            this.PageName.Caption = $"{accordionControlGozlukCategory.Text}/{accordionControlMarkalar.Text}";
            cntrl("ucMarka", "GozlukForms.");
          
        }

        private void accordionControlSekiller_Click(object sender, EventArgs e)
        {

            this.PageName.Caption = $"{accordionControlGozlukCategory.Text}/{accordionControlSekiller.Text}";
            cntrl("ucSekil", "GozlukForms.");
        }

        private void accordionControlCamlar_Click(object sender, EventArgs e)
        {

            this.PageName.Caption = $"{accordionControlGozlukCategory.Text}/{accordionControlCamlar.Text}";
            cntrl("ucCam", "GozlukForms.");
        }

        private void accordionControlSmsGonder_Click(object sender, EventArgs e)
        {
            this.PageName.Caption = $"{accordionControlSmsSistemi.Text}/{accordionControlSmsGonder.Text}";
            cntrl("ucSmsGonder", "Sms.");
        }

        private void accordionControlSmsGonderilecekler_Click(object sender, EventArgs e)
        {
            this.PageName.Caption = $"{accordionControlSmsSistemi.Text}/{accordionControlSmsGonderilecekler.Text}";
            cntrl("ucSmsGonderilecekler", "Sms.");
        }

        private void accordionControlSmsGonderilenler_Click(object sender, EventArgs e)
        {
            this.PageName.Caption = $"{accordionControlSmsSistemi.Text}/{accordionControlSmsGonderilenler.Text}";
            cntrl("ucSmsListesi", "Sms.");
        }

        private void accordionControlElementBorclar_Click(object sender, EventArgs e)
        {
            this.PageName.Caption = $"{accordionControlSmsSistemi.Text}/{accordionControlSatis.Text}";

            cntrl("ucBorclar", "Musteri.");

        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AnaForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
  
            if (MessageBox.Show("Programdan Çıkmak İstediğine Emin Misin?", "Programdan Çıkış Talebi", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
            {
                e.Cancel = true;

            }
           
        }

        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void accordionControlElementSilinen_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {    this.PageName.Caption = $"{accordionControlSmsSistemi.Text}/{accordionControlSatis.Text}";

            cntrl("Silinenler", "LogVeSilinenler.");

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            this.PageName.Caption = $"{accordionControlSmsSistemi.Text}/{accordionControlSatis.Text}";

            cntrl("Log", "LogVeSilinenler.");

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {



            this.PageName.Caption = $"LGG/GRAFİK";

            cntrl("XtraForm2", "LogVeSilinenler.");
        }
    }
}
