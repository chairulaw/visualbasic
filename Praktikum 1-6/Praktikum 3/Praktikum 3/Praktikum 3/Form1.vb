Public Class Form1
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Label8.Text = Val(TextBox3.Text) * Val(TextBox4.Text)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Label9.Text = Val(Label8.Text) - Val(TextBox5.Text) / 100 * Val(Label8.Text)
    End Sub
End Class
