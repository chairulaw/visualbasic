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
        Me.txtkodgaj = New System.Windows.Forms.TextBox()
        Me.txtnaker = New System.Windows.Forms.TextBox()
        Me.cbjabatan = New System.Windows.Forms.ComboBox()
        Me.lblgapok = New System.Windows.Forms.Label()
        Me.lbltunjab = New System.Windows.Forms.Label()
        Me.lbltunjkes = New System.Windows.Forms.Label()
        Me.txtpotkop = New System.Windows.Forms.TextBox()
        Me.txtpotas = New System.Windows.Forms.TextBox()
        Me.lbltotga = New System.Windows.Forms.Label()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Gaji"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Karyawan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jabatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gaji Pokok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tunj. Jabatan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tunj. Kesehatan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Pot. Koperasi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Pot. Asuransi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 423)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Total Gaji"
        '
        'txtkodgaj
        '
        Me.txtkodgaj.Location = New System.Drawing.Point(189, 28)
        Me.txtkodgaj.Name = "txtkodgaj"
        Me.txtkodgaj.Size = New System.Drawing.Size(245, 26)
        Me.txtkodgaj.TabIndex = 9
        '
        'txtnaker
        '
        Me.txtnaker.Location = New System.Drawing.Point(189, 76)
        Me.txtnaker.Name = "txtnaker"
        Me.txtnaker.Size = New System.Drawing.Size(245, 26)
        Me.txtnaker.TabIndex = 10
        '
        'cbjabatan
        '
        Me.cbjabatan.FormattingEnabled = True
        Me.cbjabatan.Items.AddRange(New Object() {"Manager", "Admin", "Supervisor"})
        Me.cbjabatan.Location = New System.Drawing.Point(189, 124)
        Me.cbjabatan.Name = "cbjabatan"
        Me.cbjabatan.Size = New System.Drawing.Size(245, 28)
        Me.cbjabatan.TabIndex = 11
        '
        'lblgapok
        '
        Me.lblgapok.AutoSize = True
        Me.lblgapok.Location = New System.Drawing.Point(185, 178)
        Me.lblgapok.Name = "lblgapok"
        Me.lblgapok.Size = New System.Drawing.Size(99, 20)
        Me.lblgapok.TabIndex = 12
        Me.lblgapok.Text = "=========="
        '
        'lbltunjab
        '
        Me.lbltunjab.AutoSize = True
        Me.lbltunjab.Location = New System.Drawing.Point(185, 227)
        Me.lbltunjab.Name = "lbltunjab"
        Me.lbltunjab.Size = New System.Drawing.Size(99, 20)
        Me.lbltunjab.TabIndex = 13
        Me.lbltunjab.Text = "=========="
        '
        'lbltunjkes
        '
        Me.lbltunjkes.AutoSize = True
        Me.lbltunjkes.Location = New System.Drawing.Point(185, 276)
        Me.lbltunjkes.Name = "lbltunjkes"
        Me.lbltunjkes.Size = New System.Drawing.Size(99, 20)
        Me.lbltunjkes.TabIndex = 14
        Me.lbltunjkes.Text = "=========="
        '
        'txtpotkop
        '
        Me.txtpotkop.Location = New System.Drawing.Point(189, 321)
        Me.txtpotkop.Name = "txtpotkop"
        Me.txtpotkop.Size = New System.Drawing.Size(245, 26)
        Me.txtpotkop.TabIndex = 15
        '
        'txtpotas
        '
        Me.txtpotas.Location = New System.Drawing.Point(189, 368)
        Me.txtpotas.Name = "txtpotas"
        Me.txtpotas.Size = New System.Drawing.Size(245, 26)
        Me.txtpotas.TabIndex = 16
        '
        'lbltotga
        '
        Me.lbltotga.AutoSize = True
        Me.lbltotga.Location = New System.Drawing.Point(185, 423)
        Me.lbltotga.Name = "lbltotga"
        Me.lbltotga.Size = New System.Drawing.Size(99, 20)
        Me.lbltotga.TabIndex = 17
        Me.lbltotga.Text = "=========="
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Location = New System.Drawing.Point(189, 496)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(75, 34)
        Me.cmdsimpan.TabIndex = 18
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Location = New System.Drawing.Point(299, 496)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(75, 34)
        Me.cmdkeluar.TabIndex = 19
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 589)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.lbltotga)
        Me.Controls.Add(Me.txtpotas)
        Me.Controls.Add(Me.txtpotkop)
        Me.Controls.Add(Me.lbltunjkes)
        Me.Controls.Add(Me.lbltunjab)
        Me.Controls.Add(Me.lblgapok)
        Me.Controls.Add(Me.cbjabatan)
        Me.Controls.Add(Me.txtnaker)
        Me.Controls.Add(Me.txtkodgaj)
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
        Me.Text = "Gaji Karyawan"
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
    Friend WithEvents txtkodgaj As TextBox
    Friend WithEvents txtnaker As TextBox
    Friend WithEvents cbjabatan As ComboBox
    Friend WithEvents lblgapok As Label
    Friend WithEvents lbltunjab As Label
    Friend WithEvents lbltunjkes As Label
    Friend WithEvents txtpotkop As TextBox
    Friend WithEvents txtpotas As TextBox
    Friend WithEvents lbltotga As Label
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdkeluar As Button
End Class
