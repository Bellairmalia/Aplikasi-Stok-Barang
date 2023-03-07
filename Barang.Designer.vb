<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Barang))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_Lokasi = New System.Windows.Forms.ComboBox()
        Me.txt_NamaBarang = New System.Windows.Forms.TextBox()
        Me.txt_KodeBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.DGV_Barang = New System.Windows.Forms.DataGridView()
        Me.cmb_Satuan = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_Satuan)
        Me.GroupBox1.Controls.Add(Me.cmb_Lokasi)
        Me.GroupBox1.Controls.Add(Me.txt_NamaBarang)
        Me.GroupBox1.Controls.Add(Me.txt_KodeBarang)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmb_Lokasi
        '
        Me.cmb_Lokasi.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Lokasi.FormattingEnabled = True
        Me.cmb_Lokasi.Items.AddRange(New Object() {"Rak 1 Tingkat 1", "Rak 1 Tingkat 2", "Rak 1 Tingkat 3", "Rak 1 Tingkat 4", "Rak 2 Tingkat 1 ", "Rak 2 Tingkat 2 ", "Rak 2 Tingkat 3 ", "Rak 2 Tingkat 4 ", "Rak 3 Tingkat 1", "Rak 3 Tingkat 2", "Rak 3 Tingkat 3", "Rak 3 Tingkat 4", "Rak 4 Tingkat 1", "Rak 4 Tingkat 2", "Rak 4 Tingkat 3", "Rak 4 Tingkat 4", "Rak 5 Tingkat 1", "Rak 5 Tingkat 2", "Rak 5 Tingkat 3", "Rak 5 Tingkat 4"})
        Me.cmb_Lokasi.Location = New System.Drawing.Point(412, 53)
        Me.cmb_Lokasi.Name = "cmb_Lokasi"
        Me.cmb_Lokasi.Size = New System.Drawing.Size(161, 23)
        Me.cmb_Lokasi.TabIndex = 328
        Me.cmb_Lokasi.Text = "- Pilih Lokasi"
        '
        'txt_NamaBarang
        '
        Me.txt_NamaBarang.Location = New System.Drawing.Point(123, 56)
        Me.txt_NamaBarang.Name = "txt_NamaBarang"
        Me.txt_NamaBarang.Size = New System.Drawing.Size(161, 20)
        Me.txt_NamaBarang.TabIndex = 4
        '
        'txt_KodeBarang
        '
        Me.txt_KodeBarang.Location = New System.Drawing.Point(123, 21)
        Me.txt_KodeBarang.Name = "txt_KodeBarang"
        Me.txt_KodeBarang.Size = New System.Drawing.Size(161, 20)
        Me.txt_KodeBarang.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Lokasi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(333, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Satuan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btn_hapus)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btn_cari)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Controls.Add(Me.btn_simpan)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 75)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(110, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 297
        Me.Label5.Text = "Simpan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(338, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 296
        Me.Label6.Text = "Cari"
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.Color.White
        Me.btn_hapus.BackgroundImage = CType(resources.GetObject("btn_hapus.BackgroundImage"), System.Drawing.Image)
        Me.btn_hapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_hapus.Location = New System.Drawing.Point(424, 10)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(83, 37)
        Me.btn_hapus.TabIndex = 298
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(443, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 295
        Me.Label7.Text = "Hapus"
        '
        'btn_cari
        '
        Me.btn_cari.BackColor = System.Drawing.Color.White
        Me.btn_cari.BackgroundImage = CType(resources.GetObject("btn_cari.BackgroundImage"), System.Drawing.Image)
        Me.btn_cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cari.Location = New System.Drawing.Point(314, 10)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(83, 37)
        Me.btn_cari.TabIndex = 293
        Me.btn_cari.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(231, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 15)
        Me.Label8.TabIndex = 294
        Me.Label8.Text = "Edit"
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.White
        Me.btn_edit.BackgroundImage = CType(resources.GetObject("btn_edit.BackgroundImage"), System.Drawing.Image)
        Me.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_edit.Location = New System.Drawing.Point(203, 10)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(83, 37)
        Me.btn_edit.TabIndex = 292
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.White
        Me.btn_simpan.BackgroundImage = CType(resources.GetObject("btn_simpan.BackgroundImage"), System.Drawing.Image)
        Me.btn_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_simpan.Location = New System.Drawing.Point(92, 10)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(83, 37)
        Me.btn_simpan.TabIndex = 291
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'DGV_Barang
        '
        Me.DGV_Barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Barang.Location = New System.Drawing.Point(12, 195)
        Me.DGV_Barang.Name = "DGV_Barang"
        Me.DGV_Barang.Size = New System.Drawing.Size(600, 219)
        Me.DGV_Barang.TabIndex = 299
        '
        'cmb_Satuan
        '
        Me.cmb_Satuan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Satuan.FormattingEnabled = True
        Me.cmb_Satuan.Items.AddRange(New Object() {"Sachet", "Kg", "Botol", "Dus", "Bungkus", "Kaleng", "Buah", "Tablet", "Gelas", "Roll", "Pcs"})
        Me.cmb_Satuan.Location = New System.Drawing.Point(412, 21)
        Me.cmb_Satuan.Name = "cmb_Satuan"
        Me.cmb_Satuan.Size = New System.Drawing.Size(161, 23)
        Me.cmb_Satuan.TabIndex = 329
        Me.cmb_Satuan.Text = "- Pilih Satuan"
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(626, 426)
        Me.Controls.Add(Me.DGV_Barang)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Barang"
        Me.Text = "Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_NamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents txt_KodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_cari As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents cmb_Lokasi As System.Windows.Forms.ComboBox
    Friend WithEvents DGV_Barang As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_Satuan As System.Windows.Forms.ComboBox
End Class
