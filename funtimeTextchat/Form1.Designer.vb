<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Join = New System.Windows.Forms.Button()
        Me.RoomID = New System.Windows.Forms.TextBox()
        Me.MessageBoard = New System.Windows.Forms.RichTextBox()
        Me.Send = New System.Windows.Forms.Button()
        Me.MessageInput = New System.Windows.Forms.RichTextBox()
        Me.Leave = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.updateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Join
        '
        Me.Join.Location = New System.Drawing.Point(145, 12)
        Me.Join.Name = "Join"
        Me.Join.Size = New System.Drawing.Size(75, 23)
        Me.Join.TabIndex = 0
        Me.Join.Text = "Join Room"
        Me.Join.UseVisualStyleBackColor = True
        '
        'RoomID
        '
        Me.RoomID.Location = New System.Drawing.Point(12, 13)
        Me.RoomID.Name = "RoomID"
        Me.RoomID.Size = New System.Drawing.Size(127, 20)
        Me.RoomID.TabIndex = 1
        '
        'MessageBoard
        '
        Me.MessageBoard.Location = New System.Drawing.Point(12, 42)
        Me.MessageBoard.Name = "MessageBoard"
        Me.MessageBoard.Size = New System.Drawing.Size(456, 525)
        Me.MessageBoard.TabIndex = 2
        Me.MessageBoard.Text = ""
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(394, 614)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(74, 23)
        Me.Send.TabIndex = 0
        Me.Send.Text = "Send"
        Me.Send.UseVisualStyleBackColor = True
        '
        'MessageInput
        '
        Me.MessageInput.Location = New System.Drawing.Point(12, 573)
        Me.MessageInput.Name = "MessageInput"
        Me.MessageInput.Size = New System.Drawing.Size(376, 64)
        Me.MessageInput.TabIndex = 2
        Me.MessageInput.Text = ""
        '
        'Leave
        '
        Me.Leave.Location = New System.Drawing.Point(220, 12)
        Me.Leave.Name = "Leave"
        Me.Leave.Size = New System.Drawing.Size(80, 23)
        Me.Leave.TabIndex = 0
        Me.Leave.Text = "Leave Room"
        Me.Leave.UseVisualStyleBackColor = True
        '
        'Logout
        '
        Me.Logout.Location = New System.Drawing.Point(393, 13)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(75, 23)
        Me.Logout.TabIndex = 0
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'updateTimer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 649)
        Me.Controls.Add(Me.MessageInput)
        Me.Controls.Add(Me.MessageBoard)
        Me.Controls.Add(Me.RoomID)
        Me.Controls.Add(Me.Leave)
        Me.Controls.Add(Me.Join)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Send)
        Me.Name = "Form1"
        Me.Text = "Chatroom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Join As Button
    Friend WithEvents RoomID As TextBox
    Friend WithEvents MessageBoard As RichTextBox
    Friend WithEvents Send As Button
    Friend WithEvents MessageInput As RichTextBox
    Friend WithEvents Leave As Button
    Friend WithEvents Logout As Button
    Friend WithEvents updateTimer As Timer
End Class
