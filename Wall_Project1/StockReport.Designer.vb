<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockReport))
        Me.crvStock = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvStock
        '
        Me.crvStock.ActiveViewIndex = -1
        Me.crvStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvStock.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvStock.Location = New System.Drawing.Point(0, 0)
        Me.crvStock.Name = "crvStock"
        Me.crvStock.ShowCloseButton = False
        Me.crvStock.ShowLogo = False
        Me.crvStock.Size = New System.Drawing.Size(700, 392)
        Me.crvStock.TabIndex = 0
        Me.crvStock.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'StockReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 392)
        Me.Controls.Add(Me.crvStock)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StockReport"
        Me.Text = "StockReport"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvStock As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
