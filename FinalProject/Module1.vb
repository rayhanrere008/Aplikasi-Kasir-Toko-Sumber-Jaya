Imports System.Data.OracleClient
Module Module1
    Public MySQLReader As OracleDataAdapter
    Public xcomm As New OracleCommand
    Public da As New OracleDataAdapter
    Public mystring As String = "data source=XE; user id=DBTokoSJ; password=123;"
    Public xconn As New OracleConnection(mystring)
    Public ds As New DataSet
    Public dr As OracleDataReader

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

    Public Function getLastIdTransaksi() As String
        Dim dtbl As DataTable
        Dim DA As OracleDataAdapter
        Dim sqlstr As String
        Dim data As Integer
        Dim idtransaksi As String

        sqlstr = "select ID_TRANSAKSI from tbltransaksi order by id_transaksi desc"
        DA = New OracleDataAdapter(sqlstr, xconn)
        dtbl = New DataTable
        data = DA.Fill(dtbl)
        If data > 0 Then
            idtransaksi = dtbl.Rows(0)(0).ToString()
        End If
        Return idtransaksi
    End Function
End Module
