﻿Public Class JuegoPrincipiante

    Dim hijo As New Modelo
    Dim abiertos(10) As Integer
    Dim contadorPregunta As Integer
    Dim num As String
    Dim bandera As Boolean
    Dim puntaje As Integer

    Private Sub JuegoPrincipiante_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Menu.Show()
    End Sub

    Private Sub JuegoPrincipiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btTerminar.Enabled = False

        hijo.MdiParent = Me
        'indica si es el modo principiante o avanzado para seleccionar las imagenes y palabras
        hijo.esPrincipiante = True

        btSiguiente.Enabled = False
    End Sub

    Private Sub btComenzar_Click(sender As Object, e As EventArgs) Handles btComenzar.Click
        'habilida y deshabilita botones
        btComenzar.Enabled = False
        btMenu.Enabled = False
        btTerminar.Enabled = True
        btSiguiente.Enabled = True

        'reinicia los puntajes
        hijo.puntuacion = 0


        'inicializa a 0s el arreglo de palabras ya mostradas
        abiertos = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        contadorPregunta = 0
        'abre una ventana de una palabra
        abrirPalabra2(numeroRandom())
        hijo.actualizar()
        Me.SplitContainer1.Panel2.Controls.Add(hijo)
        hijo.Show()
        contadorPregunta += 1 'incrementa el contador de las preguntas
        puntaje = 0
        lbAciertos.Text = 0
        lbPregunta.Text = (contadorPregunta & "/10")


    End Sub

    Private Sub btTerminar_Click(sender As Object, e As EventArgs) Handles btTerminar.Click
        'habilida botones
        btComenzar.Enabled = True
        btMenu.Enabled = True
        'deshabilida botones
        btTerminar.Enabled = False
        btSiguiente.Enabled = False
        'limpia el panel
        Me.SplitContainer1.Panel2.Controls.Clear()

        'mensaje de aciertos
        Dim strTitulo As String = "Terminó la partida"
        Dim strTexto As String = "Finalizó con " & lbAciertos.Text & " aciertos"
        Dim style As MsgBoxStyle = MsgBoxStyle.Information
        Dim response As Integer = MsgBox(strTexto, style, strTitulo)


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

        'si el numero no existe busca en que parte del arreglo de palabras ya mostradas guardalo


        For y = 0 To 9 Step 1

            If abiertos(y) = 0 Then
                abiertos(y) = num
                Exit For
            End If

        Next


        Return num
    End Function

    Private Sub abrirPalabra2(numero As Integer)
        Select Case numero
            Case 1
                'manda numero de palabra, palabra correcta, y palabras a mostrar como opción
                hijo.numero = "1"
                hijo.palabra = "Apple"
                hijo.valorB1 = "Apple"
                hijo.valorB2 = "Aple"
                hijo.valorB3 = "Apul"
                hijo.valorB4 = "Appl"
                'indica cual botón tiene la respuesta correcta
                hijo.banderaB1 = True
                hijo.banderaB2 = False
                hijo.banderaB3 = False
                hijo.banderaB4 = False

            Case 2
                hijo.numero = "2"
                hijo.palabra = "House"
                hijo.valorB1 = "Hous"
                hijo.valorB2 = "House"
                hijo.valorB3 = "Jous"
                hijo.valorB4 = "Jouse"
                hijo.banderaB1 = False
                hijo.banderaB2 = True
                hijo.banderaB3 = False
                hijo.banderaB4 = False

            Case 3
                hijo.numero = "3"
                hijo.palabra = "Pencil"
                hijo.valorB1 = "Pencyl"
                hijo.valorB2 = "Pensil"
                hijo.valorB3 = "Pensyl"
                hijo.valorB4 = "Pencil"
                hijo.banderaB1 = False
                hijo.banderaB2 = False
                hijo.banderaB3 = False
                hijo.banderaB4 = True

            Case 4
                hijo.numero = "4"
                hijo.palabra = "Book"
                hijo.valorB1 = "Booq"
                hijo.valorB2 = "Book"
                hijo.valorB3 = "Bok"
                hijo.valorB4 = "Booc"
                hijo.banderaB1 = False
                hijo.banderaB2 = True
                hijo.banderaB3 = False
                hijo.banderaB4 = False

            Case 5
                hijo.numero = "5"
                hijo.palabra = "Dog"
                hijo.valorB1 = "Dok"
                hijo.valorB2 = "Doog"
                hijo.valorB3 = "Dog"
                hijo.valorB4 = "Doq"
                hijo.banderaB1 = False
                hijo.banderaB2 = False
                hijo.banderaB3 = True
                hijo.banderaB4 = False

            Case 6
                hijo.numero = "6"
                hijo.palabra = "Blue"
                hijo.valorB1 = "Blue"
                hijo.valorB2 = "Blu"
                hijo.valorB3 = "Bluh"
                hijo.valorB4 = "Blueh"
                hijo.banderaB1 = True
                hijo.banderaB2 = False
                hijo.banderaB3 = False
                hijo.banderaB4 = False

            Case 7
                hijo.numero = "7"
                hijo.palabra = "Red"
                hijo.valorB1 = "Reed"
                hijo.valorB2 = "Reet"
                hijo.valorB3 = "Ret"
                hijo.valorB4 = "Red"
                hijo.banderaB1 = False
                hijo.banderaB2 = False
                hijo.banderaB3 = False
                hijo.banderaB4 = True

            Case 8
                hijo.numero = "8"
                hijo.palabra = "Cat"
                hijo.valorB1 = "Cath"
                hijo.valorB2 = "Cat"
                hijo.valorB3 = "Kat"
                hijo.valorB4 = "Catt"
                hijo.banderaB1 = False
                hijo.banderaB2 = True
                hijo.banderaB3 = False
                hijo.banderaB4 = False

            Case 9
                hijo.numero = "9"
                hijo.palabra = "Boy"
                hijo.valorB1 = "Boi"
                hijo.valorB2 = "Bhoy"
                hijo.valorB3 = "Boy"
                hijo.valorB4 = "Voy"
                hijo.banderaB1 = False
                hijo.banderaB2 = False
                hijo.banderaB3 = True
                hijo.banderaB4 = False

            Case 10
                hijo.numero = "10"
                hijo.palabra = "Car"
                hijo.valorB1 = "Caar"
                hijo.valorB2 = "Carh"
                hijo.valorB3 = "Kar"
                hijo.valorB4 = "Car"
                hijo.banderaB1 = False
                hijo.banderaB2 = False
                hijo.banderaB3 = False
                hijo.banderaB4 = True

            Case 11
                hijo.numero = "11"
                hijo.palabra = "Paper"
                hijo.valorB1 = "Paper"
                hijo.valorB2 = "Peiper"
                hijo.valorB3 = "Peper"
                hijo.valorB4 = "Paiper"
                hijo.banderaB1 = True
                hijo.banderaB2 = False
                hijo.banderaB3 = False
                hijo.banderaB4 = False

            Case 12
                hijo.numero = "12"
                hijo.palabra = "Cake"
                hijo.valorB1 = "Cake"
                hijo.valorB2 = "Kake"
                hijo.valorB3 = "Cakhe"
                hijo.valorB4 = "Caik"
                hijo.banderaB1 = True
                hijo.banderaB2 = False
                hijo.banderaB3 = False
                hijo.banderaB4 = False

            Case 13
                hijo.numero = "13"
                hijo.palabra = "Rain"
                hijo.palabra = "Rain"
                hijo.palabra = "Rain"
                hijo.valorB1 = "Rhain"
                hijo.valorB2 = "Rain"
                hijo.valorB3 = "Rein"
                hijo.valorB4 = "Rian"
                hijo.banderaB1 = False
                hijo.banderaB2 = True
                hijo.banderaB3 = False
                hijo.banderaB4 = False

            Case 14
                hijo.numero = "14"
                hijo.palabra = "Bird"
                hijo.valorB1 = "Birdh"
                hijo.valorB2 = "Birt"
                hijo.valorB3 = "Birth"
                hijo.valorB4 = "Bird"
                hijo.banderaB1 = False
                hijo.banderaB2 = False
                hijo.banderaB3 = False
                hijo.banderaB4 = True

            Case 15
                hijo.numero = "15"
                hijo.palabra = "Lion"
                hijo.valorB1 = "Lyon"
                hijo.valorB2 = "Lion"
                hijo.valorB3 = "Laion"
                hijo.valorB4 = "Lionh"
                hijo.banderaB1 = False
                hijo.banderaB2 = True
                hijo.banderaB3 = False
                hijo.banderaB4 = False

            Case 16
                hijo.numero = "16"
                hijo.palabra = "Happy"
                hijo.valorB1 = "Happi"
                hijo.valorB2 = "Happy"
                hijo.valorB3 = "Hapy"
                hijo.valorB4 = "Jappy"
                hijo.banderaB1 = False
                hijo.banderaB2 = True
                hijo.banderaB3 = False
                hijo.banderaB4 = False

            Case 17
                hijo.numero = "17"
                hijo.palabra = "Sun"
                hijo.valorB1 = "Son"
                hijo.valorB2 = "Sunh"
                hijo.valorB3 = "Sun"
                hijo.valorB4 = "Suun"
                hijo.banderaB1 = False
                hijo.banderaB2 = False
                hijo.banderaB3 = True
                hijo.banderaB4 = False

            Case 18
                hijo.numero = "18"
                hijo.palabra = "Sad"
                hijo.valorB1 = "Sad"
                hijo.valorB2 = "Zad"
                hijo.valorB3 = "Sat"
                hijo.valorB4 = "Sath"
                hijo.banderaB1 = True
                hijo.banderaB2 = False
                hijo.banderaB3 = False
                hijo.banderaB4 = False

            Case 19
                hijo.numero = "19"
                hijo.palabra = "Open"
                hijo.valorB1 = "Openh"
                hijo.valorB2 = "Opeen"
                hijo.valorB3 = "Open"
                hijo.valorB4 = "Oppen"
                hijo.banderaB1 = False
                hijo.banderaB2 = False
                hijo.banderaB3 = True
                hijo.banderaB4 = False

            Case 20
                hijo.numero = "20"
                hijo.palabra = "Nurse"
                hijo.valorB1 = "Nurceh"
                hijo.valorB2 = "Nursee"
                hijo.valorB3 = "Nurse"
                hijo.valorB4 = "Nurce"
                hijo.banderaB1 = False
                hijo.banderaB2 = False
                hijo.banderaB3 = True
                hijo.banderaB4 = False


        End Select


    End Sub

    Private Sub btSiguiente_Click(sender As Object, e As EventArgs) Handles btSiguiente.Click
        'lee los puntajes de las ventanas
        puntaje += hijo.puntuacion

        'reinicia los puntajes
        hijo.puntuacion = 0

        'limpia el panel
        Me.SplitContainer1.Panel2.Controls.Clear()
        lbAciertos.Text = puntaje
        If contadorPregunta < 10 Then 'si aun no ha terminado de mostrar 10 palabras
            contadorPregunta += 1
            abrirPalabra2(numeroRandom())
            hijo.actualizar()
            Me.SplitContainer1.Panel2.Controls.Add(hijo)
            hijo.Show()
            lbPregunta.Text = (contadorPregunta & "/10")
        Else
            btSiguiente.Enabled = False 'deshabilita el botón siguiente
            Dim strTitulo As String = "Juego finalizado"
            Dim strTexto As String = "Presione 'Terminar partida' para poder comenzar una nueva"
            Dim style As MsgBoxStyle = MsgBoxStyle.Information
            Dim response As Integer = MsgBox(strTexto, style, strTitulo)
        End If
    End Sub


End Class