Imports System.Data.OracleClient
Public Class Viewbarang
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

    Private Sub Viewbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            koneksi()
            da = New OracleDataAdapter("select kodeBarang, namaBarang,hargaBeli,hargaJual,stok from tblbarang", xconn)
            da.Fill(ds, "brg")
            DataGridViewbrg.DataSource = ds.Tables("brg").DefaultView
        Catch Ex As Exception
            MessageBox.Show("gagal")
        End Try
    End Sub

    Private Sub SimpanBrg_Click(sender As Object, e As EventArgs) Handles SimpanBrg.Click
        'Perintah simpan di database
        xcomm.Connection = xconn
        xcomm.CommandText = "insert into tblbarang values ('" & TBKodeBrg.Text & "', '" & TBNamaBrg.Text & "', '" & TBHargaBeli.Text & "', '" & TBHargaJual.Text & "', '" & TBStok.Text & "')"
        xcomm.ExecuteNonQuery()

        MessageBox.Show("Data Disimpan")
        TBKodeBrg.Text = ""
        TBNamaBrg.Text = ""
        TBHargaBeli.Text = ""
        TBHargaJual.Text = ""
        TBStok.Text = ""
        'Akhir perintah simpan di database

        'Perintah tampil data ke DataGridView
        ds.Clear()
        da = New OracleDataAdapter("select kodeBarang, namaBarang,hargaBeli,hargaJual,stok from tblbarang", xconn)
        da.Fill(ds, "brg")
        DataGridViewbrg.DataSource = ds.Tables("brg").DefaultView
    End Sub
    Private Sub DataGridViewbrg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewbrg.CellClick
        Dim i As Integer
        i = DataGridViewbrg.SelectedCells(0).RowIndex
        TBKodeBrg.Text = DataGridViewbrg.Rows(i).Cells(0).Value.ToString
        TBNamaBrg.Text = DataGridViewbrg.Rows(i).Cells(1).Value.ToString
        TBHargaBeli.Text = DataGridViewbrg.Rows(i).Cells(2).Value.ToString
        TBHargaJual.Text = DataGridViewbrg.Rows(i).Cells(3).Value.ToString
        TBStok.Text = DataGridViewbrg.Rows(i).Cells(4).Value.ToString
    End Sub

    Private Sub EditBrg_Click(sender As Object, e As EventArgs) Handles EditBrg.Click
        xcomm.Connection = xconn
        xcomm.CommandText = "update tblbarang set " & " namaBarang='" & TBNamaBrg.Text & "'," &
                           "hargaBeli ='" & TBHargaBeli.Text & "'," &
                           "hargaJual ='" & TBHargaJual.Text & "'," &
                           "stok ='" & TBStok.Text & "' where kodeBarang='" & TBKodeBrg.Text & "'"
        xcomm.ExecuteNonQuery()

        MessageBox.Show("Data Diubah")
        TBKodeBrg.Text = ""
        TBNamaBrg.Text = ""
        TBHargaBeli.Text = ""
        TBHargaJual.Text = ""
        TBStok.Text = ""
        'Akhir perintah update di database

        'Perintah tampil data ke DataGridView
        ds.Clear()
        da = New OracleDataAdapter("select kodeBarang, namaBarang, hargaBeli, hargaJual, stok from tblbarang", xconn)
        da.Fill(ds, "brg")
        DataGridViewbrg.DataSource = ds.Tables("brg").DefaultView
    End Sub

    Private Sub HapusBrg_Click(sender As Object, e As EventArgs) Handles HapusBrg.Click
        'Perintah delete di database
        xcomm.Connection = xconn
        xcomm.CommandText = "delete tblbarang where kodeBarang =('" & TBKodeBrg.Text & "')"
        xcomm.ExecuteNonQuery()

        MessageBox.Show("Data Dihapus")
        TBKodeBrg.Text = ""
        TBNamaBrg.Text = ""
        TBHargaBeli.Text = ""
        TBHargaJual.Text = ""
        TBStok.Text = ""
        'Akhir perintah delete di database

        'Perintah tampil data ke DataGridView
        ds.Clear()
        da = New OracleDataAdapter("select kodeBarang, namaBarang, hargaBeli, hargaJual,stok from tblbarang", xconn)
        da.Fill(ds, "brg")
        DataGridViewbrg.DataSource = ds.Tables("brg").DefaultView
    End Sub

    Private Sub CariBrg_Click(sender As Object, e As EventArgs) Handles CariBrg.Click
        xcomm.Connection = xconn
        xcomm.CommandText = "select * from tblbarang where kodeBarang =('" & TBKodeBrg.Text & "')"
        dr = xcomm.ExecuteReader

        While dr.Read
            If dr.HasRows Then
                TBNamaBrg.Text = dr.Item(1)
                TBHargaBeli.Text = dr.Item(2)
                TBHargaJual.Text = dr.Item(3)
                TBStok.Text = dr.Item(4)
            End If
        End While
    End Sub
End Class