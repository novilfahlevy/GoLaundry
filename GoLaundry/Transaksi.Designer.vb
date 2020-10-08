<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
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
        Me.TanggalPengambilan = New System.Windows.Forms.DateTimePicker()
        Me.TanggalTerima = New System.Windows.Forms.DateTimePicker()
        Me.Catatan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IDPelanggan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IDKaryawan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
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
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TabelKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TanggalPengambilan
        '
        Me.TanggalPengambilan.Location = New System.Drawing.Point(236, 248)
        Me.TanggalPengambilan.Name = "TanggalPengambilan"
        Me.TanggalPengambilan.Size = New System.Drawing.Size(365, 26)
        Me.TanggalPengambilan.TabIndex = 128
        '
        'TanggalTerima
        '
        Me.TanggalTerima.Location = New System.Drawing.Point(236, 182)
        Me.TanggalTerima.Name = "TanggalTerima"
        Me.TanggalTerima.Size = New System.Drawing.Size(365, 26)
        Me.TanggalTerima.TabIndex = 127
        '
        'Catatan
        '
        Me.Catatan.Location = New System.Drawing.Point(236, 438)
        Me.Catatan.Name = "Catatan"
        Me.Catatan.Size = New System.Drawing.Size(365, 26)
        Me.Catatan.TabIndex = 126
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Catatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Pelanggan"
        '
        'IDPelanggan
        '
        Me.IDPelanggan.FormattingEnabled = True
        Me.IDPelanggan.Location = New System.Drawing.Point(236, 373)
        Me.IDPelanggan.Name = "IDPelanggan"
        Me.IDPelanggan.Size = New System.Drawing.Size(365, 28)
        Me.IDPelanggan.TabIndex = 123
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Karyawan"
        '
        'IDKaryawan
        '
        Me.IDKaryawan.FormattingEnabled = True
        Me.IDKaryawan.Location = New System.Drawing.Point(236, 312)
        Me.IDKaryawan.Name = "IDKaryawan"
        Me.IDKaryawan.Size = New System.Drawing.Size(365, 28)
        Me.IDKaryawan.TabIndex = 121
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 20)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Tanggal Pengambilan"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(232, 159)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(118, 20)
        Me.Label.TabIndex = 119
        Me.Label.Text = "Tanggal Terima"
        '
        'Keluar
        '
        Me.Keluar.Location = New System.Drawing.Point(20, 554)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(181, 36)
        Me.Keluar.TabIndex = 118
        Me.Keluar.Text = "Keluar"
        Me.Keluar.UseVisualStyleBackColor = True
        '
        'FormTransaksi
        '
        Me.FormTransaksi.Enabled = False
        Me.FormTransaksi.Location = New System.Drawing.Point(20, 183)
        Me.FormTransaksi.Name = "FormTransaksi"
        Me.FormTransaksi.Size = New System.Drawing.Size(181, 36)
        Me.FormTransaksi.TabIndex = 117
        Me.FormTransaksi.Text = "Transaksi"
        Me.FormTransaksi.UseVisualStyleBackColor = True
        '
        'FormKaryawan
        '
        Me.FormKaryawan.Location = New System.Drawing.Point(20, 139)
        Me.FormKaryawan.Name = "FormKaryawan"
        Me.FormKaryawan.Size = New System.Drawing.Size(181, 38)
        Me.FormKaryawan.TabIndex = 116
        Me.FormKaryawan.Text = "Karyawan"
        Me.FormKaryawan.UseVisualStyleBackColor = True
        '
        'FormPelanggan
        '
        Me.FormPelanggan.Location = New System.Drawing.Point(20, 95)
        Me.FormPelanggan.Name = "FormPelanggan"
        Me.FormPelanggan.Size = New System.Drawing.Size(181, 38)
        Me.FormPelanggan.TabIndex = 115
        Me.FormPelanggan.Text = "Pelanggan"
        Me.FormPelanggan.UseVisualStyleBackColor = True
        '
        'MuatUlangData
        '
        Me.MuatUlangData.Location = New System.Drawing.Point(1097, 111)
        Me.MuatUlangData.Name = "MuatUlangData"
        Me.MuatUlangData.Size = New System.Drawing.Size(157, 33)
        Me.MuatUlangData.TabIndex = 114
        Me.MuatUlangData.Text = "Muat Ulang Data"
        Me.MuatUlangData.UseVisualStyleBackColor = True
        '
        'Cari
        '
        Me.Cari.Location = New System.Drawing.Point(940, 113)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(106, 33)
        Me.Cari.TabIndex = 113
        Me.Cari.Text = "Cari"
        Me.Cari.UseVisualStyleBackColor = True
        '
        'KataKunci
        '
        Me.KataKunci.Location = New System.Drawing.Point(650, 113)
        Me.KataKunci.Name = "KataKunci"
        Me.KataKunci.Size = New System.Drawing.Size(284, 26)
        Me.KataKunci.TabIndex = 112
        '
        'TabelKaryawan
        '
        Me.TabelKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelKaryawan.Location = New System.Drawing.Point(650, 159)
        Me.TabelKaryawan.Name = "TabelKaryawan"
        Me.TabelKaryawan.RowTemplate.Height = 28
        Me.TabelKaryawan.Size = New System.Drawing.Size(604, 431)
        Me.TabelKaryawan.TabIndex = 111
        '
        'Hapus
        '
        Me.Hapus.Location = New System.Drawing.Point(236, 543)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(365, 47)
        Me.Hapus.TabIndex = 110
        Me.Hapus.Text = "Hapus"
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'Sunting
        '
        Me.Sunting.Location = New System.Drawing.Point(424, 490)
        Me.Sunting.Name = "Sunting"
        Me.Sunting.Size = New System.Drawing.Size(177, 47)
        Me.Sunting.TabIndex = 109
        Me.Sunting.Text = "Sunting"
        Me.Sunting.UseVisualStyleBackColor = True
        '
        'Simpan
        '
        Me.Simpan.Location = New System.Drawing.Point(236, 490)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(182, 47)
        Me.Simpan.TabIndex = 108
        Me.Simpan.Text = "Simpan"
        Me.Simpan.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.Enabled = False
        Me.ID.Location = New System.Drawing.Point(236, 114)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(365, 26)
        Me.ID.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 20)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 37)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Daftar Transaksi"
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 609)
        Me.Controls.Add(Me.TanggalPengambilan)
        Me.Controls.Add(Me.TanggalTerima)
        Me.Controls.Add(Me.Catatan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IDPelanggan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IDKaryawan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label)
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
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        CType(Me.TabelKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TanggalPengambilan As System.Windows.Forms.DateTimePicker
    Friend WithEvents TanggalTerima As System.Windows.Forms.DateTimePicker
    Friend WithEvents Catatan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IDPelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IDKaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
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
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
