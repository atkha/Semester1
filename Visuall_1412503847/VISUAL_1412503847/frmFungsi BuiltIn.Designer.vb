<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFungsi_BuiltIn
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
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblAnimasi3 = New System.Windows.Forms.Label
        Me.lblAnimasi2 = New System.Windows.Forms.Label
        Me.txtText = New System.Windows.Forms.TextBox
        Me.lblAnimasi1 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblUang = New System.Windows.Forms.Label
        Me.lblJam = New System.Windows.Forms.Label
        Me.lblTanggal2 = New System.Windows.Forms.Label
        Me.lblTanggal1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAnimasi3)
        Me.GroupBox1.Controls.Add(Me.lblAnimasi2)
        Me.GroupBox1.Controls.Add(Me.txtText)
        Me.GroupBox1.Controls.Add(Me.lblAnimasi1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fungsi String"
        '
        'lblAnimasi3
        '
        Me.lblAnimasi3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnimasi3.Location = New System.Drawing.Point(22, 116)
        Me.lblAnimasi3.Name = "lblAnimasi3"
        Me.lblAnimasi3.Size = New System.Drawing.Size(242, 23)
        Me.lblAnimasi3.TabIndex = 4
        Me.lblAnimasi3.Text = "ANIMASi 3"
        Me.lblAnimasi3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAnimasi2
        '
        Me.lblAnimasi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnimasi2.Location = New System.Drawing.Point(22, 78)
        Me.lblAnimasi2.Name = "lblAnimasi2"
        Me.lblAnimasi2.Size = New System.Drawing.Size(242, 23)
        Me.lblAnimasi2.TabIndex = 3
        Me.lblAnimasi2.Text = "ANIMASI 2"
        Me.lblAnimasi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(62, 22)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(100, 20)
        Me.txtText.TabIndex = 2
        '
        'lblAnimasi1
        '
        Me.lblAnimasi1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnimasi1.Location = New System.Drawing.Point(22, 45)
        Me.lblAnimasi1.Name = "lblAnimasi1"
        Me.lblAnimasi1.Size = New System.Drawing.Size(242, 23)
        Me.lblAnimasi1.TabIndex = 1
        Me.lblAnimasi1.Text = "ANIMASI 1"
        Me.lblAnimasi1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Text :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblUang)
        Me.GroupBox2.Controls.Add(Me.lblJam)
        Me.GroupBox2.Controls.Add(Me.lblTanggal2)
        Me.GroupBox2.Controls.Add(Me.lblTanggal1)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 173)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Format"
        '
        'lblUang
        '
        Me.lblUang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUang.Location = New System.Drawing.Point(22, 129)
        Me.lblUang.Name = "lblUang"
        Me.lblUang.Size = New System.Drawing.Size(242, 23)
        Me.lblUang.TabIndex = 3
        Me.lblUang.Text = "Mata Uang"
        Me.lblUang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJam
        '
        Me.lblJam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJam.Location = New System.Drawing.Point(22, 99)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(242, 23)
        Me.lblJam.TabIndex = 2
        Me.lblJam.Text = "Jam 1"
        Me.lblJam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTanggal2
        '
        Me.lblTanggal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTanggal2.Location = New System.Drawing.Point(22, 64)
        Me.lblTanggal2.Name = "lblTanggal2"
        Me.lblTanggal2.Size = New System.Drawing.Size(242, 23)
        Me.lblTanggal2.TabIndex = 1
        Me.lblTanggal2.Text = "Tanggal 2"
        Me.lblTanggal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTanggal1
        '
        Me.lblTanggal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTanggal1.Location = New System.Drawing.Point(22, 26)
        Me.lblTanggal1.Name = "lblTanggal1"
        Me.lblTanggal1.Size = New System.Drawing.Size(242, 23)
        Me.lblTanggal1.TabIndex = 0
        Me.lblTanggal1.Text = "Tanggal 1"
        Me.lblTanggal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'frmFungsi_BuiltIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 340)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFungsi_BuiltIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FUNGSI BUILT IN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents lblAnimasi1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAnimasi3 As System.Windows.Forms.Label
    Friend WithEvents lblAnimasi2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUang As System.Windows.Forms.Label
    Friend WithEvents lblJam As System.Windows.Forms.Label
    Friend WithEvents lblTanggal2 As System.Windows.Forms.Label
    Friend WithEvents lblTanggal1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
End Class
