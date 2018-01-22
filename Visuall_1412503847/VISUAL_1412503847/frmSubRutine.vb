Public Class frmSubRutine
    Sub Tambah(ByVal _bil1 As Integer, ByVal _bil2 As Integer, ByRef hasil As Integer)
        hasil = _bil1 + _bil2
    End Sub
    Sub Kurang()
        Try
            Dim _bil1, _bil2, Hasil As Integer
            _bil1 = txtBil1.Text
            _bil2 = txtBil2.Text
            lblHasil.Text = Hasil
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Function Kali(ByVal _bil1 As Integer, ByVal _bil2 As Integer, ByRef hasil As Integer)
        hasil = _bil1 * _bil2
        Return hasil
    End Function
    Function bagi() As Double
        Try
            Dim hasil As Double = txtBil1.Text / txtBil2.Text
            Return hasil
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub frmSubRutine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTAMBAH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTAMBAH.Click
        Try
            Dim NA As Integer = 0
            Call Tambah(txtBil1.Text, txtBil2.Text, NA)
            lblHasil.Text = NA
        Catch ex As Exception
            MessageBox.Show(ex.Message, "KEsalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnKurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKurang.Click
        Call Kurang()
    End Sub

    Private Sub btnKALI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKALI.Click
        Try
            Dim Na As Integer = 0
            Call Kali(txtBil1.Text, txtBil2.Text, Na)
            lblHasil.Text = Na

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnBagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBagi.Click
        lblHasil.Text = bagi()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class