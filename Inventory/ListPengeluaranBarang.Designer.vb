<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListPengeluaranBarang
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListPengeluaranBarang))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.No_Dokumen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kode_Customer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nama_Customer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kode_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nama_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Harga_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.ButtonInput = New System.Windows.Forms.Button
        Me.ButtonEdit = New System.Windows.Forms.Button
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonRefresh = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Cornsilk
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No_Dokumen, Me.Tanggal, Me.Kode_Customer, Me.Nama_Customer, Me.Kode_Barang, Me.Nama_Barang, Me.Harga_Barang, Me.Jumlah})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1083, 360)
        Me.DataGridView1.TabIndex = 0
        '
        'No_Dokumen
        '
        Me.No_Dokumen.DataPropertyName = "No_Dokumen"
        Me.No_Dokumen.HeaderText = "No Dokumen"
        Me.No_Dokumen.Name = "No_Dokumen"
        Me.No_Dokumen.ReadOnly = True
        Me.No_Dokumen.Width = 80
        '
        'Tanggal
        '
        Me.Tanggal.DataPropertyName = "Tanggal"
        DataGridViewCellStyle5.Format = "dd-MMM-yyyy"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Tanggal.DefaultCellStyle = DataGridViewCellStyle5
        Me.Tanggal.HeaderText = "Tanggal"
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.ReadOnly = True
        Me.Tanggal.Width = 120
        '
        'Kode_Customer
        '
        Me.Kode_Customer.DataPropertyName = "Kode_Customer"
        Me.Kode_Customer.HeaderText = "Kode Customer"
        Me.Kode_Customer.Name = "Kode_Customer"
        Me.Kode_Customer.ReadOnly = True
        '
        'Nama_Customer
        '
        Me.Nama_Customer.DataPropertyName = "Nama_Customer"
        Me.Nama_Customer.HeaderText = "Nama Customer"
        Me.Nama_Customer.Name = "Nama_Customer"
        Me.Nama_Customer.ReadOnly = True
        Me.Nama_Customer.Width = 210
        '
        'Kode_Barang
        '
        Me.Kode_Barang.DataPropertyName = "Kode_Barang"
        Me.Kode_Barang.HeaderText = "Kode_Barang"
        Me.Kode_Barang.Name = "Kode_Barang"
        Me.Kode_Barang.ReadOnly = True
        '
        'Nama_Barang
        '
        Me.Nama_Barang.DataPropertyName = "Nama_Barang"
        Me.Nama_Barang.HeaderText = "Nama_Barang"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.ReadOnly = True
        Me.Nama_Barang.Width = 300
        '
        'Harga_Barang
        '
        Me.Harga_Barang.DataPropertyName = "Harga_Barang"
        Me.Harga_Barang.HeaderText = "Harga_Barang"
        Me.Harga_Barang.Name = "Harga_Barang"
        Me.Harga_Barang.ReadOnly = True
        Me.Harga_Barang.Visible = False
        Me.Harga_Barang.Width = 210
        '
        'Jumlah
        '
        Me.Jumlah.DataPropertyName = "Jumlah"
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1083, 442)
        Me.SplitContainer1.SplitterDistance = 78
        Me.SplitContainer1.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonInput)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonDelete)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonRefresh)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1083, 78)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'ButtonInput
        '
        Me.ButtonInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInput.Location = New System.Drawing.Point(13, 23)
        Me.ButtonInput.Name = "ButtonInput"
        Me.ButtonInput.Size = New System.Drawing.Size(75, 32)
        Me.ButtonInput.TabIndex = 0
        Me.ButtonInput.Text = "&Input"
        Me.ButtonInput.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.Location = New System.Drawing.Point(94, 23)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 32)
        Me.ButtonEdit.TabIndex = 1
        Me.ButtonEdit.Text = "&Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Location = New System.Drawing.Point(175, 23)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 32)
        Me.ButtonDelete.TabIndex = 2
        Me.ButtonDelete.Text = "&Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefresh.Location = New System.Drawing.Point(256, 23)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 32)
        Me.ButtonRefresh.TabIndex = 3
        Me.ButtonRefresh.Text = "&Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(337, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "No_Keluar"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No Keluar"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tanggal"
        DataGridViewCellStyle6.Format = "dd-MMM-yyyy"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tanggal"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Kode_Customer"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kode Customer"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nama_Customer"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nama Customer"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 210
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Kode_Barang"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Kode_Barang"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nama_Barang"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nama_Barang"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Harga_Barang"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Harga_Barang"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 210
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Jumlah"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Jumlah"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackgroundImage = Global.Inventory.My.Resources.Resources.form_logo_arcoma_basco
        Me.SplitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1083, 576)
        Me.SplitContainer2.SplitterDistance = 130
        Me.SplitContainer2.TabIndex = 3
        '
        'ListPengeluaranBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 576)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListPengeluaranBarang"
        Me.ShowInTaskbar = False
        Me.Text = "List Pengeluaran Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtonInput As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents No_Dokumen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kode_Customer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama_Customer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kode_Barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama_Barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Harga_Barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
End Class
