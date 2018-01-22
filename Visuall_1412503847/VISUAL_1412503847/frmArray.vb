Public Class frmArray

    Private Sub LBoxHasil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBoxHasil.SelectedIndexChanged

    End Sub

    Private Sub btnElemen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElemen.Click
        LBoxHasil.Items.Clear()
        Dim strfriends(4) As String
        strfriends(0) = "wendy"
        strfriends(1) = "Harriet"
        strfriends(2) = "Jay"
        strfriends(3) = "Michaelle"
        strfriends(4) = "Richard"
        LBoxHasil.Items.Add(strfriends(0))
    End Sub

    Private Sub btnEnumerasi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEnumerasi.Click
        LBoxHasil.Items.Clear()
        Dim strfriends(4) As String
        strfriends(0) = "Wendy"
        strfriends(1) = "Harriet"
        strfriends(2) = "Jay"
        strfriends(3) = "Michaelle"
        strfriends(4) = "Richard"
        For Each strname As String In strfriends
            LBoxHasil.Items.Add(strname)
        Next
    End Sub

    Private Sub btnSorting_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSorting.Click
        LBoxHasil.Items.Clear()
        Dim strfriends(4) As String
        strfriends(0) = "Wendy"
        strfriends(1) = "Harriet"
        strfriends(2) = "Jay"
        strfriends(3) = "Michaelle"
        strfriends(4) = "Richard"
        Array.Sort(strfriends)
        For Each strname As String In strfriends
            LBoxHasil.Items.Add(strname)
        Next
    End Sub

    Private Sub btnReverse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReverse.Click
        LBoxHasil.Items.Clear()
        Dim strfriends(4) As String
        strfriends(0) = "wendy"
        strfriends(1) = "harriet"
        strfriends(2) = "jay"
        strfriends(3) = "michelle"
        strfriends(4) = "richard"
        Array.Reverse(strfriends)
        For Each strname As String In strfriends
            LBoxHasil.Items.Add(strname)
        Next
    End Sub

    Private Sub btnNilaiAwal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNilaiAwal.Click
        LBoxHasil.Items.Clear()
        Dim strfriends() As String = {"elanie", "debra", "wendy", "harriet"}
        For Each strname As String In strfriends
            LBoxHasil.Items.Add(strname)

        Next
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()

    End Sub
End Class