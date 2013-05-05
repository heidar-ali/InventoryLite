<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListPenerimaanBarang
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListPenerimaanBarang))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.ButtonInput = New System.Windows.Forms.Button
        Me.ButtonEdit = New System.Windows.Forms.Button
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonRefresh = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.No_Terima = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kode_Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nama_Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kode_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nama_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Harga_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1076, 547)
        Me.SplitContainer1.SplitterDistance = 78
        Me.SplitContainer1.TabIndex = 0
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1076, 78)
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Cornsilk
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No_Terima, Me.Tanggal, Me.Kode_Supplier, Me.Nama_Supplier, Me.Kode_Barang, Me.Nama_Barang, Me.Harga_Barang, Me.Jumlah})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1076, 465)
        Me.DataGridView1.TabIndex = 0
        '
        'No_Terima
        '
        Me.No_Terima.DataPropertyName = "No_Invoice"
        Me.No_Terima.HeaderText = "No Invoice"
        Me.No_Terima.Name = "No_Terima"
        Me.No_Terima.ReadOnly = True
        Me.No_Terima.Width = 80
        '
        'Tanggal
        '
        Me.Tanggal.DataPropertyName = "Tanggal"
        DataGridViewCellStyle4.Format = "dd-MMM-yyyy"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Tanggal.DefaultCellStyle = DataGridViewCellStyle4
        Me.Tanggal.HeaderText = "Tanggal"
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.ReadOnly = True
        Me.Tanggal.Width = 120
        '
        'Kode_Supplier
        '
        Me.Kode_Supplier.DataPropertyName = "Kode_Supplier"
        Me.Kode_Supplier.HeaderText = "Kode_Supplier"
        Me.Kode_Supplier.Name = "Kode_Supplier"
        Me.Kode_Supplier.ReadOnly = True
        '
        'Nama_Supplier
        '
        Me.Nama_Supplier.DataPropertyName = "Nama_Supplier"
        Me.Nama_Supplier.HeaderText = "Nama_Supplier"
        Me.Nama_Supplier.Name = "Nama_Supplier"
        Me.Nama_Supplier.ReadOnly = True
        Me.Nama_Supplier.Width = 210
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1076, 681)
        Me.SplitContainer2.SplitterDistance = 130
        Me.SplitContainer2.TabIndex = 3
        '
        'ListPenerimaanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1076, 681)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListPenerimaanBarang"
        Me.ShowInTaskbar = False
        Me.Text = "List Penerimaan Barang"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtonInput As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents No_Terima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kode_Supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama_Supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kode_Barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama_Barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Harga_Barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
End Class
