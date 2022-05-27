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
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btInstrucciones = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btMPrincipiante
        '
        Me.btMPrincipiante.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btMPrincipiante.Location = New System.Drawing.Point(285, 263)
        Me.btMPrincipiante.Name = "btMPrincipiante"
        Me.btMPrincipiante.Size = New System.Drawing.Size(283, 56)
        Me.btMPrincipiante.TabIndex = 0
        Me.btMPrincipiante.Text = "Jugar en modo principiante"
        Me.btMPrincipiante.UseVisualStyleBackColor = False
        '
        'btMAvanzado
        '
        Me.btMAvanzado.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btMAvanzado.Location = New System.Drawing.Point(285, 335)
        Me.btMAvanzado.Name = "btMAvanzado"
        Me.btMAvanzado.Size = New System.Drawing.Size(283, 56)
        Me.btMAvanzado.TabIndex = 1
        Me.btMAvanzado.Text = "Jugar en modo avanzado"
        Me.btMAvanzado.UseVisualStyleBackColor = False
        '
        'btCreditos
        '
        Me.btCreditos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btCreditos.Location = New System.Drawing.Point(284, 479)
        Me.btCreditos.Name = "btCreditos"
        Me.btCreditos.Size = New System.Drawing.Size(283, 56)
        Me.btCreditos.TabIndex = 2
        Me.btCreditos.Text = "Créditos"
        Me.btCreditos.UseVisualStyleBackColor = False
        '
        'btSalir
        '
        Me.btSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btSalir.Location = New System.Drawing.Point(285, 551)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(283, 56)
        Me.btSalir.TabIndex = 3
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'btInstrucciones
        '
        Me.btInstrucciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btInstrucciones.Location = New System.Drawing.Point(285, 407)
        Me.btInstrucciones.Name = "btInstrucciones"
        Me.btInstrucciones.Size = New System.Drawing.Size(283, 56)
        Me.btInstrucciones.TabIndex = 4
        Me.btInstrucciones.Text = "Instrucciones"
        Me.btInstrucciones.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(245, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(368, 233)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(870, 631)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btInstrucciones)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btCreditos)
        Me.Controls.Add(Me.btMAvanzado)
        Me.Controls.Add(Me.btMPrincipiante)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btMPrincipiante As Button
    Friend WithEvents btMAvanzado As Button
    Friend WithEvents btCreditos As Button
    Friend WithEvents btSalir As Button
    Friend WithEvents btInstrucciones As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
