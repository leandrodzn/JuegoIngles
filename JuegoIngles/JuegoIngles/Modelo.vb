Public Class Modelo

    Public valorB1 As String
    Public valorB2 As String
    Public valorB3 As String
    Public valorB4 As String
    Public palabra As String
    Public numero As String



    Private Sub Modelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btR1.Text = valorB1
        btR2.Text = valorB2
        btR3.Text = valorB3
        btR4.Text = valorB4

        Me.PictureBox1.Image = Image.FromFile("C:\Users\leodz\OneDrive\Documentos\UADY LIS\4 semestre\Teoría de Lenguajes de Programación\proyecto visual\JuegoIngles\JuegoIngles\images\Prin" + numero + ".png")


    End Sub

    Private Sub btR1_Click(sender As Object, e As EventArgs) Handles btR1.Click

    End Sub


End Class