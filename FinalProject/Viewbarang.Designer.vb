<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Viewbarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewbrg = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBStok = New System.Windows.Forms.TextBox()
        Me.TBHargaJual = New System.Windows.Forms.TextBox()
        Me.TBHargaBeli = New System.Windows.Forms.TextBox()
        Me.CariBrg = New System.Windows.Forms.Button()
        Me.SimpanBrg = New System.Windows.Forms.Button()
        Me.HapusBrg = New System.Windows.Forms.Button()
        Me.TBNamaBrg = New System.Windows.Forms.TextBox()
        Me.TBKodeBrg = New System.Windows.Forms.TextBox()
        Me.EditBrg = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewbrg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.FinalProject.My.Resources.Resources.Desain_Kelola_Barang1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.DataGridViewbrg)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1186, 634)
        Me.Panel1.TabIndex = 0
        '
        'DataGridViewbrg
        '
        Me.DataGridViewbrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewbrg.Location = New System.Drawing.Point(397, 118)
        Me.DataGridViewbrg.Name = "DataGridViewbrg"
        Me.DataGridViewbrg.RowHeadersWidth = 62
        Me.DataGridViewbrg.RowTemplate.Height = 28
        Me.DataGridViewbrg.Size = New System.Drawing.Size(768, 492)
        Me.DataGridViewbrg.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBStok)
        Me.GroupBox1.Controls.Add(Me.TBHargaJual)
        Me.GroupBox1.Controls.Add(Me.TBHargaBeli)
        Me.GroupBox1.Controls.Add(Me.CariBrg)
        Me.GroupBox1.Controls.Add(Me.SimpanBrg)
        Me.GroupBox1.Controls.Add(Me.HapusBrg)
        Me.GroupBox1.Controls.Add(Me.TBNamaBrg)
        Me.GroupBox1.Controls.Add(Me.TBKodeBrg)
        Me.GroupBox1.Controls.Add(Me.EditBrg)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 492)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Barang"
        '
        'TBStok
        '
        Me.TBStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBStok.Location = New System.Drawing.Point(170, 220)
        Me.TBStok.Name = "TBStok"
        Me.TBStok.Size = New System.Drawing.Size(177, 30)
        Me.TBStok.TabIndex = 15
        '
        'TBHargaJual
        '
        Me.TBHargaJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBHargaJual.Location = New System.Drawing.Point(170, 179)
        Me.TBHargaJual.Name = "TBHargaJual"
        Me.TBHargaJual.Size = New System.Drawing.Size(177, 30)
        Me.TBHargaJual.TabIndex = 14
        '
        'TBHargaBeli
        '
        Me.TBHargaBeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBHargaBeli.Location = New System.Drawing.Point(170, 140)
        Me.TBHargaBeli.Name = "TBHargaBeli"
        Me.TBHargaBeli.Size = New System.Drawing.Size(177, 30)
        Me.TBHargaBeli.TabIndex = 13
        '
        'CariBrg
        '
        Me.CariBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CariBrg.Location = New System.Drawing.Point(132, 387)
        Me.CariBrg.Name = "CariBrg"
        Me.CariBrg.Size = New System.Drawing.Size(104, 40)
        Me.CariBrg.TabIndex = 12
        Me.CariBrg.Text = "Cari"
        Me.CariBrg.UseVisualStyleBackColor = True
        '
        'SimpanBrg
        '
        Me.SimpanBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpanBrg.Location = New System.Drawing.Point(245, 322)
        Me.SimpanBrg.Name = "SimpanBrg"
        Me.SimpanBrg.Size = New System.Drawing.Size(125, 46)
        Me.SimpanBrg.TabIndex = 11
        Me.SimpanBrg.Text = "Simpan"
        Me.SimpanBrg.UseVisualStyleBackColor = True
        '
        'HapusBrg
        '
        Me.HapusBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HapusBrg.Location = New System.Drawing.Point(132, 322)
        Me.HapusBrg.Name = "HapusBrg"
        Me.HapusBrg.Size = New System.Drawing.Size(104, 46)
        Me.HapusBrg.TabIndex = 10
        Me.HapusBrg.Text = "Hapus"
        Me.HapusBrg.UseVisualStyleBackColor = True
        '
        'TBNamaBrg
        '
        Me.TBNamaBrg.AutoCompleteCustomSource.AddRange(New String() {""})
        Me.TBNamaBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNamaBrg.Location = New System.Drawing.Point(170, 79)
        Me.TBNamaBrg.Multiline = True
        Me.TBNamaBrg.Name = "TBNamaBrg"
        Me.TBNamaBrg.Size = New System.Drawing.Size(177, 55)
        Me.TBNamaBrg.TabIndex = 6
        '
        'TBKodeBrg
        '
        Me.TBKodeBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBKodeBrg.Location = New System.Drawing.Point(170, 40)
        Me.TBKodeBrg.Name = "TBKodeBrg"
        Me.TBKodeBrg.Size = New System.Drawing.Size(177, 30)
        Me.TBKodeBrg.TabIndex = 1
        '
        'EditBrg
        '
        Me.EditBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBrg.Location = New System.Drawing.Point(16, 322)
        Me.EditBrg.Name = "EditBrg"
        Me.EditBrg.Size = New System.Drawing.Size(110, 46)
        Me.EditBrg.TabIndex = 1
        Me.EditBrg.Text = "Edit"
        Me.EditBrg.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Stok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Harga Jual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Harga Beli"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Barang"
        '
        'Viewbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 637)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Viewbarang"
        Me.Text = "Viewbarang"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewbrg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EditBrg As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewbrg As DataGridView
    Friend WithEvents CariBrg As Button
    Friend WithEvents SimpanBrg As Button
    Friend WithEvents HapusBrg As Button
    Friend WithEvents TBNamaBrg As TextBox
    Friend WithEvents TBKodeBrg As TextBox
    Friend WithEvents TBStok As TextBox
    Friend WithEvents TBHargaJual As TextBox
    Friend WithEvents TBHargaBeli As TextBox
End Class
