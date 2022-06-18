Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop

Public Class FRDomisili

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
            If TBNIK.Text = vbNullString Then
                MsgBox("Silahkan isi NIK terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                TBNIK.Focus()
            Else
                If TBTeL.Text = vbNullString Then
                    MsgBox("Silahkan isi Tempat Lahir terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                    TBTeL.Focus()
                Else
                    If CBWN.Text = vbNullString Then
                        MsgBox("Silahkan isi Kewarganegaraan terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                        CBWN.Focus()
                    Else
                        If CBAlamat.Text = vbNullString Then
                            MsgBox("Silahkan pilih Alamat terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                            CBAlamat.Focus()
                        Else
                            If CBJK.Text = vbNullString Then
                                MsgBox("Silahkan pilih Jenis Kelamin terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                CBJK.Focus()
                            Else
                                If CBSK.Text = vbNullString Then
                                    MsgBox("Silahkan pilih Status Kawin terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                    CBSK.Focus()
                                Else
                                    If CBSP.Text = vbNullString Then
                                        MsgBox("Silahkan pilih Status Pekerjaan terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                        CBSP.Focus()
                                    Else
                                        If CBAgama.Text = vbNullString Then
                                            MsgBox("Silahkan pilih Agama terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                            CBAgama.Focus()
                                        Else
                                            Dim oWord As Word.Application
                                            Dim oDoc As Word.Document
                                            Dim tgl As String
                                            Dim tanggal As String
                                            Dim query As String
                                            Dim jumsum As Integer
                                            Dim jenis As String = "Domisili"
                                            Dim kategori As String = "Keluar"
                                            Dim keterangan As String = "Membuat identitas diri (KTP) sementara"
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

                                            nos = "474/" & urut & "/" & bulan & "/Des/" & tahun & ""

                                            mycmd.Connection = myconnection.open()
                                            mycmd.CommandText = "INSERT INTO surat_keluar (id, no_surat, perihal, waktu_kegiatan, jenis_surat, kategori, tanggal, keterangan) values ('', '" & nos & "', '', '', '" & jenis & "', '" & kategori & "', '" & tgl & "', '" & keterangan & "')"
                                            mycmd.ExecuteNonQuery()
                                            myconnection.close()

                                            tanggal = Format(Today, "dd-M-yyyy")

                                            'Start Word and open the document template.
                                            oWord = CreateObject("Word.Application")
                                            oWord.Visible = True
                                            oDoc = oWord.Documents.Add("C:\Templates\SURAT KETERANGAN DOMISILI.dotx")

                                            With oDoc
                                                .FormFields("w_nos").Range.Text = nos
                                                .FormFields("w_nama").Range.Text = UCase(TBNama.Text)
                                                .FormFields("w_ttl").Range.Text = "" & UCase(TBTeL.Text) & ", " & TaL.Text & ""
                                                .FormFields("w_nik").Range.Text = TBNIK.Text
                                                .FormFields("w_negara").Range.Text = CBWN.Text
                                                .FormFields("w_jk").Range.Text = CBJK.Text
                                                .FormFields("w_sk").Range.Text = CBSK.Text
                                                .FormFields("w_sp").Range.Text = CBSP.Text
                                                .FormFields("w_agama").Range.Text = CBAgama.Text
                                                .FormFields("w_alamat").Range.Text = CBAlamat.Text
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
    End Sub

    Sub bacaCB()
        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "select * from tabel_rt"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            CBAlamat.Items.Add("" & objreader.Item("kampung").ToString & " " & objreader.Item("no_rt").ToString & "/" & objreader.Item("no_rw").ToString & "")
        End While
        myconnection.close()

        CBWN.Items.Add("INDONESIA")
        CBWN.Items.Add("ASING")

        CBJK.Items.Add("LAKI - LAKI")
        CBJK.Items.Add("PEREMPUAN")
        CBSK.Items.Add("BELUM KAWIN")
        CBSK.Items.Add("KAWIN")
        CBAgama.Items.Add("ISLAM")
        CBAgama.Items.Add("KRISTEN")
        CBAgama.Items.Add("HINDU")
        CBAgama.Items.Add("BUDHA")
        CBAgama.Items.Add("KONGHUCU")

        CBSP.Items.Add("BELUM/TIDAK BEKERJA")
        CBSP.Items.Add("IRT")
        CBSP.Items.Add("PELAJAR/MAHASISWA")
        CBSP.Items.Add("PNS")
        CBSP.Items.Add("KARYAWAN SWASTA")
        CBSP.Items.Add("BURUH HARIAN LEPAS")
        CBSP.Items.Add("GURU/DOSEN")
        CBSP.Items.Add("PEDAGANG")
        CBSP.Items.Add("WIRASWASTA")
        CBSP.Items.Add("LAINNYA")
    End Sub
#End Region

    Private Sub BPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrint.Click
        cetak()
    End Sub

    Private Sub BBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBatal.Click
        FRDashboard.Show()
        Me.Close()
    End Sub

    Private Sub FRDomisili_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FRDashboard.Show()
        Hide()
    End Sub

    Private Sub FRDomisili_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bacaCB()
        MaximizeBox = False
    End Sub

    Private Sub TBNama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBNama.KeyDown
        If e.KeyCode = Keys.Enter Then
            TBNIK.Focus()
        End If
    End Sub

    Private Sub TBNIK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBNIK.KeyDown
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
            CBWN.Focus()
        End If
    End Sub

    Private Sub TBNegara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            CBAlamat.Focus()
        End If
    End Sub

    Private Sub CBAlamat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBAlamat.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBJK.Focus()
        End If
    End Sub

    Private Sub CBJK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBJK.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBSK.Focus()
        End If
    End Sub

    Private Sub CBSK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBSK.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBSP.Focus()
        End If
    End Sub

    Private Sub CBSP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBSP.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBAgama.Focus()
        End If
    End Sub

    Private Sub CBAgama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBAgama.KeyDown
        cetak()
    End Sub

    Private Sub TBNIK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBNIK.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
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

    Private Sub TBNegara_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" Or e.KeyChar = vbBack) Then
            keyAscii = 0
        Else
            e.Handled = CBool(keyAscii)
        End If
    End Sub
End Class