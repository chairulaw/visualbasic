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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnopin = New System.Windows.Forms.TextBox()
        Me.dtwaktu = New System.Windows.Forms.DateTimePicker()
        Me.txtnapem = New System.Windows.Forms.TextBox()
        Me.txtnomobil = New System.Windows.Forms.TextBox()
        Me.cbjenismobil = New System.Windows.Forms.ComboBox()
        Me.lblsewa = New System.Windows.Forms.Label()
        Me.txtlama = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.cmdtambah = New System.Windows.Forms.Button()
        Me.cmdbatal = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdupdate = New System.Windows.Forms.Button()
        Me.cmdhapus = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(270, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rental Mobil Kencana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Pinjam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal Pinjam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Peminjam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No Mobil"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jenis Mobil"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sewa/Hari"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 357)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Lama Sewa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 413)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Total"
        '
        'txtnopin
        '
        Me.txtnopin.Location = New System.Drawing.Point(223, 70)
        Me.txtnopin.Name = "txtnopin"
        Me.txtnopin.Size = New System.Drawing.Size(245, 26)
        Me.txtnopin.TabIndex = 9
        '
        'dtwaktu
        '
        Me.dtwaktu.Location = New System.Drawing.Point(223, 109)
        Me.dtwaktu.Name = "dtwaktu"
        Me.dtwaktu.Size = New System.Drawing.Size(245, 26)
        Me.dtwaktu.TabIndex = 10
        '
        'txtnapem
        '
        Me.txtnapem.Location = New System.Drawing.Point(223, 162)
        Me.txtnapem.Name = "txtnapem"
        Me.txtnapem.Size = New System.Drawing.Size(245, 26)
        Me.txtnapem.TabIndex = 11
        '
        'txtnomobil
        '
        Me.txtnomobil.Location = New System.Drawing.Point(223, 211)
        Me.txtnomobil.Name = "txtnomobil"
        Me.txtnomobil.Size = New System.Drawing.Size(245, 26)
        Me.txtnomobil.TabIndex = 12
        '
        'cbjenismobil
        '
        Me.cbjenismobil.FormattingEnabled = True
        Me.cbjenismobil.Items.AddRange(New Object() {"Avanza", "Xenia", "Innova", "CRV", "Fortuner"})
        Me.cbjenismobil.Location = New System.Drawing.Point(223, 257)
        Me.cbjenismobil.Name = "cbjenismobil"
        Me.cbjenismobil.Size = New System.Drawing.Size(245, 28)
        Me.cbjenismobil.TabIndex = 13
        '
        'lblsewa
        '
        Me.lblsewa.AutoSize = True
        Me.lblsewa.Location = New System.Drawing.Point(219, 305)
        Me.lblsewa.Name = "lblsewa"
        Me.lblsewa.Size = New System.Drawing.Size(99, 20)
        Me.lblsewa.TabIndex = 14
        Me.lblsewa.Text = "=========="
        '
        'txtlama
        '
        Me.txtlama.Location = New System.Drawing.Point(223, 357)
        Me.txtlama.Name = "txtlama"
        Me.txtlama.Size = New System.Drawing.Size(245, 26)
        Me.txtlama.TabIndex = 15
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(219, 413)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(99, 20)
        Me.lbltotal.TabIndex = 16
        Me.lbltotal.Text = "=========="
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(12, 530)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 62
        Me.dg.RowTemplate.Height = 28
        Me.dg.Size = New System.Drawing.Size(705, 168)
        Me.dg.TabIndex = 17
        '
        'cmdtambah
        '
        Me.cmdtambah.Location = New System.Drawing.Point(63, 494)
        Me.cmdtambah.Name = "cmdtambah"
        Me.cmdtambah.Size = New System.Drawing.Size(75, 30)
        Me.cmdtambah.TabIndex = 18
        Me.cmdtambah.Text = "Tambah"
        Me.cmdtambah.UseVisualStyleBackColor = True
        '
        'cmdbatal
        '
        Me.cmdbatal.Location = New System.Drawing.Point(160, 494)
        Me.cmdbatal.Name = "cmdbatal"
        Me.cmdbatal.Size = New System.Drawing.Size(75, 30)
        Me.cmdbatal.TabIndex = 19
        Me.cmdbatal.Text = "Batal"
        Me.cmdbatal.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Location = New System.Drawing.Point(260, 494)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(75, 30)
        Me.cmdsimpan.TabIndex = 20
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdupdate
        '
        Me.cmdupdate.Location = New System.Drawing.Point(359, 494)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(75, 30)
        Me.cmdupdate.TabIndex = 21
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmdhapus
        '
        Me.cmdhapus.Location = New System.Drawing.Point(461, 494)
        Me.cmdhapus.Name = "cmdhapus"
        Me.cmdhapus.Size = New System.Drawing.Size(75, 30)
        Me.cmdhapus.TabIndex = 22
        Me.cmdhapus.Text = "Hapus"
        Me.cmdhapus.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Location = New System.Drawing.Point(563, 494)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(75, 30)
        Me.cmdkeluar.TabIndex = 23
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 710)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdhapus)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdbatal)
        Me.Controls.Add(Me.cmdtambah)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.txtlama)
        Me.Controls.Add(Me.lblsewa)
        Me.Controls.Add(Me.cbjenismobil)
        Me.Controls.Add(Me.txtnomobil)
        Me.Controls.Add(Me.txtnapem)
        Me.Controls.Add(Me.dtwaktu)
        Me.Controls.Add(Me.txtnopin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Transaksi Rental Mobil"
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
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtnopin As TextBox
    Friend WithEvents dtwaktu As DateTimePicker
    Friend WithEvents txtnapem As TextBox
    Friend WithEvents txtnomobil As TextBox
    Friend WithEvents cbjenismobil As ComboBox
    Friend WithEvents lblsewa As Label
    Friend WithEvents txtlama As TextBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents dg As DataGridView
    Friend WithEvents cmdtambah As Button
    Friend WithEvents cmdbatal As Button
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdupdate As Button
    Friend WithEvents cmdhapus As Button
    Friend WithEvents cmdkeluar As Button
End Class
