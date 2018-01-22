<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubRutine
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
        Me.lblHasil = New System.Windows.Forms.Label
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.btnBagi = New System.Windows.Forms.Button
        Me.btnKALI = New System.Windows.Forms.Button
        Me.btnKurang = New System.Windows.Forms.Button
        Me.btnTAMBAH = New System.Windows.Forms.Button
        Me.txtBil2 = New System.Windows.Forms.TextBox
        Me.txtBil1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblHasil
        '
        Me.lblHasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHasil.Location = New System.Drawing.Point(172, 9)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(100, 102)
        Me.lblHasil.TabIndex = 19
        Me.lblHasil.Text = "HASIL"
        Me.lblHasil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(15, 117)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(257, 23)
        Me.btnKeluar.TabIndex = 18
        Me.btnKeluar.Text = "K E L U A R"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnBagi
        '
        Me.btnBagi.Location = New System.Drawing.Point(117, 86)
        Me.btnBagi.Name = "btnBagi"
        Me.btnBagi.Size = New System.Drawing.Size(25, 25)
        Me.btnBagi.TabIndex = 17
        Me.btnBagi.Text = "/"
        Me.btnBagi.UseVisualStyleBackColor = True
        '
        'btnKALI
        '
        Me.btnKALI.Location = New System.Drawing.Point(83, 86)
        Me.btnKALI.Name = "btnKALI"
        Me.btnKALI.Size = New System.Drawing.Size(28, 25)
        Me.btnKALI.TabIndex = 16
        Me.btnKALI.Text = "x"
        Me.btnKALI.UseVisualStyleBackColor = True
        '
        'btnKurang
        '
        Me.btnKurang.Location = New System.Drawing.Point(49, 86)
        Me.btnKurang.Name = "btnKurang"
        Me.btnKurang.Size = New System.Drawing.Size(28, 25)
        Me.btnKurang.TabIndex = 15
        Me.btnKurang.Text = "-"
        Me.btnKurang.UseVisualStyleBackColor = True
        '
        'btnTAMBAH
        '
        Me.btnTAMBAH.Location = New System.Drawing.Point(15, 86)
        Me.btnTAMBAH.Name = "btnTAMBAH"
        Me.btnTAMBAH.Size = New System.Drawing.Size(28, 25)
        Me.btnTAMBAH.TabIndex = 14
        Me.btnTAMBAH.Text = "+"
        Me.btnTAMBAH.UseVisualStyleBackColor = True
        '
        'txtBil2
        '
        Me.txtBil2.Location = New System.Drawing.Point(75, 35)
        Me.txtBil2.Name = "txtBil2"
        Me.txtBil2.Size = New System.Drawing.Size(91, 20)
        Me.txtBil2.TabIndex = 13
        '
        'txtBil1
        '
        Me.txtBil1.Location = New System.Drawing.Point(75, 9)
        Me.txtBil1.Name = "txtBil1"
        Me.txtBil1.Size = New System.Drawing.Size(91, 20)
        Me.txtBil1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Bilangan 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Bilangan 1"
        '
        'frmSubRutine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 173)
        Me.Controls.Add(Me.lblHasil)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBagi)
        Me.Controls.Add(Me.btnKALI)
        Me.Controls.Add(Me.btnKurang)
        Me.Controls.Add(Me.btnTAMBAH)
        Me.Controls.Add(Me.txtBil2)
        Me.Controls.Add(Me.txtBil1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSubRutine"
        Me.Text = "SUBRUTINE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHasil As System.Windows.Forms.Label
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnBagi As System.Windows.Forms.Button
    Friend WithEvents btnKALI As System.Windows.Forms.Button
    Friend WithEvents btnKurang As System.Windows.Forms.Button
    Friend WithEvents btnTAMBAH As System.Windows.Forms.Button
    Friend WithEvents txtBil2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBil1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
