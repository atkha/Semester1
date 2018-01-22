Public Class Form1

    Private Sub EventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventToolStripMenuItem.Click
        frmEvent.MdiParent = Me
        frmEvent.Show()
    End Sub

    Private Sub Variabel1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Variabel1ToolStripMenuItem.Click
        frmVaraibel1.MdiParent = Me
        frmVaraibel1.Show()
    End Sub

    Private Sub Variabel2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Variabel2ToolStripMenuItem.Click
        frmVariabel2.MdiParent = Me
        frmVariabel2.Show()
    End Sub

    Private Sub LatihanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LatihanToolStripMenuItem.Click
        frmVarabelLat.MdiParent = Me
        frmVarabelLat.Show()

    End Sub

    Private Sub ErorHandling1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErorHandling1ToolStripMenuItem.Click
        frmErorHandling1.MdiParent = Me
        frmErorHandling1.Show()

    End Sub

    Private Sub ErorHandling2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErorHandling2ToolStripMenuItem.Click
        frmErorHandling2.MdiParent = Me
        frmErorHandling2.Show()

    End Sub

    Private Sub StrukturKontrolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrukturKontrolToolStripMenuItem.Click
        frmStrukturKontrol.MdiParent = Me
        frmStrukturKontrol.Show()

    End Sub

    Private Sub MessageBoxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessageBoxToolStripMenuItem.Click
        frmMessageBox.MdiParent = Me
        frmMessageBox.Show()

    End Sub

    Private Sub DialogBoxToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DialogBoxToolStripMenuItem1.Click
        frmDialogBox.MdiParent = Me
        frmDialogBox.Show()


    End Sub

    Private Sub ArrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrayToolStripMenuItem.Click
        frmArray.MdiParent = Me
        frmArray.Show()

    End Sub

    Private Sub SubrutineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubrutineToolStripMenuItem.Click

    End Sub

    Private Sub SubrutineToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubrutineToolStripMenuItem1.Click
        frmSubRutine.MdiParent = Me
        frmSubRutine.Show()

    End Sub

    Private Sub LatihanSubrutineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LatihanSubrutineToolStripMenuItem.Click
        frmSubRutineLat.MdiParent = Me
        frmSubRutineLat.Show()

    End Sub

    Private Sub FungsiBuildtInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FungsiBuildtInToolStripMenuItem.Click
        frmFungsi_BuiltIn.MdiParent = Me
        frmFungsi_BuiltIn.Show()

    End Sub


    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class