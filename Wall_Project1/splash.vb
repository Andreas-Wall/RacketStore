Public Class splash
    Public Function steps(loading As String)
        lblStatus.Text = loading
        steps()
    End Function

    Public Function steps()
        ProgressBar1.PerformStep()
        Application.DoEvents()
    End Function

End Class