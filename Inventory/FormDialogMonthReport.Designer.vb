<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDialogMonthReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDialogMonthReport))
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.ButtonView = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(245, 186)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 32)
        Me.ButtonClose.TabIndex = 10
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonView
        '
        Me.ButtonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonView.Location = New System.Drawing.Point(164, 186)
        Me.ButtonView.Name = "ButtonView"
        Me.ButtonView.Size = New System.Drawing.Size(75, 32)
        Me.ButtonView.TabIndex = 11
        Me.ButtonView.Text = "&View"
        Me.ButtonView.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bulan"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMMM yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(120, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 6
        '
        'FormDialogMonthReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(354, 282)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDialogMonthReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Month Parameter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonView As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
