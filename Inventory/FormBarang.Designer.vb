<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBarang))
        Me.SplitContainerMain = New System.Windows.Forms.SplitContainer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Kode_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nama_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Harga_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Stock_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainerSouth = New System.Windows.Forms.SplitContainer
        Me.SplitContainerContent = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.FlowLayoutPanelInputContent = New System.Windows.Forms.FlowLayoutPanel
        Me.TextBoxKodeBarang = New System.Windows.Forms.TextBox
        Me.TextBoxNamaBarang = New System.Windows.Forms.TextBox
        Me.NumericTextBoxHargaSatuan = New Inventory.CustomControls.NumericTextBox(Me.components)
        Me.NumericTextBoxJumlahStock = New Inventory.CustomControls.NumericTextBox(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonInput = New System.Windows.Forms.Button
        Me.SplitContainerMain.Panel1.SuspendLayout()
        Me.SplitContainerMain.Panel2.SuspendLayout()
        Me.SplitContainerMain.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerSouth.Panel1.SuspendLayout()
        Me.SplitContainerSouth.Panel2.SuspendLayout()
        Me.SplitContainerSouth.SuspendLayout()
        Me.SplitContainerContent.Panel1.SuspendLayout()
        Me.SplitContainerContent.Panel2.SuspendLayout()
        Me.SplitContainerContent.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanelInputContent.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerMain
        '
        Me.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerMain.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerMain.Name = "SplitContainerMain"
        Me.SplitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerMain.Panel1
        '
        Me.SplitContainerMain.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainerMain.Panel2
        '
        Me.SplitContainerMain.Panel2.Controls.Add(Me.SplitContainerSouth)
        Me.SplitContainerMain.Size = New System.Drawing.Size(833, 737)
        Me.SplitContainerMain.SplitterDistance = 466
        Me.SplitContainerMain.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImage = Global.Inventory.My.Resources.Resources.form_logo_arcoma_basco
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(833, 466)
        Me.SplitContainer1.SplitterDistance = 130
        Me.SplitContainer1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Cornsilk
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode_Barang, Me.Nama_Barang, Me.Harga_Barang, Me.Stock_Barang})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(833, 332)
        Me.DataGridView1.TabIndex = 0
        '
        'Kode_Barang
        '
        Me.Kode_Barang.DataPropertyName = "Kode_Barang"
        Me.Kode_Barang.HeaderText = "Kode Barang"
        Me.Kode_Barang.Name = "Kode_Barang"
        Me.Kode_Barang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Kode_Barang.Width = 140
        '
        'Nama_Barang
        '
        Me.Nama_Barang.DataPropertyName = "Nama_Barang"
        Me.Nama_Barang.HeaderText = "Nama Barang"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Nama_Barang.Width = 320
        '
        'Harga_Barang
        '
        Me.Harga_Barang.DataPropertyName = "Harga_Barang"
        Me.Harga_Barang.HeaderText = "Harga"
        Me.Harga_Barang.Name = "Harga_Barang"
        Me.Harga_Barang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'Stock_Barang
        '
        Me.Stock_Barang.DataPropertyName = "Stock_Barang"
        Me.Stock_Barang.HeaderText = "Stock Barang"
        Me.Stock_Barang.Name = "Stock_Barang"
        Me.Stock_Barang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'SplitContainerSouth
        '
        Me.SplitContainerSouth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerSouth.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainerSouth.IsSplitterFixed = True
        Me.SplitContainerSouth.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerSouth.Name = "SplitContainerSouth"
        Me.SplitContainerSouth.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerSouth.Panel1
        '
        Me.SplitContainerSouth.Panel1.Controls.Add(Me.SplitContainerContent)
        '
        'SplitContainerSouth.Panel2
        '
        Me.SplitContainerSouth.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainerSouth.Size = New System.Drawing.Size(833, 267)
        Me.SplitContainerSouth.SplitterDistance = 202
        Me.SplitContainerSouth.TabIndex = 0
        '
        'SplitContainerContent
        '
        Me.SplitContainerContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerContent.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerContent.IsSplitterFixed = True
        Me.SplitContainerContent.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerContent.Name = "SplitContainerContent"
        '
        'SplitContainerContent.Panel1
        '
        Me.SplitContainerContent.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        '
        'SplitContainerContent.Panel2
        '
        Me.SplitContainerContent.Panel2.Controls.Add(Me.FlowLayoutPanelInputContent)
        Me.SplitContainerContent.Size = New System.Drawing.Size(833, 202)
        Me.SplitContainerContent.SplitterDistance = 213
        Me.SplitContainerContent.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.FlowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(213, 202)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 12, 5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 12, 5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 12, 5, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Satuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 12, 5, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah Stock"
        '
        'FlowLayoutPanelInputContent
        '
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.TextBoxKodeBarang)
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.TextBoxNamaBarang)
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.NumericTextBoxHargaSatuan)
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.NumericTextBoxJumlahStock)
        Me.FlowLayoutPanelInputContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelInputContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanelInputContent.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanelInputContent.Name = "FlowLayoutPanelInputContent"
        Me.FlowLayoutPanelInputContent.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.FlowLayoutPanelInputContent.Size = New System.Drawing.Size(616, 202)
        Me.FlowLayoutPanelInputContent.TabIndex = 1
        '
        'TextBoxKodeBarang
        '
        Me.TextBoxKodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxKodeBarang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxKodeBarang.Location = New System.Drawing.Point(15, 25)
        Me.TextBoxKodeBarang.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxKodeBarang.Name = "TextBoxKodeBarang"
        Me.TextBoxKodeBarang.Size = New System.Drawing.Size(248, 22)
        Me.TextBoxKodeBarang.TabIndex = 0
        '
        'TextBoxNamaBarang
        '
        Me.TextBoxNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNamaBarang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNamaBarang.Location = New System.Drawing.Point(15, 57)
        Me.TextBoxNamaBarang.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxNamaBarang.Name = "TextBoxNamaBarang"
        Me.TextBoxNamaBarang.Size = New System.Drawing.Size(248, 22)
        Me.TextBoxNamaBarang.TabIndex = 1
        '
        'NumericTextBoxHargaSatuan
        '
        Me.NumericTextBoxHargaSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericTextBoxHargaSatuan.Location = New System.Drawing.Point(15, 89)
        Me.NumericTextBoxHargaSatuan.Margin = New System.Windows.Forms.Padding(5)
        Me.NumericTextBoxHargaSatuan.Name = "NumericTextBoxHargaSatuan"
        Me.NumericTextBoxHargaSatuan.Size = New System.Drawing.Size(250, 22)
        Me.NumericTextBoxHargaSatuan.TabIndex = 2
        '
        'NumericTextBoxJumlahStock
        '
        Me.NumericTextBoxJumlahStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericTextBoxJumlahStock.Location = New System.Drawing.Point(15, 121)
        Me.NumericTextBoxJumlahStock.Margin = New System.Windows.Forms.Padding(5)
        Me.NumericTextBoxJumlahStock.Name = "NumericTextBoxJumlahStock"
        Me.NumericTextBoxJumlahStock.Size = New System.Drawing.Size(250, 22)
        Me.NumericTextBoxJumlahStock.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonDelete)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonInput)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(833, 61)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(735, 13)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 32)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Location = New System.Drawing.Point(654, 13)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 32)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "&Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Location = New System.Drawing.Point(573, 13)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 32)
        Me.ButtonDelete.TabIndex = 2
        Me.ButtonDelete.Text = "&Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonInput
        '
        Me.ButtonInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInput.Location = New System.Drawing.Point(492, 13)
        Me.ButtonInput.Name = "ButtonInput"
        Me.ButtonInput.Size = New System.Drawing.Size(75, 32)
        Me.ButtonInput.TabIndex = 3
        Me.ButtonInput.Text = "&Input"
        Me.ButtonInput.UseVisualStyleBackColor = True
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(833, 737)
        Me.Controls.Add(Me.SplitContainerMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBarang"
        Me.ShowInTaskbar = False
        Me.Text = "Form Barang"
        Me.SplitContainerMain.Panel1.ResumeLayout(False)
        Me.SplitContainerMain.Panel2.ResumeLayout(False)
        Me.SplitContainerMain.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerSouth.Panel1.ResumeLayout(False)
        Me.SplitContainerSouth.Panel2.ResumeLayout(False)
        Me.SplitContainerSouth.ResumeLayout(False)
        Me.SplitContainerContent.Panel1.ResumeLayout(False)
        Me.SplitContainerContent.Panel2.ResumeLayout(False)
        Me.SplitContainerContent.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanelInputContent.ResumeLayout(False)
        Me.FlowLayoutPanelInputContent.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerMain As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainerSouth As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonInput As System.Windows.Forms.Button
    Friend WithEvents SplitContainerContent As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanelInputContent As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TextBoxKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents NumericTextBoxHargaSatuan As Inventory.CustomControls.NumericTextBox
    Friend WithEvents NumericTextBoxJumlahStock As Inventory.CustomControls.NumericTextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Kode_Barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama_Barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Harga_Barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock_Barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
