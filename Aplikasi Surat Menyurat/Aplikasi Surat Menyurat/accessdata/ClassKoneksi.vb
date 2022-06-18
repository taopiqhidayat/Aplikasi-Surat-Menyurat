Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class ClassKoneksi
    Dim sql As String
    Dim cn As New MySqlConnection
    Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
    Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable

    Sub CobaOpenConn()
        cn = New MySqlConnection("server=localhost;user=root;password=;database=kutawaringin")
        Try
            cn.Open()
            MsgBox("Koneksi Berhasil Tersambung!")
        Catch ex As Exception
            MsgBox("Koneksi Gagal !!! " & vbCrLf & "Pesan Error : " & ex.Message, MsgBoxStyle.Critical, "Peringatan!")
        End Try
    End Sub
    Sub CobaCloseConn()
        Try
            If Not IsNothing(cn) Then
                cn.Close()
                cn = Nothing
                MsgBox("Koneksi Telah Terputus!")
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal Diputuskan")
        End Try
    End Sub
    Public Function OpenConn() As Boolean
        cn = New MySqlConnection("server=localhost;user=root;password=;database=kutawaringin")
        cn.Open()
        If cn.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub CloseConn()
        If Not IsNothing(cn) Then
            cn.Close()
            cn = Nothing
        End If
    End Sub
    Public Sub ExecuteNonQuery(ByVal query As String)
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal...!!!", MsgBoxStyle.Critical, "Access Failed...!!!")
            Exit Sub
        End If

        cmd = New MySql.Data.MySqlClient.MySqlCommand
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = query
        cmd.ExecuteNonQuery()
        cmd = Nothing
        CloseConn()
    End Sub
    Public Function ExecuteQuery(ByVal query As String) As DataTable
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal...!!!", MsgBoxStyle.Critical, "Access Failed...!!!")
            Return Nothing
            Exit Function
        End If

        cmd = New MySql.Data.MySqlClient.MySqlCommand(query, cn)
        da = New MySql.Data.MySqlClient.MySqlDataAdapter
        da.SelectCommand = cmd
        ds = New Data.DataSet
        da.Fill(ds)

        dt = ds.Tables(0)

        Return dt

        dt = Nothing
        ds = Nothing
        da = Nothing
        cmd = Nothing

        CloseConn()
    End Function
End Class