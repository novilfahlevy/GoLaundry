﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pelanggan
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
        Me.Keluar = New System.Windows.Forms.Button()
        Me.FormTransaksi = New System.Windows.Forms.Button()
        Me.FormKaryawan = New System.Windows.Forms.Button()
        Me.FormPelanggan = New System.Windows.Forms.Button()
        Me.MuatUlangData = New System.Windows.Forms.Button()
        Me.Cari = New System.Windows.Forms.Button()
        Me.KataKunci = New System.Windows.Forms.TextBox()
        Me.TabelKaryawan = New System.Windows.Forms.DataGridView()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.Sunting = New System.Windows.Forms.Button()
        Me.Simpan = New System.Windows.Forms.Button()
        Me.Telepon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Alamat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TabelKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Keluar
        '
        Me.Keluar.Location = New System.Drawing.Point(23, 571)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(173, 39)
        Me.Keluar.TabIndex = 90
        Me.Keluar.Text = "Keluar"
        Me.Keluar.UseVisualStyleBackColor = True
        '
        'FormTransaksi
        '
        Me.FormTransaksi.Location = New System.Drawing.Point(23, 192)
        Me.FormTransaksi.Name = "FormTransaksi"
        Me.FormTransaksi.Size = New System.Drawing.Size(173, 39)
        Me.FormTransaksi.TabIndex = 89
        Me.FormTransaksi.Text = "Transaksi"
        Me.FormTransaksi.UseVisualStyleBackColor = True
        '
        'FormKaryawan
        '
        Me.FormKaryawan.Location = New System.Drawing.Point(23, 147)
        Me.FormKaryawan.Name = "FormKaryawan"
        Me.FormKaryawan.Size = New System.Drawing.Size(173, 39)
        Me.FormKaryawan.TabIndex = 88
        Me.FormKaryawan.Text = "Karyawan"
        Me.FormKaryawan.UseVisualStyleBackColor = True
        '
        'FormPelanggan
        '
        Me.FormPelanggan.Enabled = False
        Me.FormPelanggan.Location = New System.Drawing.Point(23, 103)
        Me.FormPelanggan.Name = "FormPelanggan"
        Me.FormPelanggan.Size = New System.Drawing.Size(173, 38)
        Me.FormPelanggan.TabIndex = 87
        Me.FormPelanggan.Text = "Pelanggan"
        Me.FormPelanggan.UseVisualStyleBackColor = True
        '
        'MuatUlangData
        '
        Me.MuatUlangData.Location = New System.Drawing.Point(1089, 113)
        Me.MuatUlangData.Name = "MuatUlangData"
        Me.MuatUlangData.Size = New System.Drawing.Size(157, 33)
        Me.MuatUlangData.TabIndex = 86
        Me.MuatUlangData.Text = "Muat Ulang Data"
        Me.MuatUlangData.UseVisualStyleBackColor = True
        '
        'Cari
        '
        Me.Cari.Location = New System.Drawing.Point(932, 115)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(106, 33)
        Me.Cari.TabIndex = 85
        Me.Cari.Text = "Cari"
        Me.Cari.UseVisualStyleBackColor = True
        '
        'KataKunci
        '
        Me.KataKunci.Location = New System.Drawing.Point(642, 115)
        Me.KataKunci.Name = "KataKunci"
        Me.KataKunci.Size = New System.Drawing.Size(284, 26)
        Me.KataKunci.TabIndex = 84
        '
        'TabelKaryawan
        '
        Me.TabelKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelKaryawan.Location = New System.Drawing.Point(642, 161)
        Me.TabelKaryawan.Name = "TabelKaryawan"
        Me.TabelKaryawan.RowTemplate.Height = 28
        Me.TabelKaryawan.Size = New System.Drawing.Size(604, 449)
        Me.TabelKaryawan.TabIndex = 83
        '
        'Hapus
        '
        Me.Hapus.Location = New System.Drawing.Point(228, 563)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(365, 47)
        Me.Hapus.TabIndex = 82
        Me.Hapus.Text = "Hapus"
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'Sunting
        '
        Me.Sunting.Location = New System.Drawing.Point(228, 498)
        Me.Sunting.Name = "Sunting"
        Me.Sunting.Size = New System.Drawing.Size(365, 47)
        Me.Sunting.TabIndex = 81
        Me.Sunting.Text = "Sunting"
        Me.Sunting.UseVisualStyleBackColor = True
        '
        'Simpan
        '
        Me.Simpan.Location = New System.Drawing.Point(228, 435)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(365, 47)
        Me.Simpan.TabIndex = 80
        Me.Simpan.Text = "Simpan"
        Me.Simpan.UseVisualStyleBackColor = True
        '
        'Telepon
        '
        Me.Telepon.Location = New System.Drawing.Point(228, 320)
        Me.Telepon.Name = "Telepon"
        Me.Telepon.Size = New System.Drawing.Size(365, 26)
        Me.Telepon.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(224, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Telepon"
        '
        'Alamat
        '
        Me.Alamat.Location = New System.Drawing.Point(228, 251)
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Size = New System.Drawing.Size(365, 26)
        Me.Alamat.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Alamat"
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(228, 387)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(365, 26)
        Me.Email.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(224, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Email"
        '
        'Nama
        '
        Me.Nama.Location = New System.Drawing.Point(228, 185)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(365, 26)
        Me.Nama.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Nama"
        '
        'ID
        '
        Me.ID.Enabled = False
        Me.ID.Location = New System.Drawing.Point(228, 116)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(365, 26)
        Me.ID.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 20)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 37)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Daftar Pelanggan"
        '
        'Pelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 631)
        Me.Controls.Add(Me.Keluar)
        Me.Controls.Add(Me.FormTransaksi)
        Me.Controls.Add(Me.FormKaryawan)
        Me.Controls.Add(Me.FormPelanggan)
        Me.Controls.Add(Me.MuatUlangData)
        Me.Controls.Add(Me.Cari)
        Me.Controls.Add(Me.KataKunci)
        Me.Controls.Add(Me.TabelKaryawan)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.Sunting)
        Me.Controls.Add(Me.Simpan)
        Me.Controls.Add(Me.Telepon)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Alamat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pelanggan"
        Me.Text = "Pelanggan"
        CType(Me.TabelKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Keluar As System.Windows.Forms.Button
    Friend WithEvents FormTransaksi As System.Windows.Forms.Button
    Friend WithEvents FormKaryawan As System.Windows.Forms.Button
    Friend WithEvents FormPelanggan As System.Windows.Forms.Button
    Friend WithEvents MuatUlangData As System.Windows.Forms.Button
    Friend WithEvents Cari As System.Windows.Forms.Button
    Friend WithEvents KataKunci As System.Windows.Forms.TextBox
    Friend WithEvents TabelKaryawan As System.Windows.Forms.DataGridView
    Friend WithEvents Hapus As System.Windows.Forms.Button
    Friend WithEvents Sunting As System.Windows.Forms.Button
    Friend WithEvents Simpan As System.Windows.Forms.Button
    Friend WithEvents Telepon As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Alamat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Email As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
