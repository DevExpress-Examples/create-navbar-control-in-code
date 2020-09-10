<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CreateNavBar/Form1.cs) (VB: [Form1.vb](./VB/CreateNavBar/Form1.vb))
<!-- default file list end -->
# How to: Create a NavBarControl in code


<p>This example shows how to create a NavBarControl in code.</p><p>The NavBarControl will have two groups ('Charts' and 'Settings') with items. Item link selection is enabled by setting the LinkSelectionMode property to LinkSelectionModeType.OneInGroupAndAllowAutoSelect. To respond to a link selection, the SelectedLinkChanged event is handled.</p><br />
<p>In the OneInGroupAndAllowAutoSelect mode, each group can have a single selected link independent of other groups. When a group is activated and it has no selected link, the first link is auto-selected. At runtime, you will see that the SelectedLinkChanged event fires on group activation, while the LinkClicked event does not.</p><br />
<p>The example demonstrates two methods of assigning images to navbar items:</p><p>1) explicit assignment of Image objects to items (see the 'Charts' navbar group item initialization);</p><p>2) implicit assignment, using image indexes (see the 'Settings' navbar group item initialization).</p>

<br/>

<b>In v15.1 we implemented AccordionControl. It extends NavBarControl's possibilities and has an unlimited number of hierarchies, a modern look and feel, and also a more flexible architecture.</b>


