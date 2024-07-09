<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        BtnTambah = New Button()
        DataBarang = New DataGridView()
        Kode = New DataGridViewTextBoxColumn()
        Nama = New DataGridViewTextBoxColumn()
        Harga = New DataGridViewTextBoxColumn()
        Jumlah = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextTotal = New TextBox()
        TextBayar = New TextBox()
        TextKembalian = New TextBox()
        LabelUser = New Label()
        CType(DataBarang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(13, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 23)
        Label1.TabIndex = 0
        Label1.Text = "Menu Penjual"
        ' 
        ' BtnTambah
        ' 
        BtnTambah.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnTambah.Location = New Point(12, 47)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(159, 34)
        BtnTambah.TabIndex = 1
        BtnTambah.Text = "Tambah Barang +"
        BtnTambah.UseVisualStyleBackColor = True
        ' 
        ' DataBarang
        ' 
        DataBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataBarang.Columns.AddRange(New DataGridViewColumn() {Kode, Nama, Harga, Jumlah})
        DataBarang.Location = New Point(12, 99)
        DataBarang.Name = "DataBarang"
        DataBarang.RowHeadersWidth = 51
        DataBarang.RowTemplate.Height = 29
        DataBarang.Size = New Size(627, 150)
        DataBarang.TabIndex = 2
        ' 
        ' Kode
        ' 
        Kode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Kode.HeaderText = "Kode Barang"
        Kode.MinimumWidth = 6
        Kode.Name = "Kode"
        ' 
        ' Nama
        ' 
        Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Nama.HeaderText = "Nama Barang"
        Nama.MinimumWidth = 6
        Nama.Name = "Nama"
        ' 
        ' Harga
        ' 
        Harga.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Harga.HeaderText = "Harga Satuan"
        Harga.MinimumWidth = 6
        Harga.Name = "Harga"
        ' 
        ' Jumlah
        ' 
        Jumlah.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Jumlah.HeaderText = "Jumlah Beli"
        Jumlah.MinimumWidth = 6
        Jumlah.Name = "Jumlah"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 277)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 20)
        Label2.TabIndex = 3
        Label2.Text = "Total Bayar"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 311)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 20)
        Label3.TabIndex = 4
        Label3.Text = "Bayar"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 345)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 5
        Label4.Text = "Kembalian"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 387)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 20)
        Label5.TabIndex = 6
        Label5.Text = "Selamat Datang"
        ' 
        ' TextTotal
        ' 
        TextTotal.Location = New Point(112, 274)
        TextTotal.Name = "TextTotal"
        TextTotal.Size = New Size(193, 28)
        TextTotal.TabIndex = 7
        ' 
        ' TextBayar
        ' 
        TextBayar.Location = New Point(112, 308)
        TextBayar.Name = "TextBayar"
        TextBayar.Size = New Size(193, 28)
        TextBayar.TabIndex = 8
        ' 
        ' TextKembalian
        ' 
        TextKembalian.Location = New Point(112, 342)
        TextKembalian.Name = "TextKembalian"
        TextKembalian.Size = New Size(193, 28)
        TextKembalian.TabIndex = 9
        ' 
        ' LabelUser
        ' 
        LabelUser.AutoSize = True
        LabelUser.Location = New Point(157, 387)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(81, 20)
        LabelUser.TabIndex = 10
        LabelUser.Text = "________"
        ' 
        ' FormPenjual
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(660, 450)
        Controls.Add(LabelUser)
        Controls.Add(TextKembalian)
        Controls.Add(TextBayar)
        Controls.Add(TextTotal)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DataBarang)
        Controls.Add(BtnTambah)
        Controls.Add(Label1)
        Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormPenjual"
        Text = "FormPenjual"
        CType(DataBarang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents DataBarang As DataGridView
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextTotal As TextBox
    Friend WithEvents TextBayar As TextBox
    Friend WithEvents TextKembalian As TextBox
    Friend WithEvents LabelUser As Label
End Class
