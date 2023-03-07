Public Class Index_IT

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        User.ShowDialog()
    End Sub

    Private Sub btn_barang_Click(sender As Object, e As EventArgs) Handles btn_barang.Click
        Barang.ShowDialog()
    End Sub

    Private Sub btn_Stok_Click(sender As Object, e As EventArgs) Handles btn_Stok.Click
        Stok_Barang.ShowDialog()
    End Sub

    Private Sub btn_BK_Click(sender As Object, e As EventArgs) Handles btn_BK.Click
        Barang_Keluar.ShowDialog()
    End Sub

    Private Sub btn_BP_Click(sender As Object, e As EventArgs) Handles btn_BP.Click
        Barang_Penyesuaian.ShowDialog()
    End Sub

    Private Sub btn_Lap_Click(sender As Object, e As EventArgs) Handles btn_Lap.Click
        Pilih_Laporan.ShowDialog()
    End Sub

    Dim konfirmasi As String
    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        konfirmasi = MsgBox("Anda yakin ingin Keluar..?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Close()
        End If
    End Sub

    Private Sub btn_Masuk_Click(sender As Object, e As EventArgs) Handles btn_Masuk.Click
        Barang_Masuk.ShowDialog()
    End Sub
End Class