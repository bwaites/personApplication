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
        Me.btnGet = New System.Windows.Forms.Button()
        Me.txtConnectionName = New System.Windows.Forms.TextBox()
        Me.lblConnectionString = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(107, 227)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(75, 23)
        Me.btnGet.TabIndex = 0
        Me.btnGet.Text = "Get"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'txtConnectionName
        '
        Me.txtConnectionName.Location = New System.Drawing.Point(21, 38)
        Me.txtConnectionName.Name = "txtConnectionName"
        Me.txtConnectionName.Size = New System.Drawing.Size(240, 20)
        Me.txtConnectionName.TabIndex = 1
        '
        'lblConnectionString
        '
        Me.lblConnectionString.AutoSize = True
        Me.lblConnectionString.Location = New System.Drawing.Point(21, 94)
        Me.lblConnectionString.Name = "lblConnectionString"
        Me.lblConnectionString.Size = New System.Drawing.Size(39, 13)
        Me.lblConnectionString.TabIndex = 2
        Me.lblConnectionString.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblConnectionString)
        Me.Controls.Add(Me.txtConnectionName)
        Me.Controls.Add(Me.btnGet)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGet As System.Windows.Forms.Button
    Friend WithEvents txtConnectionName As System.Windows.Forms.TextBox
    Friend WithEvents lblConnectionString As System.Windows.Forms.Label

End Class
