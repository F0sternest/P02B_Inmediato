Public Class formProcesadorTexto
    Private Sub btnRojo_Click(sender As Object, e As EventArgs) Handles btnRojo.Click
        txtResultado.ForeColor = Color.Red
    End Sub

    Private Sub btnAzul_Click(sender As Object, e As EventArgs) Handles btnAzul.Click
        txtResultado.ForeColor = Color.Blue
    End Sub

    Private Sub btnVerde_Click(sender As Object, e As EventArgs) Handles btnVerde.Click
        txtResultado.ForeColor = Color.Green
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtResultado.Text = ""
        txtResultado.ForeColor = Color.Black
    End Sub
End Class