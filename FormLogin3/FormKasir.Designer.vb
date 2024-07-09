<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKasir
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextKode = New TextBox()
        TextNama = New TextBox()
        TextHarga = New TextBox()
        TextJumlah = New TextBox()
        TextSub = New TextBox()
        BtnSimpan = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 15)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 20)
        Label1.TabIndex = 0
        Label1.Text = "Kode Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 49)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nama Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 83)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 20)
        Label3.TabIndex = 2
        Label3.Text = "Harga Satuan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 117)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 20)
        Label4.TabIndex = 3
        Label4.Text = "Jumlah Beli"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 151)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 20)
        Label5.TabIndex = 4
        Label5.Text = "Sub total "
        ' 
        ' TextKode
        ' 
        TextKode.Location = New Point(128, 12)
        TextKode.Name = "TextKode"
        TextKode.Size = New Size(125, 28)
        TextKode.TabIndex = 5
        ' 
        ' TextNama
        ' 
        TextNama.Location = New Point(128, 46)
        TextNama.Name = "TextNama"
        TextNama.Size = New Size(125, 28)
        TextNama.TabIndex = 6
        ' 
        ' TextHarga
        ' 
        TextHarga.Location = New Point(128, 80)
        TextHarga.Name = "TextHarga"
        TextHarga.Size = New Size(125, 28)
        TextHarga.TabIndex = 7
        ' 
        ' TextJumlah
        ' 
        TextJumlah.Location = New Point(128, 114)
        TextJumlah.Name = "TextJumlah"
        TextJumlah.Size = New Size(125, 28)
        TextJumlah.TabIndex = 8
        ' 
        ' TextSub
        ' 
        TextSub.Location = New Point(128, 148)
        TextSub.Name = "TextSub"
        TextSub.Size = New Size(125, 28)
        TextSub.TabIndex = 9
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(83, 199)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(94, 29)
        BtnSimpan.TabIndex = 10
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' FormKasir
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(276, 248)
        Controls.Add(BtnSimpan)
        Controls.Add(TextSub)
        Controls.Add(TextJumlah)
        Controls.Add(TextHarga)
        Controls.Add(TextNama)
        Controls.Add(TextKode)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormKasir"
        Text = "FormKasir"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextKode As TextBox
    Friend WithEvents TextNama As TextBox
    Friend WithEvents TextHarga As TextBox
    Friend WithEvents TextJumlah As TextBox
    Friend WithEvents TextSub As TextBox
    Friend WithEvents BtnSimpan As Button
End Class
