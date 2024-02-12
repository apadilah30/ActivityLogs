<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        id = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        Harga = New ColumnHeader()
        Stok = New ColumnHeader()
        Satuan = New ColumnHeader()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        txtNama = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtStok = New NumericUpDown()
        Label4 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        btnSave = New Button()
        txtLogs = New RichTextBox()
        Label5 = New Label()
        Label6 = New Label()
        txtSatuan = New TextBox()
        txtHarga = New NumericUpDown()
        CType(txtStok, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtHarga, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 30)
        Label1.TabIndex = 1
        Label1.Text = "Warehouse Management"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, id, ColumnHeader2, Harga, Stok, Satuan})
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HoverSelection = True
        ListView1.Location = New Point(12, 53)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(776, 218)
        ListView1.TabIndex = 2
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "No"
        ' 
        ' id
        ' 
        id.Text = "Kode"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Nama"
        ColumnHeader2.Width = 250
        ' 
        ' Harga
        ' 
        Harga.Text = "Harga"
        Harga.Width = 250
        ' 
        ' Stok
        ' 
        Stok.Text = "Stok"
        Stok.Width = 100
        ' 
        ' Satuan
        ' 
        Satuan.Text = "Satuan"
        Satuan.Width = 100
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(12, 288)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(110, 288)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 5
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(211, 288)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(12, 370)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(173, 23)
        txtNama.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 352)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 9
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(191, 352)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 11
        Label3.Text = "Harga"
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(405, 371)
        txtStok.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(71, 23)
        txtStok.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(405, 353)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 15)
        Label4.TabIndex = 14
        Label4.Text = "Stok"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(655, 371)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(133, 23)
        btnSave.TabIndex = 15
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtLogs
        ' 
        txtLogs.Location = New Point(12, 435)
        txtLogs.Name = "txtLogs"
        txtLogs.ReadOnly = True
        txtLogs.Size = New Size(776, 113)
        txtLogs.TabIndex = 16
        txtLogs.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 417)
        Label5.Name = "Label5"
        Label5.Size = New Size(32, 15)
        Label5.TabIndex = 17
        Label5.Text = "Logs"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(482, 352)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 15)
        Label6.TabIndex = 19
        Label6.Text = "Satuan"
        ' 
        ' txtSatuan
        ' 
        txtSatuan.Location = New Point(482, 370)
        txtSatuan.Name = "txtSatuan"
        txtSatuan.Size = New Size(167, 23)
        txtSatuan.TabIndex = 18
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(191, 370)
        txtHarga.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(208, 23)
        txtHarga.TabIndex = 20
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 560)
        Controls.Add(txtHarga)
        Controls.Add(Label6)
        Controls.Add(txtSatuan)
        Controls.Add(Label5)
        Controls.Add(txtLogs)
        Controls.Add(btnSave)
        Controls.Add(Label4)
        Controls.Add(txtStok)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtNama)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(ListView1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(txtStok, ComponentModel.ISupportInitialize).EndInit()
        CType(txtHarga, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Public WithEvents btnAdd As Button
    Public WithEvents btnEdit As Button
    Public WithEvents btnDelete As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Harga As ColumnHeader
    Friend WithEvents Stok As ColumnHeader
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStok As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Public WithEvents btnSave As Button
    Friend WithEvents Satuan As ColumnHeader
    Friend WithEvents txtLogs As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSatuan As TextBox
    Friend WithEvents txtHarga As NumericUpDown
    Friend WithEvents id As ColumnHeader

End Class
