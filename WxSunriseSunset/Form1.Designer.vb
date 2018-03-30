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
        Me.RtbRaw = New System.Windows.Forms.RichTextBox()
        Me.RtbInfo = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtLatitude = New System.Windows.Forms.TextBox()
        Me.TxtLongitude = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RtbRaw
        '
        Me.RtbRaw.Dock = System.Windows.Forms.DockStyle.Top
        Me.RtbRaw.Location = New System.Drawing.Point(0, 0)
        Me.RtbRaw.Name = "RtbRaw"
        Me.RtbRaw.Size = New System.Drawing.Size(386, 117)
        Me.RtbRaw.TabIndex = 0
        Me.RtbRaw.Text = ""
        '
        'RtbInfo
        '
        Me.RtbInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.RtbInfo.Location = New System.Drawing.Point(0, 117)
        Me.RtbInfo.Name = "RtbInfo"
        Me.RtbInfo.Size = New System.Drawing.Size(386, 156)
        Me.RtbInfo.TabIndex = 1
        Me.RtbInfo.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(161, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Fetch"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Latitude: "
        '
        'TxtLatitude
        '
        Me.TxtLatitude.Location = New System.Drawing.Point(75, 291)
        Me.TxtLatitude.Name = "TxtLatitude"
        Me.TxtLatitude.Size = New System.Drawing.Size(100, 20)
        Me.TxtLatitude.TabIndex = 4
        Me.TxtLatitude.Text = "35.12345"
        '
        'TxtLongitude
        '
        Me.TxtLongitude.Location = New System.Drawing.Point(263, 291)
        Me.TxtLongitude.Name = "TxtLongitude"
        Me.TxtLongitude.Size = New System.Drawing.Size(100, 20)
        Me.TxtLongitude.TabIndex = 6
        Me.TxtLongitude.Text = "-79.12345"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Longitude:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 354)
        Me.Controls.Add(Me.TxtLongitude)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtLatitude)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RtbInfo)
        Me.Controls.Add(Me.RtbRaw)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RtbRaw As RichTextBox
    Friend WithEvents RtbInfo As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtLatitude As TextBox
    Friend WithEvents TxtLongitude As TextBox
    Friend WithEvents Label2 As Label
End Class
