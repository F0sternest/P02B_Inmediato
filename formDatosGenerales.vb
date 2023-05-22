Public Class formDatosGenerales

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not txtNombre.Text = "" And Not txtEdad.Text = "" And Not txtTelefono.Text = "" And txtID.Text = "" Then
            lboNombre.Items.Add(txtNombre.Text)
            lboEdad.Items.Add(txtEdad.Text)
            lboTel.Items.Add(txtTelefono.Text)
            lboEstado.Items.Add(IIf(chkEstado.Checked, "Casado", "Soltero"))
            lboID.Items.Add(CInt((100 * Rnd()) + 1))
            txtContador.Text = lboNombre.Items.Count
            txtTelefono.Text = ""
            txtEdad.Text = ""
            txtNombre.Text = ""
            txtNombre.Focus()
        Else
            MsgBox("Porfavor llene todos los campos y deje vacio ID", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim l As Integer = lboNombre.SelectedIndex
        If txtNombre.Text = "" And txtID.Text = "" Then
            MsgBox("Porfavor introduzca un nombre o un id", MsgBoxStyle.Exclamation)
            txtTelefono.Text = ""
            txtEdad.Text = ""
            txtNombre.Text = ""
            txtID.Text = ""
            txtNombre.Focus()
        Else
            If Not txtID.Text = "" And lboID.Items.IndexOf(CInt(txtID.Text)) >= 0 Then
                Dim idIndex As Integer = lboID.Items.IndexOf(CInt(txtID.Text))
                lboNombre.Items.RemoveAt(idIndex)
                lboEdad.Items.RemoveAt(idIndex)
                lboTel.Items.RemoveAt(idIndex)
                lboEstado.Items.RemoveAt(idIndex)
                lboID.Items.RemoveAt(idIndex)

            ElseIf Not txtNombre.Text = "" And lboNombre.Items.IndexOf(txtNombre.Text) >= 0 Then
                Dim nameIndex As Integer = lboNombre.Items.IndexOf(txtNombre.Text)
                lboNombre.Items.RemoveAt(nameIndex)
                lboEdad.Items.RemoveAt(nameIndex)
                lboTel.Items.RemoveAt(nameIndex)
                lboEstado.Items.RemoveAt(nameIndex)
                lboID.Items.RemoveAt(nameIndex)
            Else
                MsgBox("Porfavor introduzca el nombre de una persona de la lista o un ID valido", MsgBoxStyle.Exclamation)
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