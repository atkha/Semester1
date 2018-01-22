Public Class frmVaraibel1

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        'Deklarasi Variabel Angka Dengan Tipe Integer
        Dim Angka As Integer
        'Isi Variable Angka dengan 5
        Angka = 5

        'Penambahan
        Angka = Angka + 10
        'Tampilkan Hasil Pada Label Tambah
        lblTambah.Text = Angka

        'Perkalian
        Angka = Angka + 5
        'Tampilkan Hasil Pada Label Kali
        lblKali.Text = Angka

        'Pembagian
        Angka = Angka / 2
        'Tampilkan Hasil Pada Label Bagi
        lblBagi.Text = Angka

        'Pengurangan
        Angka = Angka - 2
        'Tampilkan Hasil Pada Label Kurang
        lblKurang.Text = Angka
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class