Imports MySql.Data.MySqlClient
Public Class Form1
    Dim strkon As String = "server=localhost;uid=root;database=transaksi_peminjaman"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim jumlahpinjam, bunga, angsuran As Double
    Dim mda As New MySqlDataAdapter
    Dim ds As New DataSet

    Sub tampil()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from peminjaman"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "peminjaman")
        dg.DataSource = ds.Tables("peminjaman")
        kon.Close()
    End Sub
    Private Sub txtlapin_TextChanged(sender As Object, e As EventArgs) Handles txtlapin.TextChanged
        bunga = Val(txtbunga.Text) / 100 * Val(txtjmlpin.Text)
        angsuran = (bunga + Val(txtjmlpin.Text)) / Val(txtlapin.Text)
        lblangsuran.Text = Format(angsuran, "RP ###,###,##")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into peminjaman values('" & txtnopin.Text & "', " &
        " '" & txtnapem.Text & "', '" & txtjmlpin.Text & "', '" & txtbunga.Text & "', " &
        " '" & txtlapin.Text & "', '" & lblangsuran.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub
End Class
