Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Const precioArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagoSinIVA As Double = 0
    Dim pagoConIVA As Double = 0
    Dim descuento As Double = 0
    Dim total As Double = 0
    Dim valorIVA As Double = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        'Aqui va el codigo relacionado a los calculos de los pagos
        pagoSinIVA = (Val(txtArroz.Text) * precioArroz) + (Val(txtFrijol.Text) * precioFrijol) + (Val(txtAzucar.Text) * precioAzucar)
        valorIVA = pagoSinIVA * IVA
        pagoConIVA = pagoSinIVA + valorIVA
        descuento = pagoConIVA * 0.025
        total = pagoConIVA - descuento


        lblR1.Text = pagoSinIVA
        lblR2.Text = valorIVA
        lblR3.Text = pagoConIVA
        lblR4.Text = descuento
        lblR5.Text = total

        MsgBox(total)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        'Aqui va el codigo relacionado a limpiar todas las variables

        txtArroz.Text = "0"
        txtFrijol.Text = "0"
        txtAzucar.Text = "0"

        lblR1.Text = "0"
        lblR2.Text = "0"
        lblR3.Text = "0"
        lblR4.Text = "0"
        lblR5.Text = "0"

        MsgBox("¿Desea limpiar el formulario?")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Salir.Click
        'Aqui va el codigo que pregunta si queremos cerrar la app
        MsgBox("¿Desea cerrar el formulario?")
        Me.Close()
        End

    End Sub

    Private Sub txtArroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArroz.KeyPress
        'codigo que solo permite ingresar numeros

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrijol.KeyPress
        'codigo que solo permite ingresar numeros
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAzucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAzucar.KeyPress
        'codigo que solo permite ingresar numeros
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
