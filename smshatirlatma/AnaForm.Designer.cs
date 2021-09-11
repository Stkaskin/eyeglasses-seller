
namespace smshatirlatma
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.fluentDesignFormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElementMusteri = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementMusteriListesi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementBorclar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSatis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSmsSistemi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSmsGonder = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSmsGonderilenler = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSmsGonderilecekler = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSmsMetinleri = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlGozlukCategory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementGozlukler = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlMarkalar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSekiller = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCamlar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.PageName = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.calcEdit1 = new DevExpress.XtraEditors.CalcEdit();
            this.calcEdit2 = new DevExpress.XtraEditors.CalcEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer
            // 
            this.fluentDesignFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer.Location = new System.Drawing.Point(230, 0);
            this.fluentDesignFormContainer.Name = "fluentDesignFormContainer";
            this.fluentDesignFormContainer.Size = new System.Drawing.Size(457, 471);
            this.fluentDesignFormContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementMusteri,
            this.accordionControlSmsSistemi,
            this.accordionControlGozlukCategory,
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(230, 471);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementMusteri
            // 
            this.accordionControlElementMusteri.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementMusteriListesi,
            this.accordionControlElementBorclar,
            this.accordionControlSatis});
            this.accordionControlElementMusteri.Expanded = true;
            this.accordionControlElementMusteri.Name = "accordionControlElementMusteri";
            this.accordionControlElementMusteri.Text = "Müşteriler";
            // 
            // accordionControlElementMusteriListesi
            // 
            this.accordionControlElementMusteriListesi.Expanded = true;
            this.accordionControlElementMusteriListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementMusteriListesi.ImageOptions.Image")));
            this.accordionControlElementMusteriListesi.Name = "accordionControlElementMusteriListesi";
            this.accordionControlElementMusteriListesi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementMusteriListesi.Text = "Müşteri Listesi";
            this.accordionControlElementMusteriListesi.Click += new System.EventHandler(this.accordionControlElementMusteriListesi_Click);
            // 
            // accordionControlElementBorclar
            // 
            this.accordionControlElementBorclar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementBorclar.ImageOptions.Image")));
            this.accordionControlElementBorclar.Name = "accordionControlElementBorclar";
            this.accordionControlElementBorclar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementBorclar.Text = "Borç İşlemleri";
            this.accordionControlElementBorclar.Click += new System.EventHandler(this.accordionControlElementBorclar_Click);
            // 
            // accordionControlSatis
            // 
            this.accordionControlSatis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSatis.ImageOptions.Image")));
            this.accordionControlSatis.Name = "accordionControlSatis";
            this.accordionControlSatis.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSatis.Text = "Satiş İşlemleri";
            this.accordionControlSatis.Click += new System.EventHandler(this.accordionControlSatis_Click);
            // 
            // accordionControlSmsSistemi
            // 
            this.accordionControlSmsSistemi.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlSmsGonder,
            this.accordionControlSmsGonderilenler,
            this.accordionControlSmsGonderilecekler,
            this.accordionControlSmsMetinleri});
            this.accordionControlSmsSistemi.Expanded = true;
            this.accordionControlSmsSistemi.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlSmsSistemi.Name = "accordionControlSmsSistemi";
            this.accordionControlSmsSistemi.Text = "SMS Sistemi";
            // 
            // accordionControlSmsGonder
            // 
            this.accordionControlSmsGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSmsGonder.ImageOptions.Image")));
            this.accordionControlSmsGonder.Name = "accordionControlSmsGonder";
            this.accordionControlSmsGonder.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSmsGonder.Text = "Toplu Sms Gönder";
            this.accordionControlSmsGonder.Click += new System.EventHandler(this.accordionControlSmsGonder_Click);
            // 
            // accordionControlSmsGonderilenler
            // 
            this.accordionControlSmsGonderilenler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSmsGonderilenler.ImageOptions.Image")));
            this.accordionControlSmsGonderilenler.Name = "accordionControlSmsGonderilenler";
            this.accordionControlSmsGonderilenler.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSmsGonderilenler.Text = "Son Sms Gönderilenler";
            this.accordionControlSmsGonderilenler.Click += new System.EventHandler(this.accordionControlSmsGonderilenler_Click);
            // 
            // accordionControlSmsGonderilecekler
            // 
            this.accordionControlSmsGonderilecekler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSmsGonderilecekler.ImageOptions.Image")));
            this.accordionControlSmsGonderilecekler.Name = "accordionControlSmsGonderilecekler";
            this.accordionControlSmsGonderilecekler.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSmsGonderilecekler.Text = "SMS Gönderilecekler";
            this.accordionControlSmsGonderilecekler.Click += new System.EventHandler(this.accordionControlSmsGonderilecekler_Click);
            // 
            // accordionControlSmsMetinleri
            // 
            this.accordionControlSmsMetinleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSmsMetinleri.ImageOptions.Image")));
            this.accordionControlSmsMetinleri.Name = "accordionControlSmsMetinleri";
            this.accordionControlSmsMetinleri.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSmsMetinleri.Text = "SMS Metinleri";
            this.accordionControlSmsMetinleri.Visible = false;
            // 
            // accordionControlGozlukCategory
            // 
            this.accordionControlGozlukCategory.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementGozlukler,
            this.accordionControlMarkalar,
            this.accordionControlSekiller,
            this.accordionControlCamlar});
            this.accordionControlGozlukCategory.Expanded = true;
            this.accordionControlGozlukCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlGozlukCategory.ImageOptions.Image")));
            this.accordionControlGozlukCategory.Name = "accordionControlGozlukCategory";
            this.accordionControlGozlukCategory.Text = "Gözlükler";
            // 
            // accordionControlElementGozlukler
            // 
            this.accordionControlElementGozlukler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementGozlukler.ImageOptions.Image")));
            this.accordionControlElementGozlukler.Name = "accordionControlElementGozlukler";
            this.accordionControlElementGozlukler.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementGozlukler.Text = "Gözlük Listesi";
            this.accordionControlElementGozlukler.Click += new System.EventHandler(this.accordionControlElementGozlukler_Click);
            // 
            // accordionControlMarkalar
            // 
            this.accordionControlMarkalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlMarkalar.ImageOptions.Image")));
            this.accordionControlMarkalar.Name = "accordionControlMarkalar";
            this.accordionControlMarkalar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlMarkalar.Text = "Markalar";
            this.accordionControlMarkalar.Click += new System.EventHandler(this.accordionControlMarkalar_Click);
            // 
            // accordionControlSekiller
            // 
            this.accordionControlSekiller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSekiller.ImageOptions.Image")));
            this.accordionControlSekiller.Name = "accordionControlSekiller";
            this.accordionControlSekiller.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSekiller.Text = "Şekiller";
            this.accordionControlSekiller.Click += new System.EventHandler(this.accordionControlSekiller_Click);
            // 
            // accordionControlCamlar
            // 
            this.accordionControlCamlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCamlar.ImageOptions.Image")));
            this.accordionControlCamlar.Name = "accordionControlCamlar";
            this.accordionControlCamlar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCamlar.Text = "Cam Tipleri";
            this.accordionControlCamlar.Click += new System.EventHandler(this.accordionControlCamlar_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement4});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Log Ve Silinen Veriler";
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Silinenler";
            this.accordionControlElement2.Click += new System.EventHandler(this.accordionControlElement2_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Loglar";
            this.accordionControlElement3.Click += new System.EventHandler(this.accordionControlElement3_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement4.ImageOptions.Image")));
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Grafik";
            this.accordionControlElement4.Click += new System.EventHandler(this.accordionControlElement4_Click);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.PageName,
            this.barButtonItem1});
            this.fluentFormDefaultManager1.MaxItemId = 2;
            // 
            // PageName
            // 
            this.PageName.Caption = "barStaticItem1";
            this.PageName.Id = 0;
            this.PageName.Name = "PageName";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // calcEdit1
            // 
            this.calcEdit1.Location = new System.Drawing.Point(130, 362);
            this.calcEdit1.MenuManager = this.fluentFormDefaultManager1;
            this.calcEdit1.Name = "calcEdit1";
            this.calcEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdit1.Size = new System.Drawing.Size(100, 20);
            this.calcEdit1.TabIndex = 2;
            // 
            // calcEdit2
            // 
            this.calcEdit2.Location = new System.Drawing.Point(130, 362);
            this.calcEdit2.MenuManager = this.fluentFormDefaultManager1;
            this.calcEdit2.Name = "calcEdit2";
            this.calcEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdit2.Size = new System.Drawing.Size(100, 20);
            this.calcEdit2.TabIndex = 2;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(130, 362);
            this.dateEdit1.MenuManager = this.fluentFormDefaultManager1;
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 2;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 471);
            this.Controls.Add(this.fluentDesignFormContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.calcEdit1);
            this.Controls.Add(this.calcEdit2);
            this.Controls.Add(this.dateEdit1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("AnaForm.IconOptions.Image")));
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Işık Optik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaForm_FormClosed);
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementMusteri;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementMusteriListesi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementBorclar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSmsSistemi;
        private DevExpress.XtraEditors.CalcEdit calcEdit2;
        private DevExpress.XtraEditors.CalcEdit calcEdit1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSmsGonder;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSmsGonderilenler;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSmsGonderilecekler;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSmsMetinleri;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlGozlukCategory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementGozlukler;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlMarkalar;
        private DevExpress.XtraBars.BarStaticItem PageName;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSatis;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSekiller;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCamlar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
    }
}