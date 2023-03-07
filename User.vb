Public Class User
    Dim cntx As SqlClient.SqlConnection
    Dim cmdx As SqlClient.SqlCommand
    Dim data As SqlClient.SqlDataAdapter
    Dim dst As DataSet
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntx = New SqlClient.SqlConnection
        cntx.ConnectionString = "data source=(local);initial catalog=Stok_Barang;integrated security =true"
        cntx.Open()
        cmdx = New SqlClient.SqlCommand("select * from users")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        txt_IDuser.Enabled = False

        cmd = New SqlClient.SqlCommand("select *from users order by id_user desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            txt_IdUser.Text = "US" + "0001"
        Else
            txt_IdUser.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_user").ToString, 4, 3)) + 1
            If Len(txt_IdUser.Text) = 1 Then
                txt_IdUser.Text = "US000" & txt_IdUser.Text & ""
            ElseIf Len(txt_IdUser.Text) = 2 Then
                txt_IdUser.Text = "US00" & txt_IdUser.Text & ""
            ElseIf Len(txt_IdUser.Text) = 3 Then
                txt_IdUser.Text = "US0" & txt_IdUser.Text & ""
            End If
        End If

        DGV_User.DataSource = dst.Tables(0)
        DGV_User.Refresh()
        dr.Close()

        DGV_User.Columns(0).Width = 100
        DGV_User.Columns(0).HeaderText = "ID User"
        DGV_User.Columns(1).Width = 140
        DGV_User.Columns(1).HeaderText = "Nama User"
        DGV_User.Columns(2).Width = 105
        DGV_User.Columns(2).HeaderText = "Username"
        DGV_User.Columns(3).Width = 105
        DGV_User.Columns(3).HeaderText = "Password"
        DGV_User.Columns(4).Width = 100
        DGV_User.Columns(4).HeaderText = "Status User"
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "insert into users(id_user, nama_user, username, password, status_user ) values ('" & txt_IdUser.Text & "','" & txt_NamaUser.Text & "','" & txt_Username.Text & "','" & txt_Password.Text & "','" & cmb_Status.Text & "')"
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()
        cmdx = New SqlClient.SqlCommand("select * from users")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)
        DGV_User.DataSource = dst.Tables(0)
        DGV_User.Refresh()

        cmd = New SqlClient.SqlCommand("select *from users order by id_user desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            txt_IdUser.Text = "US" + "0001"
        Else
            txt_IdUser.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_user").ToString, 4, 3)) + 1
            If Len(txt_IdUser.Text) = 1 Then
                txt_IdUser.Text = "US000" & txt_IdUser.Text & ""
            ElseIf Len(txt_IdUser.Text) = 2 Then
                txt_IdUser.Text = "US00" & txt_IdUser.Text & ""
            ElseIf Len(txt_IdUser.Text) = 3 Then
                txt_IdUser.Text = "US0" & txt_IdUser.Text & ""
            End If
        End If
        dr.Close()

        txt_NamaUser.Clear()
        txt_Username.Clear()
        txt_Password.Clear()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_IdUser.Text = "" Then
            MsgBox("ID USER HARUS DIISI !!!")
            txt_IdUser.Focus()
            Exit Sub
        End If

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "update users set nama_user ='" & txt_NamaUser.Text & "', username ='" & txt_Username.Text & "', password ='" & txt_Password.Text & "', status_user ='" & cmb_Status.Text & "'  where id_user ='" & txt_IdUser.Text & "'"
        cmdx.Connection = cntx
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        Dim cekupdate As String
        cekupdate = MsgBox("UPDATE DATA INI", MsgBoxStyle.Question)
        If cekupdate = vbNo Then Exit Sub

        cmdx = New SqlClient.SqlCommand("Select *from users")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)
        DGV_User.DataSource = dst.Tables(0)
        DGV_User.Refresh()
       
        cmd = New SqlClient.SqlCommand("select *from users order by id_user desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            txt_IdUser.Text = "US" + "0001"
        Else
            txt_IdUser.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_user").ToString, 4, 3)) + 1
            If Len(txt_IdUser.Text) = 1 Then
                txt_IdUser.Text = "US000" & txt_IdUser.Text & ""
            ElseIf Len(txt_IdUser.Text) = 2 Then
                txt_IdUser.Text = "US00" & txt_IdUser.Text & ""
            ElseIf Len(txt_IdUser.Text) = 3 Then
                txt_IdUser.Text = "US0" & txt_IdUser.Text & ""
            End If
        End If
        dr.Close()

        txt_namauser.Clear()
        txt_username.Clear()
        txt_password.Clear()
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        Dim cari As String
        cari = InputBox("MASUKKAN ID USER")
        cmdx = New SqlClient.SqlCommand("select * from users where id_user ='" & cari & "'")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter
        data.SelectCommand = cmdx
        dst = New DataSet
        data.Fill(dst, "ketemu")
        If dst.Tables(0).Rows.Count = 0 Then
            MsgBox("Data Tidak ada / anda batal mencari Data !!")
            Exit Sub
        End If
        txt_IDuser.Text = dst.Tables(0).Rows(0)("id_user")
        txt_namauser.Text = dst.Tables(0).Rows(0)("nama_user")
        txt_username.Text = dst.Tables(0).Rows(0)("username")
        txt_password.Text = dst.Tables(0).Rows(0)("password")
        cmb_Status.Text = dst.Tables(0).Rows(0)("status_user")
        DGV_User.DataSource = dst.Tables("ketemu")
        DGV_User.ReadOnly = True
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        cmdx = New SqlClient.SqlCommand("delete from users where id_user='" & txt_IdUser.Text & "'")
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        MsgBox("Hapus selesai", MsgBoxStyle.Exclamation)

        cmdx = New SqlClient.SqlCommand("select * from users", cntx)
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)
        DGV_User.DataSource = dst.Tables(0)
        DGV_User.Refresh()
       
        cmd = New SqlClient.SqlCommand("select *from users order by id_user desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            txt_IdUser.Text = "US" + "0001"
        Else
            txt_IdUser.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_user").ToString, 4, 3)) + 1
            If Len(txt_IdUser.Text) = 1 Then
                txt_IdUser.Text = "US000" & txt_IdUser.Text & ""
            ElseIf Len(txt_IdUser.Text) = 2 Then
                txt_IdUser.Text = "US00" & txt_IdUser.Text & ""
            ElseIf Len(txt_IdUser.Text) = 3 Then
                txt_IdUser.Text = "US0" & txt_IdUser.Text & ""
            End If
        End If
        dr.Close()

        txt_namauser.Clear()
        txt_username.Clear()
        txt_password.Clear()
    End Sub
End Class