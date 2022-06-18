Imports MySql.Data.MySqlClient

Public Class FRDafNIK
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
        mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat order by no_kk"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LVDafNIK.Items.Add(objreader.Item("no_kk").ToString)
            isi.SubItems.Add(objreader.Item("nama").ToString)
            isi.SubItems.Add(objreader.Item("nik").ToString)
            isi.SubItems.Add(objreader.Item("alamat").ToString)
            isi.SubItems.Add("" & objreader.Item("kampung").ToString & " " & objreader.Item("no_rt").ToString & "/" & objreader.Item("no_rw").ToString & "")
        End While
        myconnection.close()
    End Sub

    Sub kliklv()
        Dim index As Integer
        If LVDafNIK.SelectedItems.Count = 0 Then Exit Sub
        With LVDafNIK
            index = .SelectedIndices(0)
            TBKK.Text = .Items(index).Text
            TBNama.Text = .Items(index).SubItems(1).Text
            TBNIK.Text = .Items(index).SubItems(2).Text
            IDAlamat.Text = .Items(index).SubItems(3).Text
            TBAlamat.Text = .Items(index).SubItems(4).Text

            Dim nik As String = .Items(index).SubItems(2).Text

            mycmd.Connection = myconnection.open()
            mycmd.CommandText = "select * from tabel_nik where nik = '" & nik & "'"
            objreader = mycmd.ExecuteReader
            While objreader.Read
                CBWN.Text = objreader.Item("kewarganegaraan").ToString
                TBTeL.Text = objreader.Item("tempat_lahir").ToString
                TaL.Text = objreader.Item("tanggal_lahir").ToString
                CBJK.Text = objreader.Item("jenis_kelamin").ToString
                CBAgama.Text = objreader.Item("agama").ToString
                CBSK.Text = objreader.Item("status_kawin").ToString
                CBPendidikan.Text = objreader.Item("pendidikan").ToString
                CBHK.Text = objreader.Item("hub_keluarga").ToString
                CBKerja.Text = objreader.Item("pekerjaan").ToString
                TBAyah.Text = objreader.Item("nama_ayah").ToString
                TBIbu.Text = objreader.Item("nama_ibu").ToString
            End While
            myconnection.close()
        End With
    End Sub

    Sub bacalvAlamat()
        Dim isi As ListViewItem

        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "select * from tabel_rt"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LVAlamat.Items.Add(objreader.Item("id").ToString)
            isi.SubItems.Add("" & objreader.Item("kampung").ToString & " " & objreader.Item("no_rt").ToString & "/" & objreader.Item("no_rw").ToString & "")
        End While
        myconnection.close()
    End Sub

    Sub kliklvAlamat()
        Dim index As Integer
        If LVAlamat.SelectedItems.Count = 0 Then Exit Sub
        With LVAlamat
            index = .SelectedIndices(0)
            IDAlamat.Text = .Items(index).Text
            TBAlamat.Text = .Items(index).SubItems(1).Text
        End With
    End Sub

    Sub bacacb()
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

        CBHK.Items.Add("KEPALA KELUARGA")
        CBHK.Items.Add("ISTRI")
        CBHK.Items.Add("ANAK")
        CBHK.Items.Add("SAUDARA")
        CBHK.Items.Add("IBU")
        CBHK.Items.Add("AYAH")
        CBHK.Items.Add("AYAH MERTUA")
        CBHK.Items.Add("IBU MERTUA")
        CBPendidikan.Items.Add("BELUM SEKOLAH")
        CBPendidikan.Items.Add("TIDAK SEKOLAH")
        CBPendidikan.Items.Add("SD/SEDERAJAT")
        CBPendidikan.Items.Add("SLTP/SEDERAJAT")
        CBPendidikan.Items.Add("SLTA/SEDERAJAT")
        CBPendidikan.Items.Add("D3")
        CBPendidikan.Items.Add("S1")
        CBPendidikan.Items.Add("S2")
        CBPendidikan.Items.Add("S3")
    End Sub


    Sub bersih()
        TBKK.Text = ""
        TBNIK.Text = ""
        TBNama.Text = ""
        CBWN.Text = ""
        TBTeL.Text = ""
        TBAlamat.Text = ""
        CBJK.Text = ""
        CBAgama.Text = ""
        CBSK.Text = ""
        CBPendidikan.Text = ""
        CBHK.Text = ""
        CBKerja.Text = ""
        TBAyah.Text = ""
        TBIbu.Text = ""
        TBKK.Focus()
    End Sub

#End Region

    Private Sub LVDafNIK_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVDafNIK.SelectedIndexChanged
        kliklv()
    End Sub

    Private Sub LVAlamat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVAlamat.SelectedIndexChanged
        kliklvAlamat()
    End Sub

    Private Sub BCariKK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCariKK.Click
        Dim isi As ListViewItem

        LVDafNIK.Items.Clear()
        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat where no_kk like '%" & TBKK.Text & "%'"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LVDafNIK.Items.Add(objreader.Item("no_kk").ToString)
            isi.SubItems.Add(objreader.Item("nama").ToString)
            isi.SubItems.Add(objreader.Item("nik").ToString)
            isi.SubItems.Add(objreader.Item("alamat").ToString)
            isi.SubItems.Add("" & objreader.Item("kampung").ToString & " " & objreader.Item("no_rt").ToString & "/" & objreader.Item("no_rw").ToString & "")
        End While
        myconnection.close()
    End Sub

    Private Sub BCariNIK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCariNIK.Click
        Dim isi As ListViewItem

        LVDafNIK.Items.Clear()
        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat where nik like '%" & TBNIK.Text & "%'"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LVDafNIK.Items.Add(objreader.Item("no_kk").ToString)
            isi.SubItems.Add(objreader.Item("nama").ToString)
            isi.SubItems.Add(objreader.Item("nik").ToString)
            isi.SubItems.Add(objreader.Item("alamat").ToString)
            isi.SubItems.Add("" & objreader.Item("kampung").ToString & " " & objreader.Item("no_rt").ToString & "/" & objreader.Item("no_rw").ToString & "")
        End While
        myconnection.close()
    End Sub

    Private Sub BCariNama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCariNama.Click
        Dim isi As ListViewItem

        LVDafNIK.Items.Clear()
        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat where nama like '%" & TBNama.Text & "%'"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LVDafNIK.Items.Add(objreader.Item("no_kk").ToString)
            isi.SubItems.Add(objreader.Item("nama").ToString)
            isi.SubItems.Add(objreader.Item("nik").ToString)
            isi.SubItems.Add(objreader.Item("alamat").ToString)
            isi.SubItems.Add("" & objreader.Item("kampung").ToString & " " & objreader.Item("no_rt").ToString & "/" & objreader.Item("no_rw").ToString & "")
        End While
        myconnection.close()
    End Sub

    Private Sub BTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTambah.Click
        If TBNIK.Text = vbNullString Then
            MsgBox("Silahkan isi NIK terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
            TBNIK.Focus()
        Else
            If TBKK.Text = vbNullString Then
                MsgBox("Silahkan isi Nomor Kartu Keluarga (KK) terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                TBKK.Focus()
            Else
                If TBNama.Text = vbNullString Then
                    MsgBox("Silahkan isi Nama terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                    TBNama.Focus()
                Else
                    If CBWN.Text = vbNullString Then
                        MsgBox("Silahkan isi Kewarganegaraan terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                        CBWN.Focus()
                    Else
                        If TBTeL.Text = vbNullString Then
                            MsgBox("Silahkan isi Tempat Lahir terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                            TBTeL.Focus()
                        Else
                            If CBJK.Text = vbNullString Then
                                MsgBox("Silahkan pilih Jenis Kelamin terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                CBJK.Focus()
                            Else
                                If TBAlamat.Text = vbNullString Then
                                    MsgBox("Silahkan isi Alamat dengan cara Memilih Alamat terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                    TBAlamat.Focus()
                                Else
                                    If CBAgama.Text = vbNullString Then
                                        MsgBox("Silahkan pilih Agama terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                        CBAgama.Focus()
                                    Else
                                        If CBSK.Text = vbNullString Then
                                            MsgBox("Silahkan pilih Status Kawin terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                            CBSK.Focus()
                                        Else
                                            If CBPendidikan.Text = vbNullString Then
                                                MsgBox("Silahkan pilih Pendidikan terakhir terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                                CBPendidikan.Focus()
                                            Else
                                                If CBKerja.Text = vbNullString Then
                                                    MsgBox("Silahkan pilih Pekerjaan terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                                    CBKerja.Focus()
                                                Else
                                                    If CBHK.Text = vbNullString Then
                                                        MsgBox("Silahkan pilih Hubungan Keluarga terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                                        CBHK.Focus()
                                                    Else
                                                        If TBAyah.Text = vbNullString Then
                                                            MsgBox("Silahkan isi Nama Ayah terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                                            TBAyah.Focus()
                                                        Else
                                                            If TBIbu.Text = vbNullString Then
                                                                MsgBox("Silahkan isi Nama Ibu terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                                                TBIbu.Focus()
                                                            Else
                                                                If IDAlamat.Text = vbNullString Then
                                                                    MsgBox("Silahkan pilih Alamat terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                                                    TBAlamat.Focus()
                                                                Else
                                                                    If TBKK.TextLength < 16 Then
                                                                        MsgBox("Nomor Kartu Keluarga yang dimasukkan kurang dari 16 karakter. Silahkan isi Nomor Kartu Keluarga (KK) dengan benar (harus 16 karakter)", MsgBoxStyle.Critical, "Daftar NIK")
                                                                        TBKK.Focus()
                                                                    Else
                                                                        If TBNIK.TextLength < 16 Then
                                                                            MsgBox("NIK yang dmasukkan kurang dari 16 karakter. Silahkan isi NIK dengan benar (harus 16 karakter)", MsgBoxStyle.Critical, "Daftar NIK")
                                                                            TBNIK.Focus()
                                                                        Else
                                                                            Dim query As String

                                                                            query = "SELECT * FROM tabel_nik WHERE nik = '" & TBNIK.Text & "'"
                                                                            dtab = koneksi.ExecuteQuery(query)
                                                                            If dtab.Rows.Count > 0 Then
                                                                                MsgBox("No NIK sudah terdaftar silahkan periksa kembali", MsgBoxStyle.Critical, "Daftar NIK")
                                                                                TBNIK.Focus()
                                                                            Else
                                                                                Dim quey As String
                                                                                Dim tanggal As String
                                                                                Dim tgl As Date = Today
                                                                                Dim nama As String = UCase(TBNama.Text)
                                                                                Dim tempat_lahir As String = UCase(TBTeL.Text)
                                                                                Dim nama_ayah As String = UCase(TBAyah.Text)
                                                                                Dim nama_ibu As String = UCase(TBIbu.Text)
                                                                                Dim tang As String

                                                                                tang = Format(TaL.Value, "yyyy-M-dd")
                                                                                tanggal = Format(TaL.Value, "yyyy-M-dd")

                                                                                quey = "SELECT * FROM tabel_kk WHERE no_kk = '" & TBKK.Text & "'"
                                                                                dtab = koneksi.ExecuteQuery(quey)
                                                                                If dtab.Rows.Count = 0 Then
                                                                                    mycmd.Connection = myconnection.open()
                                                                                    mycmd.CommandText = "INSERT INTO tabel_kk (no_kk, kepala_keluarga, jenis_kk, waktu) values ('" & TBKK.Text & "', '" & nama & "', 'Baru', '" & tang & "')"
                                                                                    mycmd.ExecuteNonQuery()
                                                                                    myconnection.close()
                                                                                    MsgBox("Data KK berhasil ditambahkan", MsgBoxStyle.Information, "Daftar NIK")

                                                                                    mycmd.Connection = myconnection.open()
                                                                                    mycmd.CommandText = "INSERT INTO tabel_nik (nik, nama, tempat_lahir, tanggal_lahir, jenis_kelamin, kewarganegaraan, agama, status_kawin, pendidikan, pekerjaan, hub_keluarga, nama_ayah, nama_ibu, alamat, no_kk) values ('" & TBNIK.Text & "', '" & nama & "', '" & tempat_lahir & "', '" & tanggal & "', '" & CBJK.Text & "', '" & CBWN.Text & "', '" & CBAgama.Text & "', '" & CBSK.Text & "', '" & CBPendidikan.Text & "', '" & CBKerja.Text & "', '" & CBHK.Text & "', '" & nama_ayah & "', '" & nama_ibu & "', '" & IDAlamat.Text & "', '" & TBKK.Text & "')"
                                                                                    mycmd.ExecuteNonQuery()
                                                                                    myconnection.close()
                                                                                    LVDafNIK.Items.Clear()
                                                                                    bersih()
                                                                                    bacalv()
                                                                                    MsgBox("Data NIK berhasil ditambahkan", MsgBoxStyle.Information, "Daftar NIK")
                                                                                Else
                                                                                    mycmd.Connection = myconnection.open()
                                                                                    mycmd.CommandText = "INSERT INTO tabel_nik (nik, nama, tempat_lahir, tanggal_lahir, jenis_kelamin, kewarganegaraan, agama, status_kawin, pendidikan, pekerjaan, hub_keluarga, nama_ayah, nama_ibu, alamat, no_kk) values ('" & TBNIK.Text & "', '" & nama & "', '" & tempat_lahir & "', '" & tanggal & "', '" & CBJK.Text & "', '" & CBWN.Text & "', '" & CBAgama.Text & "', '" & CBSK.Text & "', '" & CBPendidikan.Text & "', '" & CBKerja.Text & "', '" & CBHK.Text & "', '" & nama_ayah & "', '" & nama_ibu & "', '" & IDAlamat.Text & "', '" & TBKK.Text & "')"
                                                                                    mycmd.ExecuteNonQuery()
                                                                                    myconnection.close()
                                                                                    LVDafNIK.Items.Clear()
                                                                                    bersih()
                                                                                    bacalv()
                                                                                    MsgBox("Data NIK berhasil ditambahkan", MsgBoxStyle.Information, "Daftar NIK")
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

    Private Sub BUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUbah.Click
        If TBNIK.Text = vbNullString Then
            MsgBox("Silahkan isi NIK terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
            TBNIK.Focus()
        Else
            If TBKK.Text = vbNullString Then
                MsgBox("Silahkan isi No Kartu Keluarga (KK) terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                TBKK.Focus()
            Else
                If TBNama.Text = vbNullString Then
                    MsgBox("Silahkan isi Nama terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                    TBNama.Focus()
                Else
                    If CBWN.Text = vbNullString Then
                        MsgBox("Silahkan isi Kewarganegaraan terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                        CBWN.Focus()
                    Else
                        If TBTeL.Text = vbNullString Then
                            MsgBox("Silahkan isi Tempat Lahir terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                            TBTeL.Focus()
                        Else
                            If CBJK.Text = vbNullString Then
                                MsgBox("Silahkan pilih Jenis Kelamin terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                CBJK.Focus()
                            Else
                                If TBAlamat.Text = vbNullString Then
                                    MsgBox("Silahkan isi Alamat terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                    TBAlamat.Focus()
                                Else
                                    If CBAgama.Text = vbNullString Then
                                        MsgBox("Silahkan pilih Agama terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                        CBAgama.Focus()
                                    Else
                                        If CBSK.Text = vbNullString Then
                                            MsgBox("Silahkan pilih Status Kawin terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                            CBSK.Focus()
                                        Else
                                            If CBPendidikan.Text = vbNullString Then
                                                MsgBox("Silahkan pilih Pendidikan terakhir terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                                CBPendidikan.Focus()
                                            Else
                                                If CBKerja.Text = vbNullString Then
                                                    MsgBox("Silahkan pilih Pekerjaan terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                                    CBKerja.Focus()
                                                Else
                                                    If CBHK.Text = vbNullString Then
                                                        MsgBox("Silahkan pilih Hubungan Keluarga terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                                        CBHK.Focus()
                                                    Else
                                                        If TBAyah.Text = vbNullString Then
                                                            MsgBox("Silahkan isi Nama Ayah terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                                            TBAyah.Focus()
                                                        Else
                                                            If TBIbu.Text = vbNullString Then
                                                                MsgBox("Silahkan isi Nama Ibu terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                                                TBIbu.Focus()
                                                            Else
                                                                If IDAlamat.Text = vbNullString Then
                                                                    MsgBox("Silahkan pilih Alamat terlebih dahulu", MsgBoxStyle.Critical, "Daftar NIK")
                                                                    TBAlamat.Focus()
                                                                Else
                                                                    If TBKK.TextLength < 16 Then
                                                                        MsgBox("Nomor Kartu Keluarga yang dimasukkan kurang dari 16 karakter. Silahkan isi Nomor Kartu Keluarga (KK) dengan benar (harus 16 karakter)", MsgBoxStyle.Critical, "Daftar NIK")
                                                                        TBKK.Focus()
                                                                    Else
                                                                        If TBNIK.TextLength < 16 Then
                                                                            MsgBox("NIK yang dmasukkan kurang dari 16 karakter. Silahkan isi NIK dengan benar (harus 16 karakter)", MsgBoxStyle.Critical, "Daftar NIK")
                                                                            TBNIK.Focus()
                                                                        Else
                                                                            Dim query As String

                                                                            query = "SELECT * FROM tabel_nik WHERE nik = '" & TBNIK.Text & "'"
                                                                            dtab = koneksi.ExecuteQuery(query)
                                                                            If dtab.Rows.Count = 0 Then
                                                                                MsgBox("No NIK belum terdaftar silahkan periksa kembali", MsgBoxStyle.Critical, "Daftar NIK")
                                                                                TBNIK.Focus()
                                                                            Else
                                                                                Dim msg = MsgBox("Apakah Anda yakin ingin merubah data NIK ini ?", MsgBoxStyle.YesNo, "Daftar NIK")
                                                                                If msg = Windows.Forms.DialogResult.Yes Then
                                                                                    Dim quey As String
                                                                                    Dim tgl As Date = Today
                                                                                    Dim tanggal As String
                                                                                    Dim nama As String = UCase(TBNama.Text)
                                                                                    Dim tempat_lahir As String = UCase(TBTeL.Text)
                                                                                    Dim nama_ayah As String = UCase(TBAyah.Text)
                                                                                    Dim nama_ibu As String = UCase(TBIbu.Text)
                                                                                    Dim tang As String

                                                                                    tang = Format(tgl, "yyyy-M-dd")
                                                                                    tanggal = Format(TaL.Value, "yyyy-M-dd")

                                                                                    quey = "SELECT * FROM tabel_kk WHERE no_kk = '" & TBKK.Text & "'"
                                                                                    dtab = koneksi.ExecuteQuery(quey)
                                                                                    If dtab.Rows.Count = 0 Then
                                                                                        mycmd.Connection = myconnection.open()
                                                                                        mycmd.CommandText = "INSERT INTO tabel_kk (no_kk, kepala_keluarga, jenis_kk, waktu) values ('" & TBKK.Text & "', '" & nama & "', 'Baru', '" & tang & "')"
                                                                                        mycmd.ExecuteNonQuery()
                                                                                        myconnection.close()
                                                                                        MsgBox("Data KK berhasil ditambahkan", MsgBoxStyle.Information, "Daftar NIK")

                                                                                        mycmd.Connection = myconnection.open()
                                                                                        mycmd.CommandText = "UPDATE tabel_nik set nama = '" & nama & "', tempat_lahir = '" & tempat_lahir & "', tanggal_lahir = '" & tanggal & "', jenis_kelamin = '" & CBJK.Text & "', kewarganegaraan = '" & CBWN.Text & "', agama = '" & CBAgama.Text & "', status_kawin = '" & CBSK.Text & "', pendidikan = '" & CBPendidikan.Text & "', pekerjaan = '" & CBKerja.Text & "', hub_keluarga = '" & CBHK.Text & "', nama_ayah = '" & nama_ayah & "', nama_ibu = '" & nama_ibu & "', alamat = '" & IDAlamat.Text & "', no_kk = '" & TBKK.Text & "' where nik = '" & TBNIK.Text & "'"
                                                                                        mycmd.ExecuteNonQuery()
                                                                                        myconnection.close()
                                                                                        LVDafNIK.Items.Clear()
                                                                                        bersih()
                                                                                        bacalv()
                                                                                        MsgBox("Data NIK berhasil diubah", MsgBoxStyle.Information, "Daftar NIK")
                                                                                    Else
                                                                                        mycmd.Connection = myconnection.open()
                                                                                        mycmd.CommandText = "UPDATE tabel_nik set nama = '" & nama & "', tempat_lahir = '" & tempat_lahir & "', tanggal_lahir = '" & tanggal & "', jenis_kelamin = '" & CBJK.Text & "', kewarganegaraan = '" & CBWN.Text & "', agama = '" & CBAgama.Text & "', status_kawin = '" & CBSK.Text & "', pendidikan = '" & CBPendidikan.Text & "', pekerjaan = '" & CBKerja.Text & "', hub_keluarga = '" & CBHK.Text & "', nama_ayah = '" & nama_ayah & "', nama_ibu = '" & nama_ibu & "', alamat = '" & IDAlamat.Text & "', no_kk = '" & TBKK.Text & "' where nik = '" & TBNIK.Text & "'"
                                                                                        mycmd.ExecuteNonQuery()
                                                                                        myconnection.close()
                                                                                        LVDafNIK.Items.Clear()
                                                                                        bersih()
                                                                                        bacalv()
                                                                                        MsgBox("Data NIK berhasil diubah", MsgBoxStyle.Information, "Daftar NIK")
                                                                                    End If
                                                                                ElseIf msg = Windows.Forms.DialogResult.No Then
                                                                                    TBNIK.Focus()
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

    Private Sub BHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHapus.Click
        If TBNIK.Text = vbNullString Then
            MsgBox("Silahkan pilih data Penduduk yang akan Anda Hapus !", MsgBoxStyle.Critical, "Registrasi Surat")
        Else
            Dim msg = MsgBox("Apakah Anda yakin ingin menghapus data penduduk ini ?", MsgBoxStyle.YesNo, "Daftar NIK")
            If msg = Windows.Forms.DialogResult.Yes Then
                Dim query As String

                query = "SELECT * FROM tabel_nik WHERE no_kk = '" & TBKK.Text & "'"
                dtab = koneksi.ExecuteQuery(query)
                If dtab.Rows.Count > 1 Then
                    mycmd.Connection = myconnection.open()
                    mycmd.CommandText = "delete from tabel_nik where nik = '" & TBNIK.Text & "'"
                    mycmd.ExecuteNonQuery()
                    myconnection.close()
                    LVDafNIK.Items.Clear()
                    bersih()
                    bacalv()
                    MsgBox("Data NIK berhasil dihapus", MsgBoxStyle.Information, "Daftar NIK")
                ElseIf dtab.Rows.Count = 1 Then
                    mycmd.Connection = myconnection.open()
                    mycmd.CommandText = "delete from tabel_nik where nik = '" & TBNIK.Text & "'"
                    mycmd.ExecuteNonQuery()
                    myconnection.close()
                    LVDafNIK.Items.Clear()
                    bersih()
                    bacalv()

                    mycmd.Connection = myconnection.open()
                    mycmd.CommandText = "delete from tabel_kk where no_kk = '" & TBKK.Text & "'"
                    mycmd.ExecuteNonQuery()
                    myconnection.close()

                    MsgBox("Data NIK berhasil dihapus", MsgBoxStyle.Information, "Daftar NIK")
                End If
            ElseIf msg = Windows.Forms.DialogResult.No Then
                TBNIK.Focus()
            End If
        End If
    End Sub

    Private Sub BKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BKembali.Click
        Me.Close()
        FRDashboard.Show()
    End Sub

    Private Sub FRDafNIK_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FRDashboard.Show()
        Hide()
    End Sub

    Private Sub FRDafNIK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bacalv()
        bacalvAlamat()
        bacacb()
        MaximizeBox = False
    End Sub

    Private Sub TBKK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBKK.KeyDown
        If e.KeyCode = Keys.Enter Then
            TBNIK.Focus()
        End If
    End Sub

    Private Sub TBNIK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBNIK.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBWN.Focus()
        End If
    End Sub

    Private Sub CBWN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBWN.KeyDown
        If e.KeyCode = Keys.Enter Then
            TBNama.Focus()
        End If
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
            CBJK.Focus()
        End If
    End Sub

    Private Sub CBJK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBJK.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBAgama.Focus()
        End If
    End Sub

    Private Sub CBAgama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBAgama.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBSK.Focus()
        End If
    End Sub

    Private Sub CBSK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBSK.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBPendidikan.Focus()
        End If
    End Sub

    Private Sub CBPendidikan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBPendidikan.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBHK.Focus()
        End If
    End Sub

    Private Sub CBHK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBHK.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBKerja.Focus()
        End If
    End Sub

    Private Sub CBKerja_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBKerja.KeyDown
        If e.KeyCode = Keys.Enter Then
            TBAyah.Focus()
        End If
    End Sub

    Private Sub TBAyah_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBAyah.KeyDown
        If e.KeyCode = Keys.Enter Then
            TBIbu.Focus()
        End If
    End Sub

    Private Sub TBIbu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBIbu.KeyDown
        If e.KeyCode = Keys.Enter Then
            LVAlamat.Focus()
        End If
    End Sub

    Private Sub TBNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBNama.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" Or e.KeyChar = vbBack) Then
            keyAscii = 0
        Else
            e.Handled = CBool(keyAscii)
        End If
    End Sub

    Private Sub TBAyah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBAyah.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" Or e.KeyChar = vbBack) Then
            keyAscii = 0
        Else
            e.Handled = CBool(keyAscii)
        End If
    End Sub

    Private Sub TBIbu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBIbu.KeyPress
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

    Private Sub TBTeL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBTeL.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" Or e.KeyChar = vbBack) Then
            keyAscii = 0
        Else
            e.Handled = CBool(keyAscii)
        End If
    End Sub

    Private Sub TBKK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBKK.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TBNIK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBNIK.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

End Class