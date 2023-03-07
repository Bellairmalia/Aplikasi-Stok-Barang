Public Class Barang_Masuk
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

    Private Sub Barang_Masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntx = New SqlClient.SqlConnection
        cntx.ConnectionString = "data source=(local);initial catalog=Stok_Barang;integrated security =true"
        cntx.Open()
        cmdx = New SqlClient.SqlCommand("select * from barang_masuk")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        txt_IdMasuk.Enabled = False

        cmd = New SqlClient.SqlCommand("select *from barang_masuk order by id_masuk desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            txt_IdMasuk.Text = "M0" + "0001"
        Else
            txt_IdMasuk.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_masuk").ToString, 4, 3)) + 1
            If Len(txt_IdMasuk.Text) = 1 Then
                txt_IdMasuk.Text = "M0000" & txt_IdMasuk.Text & ""
            ElseIf Len(txt_IdMasuk.Text) = 2 Then
                txt_IdMasuk.Text = "M000" & txt_IdMasuk.Text & ""
            ElseIf Len(txt_IdMasuk.Text) = 3 Then
                txt_IdMasuk.Text = "M00" & txt_IdMasuk.Text & ""
            End If
        End If

        DGV_BarangMasuk.DataSource = dst.Tables(0)
        DGV_BarangMasuk.Refresh()
        dr.Close()

        txt_KodeBarang.Enabled = False
        txt_NamaBarang.Enabled = False
        txt_StokBarang.Enabled = False

        DGV_BarangMasuk.Columns(0).Width = 160
        DGV_BarangMasuk.Columns(0).HeaderText = "ID Transaksi Masuk"
        DGV_BarangMasuk.Columns(1).Width = 125
        DGV_BarangMasuk.Columns(1).HeaderText = "Tanggal Masuk"
        DGV_BarangMasuk.Columns(2).Width = 160
        DGV_BarangMasuk.Columns(2).HeaderText = "Kode Barang"
        DGV_BarangMasuk.Columns(3).Width = 350
        DGV_BarangMasuk.Columns(3).HeaderText = "Nama Barang"
        DGV_BarangMasuk.Columns(4).Width = 100
        DGV_BarangMasuk.Columns(4).HeaderText = "Nama Supplier"
        DGV_BarangMasuk.Columns(5).Width = 100
        DGV_BarangMasuk.Columns(5).HeaderText = "Stok Barang"
        DGV_BarangMasuk.Columns(6).Width = 150
        DGV_BarangMasuk.Columns(6).HeaderText = "Jumlah Masuk"
        DGV_BarangMasuk.Columns(7).Width = 150
        DGV_BarangMasuk.Columns(7).HeaderText = "Harga Masuk"
        DGV_BarangMasuk.Columns(8).Width = 150
        DGV_BarangMasuk.Columns(8).HeaderText = "Harga Keluar"
    End Sub

    Private Sub btn_LihatBarang_Click(sender As Object, e As EventArgs) Handles btn_LihatBarang.Click
        Dim cari As String
        If txt_CariBarang.Text = "" Then
            MsgBox("HARAP ISI NAMA/KODE BARANG TERLEBIH DAHULU", vbCritical)
            Return
        End If
        cari = txt_CariBarang.Text
        cmdx = New SqlClient.SqlCommand("select * from barang where kd_barang ='" & cari & "' or nama_barang ='" & cari & "'")
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
    End Sub

    Private Sub btn_Simpan_Click(sender As Object, e As EventArgs) Handles btn_Simpan.Click
        If txt_JumlahMasuk.Text = "" Or txt_HargaMasuk.Text = "" Or txt_HargaKeluar.Text = "" Then
            MsgBox("HARAP ISI JUMLAH, HARGA MASUK DAN HARGA KELUAR !!")
            Return
        End If

        Dim stoksekarang As Integer = CInt(txt_JumlahMasuk.Text)

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "insert into barang_masuk(id_masuk, tgl_masuk, kd_barang, nama_barang, nama_supplier, stok_barang, jumlah_masuk, harga_masuk, harga_keluar) values ('" & txt_IdMasuk.Text & "','" & DTP_Masuk.Text & "','" & txt_KodeBarang.Text & "','" & txt_NamaBarang.Text & "','" & txt_NamaSupplier.Text & "','" & txt_JumlahMasuk.Text & "','" & txt_JumlahMasuk.Text & "','" & txt_HargaMasuk.Text & "','" & txt_HargaKeluar.Text & "')"
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()
        cmdx = New SqlClient.SqlCommand("select * from barang_masuk")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "update stok_barang set jumlah_stok = jumlah_stok +" & stoksekarang & " where kd_barang= '" & txt_KodeBarang.Text & "'"
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        txt_IdMasuk.Enabled = False

        cmd = New SqlClient.SqlCommand("select *from barang_masuk order by id_masuk desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            txt_IdMasuk.Text = "M0" + "0001"
        Else
            txt_IdMasuk.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_masuk").ToString, 4, 3)) + 1
            If Len(txt_IdMasuk.Text) = 1 Then
                txt_IdMasuk.Text = "M0000" & txt_IdMasuk.Text & ""
            ElseIf Len(txt_IdMasuk.Text) = 2 Then
                txt_IdMasuk.Text = "M000" & txt_IdMasuk.Text & ""
            ElseIf Len(txt_IdMasuk.Text) = 3 Then
                txt_IdMasuk.Text = "M00" & txt_IdMasuk.Text & ""
            End If
        End If

        DGV_BarangMasuk.DataSource = dst.Tables(0)
        DGV_BarangMasuk.Refresh()
        dr.Close()

        txt_CariBarang.Clear()
        txt_KodeBarang.Clear()
        txt_NamaBarang.Clear()
        txt_NamaSupplier.Clear()
        txt_StokBarang.Clear()
        txt_JumlahMasuk.Clear()
        txt_HargaMasuk.Clear()
        txt_HargaKeluar.Clear()
    End Sub

    Private Sub btn_Cari_Click(sender As Object, e As EventArgs) Handles btn_Cari.Click
        Dim cari As String
        cari = InputBox("MASUKKAN ID TRANSAKSI MASUK/KODE BARANG/NAMA BARANG/NAMA SUPPLIER")
        cmdx = New SqlClient.SqlCommand("select * from barang_masuk where id_masuk ='" & cari & "' or kd_barang='" & cari & "' or nama_barang='" & cari & "' or nama_supplier='" & cari & "'")
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
        DTP_Masuk.Text = dst.Tables(0).Rows(0)("tgl_masuk")
        txt_KodeBarang.Text = dst.Tables(0).Rows(0)("kd_barang")
        txt_NamaBarang.Text = dst.Tables(0).Rows(0)("nama_barang")
        txt_NamaSupplier.Text = dst.Tables(0).Rows(0)("nama_supplier")
        txt_StokBarang.Text = dst.Tables(0).Rows(0)("stok_barang")
        txt_JumlahMasuk.Text = dst.Tables(0).Rows(0)("jumlah_masuk")
        txt_HargaMasuk.Text = dst.Tables(0).Rows(0)("harga_masuk")
        txt_HargaKeluar.Text = dst.Tables(0).Rows(0)("harga_keluar")

        DGV_BarangMasuk.DataSource = dst.Tables("ketemu")
        DGV_BarangMasuk.ReadOnly = True
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Cancel.ShowDialog()
    End Sub

    Private Sub txt_JumlahMasuk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_JumlahMasuk.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txt_HargaMasuk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_HargaMasuk.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txt_HargaKeluar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_HargaKeluar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

End Class