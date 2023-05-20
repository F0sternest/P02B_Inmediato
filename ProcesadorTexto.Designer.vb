<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formProcesadorTexto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtResultado
        '
        Me.txtResultado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtResultado.Location = New System.Drawing.Point(96, 52)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(599, 20)
        Me.txtResultado.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(96, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 164)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color de fondo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnVerde)
        Me.GroupBox2.Controls.Add(Me.btnAzul)
        Me.GroupBox2.Controls.Add(Me.btnRojo)
        Me.GroupBox2.Location = New System.Drawing.Point(329, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 164)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Color de fuente"
        '
        'btnVerde
        '
        Me.btnVerde.Location = New System.Drawing.Point(7, 119)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(75, 23)
        Me.btnVerde.TabIndex = 2
        Me.btnVerde.Text = "Verde"
        Me.btnVerde.UseVisualStyleBackColor = True
        '
        'btnAzul
        '
        Me.btnAzul.Location = New System.Drawing.Point(7, 76)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(75, 23)
        Me.btnAzul.TabIndex = 1
        Me.btnAzul.Text = "Azul"
        Me.btnAzul.UseVisualStyleBackColor = True
        '
        'btnRojo
        '
        Me.btnRojo.Location = New System.Drawing.Point(7, 37)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(75, 23)
        Me.btnRojo.TabIndex = 0
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(575, 126)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(120, 164)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones de Fuente"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(336, 344)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'formProcesadorTexto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtResultado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formProcesadorTexto"
        Me.Text = "ProcesadorTexto"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtResultado As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnVerde As Button
    Friend WithEvents btnAzul As Button
    Friend WithEvents btnRojo As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnLimpiar As Button
End Class
