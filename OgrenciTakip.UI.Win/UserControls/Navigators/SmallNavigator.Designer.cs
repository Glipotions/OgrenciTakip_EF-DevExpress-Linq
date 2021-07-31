
namespace OgrenciTakip.UI.Win.UserControls.Navigators
{
	partial class SmallNavigator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmallNavigator));
			this.Navigator = new DevExpress.XtraEditors.ControlNavigator();
			this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
			((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
			this.SuspendLayout();
			// 
			// Navigator
			// 
			this.Navigator.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Navigator.Appearance.Options.UseForeColor = true;
			this.Navigator.Buttons.Append.Visible = false;
			this.Navigator.Buttons.CancelEdit.Visible = false;
			this.Navigator.Buttons.Edit.Visible = false;
			this.Navigator.Buttons.EndEdit.Visible = false;
			this.Navigator.Buttons.First.ImageIndex = 0;
			this.Navigator.Buttons.ImageList = this.imageCollection;
			this.Navigator.Buttons.Last.ImageIndex = 3;
			this.Navigator.Buttons.Next.ImageIndex = 2;
			this.Navigator.Buttons.NextPage.Visible = false;
			this.Navigator.Buttons.Prev.ImageIndex = 1;
			this.Navigator.Buttons.PrevPage.Visible = false;
			this.Navigator.Buttons.Remove.Visible = false;
			this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Navigator.Location = new System.Drawing.Point(0, 0);
			this.Navigator.Name = "Navigator";
			this.Navigator.Size = new System.Drawing.Size(512, 24);
			this.Navigator.TabIndex = 0;
			this.Navigator.Text = "controlNavigator1";
			this.Navigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
			this.Navigator.TextStringFormat = "Kartlar ( {0} / {1} )";
			// 
			// imageCollection
			// 
			this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
			this.imageCollection.Images.SetKeyName(0, "first_16x16.png");
			this.imageCollection.Images.SetKeyName(1, "prev_16x16.png");
			this.imageCollection.Images.SetKeyName(2, "next_16x16.png");
			this.imageCollection.Images.SetKeyName(3, "last_16x16.png");
			// 
			// SmallNavigator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Navigator);
			this.Name = "SmallNavigator";
			this.Size = new System.Drawing.Size(512, 24);
			((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.ControlNavigator Navigator;
		private DevExpress.Utils.ImageCollection imageCollection;
	}
}
