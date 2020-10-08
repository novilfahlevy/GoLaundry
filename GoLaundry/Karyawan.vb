Public Class Karyawan

    Private Sub FormPelanggan_Click(sender As Object, e As EventArgs) Handles FormPelanggan.Click

        ShowForm(Pelanggan)

    End Sub

    Private Sub FormTransaksi_Click(sender As Object, e As EventArgs) Handles FormTransaksi.Click

        ShowForm(Transaksi)

    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click

        Logout()

    End Sub

End Class