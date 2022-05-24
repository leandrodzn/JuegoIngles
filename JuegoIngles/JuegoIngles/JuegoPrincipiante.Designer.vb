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
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(338, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 541)
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
        'JuegoPrincipiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 566)
        Me.Controls.Add(Me.btMenu)
        Me.Controls.Add(Me.btTerminar)
        Me.Controls.Add(Me.btComenzar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "JuegoPrincipiante"
        Me.Text = "JuegoPrincipiante"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btComenzar As Button
    Friend WithEvents btTerminar As Button
    Friend WithEvents btMenu As Button
End Class
