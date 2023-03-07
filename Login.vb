Imports System.Data.SqlClient
Public Class Login

    Private Sub OK_Click_1(sender As Object, e As EventArgs) Handles OK.Click
        Dim drLogin As SqlDataReader
        Dim CMDLogin As SqlCommand
        Dim cntx As SqlClient.SqlConnection
        Dim SQL As String
        'koneksi ke database
        cntx = New SqlClient.SqlConnection
        cntx.ConnectionString = "data source=(local);initial catalog=Stok_Barang;integrated security= true"
        cntx.Open()

        SQL = "Select *From users " + " WHERE username = '" & UsernameTextBox.Text & "' " + " and password = '" & PasswordTextBox.Text & "'"
        CMDLogin = New SqlCommand
        CMDLogin.CommandType = CommandType.Text
        CMDLogin.Connection = cntx
        CMDLogin.CommandText = SQL

        drLogin = CMDLogin.ExecuteReader()
        drLogin.Read()
        If drLogin.HasRows Then
            If drLogin("status_user").ToString = "Admin IT" Then
                Me.Hide()
                Index_IT.Show()
            Else
                Me.Hide()
                Index_Koperasi.Show()
            End If
        Else
            MsgBox("Nama User atau Password salah", +vbCritical, "Password Salah")
        End If
        cntx.Close()
        CMDLogin.Dispose()
        drLogin.Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
