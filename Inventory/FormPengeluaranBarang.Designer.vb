<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengeluaranBarang
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPengeluaranBarang))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ComboBoxKodeCustomer = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePenerimaan = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxNoTerima = New System.Windows.Forms.TextBox
        Me.FlowLayoutPanelInputContent = New System.Windows.Forms.FlowLayoutPanel
        Me.SplitContainerMain = New System.Windows.Forms.SplitContainer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SplitContainerContent = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Crud = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kode_Barang = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Harga_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanelInputContent.SuspendLayout()
        Me.SplitContainerMain.Panel1.SuspendLayout()
        Me.SplitContainerMain.Panel2.SuspendLayout()
        Me.SplitContainerMain.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainerContent.Panel1.SuspendLayout()
        Me.SplitContainerContent.Panel2.SuspendLayout()
        Me.SplitContainerContent.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(597, 63)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(499, 13)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 32)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Location = New System.Drawing.Point(418, 13)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 32)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "&Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ComboBoxKodeCustomer
        '
        Me.ComboBoxKodeCustomer.BackColor = System.Drawing.Color.Gainsboro
        Me.ComboBoxKodeCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxKodeCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxKodeCustomer.FormattingEnabled = True
        Me.ComboBoxKodeCustomer.Location = New System.Drawing.Point(15, 57)
        Me.ComboBoxKodeCustomer.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBoxKodeCustomer.Name = "ComboBoxKodeCustomer"
        Me.ComboBoxKodeCustomer.Size = New System.Drawing.Size(248, 21)
        Me.ComboBoxKodeCustomer.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 12, 5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Keluar"
        '
        'DateTimePenerimaan
        '
        Me.DateTimePenerimaan.Location = New System.Drawing.Point(15, 88)
        Me.DateTimePenerimaan.Margin = New System.Windows.Forms.Padding(5)
        Me.DateTimePenerimaan.Name = "DateTimePenerimaan"
        Me.DateTimePenerimaan.Size = New System.Drawing.Size(250, 22)
        Me.DateTimePenerimaan.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 12, 5, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Customer"
        '
        'TextBoxNoTerima
        '
        Me.TextBoxNoTerima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNoTerima.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNoTerima.Location = New System.Drawing.Point(15, 25)
        Me.TextBoxNoTerima.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxNoTerima.Name = "TextBoxNoTerima"
        Me.TextBoxNoTerima.Size = New System.Drawing.Size(248, 22)
        Me.TextBoxNoTerima.TabIndex = 0
        '
        'FlowLayoutPanelInputContent
        '
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.TextBoxNoTerima)
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.ComboBoxKodeCustomer)
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.DateTimePenerimaan)
        Me.FlowLayoutPanelInputContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelInputContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanelInputContent.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanelInputContent.Name = "FlowLayoutPanelInputContent"
        Me.FlowLayoutPanelInputContent.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.FlowLayoutPanelInputContent.Size = New System.Drawing.Size(345, 136)
        Me.FlowLayoutPanelInputContent.TabIndex = 2
        '
        'SplitContainerMain
        '
        Me.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainerMain.IsSplitterFixed = True
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
        Me.SplitContainerMain.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainerMain.Size = New System.Drawing.Size(597, 666)
        Me.SplitContainerMain.SplitterDistance = 599
        Me.SplitContainerMain.TabIndex = 1
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(597, 599)
        Me.SplitContainer1.SplitterDistance = 270
        Me.SplitContainer1.TabIndex = 1
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainerContent)
        Me.SplitContainer2.Size = New System.Drawing.Size(597, 270)
        Me.SplitContainer2.SplitterDistance = 130
        Me.SplitContainer2.TabIndex = 3
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
        Me.SplitContainerContent.Size = New System.Drawing.Size(597, 136)
        Me.SplitContainerContent.SplitterDistance = 248
        Me.SplitContainerContent.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.FlowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(248, 136)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(140, 92)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 12, 5, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Keluar"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Crud, Me.Id, Me.Kode_Barang, Me.Jumlah, Me.Harga_Barang})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(597, 325)
        Me.DataGridView1.TabIndex = 2
        '
        'Crud
        '
        Me.Crud.DataPropertyName = "Crud"
        Me.Crud.HeaderText = "Crud"
        Me.Crud.Name = "Crud"
        Me.Crud.Visible = False
        Me.Crud.Width = 360
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        '
        'Kode_Barang
        '
        Me.Kode_Barang.DataPropertyName = "KodeBarang"
        Me.Kode_Barang.HeaderText = "Barang"
        Me.Kode_Barang.Name = "Kode_Barang"
        Me.Kode_Barang.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Kode_Barang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Kode_Barang.Width = 340
        '
        'Jumlah
        '
        Me.Jumlah.DataPropertyName = "Jumlah"
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        '
        'Harga_Barang
        '
        Me.Harga_Barang.DataPropertyName = "Harga_Barang"
        Me.Harga_Barang.HeaderText = "Harga"
        Me.Harga_Barang.Name = "Harga_Barang"
        Me.Harga_Barang.ReadOnly = True
        '
        'FormPengeluaranBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(597, 666)
        Me.Controls.Add(Me.SplitContainerMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPengeluaranBarang"
        Me.ShowInTaskbar = False
        Me.Text = "Form Pengeluaran Barang"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanelInputContent.ResumeLayout(False)
        Me.FlowLayoutPanelInputContent.PerformLayout()
        Me.SplitContainerMain.Panel1.ResumeLayout(False)
        Me.SplitContainerMain.Panel2.ResumeLayout(False)
        Me.SplitContainerMain.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainerContent.Panel1.ResumeLayout(False)
        Me.SplitContainerContent.Panel2.ResumeLayout(False)
        Me.SplitContainerContent.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ComboBoxKodeCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePenerimaan As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNoTerima As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanelInputContent As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents SplitContainerMain As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainerContent As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Crud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kode_Barang As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Harga_Barang As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
