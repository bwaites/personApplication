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
        Me.btnSearchPeople = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvPersonPhone = New System.Windows.Forms.DataGridView()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PhoneTypeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPersonEmail = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPersonAddress = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpSearch = New System.Windows.Forms.TabPage()
        Me.btnSearchPhones = New System.Windows.Forms.Button()
        Me.txtSearchEmails = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.btnSearchAddresses = New System.Windows.Forms.Button()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.tpPersonInfo = New System.Windows.Forms.TabPage()
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvPersonPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPersonEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPersonAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tpSearch.SuspendLayout()
        Me.tpPersonInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPerson
        '
        Me.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerson.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstName, Me.LastName})
        Me.dgvPerson.Location = New System.Drawing.Point(6, 6)
        Me.dgvPerson.Name = "dgvPerson"
        Me.dgvPerson.Size = New System.Drawing.Size(271, 453)
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
        Me.txtFirstName.Location = New System.Drawing.Point(69, 18)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(163, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'btnSearchPeople
        '
        Me.btnSearchPeople.Location = New System.Drawing.Point(324, 30)
        Me.btnSearchPeople.Name = "btnSearchPeople"
        Me.btnSearchPeople.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchPeople.TabIndex = 2
        Me.btnSearchPeople.Text = "Search"
        Me.btnSearchPeople.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
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
        Me.dgvPersonPhone.Location = New System.Drawing.Point(307, 6)
        Me.dgvPersonPhone.Name = "dgvPersonPhone"
        Me.dgvPersonPhone.Size = New System.Drawing.Size(646, 184)
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
        Me.dgvPersonEmail.Location = New System.Drawing.Point(307, 196)
        Me.dgvPersonEmail.Name = "dgvPersonEmail"
        Me.dgvPersonEmail.Size = New System.Drawing.Size(646, 88)
        Me.dgvPersonEmail.TabIndex = 6
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
        'dgvPersonAddress
        '
        Me.dgvPersonAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonAddress.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column9, Me.Column8})
        Me.dgvPersonAddress.Location = New System.Drawing.Point(307, 290)
        Me.dgvPersonAddress.Name = "dgvPersonAddress"
        Me.dgvPersonAddress.Size = New System.Drawing.Size(646, 169)
        Me.dgvPersonAddress.TabIndex = 7
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
        Me.Column7.DataPropertyName = "Zipcode"
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpSearch)
        Me.TabControl1.Controls.Add(Me.tpPersonInfo)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(976, 503)
        Me.TabControl1.TabIndex = 8
        '
        'tpSearch
        '
        Me.tpSearch.Controls.Add(Me.btnSearchPhones)
        Me.tpSearch.Controls.Add(Me.txtSearchEmails)
        Me.tpSearch.Controls.Add(Me.txtEmail)
        Me.tpSearch.Controls.Add(Me.txtPhone)
        Me.tpSearch.Controls.Add(Me.Label7)
        Me.tpSearch.Controls.Add(Me.lblPhone)
        Me.tpSearch.Controls.Add(Me.btnSearchAddresses)
        Me.tpSearch.Controls.Add(Me.txtZip)
        Me.tpSearch.Controls.Add(Me.txtState)
        Me.tpSearch.Controls.Add(Me.txtCity)
        Me.tpSearch.Controls.Add(Me.txtStreet)
        Me.tpSearch.Controls.Add(Me.Label5)
        Me.tpSearch.Controls.Add(Me.Label4)
        Me.tpSearch.Controls.Add(Me.Label3)
        Me.tpSearch.Controls.Add(Me.Label2)
        Me.tpSearch.Controls.Add(Me.txtLastName)
        Me.tpSearch.Controls.Add(Me.lblLastName)
        Me.tpSearch.Controls.Add(Me.txtFirstName)
        Me.tpSearch.Controls.Add(Me.btnSearchPeople)
        Me.tpSearch.Controls.Add(Me.Label1)
        Me.tpSearch.Location = New System.Drawing.Point(4, 22)
        Me.tpSearch.Name = "tpSearch"
        Me.tpSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSearch.Size = New System.Drawing.Size(968, 477)
        Me.tpSearch.TabIndex = 0
        Me.tpSearch.Text = "Search"
        Me.tpSearch.UseVisualStyleBackColor = True
        '
        'btnSearchPhones
        '
        Me.btnSearchPhones.Location = New System.Drawing.Point(324, 290)
        Me.btnSearchPhones.Name = "btnSearchPhones"
        Me.btnSearchPhones.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchPhones.TabIndex = 20
        Me.btnSearchPhones.Text = "Search"
        Me.btnSearchPhones.UseVisualStyleBackColor = True
        '
        'txtSearchEmails
        '
        Me.txtSearchEmails.Location = New System.Drawing.Point(324, 315)
        Me.txtSearchEmails.Name = "txtSearchEmails"
        Me.txtSearchEmails.Size = New System.Drawing.Size(75, 23)
        Me.txtSearchEmails.TabIndex = 19
        Me.txtSearchEmails.Text = "Search"
        Me.txtSearchEmails.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(69, 318)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(163, 20)
        Me.txtEmail.TabIndex = 18
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(69, 292)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(163, 20)
        Me.txtPhone.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Email"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(7, 292)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblPhone.TabIndex = 15
        Me.lblPhone.Text = "Phone"
        '
        'btnSearchAddresses
        '
        Me.btnSearchAddresses.Location = New System.Drawing.Point(324, 176)
        Me.btnSearchAddresses.Name = "btnSearchAddresses"
        Me.btnSearchAddresses.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchAddresses.TabIndex = 14
        Me.btnSearchAddresses.Text = "Search"
        Me.btnSearchAddresses.UseVisualStyleBackColor = True
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(69, 217)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(163, 20)
        Me.txtZip.TabIndex = 13
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(69, 193)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(163, 20)
        Me.txtState.TabIndex = 12
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(69, 170)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(163, 20)
        Me.txtCity.TabIndex = 11
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(69, 145)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(163, 20)
        Me.txtStreet.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Zip"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "State"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "City"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Address"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(69, 46)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(163, 20)
        Me.txtLastName.TabIndex = 5
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(6, 49)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.Text = "Last Name"
        '
        'tpPersonInfo
        '
        Me.tpPersonInfo.Controls.Add(Me.dgvPerson)
        Me.tpPersonInfo.Controls.Add(Me.dgvPersonAddress)
        Me.tpPersonInfo.Controls.Add(Me.dgvPersonPhone)
        Me.tpPersonInfo.Controls.Add(Me.dgvPersonEmail)
        Me.tpPersonInfo.Location = New System.Drawing.Point(4, 22)
        Me.tpPersonInfo.Name = "tpPersonInfo"
        Me.tpPersonInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPersonInfo.Size = New System.Drawing.Size(968, 477)
        Me.tpPersonInfo.TabIndex = 1
        Me.tpPersonInfo.Text = "Person Information"
        Me.tpPersonInfo.UseVisualStyleBackColor = True
        '
        'frmPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 608)
        Me.Controls.Add(Me.TabControl1)
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
        Me.TabControl1.ResumeLayout(False)
        Me.tpSearch.ResumeLayout(False)
        Me.tpSearch.PerformLayout()
        Me.tpPersonInfo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPerson As System.Windows.Forms.DataGridView
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchPeople As System.Windows.Forms.Button
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpSearch As System.Windows.Forms.TabPage
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents tpPersonInfo As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents btnSearchAddresses As System.Windows.Forms.Button
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSearchEmails As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchPhones As System.Windows.Forms.Button
End Class
