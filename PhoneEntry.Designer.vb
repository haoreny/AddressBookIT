<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhoneEntry
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchNumberBtn = New System.Windows.Forms.Button()
        Me.NewEntryBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Phone #"
        '
        'SearchNumberBtn
        '
        Me.SearchNumberBtn.BackColor = System.Drawing.SystemColors.Control
        Me.SearchNumberBtn.Location = New System.Drawing.Point(12, 86)
        Me.SearchNumberBtn.Name = "SearchNumberBtn"
        Me.SearchNumberBtn.Size = New System.Drawing.Size(87, 32)
        Me.SearchNumberBtn.TabIndex = 3
        Me.SearchNumberBtn.Text = "Search"
        Me.SearchNumberBtn.UseVisualStyleBackColor = True
        '
        'NewEntryBtn
        '
        Me.NewEntryBtn.Location = New System.Drawing.Point(119, 86)
        Me.NewEntryBtn.Name = "NewEntryBtn"
        Me.NewEntryBtn.Size = New System.Drawing.Size(87, 32)
        Me.NewEntryBtn.TabIndex = 4
        Me.NewEntryBtn.Text = "New Entry"
        Me.NewEntryBtn.UseVisualStyleBackColor = True
        '
        'PhoneEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 133)
        Me.Controls.Add(Me.NewEntryBtn)
        Me.Controls.Add(Me.SearchNumberBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "PhoneEntry"
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchNumberBtn As Button
    Friend WithEvents NewEntryBtn As Button
End Class
