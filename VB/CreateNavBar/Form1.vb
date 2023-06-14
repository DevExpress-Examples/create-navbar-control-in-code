Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraNavBar

Namespace CreateNavBar

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Create a NavBarControl.
            Dim navBar As NavBarControl = New NavBarControl()
            Me.Controls.Add(navBar)
            navBar.Width = 150
            navBar.Dock = DockStyle.Left
            ' Apply the "NavigationPaneView" style.
            navBar.PaintStyleKind = NavBarViewKind.NavigationPane
            ' Create the 'Charts' navbar group.
            Dim groupChart As NavBarGroup = New NavBarGroup("Charts")
            ' Display a large image in the group caption.
            groupChart.LargeImage = Global.CreateNavBar.Properties.Resources.chart_32x32
            ' Create an 'Area' item and assign an image to it from the project resources.
            Dim itemChartArea As NavBarItem = New NavBarItem("Area")
            itemChartArea.LargeImage = Global.CreateNavBar.Properties.Resources.area_32x32
            ' Create a 'Bar' item.
            Dim itemChartBar As NavBarItem = New NavBarItem("Bar")
            itemChartBar.LargeImage = Global.CreateNavBar.Properties.Resources.bar_32x32
            ' Create a disabled 'Refresh' item.
            Dim itemChartRefresh As NavBarItem = New NavBarItem("Refresh")
            itemChartRefresh.LargeImage = Global.CreateNavBar.Properties.Resources.refresh_32x32
            itemChartRefresh.Enabled = False
            'Assign an image collection to the NavBarControl. 
            'Images from this collection are used in the 'Settings' navbar group
            navBar.LargeImages = imageCollection1
            ' Create the 'Settings' navbar group.
            Dim groupSettings As NavBarGroup = New NavBarGroup("Settings")
            ' Display a large image in the group caption.
            groupSettings.LargeImage = Global.CreateNavBar.Properties.Resources.customize_32x32
            ' Create an 'Edit Settings' item and assign a large image to it by its index in the navBar.LargeImages collection.
            Dim itemEditSettings As NavBarItem = New NavBarItem("Edit Settings")
            itemEditSettings.LargeImageIndex = 0
            ' Create an Export item and assign a large image to it by its index in the navBar.LargeImages collection.
            Dim itemExport As NavBarItem = New NavBarItem("Export")
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
            AddHandler navBar.LinkClicked, New NavBarLinkEventHandler(AddressOf navBar_LinkClicked)
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

        Private Sub navBar_SelectedLinkChanged(ByVal sender As Object, ByVal e As ViewInfo.NavBarSelectedLinkChangedEventArgs)
            Dim s As String = String.Format("'{0}' selected", e.Link.Caption)
            listBoxControl1.Items.Add(s)
        End Sub

        Private Sub navBar_LinkClicked(ByVal sender As Object, ByVal e As NavBarLinkEventArgs)
            Dim s As String = String.Format("'{0}' clicked", e.Link.Caption)
            listBoxControl1.Items.Add(s)
        End Sub
    End Class
End Namespace
