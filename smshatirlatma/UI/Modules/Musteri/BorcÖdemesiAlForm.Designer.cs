
namespace smshatirlatma.UI.Modules.Musteri
{
    partial class BorcÖdemesiAlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorcÖdemesiAlForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.KisiAdLabel = new DevExpress.XtraEditors.LabelControl();
            this.KisiBorcTutar = new DevExpress.XtraEditors.LabelControl();
            this.OdemeTutar = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
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
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.simpleButton5);
            this.panelControl1.Controls.Add(this.simpleButton7);
            this.panelControl1.Location = new System.Drawing.Point(416, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(894, 408);
            this.panelControl1.TabIndex = 14;
            this.panelControl1.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(513, 356);
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
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(181, 4);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(97, 37);
            this.simpleButton5.TabIndex = 28;
            this.simpleButton5.Text = "İptal";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.simpleButton7.Appearance.BackColor2 = System.Drawing.Color.Gray;
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton7.Appearance.Options.UseBackColor = true;
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton7.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton7.ImageOptions.Image")));
            this.simpleButton7.Location = new System.Drawing.Point(5, 4);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(121, 37);
            this.simpleButton7.TabIndex = 29;
            this.simpleButton7.Text = "Seç";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(132, 181);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(174, 43);
            this.simpleButton2.TabIndex = 12;
            this.simpleButton2.Text = "Ödeme Al";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 181);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(97, 43);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "İptal";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(105, 105);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.BeepOnError = false;
            this.textEdit3.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textEdit3.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.textEdit3.Properties.MaskSettings.Set("mask", "c");
            this.textEdit3.Size = new System.Drawing.Size(167, 20);
            this.textEdit3.TabIndex = 5;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(105, 72);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(167, 20);
            this.textEdit2.TabIndex = 6;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(105, 29);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(167, 20);
            this.textEdit1.TabIndex = 7;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(277, 27);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(82, 22);
            this.simpleButton6.TabIndex = 15;
            this.simpleButton6.Text = "Kişileri Getir";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // KisiAdLabel
            // 
            this.KisiAdLabel.Location = new System.Drawing.Point(13, 32);
            this.KisiAdLabel.Name = "KisiAdLabel";
            this.KisiAdLabel.Size = new System.Drawing.Size(14, 13);
            this.KisiAdLabel.TabIndex = 10;
            this.KisiAdLabel.Text = "AD";
            // 
            // KisiBorcTutar
            // 
            this.KisiBorcTutar.Location = new System.Drawing.Point(13, 75);
            this.KisiBorcTutar.Name = "KisiBorcTutar";
            this.KisiBorcTutar.Size = new System.Drawing.Size(28, 13);
            this.KisiBorcTutar.TabIndex = 9;
            this.KisiBorcTutar.Text = "BORÇ";
            // 
            // OdemeTutar
            // 
            this.OdemeTutar.Location = new System.Drawing.Point(13, 108);
            this.OdemeTutar.Name = "OdemeTutar";
            this.OdemeTutar.Size = new System.Drawing.Size(75, 13);
            this.OdemeTutar.TabIndex = 8;
            this.OdemeTutar.Text = "ÖDEME TUTARI";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Top;
            this.labelControl2.Location = new System.Drawing.Point(433, 416);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(132, 37);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Kişi Seçin";
            // 
            // BorcÖdemesiAlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 483);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.OdemeTutar);
            this.Controls.Add(this.KisiBorcTutar);
            this.Controls.Add(this.KisiAdLabel);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.simpleButton6);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BorcÖdemesiAlForm.IconOptions.LargeImage")));
            this.Name = "BorcÖdemesiAlForm";
            this.Text = "BorcÖdemesiAlForm";
            this.Load += new System.EventHandler(this.BorcÖdemesiAlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.LabelControl KisiAdLabel;
        private DevExpress.XtraEditors.LabelControl KisiBorcTutar;
        private DevExpress.XtraEditors.LabelControl OdemeTutar;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}