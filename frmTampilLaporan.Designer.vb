<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTampilLaporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rptview = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'rptview
        '
        Me.rptview.ActiveViewIndex = -1
        Me.rptview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptview.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptview.Location = New System.Drawing.Point(0, 0)
        Me.rptview.Name = "rptview"
        Me.rptview.Size = New System.Drawing.Size(284, 261)
        Me.rptview.TabIndex = 1
        Me.rptview.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmTampilLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.rptview)
        Me.Name = "frmTampilLaporan"
        Me.Text = "frmTampilLaporan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptview As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
