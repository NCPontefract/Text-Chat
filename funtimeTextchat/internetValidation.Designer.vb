<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class internetValidation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IP_Textbox = New System.Windows.Forms.TextBox()
        Me.Password_Textbox = New System.Windows.Forms.TextBox()
        Me.Username_Textbox = New System.Windows.Forms.TextBox()
        Me.portTextbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(170, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Port"
        '
        'IP_Textbox
        '
        Me.IP_Textbox.Location = New System.Drawing.Point(64, 7)
        Me.IP_Textbox.Name = "IP_Textbox"
        Me.IP_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.IP_Textbox.TabIndex = 0
        '
        'Password_Textbox
        '
        Me.Password_Textbox.Location = New System.Drawing.Point(64, 59)
        Me.Password_Textbox.Name = "Password_Textbox"
        Me.Password_Textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_Textbox.Size = New System.Drawing.Size(178, 20)
        Me.Password_Textbox.TabIndex = 2
        '
        'Username_Textbox
        '
        Me.Username_Textbox.Location = New System.Drawing.Point(64, 33)
        Me.Username_Textbox.Name = "Username_Textbox"
        Me.Username_Textbox.Size = New System.Drawing.Size(178, 20)
        Me.Username_Textbox.TabIndex = 1
        '
        'portTextbox
        '
        Me.portTextbox.Location = New System.Drawing.Point(197, 7)
        Me.portTextbox.Name = "portTextbox"
        Me.portTextbox.Size = New System.Drawing.Size(45, 20)
        Me.portTextbox.TabIndex = 6
        Me.portTextbox.Text = "21"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(250, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Continue"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(250, 59)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'internetValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(337, 87)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.portTextbox)
        Me.Controls.Add(Me.Username_Textbox)
        Me.Controls.Add(Me.Password_Textbox)
        Me.Controls.Add(Me.IP_Textbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(353, 126)
        Me.MinimumSize = New System.Drawing.Size(353, 126)
        Me.Name = "internetValidation"
        Me.Text = "Connection Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IP_Textbox As TextBox
    Friend WithEvents Password_Textbox As TextBox
    Friend WithEvents Username_Textbox As TextBox
    Friend WithEvents portTextbox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
