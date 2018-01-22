<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessageBox
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
        Me.btnMsgBox1 = New System.Windows.Forms.Button
        Me.btnMsgBox2 = New System.Windows.Forms.Button
        Me.btnMsgBox3 = New System.Windows.Forms.Button
        Me.lblHasil1 = New System.Windows.Forms.Label
        Me.lblHasil2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnMsgBox1
        '
        Me.btnMsgBox1.Location = New System.Drawing.Point(12, 30)
        Me.btnMsgBox1.Name = "btnMsgBox1"
        Me.btnMsgBox1.Size = New System.Drawing.Size(210, 23)
        Me.btnMsgBox1.TabIndex = 0
        Me.btnMsgBox1.Text = "Message Box"
        Me.btnMsgBox1.UseVisualStyleBackColor = True
        '
        'btnMsgBox2
        '
        Me.btnMsgBox2.Location = New System.Drawing.Point(12, 59)
        Me.btnMsgBox2.Name = "btnMsgBox2"
        Me.btnMsgBox2.Size = New System.Drawing.Size(210, 23)
        Me.btnMsgBox2.TabIndex = 1
        Me.btnMsgBox2.Text = "2 Tombol Message Box"
        Me.btnMsgBox2.UseVisualStyleBackColor = True
        '
        'btnMsgBox3
        '
        Me.btnMsgBox3.Location = New System.Drawing.Point(12, 88)
        Me.btnMsgBox3.Name = "btnMsgBox3"
        Me.btnMsgBox3.Size = New System.Drawing.Size(210, 23)
        Me.btnMsgBox3.TabIndex = 2
        Me.btnMsgBox3.Text = "3 Tombol Message Box"
        Me.btnMsgBox3.UseVisualStyleBackColor = True
        '
        'lblHasil1
        '
        Me.lblHasil1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHasil1.Location = New System.Drawing.Point(245, 59)
        Me.lblHasil1.Name = "lblHasil1"
        Me.lblHasil1.Size = New System.Drawing.Size(172, 23)
        Me.lblHasil1.TabIndex = 3
        Me.lblHasil1.Text = "H A S I L"
        Me.lblHasil1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHasil2
        '
        Me.lblHasil2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHasil2.Location = New System.Drawing.Point(245, 88)
        Me.lblHasil2.Name = "lblHasil2"
        Me.lblHasil2.Size = New System.Drawing.Size(172, 23)
        Me.lblHasil2.TabIndex = 4
        Me.lblHasil2.Text = "H A S I L"
        Me.lblHasil2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 143)
        Me.Controls.Add(Me.lblHasil2)
        Me.Controls.Add(Me.lblHasil1)
        Me.Controls.Add(Me.btnMsgBox3)
        Me.Controls.Add(Me.btnMsgBox2)
        Me.Controls.Add(Me.btnMsgBox1)
        Me.Name = "frmMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Message Box"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMsgBox1 As System.Windows.Forms.Button
    Friend WithEvents btnMsgBox2 As System.Windows.Forms.Button
    Friend WithEvents btnMsgBox3 As System.Windows.Forms.Button
    Friend WithEvents lblHasil1 As System.Windows.Forms.Label
    Friend WithEvents lblHasil2 As System.Windows.Forms.Label
End Class
