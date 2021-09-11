
namespace smshatirlatma.UI.Modules.Musteri
{
    partial class BorcEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorcEkleForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.OdemeTutar = new DevExpress.XtraEditors.LabelControl();
            this.KisiBorcTutar = new DevExpress.XtraEditors.LabelControl();
            this.KisiAdLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.simpleButton4);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(279, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(590, 480);
            this.panelControl1.TabIndex = 25;
            this.panelControl1.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Top;
            this.labelControl2.Location = new System.Drawing.Point(33, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(132, 37);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Kişi Seçin";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(488, 5);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(97, 37);
            this.simpleButton4.TabIndex = 1;
            this.simpleButton4.Text = "İptal";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.simpleButton3.Appearance.BackColor2 = System.Drawing.Color.Gray;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton3.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(368, 5);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(102, 37);
            this.simpleButton3.TabIndex = 1;
            this.simpleButton3.Text = "Seç";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(10, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(569, 426);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(121, 233);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(113, 64);
            this.simpleButton2.TabIndex = 23;
            this.simpleButton2.Text = "Borç Ekle";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 233);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(85, 64);
            this.simpleButton1.TabIndex = 24;
            this.simpleButton1.Text = "İptal";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // OdemeTutar
            // 
            this.OdemeTutar.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.OdemeTutar.Appearance.ForeColor = System.Drawing.Color.SlateBlue;
            this.OdemeTutar.Appearance.Options.UseFont = true;
            this.OdemeTutar.Appearance.Options.UseForeColor = true;
            this.OdemeTutar.Location = new System.Drawing.Point(10, 178);
            this.OdemeTutar.Name = "OdemeTutar";
            this.OdemeTutar.Size = new System.Drawing.Size(78, 16);
            this.OdemeTutar.TabIndex = 19;
            this.OdemeTutar.Text = "BORÇ TUTARI";
            // 
            // KisiBorcTutar
            // 
            this.KisiBorcTutar.Location = new System.Drawing.Point(10, 145);
            this.KisiBorcTutar.Name = "KisiBorcTutar";
            this.KisiBorcTutar.Size = new System.Drawing.Size(28, 13);
            this.KisiBorcTutar.TabIndex = 20;
            this.KisiBorcTutar.Text = "BORÇ";
            // 
            // KisiAdLabel
            // 
            this.KisiAdLabel.Location = new System.Drawing.Point(10, 102);
            this.KisiAdLabel.Name = "KisiAdLabel";
            this.KisiAdLabel.Size = new System.Drawing.Size(14, 13);
            this.KisiAdLabel.TabIndex = 21;
            this.KisiAdLabel.Text = "AD";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(101, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Veresiye Ekleme ";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(91, 175);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.BeepOnError = false;
            this.textEdit3.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textEdit3.Properties.MaskSettings.Set("mask", "c");
            this.textEdit3.Size = new System.Drawing.Size(100, 20);
            this.textEdit3.TabIndex = 16;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(91, 142);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.BeepOnError = false;
            this.textEdit2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textEdit2.Properties.MaskSettings.Set("mask", "c");
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 17;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(91, 99);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 18;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(197, 96);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(75, 23);
            this.simpleButton6.TabIndex = 26;
            this.simpleButton6.Text = "Kişileri Getir";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // BorcEkleForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Goldenrod;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 497);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.OdemeTutar);
            this.Controls.Add(this.KisiBorcTutar);
            this.Controls.Add(this.KisiAdLabel);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.simpleButton6);
            this.Name = "BorcEkleForm";
            this.Text = "BorcEkleForm";
            this.Load += new System.EventHandler(this.BorcEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl OdemeTutar;
        private DevExpress.XtraEditors.LabelControl KisiBorcTutar;
        private DevExpress.XtraEditors.LabelControl KisiAdLabel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}