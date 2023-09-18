Public Class Form2
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Label10.Text = Format(Val(TextBox2.Text) + Val(Label8.Text) - Val(Label9.Text) + Val(TextBox3.Text) - Val(TextBox4.Text), "Rp ###,###,###")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If Val(TextBox2.Text) > 25000000 Then
            Label8.Text = Val(TextBox2.Text) * 0.15
            Label9.Text = Val(TextBox2.Text) * 0.07
        ElseIf Val(TextBox2.Text) > 15000000 Then
            Label8.Text = Val(TextBox2.Text) * 0.1
            Label9.Text = Val(TextBox2.Text) * 0.07
        ElseIf Val(TextBox2.Text) > 8000000 Then
            Label8.Text = Val(TextBox2.Text) * 0.08
            Label9.Text = Val(TextBox2.Text) * 0.05
        Else
            Label8.Text = Val(TextBox2.Text) * 0.05
            Label9.Text = Val(TextBox2.Text) * 0.025
        End If
    End Sub
End Class