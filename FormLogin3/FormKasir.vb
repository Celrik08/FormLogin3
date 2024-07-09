Public Class FormKasir
    Private formPenjualan As FormPenjualan

    Public Sub New(ByVal parentForm As FormPenjualan)
        InitializeComponent()
        formPenjualan = parentForm
    End Sub

    Private Sub TextKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextKode.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TextJumlah.Focus()
        End If
    End Sub

    Private Sub TextKode_TextChanged(sender As Object, e As EventArgs) Handles TextKode.TextChanged
        Dim kode As String = TextKode.Text

        Select Case kode
            Case "69244853701232"
                TextNama.Text = "Pulpen"
                TextHarga.Text = "5000"
            Case "8997214298441"
                TextNama.Text = "Stabilo"
                TextHarga.Text = "7000"
            Case "4974052841675"
                TextNama.Text = "Spidol"
                TextHarga.Text = "4500"
            Case Else
                TextNama.Text = ""
                TextHarga.Text = ""
        End Select
    End Sub

    Private Sub TextJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextJumlah.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CalculateSubTotal()
            e.Handled = True
        End If
    End Sub

    Private Sub CalculateSubTotal()
        Dim jumlah As Integer
        If Integer.TryParse(TextJumlah.Text, jumlah) Then
            Dim hargaText As String = TextHarga.Text
            Dim harga As Decimal
            If Decimal.TryParse(hargaText, harga) Then
                Dim subTotal As Decimal = harga * jumlah
                TextSub.Text = subTotal.ToString("N0") ' Format as number with thousand separators
            Else
                MessageBox.Show("Harga tidak valid.")
            End If
        Else
            MessageBox.Show("Jumlah tidak valid.")
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim kode As String = TextKode.Text
        Dim nama As String = TextNama.Text
        Dim hargaText As String = TextHarga.Text
        Dim jumlahText As String = TextJumlah.Text
        Dim subTotal As Decimal

        If Decimal.TryParse(hargaText, subTotal) AndAlso Integer.TryParse(jumlahText, Nothing) Then
            subTotal *= Integer.Parse(jumlahText)
            If formPenjualan IsNot Nothing Then
                formPenjualan.AddDataToDataGridView(kode, nama, hargaText, jumlahText, subTotal.ToString("N0"))
                formPenjualan.UpdateTotal(subTotal)
                formPenjualan.Show()
                Me.Close()
            End If
        Else
            MessageBox.Show("Input tidak valid. Pastikan harga dan jumlah diisi dengan benar.")
        End If
    End Sub
End Class
