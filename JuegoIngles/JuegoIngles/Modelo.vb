Public Class Modelo

    Public valorB1 As String
    Public valorB2 As String
    Public valorB3 As String
    Public valorB4 As String
    Public palabra As String
    Public numero As String
    Public banderaB1 As Boolean
    Public banderaB2 As Boolean
    Public banderaB3 As Boolean
    Public banderaB4 As Boolean
    Public puntuacion As Integer
    Public esPrincipiante As Boolean
    Dim s As System.Media.SoundPlayer

    Private Sub Modelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        actualizar()



        'Me.PictureBox1.Image = Image.FromFile("C:\Users\leodz\OneDrive\Documentos\UADY LIS\4 semestre\Teoría de Lenguajes de Programación\proyecto visual\JuegoIngles\JuegoIngles\images\Prin" + numero + ".png")



    End Sub

    Public Sub actualizar()
        btR1.Text = valorB1
        btR2.Text = valorB2
        btR3.Text = valorB3
        btR4.Text = valorB4
        puntuacion = 0
        btR1.Enabled = True
        btR2.Enabled = True
        btR3.Enabled = True
        btR4.Enabled = True

        If esPrincipiante Then
            Me.PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + "\images\Prin" + numero + ".png")
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "\audios\principiante" + numero + ".wav")

        Else
            Me.PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + "\images\Avanzado" + numero + ".png")
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "\audios\avanzado" + numero + ".wav")
        End If
    End Sub

    Private Sub btR1_Click(sender As Object, e As EventArgs) Handles btR1.Click
        If (banderaB1 = True) Then
            Dim strTitulo As String = "Acertaste"
            Dim strTexto As String = "La palabra es correcta"
            Dim style As MsgBoxStyle = MsgBoxStyle.Information
            Dim response As Integer = MsgBox(strTexto, style, strTitulo)
            puntuacion = 1
            btR1.Enabled = False
            btR2.Enabled = False
            btR3.Enabled = False
            btR4.Enabled = False

        Else
            Dim strTitulo As String = "Mejor suerte la próxima"
            Dim strTexto As String = "La palabra correcta es " + palabra
            Dim style As MsgBoxStyle = MsgBoxStyle.Information
            Dim response As Integer = MsgBox(strTexto, style, strTitulo)
            btR1.Enabled = False
            btR2.Enabled = False
            btR3.Enabled = False
            btR4.Enabled = False
        End If
    End Sub

    Private Sub btR2_Click(sender As Object, e As EventArgs) Handles btR2.Click
        If (banderaB2 = True) Then
            Dim strTitulo As String = "Acertaste"
            Dim strTexto As String = "La palabra es correcta"
            Dim style As MsgBoxStyle = MsgBoxStyle.Information
            Dim response As Integer = MsgBox(strTexto, style, strTitulo)
            puntuacion = 1
            btR1.Enabled = False
            btR2.Enabled = False
            btR3.Enabled = False
            btR4.Enabled = False
        Else
            Dim strTitulo As String = "Mejor suerte la próxima"
            Dim strTexto As String = "La palabra correcta es " + palabra
            Dim style As MsgBoxStyle = MsgBoxStyle.Information
            Dim response As Integer = MsgBox(strTexto, style, strTitulo)
            btR1.Enabled = False
            btR2.Enabled = False
            btR3.Enabled = False
            btR4.Enabled = False
        End If
    End Sub

    Private Sub btR3_Click(sender As Object, e As EventArgs) Handles btR3.Click
        If (banderaB3 = True) Then
            Dim strTitulo As String = "Acertaste"
            Dim strTexto As String = "La palabra es correcta"
            Dim style As MsgBoxStyle = MsgBoxStyle.Information
            Dim response As Integer = MsgBox(strTexto, style, strTitulo)
            puntuacion = 1
            btR1.Enabled = False
            btR2.Enabled = False
            btR3.Enabled = False
            btR4.Enabled = False
        Else
            Dim strTitulo As String = "Mejor suerte la próxima"
            Dim strTexto As String = "La palabra correcta es " + palabra
            Dim style As MsgBoxStyle = MsgBoxStyle.Information
            Dim response As Integer = MsgBox(strTexto, style, strTitulo)
            btR1.Enabled = False
            btR2.Enabled = False
            btR3.Enabled = False
            btR4.Enabled = False
        End If
    End Sub

    Private Sub btR4_Click(sender As Object, e As EventArgs) Handles btR4.Click
        If (banderaB4 = True) Then
            Dim strTitulo As String = "Acertaste"
            Dim strTexto As String = "La palabra es correcta"
            Dim style As MsgBoxStyle = MsgBoxStyle.Information
            Dim response As Integer = MsgBox(strTexto, style, strTitulo)
            puntuacion = 1
            btR1.Enabled = False
            btR2.Enabled = False
            btR3.Enabled = False
            btR4.Enabled = False
        Else
            Dim strTitulo As String = "Mejor suerte la próxima"
            Dim strTexto As String = "La palabra correcta es " + palabra
            Dim style As MsgBoxStyle = MsgBoxStyle.Information
            Dim response As Integer = MsgBox(strTexto, style, strTitulo)
            btR1.Enabled = False
            btR2.Enabled = False
            btR3.Enabled = False
            btR4.Enabled = False
        End If
    End Sub

    Private Sub btSonido_Click(sender As Object, e As EventArgs) Handles btSonido.Click
        s.Play()
    End Sub
End Class