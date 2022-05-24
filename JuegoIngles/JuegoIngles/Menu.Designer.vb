<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Me.btMPrincipiante = New System.Windows.Forms.Button()
        Me.btMAvanzado = New System.Windows.Forms.Button()
        Me.btCreditos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btMPrincipiante
        '
        Me.btMPrincipiante.Location = New System.Drawing.Point(285, 192)
        Me.btMPrincipiante.Name = "btMPrincipiante"
        Me.btMPrincipiante.Size = New System.Drawing.Size(283, 71)
        Me.btMPrincipiante.TabIndex = 0
        Me.btMPrincipiante.Text = "Jugar en modo principiante"
        Me.btMPrincipiante.UseVisualStyleBackColor = True
        '
        'btMAvanzado
        '
        Me.btMAvanzado.Location = New System.Drawing.Point(285, 269)
        Me.btMAvanzado.Name = "btMAvanzado"
        Me.btMAvanzado.Size = New System.Drawing.Size(283, 71)
        Me.btMAvanzado.TabIndex = 1
        Me.btMAvanzado.Text = "Jugar en modo avanzado"
        Me.btMAvanzado.UseVisualStyleBackColor = True
        '
        'btCreditos
        '
        Me.btCreditos.Location = New System.Drawing.Point(285, 346)
        Me.btCreditos.Name = "btCreditos"
        Me.btCreditos.Size = New System.Drawing.Size(283, 71)
        Me.btCreditos.TabIndex = 2
        Me.btCreditos.Text = "Créditos"
        Me.btCreditos.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 492)
        Me.Controls.Add(Me.btCreditos)
        Me.Controls.Add(Me.btMAvanzado)
        Me.Controls.Add(Me.btMPrincipiante)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btMPrincipiante As Button
    Friend WithEvents btMAvanzado As Button
    Friend WithEvents btCreditos As Button
End Class
