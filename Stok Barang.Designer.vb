<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stok_Barang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stok_Barang))
        Me.DGV_StokBarang = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.txt_NamaBarang = New System.Windows.Forms.TextBox()
        Me.txt_KodeBarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_JumlahStok = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DGV_StokBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_StokBarang
        '
        Me.DGV_StokBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_StokBarang.Location = New System.Drawing.Point(12, 134)
        Me.DGV_StokBarang.Name = "DGV_StokBarang"
        Me.DGV_StokBarang.Size = New System.Drawing.Size(600, 280)
        Me.DGV_StokBarang.TabIndex = 302
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(421, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 296
        Me.Label6.Text = "Cari"
        '
        'btn_cari
        '
        Me.btn_cari.BackColor = System.Drawing.Color.White
        Me.btn_cari.BackgroundImage = CType(resources.GetObject("btn_cari.BackgroundImage"), System.Drawing.Image)
        Me.btn_cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cari.Location = New System.Drawing.Point(412, 56)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(52, 33)
        Me.btn_cari.TabIndex = 293
        Me.btn_cari.UseVisualStyleBackColor = False
        '
        'txt_NamaBarang
        '
        Me.txt_NamaBarang.Location = New System.Drawing.Point(125, 69)
        Me.txt_NamaBarang.Name = "txt_NamaBarang"
        Me.txt_NamaBarang.Size = New System.Drawing.Size(161, 20)
        Me.txt_NamaBarang.TabIndex = 4
        '
        'txt_KodeBarang
        '
        Me.txt_KodeBarang.Location = New System.Drawing.Point(125, 25)
        Me.txt_KodeBarang.Name = "txt_KodeBarang"
        Me.txt_KodeBarang.Size = New System.Drawing.Size(161, 20)
        Me.txt_KodeBarang.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_JumlahStok)
        Me.GroupBox1.Controls.Add(Me.btn_cari)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_NamaBarang)
        Me.GroupBox1.Controls.Add(Me.txt_KodeBarang)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 116)
        Me.GroupBox1.TabIndex = 300
        Me.GroupBox1.TabStop = False
        '
        'txt_JumlahStok
        '
        Me.txt_JumlahStok.Location = New System.Drawing.Point(412, 25)
        Me.txt_JumlahStok.Name = "txt_JumlahStok"
        Me.txt_JumlahStok.Size = New System.Drawing.Size(161, 20)
        Me.txt_JumlahStok.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(309, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Jumlah Stok"
        '
        'Stok_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(626, 426)
        Me.Controls.Add(Me.DGV_StokBarang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Stok_Barang"
        Me.Text = "Stok_Barang"
        CType(Me.DGV_StokBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV_StokBarang As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_cari As System.Windows.Forms.Button
    Friend WithEvents txt_NamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents txt_KodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_JumlahStok As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
