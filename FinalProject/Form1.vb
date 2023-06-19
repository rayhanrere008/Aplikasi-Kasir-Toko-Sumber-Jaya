Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_username.Clear()
        txt_password.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        koneksi()
        xcomm.Connection = xconn
        xcomm.CommandText = "select * from tbllogin where username =('" & txt_username.Text & "') and password =('" & txt_password.Text & "')"
        dr = xcomm.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                FormMenu.ShowDialog()
                Exit While
            End While
            dr.Close()
            txt_username.Clear()
            txt_password.Clear()
        Else
            MessageBox.Show("Data Salah")
        End If
        dr.Close()
    End Sub
End Class
