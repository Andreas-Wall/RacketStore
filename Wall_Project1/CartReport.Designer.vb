<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CartReport))
        Me.crvCart = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvCart
        '
        Me.crvCart.ActiveViewIndex = -1
        Me.crvCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvCart.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvCart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvCart.Location = New System.Drawing.Point(0, 0)
        Me.crvCart.Name = "crvCart"
        Me.crvCart.ShowCloseButton = False
        Me.crvCart.ShowLogo = False
        Me.crvCart.Size = New System.Drawing.Size(658, 450)
        Me.crvCart.TabIndex = 0
        Me.crvCart.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'CartReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 450)
        Me.Controls.Add(Me.crvCart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CartReport"
        Me.Text = "CartReport"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvCart As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
