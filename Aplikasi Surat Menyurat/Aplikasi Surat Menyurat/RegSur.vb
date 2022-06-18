Imports MySql.Data.MySqlClient

Public Class FRRegSur
#Region "Deklarasi"
    Dim koneksi As New ClassKoneksi
    Dim dtab As New DataTable
    Dim mycmd As New MySqlCommand
    Dim cmd As New MySqlCommand
    Dim myconnection As New koneksidata
    Dim objreader As MySqlDataReader
    Dim obj As MySqlDataReader
#End Region
#Region "Prosedur"
    Sub bacalv()
        Dim isi As ListViewItem

        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "select * from surat_keluar"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LVSurat.Items.Add(objreader.Item("id").ToString)
            isi.SubItems.Add(objreader.Item("no_surat").ToString)
            isi.SubItems.Add(objreader.Item("perihal").ToString)
            isi.SubItems.Add(objreader.Item("waktu_kegiatan").ToString)
            isi.SubItems.Add(objreader.Item("tanggal").ToString)
            isi.SubItems.Add(objreader.Item("kategori").ToString)
        End While
        myconnection.close()
    End Sub

    Sub kliklv()
        Dim index As Integer
        If LVSurat.SelectedItems.Count = 0 Then Exit Sub
        With LVSurat
            index = .SelectedIndices(0)
            IDS.Text = .Items(index).Text
            CBKategori.Text = .Items(index).SubItems(5).Text

            Dim id As String = .Items(index).Text
            Dim kat As String = .Items(index).SubItems(5).Text

            If kat = "Keluar" Then
                mycmd.Connection = myconnection.open()
                mycmd.CommandText = "select * from surat_keluar where id = '" & id & "'"
                objreader = mycmd.ExecuteReader
                While objreader.Read
                    TBNoS.Text = objreader.Item("no_surat").ToString
                    CBJS.Text = objreader.Item("jenis_surat").ToString
                    CBKategori.Text = objreader.Item("kategori").ToString
                    TBPerihal.Text = objreader.Item("perihal").ToString
                    TBWK.Text = objreader.Item("waktu_kegiatan").ToString
                    Tanggal.Text = objreader.Item("tanggal").ToString
                    RTBKeterangan.Text = objreader.Item("keterangan").ToString
                End While
                myconnection.close()
            ElseIf kat = "Masuk" Then
                mycmd.Connection = myconnection.open()
                mycmd.CommandText = "select * from surat_masuk where id = '" & id & "'"
                objreader = mycmd.ExecuteReader
                While objreader.Read
                    TBNoS.Text = objreader.Item("no_surat").ToString
                    CBJS.Text = objreader.Item("jenis_surat").ToString
                    CBKategori.Text = objreader.Item("kategori").ToString
                    TBPerihal.Text = objreader.Item("perihal").ToString
                    TBWK.Text = objreader.Item("waktu_kegiatan").ToString
                    Tanggal.Text = objreader.Item("tanggal").ToString
                    RTBKeterangan.Text = objreader.Item("keterangan").ToString
                End While
                myconnection.close()
            End If
        End With
    End Sub

    Sub bacacb()
        CBKategori.Items.Add("Masuk")
        CBKategori.Items.Add("Keluar")
        CBJS.Items.Add("Domisili")
        CBJS.Items.Add("SKTM")
        CBJS.Items.Add("Undangan")
        CBJS.Items.Add("Lainnya")
    End Sub

    Sub bersih()
        TBNoS.Text = ""
        TBPerihal.Text = ""
        TBWK.Text = ""
        CBJS.Text = ""
        CBKategori.Text = ""
        RTBKeterangan.Text = ""
        TBNoS.Focus()
    End Sub
#End Region

    Private Sub BTamMas_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTamMas.Click
        JT.Text = "DAFTAR SURAT MASUK"

        Dim isi As ListViewItem

        LVSurat.Items.Clear()
        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "select * from surat_masuk where kategori = 'Masuk'"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LVSurat.Items.Add(objreader.Item("id").ToString)
            isi.SubItems.Add(objreader.Item("no_surat").ToString)
            isi.SubItems.Add(objreader.Item("perihal").ToString)
            isi.SubItems.Add(objreader.Item("waktu_kegiatan").ToString)
            isi.SubItems.Add(objreader.Item("tanggal").ToString)
            isi.SubItems.Add(objreader.Item("kategori").ToString)
        End While
        myconnection.close()
    End Sub

    Private Sub BTamKel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTamKel.Click
        JT.Text = "DAFTAR SURAT KELUAR"

        Dim isi As ListViewItem

        LVSurat.Items.Clear()
        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "select * from surat_keluar where kategori = 'Keluar'"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LVSurat.Items.Add(objreader.Item("id").ToString)
            isi.SubItems.Add(objreader.Item("no_surat").ToString)
            isi.SubItems.Add(objreader.Item("perihal").ToString)
            isi.SubItems.Add(objreader.Item("waktu_kegiatan").ToString)
            isi.SubItems.Add(objreader.Item("tanggal").ToString)
            isi.SubItems.Add(objreader.Item("kategori").ToString)
        End While
        myconnection.close()
    End Sub

    Private Sub BTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTambah.Click
        If TBNoS.Text = vbNullString Then
            MsgBox("Silahkan isi No Surat terlebih dahulu", MsgBoxStyle.Critical, "Registrasi Surat")
            TBNoS.Focus()
        Else
            If CBKategori.Text = vbNullString Then
                MsgBox("Silahkan pilih Kategori Surat terlebih dahulu", MsgBoxStyle.Critical, "Registrasi Surat")
                CBKategori.Focus()
            Else
                If CBJS.Text = vbNullString Then
                    MsgBox("Silahkan pilih Jenis Surat terlebih dahulu", MsgBoxStyle.Critical, "Registrasi Surat")
                    CBJS.Focus()
                Else
                    If CBKategori.Text = "Masuk" Then
                        Dim quey As String
                        Dim tgl As String

                        tgl = Format(Tanggal.Value, "yyyy-M-dd")

                        quey = "SELECT * FROM surat_masuk WHERE no_surat = '" & TBNoS.Text & "' and kategori = '" & CBKategori.Text & "'"
                        dtab = koneksi.ExecuteQuery(quey)
                        If dtab.Rows.Count > 0 Then
                            MsgBox("No Surat telah terdaftar sebelumnya silahkan periksa kembali", MsgBoxStyle.Critical, "Registrasi Surat")
                            TBNoS.Focus()
                        Else
                            mycmd.Connection = myconnection.open()
                            mycmd.CommandText = "INSERT INTO surat_masuk (id, no_surat, perihal, waktu_kegiatan, jenis_surat, kategori, tanggal, keterangan) values ('', '" & TBNoS.Text & "', '" & TBPerihal.Text & "', '" & TBWK.Text & "', '" & CBJS.Text & "', '" & CBKategori.Text & "', '" & tgl & "', '" & RTBKeterangan.Text & "')"
                            mycmd.ExecuteNonQuery()
                            myconnection.close()
                            LVSurat.Items.Clear()
                            bersih()
                            bacalv()
                            MsgBox("Data Registrasi Surat berhasil ditambahkan", MsgBoxStyle.Information, "Registrasi Surat")
                        End If
                    ElseIf CBKategori.Text = "Keluar" Then
                        Dim quey As String
                        Dim tgl As String

                        tgl = Format(Tanggal.Value, "yyyy-M-dd")

                        quey = "SELECT * FROM surat_keluar WHERE no_surat = '" & TBNoS.Text & "' and kategori = '" & CBKategori.Text & "'"
                        dtab = koneksi.ExecuteQuery(quey)
                        If dtab.Rows.Count > 0 Then
                            MsgBox("No Surat telah terdaftar sebelumnya silahkan periksa kembali", MsgBoxStyle.Critical, "Registrasi Surat")
                            TBNoS.Focus()
                        Else
                            mycmd.Connection = myconnection.open()
                            mycmd.CommandText = "INSERT INTO surat_keluar (id, no_surat, perihal, waktu_kegiatan, jenis_surat, kategori, tanggal, keterangan) values ('', '" & TBNoS.Text & "', '" & TBPerihal.Text & "', '" & TBWK.Text & "', '" & CBJS.Text & "', '" & CBKategori.Text & "', '" & tgl & "', '" & RTBKeterangan.Text & "')"
                            mycmd.ExecuteNonQuery()
                            myconnection.close()
                            LVSurat.Items.Clear()
                            bersih()
                            bacalv()
                            MsgBox("Data Registrasi Surat berhasil ditambahkan", MsgBoxStyle.Information, "Registrasi Surat")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUbah.Click
        If TBNoS.Text = vbNullString Then
            MsgBox("Silahkan isi No Surat terlebih dahulu", MsgBoxStyle.Critical, "Registrasi Surat")
            TBNoS.Focus()
        Else
            If CBJS.Text = vbNullString Then
                MsgBox("Silahkan pilih Jenis Surat terlebih dahulu", MsgBoxStyle.Critical, "Registrasi Surat")
                CBJS.Focus()
            Else
                If CBKategori.Text = vbNullString Then
                    MsgBox("Silahkan pilih Kategori Surat terlebih dahulu", MsgBoxStyle.Critical, "Registrasi Surat")
                    CBKategori.Focus()
                Else
                    If CBKategori.Text = "Masuk" Then
                        Dim query As String
                        Dim tgl As String

                        tgl = Format(Tanggal.Value, "yyyy-M-dd")

                        query = "SELECT * FROM surat_masuk WHERE no_surat = '" & TBNoS.Text & "' and kategori = '" & CBKategori.Text & "'"
                        dtab = koneksi.ExecuteQuery(query)
                        If dtab.Rows.Count = 0 Then
                            MsgBox("No Surat belum terdaftar silahkan periksa kembali", MsgBoxStyle.Critical, "Registrasi Surat")
                            TBNoS.Focus()
                        Else
                            Dim msg = MsgBox("Apakah Anda yakin ingin merubah data surat ini ?", MsgBoxStyle.YesNo, "Registrasi Surat")
                            If msg = Windows.Forms.DialogResult.Yes Then
                                mycmd.Connection = myconnection.open()
                                mycmd.CommandText = "update surat_masuk set no_surat = '" & TBNoS.Text & "', perihal = '" & TBPerihal.Text & "', waktu_kegiatan = '" & TBWK.Text & "', jenis_surat = '" & CBJS.Text & "', kategori = '" & CBKategori.Text & "', tanggal = '" & tgl & "', keterangan = '" & RTBKeterangan.Text & "' where id = '" & IDS.Text & "'"
                                mycmd.ExecuteNonQuery()
                                myconnection.close()
                                LVSurat.Items.Clear()
                                bersih()
                                bacalv()
                                MsgBox("Data Registrasi Surat berhasil diubah", MsgBoxStyle.Information, "Registrasi Surat")
                            ElseIf msg = Windows.Forms.DialogResult.No Then
                                TBNoS.Focus()
                            End If
                        End If
                    ElseIf CBKategori.Text = "Keluar" Then
                        Dim query As String
                        Dim tgl As String

                        tgl = Format(Tanggal.Value, "yyyy-M-dd")

                        query = "SELECT * FROM surat_keluar WHERE no_surat = '" & TBNoS.Text & "' and kategori = '" & CBKategori.Text & "'"
                        dtab = koneksi.ExecuteQuery(query)
                        If dtab.Rows.Count = 0 Then
                            MsgBox("No Surat belum terdaftar silahkan periksa kembali", MsgBoxStyle.Critical, "Registrasi Surat")
                            TBNoS.Focus()
                        Else
                            Dim msg = MsgBox("Apakah Anda yakin ingin merubah data surat ini ?", MsgBoxStyle.YesNo, "Registrasi Surat")
                            If msg = Windows.Forms.DialogResult.Yes Then
                                mycmd.Connection = myconnection.open()
                                mycmd.CommandText = "update surat_keluar set no_surat = '" & TBNoS.Text & "', perihal = '" & TBPerihal.Text & "', waktu_kegiatan = '" & TBWK.Text & "', jenis_surat = '" & CBJS.Text & "', kategori = '" & CBKategori.Text & "', tanggal = '" & tgl & "', keterangan = '" & RTBKeterangan.Text & "' where id = '" & IDS.Text & "'"
                                mycmd.ExecuteNonQuery()
                                myconnection.close()
                                LVSurat.Items.Clear()
                                bersih()
                                bacalv()
                                MsgBox("Data Registrasi Surat berhasil diubah", MsgBoxStyle.Information, "Registrasi Surat")
                            ElseIf msg = Windows.Forms.DialogResult.No Then
                                TBNoS.Focus()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IDS.Text = vbNullString Then
            MsgBox("Silahkan pilih data Registrasi Surat yang akan Anda Hapus !", MsgBoxStyle.Critical, "Registrasi Surat")
        Else
            Dim msg = MsgBox("Apakah Anda yakin ingin menghapus data surat ini ?", MsgBoxStyle.YesNo, "Registrasi Surat")
            If msg = Windows.Forms.DialogResult.Yes Then
                If CBKategori.Text = "Masuk" Then
                    mycmd.Connection = myconnection.open()
                    mycmd.CommandText = "delete from surat_masuk where id = '" & IDS.Text & "'"
                    mycmd.ExecuteNonQuery()
                    myconnection.close()
                    LVSurat.Items.Clear()
                    bersih()
                    bacalv()
                    MsgBox("Data Registrasi Surat berhasil dihapus", MsgBoxStyle.Information, "Registrasi Surat")
                ElseIf CBKategori.Text = "Keluar" Then
                    mycmd.Connection = myconnection.open()
                    mycmd.CommandText = "delete from surat_keluar where id = '" & IDS.Text & "'"
                    mycmd.ExecuteNonQuery()
                    myconnection.close()
                    LVSurat.Items.Clear()
                    bersih()
                    bacalv()
                    MsgBox("Data Registrasi Surat berhasil dihapus", MsgBoxStyle.Information, "Registrasi Surat")
                End If
            ElseIf msg = Windows.Forms.DialogResult.No Then
                TBNoS.Focus()
            End If
        End If
    End Sub

    Private Sub BKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BKembali.Click
        Me.Close()
        FRDashboard.Show()
    End Sub

    Private Sub LVSurat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVSurat.SelectedIndexChanged
        kliklv()
    End Sub

    Private Sub FRRegSur_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FRDashboard.Show()
        Hide()
    End Sub

    Private Sub FRRegSur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bacalv()
        bacacb()
        MaximizeBox = False
    End Sub

    Private Sub TBNoS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBNoS.KeyDown
        If e.KeyCode = Keys.Enter Then
            TBPerihal.Focus()
        End If
    End Sub

    Private Sub TBPerihal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBPerihal.KeyDown
        If e.KeyCode = Keys.Enter Then
            TBWK.Focus()
        End If
    End Sub

    Private Sub TBWK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBWK.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBJS.Focus()
        End If
    End Sub

    Private Sub CBJS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBJS.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBKategori.Focus()
        End If
    End Sub

    Private Sub CBKategori_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBKategori.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tanggal.Focus()
        End If
    End Sub

    Private Sub Tanggal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tanggal.KeyDown
        If e.KeyCode = Keys.Enter Then
            RTBKeterangan.Focus()
        End If
    End Sub

End Class