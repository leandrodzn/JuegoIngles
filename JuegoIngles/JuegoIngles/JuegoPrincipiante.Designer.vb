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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lbPregunta = New System.Windows.Forms.Label()
        Me.lb3 = New System.Windows.Forms.Label()
        Me.lbAciertos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btTerminar = New System.Windows.Forms.Button()
        Me.btComenzar = New System.Windows.Forms.Button()
        Me.btMenu = New System.Windows.Forms.Button()
        Me.btSiguiente = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btSiguiente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbPregunta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lb3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbAciertos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btTerminar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btComenzar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btMenu)
        Me.SplitContainer1.Size = New System.Drawing.Size(1336, 580)
        Me.SplitContainer1.SplitterDistance = 349
        Me.SplitContainer1.TabIndex = 0
        '
        'lbPregunta
        '
        Me.lbPregunta.AutoSize = True
        Me.lbPregunta.Location = New System.Drawing.Point(131, 376)
        Me.lbPregunta.Name = "lbPregunta"
        Me.lbPregunta.Size = New System.Drawing.Size(0, 20)
        Me.lbPregunta.TabIndex = 6
        '
        'lb3
        '
        Me.lb3.AutoSize = True
        Me.lb3.Location = New System.Drawing.Point(131, 346)
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(71, 20)
        Me.lb3.TabIndex = 5
        Me.lb3.Text = "Pregunta:"
        '
        'lbAciertos
        '
        Me.lbAciertos.AutoSize = True
        Me.lbAciertos.Location = New System.Drawing.Point(131, 272)
        Me.lbAciertos.Name = "lbAciertos"
        Me.lbAciertos.Size = New System.Drawing.Size(0, 20)
        Me.lbAciertos.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Aciertos:"
        '
        'btTerminar
        '
        Me.btTerminar.Location = New System.Drawing.Point(35, 516)
        Me.btTerminar.Name = "btTerminar"
        Me.btTerminar.Size = New System.Drawing.Size(260, 52)
        Me.btTerminar.TabIndex = 2
        Me.btTerminar.Text = "Terminar partida"
        Me.btTerminar.UseVisualStyleBackColor = True
        '
        'btComenzar
        '
        Me.btComenzar.Location = New System.Drawing.Point(35, 146)
        Me.btComenzar.Name = "btComenzar"
        Me.btComenzar.Size = New System.Drawing.Size(260, 52)
        Me.btComenzar.TabIndex = 1
        Me.btComenzar.Text = "Comenzar partida"
        Me.btComenzar.UseVisualStyleBackColor = True
        '
        'btMenu
        '
        Me.btMenu.Location = New System.Drawing.Point(35, 36)
        Me.btMenu.Name = "btMenu"
        Me.btMenu.Size = New System.Drawing.Size(260, 52)
        Me.btMenu.TabIndex = 0
        Me.btMenu.Text = "Regresar al menú"
        Me.btMenu.UseVisualStyleBackColor = True
        '
        'btSiguiente
        '
        Me.btSiguiente.Location = New System.Drawing.Point(35, 416)
        Me.btSiguiente.Name = "btSiguiente"
        Me.btSiguiente.Size = New System.Drawing.Size(260, 52)
        Me.btSiguiente.TabIndex = 7
        Me.btSiguiente.Text = "Siguiente pregunta"
        Me.btSiguiente.UseVisualStyleBackColor = True
        '
        'JuegoPrincipiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1336, 580)
        Me.Controls.Add(Me.SplitContainer1)
        Me.IsMdiContainer = True
        Me.Name = "JuegoPrincipiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modo principiante"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lbPregunta As Label
    Friend WithEvents lb3 As Label
    Friend WithEvents lbAciertos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btTerminar As Button
    Friend WithEvents btComenzar As Button
    Friend WithEvents btMenu As Button
    Friend WithEvents btSiguiente As Button
End Class
