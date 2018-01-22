Public Class frmVarabelLat
    Private Sub btnKurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKurang.Click
        Dim Bilangan1, Bilangan2, Hasil As Double
        Bilangan1 = txtBil1.Text
        Bilangan2 = txtBil2.Text
        Hasil = Bilangan1 - Bilangan2
        lblHasil.Text = Hasil
    End Sub

    Private Sub btnKALI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKALI.Click
        Dim Bilangan1, Bilangan2, Hasil As Double
        Bilangan1 = txtBil1.Text
        Bilangan2 = txtBil2.Text
        Hasil = Bilangan1 * Bilangan2
        lblHasil.Text = Hasil
    End Sub

    Private Sub btnBagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBagi.Click
        Dim Bilangan1, Bilangan2, Hasil As Double
        Bilangan1 = txtBil1.Text
        Bilangan2 = txtBil2.Text
        Hasil = Bilangan1 / Bilangan2
        lblHasil.Text = Hasil
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnTAMBAH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTAMBAH.Click
        Dim Bilangan1, Bilangan2, Hasil As Double
        Bilangan1 = txtBil1.Text
        Bilangan2 = txtBil2.Text
        Hasil = Bilangan1 + Bilangan2
        lblHasil.Text = Hasil
    End Sub
End Class