<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubRutineLat
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDiameter = New System.Windows.Forms.Label
        Me.txtJari2 = New System.Windows.Forms.TextBox
        Me.lblLuas = New System.Windows.Forms.Label
        Me.lblVolume = New System.Windows.Forms.Label
        Me.btnHitung = New System.Windows.Forms.Button
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jari - jari :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "cm"
        '
        'lblDiameter
        '
        Me.lblDiameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiameter.Location = New System.Drawing.Point(12, 31)
        Me.lblDiameter.Name = "lblDiameter"
        Me.lblDiameter.Size = New System.Drawing.Size(166, 23)
        Me.lblDiameter.TabIndex = 2
        Me.lblDiameter.Text = "DIAMETER"
        Me.lblDiameter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtJari2
        '
        Me.txtJari2.Location = New System.Drawing.Point(87, 8)
        Me.txtJari2.Name = "txtJari2"
        Me.txtJari2.Size = New System.Drawing.Size(39, 20)
        Me.txtJari2.TabIndex = 3
        '
        'lblLuas
        '
        Me.lblLuas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLuas.Location = New System.Drawing.Point(12, 65)
        Me.lblLuas.Name = "lblLuas"
        Me.lblLuas.Size = New System.Drawing.Size(166, 23)
        Me.lblLuas.TabIndex = 4
        Me.lblLuas.Text = "LUAS PERMUKAAN"
        Me.lblLuas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVolume
        '
        Me.lblVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVolume.Location = New System.Drawing.Point(12, 100)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(166, 23)
        Me.lblVolume.TabIndex = 5
        Me.lblVolume.Text = "V O L U M E"
        Me.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(12, 138)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(166, 23)
        Me.btnHitung.TabIndex = 6
        Me.btnHitung.Text = "H I T U N G"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(12, 167)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(166, 23)
        Me.btnKeluar.TabIndex = 7
        Me.btnKeluar.Text = "K E L U A R"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'frmSubRutineLat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.lblLuas)
        Me.Controls.Add(Me.txtJari2)
        Me.Controls.Add(Me.lblDiameter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSubRutineLat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BAGUN BOLA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDiameter As System.Windows.Forms.Label
    Friend WithEvents txtJari2 As System.Windows.Forms.TextBox
    Friend WithEvents lblLuas As System.Windows.Forms.Label
    Friend WithEvents lblVolume As System.Windows.Forms.Label
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
End Class
