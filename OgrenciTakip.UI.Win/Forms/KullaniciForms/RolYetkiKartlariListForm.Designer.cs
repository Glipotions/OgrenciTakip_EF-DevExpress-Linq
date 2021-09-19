
namespace OgrenciTakip.UI.Win.Forms.KullaniciForms
{
	partial class RolYetkiKartlariListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolYetkiKartlariListForm));
			this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
			this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
			this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
			this.colKartTuru = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sagTikMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 576);
			this.ribbonStatusBar1.Size = new System.Drawing.Size(573, 24);
			// 
			// ribbonControl
			// 
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.OptionsPageCategories.ShowCaptions = false;
			// 
			// 
			// 
			this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
			this.ribbonControl.SearchEditItem.EditWidth = 150;
			this.ribbonControl.SearchEditItem.Id = -5000;
			this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
			this.ribbonControl.Size = new System.Drawing.Size(573, 109);
			this.ribbonControl.Toolbar.ShowCustomizeItem = false;
			// 
			// btnExcelDosyalari
			// 
			this.btnExcelDosyalari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelDosyalari.ImageOptions.Image")));
			// 
			// longNavigator1
			// 
			this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.longNavigator.Location = new System.Drawing.Point(0, 552);
			this.longNavigator.Name = "longNavigator1";
			this.longNavigator.Size = new System.Drawing.Size(573, 24);
			this.longNavigator.TabIndex = 2;
			// 
			// grid
			// 
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.Location = new System.Drawing.Point(0, 109);
			this.grid.MainView = this.tablo;
			this.grid.MenuManager = this.ribbonControl;
			this.grid.Name = "grid";
			this.grid.Size = new System.Drawing.Size(573, 443);
			this.grid.TabIndex = 3;
			this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
			// 
			// tablo
			// 
			this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
			this.tablo.Appearance.FooterPanel.Options.UseFont = true;
			this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
			this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
			this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
			this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
			this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
			this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKartTuru});
			this.tablo.GridControl = this.grid;
			this.tablo.Name = "tablo";
			this.tablo.OptionsMenu.EnableColumnMenu = false;
			this.tablo.OptionsMenu.EnableFooterMenu = false;
			this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
			this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
			this.tablo.OptionsPrint.AutoWidth = false;
			this.tablo.OptionsPrint.PrintFooter = false;
			this.tablo.OptionsPrint.PrintGroupFooter = false;
			this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
			this.tablo.OptionsView.RowAutoHeight = true;
			this.tablo.OptionsView.ShowAutoFilterRow = true;
			this.tablo.OptionsView.ShowGroupPanel = false;
			this.tablo.OptionsView.ShowViewCaption = true;
			this.tablo.StatusBarAciklama = null;
			this.tablo.StatusBarKisayol = null;
			this.tablo.StatusBarKisayolAciklama = null;
			this.tablo.ViewCaption = "Yetki Kartları";
			// 
			// colKartTuru
			// 
			this.colKartTuru.Caption = "Kart Türü";
			this.colKartTuru.FieldName = "KartTuru";
			this.colKartTuru.Name = "colKartTuru";
			this.colKartTuru.OptionsColumn.AllowEdit = false;
			this.colKartTuru.StatusBarAciklama = null;
			this.colKartTuru.StatusBarKisayol = null;
			this.colKartTuru.StatusBarKisayolAciklama = null;
			this.colKartTuru.Visible = true;
			this.colKartTuru.VisibleIndex = 0;
			// 
			// RolYetkiKartlariListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 600);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.longNavigator);
			this.IconOptions.ShowIcon = false;
			this.Name = "RolYetkiKartlariListForm";
			this.Text = "Yetki Kartları";
			this.Controls.SetChildIndex(this.ribbonControl, 0);
			this.Controls.SetChildIndex(this.ribbonStatusBar1, 0);
			this.Controls.SetChildIndex(this.longNavigator, 0);
			this.Controls.SetChildIndex(this.grid, 0);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sagTikMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colKartTuru;
    }
}