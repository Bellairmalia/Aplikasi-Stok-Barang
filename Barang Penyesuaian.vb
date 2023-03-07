Public Class Barang_Penyesuaian
    Dim cntx As SqlClient.SqlConnection
    Dim cmdx As SqlClient.SqlCommand
    Dim data As SqlClient.SqlDataAdapter
    Dim dst As DataSet
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand

    Private Sub KembaliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KembaliToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Barang_Penyesuaian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntx = New SqlClient.SqlConnection
        cntx.ConnectionString = "data source=(local);initial catalog=Stok_Barang;integrated security =true"
        cntx.Open()
        cmdx = New SqlClient.SqlCommand("select * from penyesuaian")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        txt_IdPenye.Enabled = False

        cmd = New SqlClient.SqlCommand("select *from penyesuaian order by id_penye desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            txt_IdPenye.Text = "P0" + "0001"
        Else
            txt_IdPenye.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_penye").ToString, 4, 3)) + 1
            If Len(txt_IdPenye.Text) = 1 Then
                txt_IdPenye.Text = "P0000" & txt_IdPenye.Text & ""
            ElseIf Len(txt_IdPenye.Text) = 2 Then
                txt_IdPenye.Text = "P000" & txt_IdPenye.Text & ""
            ElseIf Len(txt_IdPenye.Text) = 3 Then
                txt_IdPenye.Text = "P00" & txt_IdPenye.Text & ""
            End If
        End If

        DGV_Penyesuaian.DataSource = dst.Tables(0)
        DGV_Penyesuaian.Refresh()
        dr.Close()

        txt_IdPenye.Enabled = False
        txt_IdMasuk.Enabled = False
        txt_KodeBarang.Enabled = False
        txt_NamaBarang.Enabled = False
        txt_StokBarang.Enabled = False

        DGV_Penyesuaian.Columns(0).Width = 130
        DGV_Penyesuaian.Columns(0).HeaderText = "ID Penyesuaian"
        DGV_Penyesuaian.Columns(1).Width = 130
        DGV_Penyesuaian.Columns(1).HeaderText = "ID Transaksi Masuk"
        DGV_Penyesuaian.Columns(2).Width = 140
        DGV_Penyesuaian.Columns(2).HeaderText = "Tanggal Penyesuaian"
        DGV_Penyesuaian.Columns(3).Width = 130
        DGV_Penyesuaian.Columns(3).HeaderText = "Kode Barang"
        DGV_Penyesuaian.Columns(4).Width = 255
        DGV_Penyesuaian.Columns(4).HeaderText = "Nama Barang"
        DGV_Penyesuaian.Columns(5).Width = 130
        DGV_Penyesuaian.Columns(5).HeaderText = "Stok Barang"
        DGV_Penyesuaian.Columns(6).Width = 130
        DGV_Penyesuaian.Columns(6).HeaderText = "Jumlah Penyesuaian"
        DGV_Penyesuaian.Columns(7).Width = 250
        DGV_Penyesuaian.Columns(7).HeaderText = "Keterangan"

    End Sub

    Private Sub btn_LihatBarang_Click_1(sender As Object, e As EventArgs) Handles btn_LihatBarang.Click
        Dim cari As String
        If txt_LihatBarang.Text = "" Then
            MsgBox("HARAP CARI DATA BARANG TERLEBIH DAHULU", vbCritical)
            Return
        End If
        cari = txt_LihatBarang.Text
        cmdx = New SqlClient.SqlCommand("select * from barang_masuk where id_masuk ='" & cari & "' or kd_barang='" & cari & "' or nama_barang='" & cari & "'")
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
        txt_StokBarang.Text = dst.Tables(0).Rows(0)("stok_barang")
        txt_IdMasuk.Text = dst.Tables(0).Rows(0)("id_masuk")

        DGV_Penyesuaian.DataSource = dst.Tables("ketemu")
        DGV_Penyesuaian.ReadOnly = True
        DGV_Penyesuaian.Refresh()
    End Sub

    Private Sub btn_Simpan_Click(sender As Object, e As EventArgs) Handles btn_Simpan.Click
        If txt_JumlahPenye.Text = "" Or txt_Keterangan.Text = "" Then
            MsgBox("HARAP ISI JUMLAH PENYESUAIAN DAN KETERANGAN !!", vbCritical)
            Return
        End If

        If CDbl(txt_StokBarang.Text) < 1 Then
            MsgBox("STOK TIDAK ADA ATAU HABIS", vbCritical)
            Return
        End If

        If CDbl(txt_JumlahPenye.Text) > CDbl(txt_StokBarang.Text) Then
            MsgBox("JUMLAH KELUAR MELEBIHI STOK", vbCritical)
            Return
        End If

        Dim stoksekarang As Integer = CDbl(txt_StokBarang.Text) - CDbl(txt_JumlahPenye.Text)
        Dim stokkurang As Integer = CInt(txt_JumlahPenye.Text)

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "insert into penyesuaian(id_penye, id_masuk, tgl_penye, kd_barang, nama_barang, stok_barang, jumlah_penye, keterangan) values ('" & txt_IdPenye.Text & "','" & txt_IdMasuk.Text & "','" & DTP_Penye.Text & "','" & txt_KodeBarang.Text & "','" & txt_NamaBarang.Text & "','" & txt_StokBarang.Text & "','" & txt_JumlahPenye.Text & "','" & txt_Keterangan.Text & "')"
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "update barang_masuk set stok_barang=" & stoksekarang & " where id_masuk='" & txt_IdMasuk.Text & "'"
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "update stok_barang set jumlah_stok= jumlah_stok -" & stoksekarang & " where kd_barang='" & txt_KodeBarang.Text & "'"
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        cmdx = New SqlClient.SqlCommand("select * from penyesuaian")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        txt_IdPenye.Enabled = False

        cmd = New SqlClient.SqlCommand("select *from penyesuaian order by id_penye desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            txt_IdPenye.Text = "P0" + "0001"
        Else
            txt_IdPenye.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_penye").ToString, 4, 3)) + 1
            If Len(txt_IdPenye.Text) = 1 Then
                txt_IdPenye.Text = "P0000" & txt_IdPenye.Text & ""
            ElseIf Len(txt_IdPenye.Text) = 2 Then
                txt_IdPenye.Text = "P000" & txt_IdPenye.Text & ""
            ElseIf Len(txt_IdPenye.Text) = 3 Then
                txt_IdPenye.Text = "P00" & txt_IdPenye.Text & ""
            End If
        End If

        DGV_Penyesuaian.DataSource = dst.Tables(0)
        DGV_Penyesuaian.Refresh()
        dr.Close()

        txt_IdPenye.Clear()
        txt_KodeBarang.Clear()
        txt_NamaBarang.Clear()
        txt_StokBarang.Clear()
        txt_JumlahPenye.Clear()
        txt_Keterangan.Clear()

        DGV_Penyesuaian.Columns(0).Width = 130
        DGV_Penyesuaian.Columns(0).HeaderText = "ID Penyesuaian"
        DGV_Penyesuaian.Columns(1).Width = 130
        DGV_Penyesuaian.Columns(1).HeaderText = "ID Transaksi Masuk"
        DGV_Penyesuaian.Columns(2).Width = 140
        DGV_Penyesuaian.Columns(2).HeaderText = "Tanggal Penyesuaian"
        DGV_Penyesuaian.Columns(3).Width = 130
        DGV_Penyesuaian.Columns(3).HeaderText = "Kode Barang"
        DGV_Penyesuaian.Columns(4).Width = 255
        DGV_Penyesuaian.Columns(4).HeaderText = "Nama Barang"
        DGV_Penyesuaian.Columns(5).Width = 130
        DGV_Penyesuaian.Columns(5).HeaderText = "Stok Barang"
        DGV_Penyesuaian.Columns(6).Width = 130
        DGV_Penyesuaian.Columns(6).HeaderText = "Jumlah Penyesuaian"
        DGV_Penyesuaian.Columns(7).Width = 250
        DGV_Penyesuaian.Columns(7).HeaderText = "Keterangan"
    End Sub

    Private Sub btn_Cari_Click(sender As Object, e As EventArgs) Handles btn_Cari.Click
        Dim cari As String
        cari = InputBox("MASUKKAN ID PENYESUAIAN")
        cmdx = New SqlClient.SqlCommand("select * from penyesuaian where id_penye ='" & cari & "'")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter
        data.SelectCommand = cmdx
        dst = New DataSet

        data.Fill(dst, "ketemu")
        If dst.Tables(0).Rows.Count = 0 Then
            MsgBox("Data Tidak ada / anda batal mencari Data !!")
            Exit Sub
        End If

        DTP_Penye.Text = dst.Tables(0).Rows(0)("tgl_penye")
        txt_IdPenye.Text = dst.Tables(0).Rows(0)("id_penye")
        txt_IdMasuk.Text = dst.Tables(0).Rows(0)("id_masuk")
        txt_KodeBarang.Text = dst.Tables(0).Rows(0)("kd_stok")
        txt_NamaBarang.Text = dst.Tables(0).Rows(0)("nama_barang")
        txt_StokBarang.Text = dst.Tables(0).Rows(0)("stok_barang")
        txt_JumlahPenye.Text = dst.Tables(0).Rows(0)("jumlah_penye")
        txt_Keterangan.Text = dst.Tables(0).Rows(0)("keterangan")

        DGV_Penyesuaian.DataSource = dst.Tables("ketemu")
        DGV_Penyesuaian.ReadOnly = True
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Cancel.ShowDialog()
    End Sub

    Private Sub txt_JumlahPenye_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_JumlahPenye.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class