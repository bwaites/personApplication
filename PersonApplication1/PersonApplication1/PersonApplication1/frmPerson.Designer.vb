<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerson
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
        Me.dgvPerson = New System.Windows.Forms.DataGridView()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvPersonPhone = New System.Windows.Forms.DataGridView()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PhoneTypeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPersonEmail = New System.Windows.Forms.DataGridView()
        Me.dgvPersonAddress = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvPersonPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPersonEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPersonAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPerson
        '
        Me.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerson.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstName, Me.LastName})
        Me.dgvPerson.Location = New System.Drawing.Point(12, 67)
        Me.dgvPerson.Name = "dgvPerson"
        Me.dgvPerson.Size = New System.Drawing.Size(244, 529)
        Me.dgvPerson.TabIndex = 0
        '
        'FirstName
        '
        Me.FirstName.DataPropertyName = "FirstName"
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "LastName"
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(12, 40)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(163, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(181, 37)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1000, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(98, 22)
        Me.mnuSave.Text = "Save"
        '
        'dgvPersonPhone
        '
        Me.dgvPersonPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonPhone.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Number, Me.PhoneType, Me.PhoneTypeId})
        Me.dgvPersonPhone.Location = New System.Drawing.Point(262, 67)
        Me.dgvPersonPhone.Name = "dgvPersonPhone"
        Me.dgvPersonPhone.Size = New System.Drawing.Size(344, 184)
        Me.dgvPersonPhone.TabIndex = 5
        '
        'Number
        '
        Me.Number.DataPropertyName = "Number"
        Me.Number.HeaderText = "Phone Number"
        Me.Number.Name = "Number"
        '
        'PhoneType
        '
        Me.PhoneType.DataPropertyName = "PhoneTypeId"
        Me.PhoneType.HeaderText = "Phone Type"
        Me.PhoneType.Name = "PhoneType"
        '
        'PhoneTypeId
        '
        Me.PhoneTypeId.DataPropertyName = "PhoneTypeId"
        Me.PhoneTypeId.HeaderText = "Phone Type Id"
        Me.PhoneTypeId.Name = "PhoneTypeId"
        '
        'dgvPersonEmail
        '
        Me.dgvPersonEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonEmail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvPersonEmail.Location = New System.Drawing.Point(262, 258)
        Me.dgvPersonEmail.Name = "dgvPersonEmail"
        Me.dgvPersonEmail.Size = New System.Drawing.Size(344, 163)
        Me.dgvPersonEmail.TabIndex = 6
        '
        'dgvPersonAddress
        '
        Me.dgvPersonAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonAddress.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column9, Me.Column8})
        Me.dgvPersonAddress.Location = New System.Drawing.Point(262, 427)
        Me.dgvPersonAddress.Name = "dgvPersonAddress"
        Me.dgvPersonAddress.Size = New System.Drawing.Size(646, 169)
        Me.dgvPersonAddress.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Email"
        Me.Column1.HeaderText = "Email Address"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "EmailTypeId"
        Me.Column2.HeaderText = "Email Type"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "EmailTypeId"
        Me.Column3.HeaderText = "EmailTypeId"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Street"
        Me.Column4.HeaderText = "Street"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "City"
        Me.Column5.HeaderText = "City"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "State"
        Me.Column6.HeaderText = "State"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Zip"
        Me.Column7.HeaderText = "Zipcode"
        Me.Column7.Name = "Column7"
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "AddressTypeId"
        Me.Column9.HeaderText = "Address Type"
        Me.Column9.Name = "Column9"
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "AddressTypeId"
        Me.Column8.HeaderText = "AddressTypeId"
        Me.Column8.Name = "Column8"
        '
        'frmPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 608)
        Me.Controls.Add(Me.dgvPersonAddress)
        Me.Controls.Add(Me.dgvPersonEmail)
        Me.Controls.Add(Me.dgvPersonPhone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.dgvPerson)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPerson"
        Me.Text = "frmPerson"
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvPersonPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPersonEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPersonAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPerson As System.Windows.Forms.DataGridView
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvPersonPhone As System.Windows.Forms.DataGridView
    Friend WithEvents Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PhoneTypeId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvPersonEmail As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPersonAddress As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
