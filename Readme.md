<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581697/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2809)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Pivot Grid - Change the Field Value Header Background

This example handles the [CustomDrawFieldValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomDrawFieldValue) event to fill the header's color. 

![screenshot](/images/screenshot.png)

## Files to Review

[Form1.cs](./CS/WindowsApplication53/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication53/Form1.vb))

## Example Overview

Handle the [PivotGridControl.CustomDrawFieldValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomDrawFieldValue) event to change the header's back color. You can customize fields headers in two ways:

- To modify the appearance of the field header, use the [e.Appearance](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotCustomDrawEventArgs.Appearance) property to get the appearance object for the painted element and change its background color.
- To drow field headers manually, use the [e.Painter](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventArgs.Painter) property to get the Painter object and implement the default element painting mechanism. Pass the `PivotHeaderObjectInfoArgs` object (the [e.Info](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventArgs.Info) property) to the `Painter` object's `DrawObject()` method.

## Documentation

[Custom Draw](https://docs.devexpress.com/WindowsForms/1817/controls-and-libraries/pivot-grid/appearance/custom-draw)

## More Examples

- [Pivot Grid for WinForms - Highlight Field Headers when they are Filtered](https://github.com/DevExpress-Examples/how-to-highlight-field-headers-when-they-are-filtered-e545)
- [Pivot Grid for WinForms - Customize Cells](https://github.com/DevExpress-Examples/winforms-pivot-customize-cell)
- [Pivot Grid for WinForms - Draw a Custom Element when a User Hovering Over Field Value with a Mouse](https://github.com/DevExpress-Examples/how-to-draw-a-custom-element-when-a-user-hovering-over-field-value-with-a-mouse-e2228)
