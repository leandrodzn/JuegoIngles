Public Class JuegoPrincipiante

    Dim hijo As New Modelo
    Dim abiertos() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Dim contadorPregunta As Integer = 0
    Dim num As String
    Dim bandera As Boolean

    Private Sub JuegoPrincipiante_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Menu.Show()
    End Sub

    Private Sub JuegoPrincipiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btTerminar.Enabled = False
        hijo.MdiParent = Me
    End Sub

    Private Sub btComenzar_Click(sender As Object, e As EventArgs) Handles btComenzar.Click
        btComenzar.Enabled = False
        btMenu.Enabled = False
        btTerminar.Enabled = True

        abrirPalabra(1)


        Me.SplitContainer1.Panel2.Controls.Add(hijo)
        hijo.Show()
    End Sub

    Private Sub btTerminar_Click(sender As Object, e As EventArgs) Handles btTerminar.Click
        btComenzar.Enabled = True
        btMenu.Enabled = True
        btTerminar.Enabled = False
        hijo.Hide()

    End Sub

    Private Sub btMenu_Click(sender As Object, e As EventArgs) Handles btMenu.Click
        Menu.Show()
        Me.Close()

    End Sub

    Private Function numeroRandom() As Integer
        'ciclo para generar los numeros aleatorios

        bandera = True
        'generar un numero aleatorio con la semilla ramdomize
        ' Initialize the random-number generator.
        Randomize()

        Do
            ' Generate random value between 1 and 20.
            num = CInt(Int((20 * Rnd()) + 1))

            'revisar si el numero generado ya existe con la bandera
            For x = 0 To 9 Step 1

                If abiertos(x) = num Then
                    bandera = True
                    Exit For
                Else
                    bandera = False
                End If

            Next

        Loop While (bandera = True)

        'si el numero no existe busca en que parte del areglo alojarlo 
        If bandera = False Then

            For y = 0 To 9 Step 1

                If abiertos(y) = 0 Then
                    abiertos(y) = num
                    contadorPregunta = contadorPregunta + 1
                    Exit For
                End If

            Next

        End If

        Return num
    End Function

    Private Sub abrirPalabra(numero As Integer)
        Select Case numero
            Case 1
                hijo.numero = "1"
                hijo.valorB1 = "perro"
            Case 2
            Case 3
            Case 4
            Case 5
            Case 6
            Case 7
            Case 8
            Case 9
            Case 10
            Case 11
            Case 12
            Case 13
            Case 14
            Case 15
            Case 16
            Case 17
            Case 18
            Case 19
            Case 20
        End Select


    End Sub

End Class