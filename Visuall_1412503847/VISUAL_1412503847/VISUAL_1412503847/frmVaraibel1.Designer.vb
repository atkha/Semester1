<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVaraibel1
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
        Me.btnHitung = New System.Windows.Forms.Button
        Me.lblTambah = New System.Windows.Forms.Label
        Me.lblKurang = New System.Windows.Forms.Label
        Me.lblKali = New System.Windows.Forms.Label
        Me.lblBagi = New System.Windows.Forms.Label
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(12, 8)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(239, 36)
        Me.btnHitung.TabIndex = 0
        Me.btnHitung.Text = "H I T U N G"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'lblTambah
        '
        Me.lblTambah.AutoSize = True
        Me.lblTambah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTambah.Location = New System.Drawing.Point(12, 84)
        Me.lblTambah.Name = "lblTambah"
        Me.lblTambah.Size = New System.Drawing.Size(54, 15)
        Me.lblTambah.TabIndex = 1
        Me.lblTambah.Text = "TAMBAH"
        '
        'lblKurang
        '
        Me.lblKurang.AutoSize = True
        Me.lblKurang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKurang.Location = New System.Drawing.Point(12, 115)
        Me.lblKurang.Name = "lblKurang"
        Me.lblKurang.Size = New System.Drawing.Size(55, 15)
        Me.lblKurang.TabIndex = 2
        Me.lblKurang.Text = "KURANG"
        '
        'lblKali
        '
        Me.lblKali.AutoSize = True
        Me.lblKali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKali.Location = New System.Drawing.Point(217, 84)
        Me.lblKali.Name = "lblKali"
        Me.lblKali.Size = New System.Drawing.Size(32, 15)
        Me.lblKali.TabIndex = 3
        Me.lblKali.Text = "KALI"
        '
        'lblBagi
        '
        Me.lblBagi.AutoSize = True
        Me.lblBagi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBagi.Location = New System.Drawing.Point(217, 115)
        Me.lblBagi.Name = "lblBagi"
        Me.lblBagi.Size = New System.Drawing.Size(34, 15)
        Me.lblBagi.TabIndex = 4
        Me.lblBagi.Text = "BAGI"
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(12, 163)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(239, 34)
        Me.btnKeluar.TabIndex = 5
        Me.btnKeluar.Text = "K E L U A R"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'frmVaraibel1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 205)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.lblBagi)
        Me.Controls.Add(Me.lblKali)
        Me.Controls.Add(Me.lblKurang)
        Me.Controls.Add(Me.lblTambah)
        Me.Controls.Add(Me.btnHitung)
        Me.Name = "frmVaraibel1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Variabel 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents lblTambah As System.Windows.Forms.Label
    Friend WithEvents lblKurang As System.Windows.Forms.Label
    Friend WithEvents lblKali As System.Windows.Forms.Label
    Friend WithEvents lblBagi As System.Windows.Forms.Label
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
End Class
