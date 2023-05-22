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
        Me.chkMayuscula = New System.Windows.Forms.CheckBox()
        Me.chkNegrita = New System.Windows.Forms.CheckBox()
        Me.optFondoVerde = New System.Windows.Forms.RadioButton()
        Me.optFondoRojo = New System.Windows.Forms.RadioButton()
        Me.optFondoAzul = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtResultado
        '
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtResultado.Location = New System.Drawing.Point(96, 53)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(599, 33)
        Me.txtResultado.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.optFondoAzul)
        Me.GroupBox1.Controls.Add(Me.optFondoRojo)
        Me.GroupBox1.Controls.Add(Me.optFondoVerde)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(96, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 183)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color de fondo"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnVerde)
        Me.GroupBox2.Controls.Add(Me.btnAzul)
        Me.GroupBox2.Controls.Add(Me.btnRojo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(329, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 183)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Color de fuente"
        '
        'btnVerde
        '
        Me.btnVerde.BackColor = System.Drawing.Color.Chartreuse
        Me.btnVerde.Location = New System.Drawing.Point(30, 135)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(75, 29)
        Me.btnVerde.TabIndex = 2
        Me.btnVerde.Text = "Verde"
        Me.btnVerde.UseVisualStyleBackColor = False
        '
        'btnAzul
        '
        Me.btnAzul.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAzul.Location = New System.Drawing.Point(30, 87)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(75, 33)
        Me.btnAzul.TabIndex = 1
        Me.btnAzul.Text = "Azul"
        Me.btnAzul.UseVisualStyleBackColor = False
        '
        'btnRojo
        '
        Me.btnRojo.BackColor = System.Drawing.Color.LightCoral
        Me.btnRojo.Location = New System.Drawing.Point(30, 41)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(75, 31)
        Me.btnRojo.TabIndex = 0
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.chkNegrita)
        Me.GroupBox3.Controls.Add(Me.chkMayuscula)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(575, 126)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(151, 183)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones de Fuente"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLimpiar.Location = New System.Drawing.Point(339, 351)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(119, 39)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'chkMayuscula
        '
        Me.chkMayuscula.AutoSize = True
        Me.chkMayuscula.Location = New System.Drawing.Point(22, 59)
        Me.chkMayuscula.Name = "chkMayuscula"
        Me.chkMayuscula.Size = New System.Drawing.Size(94, 23)
        Me.chkMayuscula.TabIndex = 0
        Me.chkMayuscula.Text = "Mayúscula"
        Me.chkMayuscula.UseVisualStyleBackColor = True
        '
        'chkNegrita
        '
        Me.chkNegrita.AutoSize = True
        Me.chkNegrita.Location = New System.Drawing.Point(22, 107)
        Me.chkNegrita.Name = "chkNegrita"
        Me.chkNegrita.Size = New System.Drawing.Size(74, 23)
        Me.chkNegrita.TabIndex = 1
        Me.chkNegrita.Text = "Negrita"
        Me.chkNegrita.UseVisualStyleBackColor = True
        '
        'optFondoVerde
        '
        Me.optFondoVerde.AutoSize = True
        Me.optFondoVerde.Location = New System.Drawing.Point(18, 41)
        Me.optFondoVerde.Name = "optFondoVerde"
        Me.optFondoVerde.Size = New System.Drawing.Size(63, 23)
        Me.optFondoVerde.TabIndex = 0
        Me.optFondoVerde.TabStop = True
        Me.optFondoVerde.Text = "Verde"
        Me.optFondoVerde.UseVisualStyleBackColor = True
        '
        'optFondoRojo
        '
        Me.optFondoRojo.AutoSize = True
        Me.optFondoRojo.Location = New System.Drawing.Point(17, 87)
        Me.optFondoRojo.Name = "optFondoRojo"
        Me.optFondoRojo.Size = New System.Drawing.Size(54, 23)
        Me.optFondoRojo.TabIndex = 1
        Me.optFondoRojo.TabStop = True
        Me.optFondoRojo.Text = "Rojo"
        Me.optFondoRojo.UseVisualStyleBackColor = True
        '
        'optFondoAzul
        '
        Me.optFondoAzul.AutoSize = True
        Me.optFondoAzul.Location = New System.Drawing.Point(18, 141)
        Me.optFondoAzul.Name = "optFondoAzul"
        Me.optFondoAzul.Size = New System.Drawing.Size(53, 23)
        Me.optFondoAzul.TabIndex = 2
        Me.optFondoAzul.TabStop = True
        Me.optFondoAzul.Text = "Azul"
        Me.optFondoAzul.UseVisualStyleBackColor = True
        '
        'formProcesadorTexto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtResultado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formProcesadorTexto"
        Me.Text = "ProcesadorTexto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents optFondoAzul As RadioButton
    Friend WithEvents optFondoRojo As RadioButton
    Friend WithEvents optFondoVerde As RadioButton
    Friend WithEvents chkNegrita As CheckBox
    Friend WithEvents chkMayuscula As CheckBox
End Class
