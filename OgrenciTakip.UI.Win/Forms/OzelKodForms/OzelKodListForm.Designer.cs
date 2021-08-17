﻿
namespace OgrenciTakip.UI.Win.Forms.OzelKodForms
{
	partial class OzelKodListForm
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
			this.longNavigator1 = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
			this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
			this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
			this.colId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
			this.colKod = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
			this.colOzelKodAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
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
			this.ribbonControl.Size = new System.Drawing.Size(1088, 109);
			this.ribbonControl.Toolbar.ShowCustomizeItem = false;
			// 
			// btnGonder
			// 
			this.btnGonder.ImageOptions.Image = global::OgrenciTakip.UI.Win.Properties.Resources.export_16x16;
			this.btnGonder.ImageOptions.LargeImage = global::OgrenciTakip.UI.Win.Properties.Resources.export_32x32;
			// 
			// longNavigator1
			// 
			this.longNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.longNavigator1.Location = new System.Drawing.Point(0, 513);
			this.longNavigator1.Name = "longNavigator1";
			this.longNavigator1.Size = new System.Drawing.Size(1088, 24);
			this.longNavigator1.TabIndex = 2;
			// 
			// grid
			// 
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.Location = new System.Drawing.Point(0, 109);
			this.grid.MainView = this.tablo;
			this.grid.MenuManager = this.ribbonControl;
			this.grid.Name = "grid";
			this.grid.Size = new System.Drawing.Size(1088, 404);
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
            this.colId,
            this.colKod,
            this.colOzelKodAdi});
			this.tablo.GridControl = this.grid;
			this.tablo.Name = "tablo";
			this.tablo.OptionsMenu.EnableColumnMenu = false;
			this.tablo.OptionsMenu.EnableFooterMenu = false;
			this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
			this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
			this.tablo.OptionsPrint.AutoWidth = false;
			this.tablo.OptionsPrint.PrintFooter = false;
			this.tablo.OptionsPrint.PrintGroupFooter = false;
			this.tablo.OptionsView.ColumnAutoWidth = false;
			this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
			this.tablo.OptionsView.RowAutoHeight = true;
			this.tablo.OptionsView.ShowAutoFilterRow = true;
			this.tablo.OptionsView.ShowGroupPanel = false;
			this.tablo.OptionsView.ShowViewCaption = true;
			this.tablo.StatusBarAciklama = null;
			this.tablo.StatusBarKisayol = null;
			this.tablo.StatusBarKisayolAciklama = null;
			this.tablo.ViewCaption = "Özel Kod Kartları";
			// 
			// colId
			// 
			this.colId.Caption = "Id";
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			this.colId.OptionsColumn.AllowEdit = false;
			this.colId.OptionsColumn.ShowInCustomizationForm = false;
			this.colId.StatusBarAciklama = null;
			this.colId.StatusBarKisayol = null;
			this.colId.StatusBarKisayolAciklama = null;
			// 
			// colKod
			// 
			this.colKod.AppearanceCell.Options.UseTextOptions = true;
			this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKod.Caption = "Kod";
			this.colKod.FieldName = "Kod";
			this.colKod.Name = "colKod";
			this.colKod.OptionsColumn.AllowEdit = false;
			this.colKod.StatusBarAciklama = null;
			this.colKod.StatusBarKisayol = null;
			this.colKod.StatusBarKisayolAciklama = null;
			this.colKod.Visible = true;
			this.colKod.VisibleIndex = 0;
			// 
			// colOzelKodAdi
			// 
			this.colOzelKodAdi.Caption = "Özel Kod Adı";
			this.colOzelKodAdi.FieldName = "OzelKodAdi";
			this.colOzelKodAdi.Name = "colOzelKodAdi";
			this.colOzelKodAdi.OptionsColumn.AllowEdit = false;
			this.colOzelKodAdi.StatusBarAciklama = null;
			this.colOzelKodAdi.StatusBarKisayol = null;
			this.colOzelKodAdi.StatusBarKisayolAciklama = null;
			this.colOzelKodAdi.Visible = true;
			this.colOzelKodAdi.VisibleIndex = 1;
			this.colOzelKodAdi.Width = 508;
			// 
			// OzelKodListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1088, 561);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.longNavigator1);
			this.IconOptions.ShowIcon = false;
			this.Name = "OzelKodListForm";
			this.Text = "Özel Kod Kartları";
			this.Controls.SetChildIndex(this.ribbonControl, 0);
			this.Controls.SetChildIndex(this.longNavigator1, 0);
			this.Controls.SetChildIndex(this.grid, 0);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Grid.MyGridColumn colOzelKodAdi;
    }
}