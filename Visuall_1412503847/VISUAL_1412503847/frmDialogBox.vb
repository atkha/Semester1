Public Class frmDialogBox


    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim strFileName As String
        ofdOpen.Filter = "text documents (*.txt)|*.txt|all files (*.*)|*."
        ofdOpen.FilterIndex = 1
        ofdOpen.Title = "Open File"
        If ofdOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFileName = ofdOpen.FileName
            Dim fileContents As String
            fileContents = My.Computer.FileSystem.ReadAllText(strFileName)
            txtTextArea.Text = fileContents
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strfilename As String = ""
        sfdSave.DefaultExt = "txt"
        sfdSave.FileName = strfilename
        sfdSave.Filter = "text documents (*.txt)|*.txt|All files (*.*)|*.*"
        sfdSave.FilterIndex = 1
        sfdSave.OverwritePrompt = True
        sfdSave.Title = "save file"
        If sfdSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            strfilename = sfdSave.FileName
            My.Computer.FileSystem.WriteAllText(strfilename, txtTextArea.Text, True)

        End If
    End Sub

    Private Sub btnFont_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFont.Click
        fdFont.ShowColor = True
        If fdFont.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtTextArea.Font = fdFont.Font
            txtTextArea.ForeColor = fdFont.Color

        End If
    End Sub

    Private Sub btnColor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnColor.Click
        If cdColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtTextArea.BackColor = cdColor.Color

        End If
    End Sub

    Private Sub cmMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmMenu.Opening
        txtTextArea.Copy()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        txtTextArea.Copy()

    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        txtTextArea.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        txtTextArea.Paste()
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class