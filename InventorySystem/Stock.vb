Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class Stock
    Private SQL As New SQLControl
    Private SQLCat As New CatSQL
    Public Con As New SqlConnection With {.ConnectionString = "Data Source=FAIZUL; Database = DB_Inventory; Trusted_Connection = Yes;"}
    Public Cmd As SqlCommand
    Public Dap As SqlDataAdapter
    Public Das As DataSet
    Dim dr As SqlDataReader
    Dim a As New OpenFileDialog

    Private Sub btn_insert_Click(sender As System.Object, e As System.EventArgs) Handles btn_insert.Click
        Dim timeToday = DateTime.Now.ToLongTimeString()
        Dim dateToday = DateTime.Now.ToShortDateString()

        'Con.Open()
        'Cmd = New SqlCommand("Insert into TB_Stock values('" + txtStock_ID.Text + "', '" + txtS_name.Text + "', '" + combo_category.Text + "', '" + combo_subcat.Text + "', '" + txt_qty.Text + "', '" + dateToday + "', '" + timeToday + "')", Con)
        'Dap = New SqlDataAdapter(Cmd)
        'Das = New DataSet()
        'Dap.Fill(Das, "DB_Inventory")
        'Con.Close()

        'SQL.RunQuery("SELECT * FROM TB_Stocks WHERE [Stock ID] = '" & txtStock_ID.Text & "' , [Stock Name] = '" & txtS_name.Text & "', Category = '" & combo_category.Text & "' , Quantity = '" & txt_qty.Text & "' , Date = '" & dateToday & "' Time = '" & timeToday & "' ")

        'If SQL.Das.Tables(0).Rows.Count > 0 Then
        '    MsgBox("Stock ID or Stock Name already exist!")
        '    Exit Sub
        'Else
        '    AddValu()
        'End If
        'ViewStocks()
        'ClearText()

        Try
            If txtS_name.Text <> "" Then
                'Declare a file stream object
                Dim o As System.IO.FileStream
                'Declare a stream reader object
                Dim r As StreamReader
                'Shorter variable name for FileStream (optional)
                Dim jpgFile As String = TxtFoto.Text
                'Open image file
                o = New FileStream(jpgFile, FileMode.Open, FileAccess.Read, FileShare.Read)
                'Read the image into a stream reader
                r = New StreamReader(o)

                'Declare a Byte array to hold the image
                Dim FileByteArray(o.Length - 1) As Byte

                'Fill the Byte array with image byte data
                o.Read(FileByteArray, 0, o.Length)


                Using sql As New SqlClient.SqlCommand("Insert Into TB_Stock([Stock ID],[Stock Name],Category,[Sub-Category],Quantity,Date,Time,gambar) Values (@stock_id,@stock_name,@category,@sub_category,@quantity,@date,@time, @gambar)", Module1.koneksi)
                    sql.Parameters.Add(New SqlClient.SqlParameter("@stock_id", SqlDbType.Int)).Value = txtStock_ID.Text
                    sql.Parameters.Add(New SqlClient.SqlParameter("@stock_name", SqlDbType.VarChar)).Value = txtS_name.Text
                    sql.Parameters.Add(New SqlClient.SqlParameter("@category", SqlDbType.VarChar)).Value = combo_category.Text
                    sql.Parameters.Add(New SqlClient.SqlParameter("@sub_category", SqlDbType.VarChar)).Value = combo_subcat.Text
                    sql.Parameters.Add(New SqlClient.SqlParameter("@quantity", SqlDbType.VarChar)).Value = txt_qty.Text
                    sql.Parameters.Add(New SqlClient.SqlParameter("@date", SqlDbType.NVarChar)).Value = dateToday
                    sql.Parameters.Add(New SqlClient.SqlParameter("@time", SqlDbType.NVarChar)).Value = timeToday
                    'Gambar
                    If a.FileName = Nothing Then
                        sql.Parameters.Add(New SqlClient.SqlParameter("@gambar", SqlDbType.Image)).Value = IO.File.ReadAllBytes("student_icon.png")
                    Else
                        sql.Parameters.Add(New SqlClient.SqlParameter("@gambar", SqlDbType.Binary, o.Length)).Value = FileByteArray

                    End If
                    sql.ExecuteNonQuery()
                    MessageBox.Show("Nama Stock : " & txtS_name.Text & " Telah disimpan", "Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Module1.koneksi.Close()
                    ViewStocks()
                    ClearText()
                End Using
            Else
                MessageBox.Show("Ada Kesalahan !", "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'Public Sub AddValu()
    '    Dim timeToday = DateTime.Now.ToLongTimeString()
    '    Dim dateToday = DateTime.Now.ToShortDateString()

    '    If Len(txtStock_ID) < 20 And Len(txtS_name) < 20 And Len(combo_category) < 20 And Len(txt_qty) < 20 Then

    '        SQL.DataInsert(txtStock_ID.Text, txtS_name.Text, combo_category.Text, txt_qty.Text, dateToday, timeToday)
    '    Else
    '        MsgBox("Inputed values is too short")
    '    End If

    'End Sub

    Public Sub ClearText()
        txtStock_ID.Text = ""
        txtS_name.Text = ""
        txt_qty.Text = ""
        combo_category.Text = ""
        combo_subcat.Text = ""
        TxtFoto.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Public Sub ViewStocks()

        Cmd = New SqlCommand("Select * from TB_Stock", Con)
        Dap = New SqlDataAdapter(Cmd)
        Das = New DataSet()
        Dap.Fill(Das, "DB_Inventory")

        Con.Open()
        grid_stocks.DataSource = Das.Tables("DB_Inventory").DefaultView
        Con.Close()
    End Sub

    Public Sub ComboCategory()
        combo_category.Items.Clear()
        SQLCat.ExecQuery("SELECT [Category Name] FROM TB_Category")

        If String.IsNullOrEmpty(SQLCat.Exception) Then
            For Each Rw As DataRow In SQLCat.Das.Tables(0).Rows
                combo_category.Items.Add(Rw("Category Name"))
            Next
            combo_category.SelectedIndex = 0
        Else
            MsgBox(SQLCat.Exception, MsgBoxStyle.Critical, "SQL ERROR!")
        End If
    End Sub

    Public Sub GetSub()
        combo_subcat.Items.Clear()
        SQLCat.AddParam("@CatName", combo_category.Text)
        SQLCat.ExecQuery("SELECT DISTINCT [Sub Name] FROM TB_SubCategory WHERE [Category Name] = @CatName")

        If String.IsNullOrEmpty(SQLCat.Exception) Then
            For Each Rw As DataRow In SQLCat.Das.Tables(0).Rows
                combo_subcat.Items.Add(Rw("Sub Name"))
            Next

            ' SET THE COMBOBOX TO FIRST RECORD
            combo_subcat.SelectedIndex = 0
        Else
            MsgBox(SQLCat.Exception, MsgBoxStyle.Critical, "SQL ERROR!")
        End If
    End Sub

    Private Sub combo_category_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles combo_category.SelectedIndexChanged
        ' IF A FOOD TYPE IS SELECTED SEARCH FOR MATCHING FOODS
        If Not String.IsNullOrEmpty(combo_category.Text) Then GetSub()
    End Sub

    Private Sub btn_gotom_Click(sender As System.Object, e As System.EventArgs) Handles btn_gotom.Click
        Dim M As Menu
        M = New Menu
        M.Show()
        Me.Hide()
    End Sub

    Private Sub btn_delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_delete.Click
        Con.Open()

        If txtStock_ID.Text <> "" Then
            If MsgBox("Do you really wish to delete ID " & txtStock_ID.Text & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                SQL.DataDelete("DELETE FROM TB_Stock WHERE [Stock ID] ='" & txtStock_ID.Text & "' ")
            End If
        End If
        Con.Close()
        ViewStocks()
        ClearText()
    End Sub

    Private Sub btn_clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_clear.Click
        ClearText()
    End Sub

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click
        Dim uptimeToday = DateTime.Now.ToLongTimeString()
        Dim updateToday = DateTime.Now.ToShortDateString()

        'If txtStock_ID.Text <> "" Then
        'If txtS_name.Text.Length < 21 And combo_category.Text.Length < 21 And combo_subcat.Text.Length < 21 And txt_qty.Text.Length < 7 Then
        'Dim UpdateCmd As String = "UPDATE TB_Stock SET [Stock Name] = '" + txtS_name.Text + "',Category = '" + combo_category.Text + "',[Sub-Category] = '" + combo_subcat.Text + "',Quantity = '" + txt_qty.Text + "',Date = '" + updateToday + "',Time = '" + uptimeToday + "' WHERE [Stock ID] = '" + txtStock_ID.Text + "' "

        'If SQL.DataUpdate(UpdateCmd) = 0 Then
        'MsgBox("The specified values could not be found.")
        'Else
        'MsgBox("Values succesfuly change for ID " & txtStock_ID.Text & ".")
        'End If
        'Else
        'MsgBox("Inputed values is too short")
        'End If
        'Else
        'MsgBox("You must provide updated values")
        'End If

        'ViewStocks()
        'ClearText()

        Try
            Dim cmd As String = String.Empty
            Dim adapter As New SqlDataAdapter("select gambar from TB_Stock where [Stock ID]='" & txtStock_ID.Text & "'", Module1.koneksi)
            Dim dt As New DataTable("TB_Stock")
            adapter.Fill(dt)
            Using sql As New SqlClient.SqlCommand("update TB_Stock set [Stock Name]=@stock_name,Category=@category,[Sub-Category]=@sub_category,Quantity=@quantity,date=@date,time=@time,gambar=@gambar where [Stock ID]='" + txtStock_ID.Text + "'", Module1.koneksi)
                sql.Parameters.Add(New SqlClient.SqlParameter("@stock_name", SqlDbType.VarChar)).Value = txtS_name.Text
                sql.Parameters.Add(New SqlClient.SqlParameter("@category", SqlDbType.VarChar)).Value = combo_category.Text
                sql.Parameters.Add(New SqlClient.SqlParameter("@sub_category", SqlDbType.VarChar)).Value = combo_subcat.Text
                sql.Parameters.Add(New SqlClient.SqlParameter("@quantity", SqlDbType.VarChar)).Value = txt_qty.Text
                sql.Parameters.Add(New SqlClient.SqlParameter("@date", SqlDbType.NVarChar)).Value = updateToday
                sql.Parameters.Add(New SqlClient.SqlParameter("@time", SqlDbType.NVarChar)).Value = uptimeToday
                If a.FileName = Nothing Then
                    Dim row As DataRow = dt.Rows(0)
                    Using ms As New IO.MemoryStream(CType(row(0), Byte()))
                        Dim img As Image = Image.FromStream(ms)
                        PictureBox1.Image = img
                        sql.Parameters.Add(New SqlClient.SqlParameter("@gambar", SqlDbType.Image)).Value = (CType(row(0), Byte()))
                    End Using
                Else
                    sql.Parameters.Add(New SqlClient.SqlParameter("@gambar", SqlDbType.Image)).Value = IO.File.ReadAllBytes(a.FileName)
                End If
                sql.ExecuteNonQuery()
                MessageBox.Show("Nama Stock : " & txtS_name.Text & " Sudah di Update !", "Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Module1.koneksi.Close()
                ViewStocks()
                ClearText()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Stock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ViewStocks()
        ComboCategory()
        ClearText()
    End Sub

    Sub GetData(e)
        Dim StockId As String = grid_stocks.Rows(e.RowIndex).Cells(0).Value
        Dim StockNam As String = grid_stocks.Rows(e.RowIndex).Cells(1).Value
        Dim ComCat As String = grid_stocks.Rows(e.RowIndex).Cells(2).Value
        Dim ComSub As String = grid_stocks.Rows(e.RowIndex).Cells(3).Value
        Dim StockQty As String = grid_stocks.Rows(e.RowIndex).Cells(4).Value

        txtStock_ID.Text = StockId
        txtS_name.Text = StockNam
        combo_category.Text = ComCat
        combo_subcat.Text = ComSub
        txt_qty.Text = StockQty

        Dim bytePoster() As Byte = grid_stocks.Rows(e.RowIndex).Cells(7).Value
        Dim stmBLOBData As New MemoryStream(bytePoster)
        PictureBox1.Image = Image.FromStream(stmBLOBData)


    End Sub

    Private Sub grid_stocks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_stocks.CellContentClick
        GetData(e)
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Dim pictureLocation As String
        a.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|TIFF Files (*.tiff)|*.tiff"
        pictureLocation = a.FileName
        Try
            If a.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = New Bitmap(a.FileName)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                TxtFoto.Text = a.FileName.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
