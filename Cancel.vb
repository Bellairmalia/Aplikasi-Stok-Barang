Public Class Cancel
    Dim cntx As SqlClient.SqlConnection
    Dim cmdx As SqlClient.SqlCommand
    Dim data As SqlClient.SqlDataAdapter
    Dim dst As DataSet
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Dim konfirmasi As String

    Private Sub Cancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntx = New SqlClient.SqlConnection
        cntx.ConnectionString = "data source=(local);initial catalog=Stok_Barang;integrated security =true"
        cntx.Open()
        cmdx = New SqlClient.SqlCommand("select * from stok_barang")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        txt1_IdMasuk.Enabled = False
        txt1_Menu.Enabled = False
        txt1_KodeBarang.Enabled = False
        txt1_NamaBarang.Enabled = False
        DTP1_Cancel.Enabled = False
        txt1_JumlahCancel.Enabled = False
        txt2_IdMasuk.Enabled = False
        txt2_Menu.Enabled = False
        txt2_KodeBarang.Enabled = False
        txt2_NamaBarang.Enabled = False
        DTP2_Cancel.Enabled = False
        txt2_JumlahCancel.Enabled = False
        txt3_Menu.Enabled = False
        txt3_KodeBarang.Enabled = False
        txt3_NamaBarang.Enabled = False
        DTP3_Cancel.Enabled = False
        txt3_JumlahCancel.Enabled = False

    End Sub

    Private Sub btn1_Cari_Click(sender As Object, e As EventArgs) Handles btn1_Cari.Click
        Dim cari As String

        cari = txt_IdKeluar.Text
        cmdx = New SqlClient.SqlCommand("select * from barang_keluar where id_keluar ='" & cari & "'")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter
        data.SelectCommand = cmdx
        dst = New DataSet
        data.Fill(dst, "ketemu")
        If dst.Tables(0).Rows.Count = 0 Then
            MsgBox("Data Tidak ada / anda batal mencari Data !!")
            Exit Sub
        End If

        txt1_IdMasuk.Text = dst.Tables(0).Rows(0)("id_masuk")
        txt1_KodeBarang.Text = dst.Tables(0).Rows(0)("kd_barang")
        txt1_NamaBarang.Text = dst.Tables(0).Rows(0)("nama_barang")
        txt1_JumlahCancel.Text = dst.Tables(0).Rows(0)("jumlah_keluar")
    End Sub

    Private Sub btn1_Cancel_Click(sender As Object, e As EventArgs) Handles btn1_Cancel.Click
        If txt1_Keterangan.Text = "" Then
            MsgBox("Harap isi Keterangan Mengcancel")
            Return
        End If

        konfirmasi = MsgBox("Anda yakin ingin Mengcancel Barang ?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then

            cmdx = New SqlClient.SqlCommand("delete from barang_keluar where id_keluar='" & txt_IdKeluar.Text & "'")
            cmdx.Connection = cntx
            cmdx.ExecuteNonQuery()

            cmdx = New SqlClient.SqlCommand("select * from barang_keluar", cntx)
            cmdx.Connection = cntx
            data = New SqlClient.SqlDataAdapter(cmdx)
            dst = New DataSet
            data.Fill(dst)

            Dim stoksekarang As Integer = CInt(txt1_JumlahCancel.Text)

            cmdx = New SqlClient.SqlCommand
            cmdx.CommandText = "insert into cancel(menu, kd_barang, nama_barang, tgl_cancel, keterangan_c, jumlah_cancel) values ('" & txt1_Menu.Text & "','" & txt1_KodeBarang.Text & "','" & txt1_NamaBarang.Text & "','" & DTP1_Cancel.Text & "','" & txt1_Keterangan.Text & "','" & txt1_JumlahCancel.Text & "')"
            cmdx.Connection = cntx
            cmdx.ExecuteNonQuery()
            cmdx = New SqlClient.SqlCommand("select * from barang_keluar")
            cmdx.Connection = cntx
            data = New SqlClient.SqlDataAdapter(cmdx)
            dst = New DataSet
            txt1_Menu.Enabled = False
            data.Fill(dst)
            Barang_Keluar.DGV_BarangKeluar.DataSource = dst.Tables(0)
            Barang_Keluar.DGV_BarangKeluar.Refresh()

            cmdx = New SqlClient.SqlCommand
            cmdx.CommandText = "update stok_barang set jumlah_stok= jumlah_stok +" & stoksekarang & " where kd_barang='" & txt1_KodeBarang.Text & "'"
            cmdx.Connection = cntx
            cmdx.ExecuteNonQuery()

            cmdx = New SqlClient.SqlCommand
            cmdx.CommandText = "update barang_masuk set stok_barang= stok_barang +" & stoksekarang & " where id_masuk='" & txt1_IdMasuk.Text & "'"
            cmdx.Connection = cntx
            cmdx.ExecuteNonQuery()

            txt_IdKeluar.Clear()
            txt1_IdMasuk.Clear()
            txt1_Menu.Clear()
            txt1_KodeBarang.Clear()
            txt1_NamaBarang.Clear()
            txt1_Keterangan.Clear()
            txt1_JumlahCancel.Clear()
        End If
    End Sub

    Private Sub btn2_Cari_Click(sender As Object, e As EventArgs) Handles btn2_Cari.Click
        Dim cari As String

        cari = txt_IdPenye.Text
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

        txt1_IdMasuk.Text = dst.Tables(0).Rows(0)("id_penye")
        txt1_KodeBarang.Text = dst.Tables(0).Rows(0)("kd_barang")
        txt1_NamaBarang.Text = dst.Tables(0).Rows(0)("nama_barang")
        txt1_JumlahCancel.Text = dst.Tables(0).Rows(0)("jumlah_penye")
    End Sub

    Private Sub btn2_Cancel_Click(sender As Object, e As EventArgs) Handles btn2_Cancel.Click
        If txt2_Keterangan.Text = "" Then
            MsgBox("Harap isi Keterangan Mengcancel")
            Return
        End If

        konfirmasi = MsgBox("Anda yakin ingin Mengcancel Barang ?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then

            cmdx = New SqlClient.SqlCommand("delete from penyesuaian where id_penye='" & txt_IdPenye.Text & "'")
            cmdx.Connection = cntx
            cmdx.ExecuteNonQuery()

            cmdx = New SqlClient.SqlCommand("select * from penyesuaian", cntx)
            cmdx.Connection = cntx
            data = New SqlClient.SqlDataAdapter(cmdx)
            dst = New DataSet
            data.Fill(dst)

            Dim stoksekarang As Integer = CInt(txt2_JumlahCancel.Text)

            cmdx = New SqlClient.SqlCommand
            cmdx.CommandText = "insert into cancel(menu, kd_barang, nama_barang, tgl_cancel, keterangan_c) values ('" & txt2_Menu.Text & "','" & txt2_KodeBarang.Text & "','" & txt2_NamaBarang.Text & "','" & DTP2_Cancel.Text & "','" & txt2_Keterangan.Text & "')"
            cmdx.Connection = cntx
            cmdx.ExecuteNonQuery()
            cmdx = New SqlClient.SqlCommand("select * from penyesuaian")
            cmdx.Connection = cntx
            data = New SqlClient.SqlDataAdapter(cmdx)
            dst = New DataSet
            txt1_Menu.Enabled = False
            data.Fill(dst)
            Barang_Penyesuaian.DGV_Penyesuaian.DataSource = dst.Tables(0)
            Barang_Penyesuaian.DGV_Penyesuaian.Refresh()

            cmdx = New SqlClient.SqlCommand
            cmdx.CommandText = "update stok_barang set jumlah_stok= jumlah_stok +" & stoksekarang & " where kd_barang='" & txt2_KodeBarang.Text & "'"
            cmdx.Connection = cntx
            cmdx.ExecuteNonQuery()

            cmdx = New SqlClient.SqlCommand
            cmdx.CommandText = "update barang_masuk set stok_barang= stok_barang +" & stoksekarang & " where id_masuk='" & txt2_IdMasuk.Text & "'"
            cmdx.Connection = cntx
            cmdx.ExecuteNonQuery()

            txt_IdPenye.Clear()
            txt2_IdMasuk.Clear()
            txt2_Menu.Clear()
            txt2_KodeBarang.Clear()
            txt2_NamaBarang.Clear()
            txt2_Keterangan.Clear()
            txt2_JumlahCancel.Clear()
        End If
    End Sub

    Private Sub btn3_Cari_Click(sender As Object, e As EventArgs) Handles btn3_Cari.Click
        Dim cari As String

        cari = txt3_IdMasuk.Text
        cmdx = New SqlClient.SqlCommand("select * from barang_masuk where id_masuk ='" & cari & "'")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter
        data.SelectCommand = cmdx
        dst = New DataSet
        data.Fill(dst, "ketemu")
        If dst.Tables(0).Rows.Count = 0 Then
            MsgBox("Data Tidak ada / anda batal mencari Data !!")
            Exit Sub
        End If

        txt3_IdMasuk.Text = dst.Tables(0).Rows(0)("id_masuk")
        txt3_KodeBarang.Text = dst.Tables(0).Rows(0)("kd_barang")
        txt3_NamaBarang.Text = dst.Tables(0).Rows(0)("nama_barang")
        txt3_JumlahCancel.Text = dst.Tables(0).Rows(0)("jumlah_masuk")
    End Sub

    Private Sub btn3_Cancel_Click(sender As Object, e As EventArgs) Handles btn3_Cancel.Click
        If txt3_Keterangan.Text = "" Then
            MsgBox("Harap isi Keterangan Mengcancel")
            Return
        End If

        konfirmasi = MsgBox("Anda yakin ingin Mengcancel Barang ?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then

            cmdx = New SqlClient.SqlCommand("delete from barang_masuk where id_masuk='" & txt3_IdMasuk.Text & "'")
            cmdx.Connection = cntx
            cmdx.ExecuteNonQuery()

            cmdx = New SqlClient.SqlCommand("select * from barang_masuk", cntx)
            cmdx.Connection = cntx
            data = New SqlClient.SqlDataAdapter(cmdx)
            dst = New DataSet
            data.Fill(dst)

            Dim stoksekarang As Integer = CInt(txt3_JumlahCancel.Text)

            cmdx = New SqlClient.SqlCommand
            cmdx.CommandText = "insert into cancel(menu, kd_barang, nama_barang, tgl_cancel, keterangan_c) values ('" & txt3_Menu.Text & "','" & txt3_KodeBarang.Text & "','" & txt3_NamaBarang.Text & "','" & DTP3_Cancel.Text & "','" & txt3_Keterangan.Text & "')"
            cmdx.Connection = cntx
            cmdx.ExecuteNonQuery()
            cmdx = New SqlClient.SqlCommand("select * from barang_masuk")
            cmdx.Connection = cntx
            data = New SqlClient.SqlDataAdapter(cmdx)
            dst = New DataSet
            txt1_Menu.Enabled = False
            data.Fill(dst)
            Barang_Masuk.DGV_BarangMasuk.DataSource = dst.Tables(0)
            Barang_Masuk.DGV_BarangMasuk.Refresh()

            cmdx = New SqlClient.SqlCommand
            cmdx.CommandText = "update stok_barang set jumlah_stok= jumlah_stok +" & stoksekarang & " where kd_barang='" & txt3_KodeBarang.Text & "'"
            cmdx.Connection = cntx
            cmdx.ExecuteNonQuery()

            txt3_IdMasuk.Clear()
            txt3_Menu.Clear()
            txt3_KodeBarang.Clear()
            txt3_NamaBarang.Clear()
            txt3_Keterangan.Clear()
            txt3_JumlahCancel.Clear()
        End If
    End Sub
End Class