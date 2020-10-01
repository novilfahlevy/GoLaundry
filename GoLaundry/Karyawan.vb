Public Class Karyawan

    Private Sub FormPelanggan_Click(sender As Object, e As EventArgs) Handles FormPelanggan.Click

        ShowForm(Pelanggan)

    End Sub

    Private Sub TransaksiForm_Click(sender As Object, e As EventArgs) Handles TransaksiForm.Click

        ShowForm(Transaksi)

    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click

        HideAllForm()

    End Sub

    Private Sub Karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class