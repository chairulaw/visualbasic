<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txttmptlahir = New System.Windows.Forms.TextBox()
        Me.dtplahir = New System.Windows.Forms.DateTimePicker()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.dtpmasuk = New System.Windows.Forms.DateTimePicker()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.cmdtambah = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdbatal = New System.Windows.Forms.Button()
        Me.cmdupdate = New System.Windows.Forms.Button()
        Me.cmdhapus = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Karyawan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No HP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 441)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tanggal Masuk"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(202, 38)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(287, 26)
        Me.txtid.TabIndex = 7
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(202, 91)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(287, 26)
        Me.txtnama.TabIndex = 8
        '
        'txttmptlahir
        '
        Me.txttmptlahir.Location = New System.Drawing.Point(202, 150)
        Me.txttmptlahir.Name = "txttmptlahir"
        Me.txttmptlahir.Size = New System.Drawing.Size(287, 26)
        Me.txttmptlahir.TabIndex = 9
        '
        'dtplahir
        '
        Me.dtplahir.Location = New System.Drawing.Point(202, 216)
        Me.dtplahir.Name = "dtplahir"
        Me.dtplahir.Size = New System.Drawing.Size(241, 26)
        Me.dtplahir.TabIndex = 10
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(202, 273)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(287, 26)
        Me.txtnohp.TabIndex = 11
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(202, 322)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(431, 99)
        Me.txtalamat.TabIndex = 12
        '
        'dtpmasuk
        '
        Me.dtpmasuk.Location = New System.Drawing.Point(202, 441)
        Me.dtpmasuk.Name = "dtpmasuk"
        Me.dtpmasuk.Size = New System.Drawing.Size(241, 26)
        Me.dtpmasuk.TabIndex = 13
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(12, 542)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 62
        Me.dg.RowTemplate.Height = 28
        Me.dg.Size = New System.Drawing.Size(781, 199)
        Me.dg.TabIndex = 14
        '
        'cmdtambah
        '
        Me.cmdtambah.Location = New System.Drawing.Point(100, 507)
        Me.cmdtambah.Name = "cmdtambah"
        Me.cmdtambah.Size = New System.Drawing.Size(75, 29)
        Me.cmdtambah.TabIndex = 15
        Me.cmdtambah.Text = "Tambah"
        Me.cmdtambah.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Location = New System.Drawing.Point(200, 507)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(75, 29)
        Me.cmdsimpan.TabIndex = 16
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdbatal
        '
        Me.cmdbatal.Location = New System.Drawing.Point(300, 507)
        Me.cmdbatal.Name = "cmdbatal"
        Me.cmdbatal.Size = New System.Drawing.Size(75, 29)
        Me.cmdbatal.TabIndex = 17
        Me.cmdbatal.Text = "Batal"
        Me.cmdbatal.UseVisualStyleBackColor = True
        '
        'cmdupdate
        '
        Me.cmdupdate.Location = New System.Drawing.Point(402, 507)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(75, 29)
        Me.cmdupdate.TabIndex = 18
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmdhapus
        '
        Me.cmdhapus.Location = New System.Drawing.Point(507, 507)
        Me.cmdhapus.Name = "cmdhapus"
        Me.cmdhapus.Size = New System.Drawing.Size(75, 29)
        Me.cmdhapus.TabIndex = 19
        Me.cmdhapus.Text = "Hapus"
        Me.cmdhapus.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Location = New System.Drawing.Point(618, 507)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(75, 29)
        Me.cmdkeluar.TabIndex = 20
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 753)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdhapus)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmdbatal)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdtambah)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.dtpmasuk)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.dtplahir)
        Me.Controls.Add(Me.txttmptlahir)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Tambah Karyawan"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txttmptlahir As TextBox
    Friend WithEvents dtplahir As DateTimePicker
    Friend WithEvents txtnohp As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents dtpmasuk As DateTimePicker
    Friend WithEvents dg As DataGridView
    Friend WithEvents cmdtambah As Button
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdbatal As Button
    Friend WithEvents cmdupdate As Button
    Friend WithEvents cmdhapus As Button
    Friend WithEvents cmdkeluar As Button
End Class
