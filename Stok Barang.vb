Public Class Stok_Barang
    Dim cntx As SqlClient.SqlConnection
    Dim cmdx As SqlClient.SqlCommand
    Dim data As SqlClient.SqlDataAdapter
    Dim dst As DataSet
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Dim konfirmasi As String

    Private Sub Stok_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntx = New SqlClient.SqlConnection
        cntx.ConnectionString = "data source=(local);initial catalog=Stok_Barang;integrated security =true"
        cntx.Open()
        cmdx = New SqlClient.SqlCommand("select * from stok_barang")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        txt_KodeBarang.Enabled = False
        txt_namabarang.Enabled = False
        txt_JumlahStok.Enabled = False

        DGV_StokBarang.DataSource = dst.Tables(0)
        DGV_StokBarang.Refresh()

        DGV_StokBarang.Columns(0).Width = 140
        DGV_StokBarang.Columns(0).HeaderText = "Kode Barang"
        DGV_StokBarang.Columns(1).Width = 300
        DGV_StokBarang.Columns(1).HeaderText = "Nama Barang"
        DGV_StokBarang.Columns(2).Width = 115
        DGV_StokBarang.Columns(2).HeaderText = "Jumlah Stok"

    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        Dim cari As String
        cari = InputBox("MASUKKAN KODE BARANG")
        cmdx = New SqlClient.SqlCommand("select * from stok_barang where kd_barang ='" & cari & "'")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter
        data.SelectCommand = cmdx
        dst = New DataSet

        data.Fill(dst, "ketemu")
        If dst.Tables(0).Rows.Count = 0 Then
            MsgBox("Data Tidak ada / anda batal mencari Data !!")
            Exit Sub
        End If
        txt_KodeBarang.Text = dst.Tables(0).Rows(0)("kd_barang")
        txt_NamaBarang.Text = dst.Tables(0).Rows(0)("nama_barang")
        txt_JumlahStok.Text = dst.Tables(0).Rows(0)("jumlah_stok")

        DGV_StokBarang.DataSource = dst.Tables("ketemu")
        DGV_StokBarang.ReadOnly = True
    End Sub
End Class