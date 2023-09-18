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
        Me.txtnopin = New System.Windows.Forms.TextBox()
        Me.txtnapem = New System.Windows.Forms.TextBox()
        Me.txtjmlpin = New System.Windows.Forms.TextBox()
        Me.txtbunga = New System.Windows.Forms.TextBox()
        Me.txtlapin = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.lblangsuran = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Peminjam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Peminjam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah Pinjam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bunga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Lama Pinjam"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Angsuran"
        '
        'txtnopin
        '
        Me.txtnopin.Location = New System.Drawing.Point(212, 40)
        Me.txtnopin.Name = "txtnopin"
        Me.txtnopin.Size = New System.Drawing.Size(263, 26)
        Me.txtnopin.TabIndex = 6
        '
        'txtnapem
        '
        Me.txtnapem.Location = New System.Drawing.Point(212, 96)
        Me.txtnapem.Name = "txtnapem"
        Me.txtnapem.Size = New System.Drawing.Size(263, 26)
        Me.txtnapem.TabIndex = 7
        '
        'txtjmlpin
        '
        Me.txtjmlpin.Location = New System.Drawing.Point(212, 155)
        Me.txtjmlpin.Name = "txtjmlpin"
        Me.txtjmlpin.Size = New System.Drawing.Size(263, 26)
        Me.txtjmlpin.TabIndex = 8
        '
        'txtbunga
        '
        Me.txtbunga.Location = New System.Drawing.Point(212, 213)
        Me.txtbunga.Name = "txtbunga"
        Me.txtbunga.Size = New System.Drawing.Size(145, 26)
        Me.txtbunga.TabIndex = 9
        '
        'txtlapin
        '
        Me.txtlapin.Location = New System.Drawing.Point(212, 279)
        Me.txtlapin.Name = "txtlapin"
        Me.txtlapin.Size = New System.Drawing.Size(145, 26)
        Me.txtlapin.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(61, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(473, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(12, 459)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 62
        Me.dg.RowTemplate.Height = 28
        Me.dg.Size = New System.Drawing.Size(688, 198)
        Me.dg.TabIndex = 14
        '
        'lblangsuran
        '
        Me.lblangsuran.AutoSize = True
        Me.lblangsuran.Location = New System.Drawing.Point(212, 344)
        Me.lblangsuran.Name = "lblangsuran"
        Me.lblangsuran.Size = New System.Drawing.Size(99, 20)
        Me.lblangsuran.TabIndex = 15
        Me.lblangsuran.Text = "=========="
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(212, 417)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 36)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 669)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblangsuran)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtlapin)
        Me.Controls.Add(Me.txtbunga)
        Me.Controls.Add(Me.txtjmlpin)
        Me.Controls.Add(Me.txtnapem)
        Me.Controls.Add(Me.txtnopin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
    Friend WithEvents txtnopin As TextBox
    Friend WithEvents txtnapem As TextBox
    Friend WithEvents txtjmlpin As TextBox
    Friend WithEvents txtbunga As TextBox
    Friend WithEvents txtlapin As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents lblangsuran As Label
    Friend WithEvents Button3 As Button
End Class
