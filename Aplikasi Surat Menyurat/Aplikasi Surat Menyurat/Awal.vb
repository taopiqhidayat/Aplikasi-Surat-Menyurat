Public Class FRAwal

    Private Sub BKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BKeluar.Click
        Dim msg = MsgBox("Apakah Anda yakin ingin benar - benar KELUAR dari Apikasi Surat Menyurat ini ?", MsgBoxStyle.YesNo, "Aplikasi Surat Menyurat!")
        If msg = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Application.Exit()
        ElseIf msg = Windows.Forms.DialogResult.No Then

        End If
    End Sub

    Private Sub BLanjut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLanjut.Click
        Me.Hide()
        FRLogin.Show()
    End Sub

    Private Sub FRAwal_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class