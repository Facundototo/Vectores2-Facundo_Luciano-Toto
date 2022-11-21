Imports System.Net.Sockets

Public Class Form1
    Dim med() As Integer = {10, 110, 1, 2, 7, 24, 88, 99, 12, 51}
    Dim precio() As Integer = {66, 255, 40, 99, 1999, 23, 72, 31, 84, 23}
    Dim cont As Integer = 0
    Dim contmed(10) As Integer
    Dim acummed(10) As Integer

    Structure Estructura
        Dim Medi As Integer
        Dim Farmacia As String
        Dim Cant As Integer
    End Structure
    Dim Paquete(25) As Estructura
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Dim sino As Boolean = False
        For i As Integer = 0 To 9
            If NumericUpDown1.Value = Medicamentos(i) Then
                sino = True
            End If
        Next

        If sino = False Then
            Label4.Visible = True
            Button1.Enabled = False
        Else
            Label4.Visible = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReDim Preserve Paquete(cont + 1)
        cont += 1
        Paquete(cont).Medi = NumericUpDown1.Value
        Paquete(cont).Farmacia = TextBox1.Text
        Paquete(cont).Cant = NumericUpDown2.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = False
        Button2.Enabled = False
        For i As Integer = 0 To cont
            Select Case Paquete(i).Medi
                Case 10
                    contmed(0) += 1
                    acummed(0) += Paquete(i).Cant
                Case 110
                    contmed(1) += 1
                    acummed(1) += Paquete(i).Cant
                Case 1
                    contmed(2) += 1
                    acummed(2) += Paquete(i).Cant
                Case 2
                    contmed(3) += 1
                    acummed(3) += Paquete(i).Cant
                Case 7
                    contmed(4) += 1
                    acummed(4) += Paquete(i).Cant
                Case 24
                    contmed(5) += 1
                    acummed(5) += Paquete(i).Cant
                Case 88
                    contmed(6) += 1
                    acummed(6) += Paquete(i).Cant
                Case 99
                    contmed(7) += 1
                    acummed(7) += Paquete(i).Cant
                Case 12
                    contmed(8) += 1
                    acummed(8) += Paquete(i).Cant
                Case 51
                    contmed(9) += 1
                    acummed(9) += Paquete(i).Cant
            End Select

        Next
        ListView1.Items.Add("Medicamentos totales: ")
        For i As Integer = 0 To 9
            Dim preciototal As Integer = acummed(i) * precio(i)
            ListView1.Items.Add("Cantidad del medicamento " & med(i) & " " & acummed(i) & " Precio: " & preciototal)
        Next
        ListView1.Items.Add("Medicamentos individuales: ")

        For i As Integer = 0 To cont
            ListView1.Items.Add(Paquete(i).Farmacia + ": " & Paquete(i).Cant)
        Next

    End Sub

End Class
