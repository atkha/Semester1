Public Class frmErorHandling2

    Private Sub frmErorHandling2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'perintah untuk mengisi pilihan pada Combo Potongan
        cmbPotongan.Items.Add("5")
        cmbPotongan.Items.Add("10")
        cmbPotongan.Items.Add("15")
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesan.Click
        Dim Disc, Total As Double
        'menghitung discount >>> Disc = (Harga x Jumlah x Potongan) / 100
        Disc = (txtHarga.Text * txtJumlah.Text * cmbPotongan.Text) / 100
        'menghitung total >> Total (Harga x jumlah) - disc
        Total = (txtHarga.Text * txtJumlah.Text) - Disc
        'hasil total ditampilkan pada albel total 
        lblTotal.Text = total
        'menambah Baris pada List Box
        LBoxList.Items.Add("Nama Makanan :" & cmbMakan.Text)
        LBoxList.Items.Add("Harga :" & txtHarga.Text)
        LBoxList.Items.Add("Jumlah :" & txtJumlah.Text)
        LBoxList.Items.Add("Diskon :" & Disc)
        LBoxList.Items.Add("Total :" & Total)
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        'mengisi combo makan/minum dengan teks --Pilih--
        cmbMakan.Text = "--Pilih--"
        'membersihkan aBaris pada ListBox
        LBoxList.Items.Clear()
        'mengisi teks Jumlah,Harga dan Total dengan angka 0
        txtJumlah.Text = 0
        txtHarga.Text = 0
        lblTotal.Text = 0
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        'tutup Form
        Me.Close()

    End Sub
End Class