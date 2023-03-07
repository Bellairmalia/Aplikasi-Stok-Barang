Public Class Barang_Keluar
    Dim cntx As SqlClient.SqlConnection
    Dim cmdx As SqlClient.SqlCommand
    Dim data As SqlClient.SqlDataAdapter
    Dim dst As DataSet
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Dim konfirmasi As String

    Private Sub KembaliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KembaliToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Barang_Keluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntx = New SqlClient.SqlConnection
        cntx.ConnectionString = "data source=(local);initial catalog=Stok_Barang;integrated security =true"
        cntx.Open()
        cmdx = New SqlClient.SqlCommand("select * from barang_keluar")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        txt_IdKeluar.Enabled = False

        cmd = New SqlClient.SqlCommand("select *from barang_keluar order by id_keluar desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            txt_IdKeluar.Text = "K0" + "0001"
        Else
            txt_IdKeluar.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_keluar").ToString, 4, 3)) + 1
            If Len(txt_IdKeluar.Text) = 1 Then
                txt_IdKeluar.Text = "K0000" & txt_IdKeluar.Text & ""
            ElseIf Len(txt_IdKeluar.Text) = 2 Then
                txt_IdKeluar.Text = "K000" & txt_IdKeluar.Text & ""
            ElseIf Len(txt_IdKeluar.Text) = 3 Then
                txt_IdKeluar.Text = "K00" & txt_IdKeluar.Text & ""
            End If
        End If

        DGV_BarangKeluar.DataSource = dst.Tables(0)
        DGV_BarangKeluar.Refresh()
        dr.Close()

        txt_IdMasuk.Enabled = False
        txt_IdKeluar.Enabled = False
        txt_KodeBarang.Enabled = False
        txt_NamaBarang.Enabled = False
        txt_StokBarang.Enabled = False
        txt_SisaStok.Enabled = False
        txt_HargaKeluar.Enabled = False
        txt_TotalHarga.Enabled = False
        txt_JumlahStok.Enabled = False

        DGV_BarangKeluar.Columns(0).Width = 130
        DGV_BarangKeluar.Columns(0).HeaderText = "ID Transaksi Keluar"
        DGV_BarangKeluar.Columns(1).Width = 130
        DGV_BarangKeluar.Columns(1).HeaderText = "ID Transaksi Masuk"
        DGV_BarangKeluar.Columns(2).Width = 125
        DGV_BarangKeluar.Columns(2).HeaderText = "Tanggal Keluar"
        DGV_BarangKeluar.Columns(3).Width = 125
        DGV_BarangKeluar.Columns(3).HeaderText = "Kode Barang"
        DGV_BarangKeluar.Columns(4).Width = 245
        DGV_BarangKeluar.Columns(4).HeaderText = "Nama Barang"
        DGV_BarangKeluar.Columns(5).Width = 100
        DGV_BarangKeluar.Columns(5).HeaderText = "Stok Barang"
        DGV_BarangKeluar.Columns(6).Width = 100
        DGV_BarangKeluar.Columns(6).HeaderText = "Jumlah Keluar"
        DGV_BarangKeluar.Columns(7).Width = 100
        DGV_BarangKeluar.Columns(7).HeaderText = "Stok Sisa"
        DGV_BarangKeluar.Columns(8).Width = 120
        DGV_BarangKeluar.Columns(8).HeaderText = "Harga Keluar"
        DGV_BarangKeluar.Columns(9).Width = 120
        DGV_BarangKeluar.Columns(9).HeaderText = "Total Harga"

    End Sub

    Private Sub btn_LihatBarang_Click(sender As Object, e As EventArgs) Handles btn_LihatBarang.Click
        Dim cari As String
        If txt_LihatBarang.Text = "" Then
            MsgBox("HARAP ISI DATA BARANG YANG INGIN DICARI", vbCritical)
            Return
        End If
        cari = txt_LihatBarang.Text
        cmdx = New SqlClient.SqlCommand("select bm.*,s.jumlah_stok from barang_masuk as bm join stok_barang as s on(s.kd_barang=bm.kd_barang) where bm.kd_barang='" & cari & "' or bm.id_masuk ='" & cari & "' or bm.nama_barang='" & cari & "'")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter
        data.SelectCommand = cmdx
        dst = New DataSet
        data.Fill(dst, "ketemu")
        If dst.Tables(0).Rows.Count = 0 Then
            MsgBox("Data Tidak ada / anda batal mencari Data !!")
            Exit Sub
        End If 

        txt_IdMasuk.Text = dst.Tables(0).Rows(0)("id_masuk")
        txt_KodeBarang.Text = dst.Tables(0).Rows(0)("kd_barang")
        txt_NamaBarang.Text = dst.Tables(0).Rows(0)("nama_barang")
        txt_StokBarang.Text = dst.Tables(0).Rows(0)("stok_barang")
        txt_JumlahStok.Text = dst.Tables(0).Rows(0)("jumlah_stok")
        txt_HargaKeluar.Text = dst.Tables(0).Rows(0)("harga_keluar")

        DGV_BarangKeluar.Columns(0).Width = 160
        DGV_BarangKeluar.Columns(0).HeaderText = "ID Transaksi Masuk"
        DGV_BarangKeluar.Columns(1).Width = 125
        DGV_BarangKeluar.Columns(1).HeaderText = "Tanggal Masuk"
        DGV_BarangKeluar.Columns(2).Width = 160
        DGV_BarangKeluar.Columns(2).HeaderText = "Kode Barang"
        DGV_BarangKeluar.Columns(3).Width = 350
        DGV_BarangKeluar.Columns(3).HeaderText = "Nama Barang"
        DGV_BarangKeluar.Columns(4).Width = 100
        DGV_BarangKeluar.Columns(4).HeaderText = "Nama Supplier"
        DGV_BarangKeluar.Columns(5).Width = 100
        DGV_BarangKeluar.Columns(5).HeaderText = "Stok Barang"
        DGV_BarangKeluar.Columns(6).Width = 150
        DGV_BarangKeluar.Columns(6).HeaderText = "Jumlah Masuk"
        DGV_BarangKeluar.Columns(7).Width = 150
        DGV_BarangKeluar.Columns(7).HeaderText = "Harga Masuk"
        DGV_BarangKeluar.Columns(8).Width = 150
        DGV_BarangKeluar.Columns(8).HeaderText = "Harga Keluar"

        DGV_BarangKeluar.DataSource = dst.Tables("ketemu")
        DGV_BarangKeluar.ReadOnly = True
        DGV_BarangKeluar.Refresh()

    End Sub

    Private Sub btn_Hitung_Click(sender As Object, e As EventArgs) Handles btn_Hitung.Click
        If txt_JumlahKeluar.Text = "" Then
            MsgBox("HARAP ISI JUMLAH KELUAR TERLEBIH DAHULU", vbCritical)
            Return
        End If

        Dim SB As Integer = txt_StokBarang.Text
        Dim HK As Integer = txt_HargaKeluar.Text
        Dim JK As Integer = txt_JumlahKeluar.Text

        txt_TotalHarga.Text = HK * JK
        txt_SisaStok.Text = SB - JK
    End Sub

    Private Sub btn_Simpan_Click(sender As Object, e As EventArgs) Handles btn_Simpan.Click
        If txt_JumlahKeluar.Text = "" Then
            MsgBox("HARAP ISI JUMLAH KELUAR TERLEBIH DAHULU", vbCritical)
            Return
        End If

        If CDbl(txt_StokBarang.Text) < 1 Then
            MsgBox("STOK TIDAK ADA ATAU HABIS", vbCritical)
            Return
        End If

        If CDbl(txt_JumlahKeluar.Text) > CDbl(txt_StokBarang.Text) Then
            MsgBox("JUMLAH KELUAR MELEBIHI STOK", vbCritical)
            Return
        End If

        Dim stoksekarang As Integer = CDbl(txt_StokBarang.Text) - CDbl(txt_JumlahKeluar.Text)
        Dim stokkurang As Integer = CInt(txt_JumlahKeluar.Text)

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "insert into barang_keluar(id_keluar, id_masuk, tgl_keluar, kd_barang, nama_barang, stok_barang, jumlah_keluar, stok_sisa, harga_keluar, total_keluar) values ('" & txt_IdKeluar.Text & "','" & txt_IdMasuk.Text & "','" & DTP_Keluar.Text & "','" & txt_KodeBarang.Text & "','" & txt_NamaBarang.Text & "','" & txt_StokBarang.Text & "','" & txt_JumlahKeluar.Text & "','" & txt_SisaStok.Text & "','" & txt_HargaKeluar.Text & "','" & txt_TotalHarga.Text & "')"
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "update barang_masuk set stok_barang=" & stoksekarang & " where id_masuk='" & txt_IdMasuk.Text & "'"
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "update stok_barang set jumlah_stok= jumlah_stok -" & stokkurang & " where kd_barang='" & txt_KodeBarang.Text & "'"
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        cmdx = New SqlClient.SqlCommand("select * from barang_keluar")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        txt_IdKeluar.Enabled = False

        cmd = New SqlClient.SqlCommand("select *from barang_keluar order by id_keluar desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            txt_IdKeluar.Text = "K0" + "0001"
        Else
            txt_IdKeluar.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_keluar").ToString, 4, 3)) + 1
            If Len(txt_IdKeluar.Text) = 1 Then
                txt_IdKeluar.Text = "K0000" & txt_IdKeluar.Text & ""
            ElseIf Len(txt_IdKeluar.Text) = 2 Then
                txt_IdKeluar.Text = "K000" & txt_IdKeluar.Text & ""
            ElseIf Len(txt_IdKeluar.Text) = 3 Then
                txt_IdKeluar.Text = "K00" & txt_IdKeluar.Text & ""
            End If
        End If

        DGV_BarangKeluar.DataSource = dst.Tables(0)
        DGV_BarangKeluar.Refresh()
        dr.Close()

        txt_LihatBarang.Clear()
        txt_IdMasuk.Clear()
        txt_KodeBarang.Clear()
        txt_NamaBarang.Clear()
        txt_StokBarang.Clear()
        txt_JumlahKeluar.Clear()
        txt_SisaStok.Clear()
        txt_HargaKeluar.Clear()
        txt_TotalHarga.Clear()
        txt_JumlahStok.Clear()

        DGV_BarangKeluar.Columns(0).Width = 130
        DGV_BarangKeluar.Columns(0).HeaderText = "ID Transaksi Keluar"
        DGV_BarangKeluar.Columns(1).Width = 130
        DGV_BarangKeluar.Columns(1).HeaderText = "ID Transaksi Masuk"
        DGV_BarangKeluar.Columns(2).Width = 125
        DGV_BarangKeluar.Columns(2).HeaderText = "Tanggal Keluar"
        DGV_BarangKeluar.Columns(3).Width = 125
        DGV_BarangKeluar.Columns(3).HeaderText = "Kode Barang"
        DGV_BarangKeluar.Columns(4).Width = 245
        DGV_BarangKeluar.Columns(4).HeaderText = "Nama Barang"
        DGV_BarangKeluar.Columns(5).Width = 100
        DGV_BarangKeluar.Columns(5).HeaderText = "Stok Barang"
        DGV_BarangKeluar.Columns(6).Width = 100
        DGV_BarangKeluar.Columns(6).HeaderText = "Jumlah Keluar"
        DGV_BarangKeluar.Columns(7).Width = 100
        DGV_BarangKeluar.Columns(7).HeaderText = "Stok Sisa"
        DGV_BarangKeluar.Columns(8).Width = 120
        DGV_BarangKeluar.Columns(8).HeaderText = "Harga Keluar"
        DGV_BarangKeluar.Columns(9).Width = 120
        DGV_BarangKeluar.Columns(9).HeaderText = "Total Harga"
    End Sub

    Private Sub btn_Cari_Click(sender As Object, e As EventArgs) Handles btn_Cari.Click
        Dim cari As String
        cari = InputBox("MASUKKAN ID BARANG KELUAR/KODE BARANG/NAMA BARANG")
        cmdx = New SqlClient.SqlCommand("select * from barang_keluar where id_keluar ='" & cari & "' or kd_barang='" & cari & "' or nama_barang='" & cari & "'")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter
        data.SelectCommand = cmdx
        dst = New DataSet

        data.Fill(dst, "ketemu")
        If dst.Tables(0).Rows.Count = 0 Then
            MsgBox("Data Tidak ada / anda batal mencari Data !!")
            Exit Sub
        End If

        DGV_BarangKeluar.DataSource = dst.Tables("ketemu")
        DGV_BarangKeluar.ReadOnly = True
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Cancel.ShowDialog()
    End Sub

    Private Sub txt_JumlahKeluar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_JumlahKeluar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class