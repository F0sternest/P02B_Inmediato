Public Class formDatosGenerales

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not txtNombre.Text = "" And Not txtEdad.Text = "" And Not txtTelefono.Text = "" Then
            lboNombre.Items.Add(txtNombre.Text)
            lboEdad.Items.Add(txtEdad.Text)
            lboTel.Items.Add(txtTelefono.Text)
            lboEstado.Items.Add(IIf(chkEstado.Checked, "Casado", "Soltero"))
            txtContador.Text = lboNombre.Items.Count
            txtTelefono.Text = ""
            txtEdad.Text = ""
            txtNombre.Text = ""
            txtNombre.Focus()
        Else
            MsgBox("Porfavor llene todos los campos", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim l As Integer = lboNombre.SelectedIndex
        If txtNombre.Text = "" Then
            MsgBox("Porfavor introduzca un nombre", MsgBoxStyle.Exclamation)
            txtTelefono.Text = ""
            txtEdad.Text = ""
            txtNombre.Text = ""
            txtNombre.Focus()
        Else
            Dim itemIndex As Integer = lboNombre.Items.IndexOf(txtNombre.Text)
            If lboNombre.Items.IndexOf(txtNombre.Text) >= 0 Then
                lboNombre.Items.RemoveAt(itemIndex)
                lboEdad.Items.RemoveAt(itemIndex)
                lboTel.Items.RemoveAt(itemIndex)
                lboEstado.Items.RemoveAt(itemIndex)
            Else
                MsgBox("Porfavor introduzca el nombre de una persona de la lista", MsgBoxStyle.Exclamation)
                txtTelefono.Text = ""
                txtEdad.Text = ""
                txtNombre.Text = ""
            End If
            txtContador.Text = lboNombre.Items.Count
            txtTelefono.Text = ""
            txtEdad.Text = ""
            txtNombre.Text = ""
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lboNombre.Items.Clear()
        lboEdad.Items.Clear()
        lboTel.Items.Clear()
        lboEstado.Items.Clear()
        txtContador.Text = lboNombre.Items.Count
        txtNombre.Focus()
    End Sub

End Class