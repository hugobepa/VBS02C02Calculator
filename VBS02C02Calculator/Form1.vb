Public Class Form1

    'Crear variable double'
    Dim primero, segundo, resultado As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'ejecutar booton suma'
    Private Sub BTNSuma_Click(sender As Object, e As EventArgs) Handles BTNSuma.Click

        'Condicionante que esten vacias'
        If TXTPrimero.Text <> "" And TXTSegundo.Text <> "" Then
            'TXTPrimero.Text extraer datos en string y CDbl( convertir en Booleano
            primero = CDbl(TXTPrimero.Text)
            segundo = CDbl(TXTSegundo.Text)

            resultado = primero + segundo
            'printar resultado'
            TXTResultado.Text = "RESULTADO: " & resultado
        Else
            MessageBox.Show("camposvacios")

        End If

        BTNSuma.BackColor = Color.Aqua
        BTNResta.BackColor = Color.FromArgb(224, 224, 224)
        BTNMul.BackColor = Color.FromArgb(224, 224, 224)



    End Sub

    Private Sub BTNResta_Click(sender As Object, e As EventArgs) Handles BTNResta.Click

        'Condicionante que esten vacias'
        If TXTPrimero.Text <> "" And TXTSegundo.Text <> "" Then
            'TXTPrimero.Text extraer datos en string y CDbl( convertir en Booleano
            primero = CDbl(TXTPrimero.Text)
            segundo = CDbl(TXTSegundo.Text)

            resultado = primero - segundo
            'printar resultado'
            TXTResultado.Text = "RESULTADO: " & resultado
        Else
            MessageBox.Show("camposvacios")

        End If

        BTNResta.BackColor = Color.Aqua
        BTNSuma.BackColor = Color.FromArgb(224, 224, 224)
        BTNMul.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub BTNMul_Click(sender As Object, e As EventArgs) Handles BTNMul.Click

        'Condicionante que esten vacias'
        If TXTPrimero.Text <> "" And TXTSegundo.Text <> "" Then
            'TXTPrimero.Text extraer datos en string y CDbl( convertir en Booleano
            primero = CDbl(TXTPrimero.Text)
            segundo = CDbl(TXTSegundo.Text)

            resultado = primero * segundo
            'printar resultado'
            TXTResultado.Text = "RESULTADO: " & resultado
        Else
            MessageBox.Show("camposvacios")

        End If

        BTNMul.BackColor = Color.Aqua
        BTNResta.BackColor = Color.FromArgb(224, 224, 224)
        BTNSuma.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub TXTPrimero_TextChanged(sender As Object, e As EventArgs) Handles TXTPrimero.TextChanged
        'TXTPrimero.Clear()'
    End Sub
End Class
