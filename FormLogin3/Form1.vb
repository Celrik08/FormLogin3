Public Class Form1

    ' Ketika tombol tekan di kolom username, jika tombol Enter, fokus pindah ke kolom password
    Private Sub TextUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextUser.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TextPassword.Focus()
        End If
    End Sub

    ' Ketika tombol Login diklik
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        PerformLogin()  ' Panggil fungsi untuk melakukan login
    End Sub

    ' Ketika tombol tekan di kolom password, jika tombol Enter, panggil fungsi untuk melakukan login
    Private Sub TextPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            PerformLogin()
        End If
    End Sub

    ' Fungsi untuk melakukan login
    Private Sub PerformLogin()
        Dim username As String = TextUser.Text.ToLower()
        Dim password As String = TextPassword.Text

        ' Memeriksa apakah kredensial yang dimasukkan sesuai
        If CheckCredentials(username, password) Then
            ' Menampilkan pesan login berhasil
            MessageBox.Show("Login Berhasil.", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim fullName As String = GetFullName(username)
            Dim FormPenjualan As New FormPenjualan(fullName)
            FormPenjualan.Show()
            Me.Hide()
        Else
            ' Menampilkan pesan login gagal dan mengosongkan kolom username dan password
            MessageBox.Show("Login Gagal. Username atau Password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextUser.Text = ""
            TextPassword.Text = ""
        End If
    End Sub

    ' Memeriksa kredensial
    Private Function CheckCredentials(username As String, password As String) As Boolean
        Select Case username
            Case "kasir0001"
                Return password = "327469"
            Case "kasir0002"
                Return password = "469725"
            Case "petugas"
                Return password = "admin00"
            Case Else
                Return False
        End Select
    End Function

    ' Mendapatkan nama lengkap berdasarkan username
    Private Function GetFullName(username As String) As String
        Select Case username
            Case "kasir0001"
                Return "Kartika"
            Case "kasir0002"
                Return "Ferdinan"
            Case "admin"
                Return "Admin"
            Case Else
                Return "Unknown"
        End Select
    End Function

    ' Saat form login dimuat, mengatur karakter password menjadi '*'
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextPassword.PasswordChar = "*"
    End Sub
End Class
