Public Class frmEvent

    Private Sub btnEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvent.Click
        btnKeluar.Text = " SUDAH CUKUP "
    End Sub

    Private Sub btnEvent_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnEvent.MouseDown
        btnEvent.Text = " MOUSE DI KLIK "
    End Sub

    Private Sub btnEvent_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEvent.MouseEnter
        btnEvent.Text = " MOUSE DATANG !!! "
    End Sub

    Private Sub btnEvent_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEvent.MouseLeave
        btnEvent.Text = "MOUSE PERGI !!! "
    End Sub

    Private Sub btnEvent_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnEvent.MouseUp
        btnEvent.Text = " MOUSE TIDAK DI KLIK "
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class