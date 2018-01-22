<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArray
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
        Me.btnReverse = New System.Windows.Forms.Button
        Me.btnSorting = New System.Windows.Forms.Button
        Me.btnEnumerasi = New System.Windows.Forms.Button
        Me.btnElemen = New System.Windows.Forms.Button
        Me.LBoxHasil = New System.Windows.Forms.ListBox
        Me.btnNilaiAwal = New System.Windows.Forms.Button
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnReverse
        '
        Me.btnReverse.Location = New System.Drawing.Point(278, 99)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(176, 23)
        Me.btnReverse.TabIndex = 13
        Me.btnReverse.Text = "Reverse Array"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'btnSorting
        '
        Me.btnSorting.Location = New System.Drawing.Point(278, 70)
        Me.btnSorting.Name = "btnSorting"
        Me.btnSorting.Size = New System.Drawing.Size(176, 23)
        Me.btnSorting.TabIndex = 12
        Me.btnSorting.Text = "Sorting Array"
        Me.btnSorting.UseVisualStyleBackColor = True
        '
        'btnEnumerasi
        '
        Me.btnEnumerasi.Location = New System.Drawing.Point(278, 41)
        Me.btnEnumerasi.Name = "btnEnumerasi"
        Me.btnEnumerasi.Size = New System.Drawing.Size(176, 23)
        Me.btnEnumerasi.TabIndex = 11
        Me.btnEnumerasi.Text = "Enumerasi Array"
        Me.btnEnumerasi.UseVisualStyleBackColor = True
        '
        'btnElemen
        '
        Me.btnElemen.Location = New System.Drawing.Point(278, 12)
        Me.btnElemen.Name = "btnElemen"
        Me.btnElemen.Size = New System.Drawing.Size(176, 23)
        Me.btnElemen.TabIndex = 10
        Me.btnElemen.Text = "Elemen Array"
        Me.btnElemen.UseVisualStyleBackColor = True
        '
        'LBoxHasil
        '
        Me.LBoxHasil.FormattingEnabled = True
        Me.LBoxHasil.Location = New System.Drawing.Point(12, 18)
        Me.LBoxHasil.Name = "LBoxHasil"
        Me.LBoxHasil.Size = New System.Drawing.Size(260, 212)
        Me.LBoxHasil.TabIndex = 9
        '
        'btnNilaiAwal
        '
        Me.btnNilaiAwal.Location = New System.Drawing.Point(278, 128)
        Me.btnNilaiAwal.Name = "btnNilaiAwal"
        Me.btnNilaiAwal.Size = New System.Drawing.Size(176, 23)
        Me.btnNilaiAwal.TabIndex = 14
        Me.btnNilaiAwal.Text = "Array Dengan Nilai Awal"
        Me.btnNilaiAwal.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(278, 157)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(176, 23)
        Me.btnKeluar.TabIndex = 15
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'frmArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 307)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnNilaiAwal)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.btnSorting)
        Me.Controls.Add(Me.btnEnumerasi)
        Me.Controls.Add(Me.btnElemen)
        Me.Controls.Add(Me.LBoxHasil)
        Me.Name = "frmArray"
        Me.Text = "Array"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReverse As System.Windows.Forms.Button
    Friend WithEvents btnSorting As System.Windows.Forms.Button
    Friend WithEvents btnEnumerasi As System.Windows.Forms.Button
    Friend WithEvents btnElemen As System.Windows.Forms.Button
    Friend WithEvents LBoxHasil As System.Windows.Forms.ListBox
    Friend WithEvents btnNilaiAwal As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
End Class
