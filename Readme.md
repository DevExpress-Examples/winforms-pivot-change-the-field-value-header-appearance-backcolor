<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication53/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication53/Form1.vb))
<!-- default file list end -->
# How to change the Field Value Header appearance backcolor or draw it manually


<p>If <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressLookAndFeelUserLookAndFeel_Styletopic">UserLookAndFeel.Style</a> is equal to <em>Skin</em>, the XtraPivotGrid control uses the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument2399">Skins</a> technology to draw its content. With this approach, all headers are drawn using a specific bitmap provided by a corresponding skin element. The appearance back color settings have no effect in this instance. If you want to draw a field header using a custom color, you can draw the field header manually using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomDrawFieldValuetopic">PivotGridControl.CustomDrawFieldValue</a> event.<br><br>Note that the DrawIndicator method can throw exceptions in versions 15.1.3 - 15.1.5. We have fixed this issue in the context of the <a href="https://www.devexpress.com/Support/Center/p/T279173">DrawIndicator method call throws an exception after updating to 15.1.5</a> ticket.</p>

<br/>


