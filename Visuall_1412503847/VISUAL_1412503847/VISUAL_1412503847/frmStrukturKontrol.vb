Public Class frmStrukturKontrol

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtL.CheckedChanged

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnForEach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForEach.Click
        LBoxHasil.Items.Clear()
        For Each strFolder As String In My.Computer.FileSystem.GetDirectories("C:\")
            LBoxHasil.Items.Add(strFolder)
        Next
    End Sub

    Private Sub btnProses3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses3.Click
        If rbtL.Checked = True Then
            If cmbStatus.Text = "Menikah" Then
                lblKet3.Text = "Ayah"
            Else
                lblKet3.Text = "Jejaka"
            End If
        Else : rbtP.Checked = True
            If cmbStatus.Text = "Menikah" Then
                lblKet3.Text = "Ibu"
            Else
                lblKet3.Text = "Gadis"
            End If
        End If
    End Sub

    Private Sub btnProses1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses1.Click
        Dim ket As String = ""
        If txtNA1.Text >= 60 Then
            ket = "Lulus"
        End If
        lblKet1.Text = ket

    End Sub

    Private Sub btnProses2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses2.Click
        Dim ket As String = ""
        If txtNA2.Text >= 60 Then
            ket = "Lulus"
        Else
            ket = "Gagal"
        End If
        lblKet2.Text = ket

    End Sub

    Private Sub btnProses4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses4.Click
        Dim NA As Integer = txtNA3.Text
        If NA >= 85 And NA <= 100 Then
            lblKet4.Text = "A"
        ElseIf NA >= 75 And NA <= 84 Then
            lblKet4.Text = "B"
        ElseIf NA >= 60 And NA <= 74 Then
            lblKet4.Text = "C"
        ElseIf NA >= 40 And NA <= 59 Then
            lblKet4.Text = "D"
        ElseIf NA >= 0 And NA <= 39 Then
            lblKet4.Text = "E"
        Else
            lblKet4.Text = "Salah Input Nilai"
        End If
    End Sub

    Private Sub btnProses5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses5.Click
        Dim Hari As String
        Dim Ke As String = cmbHari.Text
        Hari = IIf(Ke = "1", "Senin", _
               IIf(Ke = "2", "Selasa", _
               IIf(Ke = "3", "Rabu", _
               IIf(Ke = "4", "Kamis", _
               IIf(Ke = "5", "Jum'at", _
               IIf(Ke = "6", "Sabtu", _
               "Minggu"))))))
        lblNamaHari.Text = Hari
    End Sub

    Private Sub btnProses6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses6.Click
        Dim Bilangan As Integer
        Select Case Bilangan
            Case 1
                lblHasil.Text = "Bilangan 1"
            Case 2 To 5
                lblHasil.Text = "Bilangan 2 Sampai 5"
            Case 6, 7, 8
                lblHasil.Text = "Bilangan 6,7,atau 8"
            Case Is <= 1
                lblHasil.Text = "Bilangan Lebih Kecil dari 1"
            Case Else
                lblHasil.Text = "Bialngan Selain Antara 1 - 8"
        End Select
    End Sub

    Private Sub btnForNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForNext.Click
        LBoxHasil.Items.Clear()
        For IntCount = 1 To 5
            LBoxHasil.Items.Add("Item ke :" & IntCount & "Dalam List")
        Next
    End Sub

    Private Sub btnForStep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForStep.Click
        LBoxHasil.Items.Clear()
        For intCount = 4 To 70 Step 7
            LBoxHasil.Items.Add("Item Ke :" & intCount & "+ Step")
        Next
    End Sub

    Private Sub btnBackWard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackWard.Click
        LBoxHasil.Items.Clear()
        For IntCount = 10 To 1 Step -1
            LBoxHasil.Items.Add("Item Ke:" & IntCount & "+Step")
        Next
    End Sub

    Private Sub btnDoUntil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoUntil.Click
        LBoxHasil.Items.Clear()
        Dim IntCount As Integer = 0
        Do Until IntCount >= 5
            LBoxHasil.Items.Add("Item Ke :" & IntCount & "Dalam List")
            IntCount += 1
        Loop

    End Sub

    Private Sub btnDoWhile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoWhile.Click
        LBoxHasil.Items.Clear()
        Dim IntCount As Integer = 0
        Do While IntCount <= 5
            LBoxHasil.Items.Add("Item Ke :" & IntCount & "Dalam List")
            IntCount += 1
        Loop
    End Sub

    Private Sub btnNested_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNested.Click
        LBoxHasil.Items.Clear()
        For intOuterLoop = 1 To 2
            For IntInnerLoop = 1 To 3
                LBoxHasil.Items.Add(intOuterLoop & "." & IntInnerLoop)
            Next
        Next
    End Sub
End Class