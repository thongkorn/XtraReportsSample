<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.lblUnitsInStock = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblProductID = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblProductName = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblCategoryName = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblUnitPrice = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblSumUnitsInStock = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblUnitsInStock, Me.lblProductID, Me.lblProductName, Me.lblCategoryName, Me.lblUnitPrice})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 69.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblUnitsInStock
        '
        Me.lblUnitsInStock.Dpi = 254.0!
        Me.lblUnitsInStock.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitsInStock.LocationFloat = New DevExpress.Utils.PointFloat(1622.25!, 0.0!)
        Me.lblUnitsInStock.Name = "lblUnitsInStock"
        Me.lblUnitsInStock.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblUnitsInStock.SizeF = New System.Drawing.SizeF(267.3348!, 68.79166!)
        Me.lblUnitsInStock.StylePriority.UseFont = False
        Me.lblUnitsInStock.StylePriority.UseTextAlignment = False
        Me.lblUnitsInStock.Text = "lblUnitsInStock"
        Me.lblUnitsInStock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblProductID
        '
        Me.lblProductID.Dpi = 254.0!
        Me.lblProductID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.LocationFloat = New DevExpress.Utils.PointFloat(0.3749771!, 0.0!)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblProductID.SizeF = New System.Drawing.SizeF(250.2385!, 68.79166!)
        Me.lblProductID.StylePriority.UseFont = False
        Me.lblProductID.StylePriority.UseTextAlignment = False
        Me.lblProductID.Text = "lblProductID"
        Me.lblProductID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblProductName
        '
        Me.lblProductName.Dpi = 254.0!
        Me.lblProductName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.LocationFloat = New DevExpress.Utils.PointFloat(250.6135!, 0.0!)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblProductName.SizeF = New System.Drawing.SizeF(797.4916!, 68.79166!)
        Me.lblProductName.StylePriority.UseFont = False
        Me.lblProductName.StylePriority.UseTextAlignment = False
        Me.lblProductName.Text = "lblProductName"
        Me.lblProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblCategoryName
        '
        Me.lblCategoryName.Dpi = 254.0!
        Me.lblCategoryName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryName.LocationFloat = New DevExpress.Utils.PointFloat(1048.105!, 0.0!)
        Me.lblCategoryName.Name = "lblCategoryName"
        Me.lblCategoryName.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblCategoryName.SizeF = New System.Drawing.SizeF(301.6241!, 68.79166!)
        Me.lblCategoryName.StylePriority.UseFont = False
        Me.lblCategoryName.StylePriority.UseTextAlignment = False
        Me.lblCategoryName.Text = "lblCategoryName"
        Me.lblCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.Dpi = 254.0!
        Me.lblUnitPrice.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitPrice.LocationFloat = New DevExpress.Utils.PointFloat(1352.269!, 0.0!)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblUnitPrice.SizeF = New System.Drawing.SizeF(267.3348!, 68.79166!)
        Me.lblUnitPrice.StylePriority.UseFont = False
        Me.lblUnitPrice.StylePriority.UseTextAlignment = False
        Me.lblUnitPrice.Text = "lblUnitPrice"
        Me.lblUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 54.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.XrLabel2.BorderColor = System.Drawing.Color.White
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.BorderWidth = 1.0!
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.ForeColor = System.Drawing.Color.White
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 141.2292!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(247.9677!, 68.79166!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseBorderColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseBorderWidth = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Product ID"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.XrLabel3.BorderColor = System.Drawing.Color.White
        Me.XrLabel3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.ForeColor = System.Drawing.Color.White
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(247.9677!, 141.2292!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(800.1373!, 68.79166!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Product Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.DodgerBlue
        Me.XrLabel4.BorderColor = System.Drawing.Color.White
        Me.XrLabel4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.ForeColor = System.Drawing.Color.White
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(1048.105!, 141.2292!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(301.6241!, 68.79166!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Categories"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.DodgerBlue
        Me.XrLabel5.BorderColor = System.Drawing.Color.White
        Me.XrLabel5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.ForeColor = System.Drawing.Color.White
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(1349.729!, 141.2292!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(269.875!, 68.79167!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Unit Price"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Orange
        Me.XrLabel1.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Browallia New", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.XrLabel1.ForeColor = System.Drawing.Color.White
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1886.939!, 140.2292!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseBorderDashStyle = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Sample XtraReports DevExpress."
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 69.27081!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 254.0!
        Me.XrPageInfo1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(401.4261!, 76.72919!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.DodgerBlue
        Me.XrLabel7.BorderColor = System.Drawing.Color.White
        Me.XrLabel7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.ForeColor = System.Drawing.Color.White
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(1619.604!, 141.2292!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(269.9808!, 68.79166!)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseBorderColor = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Units In Stock"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblSumUnitsInStock
        '
        Me.lblSumUnitsInStock.Dpi = 254.0!
        Me.lblSumUnitsInStock.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumUnitsInStock.LocationFloat = New DevExpress.Utils.PointFloat(1352.27!, 0.0!)
        Me.lblSumUnitsInStock.Name = "lblSumUnitsInStock"
        Me.lblSumUnitsInStock.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblSumUnitsInStock.SizeF = New System.Drawing.SizeF(534.6698!, 76.72919!)
        Me.lblSumUnitsInStock.StylePriority.UseFont = False
        Me.lblSumUnitsInStock.StylePriority.UseTextAlignment = False
        Me.lblSumUnitsInStock.Text = "lblSumUnitsInStock"
        Me.lblSumUnitsInStock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrLine2, Me.XrLabel7, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabel5, Me.XrLabel1})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 226.3029!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLine3
        '
        Me.XrLine3.Dpi = 254.0!
        Me.XrLine3.LineWidth = 3
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0.6105521!, 215.1266!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(1884.872!, 10.17628!)
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LineWidth = 4
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0.6105521!, 209.0209!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1884.872!, 10.17628!)
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.lblSumUnitsInStock, Me.XrPageInfo1})
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 76.72919!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(2.067306!, 0.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1884.872!, 10.17628!)
        '
        'XtraReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter})
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(175, 93, 54, 69)
        Me.PageHeight = 2794
        Me.PageWidth = 2159
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnapGridSize = 25.0!
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblProductID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblProductName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCategoryName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblUnitPrice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblUnitsInStock As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSumUnitsInStock As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
End Class
