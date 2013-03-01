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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvPersonPhone = New System.Windows.Forms.DataGridView()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PhoneTypeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPersonAddress = New System.Windows.Forms.DataGridView()
        Me.dgvPersonEmail = New System.Windows.Forms.DataGridView()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EmailTypeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Zipcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AddressTypeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvPersonPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPersonAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPersonEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPerson
        '
        Me.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerson.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstName, Me.LastName})
        Me.dgvPerson.Location = New System.Drawing.Point(26, 28)
        Me.dgvPerson.Name = "dgvPerson"
        Me.dgvPerson.Size = New System.Drawing.Size(246, 302)
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
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(207, 336)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(101, 338)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1444, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuExit})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(98, 22)
        Me.mnuSave.Text = "Save"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(98, 22)
        Me.mnuExit.Text = "Exit"
        '
        'dgvPersonPhone
        '
        Me.dgvPersonPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonPhone.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Number, Me.PhoneType, Me.PhoneTypeID})
        Me.dgvPersonPhone.Location = New System.Drawing.Point(291, 28)
        Me.dgvPersonPhone.Name = "dgvPersonPhone"
        Me.dgvPersonPhone.Size = New System.Drawing.Size(345, 331)
        Me.dgvPersonPhone.TabIndex = 5
        '
        'Number
        '
        Me.Number.DataPropertyName = "Number"
        Me.Number.HeaderText = "Number"
        Me.Number.Name = "Number"
        '
        'PhoneType
        '
        Me.PhoneType.DataPropertyName = "PhoneTypeID"
        Me.PhoneType.HeaderText = "Phone Type"
        Me.PhoneType.Name = "PhoneType"
        '
        'PhoneTypeID
        '
        Me.PhoneTypeID.DataPropertyName = "PhoneTypeID"
        Me.PhoneTypeID.HeaderText = "Phone Type ID"
        Me.PhoneTypeID.Name = "PhoneTypeID"
        Me.PhoneTypeID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'dgvPersonAddress
        '
        Me.dgvPersonAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonAddress.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Type, Me.City, Me.State, Me.Zipcode, Me.AddressType, Me.AddressTypeID})
        Me.dgvPersonAddress.Location = New System.Drawing.Point(667, 27)
        Me.dgvPersonAddress.Name = "dgvPersonAddress"
        Me.dgvPersonAddress.Size = New System.Drawing.Size(551, 150)
        Me.dgvPersonAddress.TabIndex = 7
        '
        'dgvPersonEmail
        '
        Me.dgvPersonEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonEmail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Email, Me.EmailType, Me.EmailTypeID})
        Me.dgvPersonEmail.Location = New System.Drawing.Point(667, 219)
        Me.dgvPersonEmail.Name = "dgvPersonEmail"
        Me.dgvPersonEmail.Size = New System.Drawing.Size(346, 150)
        Me.dgvPersonEmail.TabIndex = 8
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'EmailType
        '
        Me.EmailType.DataPropertyName = "EmailTypeID"
        Me.EmailType.HeaderText = "Email Type"
        Me.EmailType.Name = "EmailType"
        '
        'EmailTypeID
        '
        Me.EmailTypeID.DataPropertyName = "EmailTypeID"
        Me.EmailTypeID.HeaderText = "Email Type ID"
        Me.EmailTypeID.Name = "EmailTypeID"
        '
        'Type
        '
        Me.Type.DataPropertyName = "Street"
        Me.Type.HeaderText = "Street"
        Me.Type.Name = "Type"
        Me.Type.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'City
        '
        Me.City.DataPropertyName = "City"
        Me.City.HeaderText = "City"
        Me.City.Name = "City"
        '
        'State
        '
        Me.State.DataPropertyName = "State"
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        '
        'Zipcode
        '
        Me.Zipcode.DataPropertyName = "Zipcode"
        Me.Zipcode.HeaderText = "Zipcode"
        Me.Zipcode.Name = "Zipcode"
        '
        'AddressType
        '
        Me.AddressType.DataPropertyName = "AddressTypeID"
        Me.AddressType.HeaderText = "Address Type"
        Me.AddressType.Name = "AddressType"
        '
        'AddressTypeID
        '
        Me.AddressTypeID.DataPropertyName = "AddressTypeID"
        Me.AddressTypeID.HeaderText = "Address Type ID"
        Me.AddressTypeID.Name = "AddressTypeID"
        Me.AddressTypeID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AddressTypeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1444, 463)
        Me.Controls.Add(Me.dgvPersonEmail)
        Me.Controls.Add(Me.dgvPersonAddress)
        Me.Controls.Add(Me.dgvPersonPhone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgvPerson)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPerson"
        Me.Text = "frmPerson"
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvPersonPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPersonAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPersonEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPerson As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvPersonPhone As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPersonAddress As System.Windows.Forms.DataGridView
    Friend WithEvents Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PhoneTypeID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvPersonEmail As System.Windows.Forms.DataGridView
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents EmailTypeID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents City As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents State As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Zipcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents AddressTypeID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
