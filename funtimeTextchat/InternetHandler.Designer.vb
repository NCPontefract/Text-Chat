<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InternetHandler
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
        Me.action = New System.Windows.Forms.Button()
        Me.setIP = New System.Windows.Forms.Button()
        Me.SetPath = New System.Windows.Forms.Button()
        Me.SetName = New System.Windows.Forms.Button()
        Me.IPAddr = New System.Windows.Forms.TextBox()
        Me.FilePathAddr = New System.Windows.Forms.TextBox()
        Me.FileName = New System.Windows.Forms.TextBox()
        Me.DownloadBttn = New System.Windows.Forms.RadioButton()
        Me.UploadBttn = New System.Windows.Forms.RadioButton()
        Me.DeleteBttn = New System.Windows.Forms.RadioButton()
        Me.SetDownloadLocation = New System.Windows.Forms.Button()
        Me.DownloadLocation = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'action
        '
        Me.action.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.action.Location = New System.Drawing.Point(0, 152)
        Me.action.Name = "action"
        Me.action.Size = New System.Drawing.Size(386, 23)
        Me.action.TabIndex = 0
        Me.action.Text = "Action"
        Me.action.UseVisualStyleBackColor = True
        '
        'setIP
        '
        Me.setIP.Location = New System.Drawing.Point(12, 12)
        Me.setIP.Name = "setIP"
        Me.setIP.Size = New System.Drawing.Size(168, 23)
        Me.setIP.TabIndex = 1
        Me.setIP.Text = "Set IP Addr"
        Me.setIP.UseVisualStyleBackColor = True
        '
        'SetPath
        '
        Me.SetPath.Location = New System.Drawing.Point(12, 41)
        Me.SetPath.Name = "SetPath"
        Me.SetPath.Size = New System.Drawing.Size(168, 23)
        Me.SetPath.TabIndex = 2
        Me.SetPath.Text = "Set FileAddrDir"
        Me.SetPath.UseVisualStyleBackColor = True
        '
        'SetName
        '
        Me.SetName.Location = New System.Drawing.Point(12, 70)
        Me.SetName.Name = "SetName"
        Me.SetName.Size = New System.Drawing.Size(168, 23)
        Me.SetName.TabIndex = 3
        Me.SetName.Text = "Set FileName+Type"
        Me.SetName.UseVisualStyleBackColor = True
        '
        'IPAddr
        '
        Me.IPAddr.Location = New System.Drawing.Point(186, 12)
        Me.IPAddr.Name = "IPAddr"
        Me.IPAddr.Size = New System.Drawing.Size(188, 20)
        Me.IPAddr.TabIndex = 4
        '
        'FilePathAddr
        '
        Me.FilePathAddr.Location = New System.Drawing.Point(186, 41)
        Me.FilePathAddr.Name = "FilePathAddr"
        Me.FilePathAddr.Size = New System.Drawing.Size(188, 20)
        Me.FilePathAddr.TabIndex = 5
        '
        'FileName
        '
        Me.FileName.Location = New System.Drawing.Point(186, 70)
        Me.FileName.Name = "FileName"
        Me.FileName.Size = New System.Drawing.Size(188, 20)
        Me.FileName.TabIndex = 6
        '
        'DownloadBttn
        '
        Me.DownloadBttn.AutoSize = True
        Me.DownloadBttn.Location = New System.Drawing.Point(107, 129)
        Me.DownloadBttn.Name = "DownloadBttn"
        Me.DownloadBttn.Size = New System.Drawing.Size(73, 17)
        Me.DownloadBttn.TabIndex = 7
        Me.DownloadBttn.TabStop = True
        Me.DownloadBttn.Text = "Download"
        Me.DownloadBttn.UseVisualStyleBackColor = True
        '
        'UploadBttn
        '
        Me.UploadBttn.AutoSize = True
        Me.UploadBttn.Location = New System.Drawing.Point(186, 129)
        Me.UploadBttn.Name = "UploadBttn"
        Me.UploadBttn.Size = New System.Drawing.Size(59, 17)
        Me.UploadBttn.TabIndex = 8
        Me.UploadBttn.TabStop = True
        Me.UploadBttn.Text = "Upload"
        Me.UploadBttn.UseVisualStyleBackColor = True
        '
        'DeleteBttn
        '
        Me.DeleteBttn.AutoSize = True
        Me.DeleteBttn.Location = New System.Drawing.Point(251, 129)
        Me.DeleteBttn.Name = "DeleteBttn"
        Me.DeleteBttn.Size = New System.Drawing.Size(56, 17)
        Me.DeleteBttn.TabIndex = 9
        Me.DeleteBttn.TabStop = True
        Me.DeleteBttn.Text = "Delete"
        Me.DeleteBttn.UseVisualStyleBackColor = True
        '
        'SetDownloadLocation
        '
        Me.SetDownloadLocation.Location = New System.Drawing.Point(12, 99)
        Me.SetDownloadLocation.Name = "SetDownloadLocation"
        Me.SetDownloadLocation.Size = New System.Drawing.Size(168, 23)
        Me.SetDownloadLocation.TabIndex = 10
        Me.SetDownloadLocation.Text = "SetDownloadFolder"
        Me.SetDownloadLocation.UseVisualStyleBackColor = True
        '
        'DownloadLocation
        '
        Me.DownloadLocation.Location = New System.Drawing.Point(186, 99)
        Me.DownloadLocation.Name = "DownloadLocation"
        Me.DownloadLocation.Size = New System.Drawing.Size(188, 20)
        Me.DownloadLocation.TabIndex = 11
        '
        'InternetHandler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 175)
        Me.Controls.Add(Me.DownloadLocation)
        Me.Controls.Add(Me.SetDownloadLocation)
        Me.Controls.Add(Me.DeleteBttn)
        Me.Controls.Add(Me.UploadBttn)
        Me.Controls.Add(Me.DownloadBttn)
        Me.Controls.Add(Me.FileName)
        Me.Controls.Add(Me.FilePathAddr)
        Me.Controls.Add(Me.IPAddr)
        Me.Controls.Add(Me.SetName)
        Me.Controls.Add(Me.SetPath)
        Me.Controls.Add(Me.setIP)
        Me.Controls.Add(Me.action)
        Me.Name = "InternetHandler"
        Me.Text = "InternetHandler"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents action As Button
    Friend WithEvents setIP As Button
    Friend WithEvents SetPath As Button
    Friend WithEvents SetName As Button
    Friend WithEvents IPAddr As TextBox
    Friend WithEvents FilePathAddr As TextBox
    Friend WithEvents FileName As TextBox
    Friend WithEvents DownloadBttn As RadioButton
    Friend WithEvents UploadBttn As RadioButton
    Friend WithEvents DeleteBttn As RadioButton
    Friend WithEvents SetDownloadLocation As Button
    Friend WithEvents DownloadLocation As TextBox
End Class
