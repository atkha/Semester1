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

    Private Sub btnProses1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses1.Click
        'Deklarasi variable ket dengan tipe string
        'untuk menyimpan hasil keterangan
        Dim ket As String = ""
        'Jika nilai akhir >=
        If txtNA1.Text >= 60 Then
            'Jika benar nilai akhir >= 60 maka ket = LULUS
            ket = "LULUS"
        End If
        'Menampilkan hasil keterangan pada label keterangan
        lblKet1.Text = ket
    End Sub

    Private Sub btnProses2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses2.Click
        'Deklarasi variable ket dengan tipe string
        'untuk menyimpan hasil keterangan
        Dim ket As String = ""
        'Jika nilai akhir >= 60
        If txtNA2.Text >= 60 Then
            'Jika benar nilai akhir >= 60 maka ket = LULUS
            ket = "LULUS"
        Else
            'Jika salah nilai akhir >= 60 maka ket = GAGAL
            ket = "GAGAL"
        End If
        'Menampilkan hasil keterangan pada label keterangan
        lblKet2.Text = ket
    End Sub

    Private Sub btnProses3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses3.Click
        'Jika jenis kelamin yang dipilih adalah laki-laki (L)
        If rbtL.Checked = True Then
            'JIka status yang dipilih adalah menikah
            If cmbStatus.Text = "Menikah" Then
                'label keterangan diisi dengan ayah
                lblKet3.Text = "AYAH"
            Else ' Jika status yang dipilih adalah belum menikah
                'Label keterangan diisi dengan Jejaka
                lblKet3.Text = "JEJAKA"
            End If
        ElseIf cmbStatus.Text = "Menikah" Then
            'label keterangan diisi dengan ibu
            lblKet3.Text = "IBU"
        Else 'Jika status yang dipilih adalah belum menikah
            'Label keterangan diisi dengan gadis
            lblKet3.Text = "GADIS"
        End If
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
        ElseIf NA >= 0 And NA <= 30 Then
            lblKet4.Text = "E"
        Else
            lblKet4.Text = "SALAH INPUT NILAI"
        End If
    End Sub

    Private Sub btnProses5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses5.Click
        Dim Ke As String = cmbHari.Text
        If Ke = 1 Then
            lblNamaHari.Text = "Senin"
        ElseIf Ke = 2 Then
            lblNamaHari.Text = "Selasa"
        ElseIf Ke = 3 Then
            lblNamaHari.Text = "Rabu"
        ElseIf Ke = 4 Then
            lblNamaHari.Text = "Kamis"
        ElseIf Ke = 5 Then
            lblNamaHari.Text = "Jum'at"
        ElseIf Ke = 6 Then
            lblNamaHari.Text = "Sabtu"
        Else
            lblNamaHari.Text = "Minggu"





        End If
    End Sub

    Private Sub btnProses6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses6.Click
        'deklarasi variabel bilangan dengan tipe integer
        'untuk menyimpan bilangan 
        'pada textbox bilangan
        Dim Bil As Integer = txtBil.Text
        Select Case Bil 'cek ekspresi pada bil
            Case 1 'Jika nilai Bil adalah 1
                'label hasil akan tampil bilangan 1
                lblHasil.Text = "Bilangan 1"
            Case 2 To 5 'Jika nilai Bil 2 sampai 5
                'label hasil akan tampil bilangan 2 sampai 5
                lblHasil.Text = "Bilangan 2-5"
            Case 6, 7, 8 'JIka nilai bil adalah 6,7,8
                'label hasil akan tampil bilangan 6,7, atau 8
                lblHasil.Text = "Bilangan6,7, atau 8"
            Case Is <= 1 'jika nilai bilangan <=1
                'label hasil akan tampil bilangan Lebih Kecil Dari 1
                lblHasil.Text = "Bil. Lebih kecil dari 1"
            Case Else 'jika bilangan yang diinput selain diatas
                'label hasil akan tampil bilangan Selain antara 1-8
                lblHasil.Text = "Bil. Selain Antara 1-8"
        End Select
    End Sub

    Private Sub btnForNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForNext.Click
        LBoxHasil.Items.Clear()
        For intCount = 1 To 5
            LBoxHasil.Items.Add("Item Ke :" & intCount & "Dalam List")
        Next
    End Sub

    Private Sub btnForStep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForStep.Click
        LBoxHasil.Items.Clear()
        For intCount = 4 To 70 Step 7
            LBoxHasil.Items.Add("Item Ke :" & intCount & " + Step")
        Next
    End Sub

    Private Sub btnBackWard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackWard.Click
        LBoxHasil.Items.Clear()
        For intCount = 10 To 1 Step -1
            LBoxHasil.Items.Add("Item Ke :" & intCount & " + Step")
        Next
    End Sub

    Private Sub btnForEach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForEach.Click
        LBoxHasil.Items.Clear()
        For Each strFolder As String In My.Computer.FileSystem.GetDirectories("C:\")
            LBoxHasil.Items.Add(strFolder)
        Next
    End Sub

    Private Sub btnDoUntil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoUntil.Click
        LBoxHasil.Items.Clear()
        Dim intCount As Integer = 0
        Do Until intCount >= 5
            LBoxHasil.Items.Add("Item Ke :" & intCount & "Dalam List")
            intCount += 1
        Loop
    End Sub

    Private Sub btnDoWhile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoWhile.Click
        LBoxHasil.Items.Clear()
        Dim intCount As Integer = 0
        Do While intCount <= 5
            LBoxHasil.Items.Add("Item Ke :" & intCount & "Dalam List")
            intCount += 1
        Loop
    End Sub

    Private Sub btnNested_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNested.Click
        LBoxHasil.Items.Clear()
        For intOuterLoop = 1 To 2
            For intInnerLoop = 1 To 3
                LBoxHasil.Items.Add(intOuterLoop & "." & intInnerLoop)
            Next
        Next
    End Sub

    Private Sub cmbHari_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHari.SelectedIndexChanged

    End Sub
End Class