Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Integer
        Dim c As String
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a + b
        MsgBox("Hasil Penjumlahan " + c, MsgBoxStyle.Information, "Hasil")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b As Integer
        Dim c As String
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a - b
        MsgBox("Hasil Penjumlahan " + c, MsgBoxStyle.Information, "Hasil")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a, b As Integer
        Dim c As String
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a * b
        MsgBox("Hasil Penjumlahan " + c, MsgBoxStyle.Information, "Hasil")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a, b As Integer
        Dim c As String
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a / b
        MsgBox("Hasil Penjumlahan " + c, MsgBoxStyle.Information, "Hasil")
    End Sub
End Class
