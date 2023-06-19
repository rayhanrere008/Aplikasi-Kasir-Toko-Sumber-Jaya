Imports System.Data.OracleClient
Public Class Viewkaryawan
    Public Sub koneksi()
        If xconn.State = ConnectionState.Closed Then
            Try
                xconn.ConnectionString = mystring
                xconn.Open()
            Catch ex As Exception
                MessageBox.Show("Koneksi Gagal" & vbCrLf & "Mohon cek apakah server sudah siap!", "Koneksi ke server", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
    Private Sub Viewkaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            koneksi()
            da = New OracleDataAdapter("select username, password from tbllogin", xconn)
            da.Fill(ds, "user")
            DataGridViewUser.DataSource = ds.Tables("user").DefaultView
        Catch Ex As Exception
            MessageBox.Show("gagal")
        End Try
    End Sub

    Private Sub SimpanUser_Click(sender As Object, e As EventArgs) Handles SimpanUser.Click
        'Perintah simpan di database
        xcomm.Connection = xconn
        xcomm.CommandText = "insert into tbllogin values ('" & TBUsername.Text & "', '" & TBPassword.Text & "')"
        xcomm.ExecuteNonQuery()

        MessageBox.Show("Data Disimpan")
        TBUsername.Text = ""
        TBPassword.Text = ""
        'Akhir perintah simpan di database

        'Perintah tampil data ke DataGridView
        ds.Clear()
        da = New OracleDataAdapter("select username, password from tbllogin", xconn)
        da.Fill(ds, "user")
        DataGridViewUser.DataSource = ds.Tables("user").DefaultView
    End Sub

    Private Sub DataGridViewUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUser.CellClick
        Dim i As Integer
        i = DataGridViewUser.SelectedCells(0).RowIndex
        TBUsername.Text = DataGridViewUser.Rows(i).Cells(0).Value.ToString
        TBPassword.Text = DataGridViewUser.Rows(i).Cells(1).Value.ToString
    End Sub

    Private Sub HapusUser_Click(sender As Object, e As EventArgs) Handles HapusUser.Click
        'Perintah delete di database
        xcomm.Connection = xconn
        xcomm.CommandText = "delete tbllogin where username =('" & TBUsername.Text & "')"
        xcomm.ExecuteNonQuery()

        MessageBox.Show("Data Dihapus")
        TBUsername.Text = ""
        TBPassword.Text = ""
        'Akhir perintah delete di database

        'Perintah tampil data ke DataGridView
        ds.Clear()
        da = New OracleDataAdapter("select username, password from tbllogin", xconn)
        da.Fill(ds, "user")
        DataGridViewUser.DataSource = ds.Tables("user").DefaultView

    End Sub

    Private Sub UpdateUser_Click(sender As Object, e As EventArgs) Handles UpdateUser.Click
        'Perintah update di database
        xcomm.Connection = xconn
        xcomm.CommandText = "update tbllogin set password =('" & TBPassword.Text & "') where username =('" & TBUsername.Text & "')"
        xcomm.ExecuteNonQuery()

        MessageBox.Show("Data Diubah")
        TBUsername.Text = ""
        TBPassword.Text = ""
        'Akhir perintah update di database

        'Perintah tampil data ke DataGridView
        ds.Clear()
        da = New OracleDataAdapter("select username, password from tbllogin", xconn)
        da.Fill(ds, "user")
        DataGridViewUser.DataSource = ds.Tables("user").DefaultView
    End Sub

    Private Sub CariUser_Click(sender As Object, e As EventArgs) Handles CariUser.Click
        xcomm.Connection = xconn
        xcomm.CommandText = "select * from tbllogin where username =('" & TBUsername.Text & "')"
        dr = xcomm.ExecuteReader

        While dr.Read
            If dr.HasRows Then
                TBPassword.Text = dr.Item(1)
            End If
        End While
    End Sub
End Class