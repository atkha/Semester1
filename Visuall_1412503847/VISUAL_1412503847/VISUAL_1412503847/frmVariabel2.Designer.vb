<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVariabel2
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
        Me.lblPanjang = New System.Windows.Forms.Label
        Me.lblLebar = New System.Windows.Forms.Label
        Me.txtPanjang = New System.Windows.Forms.TextBox
        Me.txtLebar = New System.Windows.Forms.TextBox
        Me.btnHitung = New System.Windows.Forms.Button
        Me.lblHasil = New System.Windows.Forms.Label
        Me.txtHasil = New System.Windows.Forms.TextBox
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblPanjang
        '
        Me.lblPanjang.AutoSize = True
        Me.lblPanjang.Location = New System.Drawing.Point(12, 12)
        Me.lblPanjang.Name = "lblPanjang"
        Me.lblPanjang.Size = New System.Drawing.Size(46, 13)
        Me.lblPanjang.TabIndex = 0
        Me.lblPanjang.Text = "Panjang"
        '
        'lblLebar
        '
        Me.lblLebar.AutoSize = True
        Me.lblLebar.Location = New System.Drawing.Point(12, 51)
        Me.lblLebar.Name = "lblLebar"
        Me.lblLebar.Size = New System.Drawing.Size(34, 13)
        Me.lblLebar.TabIndex = 1
        Me.lblLebar.Text = "Lebar"
        '
        'txtPanjang
        '
        Me.txtPanjang.Location = New System.Drawing.Point(97, 9)
        Me.txtPanjang.Name = "txtPanjang"
        Me.txtPanjang.Size = New System.Drawing.Size(100, 20)
        Me.txtPanjang.TabIndex = 2
        '
        'txtLebar
        '
        Me.txtLebar.Location = New System.Drawing.Point(97, 48)
        Me.txtLebar.Name = "txtLebar"
        Me.txtLebar.Size = New System.Drawing.Size(100, 20)
        Me.txtLebar.TabIndex = 3
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(15, 90)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(182, 30)
        Me.btnHitung.TabIndex = 4
        Me.btnHitung.Text = "H I T U N G"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'lblHasil
        '
        Me.lblHasil.AutoSize = True
        Me.lblHasil.Location = New System.Drawing.Point(12, 145)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(38, 13)
        Me.lblHasil.TabIndex = 5
        Me.lblHasil.Text = "HASIL"
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(97, 145)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(100, 20)
        Me.txtHasil.TabIndex = 6
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(15, 182)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(182, 36)
        Me.btnKeluar.TabIndex = 7
        Me.btnKeluar.Text = "K E L U A R"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'frmVariabel2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 230)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.lblHasil)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtLebar)
        Me.Controls.Add(Me.txtPanjang)
        Me.Controls.Add(Me.lblLebar)
        Me.Controls.Add(Me.lblPanjang)
        Me.Name = "frmVariabel2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Variabel 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPanjang As System.Windows.Forms.Label
    Friend WithEvents lblLebar As System.Windows.Forms.Label
    Friend WithEvents txtPanjang As System.Windows.Forms.TextBox
    Friend WithEvents txtLebar As System.Windows.Forms.TextBox
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents lblHasil As System.Windows.Forms.Label
    Friend WithEvents txtHasil As System.Windows.Forms.TextBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
End Class
