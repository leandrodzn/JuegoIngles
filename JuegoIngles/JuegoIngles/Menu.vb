Public Class Menu
    Private Sub btMPrincipiante_Click(sender As Object, e As EventArgs) Handles btMPrincipiante.Click
        JuegoPrincipiante.Show()
        Me.Hide()
    End Sub

    Private Sub btMAvanzado_Click(sender As Object, e As EventArgs) Handles btMAvanzado.Click
        JuegoAvanzado.Show()
        Me.Hide()
    End Sub

    Private Sub btCreditos_Click(sender As Object, e As EventArgs) Handles btCreditos.Click
        Creditos.Show()
        Me.Hide()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
