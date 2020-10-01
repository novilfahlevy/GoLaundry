Public Class Transaksi

    Private Sub FormPelanggan_Click(sender As Object, e As EventArgs) Handles FormPelanggan.Click

        ShowForm(Pelanggan)

    End Sub


    Private Sub FormKaryawan_Click(sender As Object, e As EventArgs) Handles FormKaryawan.Click

        ShowForm(Karyawan)

    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click

        HideAllForm()

    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class