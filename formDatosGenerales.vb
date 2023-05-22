Public Class formDatosGenerales
    Private Sub formDatosGenerales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        lboNombre.Items.Add(txtNombre.Text)
        lboEdad.Items.Add(txtEdad.Text)
        lboTel.Items.Add(txtTelefono.Text)
        lboEstado.Items.Add(IIf(chkEstado.Checked, "Casado", "Soltero"))
        txtContador.Text = lboNombre.Items.Count
        txtTelefono.Text = ""
        txtEdad.Text = ""
        txtNombre.Text = ""
        txtNombre.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim l As Integer = lboNombre.SelectedIndex
        lboNombre.Items.RemoveAt(l)
        lboEdad.Items.RemoveAt(l)
        lboTel.Items.RemoveAt(l)
        lboEstado.Items.RemoveAt(l)
        txtContador.Text = lboNombre.Items.Count
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lboNombre.Items.Clear()
        lboEdad.Items.Clear()
        lboTel.Items.Clear()
        lboEstado.Items.Clear()
        txtContador.Text = lboNombre.Items.Count
        txtNombre.Focus()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class