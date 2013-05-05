<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxUserName = New System.Windows.Forms.TextBox
        Me.TextBoxPassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ButtonLogin = New System.Windows.Forms.Button
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonCancel)
        Me.GroupBox1.Controls.Add(Me.ButtonLogin)
        Me.GroupBox1.Controls.Add(Me.TextBoxPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxUserName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 228)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.Location = New System.Drawing.Point(143, 48)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.Size = New System.Drawing.Size(229, 22)
        Me.TextBoxUserName.TabIndex = 1
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(143, 93)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(229, 22)
        Me.TextBoxPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(216, 193)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(75, 29)
        Me.ButtonLogin.TabIndex = 4
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(297, 193)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 29)
        Me.ButtonCancel.TabIndex = 5
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 290)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "LoginForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
End Class
