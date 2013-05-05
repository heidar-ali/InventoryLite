<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupplier
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSupplier))
        Me.TextBoxKodeSupplier = New System.Windows.Forms.TextBox
        Me.FlowLayoutPanelInputContent = New System.Windows.Forms.FlowLayoutPanel
        Me.TextBoxNamaSupplier = New System.Windows.Forms.TextBox
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox
        Me.TextBoxTelp = New System.Windows.Forms.TextBox
        Me.TextBoxEmail = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonInput = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Kode_Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nama_Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Alamat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Telepon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainerMain = New System.Windows.Forms.SplitContainer
        Me.SplitContainerSouth = New System.Windows.Forms.SplitContainer
        Me.SplitContainerContent = New System.Windows.Forms.SplitContainer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanelInputContent.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerMain.Panel1.SuspendLayout()
        Me.SplitContainerMain.Panel2.SuspendLayout()
        Me.SplitContainerMain.SuspendLayout()
        Me.SplitContainerSouth.Panel1.SuspendLayout()
        Me.SplitContainerSouth.Panel2.SuspendLayout()
        Me.SplitContainerSouth.SuspendLayout()
        Me.SplitContainerContent.Panel1.SuspendLayout()
        Me.SplitContainerContent.Panel2.SuspendLayout()
        Me.SplitContainerContent.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxKodeSupplier
        '
        Me.TextBoxKodeSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxKodeSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxKodeSupplier.Location = New System.Drawing.Point(15, 25)
        Me.TextBoxKodeSupplier.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxKodeSupplier.Name = "TextBoxKodeSupplier"
        Me.TextBoxKodeSupplier.Size = New System.Drawing.Size(248, 22)
        Me.TextBoxKodeSupplier.TabIndex = 0
        '
        'FlowLayoutPanelInputContent
        '
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.TextBoxKodeSupplier)
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.TextBoxNamaSupplier)
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.TextBoxAlamat)
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.TextBoxTelp)
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.TextBoxEmail)
        Me.FlowLayoutPanelInputContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelInputContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanelInputContent.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanelInputContent.Name = "FlowLayoutPanelInputContent"
        Me.FlowLayoutPanelInputContent.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.FlowLayoutPanelInputContent.Size = New System.Drawing.Size(748, 222)
        Me.FlowLayoutPanelInputContent.TabIndex = 1
        '
        'TextBoxNamaSupplier
        '
        Me.TextBoxNamaSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNamaSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNamaSupplier.Location = New System.Drawing.Point(15, 57)
        Me.TextBoxNamaSupplier.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxNamaSupplier.Name = "TextBoxNamaSupplier"
        Me.TextBoxNamaSupplier.Size = New System.Drawing.Size(248, 22)
        Me.TextBoxNamaSupplier.TabIndex = 1
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAlamat.Location = New System.Drawing.Point(15, 89)
        Me.TextBoxAlamat.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(248, 22)
        Me.TextBoxAlamat.TabIndex = 2
        '
        'TextBoxTelp
        '
        Me.TextBoxTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTelp.Location = New System.Drawing.Point(15, 121)
        Me.TextBoxTelp.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxTelp.Name = "TextBoxTelp"
        Me.TextBoxTelp.Size = New System.Drawing.Size(248, 22)
        Me.TextBoxTelp.TabIndex = 3
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxEmail.Location = New System.Drawing.Point(15, 153)
        Me.TextBoxEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(248, 22)
        Me.TextBoxEmail.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 12, 5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Supplier"
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(867, 13)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 32)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(965, 61)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'ButtonSave
        '
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Location = New System.Drawing.Point(786, 13)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 32)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "&Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Location = New System.Drawing.Point(705, 13)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 32)
        Me.ButtonDelete.TabIndex = 2
        Me.ButtonDelete.Text = "&Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonInput
        '
        Me.ButtonInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInput.Location = New System.Drawing.Point(624, 13)
        Me.ButtonInput.Name = "ButtonInput"
        Me.ButtonInput.Size = New System.Drawing.Size(75, 32)
        Me.ButtonInput.TabIndex = 3
        Me.ButtonInput.Text = "&Input"
        Me.ButtonInput.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 12, 5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Supplier"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.FlowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(213, 222)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 14, 5, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 15, 5, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No. Telp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(154, 159)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 14, 5, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Cornsilk
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode_Supplier, Me.Nama_Supplier, Me.Alamat, Me.Telepon, Me.Email})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(965, 234)
        Me.DataGridView1.TabIndex = 0
        '
        'Kode_Supplier
        '
        Me.Kode_Supplier.DataPropertyName = "Kode_Supplier"
        Me.Kode_Supplier.HeaderText = "Kode Supplier"
        Me.Kode_Supplier.Name = "Kode_Supplier"
        Me.Kode_Supplier.Width = 140
        '
        'Nama_Supplier
        '
        Me.Nama_Supplier.DataPropertyName = "Nama_Supplier"
        Me.Nama_Supplier.HeaderText = "Nama Supplier"
        Me.Nama_Supplier.Name = "Nama_Supplier"
        Me.Nama_Supplier.Width = 280
        '
        'Alamat
        '
        Me.Alamat.DataPropertyName = "Alamat"
        Me.Alamat.HeaderText = "Alamat"
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Width = 180
        '
        'Telepon
        '
        Me.Telepon.DataPropertyName = "Telepon"
        Me.Telepon.HeaderText = "Telepon"
        Me.Telepon.Name = "Telepon"
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.Width = 210
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
        Me.SplitContainerMain.Size = New System.Drawing.Size(965, 659)
        Me.SplitContainerMain.SplitterDistance = 368
        Me.SplitContainerMain.TabIndex = 1
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
        Me.SplitContainerSouth.Size = New System.Drawing.Size(965, 287)
        Me.SplitContainerSouth.SplitterDistance = 222
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
        Me.SplitContainerContent.Size = New System.Drawing.Size(965, 222)
        Me.SplitContainerContent.SplitterDistance = 213
        Me.SplitContainerContent.TabIndex = 0
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
        Me.SplitContainer1.Size = New System.Drawing.Size(965, 368)
        Me.SplitContainer1.SplitterDistance = 130
        Me.SplitContainer1.TabIndex = 3
        '
        'FormSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(965, 659)
        Me.Controls.Add(Me.SplitContainerMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSupplier"
        Me.ShowInTaskbar = False
        Me.Text = "Form Supplier"
        Me.FlowLayoutPanelInputContent.ResumeLayout(False)
        Me.FlowLayoutPanelInputContent.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerMain.Panel1.ResumeLayout(False)
        Me.SplitContainerMain.Panel2.ResumeLayout(False)
        Me.SplitContainerMain.ResumeLayout(False)
        Me.SplitContainerSouth.Panel1.ResumeLayout(False)
        Me.SplitContainerSouth.Panel2.ResumeLayout(False)
        Me.SplitContainerSouth.ResumeLayout(False)
        Me.SplitContainerContent.Panel1.ResumeLayout(False)
        Me.SplitContainerContent.Panel2.ResumeLayout(False)
        Me.SplitContainerContent.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxKodeSupplier As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanelInputContent As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TextBoxNamaSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonInput As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainerMain As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainerSouth As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainerContent As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBoxAlamat As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTelp As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Kode_Supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama_Supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telepon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
