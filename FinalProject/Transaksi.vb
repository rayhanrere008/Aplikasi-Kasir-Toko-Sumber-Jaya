Imports System.Data.OracleClient
Public Class Transaksi
    Dim i As Integer
    Dim kodePembelian As String
    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetSJ.TBLBARANG' table. You can move, or remove it, as needed.
        Me.TBLBARANGTableAdapter.Fill(Me.DataSetSJ.TBLBARANG)

        Try
            koneksi()
            da = New OracleDataAdapter("select kodeBarang, namaBarang,hargaBeli,hargaJual,stok from tblbarang", xconn)
            da.Fill(ds, "brg")
            DataGridViewbrg.DataSource = ds.Tables("brg").DefaultView
        Catch Ex As Exception
            MessageBox.Show("gagal")
        End Try
        TBTotalHargaSementara.Text = 0
    End Sub
    Public Function totalsementara()
        Dim i As Integer = 0
        Dim Total As Integer
        For Each items As ListViewItem In ListViewTransaksi.Items
            Total += ListViewTransaksi.Items(i).SubItems(4).Text
            i += 1
        Next
        Return Total
    End Function

    Private Sub DataGridViewbrg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewbrg.CellClick
        i = e.RowIndex
        If i < 0 Then
        Else
            TBKodeBrg2.Text = DataGridViewbrg.Rows(i).Cells(0).Value.ToString
            TBNamaBrg2.Text = DataGridViewbrg.Rows(i).Cells(1).Value.ToString
            TBHargaBrg.Text = DataGridViewbrg.Rows(i).Cells(3).Value.ToString
        End If
    End Sub

    Private Sub BTNTambah2_Click(sender As Object, e As EventArgs) Handles BTNTambah2.Click
        Dim seq As Integer = 0
        Dim condition As Boolean = False

        If TBKodeBrg2.Text = "" Then
            MsgBox("Silahkan Pilih Baris yang ingin di pilih!")
        Else

            If ListViewTransaksi.Items.Count = 0 Then
                ListViewTransaksi.Items.Add(DataGridViewbrg(0, i).Value)
                ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(DataGridViewbrg(1, i).Value)
                ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(DataGridViewbrg(3, i).Value)
                ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(NumericUpJmlh.Value)
                ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(DataGridViewbrg(3, i).Value * NumericUpJmlh.Value)

            Else
                'pengecekan setiap baris listview apakah terdapat data yang sama
                For Each items As ListViewItem In ListViewTransaksi.Items
                    If DataGridViewbrg(0, i).Value = ListViewTransaksi.Items(seq).SubItems(0).Text Then

                        'pengecekan apakah stok melebihi stok yang tersedia
                        If (ListViewTransaksi.Items(seq).SubItems(3).Text + NumericUpJmlh.Value) <= DataGridViewbrg(4, 1).Value Then
                            ListViewTransaksi.Items(seq).SubItems(3).Text = NumericUpJmlh.Value + ListViewTransaksi.Items(seq).SubItems(4).Text
                            ListViewTransaksi.Items(seq).SubItems(4).Text = ListViewTransaksi.Items(seq).SubItems(4).Text * ListViewTransaksi.Items(seq).SubItems(2).Text

                        Else
                            MsgBox("Jumlah barang melebihi stok barang")
                        End If
                    Else
                        'jika tidak ada yg sama akan mengganti boolean ke true
                        If seq = ListViewTransaksi.Items.Count - 1 Then
                            condition = True
                        End If
                    End If
                    seq += 1
                Next
                'ketika data tidak ada yang sama maka akan di tambh di baris baru
                If condition = True Then
                    ListViewTransaksi.Items.Add(DataGridViewbrg(0, 1).Value)
                    ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(DataGridViewbrg(1, i).Value)
                    ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(DataGridViewbrg(3, i).Value)
                    ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(NumericUpJmlh.Value)
                    ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(DataGridViewbrg(3, i).Value * NumericUpJmlh.Value)
                    totalsementara()
                End If
            End If
        End If
        TBTotalHargaSementara.Text = totalsementara()
    End Sub

    Private Sub BTNSubmit_Click(sender As Object, e As EventArgs) Handles BTNSubmit.Click
        If TBTotalHargaSementara.Text = 0 Then
            MsgBox("Mohon Masukkan Pesanan Pembeli!")
        Else
            If TBTunai.Text = "" Then
                MsgBox("Mohon Masukkan Tunai!")
            Else
                If (TBTunai.Text - TBTotalHargaSementara.Text) < 0 Then
                    MsgBox("Uang Kurang!")
                Else

                    submit()
                End If
            End If
        End If
    End Sub
    Private Function kodeCek(kodeBarang As String)
        Dim iii As Integer = 0
        For Each row As DataGridViewRow In DataGridViewbrg.Rows
            If kodeBarang = DataGridViewbrg(0, iii).Value Then
                kodeBarang = DataGridViewbrg(4, iii).Value

            End If
            iii += 1
        Next
        Return kodeBarang
    End Function

    Sub submit()
        Dim ii As Integer = 0
        Dim seq As Integer = 0
        koneksi()
        Dim myDate = Convert.ToDateTime(Now.ToString("dd-MMM-yyyy"))

        'pengurangan stok barang oleh transaksi
        For Each item As ListViewItem In Me.ListViewTransaksi.Items
            xcomm.CommandType = CommandType.Text
            Dim kodeCekk As Integer = kodeCek(ListViewTransaksi.Items(seq).SubItems(0).Text)
            xcomm.CommandText = "UPDATE " & ControlChars.Quote & "TBLBARANG" & ControlChars.Quote & " SET stok = '" & (kodeCekk - ListViewTransaksi.Items(seq).SubItems(3).Text) & "' WHERE kodeBarang = '" & ListViewTransaksi.Items(seq).SubItems(0).Text & "'"
            xcomm.Connection = xconn
            xcomm.ExecuteNonQuery()
            seq += 1
        Next

        'mencari total kolom
        For Each item As ListViewItem In Me.ListViewTransaksi.Items
            ii += 1
        Next

        If TBTotalHargaSementara.Text = "" Then
            TBTotalHargaSementara.Text = ""

            'Insert tbltransaksi VALUE
            xcomm.CommandType = CommandType.Text
        xcomm.CommandText = "INSERT INTO " & ControlChars.Quote & "TBLTRANSAKSI" & ControlChars.Quote & "  (JUMLAH_PESANAN,TOTAL_TRANSAKSI,TANGGAL_TRANSAKSI) VALUES
                                        ('" & ii & "','" & TBTotalHargaSementara.Text & "','" & myDate & "')"
        xcomm.Connection = xconn
        xcomm.ExecuteNonQuery()
        End If

        Dim idtransaksi2 As String = getLastIdTransaksi()

        'mencari nilai id_transaksi
        Try
            ii = 0
            For Each item As ListViewItem In Me.ListViewTransaksi.Items
                xcomm.CommandType = CommandType.Text
                xcomm.CommandText = "INSERT INTO " & ControlChars.Quote & "TBLDETAILTRANSAKSI" & ControlChars.Quote & "  (ID_TRANSAKSI, NOMOR_PESANAN,kodeBarang,namaBarang, hargaJual, JUMLAH,TOTAL_PESANAN) VALUES
                                        ('" & idtransaksi2 & "','" & ii + 1 & "','" & ListViewTransaksi.Items(ii).SubItems(0).Text & "','" & ListViewTransaksi.Items(ii).SubItems(1).Text & "','" & ListViewTransaksi.Items(ii).SubItems(2).Text & "','" & ListViewTransaksi.Items(ii).SubItems(3).Text & "','" & ListViewTransaksi.Items(ii).SubItems(4).Text & "')"
                xcomm.Connection = xconn
                xcomm.ExecuteNonQuery()
                ii += 1
            Next
            MsgBox("Data disimpan", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            MsgBox("Data disimpan" + ex.Message, MsgBoxStyle.Critical)
        End Try
        xconn.Close()
    End Sub

    Private Sub TBTunai_TextChanged(sender As Object, e As EventArgs) Handles TBTunai.TextChanged
        TBKembalian.Text = TBTunai.Text - TBTotalHargaSementara.Text
    End Sub
End Class