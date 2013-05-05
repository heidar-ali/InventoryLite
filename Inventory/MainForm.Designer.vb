<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PengeluaranBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PenerimaanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanHarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanBulananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChartBulananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMasterToolStripMenuItem, Me.PengeluaranBarangToolStripMenuItem, Me.PenerimaanBarangToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(952, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.CustomerToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(92, 21)
        Me.DataMasterToolStripMenuItem.Text = "Data Master"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'PengeluaranBarangToolStripMenuItem
        '
        Me.PengeluaranBarangToolStripMenuItem.Name = "PengeluaranBarangToolStripMenuItem"
        Me.PengeluaranBarangToolStripMenuItem.Size = New System.Drawing.Size(137, 21)
        Me.PengeluaranBarangToolStripMenuItem.Text = "Pengeluaran Barang"
        '
        'PenerimaanBarangToolStripMenuItem
        '
        Me.PenerimaanBarangToolStripMenuItem.Name = "PenerimaanBarangToolStripMenuItem"
        Me.PenerimaanBarangToolStripMenuItem.Size = New System.Drawing.Size(133, 21)
        Me.PenerimaanBarangToolStripMenuItem.Text = "Penerimaan Barang"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanHarianToolStripMenuItem, Me.LaporanBulananToolStripMenuItem, Me.ChartBulananToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanHarianToolStripMenuItem
        '
        Me.LaporanHarianToolStripMenuItem.Name = "LaporanHarianToolStripMenuItem"
        Me.LaporanHarianToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.LaporanHarianToolStripMenuItem.Text = "Laporan Harian"
        '
        'LaporanBulananToolStripMenuItem
        '
        Me.LaporanBulananToolStripMenuItem.Name = "LaporanBulananToolStripMenuItem"
        Me.LaporanBulananToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.LaporanBulananToolStripMenuItem.Text = "Laporan Bulanan"
        '
        'ChartBulananToolStripMenuItem
        '
        Me.ChartBulananToolStripMenuItem.Name = "ChartBulananToolStripMenuItem"
        Me.ChartBulananToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ChartBulananToolStripMenuItem.Text = "Chart Bulanan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(57, 21)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(952, 554)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Inventory - CV. Arcoma Basco"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengeluaranBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenerimaanBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanHarianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanBulananToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChartBulananToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
