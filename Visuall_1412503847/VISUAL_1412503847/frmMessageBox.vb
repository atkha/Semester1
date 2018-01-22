Public Class frmMessageBox

    Private Sub lblHasil2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHasil2.Click

    End Sub

    Private Sub btnMsgBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMsgBox1.Click
        MessageBox.Show("Isi text", "Isi caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub btnMsgBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMsgBox2.Click
        If MessageBox.Show("Jaringan Internet akan ditutup", "notifikasi jaringan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            lblHasil1.Text = "tombol ok diklik"
        Else
            lblHasil1.Text = "tombol cancel diklik"
        End If
    End Sub

    Private Sub btnMsgBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMsgBox3.Click
        Dim inthasil As DialogResult
        inthasil = MessageBox.Show("apakah Dokumen Ini Akan Disimpan?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3)
        Select Case inthasil
            Case Windows.Forms.DialogResult.Yes
                lblHasil2.Text = "tombol yes diklik"
            Case Windows.Forms.DialogResult.No
                lblHasil2.Text = "tombol no diklik"
            Case Windows.Forms.DialogResult.Cancel
                lblHasil2.Text = "tombol cancel diklik"
        End Select
    End Sub
End Class