<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridViewbrg = New System.Windows.Forms.DataGridView()
        Me.KODEBARANGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMABARANGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGABELIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGAJUALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLBARANGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSJBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSJ = New FinalProject.DataSetSJ()
        Me.TBLBARANG2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTokoSJBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTokoSJ = New FinalProject.DataSetTokoSJ()
        Me.ListViewTransaksi = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNSubmit = New System.Windows.Forms.Button()
        Me.TBKembalian = New System.Windows.Forms.TextBox()
        Me.TBTunai = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBTotalHargaSementara = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNTambah2 = New System.Windows.Forms.Button()
        Me.NumericUpJmlh = New System.Windows.Forms.NumericUpDown()
        Me.TBHargaBrg = New System.Windows.Forms.TextBox()
        Me.TBNamaBrg2 = New System.Windows.Forms.TextBox()
        Me.TBKodeBrg2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBLBARANG2TableAdapter = New FinalProject.DataSetTokoSJTableAdapters.TBLBARANG2TableAdapter()
        Me.TBLBARANGTableAdapter = New FinalProject.DataSetSJTableAdapters.TBLBARANGTableAdapter()
        Me.TbldetailtransaksiTableAdapter1 = New FinalProject.DataSetSJTableAdapters.TBLDETAILTRANSAKSITableAdapter()
        CType(Me.DataGridViewbrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBARANGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSJBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBARANG2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTokoSJBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTokoSJ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpJmlh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewbrg
        '
        Me.DataGridViewbrg.AutoGenerateColumns = False
        Me.DataGridViewbrg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewbrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewbrg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KODEBARANGDataGridViewTextBoxColumn, Me.NAMABARANGDataGridViewTextBoxColumn, Me.HARGABELIDataGridViewTextBoxColumn, Me.HARGAJUALDataGridViewTextBoxColumn, Me.STOKDataGridViewTextBoxColumn})
        Me.DataGridViewbrg.DataSource = Me.TBLBARANGBindingSource
        Me.DataGridViewbrg.Location = New System.Drawing.Point(474, 13)
        Me.DataGridViewbrg.Name = "DataGridViewbrg"
        Me.DataGridViewbrg.RowHeadersWidth = 62
        Me.DataGridViewbrg.RowTemplate.Height = 28
        Me.DataGridViewbrg.Size = New System.Drawing.Size(743, 349)
        Me.DataGridViewbrg.TabIndex = 0
        '
        'KODEBARANGDataGridViewTextBoxColumn
        '
        Me.KODEBARANGDataGridViewTextBoxColumn.DataPropertyName = "KODEBARANG"
        Me.KODEBARANGDataGridViewTextBoxColumn.HeaderText = "KODEBARANG"
        Me.KODEBARANGDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.KODEBARANGDataGridViewTextBoxColumn.Name = "KODEBARANGDataGridViewTextBoxColumn"
        '
        'NAMABARANGDataGridViewTextBoxColumn
        '
        Me.NAMABARANGDataGridViewTextBoxColumn.DataPropertyName = "NAMABARANG"
        Me.NAMABARANGDataGridViewTextBoxColumn.HeaderText = "NAMABARANG"
        Me.NAMABARANGDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NAMABARANGDataGridViewTextBoxColumn.Name = "NAMABARANGDataGridViewTextBoxColumn"
        '
        'HARGABELIDataGridViewTextBoxColumn
        '
        Me.HARGABELIDataGridViewTextBoxColumn.DataPropertyName = "HARGABELI"
        Me.HARGABELIDataGridViewTextBoxColumn.HeaderText = "HARGABELI"
        Me.HARGABELIDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HARGABELIDataGridViewTextBoxColumn.Name = "HARGABELIDataGridViewTextBoxColumn"
        '
        'HARGAJUALDataGridViewTextBoxColumn
        '
        Me.HARGAJUALDataGridViewTextBoxColumn.DataPropertyName = "HARGAJUAL"
        Me.HARGAJUALDataGridViewTextBoxColumn.HeaderText = "HARGAJUAL"
        Me.HARGAJUALDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HARGAJUALDataGridViewTextBoxColumn.Name = "HARGAJUALDataGridViewTextBoxColumn"
        '
        'STOKDataGridViewTextBoxColumn
        '
        Me.STOKDataGridViewTextBoxColumn.DataPropertyName = "STOK"
        Me.STOKDataGridViewTextBoxColumn.HeaderText = "STOK"
        Me.STOKDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.STOKDataGridViewTextBoxColumn.Name = "STOKDataGridViewTextBoxColumn"
        '
        'TBLBARANGBindingSource
        '
        Me.TBLBARANGBindingSource.DataMember = "TBLBARANG"
        Me.TBLBARANGBindingSource.DataSource = Me.DataSetSJBindingSource
        '
        'DataSetSJBindingSource
        '
        Me.DataSetSJBindingSource.DataSource = Me.DataSetSJ
        Me.DataSetSJBindingSource.Position = 0
        '
        'DataSetSJ
        '
        Me.DataSetSJ.DataSetName = "DataSetSJ"
        Me.DataSetSJ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLBARANG2BindingSource
        '
        Me.TBLBARANG2BindingSource.DataMember = "TBLBARANG2"
        Me.TBLBARANG2BindingSource.DataSource = Me.DataSetTokoSJBindingSource
        '
        'DataSetTokoSJBindingSource
        '
        Me.DataSetTokoSJBindingSource.DataSource = Me.DataSetTokoSJ
        Me.DataSetTokoSJBindingSource.Position = 0
        '
        'DataSetTokoSJ
        '
        Me.DataSetTokoSJ.DataSetName = "DataSetTokoSJ"
        Me.DataSetTokoSJ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListViewTransaksi
        '
        Me.ListViewTransaksi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListViewTransaksi.HideSelection = False
        Me.ListViewTransaksi.Location = New System.Drawing.Point(474, 368)
        Me.ListViewTransaksi.Name = "ListViewTransaksi"
        Me.ListViewTransaksi.Size = New System.Drawing.Size(743, 264)
        Me.ListViewTransaksi.TabIndex = 1
        Me.ListViewTransaksi.UseCompatibleStateImageBehavior = False
        Me.ListViewTransaksi.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "KodeBarang"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NamaBarang"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Harga"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Jumlah"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "TotalHarga"
        Me.ColumnHeader5.Width = 110
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.FinalProject.My.Resources.Resources.Tan_Boho_Gouache_Artwork_Kartu_Ucapan_Terima_Kasih
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.ListViewTransaksi)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.DataGridViewbrg)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1233, 661)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNSubmit)
        Me.GroupBox2.Controls.Add(Me.TBKembalian)
        Me.GroupBox2.Controls.Add(Me.TBTunai)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TBTotalHargaSementara)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 264)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pembayaran"
        '
        'BTNSubmit
        '
        Me.BTNSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSubmit.Location = New System.Drawing.Point(179, 195)
        Me.BTNSubmit.Name = "BTNSubmit"
        Me.BTNSubmit.Size = New System.Drawing.Size(175, 44)
        Me.BTNSubmit.TabIndex = 10
        Me.BTNSubmit.Text = "Submit"
        Me.BTNSubmit.UseVisualStyleBackColor = True
        '
        'TBKembalian
        '
        Me.TBKembalian.Location = New System.Drawing.Point(147, 148)
        Me.TBKembalian.Name = "TBKembalian"
        Me.TBKembalian.Size = New System.Drawing.Size(249, 32)
        Me.TBKembalian.TabIndex = 4
        '
        'TBTunai
        '
        Me.TBTunai.Location = New System.Drawing.Point(147, 101)
        Me.TBTunai.Name = "TBTunai"
        Me.TBTunai.Size = New System.Drawing.Size(249, 32)
        Me.TBTunai.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 26)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Kembalian"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 26)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tunai"
        '
        'TBTotalHargaSementara
        '
        Me.TBTotalHargaSementara.Location = New System.Drawing.Point(21, 41)
        Me.TBTotalHargaSementara.Name = "TBTotalHargaSementara"
        Me.TBTotalHargaSementara.Size = New System.Drawing.Size(375, 32)
        Me.TBTotalHargaSementara.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNTambah2)
        Me.GroupBox1.Controls.Add(Me.NumericUpJmlh)
        Me.GroupBox1.Controls.Add(Me.TBHargaBrg)
        Me.GroupBox1.Controls.Add(Me.TBNamaBrg2)
        Me.GroupBox1.Controls.Add(Me.TBKodeBrg2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 350)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tambah Barang"
        '
        'BTNTambah2
        '
        Me.BTNTambah2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTambah2.Location = New System.Drawing.Point(158, 255)
        Me.BTNTambah2.Name = "BTNTambah2"
        Me.BTNTambah2.Size = New System.Drawing.Size(238, 44)
        Me.BTNTambah2.TabIndex = 9
        Me.BTNTambah2.Text = "Tambahkan"
        Me.BTNTambah2.UseVisualStyleBackColor = True
        '
        'NumericUpJmlh
        '
        Me.NumericUpJmlh.Location = New System.Drawing.Point(159, 196)
        Me.NumericUpJmlh.Name = "NumericUpJmlh"
        Me.NumericUpJmlh.Size = New System.Drawing.Size(77, 32)
        Me.NumericUpJmlh.TabIndex = 8
        '
        'TBHargaBrg
        '
        Me.TBHargaBrg.Location = New System.Drawing.Point(158, 153)
        Me.TBHargaBrg.Name = "TBHargaBrg"
        Me.TBHargaBrg.Size = New System.Drawing.Size(238, 32)
        Me.TBHargaBrg.TabIndex = 7
        '
        'TBNamaBrg2
        '
        Me.TBNamaBrg2.Location = New System.Drawing.Point(158, 111)
        Me.TBNamaBrg2.Name = "TBNamaBrg2"
        Me.TBNamaBrg2.Size = New System.Drawing.Size(238, 32)
        Me.TBNamaBrg2.TabIndex = 6
        '
        'TBKodeBrg2
        '
        Me.TBKodeBrg2.Location = New System.Drawing.Point(158, 70)
        Me.TBKodeBrg2.Name = "TBKodeBrg2"
        Me.TBKodeBrg2.Size = New System.Drawing.Size(238, 32)
        Me.TBKodeBrg2.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NamaBarang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KodeBarang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Klik barang yang ingin dipilih"
        '
        'TBLBARANG2TableAdapter
        '
        Me.TBLBARANG2TableAdapter.ClearBeforeFill = True
        '
        'TBLBARANGTableAdapter
        '
        Me.TBLBARANGTableAdapter.ClearBeforeFill = True
        '
        'TbldetailtransaksiTableAdapter1
        '
        Me.TbldetailtransaksiTableAdapter1.ClearBeforeFill = True
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 644)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        CType(Me.DataGridViewbrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBARANGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSJBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBARANG2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTokoSJBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTokoSJ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpJmlh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewbrg As DataGridView
    Friend WithEvents DataSetTokoSJBindingSource As BindingSource
    Friend WithEvents DataSetTokoSJ As DataSetTokoSJ
    Friend WithEvents TBLBARANG2BindingSource As BindingSource
    Friend WithEvents TBLBARANG2TableAdapter As DataSetTokoSJTableAdapters.TBLBARANG2TableAdapter
    Friend WithEvents ListViewTransaksi As ListView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTNSubmit As Button
    Friend WithEvents TBKembalian As TextBox
    Friend WithEvents TBTunai As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TBTotalHargaSementara As TextBox
    Friend WithEvents BTNTambah2 As Button
    Friend WithEvents NumericUpJmlh As NumericUpDown
    Friend WithEvents TBHargaBrg As TextBox
    Friend WithEvents TBNamaBrg2 As TextBox
    Friend WithEvents TBKodeBrg2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents DataSetSJBindingSource As BindingSource
    Friend WithEvents DataSetSJ As DataSetSJ
    Friend WithEvents TBLBARANGBindingSource As BindingSource
    Friend WithEvents TBLBARANGTableAdapter As DataSetSJTableAdapters.TBLBARANGTableAdapter
    Friend WithEvents KODEBARANGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMABARANGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HARGABELIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HARGAJUALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STOKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbldetailtransaksiTableAdapter1 As DataSetSJTableAdapters.TBLDETAILTRANSAKSITableAdapter
End Class
