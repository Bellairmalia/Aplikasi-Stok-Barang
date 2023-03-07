Public Class Index_Koperasi

    Private Sub btn_barang_Click(sender As Object, e As EventArgs) Handles btn_barang.Click
        Barang.Show()
    End Sub

    Private Sub btn_Stok_Click(sender As Object, e As EventArgs) Handles btn_Stok.Click
        Stok_Barang.Show()
    End Sub

    Private Sub btn_BK_Click(sender As Object, e As EventArgs) Handles btn_BK.Click
        Barang_Keluar.Show()
    End Sub

    Private Sub btn_BP_Click(sender As Object, e As EventArgs) Handles btn_BP.Click
        Barang_Penyesuaian.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Pilih_Laporan.ShowDialog()
    End Sub

    Dim konfirmasi As String
    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        konfirmasi = MsgBox("Anda yakin ingin Keluar..?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Barang_Masuk.ShowDialog()
    End Sub
End Class