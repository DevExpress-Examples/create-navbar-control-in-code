Imports Microsoft.VisualBasic
Imports System
Namespace CreateNavBar
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.InsertGalleryImage("settings_32x32.png", "images/edit/customization_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/customization_32x32.png"), 0)
			Me.imageCollection1.Images.SetKeyName(0, "settings_32x32.png")
			Me.imageCollection1.InsertGalleryImage("export_32x32.png", "images/export/export_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/export_32x32.png"), 1)
			Me.imageCollection1.Images.SetKeyName(1, "export_32x32.png")
			Me.imageCollection1.InsertGalleryImage("find_32x32.png", "images/find/find_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/find/find_32x32.png"), 2)
			Me.imageCollection1.Images.SetKeyName(2, "find_32x32.png")
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.listBoxControl1.Location = New System.Drawing.Point(381, 0)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(207, 406)
			Me.listBoxControl1.TabIndex = 1
			' 
			' Form1
			' 
			Me.ClientSize = New System.Drawing.Size(588, 406)
			Me.Controls.Add(Me.listBoxControl1)
			Me.Name = "Form1"
			Me.Text = "NavBarControl Runtime Sample"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private navBarSeparatorItem1 As DevExpress.XtraNavBar.NavBarSeparatorItem
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
	End Class
End Namespace

