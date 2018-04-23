Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraNavBar

Namespace CreateNavBar
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a NavBarControl.
			Dim navBar As New NavBarControl()
			Me.Controls.Add(navBar)
			navBar.Width = 150
			navBar.Dock = DockStyle.Left
			' Apply the "NavigationPaneView" style.
			navBar.PaintStyleKind = NavBarViewKind.NavigationPane

			' Create the 'Charts' navbar group.
			Dim groupChart As New NavBarGroup("Charts")
			' Display a large image in the group caption.
			groupChart.LargeImage = My.Resources.chart_32x32
			' Create an 'Area' item and assign an image to it from the project resources.
			Dim itemChartArea As New NavBarItem("Area")
			itemChartArea.LargeImage = My.Resources.area_32x32
			' Create a 'Bar' item.
			Dim itemChartBar As New NavBarItem("Bar")
			itemChartBar.LargeImage = My.Resources.bar_32x32
			' Create a disabled 'Refresh' item.
			Dim itemChartRefresh As New NavBarItem("Refresh")
			itemChartRefresh.LargeImage = My.Resources.refresh_32x32
			itemChartRefresh.Enabled = False

			'Assign an image collection to the NavBarControl. 
			'Images from this collection are used in the 'Settings' navbar group
			navBar.LargeImages = imageCollection1

			' Create the 'Settings' navbar group.
			Dim groupSettings As New NavBarGroup("Settings")
			' Display a large image in the group caption.
			groupSettings.LargeImage = My.Resources.customize_32x32
			' Create an 'Edit Settings' item and assign a large image to it by its index in the navBar.LargeImages collection.
			Dim itemEditSettings As New NavBarItem("Edit Settings")
			itemEditSettings.LargeImageIndex = 0
			' Create an Export item and assign a large image to it by its index in the navBar.LargeImages collection.
			Dim itemExport As New NavBarItem("Export")
			itemExport.LargeImageIndex = 1

			' Add the created items to the groups and the groups to the NavBarControl.
			' Prevent excessive updates using the BeginUpdate and EndUpdate methods.
			navBar.BeginUpdate()

			navBar.Groups.Add(groupChart)
			groupChart.ItemLinks.Add(itemChartArea)
			groupChart.ItemLinks.Add(itemChartBar)
			' Add a separator.
			groupChart.ItemLinks.Add(New NavBarSeparatorItem())
			groupChart.ItemLinks.Add(itemChartRefresh)
			'Enable the display of large images in the group.
			groupChart.GroupStyle = NavBarGroupStyle.LargeIconsText

			navBar.Groups.Add(groupSettings)
			groupSettings.ItemLinks.Add(itemEditSettings)
			groupSettings.ItemLinks.Add(itemExport)
			'Enable the display of large images in the group.
			groupSettings.GroupStyle = NavBarGroupStyle.LargeIconsText

			' Activate the 'Charts' group.
			navBar.ActiveGroup = groupChart

			' Specify the event handler to process item clicks.
			AddHandler navBar.LinkClicked, AddressOf navBar_LinkClicked
			' Specify the event handler to process item selection.
			AddHandler navBar.SelectedLinkChanged, AddressOf navBar_SelectedLinkChanged

			' Enable link selection. 
			' Each group can have a single selected link independent of other groups.
			' When a group is activated and it has no selected link, the first link is auto-selected.
			' At runtime, you will see that the SelectedLinkChanged event fires on group activation, 
			' while the LinkClicked event does not.
			navBar.LinkSelectionMode = LinkSelectionModeType.OneInGroupAndAllowAutoSelect
			navBar.EndUpdate()

			' Manually select the second link:
			'groupChart.SelectedLinkIndex = 1;
		End Sub

		Private Sub navBar_SelectedLinkChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventArgs)
			Dim s As String = String.Format("'{0}' selected", e.Link.Caption)
			listBoxControl1.Items.Add(s)
		End Sub

		Private Sub navBar_LinkClicked(ByVal sender As Object, ByVal e As NavBarLinkEventArgs)
			Dim s As String = String.Format("'{0}' clicked", e.Link.Caption)
			listBoxControl1.Items.Add(s)
		End Sub

	End Class
End Namespace
