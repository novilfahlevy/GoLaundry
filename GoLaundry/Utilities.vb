Module Utilities

    Sub HideAllForm()

        Pelanggan.Hide()
        Karyawan.Hide()
        Transaksi.Hide()

    End Sub

    Sub ShowForm(Form As System.Windows.Forms.Form)

        HideAllForm()
        Form.Show()

    End Sub

    Sub Logout()

        HideAllForm()
        Application.Exit()

    End Sub

End Module
