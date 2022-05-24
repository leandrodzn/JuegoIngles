<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JuegoPrincipiante
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btComenzar = New System.Windows.Forms.Button()
        Me.btTerminar = New System.Windows.Forms.Button()
        Me.btMenu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lAciertos = New System.Windows.Forms.Label()
        Me.lPregunta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(338, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(961, 525)
        Me.Panel1.TabIndex = 0
        '
        'btComenzar
        '
        Me.btComenzar.Location = New System.Drawing.Point(30, 116)
        Me.btComenzar.Name = "btComenzar"
        Me.btComenzar.Size = New System.Drawing.Size(265, 56)
        Me.btComenzar.TabIndex = 1
        Me.btComenzar.Text = "Comenzar partida"
        Me.btComenzar.UseVisualStyleBackColor = True
        '
        'btTerminar
        '
        Me.btTerminar.Location = New System.Drawing.Point(30, 478)
        Me.btTerminar.Name = "btTerminar"
        Me.btTerminar.Size = New System.Drawing.Size(265, 56)
        Me.btTerminar.TabIndex = 2
        Me.btTerminar.Text = "Terminar partida"
        Me.btTerminar.UseVisualStyleBackColor = True
        '
        'btMenu
        '
        Me.btMenu.Location = New System.Drawing.Point(30, 13)
        Me.btMenu.Name = "btMenu"
        Me.btMenu.Size = New System.Drawing.Size(265, 56)
        Me.btMenu.TabIndex = 3
        Me.btMenu.Text = "Regresar al menú"
        Me.btMenu.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Aciertos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pregunta:"
        '
        'lAciertos
        '
        Me.lAciertos.AutoSize = True
        Me.lAciertos.Location = New System.Drawing.Point(121, 236)
        Me.lAciertos.Name = "lAciertos"
        Me.lAciertos.Size = New System.Drawing.Size(0, 20)
        Me.lAciertos.TabIndex = 7
        '
        'lPregunta
        '
        Me.lPregunta.AutoSize = True
        Me.lPregunta.Location = New System.Drawing.Point(121, 326)
        Me.lPregunta.Name = "lPregunta"
        Me.lPregunta.Size = New System.Drawing.Size(0, 20)
        Me.lPregunta.TabIndex = 8
        '
        'JuegoPrincipiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 572)
        Me.Controls.Add(Me.lPregunta)
        Me.Controls.Add(Me.lAciertos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btMenu)
        Me.Controls.Add(Me.btTerminar)
        Me.Controls.Add(Me.btComenzar)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "JuegoPrincipiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modo principiante"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btComenzar As Button
    Friend WithEvents btTerminar As Button
    Friend WithEvents btMenu As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lAciertos As Label
    Friend WithEvents lPregunta As Label
End Class
