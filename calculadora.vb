Public Class calculadora
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Concatenar()
        Pantalla.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Concatenar()
        Pantalla.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Concatenar()
        Pantalla.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Concatenar()
        Pantalla.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Concatenar()
        Pantalla.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Concatenar()
        Pantalla.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Concatenar()
        Pantalla.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Concatenar()
        Pantalla.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Concatenar()
        Pantalla.Text &= "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        Concatenar()
        Pantalla.Text &= "0"
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        Concatenar()
        If InStr(Pantalla.Text, ".", CompareMethod.Text) = 0 Then
            Pantalla.Text &= "."
        End If
    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        HacerOperacion()
        Operacion = "+"
    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        HacerOperacion()
        Operacion = "-"
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        HacerOperacion()
        Operacion = "x"
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        HacerOperacion()
        Operacion = "/"
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        HacerOperacion()
        Operacion = ""
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Borrar()
    End Sub

    Public Sub HacerOperacion()
        SePresionaOperador = True
        Valor2 = Val(Pantalla.Text)
        If ValorResultado <> 0 Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado = ValorResultado - Valor2
                Case "x"
                    ValorResultado = ValorResultado * Valor2
                Case "/"
                    ValorResultado = ValorResultado / Valor2
            End Select
            Pantalla.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

    Public Sub Concatenar()
        If SePresionaOperador = True Then
            Pantalla.Text = ""
            SePresionaOperador = False
        ElseIf Pantalla.Text = "0" Then
            Pantalla.Text = ""
        End If
    End Sub

    Public Sub Borrar()
        ValorResultado = Nothing
        Valor2 = Nothing
        Pantalla.Text = "0"
    End Sub
End Class
