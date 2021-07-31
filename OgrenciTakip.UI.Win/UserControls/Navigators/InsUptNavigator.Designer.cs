
namespace OgrenciTakip.UI.Win.UserControls.Navigators
{
	partial class Navigator
	{
		/// <summary> 
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Bileşen Tasarımcısı üretimi kod

		/// <summary> 
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navigator));
			this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
			this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
			((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
			this.SuspendLayout();
			// 
			// controlNavigator1
			// 
			this.controlNavigator1.Buttons.Append.ImageIndex = 6;
			this.controlNavigator1.Buttons.CancelEdit.Visible = false;
			this.controlNavigator1.Buttons.Edit.Visible = false;
			this.controlNavigator1.Buttons.EndEdit.Visible = false;
			this.controlNavigator1.Buttons.First.ImageIndex = 0;
			this.controlNavigator1.Buttons.ImageList = this.imageCollection;
			this.controlNavigator1.Buttons.Last.ImageIndex = 5;
			this.controlNavigator1.Buttons.Next.ImageIndex = 3;
			this.controlNavigator1.Buttons.NextPage.Visible = false;
			this.controlNavigator1.Buttons.Prev.ImageIndex = 2;
			this.controlNavigator1.Buttons.PrevPage.Visible = false;
			this.controlNavigator1.Buttons.Remove.ImageIndex = 7;
			this.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.controlNavigator1.Location = new System.Drawing.Point(0, 0);
			this.controlNavigator1.Name = "controlNavigator1";
			this.controlNavigator1.Size = new System.Drawing.Size(618, 24);
			this.controlNavigator1.TabIndex = 0;
			this.controlNavigator1.Text = "controlNavigator1";
			// 
			// imageCollection
			// 
			this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
			this.imageCollection.Images.SetKeyName(0, "first_16x16.png");
			this.imageCollection.Images.SetKeyName(1, "doubleprev_16x16.png");
			this.imageCollection.Images.SetKeyName(2, "prev_16x16.png");
			this.imageCollection.Images.SetKeyName(3, "next_16x16.png");
			this.imageCollection.Images.SetKeyName(4, "doublenext_16x16.png");
			this.imageCollection.Images.SetKeyName(5, "last_16x16.png");
			this.imageCollection.InsertImage(global::OgrenciTakip.UI.Win.Properties.Resources.addfile_16x16, "addfile_16x16", typeof(global::OgrenciTakip.UI.Win.Properties.Resources), 6);
			this.imageCollection.Images.SetKeyName(6, "addfile_16x16");
			this.imageCollection.InsertImage(global::OgrenciTakip.UI.Win.Properties.Resources.deletelist_16x16, "deletelist_16x16", typeof(global::OgrenciTakip.UI.Win.Properties.Resources), 7);
			this.imageCollection.Images.SetKeyName(7, "deletelist_16x16");
			// 
			// Navigator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.controlNavigator1);
			this.Name = "Navigator";
			this.Size = new System.Drawing.Size(618, 24);
			((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
		private DevExpress.Utils.ImageCollection imageCollection;
	}
}
