Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop

Public Class FRSKTM

#Region "Deklarasi"
    Dim koneksi As New ClassKoneksi
    Dim dtab As New DataTable
    Dim mycmd As New MySqlCommand
    Dim cmd As New MySqlCommand
    Dim myconnection As New koneksidata
    Dim objreader As MySqlDataReader
    Dim obj As MySqlDataReader


    Sub cetak()
        If TBNama.Text = vbNullString Then
            MsgBox("Silahkan isi Nama terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
            TBNama.Focus()
        Else
            If TBTeL.Text = vbNullString Then
                MsgBox("Silahkan isi Tempat Lahir terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                TBTeL.Focus()
            Else
                If CBAgama.Text = vbNullString Then
                    MsgBox("Silahkan pilih Agama terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                    CBAgama.Focus()
                Else
                    If CBKerja.Text = vbNullString Then
                        MsgBox("Silahkan pilih Pekerjaan terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                        CBKerja.Focus()
                    Else
                        If CBAlamat.Text = vbNullString Then
                            MsgBox("Silahkan pilih Alamat terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                            CBAlamat.Focus()
                        Else
                            If TBNamaOt.Text = vbNullString Then
                                MsgBox("Silahkan isi Nama Orangtua terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                TBNamaOt.Focus()
                            Else
                                If TBTeLOt.Text = vbNullString Then
                                    MsgBox("Silahkan isi Tempat Lahir Orangtua terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                    TBTeLOt.Focus()
                                Else
                                    If CBAgamaOt.Text = vbNullString Then
                                        MsgBox("Silahkan pilih Agama Orangtua terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                        CBAgamaOt.Focus()
                                    Else
                                        If CBKerjaOt.Text = vbNullString Then
                                            MsgBox("Silahkan pilih Pekerjaan Orangtua terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                            CBKerjaOt.Focus()
                                        Else
                                            If CBAlamatOt.Text = vbNullString Then
                                                MsgBox("Silahkan pilih Alamat Orangtua terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                                CBAlamatOt.Focus()
                                            Else
                                                Dim oWord As Word.Application
                                                Dim oDoc As Word.Document
                                                Dim tgl As String
                                                Dim tanggal As String
                                                Dim query As String
                                                Dim jumsum As Integer
                                                Dim jenis As String = "SKTM"
                                                Dim kategori As String = "Keluar"
                                                Dim keterangan As String = "Untuk Syarat Permintaan Bantuan"
                                                Dim bulan As String
                                                Dim tahun As String
                                                Dim urut As String
                                                Dim nos As String

                                                query = "SELECT * FROM surat_keluar WHERE jenis_surat = '" & jenis & "' AND kategori = '" & kategori & "' AND MONTH(tanggal) = '" & Month(Today) & "'"
                                                dtab = koneksi.ExecuteQuery(query)
                                                jumsum = dtab.Rows.Count

                                                urut = jumsum + 1
                                                Select Case Month(Today)
                                                    Case Is = 1
                                                        bulan = "I"
                                                    Case Is = 2
                                                        bulan = "II"
                                                    Case Is = 3
                                                        bulan = "III"
                                                    Case Is = 4
                                                        bulan = "IV"
                                                    Case Is = 5
                                                        bulan = "V"
                                                    Case Is = 6
                                                        bulan = "VI"
                                                    Case Is = 7
                                                        bulan = "VII"
                                                    Case Is = 8
                                                        bulan = "VIII"
                                                    Case Is = 9
                                                        bulan = "IX"
                                                    Case Is = 10
                                                        bulan = "X"
                                                    Case Is = 11
                                                        bulan = "XI"
                                                    Case Is = 12
                                                        bulan = "XII"
                                                End Select
                                                tahun = Format(Today, "yyyy")
                                                tgl = Format(Today, "yyyy-MM-dd")

                                                nos = "141/" & urut & "/" & bulan & "/Des/" & tahun & ""

                                                mycmd.Connection = myconnection.open()
                                                mycmd.CommandText = "INSERT INTO surat_keluar (id, no_surat, perihal, waktu_kegiatan, jenis_surat, kategori, tanggal, keterangan) values ('', '" & nos & "', '', '', '" & jenis & "', '" & kategori & "', '" & tgl & "', '" & keterangan & "')"
                                                mycmd.ExecuteNonQuery()
                                                myconnection.close()

                                                tanggal = Format(Today, "dd-M-yyyy")

                                                'Start Word and open the document template.
                                                oWord = CreateObject("Word.Application")
                                                oWord.Visible = True
                                                oDoc = oWord.Documents.Add("C:\Templates\SURAT KETERANGAN TIDAK MAMPU.dotx")

                                                With oDoc
                                                    .FormFields("w_nos").Range.Text = nos
                                                    .FormFields("w_nama").Range.Text = UCase(TBNama.Text)
                                                    .FormFields("w_ttl").Range.Text = "" & UCase(TBTeL.Text) & ", " & TaL.Text & ""
                                                    .FormFields("w_kerja").Range.Text = CBKerja.Text
                                                    .FormFields("w_agama").Range.Text = CBAgama.Text
                                                    .FormFields("w_alamat").Range.Text = CBAlamat.Text
                                                    .FormFields("w_namaot").Range.Text = UCase(TBNamaOt.Text)
                                                    .FormFields("w_ttlot").Range.Text = "" & UCase(TBTeLOt.Text) & ", " & TaLOt.Text & ""
                                                    .FormFields("w_kerjaot").Range.Text = CBKerjaOt.Text
                                                    .FormFields("w_agamaot").Range.Text = CBAgamaOt.Text
                                                    .FormFields("w_alamatot").Range.Text = CBAlamatOt.Text
                                                    .FormFields("w_tanggal").Range.Text = tanggal
                                                End With
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Sub bacaCB()
        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "select * from tabel_rt"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            CBAlamat.Items.Add("" & objreader.Item("kampung").ToString & " " & objreader.Item("no_rt").ToString & "/" & objreader.Item("no_rw").ToString & "")
            CBAlamatOt.Items.Add("" & objreader.Item("kampung").ToString & " " & objreader.Item("no_rt").ToString & "/" & objreader.Item("no_rw").ToString & "")
        End While
        myconnection.close()

        CBAgama.Items.Add("ISLAM")
        CBAgama.Items.Add("KRISTEN")
        CBAgama.Items.Add("HINDU")
        CBAgama.Items.Add("BUDHA")
        CBAgama.Items.Add("KONGHUCU")
        CBAgamaOt.Items.Add("ISLAM")
        CBAgamaOt.Items.Add("KRISTEN")
        CBAgamaOt.Items.Add("HINDU")
        CBAgamaOt.Items.Add("BUDHA")
        CBAgamaOt.Items.Add("KONGHUCU")

        CBKerja.Items.Add("BELUM/TIDAK BEKERJA")
        CBKerja.Items.Add("IRT")
        CBKerja.Items.Add("PELAJAR/MAHASISWA")
        CBKerja.Items.Add("PNS")
        CBKerja.Items.Add("KARYAWAN SWASTA")
        CBKerja.Items.Add("BURUH HARIAN LEPAS")
        CBKerja.Items.Add("GURU/DOSEN")
        CBKerja.Items.Add("PEDAGANG")
        CBKerja.Items.Add("WIRASWASTA")
        CBKerja.Items.Add("LAINNYA")

        CBKerjaOt.Items.Add("BELUM/TIDAK BEKERJA")
        CBKerjaOt.Items.Add("IRT")
        CBKerjaOt.Items.Add("PELAJAR/MAHASISWA")
        CBKerjaOt.Items.Add("PNS")
        CBKerjaOt.Items.Add("KARYAWAN SWASTA")
        CBKerjaOt.Items.Add("BURUH HARIAN LEPAS")
        CBKerjaOt.Items.Add("GURU/DOSEN")
        CBKerjaOt.Items.Add("PEDAGANG")
        CBKerjaOt.Items.Add("WIRASWASTA")
        CBKerjaOt.Items.Add("LAINNYA")
    End Sub
#End Region

    Private Sub BPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrint.Click
        cetak()
    End Sub

    Private Sub BBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBatal.Click
        FRDashboard.Show()
        Me.Close()
    End Sub

    Private Sub FRSKTM_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FRDashboard.Show()
        Hide()
    End Sub

    Private Sub FRSKTM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bacaCB()
        MaximizeBox = False
    End Sub

    Private Sub TBNama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBNama.KeyDown
        If e.KeyCode = Keys.Enter Then
            TBTeL.Focus()
        End If
    End Sub

    Private Sub TBTeL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBTeL.KeyDown
        If e.KeyCode = Keys.Enter Then
            TaL.Focus()
        End If
    End Sub

    Private Sub TaL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TaL.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBAgama.Focus()
        End If
    End Sub

    Private Sub CBAgama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBAgama.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBKerja.Focus()
        End If
    End Sub

    Private Sub CBKerja_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBKerja.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBAlamat.Focus()
        End If
    End Sub

    Private Sub CBAlamat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBAlamat.KeyDown
        If e.KeyCode = Keys.Enter Then
            TBNamaOt.Focus()
        End If
    End Sub

    Private Sub TBNamaOt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBNamaOt.KeyDown
        If e.KeyCode = Keys.Enter Then
            TBTeLOt.Focus()
        End If
    End Sub

    Private Sub TBTeLOt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBTeLOt.KeyDown
        If e.KeyCode = Keys.Enter Then
            TaLOt.Focus()
        End If
    End Sub

    Private Sub TaLOt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TaLOt.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBAgamaOt.Focus()
        End If
    End Sub

    Private Sub CBAgamaOt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBAgamaOt.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBKerjaOt.Focus()
        End If
    End Sub

    Private Sub CBKerjaOt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBKerjaOt.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBAlamatOt.Focus()
        End If
    End Sub

    Private Sub CBAlamatOt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBAlamatOt.KeyDown
        cetak()
    End Sub

    Private Sub TBNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBNama.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" Or e.KeyChar = vbBack) Then
            keyAscii = 0
        Else
            e.Handled = CBool(keyAscii)
        End If
    End Sub

    Private Sub TBTeL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBTeL.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" Or e.KeyChar = vbBack) Then
            keyAscii = 0
        Else
            e.Handled = CBool(keyAscii)
        End If
    End Sub

    Private Sub TBNamaOt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBNamaOt.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" Or e.KeyChar = vbBack) Then
            keyAscii = 0
        Else
            e.Handled = CBool(keyAscii)
        End If
    End Sub

    Private Sub TBTeLOt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBTeLOt.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" Or e.KeyChar = vbBack) Then
            keyAscii = 0
        Else
            e.Handled = CBool(keyAscii)
        End If
    End Sub
End Class