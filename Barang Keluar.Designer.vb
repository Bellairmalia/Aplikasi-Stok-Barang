<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barang_Keluar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Barang_Keluar))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Cari = New System.Windows.Forms.Button()
        Me.btn_Simpan = New System.Windows.Forms.Button()
        Me.txt_StokBarang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_HargaKeluar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_JumlahKeluar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_NamaBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_KodeBarang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTP_Keluar = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_IdKeluar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.KembaliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGV_BarangKeluar = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_IdMasuk = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_Hitung = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_TotalHarga = New System.Windows.Forms.TextBox()
        Me.btn_LihatBarang = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_LihatBarang = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_SisaStok = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.txt_JumlahStok = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_BarangKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1244, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 12)
        Me.Label12.TabIndex = 333
        Me.Label12.Text = "CANCEL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1144, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 12)
        Me.Label11.TabIndex = 332
        Me.Label11.Text = "CARI"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1021, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 12)
        Me.Label9.TabIndex = 330
        Me.Label9.Text = "SIMPAN"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackgroundImage = CType(resources.GetObject("btn_Cancel.BackgroundImage"), System.Drawing.Image)
        Me.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cancel.Location = New System.Drawing.Point(1223, 33)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(87, 59)
        Me.btn_Cancel.TabIndex = 329
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Cari
        '
        Me.btn_Cari.BackgroundImage = CType(resources.GetObject("btn_Cari.BackgroundImage"), System.Drawing.Image)
        Me.btn_Cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cari.Location = New System.Drawing.Point(1114, 33)
        Me.btn_Cari.Name = "btn_Cari"
        Me.btn_Cari.Size = New System.Drawing.Size(87, 59)
        Me.btn_Cari.TabIndex = 328
        Me.btn_Cari.UseVisualStyleBackColor = True
        '
        'btn_Simpan
        '
        Me.btn_Simpan.BackgroundImage = CType(resources.GetObject("btn_Simpan.BackgroundImage"), System.Drawing.Image)
        Me.btn_Simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Simpan.Location = New System.Drawing.Point(1005, 33)
        Me.btn_Simpan.Name = "btn_Simpan"
        Me.btn_Simpan.Size = New System.Drawing.Size(87, 59)
        Me.btn_Simpan.TabIndex = 326
        Me.btn_Simpan.UseVisualStyleBackColor = True
        '
        'txt_StokBarang
        '
        Me.txt_StokBarang.Location = New System.Drawing.Point(435, 69)
        Me.txt_StokBarang.Name = "txt_StokBarang"
        Me.txt_StokBarang.Size = New System.Drawing.Size(81, 20)
        Me.txt_StokBarang.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(335, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Stok Barang"
        '
        'txt_HargaKeluar
        '
        Me.txt_HargaKeluar.Location = New System.Drawing.Point(640, 105)
        Me.txt_HargaKeluar.Name = "txt_HargaKeluar"
        Me.txt_HargaKeluar.Size = New System.Drawing.Size(104, 20)
        Me.txt_HargaKeluar.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(552, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Harga Keluar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Transaksi Keluar"
        '
        'txt_JumlahKeluar
        '
        Me.txt_JumlahKeluar.Location = New System.Drawing.Point(435, 104)
        Me.txt_JumlahKeluar.Name = "txt_JumlahKeluar"
        Me.txt_JumlahKeluar.Size = New System.Drawing.Size(81, 20)
        Me.txt_JumlahKeluar.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(335, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Keluar"
        '
        'txt_NamaBarang
        '
        Me.txt_NamaBarang.Location = New System.Drawing.Point(120, 105)
        Me.txt_NamaBarang.Name = "txt_NamaBarang"
        Me.txt_NamaBarang.Size = New System.Drawing.Size(180, 20)
        Me.txt_NamaBarang.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Barang"
        '
        'txt_KodeBarang
        '
        Me.txt_KodeBarang.Location = New System.Drawing.Point(120, 73)
        Me.txt_KodeBarang.Name = "txt_KodeBarang"
        Me.txt_KodeBarang.Size = New System.Drawing.Size(129, 20)
        Me.txt_KodeBarang.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kode Barang"
        '
        'DTP_Keluar
        '
        Me.DTP_Keluar.Location = New System.Drawing.Point(415, 16)
        Me.DTP_Keluar.Name = "DTP_Keluar"
        Me.DTP_Keluar.Size = New System.Drawing.Size(152, 20)
        Me.DTP_Keluar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tanggal Keluar"
        '
        'txt_IdKeluar
        '
        Me.txt_IdKeluar.Location = New System.Drawing.Point(125, 16)
        Me.txt_IdKeluar.Name = "txt_IdKeluar"
        Me.txt_IdKeluar.Size = New System.Drawing.Size(152, 20)
        Me.txt_IdKeluar.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_IdMasuk)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DTP_Keluar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_IdKeluar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1338, 49)
        Me.GroupBox1.TabIndex = 328
        Me.GroupBox1.TabStop = False
        '
        'KembaliToolStripMenuItem
        '
        Me.KembaliToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KembaliToolStripMenuItem.Name = "KembaliToolStripMenuItem"
        Me.KembaliToolStripMenuItem.Size = New System.Drawing.Size(103, 23)
        Me.KembaliToolStripMenuItem.Text = "<<= Kembali"
        '
        'DGV_BarangKeluar
        '
        Me.DGV_BarangKeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_BarangKeluar.Location = New System.Drawing.Point(12, 242)
        Me.DGV_BarangKeluar.Name = "DGV_BarangKeluar"
        Me.DGV_BarangKeluar.Size = New System.Drawing.Size(1338, 454)
        Me.DGV_BarangKeluar.TabIndex = 329
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_JumlahStok)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.btn_LihatBarang)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txt_LihatBarang)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_JumlahKeluar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btn_Cancel)
        Me.GroupBox2.Controls.Add(Me.btn_Cari)
        Me.GroupBox2.Controls.Add(Me.btn_Simpan)
        Me.GroupBox2.Controls.Add(Me.txt_StokBarang)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_HargaKeluar)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_SisaStok)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_NamaBarang)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_KodeBarang)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1338, 142)
        Me.GroupBox2.TabIndex = 326
        Me.GroupBox2.TabStop = False
        '
        'txt_IdMasuk
        '
        Me.txt_IdMasuk.Location = New System.Drawing.Point(735, 16)
        Me.txt_IdMasuk.Name = "txt_IdMasuk"
        Me.txt_IdMasuk.Size = New System.Drawing.Size(152, 20)
        Me.txt_IdMasuk.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(627, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "ID Transaksi Masuk"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.btn_Hitung)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_TotalHarga)
        Me.GroupBox3.Location = New System.Drawing.Point(766, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(211, 120)
        Me.GroupBox3.TabIndex = 337
        Me.GroupBox3.TabStop = False
        '
        'btn_Hitung
        '
        Me.btn_Hitung.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Hitung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Hitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Hitung.ForeColor = System.Drawing.Color.White
        Me.btn_Hitung.Location = New System.Drawing.Point(8, 90)
        Me.btn_Hitung.Name = "btn_Hitung"
        Me.btn_Hitung.Size = New System.Drawing.Size(197, 24)
        Me.btn_Hitung.TabIndex = 342
        Me.btn_Hitung.Text = "Hitung"
        Me.btn_Hitung.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(59, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 18)
        Me.Label15.TabIndex = 341
        Me.Label15.Text = "Total Harga"
        '
        'txt_TotalHarga
        '
        Me.txt_TotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalHarga.Location = New System.Drawing.Point(8, 36)
        Me.txt_TotalHarga.Multiline = True
        Me.txt_TotalHarga.Name = "txt_TotalHarga"
        Me.txt_TotalHarga.Size = New System.Drawing.Size(197, 48)
        Me.txt_TotalHarga.TabIndex = 340
        Me.txt_TotalHarga.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt_TotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_LihatBarang
        '
        Me.btn_LihatBarang.BackColor = System.Drawing.Color.White
        Me.btn_LihatBarang.BackgroundImage = CType(resources.GetObject("btn_LihatBarang.BackgroundImage"), System.Drawing.Image)
        Me.btn_LihatBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_LihatBarang.Location = New System.Drawing.Point(397, 12)
        Me.btn_LihatBarang.Name = "btn_LihatBarang"
        Me.btn_LihatBarang.Size = New System.Drawing.Size(55, 23)
        Me.btn_LihatBarang.TabIndex = 335
        Me.btn_LihatBarang.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(117, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(335, 13)
        Me.Label14.TabIndex = 336
        Me.Label14.Text = "* Berdasarkan ID Transaksi Masuk, Kode Barang, atau Nama Barang"
        '
        'txt_LihatBarang
        '
        Me.txt_LihatBarang.Location = New System.Drawing.Point(120, 14)
        Me.txt_LihatBarang.Name = "txt_LihatBarang"
        Me.txt_LihatBarang.Size = New System.Drawing.Size(271, 20)
        Me.txt_LihatBarang.TabIndex = 335
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 334
        Me.Label13.Text = "Cari Barang"
        '
        'txt_SisaStok
        '
        Me.txt_SisaStok.Location = New System.Drawing.Point(640, 67)
        Me.txt_SisaStok.Name = "txt_SisaStok"
        Me.txt_SisaStok.Size = New System.Drawing.Size(81, 20)
        Me.txt_SisaStok.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(552, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Sisa Stok"
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
        'txt_JumlahStok
        '
        Me.txt_JumlahStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_JumlahStok.Location = New System.Drawing.Point(640, 19)
        Me.txt_JumlahStok.Multiline = True
        Me.txt_JumlahStok.Name = "txt_JumlahStok"
        Me.txt_JumlahStok.Size = New System.Drawing.Size(81, 31)
        Me.txt_JumlahStok.TabIndex = 339
        Me.txt_JumlahStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(552, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 338
        Me.Label16.Text = "Jumlah Stok"
        '
        'Barang_Keluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV_BarangKeluar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "Barang_Keluar"
        Me.Text = "Barang_Keluar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_BarangKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Cari As System.Windows.Forms.Button
    Friend WithEvents btn_Simpan As System.Windows.Forms.Button
    Friend WithEvents txt_StokBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_HargaKeluar As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_JumlahKeluar As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_NamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_KodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTP_Keluar As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_IdKeluar As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents KembaliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DGV_BarangKeluar As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents txt_SisaStok As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_LihatBarang As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_LihatBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Hitung As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_TotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents txt_IdMasuk As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_JumlahStok As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
