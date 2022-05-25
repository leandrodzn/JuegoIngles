<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modelo
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
        Me.btR4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btSonido = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btR1
        '
        Me.btR1.Location = New System.Drawing.Point(53, 348)
        Me.btR1.Name = "btR1"
        Me.btR1.Size = New System.Drawing.Size(388, 75)
        Me.btR1.TabIndex = 0
        Me.btR1.Text = "Respuesta 1"
        Me.btR1.UseVisualStyleBackColor = True
        '
        'btR2
        '
        Me.btR2.Location = New System.Drawing.Point(501, 348)
        Me.btR2.Name = "btR2"
        Me.btR2.Size = New System.Drawing.Size(388, 75)
        Me.btR2.TabIndex = 1
        Me.btR2.Text = "Respuesta 2"
        Me.btR2.UseVisualStyleBackColor = True
        '
        'btR3
        '
        Me.btR3.Location = New System.Drawing.Point(53, 449)
        Me.btR3.Name = "btR3"
        Me.btR3.Size = New System.Drawing.Size(388, 75)
        Me.btR3.TabIndex = 2
        Me.btR3.Text = "Respuesta 3"
        Me.btR3.UseVisualStyleBackColor = True
        '
        'btR4
        '
        Me.btR4.Location = New System.Drawing.Point(501, 449)
        Me.btR4.Name = "btR4"
        Me.btR4.Size = New System.Drawing.Size(388, 75)
        Me.btR4.TabIndex = 3
        Me.btR4.Text = "Respuesta 4"
        Me.btR4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(279, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 290)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btSonido
        '
        Me.btSonido.Location = New System.Drawing.Point(53, 87)
        Me.btSonido.Name = "btSonido"
        Me.btSonido.Size = New System.Drawing.Size(92, 74)
        Me.btSonido.TabIndex = 5
        Me.btSonido.Text = "Sonido"
        Me.btSonido.UseVisualStyleBackColor = True
        '
        'Modelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(961, 564)
        Me.Controls.Add(Me.btSonido)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btR4)
        Me.Controls.Add(Me.btR3)
        Me.Controls.Add(Me.btR2)
        Me.Controls.Add(Me.btR1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Modelo"
        Me.Text = "PPrinci1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents PictureBox1 As PictureBox
    Public WithEvents btR1 As Button
    Public WithEvents btR2 As Button
    Public WithEvents btR3 As Button
    Public WithEvents btR4 As Button
    Friend WithEvents btSonido As Button
End Class
