<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barang_Masuk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Barang_Masuk))
        Me.DGV_BarangMasuk = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_CariBarang = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_LihatBarang = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_NamaSupplier = New System.Windows.Forms.TextBox()
        Me.btn_Cari = New System.Windows.Forms.Button()
        Me.btn_Simpan = New System.Windows.Forms.Button()
        Me.txt_JumlahMasuk = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_HargaKeluar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_HargaMasuk = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_StokBarang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_NamaBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_KodeBarang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.KembaliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTP_Masuk = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_IdMasuk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV_BarangMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_BarangMasuk
        '
        Me.DGV_BarangMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_BarangMasuk.Location = New System.Drawing.Point(12, 239)
        Me.DGV_BarangMasuk.Name = "DGV_BarangMasuk"
        Me.DGV_BarangMasuk.Size = New System.Drawing.Size(1338, 465)
        Me.DGV_BarangMasuk.TabIndex = 329
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(124, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(251, 13)
        Me.Label14.TabIndex = 337
        Me.Label14.Text = "* Cari berdasarkan Nama Barang atau Kode Barang"
        '
        'txt_CariBarang
        '
        Me.txt_CariBarang.Location = New System.Drawing.Point(127, 14)
        Me.txt_CariBarang.Name = "txt_CariBarang"
        Me.txt_CariBarang.Size = New System.Drawing.Size(197, 20)
        Me.txt_CariBarang.TabIndex = 336
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 335
        Me.Label13.Text = "Cari Barang"
        '
        'btn_LihatBarang
        '
        Me.btn_LihatBarang.BackColor = System.Drawing.Color.White
        Me.btn_LihatBarang.BackgroundImage = CType(resources.GetObject("btn_LihatBarang.BackgroundImage"), System.Drawing.Image)
        Me.btn_LihatBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_LihatBarang.Location = New System.Drawing.Point(330, 12)
        Me.btn_LihatBarang.Name = "btn_LihatBarang"
        Me.btn_LihatBarang.Size = New System.Drawing.Size(45, 23)
        Me.btn_LihatBarang.TabIndex = 334
        Me.btn_LihatBarang.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1227, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 12)
        Me.Label12.TabIndex = 333
        Me.Label12.Text = "CANCEL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1077, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 12)
        Me.Label11.TabIndex = 332
        Me.Label11.Text = "CARI"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(913, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 12)
        Me.Label9.TabIndex = 330
        Me.Label9.Text = "SIMPAN"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackgroundImage = CType(resources.GetObject("btn_Cancel.BackgroundImage"), System.Drawing.Image)
        Me.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cancel.Location = New System.Drawing.Point(1187, 33)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(128, 68)
        Me.btn_Cancel.TabIndex = 329
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_NamaSupplier)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txt_CariBarang)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.btn_LihatBarang)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btn_Cancel)
        Me.GroupBox2.Controls.Add(Me.btn_Cari)
        Me.GroupBox2.Controls.Add(Me.btn_Simpan)
        Me.GroupBox2.Controls.Add(Me.txt_JumlahMasuk)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_HargaKeluar)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_HargaMasuk)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_StokBarang)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_NamaBarang)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_KodeBarang)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1338, 131)
        Me.GroupBox2.TabIndex = 326
        Me.GroupBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(327, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 339
        Me.Label10.Text = "Nama Supplier"
        '
        'txt_NamaSupplier
        '
        Me.txt_NamaSupplier.Location = New System.Drawing.Point(442, 63)
        Me.txt_NamaSupplier.Name = "txt_NamaSupplier"
        Me.txt_NamaSupplier.Size = New System.Drawing.Size(114, 20)
        Me.txt_NamaSupplier.TabIndex = 338
        '
        'btn_Cari
        '
        Me.btn_Cari.BackgroundImage = CType(resources.GetObject("btn_Cari.BackgroundImage"), System.Drawing.Image)
        Me.btn_Cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cari.Location = New System.Drawing.Point(1030, 33)
        Me.btn_Cari.Name = "btn_Cari"
        Me.btn_Cari.Size = New System.Drawing.Size(128, 68)
        Me.btn_Cari.TabIndex = 328
        Me.btn_Cari.UseVisualStyleBackColor = True
        '
        'btn_Simpan
        '
        Me.btn_Simpan.BackgroundImage = CType(resources.GetObject("btn_Simpan.BackgroundImage"), System.Drawing.Image)
        Me.btn_Simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Simpan.Location = New System.Drawing.Point(875, 33)
        Me.btn_Simpan.Name = "btn_Simpan"
        Me.btn_Simpan.Size = New System.Drawing.Size(128, 68)
        Me.btn_Simpan.TabIndex = 326
        Me.btn_Simpan.UseVisualStyleBackColor = True
        '
        'txt_JumlahMasuk
        '
        Me.txt_JumlahMasuk.Location = New System.Drawing.Point(707, 19)
        Me.txt_JumlahMasuk.Name = "txt_JumlahMasuk"
        Me.txt_JumlahMasuk.Size = New System.Drawing.Size(127, 20)
        Me.txt_JumlahMasuk.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(327, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Stok Barang"
        '
        'txt_HargaKeluar
        '
        Me.txt_HargaKeluar.Location = New System.Drawing.Point(707, 96)
        Me.txt_HargaKeluar.Name = "txt_HargaKeluar"
        Me.txt_HargaKeluar.Size = New System.Drawing.Size(127, 20)
        Me.txt_HargaKeluar.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(603, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Harga Keluar"
        '
        'txt_HargaMasuk
        '
        Me.txt_HargaMasuk.Location = New System.Drawing.Point(707, 58)
        Me.txt_HargaMasuk.Name = "txt_HargaMasuk"
        Me.txt_HargaMasuk.Size = New System.Drawing.Size(127, 20)
        Me.txt_HargaMasuk.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(603, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Harga Masuk"
        '
        'txt_StokBarang
        '
        Me.txt_StokBarang.Location = New System.Drawing.Point(442, 96)
        Me.txt_StokBarang.Name = "txt_StokBarang"
        Me.txt_StokBarang.Size = New System.Drawing.Size(114, 20)
        Me.txt_StokBarang.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(592, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Masuk"
        '
        'txt_NamaBarang
        '
        Me.txt_NamaBarang.Location = New System.Drawing.Point(127, 97)
        Me.txt_NamaBarang.Name = "txt_NamaBarang"
        Me.txt_NamaBarang.Size = New System.Drawing.Size(164, 20)
        Me.txt_NamaBarang.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Barang"
        '
        'txt_KodeBarang
        '
        Me.txt_KodeBarang.Location = New System.Drawing.Point(127, 63)
        Me.txt_KodeBarang.Name = "txt_KodeBarang"
        Me.txt_KodeBarang.Size = New System.Drawing.Size(113, 20)
        Me.txt_KodeBarang.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kode Barang"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KembaliToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1370, 27)
        Me.MenuStrip2.TabIndex = 327
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'KembaliToolStripMenuItem
        '
        Me.KembaliToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KembaliToolStripMenuItem.Name = "KembaliToolStripMenuItem"
        Me.KembaliToolStripMenuItem.Size = New System.Drawing.Size(103, 23)
        Me.KembaliToolStripMenuItem.Text = "<<= Kembali"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTP_Masuk)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_IdMasuk)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1338, 49)
        Me.GroupBox1.TabIndex = 328
        Me.GroupBox1.TabStop = False
        '
        'DTP_Masuk
        '
        Me.DTP_Masuk.Location = New System.Drawing.Point(415, 16)
        Me.DTP_Masuk.Name = "DTP_Masuk"
        Me.DTP_Masuk.Size = New System.Drawing.Size(152, 20)
        Me.DTP_Masuk.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tanggal Masuk"
        '
        'txt_IdMasuk
        '
        Me.txt_IdMasuk.Location = New System.Drawing.Point(127, 16)
        Me.txt_IdMasuk.Name = "txt_IdMasuk"
        Me.txt_IdMasuk.Size = New System.Drawing.Size(152, 20)
        Me.txt_IdMasuk.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Transaksi Masuk"
        '
        'Barang_Masuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 722)
        Me.Controls.Add(Me.DGV_BarangMasuk)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Barang_Masuk"
        Me.Text = "Barang_Masuk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV_BarangMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_BarangMasuk As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_CariBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btn_LihatBarang As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cari As System.Windows.Forms.Button
    Friend WithEvents btn_Simpan As System.Windows.Forms.Button
    Friend WithEvents txt_JumlahMasuk As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_HargaKeluar As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_HargaMasuk As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_StokBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_NamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_KodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents KembaliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DTP_Masuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_IdMasuk As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_NamaSupplier As System.Windows.Forms.TextBox
End Class
