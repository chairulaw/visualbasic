Imports MySql.Data.MySqlClient
Public Class Form2
    Dim strkon As String = "server=localhost;uid=root;database=penjualan_barang"

    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim harga, diskon, totalbayar As Double

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into transaksi values('" & txtnofak.Text & "' " &
        ", '" & txtnapel.Text & "', '" & txtnabar.Text & "', '" & txtharga.Text & "' " &
        ", '" & txtqty.Text & "', '" & lbljmlharga.Text & "', '" & txtdiskon.Text & "', '" & lbltotbay.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub

    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Close()
    End Sub

    Private Sub txtdiskon_TextChanged(sender As Object, e As EventArgs) Handles txtdiskon.TextChanged
        diskon = harga * Val(txtdiskon.Text) / 100
        totalbayar = harga - diskon
        lbltotbay.Text = Format(totalbayar, "Rp ###,###,##")
    End Sub

    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged
        harga = Val(txtharga.Text) * Val(txtqty.Text)
        lbljmlharga.Text = Format(harga, "Rp ###,###,##")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class