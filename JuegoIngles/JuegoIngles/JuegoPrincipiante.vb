Public Class JuegoPrincipiante

    Private Sub btComenzar_Click(sender As Object, e As EventArgs) Handles btComenzar.Click
        btComenzar.Enabled = False
        btMenu.Enabled = False
        btTerminar.Enabled = True

    End Sub

    Private Sub JuegoPrincipiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btTerminar.Enabled = False

    End Sub

    Private Sub JuegoPrincipiante_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Menu.Show()

    End Sub

    Private Sub btMenu_Click(sender As Object, e As EventArgs) Handles btMenu.Click
        Me.Close()
        Menu.Show()

    End Sub

    Private Sub btTerminar_Click(sender As Object, e As EventArgs) Handles btTerminar.Click
        btMenu.Enabled = True
        btComenzar.Enabled = True
        btTerminar.Enabled = False

    End Sub
End Class