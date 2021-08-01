
namespace OgrenciTakip.UI.Win.Forms.FiltreForms
{
	partial class FiltreEditForm
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
			DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
			DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
			DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
			DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
			DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
			this.myDataLayoutControl = new OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
			this.txtFiltreMetni = new OgrenciTakip.UI.Win.UserControls.Controls.MyFilterControl();
			this.txtFiltreAdi = new OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
			this.txtKod = new OgrenciTakip.UI.Win.UserControls.Controls.MyCodeTextEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
			this.myDataLayoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtFiltreAdi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl
			// 
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			// 
			// 
			// 
			this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
			this.ribbonControl.SearchEditItem.EditWidth = 150;
			this.ribbonControl.SearchEditItem.Id = -5000;
			this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
			this.ribbonControl.Size = new System.Drawing.Size(468, 109);
			this.ribbonControl.Toolbar.ShowCustomizeItem = false;
			// 
			// myDataLayoutControl
			// 
			this.myDataLayoutControl.Controls.Add(this.txtFiltreMetni);
			this.myDataLayoutControl.Controls.Add(this.txtFiltreAdi);
			this.myDataLayoutControl.Controls.Add(this.txtKod);
			this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
			this.myDataLayoutControl.Name = "myDataLayoutControl";
			this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
			this.myDataLayoutControl.Root = this.Root;
			this.myDataLayoutControl.Size = new System.Drawing.Size(468, 186);
			this.myDataLayoutControl.TabIndex = 0;
			this.myDataLayoutControl.Text = "myDataLayoutControl1";
			// 
			// txtFiltreMetni
			// 
			this.txtFiltreMetni.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtFiltreMetni.Location = new System.Drawing.Point(77, 60);
			this.txtFiltreMetni.Name = "txtFiltreMetni";
			this.txtFiltreMetni.ShowGroupCommandsIcon = true;
			this.txtFiltreMetni.Size = new System.Drawing.Size(379, 114);
			this.txtFiltreMetni.StatusBarAciklama = "Filtre Metni Giriniz..";
			this.txtFiltreMetni.TabIndex = 2;
			this.txtFiltreMetni.Text = "myFilterControl1";
			// 
			// txtFiltreAdi
			// 
			this.txtFiltreAdi.Location = new System.Drawing.Point(77, 36);
			this.txtFiltreAdi.MenuManager = this.ribbonControl;
			this.txtFiltreAdi.Name = "txtFiltreAdi";
			this.txtFiltreAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
			this.txtFiltreAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
			this.txtFiltreAdi.Properties.MaxLength = 50;
			this.txtFiltreAdi.Size = new System.Drawing.Size(379, 20);
			this.txtFiltreAdi.StatusBarAciklama = "Filtre Adı Giriniz.";
			this.txtFiltreAdi.StyleController = this.myDataLayoutControl;
			this.txtFiltreAdi.TabIndex = 1;
			// 
			// txtKod
			// 
			this.txtKod.Location = new System.Drawing.Point(77, 12);
			this.txtKod.MenuManager = this.ribbonControl;
			this.txtKod.Name = "txtKod";
			this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.txtKod.Properties.Appearance.Options.UseBackColor = true;
			this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
			this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
			this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
			this.txtKod.Properties.MaxLength = 20;
			this.txtKod.Size = new System.Drawing.Size(131, 20);
			this.txtKod.StatusBarAciklama = "Kod Alanı..";
			this.txtKod.StyleController = this.myDataLayoutControl;
			this.txtKod.TabIndex = 0;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
			this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
			this.Root.Name = "Root";
			columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
			columnDefinition3.Width = 200D;
			columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
			columnDefinition4.Width = 100D;
			this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition3,
            columnDefinition4});
			rowDefinition4.Height = 24D;
			rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
			rowDefinition5.Height = 24D;
			rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
			rowDefinition6.Height = 100D;
			rowDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
			this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition4,
            rowDefinition5,
            rowDefinition6});
			this.Root.Size = new System.Drawing.Size(468, 186);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
			this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
			this.layoutControlItem1.Control = this.txtKod;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
			this.layoutControlItem1.Text = "Kod";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(53, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
			this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
			this.layoutControlItem2.Control = this.txtFiltreAdi;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 2;
			this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
			this.layoutControlItem2.Size = new System.Drawing.Size(448, 24);
			this.layoutControlItem2.Text = "Filtre Adı";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(53, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
			this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
			this.layoutControlItem3.Control = this.txtFiltreMetni;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 2;
			this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
			this.layoutControlItem3.Size = new System.Drawing.Size(448, 118);
			this.layoutControlItem3.Text = "Filtre Metni";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(53, 13);
			// 
			// FiltreEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(468, 319);
			this.Controls.Add(this.myDataLayoutControl);
			this.IconOptions.ShowIcon = false;
			this.MinimumSize = new System.Drawing.Size(470, 320);
			this.Name = "FiltreEditForm";
			this.Text = "Filtre Kartı";
			this.Controls.SetChildIndex(this.ribbonControl, 0);
			this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
			this.myDataLayoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtFiltreAdi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
		private UserControls.Controls.MyFilterControl txtFiltreMetni;
		private UserControls.Controls.MyTextEdit txtFiltreAdi;
		private UserControls.Controls.MyCodeTextEdit txtKod;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
	}
}