Public Class Menu
    Private Sub btMPrincipiante_Click(sender As Object, e As EventArgs) Handles btMPrincipiante.Click
        JuegoPrincipiante.principiante = True
        JuegoPrincipiante.SplitContainer1.Panel2.BackColor = Color.FromArgb(195, 254, 139)
        JuegoPrincipiante.SplitContainer1.Panel1.BackColor = Color.FromArgb(254, 176, 139)
        JuegoPrincipiante.Show()
        Me.Hide()
    End Sub

    Private Sub btMAvanzado_Click(sender As Object, e As EventArgs) Handles btMAvanzado.Click
        JuegoPrincipiante.principiante = False
        JuegoPrincipiante.SplitContainer1.Panel1.BackColor = Color.FromArgb(195, 254, 139)
        JuegoPrincipiante.SplitContainer1.Panel2.BackColor = Color.FromArgb(254, 176, 139)

        JuegoPrincipiante.Show()
        Me.Hide()
    End Sub

    Private Sub btCreditos_Click(sender As Object, e As EventArgs) Handles btCreditos.Click
        Creditos.Show()
        Me.Hide()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + "\images\visual.png")
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub btInstrucciones_Click(sender As Object, e As EventArgs) Handles btInstrucciones.Click
        Intrucciones.Show()
        Me.Hide()
    End Sub
End Class
