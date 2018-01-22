Public Class frmFungsi_BuiltIn
    Dim ket1, ket2, ket3 As String
    Dim N, K, L As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ket1 = ket1 & Mid(txtText.Text, N, 1)
        lblAnimasi1.Text = ket1
        If N = Len(txtText.Text) Then
            ket1 = ""
            N = 1
        Else
            N = N + 1
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lblAnimasi2.Text = Microsoft.VisualBasic.Left(txtText.Text, K)
        If K = Len(txtText.Text) Then
            K = 1
        Else
            K = K + 1
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Len(txtText.Text) > 0 Then
            ket3 = Microsoft.VisualBasic.Left(txtText.Text, Len(txtText.Text) - L)
            lblAnimasi3.Text = ket3
            If L = Len(txtText.Text) Then
                L = 1
            Else
                L = L + 1
            End If
        End If
    End Sub

    Private Sub frmFungsi_BuiltIn_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        N = 1
        K = 1
        ket1 = ""
        FormatX()

    End Sub
    Sub FormatX()
        lblTanggal1.Text = Format(Now(), "dd/MM/yyyy")
        lblTanggal2.Text = Format(Now(), "dddd, dd MMMM yyyy")
        lblJam.Text = Format(Now(), "hh:mm")
        lblUang.Text = Format(10203.192, "Rp ##,###.000")

    End Sub

    Private Sub txtText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtText.KeyPress
        If e.KeyChar = Chr(13) Then
            Timer1.Enabled = True
            Timer2.Enabled = True
            Timer3.Enabled = True

        End If

    End Sub

End Class