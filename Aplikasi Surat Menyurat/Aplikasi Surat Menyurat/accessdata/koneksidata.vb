Imports MySql.Data.MySqlClient

Public Class koneksidata
    Dim connect As New MySqlConnection("server=localhost;user=root;password=;database=kutawaringin")
    Public Function open() As MySqlConnection
        Try
            connect.Open()
        Catch ex As Exception
            MsgBox("Maaf Koneksi Error! :", ex.Message)
        End Try
        Return connect
    End Function

    Public Function close() As MySqlConnection
        Try
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connect
    End Function
End Class