﻿Imports Karyawan

Public Class Pelanggan

    Private Sub Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'SetConnection()

        'TabelKaryawan.DataSource = GetDataSourceFromDB("SELECT * FROM pelanggan")
        'SetTableHeader(TabelKaryawan, {"ID", "Nama", "Alamat", "Telepon", "Email"})

    End Sub

    Private Sub FormKaryawan_Click(sender As Object, e As EventArgs) Handles FormKaryawan.Click

        ShowForm(Karyawan)

    End Sub

    Private Sub FormTransaksi_Click(sender As Object, e As EventArgs) Handles FormTransaksi.Click

        ShowForm(Transaksi)

    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click

        Logout()

    End Sub

End Class
