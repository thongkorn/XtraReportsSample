' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gnet.com/webboard
' /
' / Purpose: Sample XtraReports of DevExpress. (V.17.6.1)
' / Microsoft Visual Basic .NET (2010) + MS Access
' /
' / This is open source code under @Copyleft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------

Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports System.Data
Imports System.Drawing.Printing

'// Document Viewer Toolbars ... https://docs.devexpress.com/WindowsForms/3086/controls-and-libraries/printing-exporting/concepts/print-preview/document-viewer-toolbars

Public Class frmXtraReportsSample
    '// หากเป็นโปรเจคจริงๆ กลุ่มตัวแปรเหล่านี้ต้องนำไปวางไว้ใน Module 
    Dim Conn As OleDb.OleDbConnection
    Dim DA As New System.Data.OleDb.OleDbDataAdapter()
    Dim Cmd As New System.Data.OleDb.OleDbCommand
    Dim DT As New DataTable
    Dim strSQL As String

    ' / Get my project path
    Function MyPath(AppPath As String) As String
        '/ MessageBox.Show(AppPath)
        MyPath = AppPath.ToLower.Replace("\bin\debug", "\").Replace("\bin\Release", "\")
    End Function

    ' / ------------------------------------------------------------------
    Public Sub ConnectDataBase()
        Dim strPath As String = MyPath(Application.StartupPath)
        Dim strConn As String = _
            " Provider = Microsoft.ACE.OLEDB.12.0; " & _
            " Data Source = " & strPath & "NwindProduct.accdb;"
        '//
        Conn = New OleDb.OleDbConnection(strConn)
    End Sub

    Private Sub frmXtraReportsSample_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '// Connect Database
        Call ConnectDataBase()
        '// Refresh Data.
        Call RetrieveData()
        '// Initialized GridControl.
        Call SetupGridView()
        '// ปิดการมองเห็นปุ่ม Close ใน RibbonControl กลุ่มเครื่องมือการพิมพ์ (ดูชื่อ Control ตอน Design Time)
        Me.PrintPreviewRibbonPageGroup8.Visible = False
        '//
        btnPreviewGrid.Location = New Point(751, 26)
        btnExit.Location = New Point(751, 64)
    End Sub

    Private Sub SetupGridView()
        GridView1.Columns.Clear()
        '// ตั้งค่าคุณสมบัติ XtraGrid
        '// Start Add Fields.
        Dim GC As New GridColumn    '// Imports DevExpress.XtraGrid.Columns
        GC = GridView1.Columns.AddField("ProductPK")
        With GC
            .Caption = "ProductPK"
            .UnboundType = DevExpress.Data.UnboundColumnType.Integer
            '// ซ่อนหลัก Index = 0 ซึ่งเป็นค่า Primary Key 
            '// เมื่อผู้ใช้กดดับเบิ้ลคลิ๊กเมาส์ หรือกด Enter ในแต่ละแถว เราจะนำค่านี้ไป Query เพื่อแสดงผลรายละเอียดอีกที
            .Visible = False
        End With
        '// ProductID
        GC = GridView1.Columns.AddField("ProductID")
        With GC
            .Caption = "Product ID"
            .UnboundType = DevExpress.Data.UnboundColumnType.String
            .Visible = True
        End With
        '// Product Name
        GC = GridView1.Columns.AddField("ProductName")
        With GC
            .Caption = "Product Name"
            .UnboundType = DevExpress.Data.UnboundColumnType.String
            .Visible = True
        End With
        '// Category Name
        GC = GridView1.Columns.AddField("CategoryName")
        With GC
            .Caption = "Category Name"
            .UnboundType = DevExpress.Data.UnboundColumnType.String
            .Visible = True
        End With
        '// UnitPrice
        GC = GridView1.Columns.AddField("UnitPrice")
        With GC
            .Caption = "Unit Price"
            .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .DisplayFormat.FormatString = "#,##0.00;(-#,##0.00);"
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            .Visible = True
        End With
        '// UnitsInStock
        GC = GridView1.Columns.AddField("UnitsInStock")
        With GC
            .Caption = "Units In Stock"
            .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .DisplayFormat.FormatString = "#,##0.00;(-#,##0.00);"
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            .Visible = True
        End With

        '// Setup XtraGrid Properties @Run Time.
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(GridControl1.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
        With view
            .OptionsBehavior.AutoPopulateColumns = False
            '// ไม่ให้เกิด GroupPanel เพื่อจับหลักลากมาวางในส่วนนี้ได้ จะใช้การเขียนโค้ดในการจัดกลุ่มแทน
            .OptionsView.ShowGroupPanel = False
            .OptionsCustomization.AllowFilter = True '//False
            .OptionsCustomization.AllowColumnMoving = False
            '// CheckBox Selector
            .OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        End With
        '//
        With GridView1
            .RowHeight = 25
            .GroupRowHeight = 30
            .Appearance.Row.Font = New Font("Tahoma", 10, FontStyle.Regular)
            .Appearance.HeaderPanel.Font = New Font("Tahoma", 10, FontStyle.Bold)
            .Appearance.GroupRow.Font = New Font("Tahoma", 10, FontStyle.Bold)
            .Appearance.SelectedRow.Font = New Font("Tahoma", 10)
            .Appearance.FooterPanel.Font = New Font("Tahoma", 10)
            ' / Word wrap
            .OptionsView.RowAutoHeight = True
            .Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap

            '// ปรับการเพิ่ม/แก้ไข/ลบข้อมูล
            .OptionsBehavior.AllowAddRows = False
            .OptionsBehavior.AllowDeleteRows = False
            .OptionsBehavior.Editable = False '// True
            '// Display
            .FocusRectStyle = DrawFocusRectStyle.RowFocus
            .Appearance.FocusedCell.ForeColor = Color.Red
            .Appearance.FocusedCell.Options.UseTextOptions = True
            .OptionsSelection.EnableAppearanceFocusedCell = False '//True
            '// Make the group footers always visible = True, Otherwise = False.
            .OptionsView.ShowFooter = False
            .OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways
        End With
    End Sub

    '// การค้นหาข้อมูล หรือแสดงผลข้อมูลทั้งหมด จะใช้เพียงโปรแกรมย่อยแบบ Sub Program เดียวกัน
    '// หากค่าที่ส่งมาเป็น False (หรือไม่ส่งมา จะถือเป็นค่า Default) นั่นคือให้แสดงผลข้อมูลทั้งหมด
    '// หากค่าที่ส่งมาเป็น True จะเป็นการค้นหาข้อมูล
    Private Sub RetrieveData(Optional ByVal blnSearch As Boolean = False)
        '// Join 2 Table between Products & Categories.
        strSQL = _
            " SELECT Products.ProductID, Products.ProductName, Categories.CategoryName, Products.UnitPrice, Products.UnitsInStock " & _
            " FROM Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID "
        '// เป็นการค้นหา
        If blnSearch Then
            strSQL = strSQL & _
                    " WHERE " & _
                    " ProductID " & " Like '%" & Trim(txtSearch.Text) & "%'" & " OR " & _
                    " ProductName " & " Like '%" & Trim(txtSearch.Text) & "%'" & " OR " & _
                    " UnitPrice " & " Like '%" & Trim(txtSearch.Text) & "%'" & " OR " & _
                    " UnitsInStock " & " Like '%" & Trim(txtSearch.Text) & "%'" & " OR " & _
                    " CategoryName " & " Like '%" & Trim(txtSearch.Text) & "%'"
            '// Else ไม่ต้องมี
        End If
        '// เอา strSQL มาเรียงต่อกัน
        strSQL = strSQL & " ORDER BY ProductID "
        '/
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            Cmd = Conn.CreateCommand
            Cmd.CommandText = strSQL
            DT = New DataTable
            DA = New OleDb.OleDbDataAdapter(Cmd)
            DA.Fill(DT)
            '// Bound Data
            GridControl1.DataSource = DT
            lblRecordCount.Text = "[Total : " & DT.Rows.Count & " Records.]"
            Me.XtraTabControl1.SelectedTabPage = XtraTabPage2
            '// ------------------- Starting to Create Report. -------------------
            '// Instance Name of XtraReports.
            Dim Report As New XtraReport1() With {
                .Name = "SampleXtraReports",
                .DisplayName = "Sample XtraReports",
                .PaperKind = PaperKind.A4,
                .Margins = New Margins(100, 100, 100, 100)
            }
            '/ Binding Data to XRLabel within Report.
            With Report
                .lblProductID.DataBindings.Add("Text", DT, "ProductID")
                .lblProductName.DataBindings.Add("Text", DT, "ProductName")
                .lblCategoryName.DataBindings.Add("Text", DT, "CategoryName")
                .lblUnitPrice.DataBindings.Add("Text", DT, "UnitPrice", "{0:#,##0.00}")
                .lblUnitsInStock.DataBindings.Add("Text", DT, "UnitsInStock", "{0:N2}")
                '// Example: Summary of UnitsInStock
                .lblSumUnitsInStock.DataBindings.Add("Text", DT, "UnitsInStock", "{0:N2}")
                With .lblSumUnitsInStock
                    '// ใช้ฟังค์ชั่นในการรวมค่าจำนวนของ UnitsInStock (SUM)
                    .Summary.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
                    .Summary.FormatString = "In Stock: {0:N2} Items."
                    .Summary.IgnoreNullValues = True
                    '// ผลรวม Sum of UnitsInStock ในแต่ละหน้า
                    .Summary.Running = SummaryRunning.Page
                End With
                '// Page No.
                .XrPageInfo1.Format = "Page: {0}/{1}"
                .DataSource = DT
                .CreateDocument()
            End With
            '// Bound Report to DocumentViewer
            DocumentViewer1.DocumentSource = Report
            With DocumentViewer1
                .ShowPageMargins = True 'False
                .IsMetric = True
                .PrintingSystem.ExecCommand(PrintingSystemCommand.ZoomToPageWidth)
            End With
            '// ------------------- End to Print Report. -------------------
            DT.Dispose()
            DA.Dispose()
            txtSearch.Text = "" : txtSearch.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        '// Refresh Data. (Show all data)
        Call RetrieveData()
    End Sub

    '// การค้นหา (Retrieve Data)
    Private Sub txtSearch_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If txtSearch.Text.Trim = "" Or Len(txtSearch.Text.Trim) = 0 Then Return
        '// RetrieveData(True) It means searching for information.
        If e.KeyChar = Chr(13) Then '// Press Enter
            '// No beep.
            e.Handled = True
            '// Undesirable characters for the database ex.  ', * or %
            txtSearch.Text = txtSearch.Text.Trim.Replace("'", "").Replace("%", "").Replace("*", "")
            '// ระบุเป็นการค้นหาข้อมูล
            Call RetrieveData(True)
        End If
    End Sub

    '// GridControl To XtraReports.
    Private Sub btnPreviewGrid_Click(sender As System.Object, e As System.EventArgs) Handles btnPreviewGrid.Click
        Call ShowGridPreview(GridControl1)
    End Sub

    Sub ShowGridPreview(ByVal grid As GridControl)
        '// Check whether the GridControl can be previewed.
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found.", "Error")
            Return
        End If
        '// แสดงผลรายงานออกหน้าจอ Dialog
        grid.ShowPrintPreview()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmXtraReport_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub
End Class