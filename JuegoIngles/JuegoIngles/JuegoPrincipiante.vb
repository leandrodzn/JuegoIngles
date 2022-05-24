Public Class JuegoPrincipiante
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btMenu.Click

    End Sub

    Private Sub btComenzar_Click(sender As Object, e As EventArgs) Handles btComenzar.Click
        btMenu.Enabled = False
        btTerminar.Enabled = True
    End Sub

    Private Sub JuegoPrincipiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btTerminar.Enabled = False
    End Sub
End Class