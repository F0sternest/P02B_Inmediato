Public Class homeForm
    Sub cambiarPanel(ByVal panel As Form)
        pnlProcesadorTexto.Controls.Clear()
        panel.TopLevel = False
        pnlProcesadorTexto.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cambiarPanel(formProcesadorTexto)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cambiarPanel(formPresentacion)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Stop
    End Sub
End Class
