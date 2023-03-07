Public Class Barang
    Dim cntx As SqlClient.SqlConnection
    Dim cmdx As SqlClient.SqlCommand
    Dim data As SqlClient.SqlDataAdapter
    Dim dst As DataSet
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Dim konfirmasi As String

    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntx = New SqlClient.SqlConnection
        cntx.ConnectionString = "data source=(local);initial catalog=Stok_Barang;integrated security =true"
        cntx.Open()
        cmdx = New SqlClient.SqlCommand("select * from barang")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        txt_KodeBarang.Enabled = False

        cmd = New SqlClient.SqlCommand("select *from barang order by kd_barang desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            txt_KodeBarang.Text = "BR" + "0001"
        Else
            txt_KodeBarang.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("kd_barang").ToString, 4, 3)) + 1
            If Len(txt_KodeBarang.Text) = 1 Then
                txt_KodeBarang.Text = "BR000" & txt_KodeBarang.Text & ""
            ElseIf Len(txt_KodeBarang.Text) = 2 Then
                txt_KodeBarang.Text = "BR00" & txt_KodeBarang.Text & ""
            ElseIf Len(txt_KodeBarang.Text) = 3 Then
                txt_KodeBarang.Text = "BR0" & txt_KodeBarang.Text & ""
            End If
        End If

        DGV_Barang.DataSource = dst.Tables(0)
        DGV_Barang.Refresh()
        dr.Close()

        DGV_Barang.Columns(0).Width = 130
        DGV_Barang.Columns(0).HeaderText = "Kode Barang"
        DGV_Barang.Columns(1).Width = 200
        DGV_Barang.Columns(1).HeaderText = "Nama Barang"
        DGV_Barang.Columns(2).Width = 90
        DGV_Barang.Columns(2).HeaderText = "Satuan"
        DGV_Barang.Columns(3).Width = 135
        DGV_Barang.Columns(3).HeaderText = "Lokasi"
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_NamaBarang.Text = "" Or cmb_Satuan.Text = "" Or cmb_Lokasi.Text = "" Then
            MsgBox("HARAP ISI NAMA BARANG, SATUAN DAN LOKASI TERLEBIH DAHULU")
            Return
        End If

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "insert into barang(kd_barang, nama_barang, satuan, lokasi) values ('" & txt_KodeBarang.Text & "','" & txt_NamaBarang.Text & "','" & cmb_Satuan.Text & "','" & cmb_Lokasi.Text & "')"
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "insert into stok_barang(kd_barang, nama_barang) values ('" & txt_KodeBarang.Text & "','" & txt_NamaBarang.Text & "')"
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()
        cmdx = New SqlClient.SqlCommand("select * from barang")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        txt_KodeBarang.Enabled = False

        cmd = New SqlClient.SqlCommand("select *from barang order by kd_barang desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            txt_KodeBarang.Text = "BR" + "0001"
        Else
            txt_KodeBarang.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("kd_barang").ToString, 4, 3)) + 1
            If Len(txt_KodeBarang.Text) = 1 Then
                txt_KodeBarang.Text = "BR000" & txt_KodeBarang.Text & ""
            ElseIf Len(txt_KodeBarang.Text) = 2 Then
                txt_KodeBarang.Text = "BR00" & txt_KodeBarang.Text & ""
            ElseIf Len(txt_KodeBarang.Text) = 3 Then
                txt_KodeBarang.Text = "BR0" & txt_KodeBarang.Text & ""
            End If
        End If

        DGV_Barang.DataSource = dst.Tables(0)
        DGV_Barang.Refresh()
        dr.Close()

        txt_NamaBarang.Clear()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_KodeBarang.Text = "" Then
            MsgBox("KODE BARANG HARUS DIISI")
            txt_KodeBarang.Focus()
            Exit Sub
        End If

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "update barang set nama_barang ='" & txt_NamaBarang.Text & "', satuan ='" & cmb_Satuan.Text & "', lokasi ='" & cmb_Lokasi.Text & "'  where kd_barang ='" & txt_KodeBarang.Text & "'"
        cmdx.Connection = cntx
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        Dim cekupdate As String
        cekupdate = MsgBox("UPDATE DATA INI", MsgBoxStyle.Question)
        If cekupdate = vbNo Then Exit Sub

        cmdx = New SqlClient.SqlCommand("Select *from barang")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)
        DGV_Barang.DataSource = dst.Tables(0)
        DGV_Barang.Refresh()

        cmd = New SqlClient.SqlCommand("select *from barang order by kd_barang desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            txt_KodeBarang.Text = "BR" + "0001"
        Else
            txt_KodeBarang.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("kd_barang").ToString, 4, 3)) + 1
            If Len(txt_KodeBarang.Text) = 1 Then
                txt_KodeBarang.Text = "BR000" & txt_KodeBarang.Text & ""
            ElseIf Len(txt_KodeBarang.Text) = 2 Then
                txt_KodeBarang.Text = "BR00" & txt_KodeBarang.Text & ""
            ElseIf Len(txt_KodeBarang.Text) = 3 Then
                txt_KodeBarang.Text = "BR0" & txt_KodeBarang.Text & ""
            End If
        End If
        dr.Close()

        txt_NamaBarang.Clear()
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        Dim cari As String
        cari = InputBox("MASUKKAN KODE BARANG")
        cmdx = New SqlClient.SqlCommand("select * from barang where kd_barang ='" & cari & "'")
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
        cmb_Satuan.Text = dst.Tables(0).Rows(0)("satuan")
        cmb_Lokasi.Text = dst.Tables(0).Rows(0)("lokasi")

        DGV_Barang.DataSource = dst.Tables("ketemu")
        DGV_Barang.ReadOnly = True
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        cmdx = New SqlClient.SqlCommand("delete from barang where kd_barang='" & txt_KodeBarang.Text & "'")
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        MsgBox("Hapus selesai", MsgBoxStyle.Exclamation)

        cmdx = New SqlClient.SqlCommand("select * from barang", cntx)
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)
        DGV_Barang.DataSource = dst.Tables(0)
        DGV_Barang.Refresh()

        cmd = New SqlClient.SqlCommand("select *from barang order by kd_barang desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            txt_KodeBarang.Text = "BR" + "0001"
        Else
            txt_KodeBarang.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("kd_barang").ToString, 4, 3)) + 1
            If Len(txt_KodeBarang.Text) = 1 Then
                txt_KodeBarang.Text = "BR000" & txt_KodeBarang.Text & ""
            ElseIf Len(txt_KodeBarang.Text) = 2 Then
                txt_KodeBarang.Text = "BR00" & txt_KodeBarang.Text & ""
            ElseIf Len(txt_KodeBarang.Text) = 3 Then
                txt_KodeBarang.Text = "BR0" & txt_KodeBarang.Text & ""
            End If
        End If
        dr.Close()

        txt_NamaBarang.Clear()
    End Sub
End Class