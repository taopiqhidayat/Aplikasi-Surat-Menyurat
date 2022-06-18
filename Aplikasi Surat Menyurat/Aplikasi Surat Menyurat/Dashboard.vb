Imports MySql.Data.MySqlClient

Public Class FRDashboard
#Region "Deklarasi"
    Dim koneksi As New ClassKoneksi
    Dim dtab As New DataTable
    Dim datab As New DataTable
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
        mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LVDafDD.Items.Add(objreader.Item("nik").ToString)
            isi.SubItems.Add(objreader.Item("nama").ToString)
            isi.SubItems.Add("" & objreader.Item("kampung").ToString & " " & objreader.Item("no_rt").ToString & "/" & objreader.Item("no_rw").ToString & "")
        End While
        myconnection.close()
    End Sub

    Sub kliklv()
        Dim index As Integer
        If LVDafDD.SelectedItems.Count = 0 Then Exit Sub
        With LVDafDD
            index = .SelectedIndices(0)
            TBNIK.Text = .Items(index).Text
            TBNama.Text = .Items(index).SubItems(1).Text
        End With
    End Sub

    Sub bacalvot()
        Dim isi As ListViewItem
        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LVDafOt.Items.Add(objreader.Item("nik").ToString)
            isi.SubItems.Add(objreader.Item("nama").ToString)
            isi.SubItems.Add("" & objreader.Item("kampung").ToString & " " & objreader.Item("no_rt").ToString & "/" & objreader.Item("no_rw").ToString & "")
        End While
        myconnection.close()
    End Sub

    Sub kliklvot()
        Dim index As Integer
        If LVDafOt.SelectedItems.Count = 0 Then Exit Sub
        With LVDafOt
            index = .SelectedIndices(0)
            TBNIKOt.Text = .Items(index).Text
            TBNamaOt.Text = .Items(index).SubItems(1).Text
        End With
    End Sub

    Sub bersih()
        TBNIK.Clear()
        TBNama.Clear()
        TBNIKOt.Clear()
        TBNamaOt.Clear()
        TBNIK.Focus()
    End Sub
#End Region

    Private Sub LVDafDD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVDafDD.SelectedIndexChanged
        kliklv()
    End Sub

    Private Sub BDomisili_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDomisili.Click
        Dim query As String
        Dim nik As String
        Dim tel As String
        Dim tal As String

        query = "SELECT * FROM tabel_nik WHERE nik = '" & TBNIK.Text & "'"
        dtab = koneksi.ExecuteQuery(query)
        If dtab.Rows.Count = 0 Then
            Dim msg = MsgBox("Data tidak dapat ditemukan, apakah Anda akan mengisinya manual ?", MsgBoxStyle.YesNo, "Aplikasi Surat Menyurat!")
            If msg = Windows.Forms.DialogResult.Yes Then
                FRDomisili.TBNIK.Text = TBNIK.Text
                FRDomisili.TBNama.Text = TBNama.Text
                FRDomisili.TBNIK.Focus()
                Me.Hide()
                FRDomisili.Show()
            ElseIf msg = Windows.Forms.DialogResult.No Then
                TBNIK.Focus()
            End If
        Else
            nik = dtab.Rows(0).Item(1)
            mycmd.Connection = myconnection.open()
            mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat where nik = '" & TBNIK.Text & "'"
            objreader = mycmd.ExecuteReader
            objreader.Read()
            If objreader.HasRows Then
                tel = objreader.Item("tempat_lahir")

                tal = Format(objreader.Item("tanggal_lahir"), "dd-M-yyyy")

                FRDomisili.TBNIK.Text = "" & TBNIK.Text & ""
                FRDomisili.TBNama.Text = "" & objreader.Item("nama") & ""
                FRDomisili.TBTeL.Text = "" & tel & ""
                FRDomisili.TaL.Text = "" & tal & ""
                FRDomisili.CBWN.Text = "" & objreader.Item("kewarganegaraan") & ""
                FRDomisili.CBJK.Text = "" & objreader.Item("jenis_kelamin") & ""
                FRDomisili.CBSK.Text = "" & objreader.Item("status_kawin") & ""
                FRDomisili.CBSP.Text = "" & objreader.Item("pekerjaan") & ""
                FRDomisili.CBAgama.Text = "" & objreader.Item("agama") & ""
                FRDomisili.CBAlamat.Text = "" & objreader.Item("kampung") & " " & objreader.Item("no_rt") & "/" & objreader.Item("no_rw") & ""

            End If
            myconnection.close()
            FRDomisili.CBAgama.Focus()
            bersih()
            Me.Hide()
            FRDomisili.Show()
        End If
    End Sub

    Private Sub LVDafOt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVDafOt.SelectedIndexChanged
        kliklvot()
    End Sub

    Private Sub BSKTM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSKTM.Click
        Dim query As String
        Dim que As String
        Dim nik As String
        Dim tel As String
        Dim tal As String
        Dim telot As String
        Dim talot As String

        query = "SELECT * FROM tabel_nik WHERE nik = '" & TBNIK.Text & "'"
        dtab = koneksi.ExecuteQuery(query)
        que = "SELECT * FROM tabel_nik WHERE nik = '" & TBNIKOt.Text & "'"
        datab = koneksi.ExecuteQuery(que)
        If dtab.Rows.Count = 0 And datab.Rows.Count = 0 Then
            Dim msg = MsgBox("Data diri dan data orangtua tidak dapat ditemukan, apakah Anda akan mengisinya manual ?", MsgBoxStyle.YesNo, "Aplikasi Surat Menyurat!")
            If msg = Windows.Forms.DialogResult.Yes Then
                FRSKTM.TBNama.Text = TBNama.Text
                FRSKTM.TBNamaOt.Text = TBNamaOt.Text
                FRSKTM.TBNama.Focus()
                Me.Hide()
                FRSKTM.Show()
            ElseIf msg = Windows.Forms.DialogResult.No Then
                TBNIK.Focus()
            End If
        ElseIf datab.Rows.Count = 0 Then
            Dim msg = MsgBox("Data orangtua tidak dapat ditemukan, apakah Anda akan mengisinya manual ?", MsgBoxStyle.YesNo, "Aplikasi Surat Menyurat!")
            If msg = Windows.Forms.DialogResult.Yes Then
                nik = dtab.Rows(0).Item(1)
                mycmd.Connection = myconnection.open()
                mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat where nik = '" & TBNIK.Text & "'"
                objreader = mycmd.ExecuteReader
                objreader.Read()
                If objreader.HasRows Then
                    tel = objreader.Item("tempat_lahir")

                    tal = Format(objreader.Item("tanggal_lahir"), "dd-M-yyyy")

                    FRSKTM.TBNama.Text = "" & objreader.Item("nama") & ""
                    FRSKTM.TBTeL.Text = "" & tel & ""
                    FRSKTM.TaL.Text = "" & tal & ""
                    FRSKTM.CBKerja.Text = "" & objreader.Item("pekerjaan") & ""
                    FRSKTM.CBAgama.Text = "" & objreader.Item("agama") & ""
                    FRSKTM.CBAlamat.Text = "" & objreader.Item("kampung") & " " & objreader.Item("no_rt") & "/" & objreader.Item("no_rw") & ""

                End If
                myconnection.close()
                FRSKTM.TBNamaOt.Text = TBNamaOt.Text
                FRSKTM.TBNamaOt.Focus()
                bersih()
                Me.Hide()
                FRSKTM.Show()
            ElseIf msg = Windows.Forms.DialogResult.No Then
                TBNIKOt.Focus()
            End If
        ElseIf dtab.Rows.Count = 0 Then
            Dim msg = MsgBox("Data diri tidak dapat ditemukan, apakah Anda akan mengisinya manual ?", MsgBoxStyle.YesNo, "Aplikasi Surat Menyurat!")
            If msg = Windows.Forms.DialogResult.Yes Then
                nik = datab.Rows(0).Item(1)
                mycmd.Connection = myconnection.open()
                mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat where nik = '" & TBNIKOt.Text & "'"
                objreader = mycmd.ExecuteReader
                objreader.Read()
                If objreader.HasRows Then
                    telot = objreader.Item("tempat_lahir")

                    talot = Format(objreader.Item("tanggal_lahir"), "dd-M-yyyy")

                    FRSKTM.TBNamaOt.Text = "" & objreader.Item("nama") & ""
                    FRSKTM.TBTeLOt.Text = "" & telot & ""
                    FRSKTM.TaLOt.Text = "" & talot & ""
                    FRSKTM.CBKerjaOt.Text = "" & objreader.Item("pekerjaan") & ""
                    FRSKTM.CBAgamaOt.Text = "" & objreader.Item("agama") & ""
                    FRSKTM.CBAlamatOt.Text = "" & objreader.Item("kampung") & " " & objreader.Item("no_rt") & "/" & objreader.Item("no_rw") & ""

                End If
                myconnection.close()
                FRSKTM.TBNama.Text = TBNama.Text
                FRSKTM.TBNama.Focus()
                bersih()
                Me.Hide()
                FRSKTM.Show()
            ElseIf msg = Windows.Forms.DialogResult.No Then
                TBNIK.Focus()
            End If
        Else
            nik = dtab.Rows(0).Item(1)
            mycmd.Connection = myconnection.open()
            mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat where nik = '" & TBNIK.Text & "'"
            objreader = mycmd.ExecuteReader
            objreader.Read()
            If objreader.HasRows Then
                tel = objreader.Item("tempat_lahir")

                tal = Format(objreader.Item("tanggal_lahir"), "dd-M-yyyy")

                FRSKTM.TBNama.Text = "" & objreader.Item("nama") & ""
                FRSKTM.TBTeL.Text = "" & tel & ""
                FRSKTM.TaL.Text = "" & tal & ""
                FRSKTM.CBKerja.Text = "" & objreader.Item("pekerjaan") & ""
                FRSKTM.CBAgama.Text = "" & objreader.Item("agama") & ""
                FRSKTM.CBAlamat.Text = "" & objreader.Item("kampung") & " " & objreader.Item("no_rt") & "/" & objreader.Item("no_rw") & ""

            End If
            myconnection.close()

            nik = datab.Rows(0).Item(1)
            mycmd.Connection = myconnection.open()
            mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat where nik = '" & TBNIKOt.Text & "'"
            objreader = mycmd.ExecuteReader
            objreader.Read()
            If objreader.HasRows Then
                telot = objreader.Item("tempat_lahir")

                talot = Format(objreader.Item("tanggal_lahir"), "dd-M-yyyy")

                FRSKTM.TBNamaOt.Text = "" & objreader.Item("nama") & ""
                FRSKTM.TBTeLOt.Text = "" & telot & ""
                FRSKTM.TaLOt.Text = "" & talot & ""
                FRSKTM.CBKerjaOt.Text = "" & objreader.Item("pekerjaan") & ""
                FRSKTM.CBAgamaOt.Text = "" & objreader.Item("agama") & ""
                FRSKTM.CBAlamatOt.Text = "" & objreader.Item("kampung") & " " & objreader.Item("no_rt") & "/" & objreader.Item("no_rw") & ""

            End If
            myconnection.close()
            FRSKTM.CBAlamatOt.Focus()
            bersih()
            Me.Hide()
            FRSKTM.Show()
        End If
    End Sub

    Private Sub BRegSur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRegSur.Click
        bersih()
        Me.Hide()
        FRRegSur.Show()
    End Sub

    Private Sub BDNIK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDNIK.Click
        bersih()
        Me.Hide()
        FRDafNIK.Show()
    End Sub

    Private Sub BCariNama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCariNama.Click
        Dim isi As ListViewItem

        LVDafDD.Items.Clear()
        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat where nama like '%" & TBNama.Text & "%'"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LVDafDD.Items.Add(objreader.Item("nik").ToString)
            isi.SubItems.Add(objreader.Item("nama").ToString)
            isi.SubItems.Add("" & objreader.Item("kampung").ToString & " " & objreader.Item("no_rt").ToString & "/" & objreader.Item("no_rw").ToString & "")
        End While
        myconnection.close()
    End Sub

    Private Sub BCariNamaOt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCariNamaOt.Click
        Dim isi As ListViewItem

        LVDafOt.Items.Clear()
        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat where nama like '%" & TBNamaOt.Text & "%'"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LVDafOt.Items.Add(objreader.Item("nik").ToString)
            isi.SubItems.Add(objreader.Item("nama").ToString)
            isi.SubItems.Add("" & objreader.Item("kampung").ToString & " " & objreader.Item("no_rt").ToString & "/" & objreader.Item("no_rw").ToString & "")
        End While
        myconnection.close()
    End Sub

    Private Sub BCariNIK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCariNIK.Click
        Dim isi As ListViewItem

        LVDafDD.Items.Clear()
        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat where nik like '%" & TBNIK.Text & "%'"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LVDafDD.Items.Add(objreader.Item("nik").ToString)
            isi.SubItems.Add(objreader.Item("nama").ToString)
            isi.SubItems.Add("" & objreader.Item("kampung").ToString & " " & objreader.Item("no_rt").ToString & "/" & objreader.Item("no_rw").ToString & "")
        End While
        myconnection.close()
    End Sub

    Private Sub BCariNIKOt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCariNIKOt.Click
        Dim isi As ListViewItem

        LVDafOt.Items.Clear()
        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "select * from tabel_nik join tabel_rt on tabel_rt.id = tabel_nik.alamat where nik like '%" & TBNIKOt.Text & "%'"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LVDafOt.Items.Add(objreader.Item("nik").ToString)
            isi.SubItems.Add(objreader.Item("nama").ToString)
            isi.SubItems.Add("" & objreader.Item("kampung").ToString & " " & objreader.Item("no_rt").ToString & "/" & objreader.Item("no_rw").ToString & "")
        End While
        myconnection.close()
    End Sub

    Private Sub FRDashboard_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bacalv()
        Call bacalvot()
        MaximizeBox = False
    End Sub

    Private Sub BKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BKeluar.Click
        Dim msg = MsgBox("Apakah Anda yakin ingin KELUAR dari Apikasi Surat Menyurat ini ?", MsgBoxStyle.YesNo, "Aplikasi Surat Menyurat!")
        If msg = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            FRAwal.Show()
        ElseIf msg = Windows.Forms.DialogResult.No Then
            TBNIK.Focus()
        End If
    End Sub

    Private Sub TBNIK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBNIK.KeyDown
        If e.KeyCode = Keys.Enter Then
            TBNama.Focus()
        End If
    End Sub

    Private Sub TBNama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBNama.KeyDown
        If e.KeyCode = Keys.Enter Then
            TBNIKOt.Focus()
        End If
    End Sub

    Private Sub TBNIKOt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBNIKOt.KeyDown
        If e.KeyCode = Keys.Enter Then
            TBNamaOt.Focus()
        End If
    End Sub

    Private Sub TBNIK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBNIK.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TBNIKOt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBNIKOt.KeyPress
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

    Private Sub TBNamaOt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBNamaOt.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" Or e.KeyChar = vbBack) Then
            keyAscii = 0
        Else
            e.Handled = CBool(keyAscii)
        End If
    End Sub

    Private Sub FRDashboard_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FRAwal.Show()
        Hide()
    End Sub
End Class