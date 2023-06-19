<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewkaryawan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CariUser = New System.Windows.Forms.Button()
        Me.DataGridViewUser = New System.Windows.Forms.DataGridView()
        Me.UpdateUser = New System.Windows.Forms.Button()
        Me.HapusUser = New System.Windows.Forms.Button()
        Me.SimpanUser = New System.Windows.Forms.Button()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.TBUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.FinalProject.My.Resources.Resources.Desain_Kelola_User
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.CariUser)
        Me.Panel1.Controls.Add(Me.DataGridViewUser)
        Me.Panel1.Controls.Add(Me.UpdateUser)
        Me.Panel1.Controls.Add(Me.HapusUser)
        Me.Panel1.Controls.Add(Me.SimpanUser)
        Me.Panel1.Controls.Add(Me.TBPassword)
        Me.Panel1.Controls.Add(Me.TBUsername)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 587)
        Me.Panel1.TabIndex = 0
        '
        'CariUser
        '
        Me.CariUser.Location = New System.Drawing.Point(352, 454)
        Me.CariUser.Name = "CariUser"
        Me.CariUser.Size = New System.Drawing.Size(75, 38)
        Me.CariUser.TabIndex = 8
        Me.CariUser.Text = "Cari"
        Me.CariUser.UseVisualStyleBackColor = True
        '
        'DataGridViewUser
        '
        Me.DataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUser.Location = New System.Drawing.Point(352, 194)
        Me.DataGridViewUser.Name = "DataGridViewUser"
        Me.DataGridViewUser.RowHeadersWidth = 62
        Me.DataGridViewUser.RowTemplate.Height = 28
        Me.DataGridViewUser.Size = New System.Drawing.Size(383, 239)
        Me.DataGridViewUser.TabIndex = 7
        '
        'UpdateUser
        '
        Me.UpdateUser.Location = New System.Drawing.Point(228, 292)
        Me.UpdateUser.Name = "UpdateUser"
        Me.UpdateUser.Size = New System.Drawing.Size(75, 38)
        Me.UpdateUser.TabIndex = 6
        Me.UpdateUser.Text = "Update"
        Me.UpdateUser.UseVisualStyleBackColor = True
        '
        'HapusUser
        '
        Me.HapusUser.Location = New System.Drawing.Point(147, 292)
        Me.HapusUser.Name = "HapusUser"
        Me.HapusUser.Size = New System.Drawing.Size(75, 38)
        Me.HapusUser.TabIndex = 5
        Me.HapusUser.Text = "Hapus"
        Me.HapusUser.UseVisualStyleBackColor = True
        '
        'SimpanUser
        '
        Me.SimpanUser.Location = New System.Drawing.Point(66, 292)
        Me.SimpanUser.Name = "SimpanUser"
        Me.SimpanUser.Size = New System.Drawing.Size(75, 38)
        Me.SimpanUser.TabIndex = 4
        Me.SimpanUser.Text = "Simpan"
        Me.SimpanUser.UseVisualStyleBackColor = True
        '
        'TBPassword
        '
        Me.TBPassword.Location = New System.Drawing.Point(180, 238)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.Size = New System.Drawing.Size(142, 26)
        Me.TBPassword.TabIndex = 3
        '
        'TBUsername
        '
        Me.TBUsername.Location = New System.Drawing.Point(180, 195)
        Me.TBUsername.Name = "TBUsername"
        Me.TBUsername.Size = New System.Drawing.Size(142, 26)
        Me.TBUsername.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Cornsilk
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Cornsilk
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Viewkaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 587)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Viewkaryawan"
        Me.Text = "Viewkaryawan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewUser As DataGridView
    Friend WithEvents UpdateUser As Button
    Friend WithEvents HapusUser As Button
    Friend WithEvents SimpanUser As Button
    Friend WithEvents TBPassword As TextBox
    Friend WithEvents TBUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CariUser As Button
End Class
