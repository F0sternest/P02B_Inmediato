Imports System.Resources

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
        txtResultado.BackColor = Color.White
        If chkMayuscula.CheckState = CheckState.Checked Then
            chkMayuscula.CheckState = CheckState.Unchecked
        End If
        If chkNegrita.CheckState = CheckState.Checked Then
            chkNegrita.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub optFondoVerde_CheckedChanged(sender As Object, e As EventArgs) Handles optFondoVerde.CheckedChanged
        txtResultado.BackColor = Color.DarkOliveGreen
    End Sub

    Private Sub optFondoRojo_CheckedChanged(sender As Object, e As EventArgs) Handles optFondoRojo.CheckedChanged
        txtResultado.BackColor = Color.DarkRed
    End Sub

    Private Sub optFondoAzul_CheckedChanged(sender As Object, e As EventArgs) Handles optFondoAzul.CheckedChanged
        txtResultado.BackColor = Color.CadetBlue
    End Sub

    Private Sub chkMayuscula_CheckedChanged(sender As Object, e As EventArgs) Handles chkMayuscula.CheckedChanged
        If chkMayuscula.Checked = True Then
            txtResultado.Text = UCase(txtResultado.Text)
        Else
            txtResultado.Text = LCase(txtResultado.Text)
        End If
    End Sub

    Private Sub chkNegrita_CheckedChanged(sender As Object, e As EventArgs) Handles chkNegrita.CheckedChanged
        If chkNegrita.Checked = True Then
            txtResultado.Font = New Font(txtResultado.Font, FontStyle.Bold)
        Else
            txtResultado.Font = New Font(txtResultado.Font, FontStyle.Regular)
        End If
    End Sub
End Class