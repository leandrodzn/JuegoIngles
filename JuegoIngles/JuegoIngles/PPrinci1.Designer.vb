<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPrinci1
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
        Me.btR1 = New System.Windows.Forms.Button()
        Me.btR2 = New System.Windows.Forms.Button()
        Me.btR3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btR1
        '
        Me.btR1.Location = New System.Drawing.Point(53, 315)
        Me.btR1.Name = "btR1"
        Me.btR1.Size = New System.Drawing.Size(242, 121)
        Me.btR1.TabIndex = 0
        Me.btR1.Text = "Respuesta 1"
        Me.btR1.UseVisualStyleBackColor = True
        '
        'btR2
        '
        Me.btR2.Location = New System.Drawing.Point(362, 315)
        Me.btR2.Name = "btR2"
        Me.btR2.Size = New System.Drawing.Size(242, 121)
        Me.btR2.TabIndex = 1
        Me.btR2.Text = "Respuesta 2"
        Me.btR2.UseVisualStyleBackColor = True
        '
        'btR3
        '
        Me.btR3.Location = New System.Drawing.Point(666, 315)
        Me.btR3.Name = "btR3"
        Me.btR3.Size = New System.Drawing.Size(242, 121)
        Me.btR3.TabIndex = 2
        Me.btR3.Text = "Respuesta 3"
        Me.btR3.UseVisualStyleBackColor = True
        '
        'PPrinci1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 525)
        Me.Controls.Add(Me.btR3)
        Me.Controls.Add(Me.btR2)
        Me.Controls.Add(Me.btR1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PPrinci1"
        Me.Text = "PPrinci1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btR1 As Button
    Friend WithEvents btR2 As Button
    Friend WithEvents btR3 As Button
End Class
