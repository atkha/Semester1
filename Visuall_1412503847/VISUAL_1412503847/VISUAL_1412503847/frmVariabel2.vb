Public Class frmVariabel2

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        'Deklarasi Variabel yang Ditentukan
        Dim Panjang, Lebar, Hasil As Double
        'Isi Variabel panjang berdaraskan input
        'textBox Panjang
        Panjang = txtPanjang.Text
        'Isi Variabel Lebar berdasrkan Input
        'TextBox Lebar
        Lebar = txtLebar.Text
        'Variabel Hasil berdasarkan Panjang X Lebar
        Hasil = Panjang * Lebar
        'Hasil perkalian panjang x lebar ditampilkan 
        'pada TextBox Hasil
        txtHasil.Text = Hasil

    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class