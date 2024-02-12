Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Imports System.IO
Imports System.IO.File
Imports System.Text

Public Class Form1
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim actionStatus As String = "create"
    Dim selectedId As String = ""

    'Dim sqlDt As New DataTable
    'Dim sqlDtAdt As New MySqlDataAdapter

    Private Sub WriteLogs(message As String)
        Dim filepath As String = "D:/Logfile/logs.txt"
        Dim text As New StringBuilder
        text.AppendLine("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] " + message)
        File.AppendAllText(filepath, text.ToString())

        Dim getText As String = My.Computer.FileSystem.ReadAllText(filepath)
        txtLogs.Text = getText
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        WriteLogs("Application stopped.")
    End Sub

    Private Sub GetAllData()
        Dim server As String = "localhost"
        Dim username As String = "root"
        Dim password As String = ""
        Dim database As String = "warehouse"

        sqlConn.ConnectionString = "host=" + server + ";user=" + username + ";password=" + password + ";database=" + database
        sqlCmd.Connection = sqlConn

        Dim sqlDt As New DataTable
        sqlConn.Open()
        sqlCmd.CommandText = "SELECT * FROM products"
        sqlRd = sqlCmd.ExecuteReader

        ListView1.Items.Clear()

        Dim i As Integer = 1
        While sqlRd.Read()
            Dim lv = ListView1.Items.Add(i)
            lv.SubItems.Add(sqlRd.GetUInt32("id"))
            lv.SubItems.Add(sqlRd.GetString("name"))
            lv.SubItems.Add(sqlRd.GetDouble("price"))
            lv.SubItems.Add(sqlRd.GetInt32("stock"))
            lv.SubItems.Add(sqlRd.GetString("uom"))
            i = i + 1
        End While

        sqlRd.Close()
        sqlConn.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filepath As String = "D:/Logfile/logs.txt"
        If Not Exists(filepath) Then
            Dim fs As FileStream = File.Create(filepath)
        End If

        WriteLogs("Application started.")

        GetAllData()
    End Sub


    Private Function Validator() As Boolean
        Dim results As Boolean = If(txtNama.Text IsNot "" And txtHarga.Text > 0 And txtStok.Value > 0 And txtSatuan.Text IsNot "", True, False)

        If Not results Then
            WriteLogs("Simpan data gagal karena ada kolom yang kosong.")
        End If

        Return results
    End Function

    Private Function SaveData() As Boolean
        'for creating
        If Not Validator() Then
            Return False
        End If

        sqlConn.Open()
        sqlCmd.CommandText = "INSERT INTO products (name, price, stock, uom) VALUE('" + txtNama.Text + "', '" + txtHarga.Value.ToString() + "', '" + txtStok.Value.ToString() + "', '" + txtSatuan.Text + "' )"
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()

        WriteLogs("Simpan data berhasil.")
        Return True
    End Function

    Private Function UpdateData(id As String) As Boolean
        'for updating
        If Not Validator() Then
            Return False
        End If

        sqlConn.Open()
        sqlCmd.CommandText = "UPDATE products SET name='" + txtNama.Text + "', price='" + txtHarga.Value.ToString() + "', stock='" + txtStok.Value.ToString() + "', uom='" + txtSatuan.Text + "' WHERE id=" + id
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()

        WriteLogs("Edit data berhasil.")
        Return True
    End Function

    Private Sub ResetColumn()
        txtNama.Text = ""
        txtHarga.Value = 0
        txtStok.Value = 0
        txtSatuan.Text = ""
    End Sub

    Private Function IsSelected() As Boolean
        If selectedId IsNot "" Then
            Return True
        Else
            MsgBox("Id belum dipilih")
            Return False
        End If
    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim status As Boolean

        If actionStatus Is "create" Then
            status = SaveData()
        ElseIf actionStatus Is "edit" And IsSelected() Then
            status = UpdateData(selectedId)
        End If

        If status Then
            GetAllData()
            MsgBox("Operasi Berhasil.")
            ResetColumn()
        Else
            MsgBox("Operasi Gagal!")
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        actionStatus = "create"

        'will reset values
        ResetColumn()

        WriteLogs("Kolom berhasil di reset")
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        actionStatus = "edit"

        Dim index As Integer = ListView1.FocusedItem.Index
        Dim item = ListView1.Items(index)
        Dim id As String = item.SubItems(1).Text

        selectedId = id

        'will change values
        txtNama.Text = item.SubItems(2).Text
        txtHarga.Value = Integer.Parse(item.SubItems(3).Text)
        txtStok.Value = Integer.Parse(item.SubItems(4).Text)
        txtSatuan.Text = item.SubItems(5).Text

        WriteLogs("Nilai kolom berhasil diubah")
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        actionStatus = "delete"

        Dim index As Integer = ListView1.FocusedItem.Index
        Dim item = ListView1.Items(index)
        Dim id As String = item.SubItems(1).Text

        selectedId = id

        If IsSelected() Then
            sqlConn.Open()
            sqlCmd.CommandText = "DELETE FROM products WHERE id=" + selectedId
            sqlCmd.ExecuteNonQuery()
            sqlConn.Close()

            WriteLogs("Data berhasil dihapus")
            MsgBox("Data berhasil dihapus")
            ResetColumn()
            GetAllData()
        Else
            WriteLogs("Hapus data gagal")
            MsgBox("Hapus data gagal")
        End If
    End Sub
End Class
