Imports MySql.Data.MySqlClient
Public Class Form1
    Dim strkon As String = "server=localhost;uid=root;database=gaji_karyawan"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim gajipokok, tunjjabatan, tunjkesehatan, potkoperasi, potasuransi, totalgaji As Double

    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Close()
    End Sub

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into gaji values('" & txtkodgaj.Text & "','" & txtnaker.Text & "', '" & cbjabatan.Text & "', " &
        "'" & gajipokok & "', '" & tunjjabatan & "', '" & tunjkesehatan & "', '" & txtpotkop.Text & "', '" & txtpotas.Text & "', '" & totalgaji & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub

    Private Sub txtpotas_TextChanged(sender As Object, e As EventArgs) Handles txtpotas.TextChanged
        totalgaji = gajipokok + tunjjabatan + tunjkesehatan - Val(txtpotkop.Text) - Val(txtpotas.Text)
        lbltotga.Text = Format(totalgaji, "Rp ###,###,##")
    End Sub

    Private Sub cbjabatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjabatan.SelectedIndexChanged
        Select Case cbjabatan.SelectedIndex
            Case 0
                gajipokok = 4000000
                tunjjabatan = 20 / 100 * gajipokok
                tunjkesehatan = 15 / 100 * gajipokok
            Case 1
                gajipokok = 3000000
                tunjjabatan = 15 / 100 * gajipokok
                tunjkesehatan = 10 / 100 * gajipokok

            Case 2
                gajipokok = 2500000
                tunjjabatan = 15 / 100 * gajipokok
                tunjkesehatan = 10 / 100 * gajipokok
        End Select
        lblgapok.Text = Format(gajipokok, "Rp ###,###,##")
        lbltunjab.Text = Format(tunjjabatan, "Rp ###,###,##")
        lbltunjkes.Text = Format(tunjkesehatan, "Rp ###,###,##")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
