Imports MySql.Data.MySqlClient

Public Class FRLogin

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

    Sub login()
        Dim query As String
        Dim que As String

        que = "SELECT * FROM users WHERE username = '" & TBUsername.Text & "'"
        dtab = koneksi.ExecuteQuery(que)
        If dtab.Rows.Count = 0 Then
            MsgBox("Username yang dimasukkan tidak dapat ditemukan", MsgBoxStyle.Critical, "Login")
            TBUsername.Focus()
        Else
            query = "SELECT * FROM users WHERE username = '" & TBUsername.Text & "' AND password = '" & TBPassword.Text & "'"
            dtab = koneksi.ExecuteQuery(query)
            If dtab.Rows.Count = 0 Then
                MsgBox("Password yang dimasukkan tidak sesuai", MsgBoxStyle.Critical, "Login")
                TBPassword.Focus()
            Else
                Me.Close()
                FRDashboard.Show()
            End If
        End If
    End Sub

    Private Sub BBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBatal.Click
        Me.Close()
        FRAwal.Show()
    End Sub

    Private Sub BLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLogin.Click
        login()
    End Sub

    Private Sub TBUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            TBPassword.Focus()
        End If
    End Sub

    Private Sub TBPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
End Class