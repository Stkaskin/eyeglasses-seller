
namespace smshatirlatma.Forms.Musteri
{
    partial class MusteriEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkleForm));
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.MusteriEkleFormlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textEdit3item = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit2item = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1item = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriEkleFormlayoutControl1ConvertedLayout)).BeginInit();
            this.MusteriEkleFormlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton1item)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(63, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(184, 20);
            this.textEdit1.StyleController = this.MusteriEkleFormlayoutControl1ConvertedLayout;
            this.textEdit1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 84);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(235, 38);
            this.simpleButton1.StyleController = this.MusteriEkleFormlayoutControl1ConvertedLayout;
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(63, 36);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.BeepOnError = false;
            this.textEdit2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.textEdit2.Properties.MaskSettings.Set("mask", "0\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.textEdit2.Size = new System.Drawing.Size(184, 20);
            this.textEdit2.StyleController = this.MusteriEkleFormlayoutControl1ConvertedLayout;
            this.textEdit2.TabIndex = 0;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(63, 60);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(184, 20);
            this.textEdit3.StyleController = this.MusteriEkleFormlayoutControl1ConvertedLayout;
            this.textEdit3.TabIndex = 0;
            this.textEdit3.Visible = false;
            // 
            // MusteriEkleFormlayoutControl1ConvertedLayout
            // 
            this.MusteriEkleFormlayoutControl1ConvertedLayout.Controls.Add(this.textEdit3);
            this.MusteriEkleFormlayoutControl1ConvertedLayout.Controls.Add(this.textEdit2);
            this.MusteriEkleFormlayoutControl1ConvertedLayout.Controls.Add(this.textEdit1);
            this.MusteriEkleFormlayoutControl1ConvertedLayout.Controls.Add(this.simpleButton1);
            this.MusteriEkleFormlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MusteriEkleFormlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.MusteriEkleFormlayoutControl1ConvertedLayout.Name = "MusteriEkleFormlayoutControl1ConvertedLayout";
            this.MusteriEkleFormlayoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(311, 0, 650, 400);
            this.MusteriEkleFormlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.MusteriEkleFormlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(259, 189);
            this.MusteriEkleFormlayoutControl1ConvertedLayout.TabIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.textEdit3item,
            this.textEdit2item,
            this.textEdit1item,
            this.simpleButton1item});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(259, 189);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // textEdit3item
            // 
            this.textEdit3item.Control = this.textEdit3;
            this.textEdit3item.Location = new System.Drawing.Point(0, 48);
            this.textEdit3item.Name = "textEdit3item";
            this.textEdit3item.Size = new System.Drawing.Size(239, 24);
            this.textEdit3item.Text = "Adres";
            this.textEdit3item.TextLocation = DevExpress.Utils.Locations.Left;
            this.textEdit3item.TextSize = new System.Drawing.Size(47, 13);
            // 
            // textEdit2item
            // 
            this.textEdit2item.Control = this.textEdit2;
            this.textEdit2item.Location = new System.Drawing.Point(0, 24);
            this.textEdit2item.Name = "textEdit2item";
            this.textEdit2item.Size = new System.Drawing.Size(239, 24);
            this.textEdit2item.Text = "Telefon";
            this.textEdit2item.TextLocation = DevExpress.Utils.Locations.Left;
            this.textEdit2item.TextSize = new System.Drawing.Size(47, 13);
            // 
            // textEdit1item
            // 
            this.textEdit1item.Control = this.textEdit1;
            this.textEdit1item.Location = new System.Drawing.Point(0, 0);
            this.textEdit1item.Name = "textEdit1item";
            this.textEdit1item.Size = new System.Drawing.Size(239, 24);
            this.textEdit1item.Text = "AD Soyad";
            this.textEdit1item.TextLocation = DevExpress.Utils.Locations.Left;
            this.textEdit1item.TextSize = new System.Drawing.Size(47, 13);
            // 
            // simpleButton1item
            // 
            this.simpleButton1item.Control = this.simpleButton1;
            this.simpleButton1item.Location = new System.Drawing.Point(0, 72);
            this.simpleButton1item.Name = "simpleButton1item";
            this.simpleButton1item.Size = new System.Drawing.Size(239, 97);
            this.simpleButton1item.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButton1item.TextVisible = false;
            // 
            // MusteriEkleForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 189);
            this.Controls.Add(this.MusteriEkleFormlayoutControl1ConvertedLayout);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MusteriEkleForm.IconOptions.LargeImage")));
            this.Name = "MusteriEkleForm";
            this.Text = "MusteriSilForm";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriEkleFormlayoutControl1ConvertedLayout)).EndInit();
            this.MusteriEkleFormlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton1item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraLayout.LayoutControl MusteriEkleFormlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem textEdit3item;
        private DevExpress.XtraLayout.LayoutControlItem textEdit2item;
        private DevExpress.XtraLayout.LayoutControlItem textEdit1item;
        private DevExpress.XtraLayout.LayoutControlItem simpleButton1item;
    }
}