Public Class FormPenjualan
    Private loggedInFullName As String = ""
    Private total As Decimal = 0 ' Menyimpan total dari semua subtotal

    Public Sub New(fullName As String)
        InitializeComponent()
        loggedInFullName = fullName
        LabelUser.Text = loggedInFullName
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim FormKasir As New FormKasir(Me)
        FormKasir.Show()
        Me.Hide()
    End Sub

    Public Sub AddDataToDataGridView(kode As String, nama As String, harga As String, jumlah As String, subTotal As Decimal)
        DataBarang.Rows.Add(kode, nama, harga, jumlah, subTotal.ToString("C"))
    End Sub

    Public Sub UpdateTotal(subTotal As Decimal)
        total += subTotal
        TextTotal.Text = total.ToString("C")
    End Sub

    Private Sub TextBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBayar.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim bayarAmount As Decimal
            If Decimal.TryParse(TextBayar.Text, bayarAmount) Then
                Dim kembalian As Decimal = bayarAmount - total
                TextKembalian.Text = kembalian.ToString("C")
            Else
                MessageBox.Show("Input bayar tidak valid. Harap masukkan angka yang benar.")
            End If
        End If
    End Sub

    Private Sub TextTotal_TextChanged(sender As Object, e As EventArgs) Handles TextTotal.TextChanged

    End Sub
End Class
