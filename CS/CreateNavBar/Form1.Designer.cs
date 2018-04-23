namespace CreateNavBar {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("settings_32x32.png", "images/edit/customization_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/customization_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "settings_32x32.png");
            this.imageCollection1.InsertGalleryImage("export_32x32.png", "images/export/export_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/export_32x32.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "export_32x32.png");
            this.imageCollection1.InsertGalleryImage("find_32x32.png", "images/find/find_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/find/find_32x32.png"), 2);
            this.imageCollection1.Images.SetKeyName(2, "find_32x32.png");
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxControl1.Location = new System.Drawing.Point(381, 0);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(207, 406);
            this.listBoxControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(588, 406);
            this.Controls.Add(this.listBoxControl1);
            this.Name = "Form1";
            this.Text = "NavBarControl Runtime Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
    }
}

