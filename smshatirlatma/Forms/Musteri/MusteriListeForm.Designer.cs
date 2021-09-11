
namespace smshatirlatma.Forms.Musteri
{
    partial class MusteriListeForm
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
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling2 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling3 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriListeForm));
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.spellChecker1 = new DevExpress.XtraSpellChecker.SpellChecker(this.components);
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimeOffsetEdit1 = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(51, 26);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.spellChecker1.SetShowSpellCheckMenu(this.textEdit1, true);
            this.textEdit1.Size = new System.Drawing.Size(190, 20);
            this.spellChecker1.SetSpellCheckerOptions(this.textEdit1, optionsSpelling1);
            this.textEdit1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(247, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Müşteri Seç";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(247, 62);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Gözlük Seç";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(51, 65);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.spellChecker1.SetShowSpellCheckMenu(this.textEdit2, true);
            this.textEdit2.Size = new System.Drawing.Size(190, 20);
            this.spellChecker1.SetSpellCheckerOptions(this.textEdit2, optionsSpelling2);
            this.textEdit2.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, 17);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(714, 360);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(51, 229);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "SMS Bilgilendirmesi";
            this.checkEdit1.Size = new System.Drawing.Size(190, 19);
            this.checkEdit1.TabIndex = 6;
            // 
            // spellChecker1
            // 
            this.spellChecker1.Culture = new System.Globalization.CultureInfo("tr-TR");
            this.spellChecker1.ParentContainer = null;
            // 
            // textEdit4
            // 
            this.textEdit4.EditValue = 0;
            this.textEdit4.Location = new System.Drawing.Point(51, 145);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.BeepOnError = false;
            this.textEdit4.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textEdit4.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.textEdit4.Properties.MaskSettings.Set("mask", "c");
            this.spellChecker1.SetShowSpellCheckMenu(this.textEdit4, true);
            this.textEdit4.Size = new System.Drawing.Size(190, 20);
            this.spellChecker1.SetSpellCheckerOptions(this.textEdit4, optionsSpelling3);
            this.textEdit4.TabIndex = 8;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton6);
            this.panelControl1.Controls.Add(this.simpleButton5);
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(481, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(895, 466);
            this.panelControl1.TabIndex = 7;
            this.panelControl1.Visible = false;
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(725, 94);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(75, 56);
            this.simpleButton6.TabIndex = 5;
            this.simpleButton6.Text = "İptal";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(725, 17);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 56);
            this.simpleButton5.TabIndex = 5;
            this.simpleButton5.Text = "Seç";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // dateTimeOffsetEdit1
            // 
            this.dateTimeOffsetEdit1.EditValue = new System.DateTime(2021, 6, 27, 23, 49, 52, 748);
            this.dateTimeOffsetEdit1.Location = new System.Drawing.Point(51, 185);
            this.dateTimeOffsetEdit1.Name = "dateTimeOffsetEdit1";
            this.dateTimeOffsetEdit1.Properties.BeepOnError = false;
            this.dateTimeOffsetEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeOffsetEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTimeOffsetEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTimeOffsetEdit1.Properties.MaskSettings.Set("mask", "g");
            this.dateTimeOffsetEdit1.Properties.NullText = "Tarih Seç";
            this.dateTimeOffsetEdit1.Properties.Tag = new System.DateTime(2021, 5, 29, 19, 45, 29, 480);
            this.dateTimeOffsetEdit1.Size = new System.Drawing.Size(190, 20);
            this.dateTimeOffsetEdit1.TabIndex = 5;
            this.dateTimeOffsetEdit1.EditValueChanged += new System.EventHandler(this.dateTimeOffsetEdit1_EditValueChanged);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Enabled = false;
            this.simpleButton3.Location = new System.Drawing.Point(247, 106);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Ödeme Şekli";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Enabled = false;
            this.simpleButton4.Location = new System.Drawing.Point(247, 143);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Fiyat";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.EditValue = "";
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(51, 103);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Peşin",
            "Borç"});
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(190, 20);
            this.checkedComboBoxEdit1.TabIndex = 9;
            // 
            // simpleButton7
            // 
            this.simpleButton7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton7.ImageOptions.SvgImage")));
            this.simpleButton7.Location = new System.Drawing.Point(51, 255);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(190, 37);
            this.simpleButton7.TabIndex = 10;
            this.simpleButton7.Text = "Satış Yap";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // MusteriListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 376);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.dateTimeOffsetEdit1);
            this.Controls.Add(this.checkedComboBoxEdit1);
            this.Name = "MusteriListeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriListeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MusteriListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraSpellChecker.SpellChecker spellChecker1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dateTimeOffsetEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.ComboBoxEdit checkedComboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
    }
}