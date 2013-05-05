<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCustomers))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Kode_Customer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nama_Customer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Alamat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Telephone = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.SplitContainerMain = New System.Windows.Forms.SplitContainer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainerSouth = New System.Windows.Forms.SplitContainer
        Me.SplitContainerContent = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.FlowLayoutPanelInputContent = New System.Windows.Forms.FlowLayoutPanel
        Me.TextBoxKodeCustomer = New System.Windows.Forms.TextBox
        Me.TextBoxNamaCustomer = New System.Windows.Forms.TextBox
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox
        Me.TextBoxTelp = New System.Windows.Forms.TextBox
        Me.TextBoxEmail = New System.Windows.Forms.TextBox
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.ButtonInput = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerMain.Panel1.SuspendLayout()
        Me.SplitContainerMain.Panel2.SuspendLayout()
        Me.SplitContainerMain.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Cornsilk
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode_Customer, Me.Nama_Customer, Me.Alamat, Me.Telephone, Me.Email})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(838, 285)
        Me.DataGridView1.TabIndex = 0
        '
        'Kode_Customer
        '
        Me.Kode_Customer.DataPropertyName = "Kode_Customer"
        Me.Kode_Customer.HeaderText = "Kode Customer"
        Me.Kode_Customer.Name = "Kode_Customer"
        Me.Kode_Customer.Width = 140
        '
        'Nama_Customer
        '
        Me.Nama_Customer.DataPropertyName = "Nama_Customer"
        Me.Nama_Customer.HeaderText = "Nama Customer"
        Me.Nama_Customer.Name = "Nama_Customer"
        Me.Nama_Customer.Width = 280
        '
        'Alamat
        '
        Me.Alamat.DataPropertyName = "Alamat"
        Me.Alamat.HeaderText = "Alamat"
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Width = 180
        '
        'Telephone
        '
        Me.Telephone.DataPropertyName = "Telephone"
        Me.Telephone.HeaderText = "Telepon"
        Me.Telephone.Name = "Telephone"
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.Width = 210
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(740, 13)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 32)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
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
        'ButtonSave
        '
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Location = New System.Drawing.Point(659, 13)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 32)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "&Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Location = New System.Drawing.Point(578, 13)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 32)
        Me.ButtonDelete.TabIndex = 2
        Me.ButtonDelete.Text = "&Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
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
        Me.SplitContainerMain.Size = New System.Drawing.Size(838, 727)
        Me.SplitContainerMain.SplitterDistance = 430
        Me.SplitContainerMain.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer1.Size = New System.Drawing.Size(838, 430)
        Me.SplitContainer1.SplitterDistance = 141
        Me.SplitContainer1.TabIndex = 1
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
        Me.SplitContainerSouth.Size = New System.Drawing.Size(838, 293)
        Me.SplitContainerSouth.SplitterDistance = 228
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
        Me.SplitContainerContent.Size = New System.Drawing.Size(838, 228)
        Me.SplitContainerContent.SplitterDistance = 213
        Me.SplitContainerContent.TabIndex = 0
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
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(213, 228)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 12, 5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 12, 5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Customer"
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
        'FlowLayoutPanelInputContent
        '
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.TextBoxKodeCustomer)
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.TextBoxNamaCustomer)
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.TextBoxAlamat)
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.TextBoxTelp)
        Me.FlowLayoutPanelInputContent.Controls.Add(Me.TextBoxEmail)
        Me.FlowLayoutPanelInputContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelInputContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanelInputContent.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanelInputContent.Name = "FlowLayoutPanelInputContent"
        Me.FlowLayoutPanelInputContent.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.FlowLayoutPanelInputContent.Size = New System.Drawing.Size(621, 228)
        Me.FlowLayoutPanelInputContent.TabIndex = 1
        '
        'TextBoxKodeCustomer
        '
        Me.TextBoxKodeCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxKodeCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxKodeCustomer.Location = New System.Drawing.Point(15, 25)
        Me.TextBoxKodeCustomer.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxKodeCustomer.Name = "TextBoxKodeCustomer"
        Me.TextBoxKodeCustomer.Size = New System.Drawing.Size(248, 22)
        Me.TextBoxKodeCustomer.TabIndex = 0
        '
        'TextBoxNamaCustomer
        '
        Me.TextBoxNamaCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNamaCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNamaCustomer.Location = New System.Drawing.Point(15, 57)
        Me.TextBoxNamaCustomer.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxNamaCustomer.Name = "TextBoxNamaCustomer"
        Me.TextBoxNamaCustomer.Size = New System.Drawing.Size(248, 22)
        Me.TextBoxNamaCustomer.TabIndex = 1
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(838, 61)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'ButtonInput
        '
        Me.ButtonInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInput.Location = New System.Drawing.Point(497, 13)
        Me.ButtonInput.Name = "ButtonInput"
        Me.ButtonInput.Size = New System.Drawing.Size(75, 32)
        Me.ButtonInput.TabIndex = 3
        Me.ButtonInput.Text = "&Input"
        Me.ButtonInput.UseVisualStyleBackColor = True
        '
        'FormCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(838, 727)
        Me.Controls.Add(Me.SplitContainerMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCustomers"
        Me.ShowInTaskbar = False
        Me.Text = "Form Customer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerMain.Panel1.ResumeLayout(False)
        Me.SplitContainerMain.Panel2.ResumeLayout(False)
        Me.SplitContainerMain.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SplitContainerMain As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainerSouth As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainerContent As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanelInputContent As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TextBoxKodeCustomer As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNamaCustomer As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAlamat As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTelp As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtonInput As System.Windows.Forms.Button
    Friend WithEvents Kode_Customer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama_Customer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
