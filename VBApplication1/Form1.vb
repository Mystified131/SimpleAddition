Public Class Form1
    Dim add1 As Double
    Dim add2 As Double
    Dim sum As Double
    Dim summa As String

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        add1 = Double.Parse(txtAdd1.Text)
        add2 = Double.Parse(txtAdd2.Text)
        sum = add1 + add2

        summa = sum.ToString
        txtSum.Text = summa

    End Sub
End Class
