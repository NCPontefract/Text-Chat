<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class internetChatform
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
        Me.components = New System.ComponentModel.Container()
        Me.join = New System.Windows.Forms.Button()
        Me.leave = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.outputBox = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.send = New System.Windows.Forms.Button()
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'join
        '
        Me.join.Location = New System.Drawing.Point(167, 10)
        Me.join.Name = "join"
        Me.join.Size = New System.Drawing.Size(75, 23)
        Me.join.TabIndex = 0
        Me.join.Text = "Join"
        Me.join.UseVisualStyleBackColor = True
        '
        'leave
        '
        Me.leave.Location = New System.Drawing.Point(248, 10)
        Me.leave.Name = "leave"
        Me.leave.Size = New System.Drawing.Size(75, 23)
        Me.leave.TabIndex = 1
        Me.leave.Text = "Leave"
        Me.leave.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(61, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Room ID:"
        '
        'outputBox
        '
        Me.outputBox.Enabled = False
        Me.outputBox.Location = New System.Drawing.Point(6, 38)
        Me.outputBox.Name = "outputBox"
        Me.outputBox.Size = New System.Drawing.Size(317, 512)
        Me.outputBox.TabIndex = 4
        Me.outputBox.Text = ""
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(329, 10)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(194, 511)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'send
        '
        Me.send.Location = New System.Drawing.Point(329, 527)
        Me.send.Name = "send"
        Me.send.Size = New System.Drawing.Size(194, 23)
        Me.send.TabIndex = 6
        Me.send.Text = "Send"
        Me.send.UseVisualStyleBackColor = True
        '
        'Updater
        '
        Me.Updater.Interval = 1000
        '
        'internetChatform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 562)
        Me.Controls.Add(Me.send)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.outputBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.leave)
        Me.Controls.Add(Me.join)
        Me.Name = "internetChatform"
        Me.Text = "Chatroom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents join As Button
    Friend WithEvents leave As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents outputBox As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents send As Button
    Friend WithEvents Updater As Timer
End Class
