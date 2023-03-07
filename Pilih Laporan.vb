Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class Pilih_Laporan

    Dim cntx As SqlClient.SqlConnection

    Sub koneksi()
        cntx = New SqlClient.SqlConnection
        cntx.ConnectionString = "data source=(local);initial catalog=Stok_Barang;integrated security =true"
        cntx.Open()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim objReport As New rptBarang
        Dim AccessCommand As New System.Data.SqlClient.SqlCommand("select * from barang", cntx)

        AccessCommand.CommandText = "select * from barang"
        Dim ds As New DataSet()
        Dim da As New SqlDataAdapter(AccessCommand)
        Dim dtT As New DataTable
        da.Fill(dtT)
        ds.Tables.Add(dtT)
        objReport.Database.Tables("barang").SetDataSource(ds.Tables(0))

        frmTampilLaporan.rptview.ShowGroupTreeButton = False
        frmTampilLaporan.rptview.ReportSource = objReport
        frmTampilLaporan.rptview.Refresh()
        frmTampilLaporan.StartPosition = FormStartPosition.CenterScreen
        frmTampilLaporan.WindowState = FormWindowState.Maximized
        frmTampilLaporan.Show()
    End Sub

    Private Sub Pilih_Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim objReport As New rptBarangMasuk
        Dim AccessCommand As New System.Data.SqlClient.SqlCommand("select * from barang_masuk", cntx)
        Dim whereString As String = ""

        If ckBulananBarangKeluar.Checked = True Then
            whereString = "month(tgl_masuk)='" & Format(DTP1.Value, "MM") & "' and year(tgl_masuk)='" & Format(DTP1.Value, "yyyy") & "'"
        Else
            whereString = "(tgl_masuk>='" & Format(DTP1.Value, "MM/dd/yyyy") & "' and tgl_masuk<='" & Format(DTP2.Value, "MM/dd/yyyy") & "')"
        End If
        'get data
        AccessCommand.CommandText = "select * from barang_masuk where " & whereString & ""
        Dim ds As New DataSet()
        Dim da As New SqlDataAdapter(AccessCommand)
        Dim dtT As New DataTable
        da.Fill(dtT)
        ds.Tables.Add(dtT)
        objReport.Database.Tables("barang_masuk").SetDataSource(ds.Tables(0))


        'send to parameter

        If ckBulananBarangMasuk.Checked = True Then
            objReport.SetParameterValue("Tampiltanggal", "Bulan :" & Format(DTP1.Value.Date, "MMMM") & ", " & Format(DTP2.Value.Date, "yyyy"))
        Else
            objReport.SetParameterValue("Tampiltanggal", "Tanggal :" & Format(DTP1.Value.Date, "dd MMMM yyyy") & " - " & Format(DTP2.Value.Date, "dd MMMM yyyy"))
        End If

        'load to view report
        frmTampilLaporan.rptview.ShowGroupTreeButton = False
        frmTampilLaporan.rptview.ReportSource = objReport
        frmTampilLaporan.rptview.Refresh()
        frmTampilLaporan.StartPosition = FormStartPosition.CenterScreen
        frmTampilLaporan.WindowState = FormWindowState.Maximized
        frmTampilLaporan.Show()
    End Sub

    Private Sub ckBulananBarangMasuk_CheckedChanged(sender As Object, e As EventArgs) Handles ckBulananBarangMasuk.CheckedChanged
        If ckBulananBarangMasuk.Checked = True Then
            DTP2.Enabled = False
            DTP1.Format = DateTimePickerFormat.Custom
            DTP1.CustomFormat = "MM/yyyy"
        Else
            DTP2.Enabled = True
            DTP1.Format = DateTimePickerFormat.Custom
            DTP1.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Dim objReport As New rptBarangKeluar
        Dim AccessCommand As New System.Data.SqlClient.SqlCommand("select * from barang_keluar", cntx)
        Dim whereString As String = ""

        If ckBulananBarangKeluar.Checked = True Then
            whereString = "month(tgl_keluar)='" & Format(DTP3.Value, "MM") & "' and year(tgl_keluar)='" & Format(DTP3.Value, "yyyy") & "'"
        Else
            whereString = "(tgl_keluar>='" & Format(DTP3.Value, "MM/dd/yyyy") & "' and tgl_keluar<='" & Format(DTP4.Value, "MM/dd/yyyy") & "')"
        End If
        'get data
        AccessCommand.CommandText = "select * from barang_keluar where " & whereString & ""
        Dim ds As New DataSet()
        Dim da As New SqlDataAdapter(AccessCommand)
        Dim dtT As New DataTable
        da.Fill(dtT)
        ds.Tables.Add(dtT)
        objReport.Database.Tables("barang_keluar").SetDataSource(ds.Tables(0))


        'send to parameter

        If ckBulananBarangKeluar.Checked = True Then
            objReport.SetParameterValue("Tampiltanggal", "Bulan :" & Format(DTP3.Value.Date, "MMMM") & ", " & Format(DTP4.Value.Date, "yyyy"))
        Else
            objReport.SetParameterValue("Tampiltanggal", "Tanggal :" & Format(DTP3.Value.Date, "dd MMMM yyyy") & " - " & Format(DTP4.Value.Date, "dd MMMM yyyy"))
        End If

        'load to view report
        frmTampilLaporan.rptview.ShowGroupTreeButton = False
        frmTampilLaporan.rptview.ReportSource = objReport
        frmTampilLaporan.rptview.Refresh()
        frmTampilLaporan.StartPosition = FormStartPosition.CenterScreen
        frmTampilLaporan.WindowState = FormWindowState.Maximized
        frmTampilLaporan.Show()
    End Sub

    Private Sub ckBulananBarangKeluar_CheckedChanged(sender As Object, e As EventArgs) Handles ckBulananBarangKeluar.CheckedChanged
        If ckBulananBarangKeluar.Checked = True Then
            DTP4.Enabled = False
            DTP3.Format = DateTimePickerFormat.Custom
            DTP3.CustomFormat = "MM/yyyy"
        Else
            DTP4.Enabled = True
            DTP3.Format = DateTimePickerFormat.Custom
            DTP3.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Dim objReport As New rptPenyesuaian
        Dim AccessCommand As New System.Data.SqlClient.SqlCommand("select * from penyesuaian", cntx)
        Dim whereString As String = ""

        If ckBulananBarangKeluar.Checked = True Then
            whereString = "month(tgl_penye)='" & Format(DTP5.Value, "MM") & "' and year(tgl_penye)='" & Format(DTP5.Value, "yyyy") & "'"
        Else
            whereString = "(tgl_penye>='" & Format(DTP5.Value, "MM/dd/yyyy") & "' and tgl_penye<='" & Format(DTP6.Value, "MM/dd/yyyy") & "')"
        End If
        'get data
        AccessCommand.CommandText = "select * from penyesuaian where " & whereString & ""
        Dim ds As New DataSet()
        Dim da As New SqlDataAdapter(AccessCommand)
        Dim dtT As New DataTable
        da.Fill(dtT)
        ds.Tables.Add(dtT)
        objReport.Database.Tables("penyesuaian").SetDataSource(ds.Tables(0))


        'send to parameter

        If ckBulananPenyesuaian.Checked = True Then
            objReport.SetParameterValue("Tampiltanggal", "Bulan :" & Format(DTP5.Value.Date, "MMMM") & ", " & Format(DTP6.Value.Date, "yyyy"))
        Else
            objReport.SetParameterValue("Tampiltanggal", "Tanggal :" & Format(DTP5.Value.Date, "dd MMMM yyyy") & " - " & Format(DTP6.Value.Date, "dd MMMM yyyy"))
        End If

        'load to view report
        frmTampilLaporan.rptview.ShowGroupTreeButton = False
        frmTampilLaporan.rptview.ReportSource = objReport
        frmTampilLaporan.rptview.Refresh()
        frmTampilLaporan.StartPosition = FormStartPosition.CenterScreen
        frmTampilLaporan.WindowState = FormWindowState.Maximized
        frmTampilLaporan.Show()
    End Sub

    Private Sub ckBulananPenyesuaian_CheckedChanged(sender As Object, e As EventArgs) Handles ckBulananPenyesuaian.CheckedChanged
        If ckBulananPenyesuaian.Checked = True Then
            DTP6.Enabled = False
            DTP5.Format = DateTimePickerFormat.Custom
            DTP5.CustomFormat = "MM/yyyy"
        Else
            DTP6.Enabled = True
            DTP5.Format = DateTimePickerFormat.Custom
            DTP5.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Dim objReport As New rptStokBarang
        Dim AccessCommand As New System.Data.SqlClient.SqlCommand("select * from stok_barang", cntx)

        AccessCommand.CommandText = "select * from stok_barang"
        Dim ds As New DataSet()
        Dim da As New SqlDataAdapter(AccessCommand)
        Dim dtT As New DataTable
        da.Fill(dtT)
        ds.Tables.Add(dtT)
        objReport.Database.Tables("stok_barang").SetDataSource(ds.Tables(0))

        frmTampilLaporan.rptview.ShowGroupTreeButton = False
        frmTampilLaporan.rptview.ReportSource = objReport
        frmTampilLaporan.rptview.Refresh()
        frmTampilLaporan.StartPosition = FormStartPosition.CenterScreen
        frmTampilLaporan.WindowState = FormWindowState.Maximized
        frmTampilLaporan.Show()
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Dim objReport As New rptCancel
        Dim AccessCommand As New System.Data.SqlClient.SqlCommand("select * from cancel", cntx)
        Dim whereString As String = ""

        If ckBulananBarangKeluar.Checked = True Then
            whereString = "month(tgl_cancel)='" & Format(DTP7.Value, "MM") & "' and year(tgl_cancel)='" & Format(DTP7.Value, "yyyy") & "'"
        Else
            whereString = "(tgl_cancel>='" & Format(DTP7.Value, "MM/dd/yyyy") & "' and tgl_cancel<='" & Format(DTP8.Value, "MM/dd/yyyy") & "')"
        End If
        'get data
        AccessCommand.CommandText = "select * from cancel where " & whereString & ""
        Dim ds As New DataSet()
        Dim da As New SqlDataAdapter(AccessCommand)
        Dim dtT As New DataTable
        da.Fill(dtT)
        ds.Tables.Add(dtT)
        objReport.Database.Tables("cancel").SetDataSource(ds.Tables(0))


        'send to parameter

        If ckBulananCancel.Checked = True Then
            objReport.SetParameterValue("Tampiltanggal", "Bulan :" & Format(DTP7.Value.Date, "MMMM") & ", " & Format(DTP8.Value.Date, "yyyy"))
        Else
            objReport.SetParameterValue("Tampiltanggal", "Tanggal :" & Format(DTP7.Value.Date, "dd MMMM yyyy") & " - " & Format(DTP8.Value.Date, "dd MMMM yyyy"))
        End If

        'load to view report
        frmTampilLaporan.rptview.ShowGroupTreeButton = False
        frmTampilLaporan.rptview.ReportSource = objReport
        frmTampilLaporan.rptview.Refresh()
        frmTampilLaporan.StartPosition = FormStartPosition.CenterScreen
        frmTampilLaporan.WindowState = FormWindowState.Maximized
        frmTampilLaporan.Show()
    End Sub

    Private Sub ckBulananCancel_CheckedChanged(sender As Object, e As EventArgs) Handles ckBulananCancel.CheckedChanged
        If ckBulananCancel.Checked = True Then
            DTP8.Enabled = False
            DTP7.Format = DateTimePickerFormat.Custom
            DTP7.CustomFormat = "MM/yyyy"
        Else
            DTP8.Enabled = True
            DTP7.Format = DateTimePickerFormat.Custom
            DTP7.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub
End Class