<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homeForm))
        Me.btnTerminar = New System.Windows.Forms.Button()
        Me.btnTextos = New System.Windows.Forms.Button()
        Me.pnlProcesadorTexto = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDatosGenerales = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.pnlProcesadorTexto.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTerminar
        '
        Me.btnTerminar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnTerminar.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTerminar.Location = New System.Drawing.Point(654, 486)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(144, 38)
        Me.btnTerminar.TabIndex = 11
        Me.btnTerminar.Text = "Terminar"
        Me.btnTerminar.UseVisualStyleBackColor = False
        '
        'btnTextos
        '
        Me.btnTextos.BackColor = System.Drawing.Color.DarkCyan
        Me.btnTextos.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTextos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTextos.Location = New System.Drawing.Point(278, 486)
        Me.btnTextos.Name = "btnTextos"
        Me.btnTextos.Size = New System.Drawing.Size(166, 38)
        Me.btnTextos.TabIndex = 12
        Me.btnTextos.Text = "Procesador de texto"
        Me.btnTextos.UseVisualStyleBackColor = False
        '
        'pnlProcesadorTexto
        '
        Me.pnlProcesadorTexto.BackColor = System.Drawing.Color.White
        Me.pnlProcesadorTexto.Controls.Add(Me.GroupBox1)
        Me.pnlProcesadorTexto.Location = New System.Drawing.Point(48, 30)
        Me.pnlProcesadorTexto.Name = "pnlProcesadorTexto"
        Me.pnlProcesadorTexto.Size = New System.Drawing.Size(800, 450)
        Me.pnlProcesadorTexto.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(56, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 385)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Presentación"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(48, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(596, 57)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(246, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Cambios inmediatos en textos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Integrantes:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Herramientas de Programacion Aplicadas III"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(593, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Equipo: #5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Kevin Rodriguez 8-973-2498"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(569, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Grupo: 1IL132"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Natasha Urdaneta E-8-171454"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Práctica 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Jorge Pitti 8-976-1637"
        '
        'btnDatosGenerales
        '
        Me.btnDatosGenerales.BackColor = System.Drawing.Color.DarkCyan
        Me.btnDatosGenerales.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatosGenerales.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDatosGenerales.Location = New System.Drawing.Point(471, 486)
        Me.btnDatosGenerales.Name = "btnDatosGenerales"
        Me.btnDatosGenerales.Size = New System.Drawing.Size(150, 38)
        Me.btnDatosGenerales.TabIndex = 14
        Me.btnDatosGenerales.Text = "Datos Generales"
        Me.btnDatosGenerales.UseVisualStyleBackColor = False
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.DarkCyan
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnInicio.Location = New System.Drawing.Point(104, 486)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(150, 36)
        Me.btnInicio.TabIndex = 15
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'homeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.P02B_Inmediato.My.Resources.Resources._2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(953, 584)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.btnDatosGenerales)
        Me.Controls.Add(Me.pnlProcesadorTexto)
        Me.Controls.Add(Me.btnTextos)
        Me.Controls.Add(Me.btnTerminar)
        Me.Name = "homeForm"
        Me.Text = "Menu"
        Me.pnlProcesadorTexto.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTerminar As Button
    Friend WithEvents btnTextos As Button
    Friend WithEvents pnlProcesadorTexto As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDatosGenerales As Button
    Friend WithEvents btnInicio As Button
End Class
