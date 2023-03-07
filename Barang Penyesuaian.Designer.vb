<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barang_Penyesuaian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Barang_Penyesuaian))
        Me.DGV_Penyesuaian = New System.Windows.Forms.DataGridView()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.KembaliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTP_Penye = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_IdPenye = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_JumlahPenye = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_NamaBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_KodeBarang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_IdMasuk = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Cari = New System.Windows.Forms.Button()
        Me.btn_Simpan = New System.Windows.Forms.Button()
        Me.btn_LihatBarang = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_LihatBarang = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_StokBarang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Keterangan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DGV_Penyesuaian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Penyesuaian
        '
        Me.DGV_Penyesuaian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Penyesuaian.Location = New System.Drawing.Point(12, 246)
        Me.DGV_Penyesuaian.Name = "DGV_Penyesuaian"
        Me.DGV_Penyesuaian.Size = New System.Drawing.Size(1338, 450)
        Me.DGV_Penyesuaian.TabIndex = 333
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KembaliToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1370, 27)
        Me.MenuStrip2.TabIndex = 331
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
        Me.GroupBox1.Controls.Add(Me.txt_IdMasuk)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DTP_Penye)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_IdPenye)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1338, 49)
        Me.GroupBox1.TabIndex = 332
        Me.GroupBox1.TabStop = False
        '
        'DTP_Penye
        '
        Me.DTP_Penye.Location = New System.Drawing.Point(501, 16)
        Me.DTP_Penye.Name = "DTP_Penye"
        Me.DTP_Penye.Size = New System.Drawing.Size(152, 20)
        Me.DTP_Penye.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(388, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tanggal Penyesuaian"
        '
        'txt_IdPenye
        '
        Me.txt_IdPenye.Location = New System.Drawing.Point(154, 16)
        Me.txt_IdPenye.Name = "txt_IdPenye"
        Me.txt_IdPenye.Size = New System.Drawing.Size(152, 20)
        Me.txt_IdPenye.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Transaksi Penyesuaian"
        '
        'txt_JumlahPenye
        '
        Me.txt_JumlahPenye.Location = New System.Drawing.Point(497, 107)
        Me.txt_JumlahPenye.Name = "txt_JumlahPenye"
        Me.txt_JumlahPenye.Size = New System.Drawing.Size(114, 20)
        Me.txt_JumlahPenye.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(384, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Penyesuaian"
        '
        'txt_NamaBarang
        '
        Me.txt_NamaBarang.Location = New System.Drawing.Point(150, 107)
        Me.txt_NamaBarang.Name = "txt_NamaBarang"
        Me.txt_NamaBarang.Size = New System.Drawing.Size(180, 20)
        Me.txt_NamaBarang.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Barang"
        '
        'txt_KodeBarang
        '
        Me.txt_KodeBarang.Location = New System.Drawing.Point(150, 71)
        Me.txt_KodeBarang.Name = "txt_KodeBarang"
        Me.txt_KodeBarang.Size = New System.Drawing.Size(180, 20)
        Me.txt_KodeBarang.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kode Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btn_Cancel)
        Me.GroupBox2.Controls.Add(Me.btn_Cari)
        Me.GroupBox2.Controls.Add(Me.btn_Simpan)
        Me.GroupBox2.Controls.Add(Me.btn_LihatBarang)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txt_LihatBarang)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_JumlahPenye)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_StokBarang)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_Keterangan)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_NamaBarang)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_KodeBarang)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1338, 146)
        Me.GroupBox2.TabIndex = 330
        Me.GroupBox2.TabStop = False
        '
        'txt_IdMasuk
        '
        Me.txt_IdMasuk.Location = New System.Drawing.Point(823, 16)
        Me.txt_IdMasuk.Name = "txt_IdMasuk"
        Me.txt_IdMasuk.Size = New System.Drawing.Size(152, 20)
        Me.txt_IdMasuk.TabIndex = 348
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(715, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 347
        Me.Label10.Text = "ID Transaksi Masuk"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1239, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 12)
        Me.Label12.TabIndex = 346
        Me.Label12.Text = "CANCEL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1139, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 12)
        Me.Label11.TabIndex = 345
        Me.Label11.Text = "CARI"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1016, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 12)
        Me.Label9.TabIndex = 344
        Me.Label9.Text = "SIMPAN"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackgroundImage = CType(resources.GetObject("btn_Cancel.BackgroundImage"), System.Drawing.Image)
        Me.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cancel.Location = New System.Drawing.Point(1218, 39)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(87, 59)
        Me.btn_Cancel.TabIndex = 343
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Cari
        '
        Me.btn_Cari.BackgroundImage = CType(resources.GetObject("btn_Cari.BackgroundImage"), System.Drawing.Image)
        Me.btn_Cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cari.Location = New System.Drawing.Point(1109, 39)
        Me.btn_Cari.Name = "btn_Cari"
        Me.btn_Cari.Size = New System.Drawing.Size(87, 59)
        Me.btn_Cari.TabIndex = 342
        Me.btn_Cari.UseVisualStyleBackColor = True
        '
        'btn_Simpan
        '
        Me.btn_Simpan.BackgroundImage = CType(resources.GetObject("btn_Simpan.BackgroundImage"), System.Drawing.Image)
        Me.btn_Simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Simpan.Location = New System.Drawing.Point(1000, 39)
        Me.btn_Simpan.Name = "btn_Simpan"
        Me.btn_Simpan.Size = New System.Drawing.Size(87, 59)
        Me.btn_Simpan.TabIndex = 341
        Me.btn_Simpan.UseVisualStyleBackColor = True
        '
        'btn_LihatBarang
        '
        Me.btn_LihatBarang.BackColor = System.Drawing.Color.White
        Me.btn_LihatBarang.BackgroundImage = CType(resources.GetObject("btn_LihatBarang.BackgroundImage"), System.Drawing.Image)
        Me.btn_LihatBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_LihatBarang.Location = New System.Drawing.Point(427, 14)
        Me.btn_LihatBarang.Name = "btn_LihatBarang"
        Me.btn_LihatBarang.Size = New System.Drawing.Size(55, 23)
        Me.btn_LihatBarang.TabIndex = 338
        Me.btn_LihatBarang.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(147, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(335, 13)
        Me.Label14.TabIndex = 340
        Me.Label14.Text = "* Berdasarkan ID Transaksi Masuk, Kode Barang, atau Nama Barang"
        '
        'txt_LihatBarang
        '
        Me.txt_LihatBarang.Location = New System.Drawing.Point(150, 16)
        Me.txt_LihatBarang.Name = "txt_LihatBarang"
        Me.txt_LihatBarang.Size = New System.Drawing.Size(271, 20)
        Me.txt_LihatBarang.TabIndex = 339
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 337
        Me.Label13.Text = "Cari Barang"
        '
        'txt_StokBarang
        '
        Me.txt_StokBarang.Location = New System.Drawing.Point(497, 72)
        Me.txt_StokBarang.Name = "txt_StokBarang"
        Me.txt_StokBarang.Size = New System.Drawing.Size(114, 20)
        Me.txt_StokBarang.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(384, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Stok Barang"
        '
        'txt_Keterangan
        '
        Me.txt_Keterangan.Location = New System.Drawing.Point(749, 68)
        Me.txt_Keterangan.Multiline = True
        Me.txt_Keterangan.Name = "txt_Keterangan"
        Me.txt_Keterangan.Size = New System.Drawing.Size(200, 59)
        Me.txt_Keterangan.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(641, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Keterangan"
        '
        'Barang_Penyesuaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.DGV_Penyesuaian)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Barang_Penyesuaian"
        Me.Text = "Barang_Penyesuaian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV_Penyesuaian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_Penyesuaian As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents KembaliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DTP_Penye As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_IdPenye As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_JumlahPenye As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_NamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_KodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_StokBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Keterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_LihatBarang As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_LihatBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Cari As System.Windows.Forms.Button
    Friend WithEvents btn_Simpan As System.Windows.Forms.Button
    Friend WithEvents txt_IdMasuk As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
