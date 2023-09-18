Imports MySql.Data.MySqlClient
Public Class Form1
    Dim strkon As String = "server=localhost;uid=root;database=rental_mobil"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim mda As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim cek As MySqlDataReader
    Dim sewa, total As Double

    Private Sub cbjenismobil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjenismobil.SelectedIndexChanged
        Select Case cbjenismobil.SelectedIndex
            Case 0
                sewa = 250000
            Case 1
                sewa = 250000
            Case 2
                sewa = 300000
            Case 3
                sewa = 700000
            Case 4
                sewa = 1000000
        End Select
        lblsewa.Text = Format(sewa, "Rp ###,###,##")
    End Sub

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into rental values " &
            " ('" & txtnopin.Text & "', '" & Format(dtwaktu.Value, "yyyy-MM-dd") & "'," &
            " '" & txtnapem.Text & "', '" & txtnomobil.Text & "', '" & cbjenismobil.Text & "'," &
            " '" & sewa & "', '" & txtlama.Text & "', '" & total & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("data berhasil di simpan!", MsgBoxStyle.Information, "pesan")
        tampil()
        bersih()
        tidakaktif()
    End Sub

    Private Sub cmdtambah_Click(sender As Object, e As EventArgs) Handles cmdtambah.Click
        aktif()
        txtnopin.Focus()
        cmdtambah.Enabled = False
    End Sub

    Private Sub cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "update rental set tanggalpinjam='" &
            Format(dtwaktu.Value, "yyyy-MM-dd") & "', " &
            " namapeminjam='" & txtnapem.Text & "', nomobil='" & txtnomobil.Text & "', " &
            " jenismobil='" & cbjenismobil.Text & "',sewa='" & sewa & "',lamasewa='" & txtlama.Text & "', " &
            " total='" & total & "' where nopinjam='" & txtnopin.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampil()
        bersih()
        tidakaktif()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tidakaktif()
        bersih()
        tampil()
    End Sub

    Private Sub cmdhapus_Click(sender As Object, e As EventArgs) Handles cmdhapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from rental where nopinjam='" & txtnopin.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampil()
        bersih()
    End Sub

    Private Sub cmdbatal_Click(sender As Object, e As EventArgs) Handles cmdbatal.Click
        tidakaktif()
        cmdtambah.Enabled = True
        bersih()
    End Sub

    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Close()
    End Sub
    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        Dim i As Integer
        i = dg.CurrentRow.Index
        txtnopin.Text = dg.Rows.Item(i).Cells(0).Value
        dtwaktu.Value = dg.Rows.Item(i).Cells(1).Value
        txtnapem.Text = dg.Rows.Item(i).Cells(2).Value
        txtnomobil.Text = dg.Rows.Item(i).Cells(3).Value
        cbjenismobil.Text = dg.Rows.Item(i).Cells(4).Value
        lblsewa.Text = dg.Rows.Item(i).Cells(5).Value
        txtlama.Text = dg.Rows.Item(i).Cells(6).Value
        lbltotal.Text = dg.Rows.Item(i).Cells(7).Value
    End Sub

    Sub tidakaktif()
        txtnopin.Enabled = False
        dtwaktu.Enabled = False
        txtnapem.Enabled = False
        txtnomobil.Enabled = False
        cbjenismobil.Enabled = False
        txtlama.Enabled = False

        txtnopin.BackColor = Color.Gray
        txtnapem.BackColor = Color.Gray
        txtnomobil.BackColor = Color.Gray
        cbjenismobil.BackColor = Color.Gray
        txtlama.BackColor = Color.Gray

        cmdhapus.Enabled = False
        cmdsimpan.Enabled = False
        cmdupdate.Enabled = False
        cmdbatal.Enabled = False
    End Sub

    Sub aktif()
        txtnopin.Enabled = True
        dtwaktu.Enabled = True
        txtnapem.Enabled = True
        txtnomobil.Enabled = True
        cbjenismobil.Enabled = True
        txtlama.Enabled = True

        txtnopin.BackColor = Color.White
        txtnapem.BackColor = Color.White
        txtnomobil.BackColor = Color.White
        cbjenismobil.BackColor = Color.White
        txtlama.BackColor = Color.White

        cmdhapus.Enabled = True
        cmdsimpan.Enabled = True
        cmdupdate.Enabled = True
        cmdbatal.Enabled = True
    End Sub

    Sub bersih()
        txtnopin.Text = ""
        dtwaktu.Text = ""
        txtnapem.Text = ""
        txtnomobil.Text = ""
        cbjenismobil.Text = ""
        txtlama.Text = ""
    End Sub

    Sub tampil()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from rental"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "pinjam")
        dg.DataSource = ds.Tables("pinjam")
        kon.Close()
    End Sub

    Private Sub txtlama_TextChanged(sender As Object, e As EventArgs) Handles txtlama.TextChanged
        total = sewa * Val(txtlama.Text)
        lbltotal.Text = Format(total, "Rp ###,###,##")
    End Sub

    Private Sub txtnopin_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnopin.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "Select * from rental" &
                " where nopinjam='" & txtnopin.Text & "'"
                cek = perintah.ExecuteReader
                cek.Read()
                MsgBox("data sudah ada...!", MsgBoxStyle.Information, "pesan")
                If cek.HasRows Then
                    dtwaktu.Value = cek.Item("tanggalpinjam")
                    txtnapem.Text = cek.Item("namapeminjam")
                    txtnomobil.Text = cek.Item("nomobil")
                    cbjenismobil.Text = cek.Item("jenismobil")
                    lblsewa.Text = cek.Item("sewa")
                    txtlama.Text = cek.Item("lamasewa")
                    lblsewa.Text = cek.Item("total")

                    cmdsimpan.Enabled = False
                End If
                kon.Close()
                ' tidakaktif()
                cmdhapus.Enabled = True
        End Select
    End Sub
End Class
