Imports MySql.Data.MySqlClient
Public Class Form1
    Dim strkon As String = "server=localhost;uid=root;database=tambah_karyawan"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim mda As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim cek As MySqlDataReader
    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub

    Private Sub txtid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtid.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "Select * from karyawan" &
                " where idkaryawan='" & txtid.Text & "'"
                cek = perintah.ExecuteReader
                cek.Read()
                MsgBox("data sudah ada...!", MsgBoxStyle.Information, "pesan")
                If cek.HasRows Then
                    dtplahir.Value = cek.Item("tanggallahir")
                    dtpmasuk.Value = cek.Item("tanggalmasuk")
                    txtid.Text = cek.Item("idkaryawan")
                    txtnama.Text = cek.Item("namakaryawan")
                    txttmptlahir.Text = cek.Item("tempatlahir")
                    txtnohp.Text = cek.Item("nohp")
                    txtalamat.Text = cek.Item("alamat")

                    cmdsimpan.Enabled = False
                End If
                kon.Close()
                ' tidakaktif()
                cmdhapus.Enabled = True
        End Select
    End Sub

    Private Sub cmdtambah_Click(sender As Object, e As EventArgs) Handles cmdtambah.Click
        aktif()
        txtid.Focus()
        cmdtambah.Enabled = False
    End Sub

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into karyawan values " &
            " ('" & txtid.Text & "', '" & txtnama.Text & "', " &
            " '" & txttmptlahir.Text & "', '" & Format(dtplahir.Value, "yyyy-MM-dd") & "', " &
            " '" & txtnohp.Text & "', '" & txtalamat.Text & "', '" & Format(dtpmasuk.Value, "yyyy-MM-dd") & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("data berhasil di simpan!", MsgBoxStyle.Information, "pesan")
        tampil()
        bersih()
        tidakaktif()
    End Sub

    Private Sub cmdbatal_Click(sender As Object, e As EventArgs) Handles cmdbatal.Click
        tidakaktif()
        cmdtambah.Enabled = True
        bersih()
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "update karyawan set tanggallahir='" &
            Format(dtplahir.Value, "yyyy-MM-dd") & "', " &
            " tanggalmasuk='" & Format(dtpmasuk.Value, "yyyy-MM-dd") & "', " &
            " namakaryawan='" & txtnama.Text & "', tempatlahir='" & txttmptlahir.Text & "', " &
            " nohp='" & txtnohp.Text & "', alamat='" & txtalamat.Text & "' where idkaryawan='" & txtid.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampil()
        bersih()
        tidakaktif()
    End Sub

    Private Sub cmdhapus_Click(sender As Object, e As EventArgs) Handles cmdhapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from karyawan where idkaryawan='" & txtid.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampil()
        bersih()
    End Sub

    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Close()
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        Dim i As Integer
        i = dg.CurrentRow.Index
        txtid.Text = dg.Rows.Item(i).Cells(0).Value
        txtnama.Text = dg.Rows.Item(i).Cells(1).Value
        txttmptlahir.Text = dg.Rows.Item(i).Cells(2).Value
        dtplahir.Value = dg.Rows.Item(i).Cells(3).Value
        txtnohp.Text = dg.Rows.Item(i).Cells(4).Value
        txtalamat.Text = dg.Rows.Item(i).Cells(5).Value
        dtpmasuk.Value = dg.Rows.Item(i).Cells(6).Value
    End Sub

    Sub tidakaktif()
        txtid.Enabled = False
        txtnama.Enabled = False
        txttmptlahir.Enabled = False
        dtplahir.Enabled = False
        txtnohp.Enabled = False
        txtalamat.Enabled = False
        dtpmasuk.Enabled = False

        txtid.BackColor = Color.Gray
        txtnama.BackColor = Color.Gray
        txttmptlahir.BackColor = Color.Gray
        txtnohp.BackColor = Color.Gray
        txtalamat.BackColor = Color.Gray

        cmdhapus.Enabled = False
        cmdsimpan.Enabled = False
        cmdUpdate.Enabled = False
        cmdbatal.Enabled = False
    End Sub

    Sub aktif()
        txtid.Enabled = True
        txtnama.Enabled = True
        txttmptlahir.Enabled = True
        dtplahir.Enabled = True
        txtnohp.Enabled = True
        txtalamat.Enabled = True
        dtpmasuk.Enabled = True

        txtid.BackColor = Color.White
        txtnama.BackColor = Color.White
        txttmptlahir.BackColor = Color.White
        txtnohp.BackColor = Color.White
        txtalamat.BackColor = Color.White

        cmdhapus.Enabled = True
        cmdsimpan.Enabled = True
        cmdUpdate.Enabled = True
        cmdbatal.Enabled = True
    End Sub

    Sub bersih()
        txtid.Text = ""
        txtnama.Text = ""
        txttmptlahir.Text = ""
        dtplahir.Text = ""
        txtnohp.Text = ""
        txtalamat.Text = ""
        dtpmasuk.Text = ""
    End Sub

    Sub tampil()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from karyawan"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "karyawan")
        dg.DataSource = ds.Tables("karyawan")
        kon.Close()
    End Sub

End Class
