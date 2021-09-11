
namespace smshatirlatma.UI.Modules.Sms
{
    partial class ucSmsGonder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSmsGonder));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SmsEkle = new DevExpress.XtraEditors.SimpleButton();
            this.SmsTopluEkle = new DevExpress.XtraEditors.SimpleButton();
            this.SmsCikar = new DevExpress.XtraEditors.SimpleButton();
            this.SmsTopluCikar = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(7, 156);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(523, 447);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "SMS GÖNDERİLECEKLER";
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Mesaj";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(67, 92);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "SADECE MESAJ",
            "KİŞİYE ÖZEL MESAJ"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(161, 20);
            this.comboBoxEdit1.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Seçim";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(17, 61);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(528, 447);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupPanelText = "MÜŞTERİLER";
            this.gridView2.Name = "gridView2";
            // 
            // SmsEkle
            // 
            this.SmsEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SmsEkle.ImageOptions.SvgImage")));
            this.SmsEkle.Location = new System.Drawing.Point(17, 17);
            this.SmsEkle.Name = "SmsEkle";
            this.SmsEkle.Size = new System.Drawing.Size(75, 38);
            this.SmsEkle.TabIndex = 9;
            this.SmsEkle.Text = "Ekle";
            this.SmsEkle.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // SmsTopluEkle
            // 
            this.SmsTopluEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SmsTopluEkle.ImageOptions.SvgImage")));
            this.SmsTopluEkle.Location = new System.Drawing.Point(128, 17);
            this.SmsTopluEkle.Name = "SmsTopluEkle";
            this.SmsTopluEkle.Size = new System.Drawing.Size(114, 38);
            this.SmsTopluEkle.TabIndex = 9;
            this.SmsTopluEkle.Text = "Hepsini ekle";
            this.SmsTopluEkle.Click += new System.EventHandler(this.SmsTopluEkle_Click);
            // 
            // SmsCikar
            // 
            this.SmsCikar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SmsCikar.ImageOptions.SvgImage")));
            this.SmsCikar.Location = new System.Drawing.Point(439, 112);
            this.SmsCikar.Name = "SmsCikar";
            this.SmsCikar.Size = new System.Drawing.Size(91, 38);
            this.SmsCikar.TabIndex = 9;
            this.SmsCikar.Text = "Çıkar";
            this.SmsCikar.Click += new System.EventHandler(this.SmsCikar_Click);
            // 
            // SmsTopluCikar
            // 
            this.SmsTopluCikar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SmsTopluCikar.ImageOptions.SvgImage")));
            this.SmsTopluCikar.Location = new System.Drawing.Point(312, 112);
            this.SmsTopluCikar.Name = "SmsTopluCikar";
            this.SmsTopluCikar.Size = new System.Drawing.Size(112, 38);
            this.SmsTopluCikar.TabIndex = 9;
            this.SmsTopluCikar.Text = "Hepsini Çıkar";
            this.SmsTopluCikar.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(67, 15);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(274, 71);
            this.memoEdit1.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(358, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(141, 47);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Onayla";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(516, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 47);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "İptal";
            this.simpleButton2.Visible = false;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.SmsTopluEkle);
            this.panelControl1.Controls.Add(this.gridControl2);
            this.panelControl1.Controls.Add(this.SmsEkle);
            this.panelControl1.Location = new System.Drawing.Point(573, 95);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(565, 564);
            this.panelControl1.TabIndex = 12;
            // 
            // ucSmsGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.SmsTopluCikar);
            this.Controls.Add(this.SmsCikar);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "ucSmsGonder";
            this.Size = new System.Drawing.Size(1138, 943);
            this.Load += new System.EventHandler(this.ucSmsGonder_Load);
            this.VisibleChanged += new System.EventHandler(this.ucSmsGonder_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton SmsEkle;
        private DevExpress.XtraEditors.SimpleButton SmsTopluEkle;
        private DevExpress.XtraEditors.SimpleButton SmsCikar;
        private DevExpress.XtraEditors.SimpleButton SmsTopluCikar;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
