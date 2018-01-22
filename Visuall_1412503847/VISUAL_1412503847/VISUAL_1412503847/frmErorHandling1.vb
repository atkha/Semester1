Public Class frmErorHandling1

    Private Sub btnTAMBAH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTAMBAH.Click
        Try 'Program yang akan diperiksa
            'Label pesan tidak ditampilkan
            lblPesan.Visible = False
            'Deklarasi variabel yang dibutuhkan
            Dim Bilangan1 As Double
            Dim Bilangan2 As Double
            Dim Hasil As Double
            'Isi variabel bilangan1 dengan Textbox Bilangan 1
            Bilangan1 = txtBil1.Text
            'isi variabel bilangan2 dengan TextBox Bilangan 2
            Bilangan2 = txtBil2.Text
            'HItung penambahan bilangan 1 dengan bilangan 2
            'disimpan dalam variabel hasil
            Hasil = Bilangan1 + Bilangan2
            'Hasil ditampilkan pada label Hasil
            lblHasil.Text = Hasil
        Catch ex As Exception 'program dijalankan jika terdapat kesalahan 
            'pesan kesalahan ditampilkan pada Label Pesan
            lblPesan.Text = "EROR PENAMBAHAN: " & ex.Message
            'LAbel PEsan ditampilkan
            lblPesan.Visible = True

        End Try
    End Sub

    Private Sub btnKurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKurang.Click
        Try 'Program yang akan diperiksa
            'Label pesan tidak ditampilkan
            lblPesan.Visible = False
            'Deklarasi variabel yang dibutuhkan
            Dim Bilangan1 As Double
            Dim Bilangan2 As Double
            Dim Hasil As Double
            'Isi variabel bilangan1 dengan Textbox Bilangan 1
            Bilangan1 = txtBil1.Text
            'isi variabel bilangan2 dengan TextBox Bilangan 2
            Bilangan2 = txtBil2.Text
            'HItung penambahan bilangan 1 dengan bilangan 2
            'disimpan dalam variabel hasil
            Hasil = Bilangan1 - Bilangan2
            'Hasil ditampilkan pada label Hasil
            lblHasil.Text = Hasil
        Catch ex As Exception 'program dijalankan jika terdapat kesalahan 
            'pesan kesalahan ditampilkan pada Label Pesan
            lblPesan.Text = "EROR PENURANGAN: " & ex.Message
            'LAbel PEsan ditampilkan
            lblPesan.Visible = True
        End Try

    End Sub

    Private Sub btnKALI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKALI.Click
        Try 'Program yang akan diperiksa
            'Label pesan tidak ditampilkan
            lblPesan.Visible = False
            'Deklarasi variabel yang dibutuhkan
            Dim Bilangan1 As Double
            Dim Bilangan2 As Double
            Dim Hasil As Double
            'Isi variabel bilangan1 dengan Textbox Bilangan 1
            Bilangan1 = txtBil1.Text
            'isi variabel bilangan2 dengan TextBox Bilangan 2
            Bilangan2 = txtBil2.Text
            'HItung penambahan bilangan 1 dengan bilangan 2
            'disimpan dalam variabel hasil
            Hasil = Bilangan1 * Bilangan2
            'Hasil ditampilkan pada label Hasil
            lblHasil.Text = Hasil
        Catch ex As Exception 'program dijalankan jika terdapat kesalahan 
            'pesan kesalahan ditampilkan pada Label Pesan
            lblPesan.Text = "EROR PERKALIAN: " & ex.Message
            'LAbel PEsan ditampilkan
            lblPesan.Visible = True
        End Try
    End Sub

    Private Sub btnBagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBagi.Click
        Try 'Program yang akan diperiksa
            'Label pesan tidak ditampilkan
            lblPesan.Visible = False
            'Deklarasi variabel yang dibutuhkan
            Dim Bilangan1 As Double
            Dim Bilangan2 As Double
            Dim Hasil As Double
            'Isi variabel bilangan1 dengan Textbox Bilangan 1
            Bilangan1 = txtBil1.Text
            'isi variabel bilangan2 dengan TextBox Bilangan 2
            Bilangan2 = txtBil2.Text
            'HItung penambahan bilangan 1 dengan bilangan 2
            'disimpan dalam variabel hasil
            Hasil = Bilangan1 / Bilangan2
            'Hasil ditampilkan pada label Hasil
            lblHasil.Text = Hasil
        Catch ex As Exception 'program dijalankan jika terdapat kesalahan 
            'pesan kesalahan ditampilkan pada Label Pesan
            lblPesan.Text = "EROR PEMBAGIAN: " & ex.Message
            'LAbel PEsan ditampilkan
            lblPesan.Visible = True
        End Try

    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class