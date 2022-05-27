Public Class Creditos
    Private Sub Creditos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Menu.Show()
    End Sub

    Private Sub Creditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + "\images\belen.jpg")
        Me.PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath + "\images\carlos.png")
        Me.PictureBox3.Image = Image.FromFile(My.Application.Info.DirectoryPath + "\images\leandro.png")
        Me.PictureBox4.Image = Image.FromFile(My.Application.Info.DirectoryPath + "\images\erik.jpeg")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class