﻿Public Class homeForm
    Sub cambiarPanel(ByVal panel As Form)
        pnlProcesadorTexto.Controls.Clear()
        panel.TopLevel = False
        pnlProcesadorTexto.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnTextos_Click(sender As Object, e As EventArgs) Handles btnTextos.Click
        cambiarPanel(formProcesadorTexto)
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs)
        cambiarPanel(formPresentacion)
    End Sub
    Private Sub btnDatosGenerales_Click(sender As Object, e As EventArgs) Handles btnDatosGenerales.Click
        cambiarPanel(formDatosGenerales)
    End Sub

    Private Sub btnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        Close()
    End Sub

    Private Sub homeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnInicio_Click_1(sender As Object, e As EventArgs) Handles btnInicio.Click
        cambiarPanel(formPresentacion)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
