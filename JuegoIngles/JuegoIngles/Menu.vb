Public Class Menu
    Private Sub btMPrincipiante_Click(sender As Object, e As EventArgs) Handles btMPrincipiante.Click
        JuegoPrincipiante.Show()
    End Sub

    Private Sub btMAvanzado_Click(sender As Object, e As EventArgs) Handles btMAvanzado.Click
        JuegoAvanzado.Show()
    End Sub

    Private Sub btCreditos_Click(sender As Object, e As EventArgs) Handles btCreditos.Click
        Creditos.Show()
    End Sub
End Class
