<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecurityQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecurityAnswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StoryAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvStory = New System.Windows.Forms.DataGridView()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Summary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaturityID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvFandom = New System.Windows.Forms.DataGridView()
        Me.FandomName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGenre = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FanataficsDataSet = New PersonApplication.fanataficsDataSet()
        Me.TblUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUserTableAdapter = New PersonApplication.fanataficsDataSetTableAdapters.tblUserTableAdapter()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvStory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFandom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGenre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FanataficsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUser
        '
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserName, Me.Password, Me.Email, Me.SecurityQuestion, Me.SecurityAnswer, Me.StoryAmount})
        Me.dgvUser.Location = New System.Drawing.Point(26, 28)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.Size = New System.Drawing.Size(645, 69)
        Me.dgvUser.TabIndex = 0
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "User Name"
        Me.UserName.Name = "UserName"
        '
        'Password
        '
        Me.Password.DataPropertyName = "Password"
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'SecurityQuestion
        '
        Me.SecurityQuestion.DataPropertyName = "SecurityQuestion"
        Me.SecurityQuestion.HeaderText = "Security Question"
        Me.SecurityQuestion.Name = "SecurityQuestion"
        '
        'SecurityAnswer
        '
        Me.SecurityAnswer.DataPropertyName = "SecurityAnswer"
        Me.SecurityAnswer.HeaderText = "Security Answer"
        Me.SecurityAnswer.Name = "SecurityAnswer"
        '
        'StoryAmount
        '
        Me.StoryAmount.DataPropertyName = "StoryAmount"
        Me.StoryAmount.HeaderText = "Stories Written"
        Me.StoryAmount.Name = "StoryAmount"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(208, 416)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(102, 418)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 421)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User Name"
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
        'dgvStory
        '
        Me.dgvStory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Title, Me.Summary, Me.MaturityID})
        Me.dgvStory.Location = New System.Drawing.Point(26, 118)
        Me.dgvStory.Name = "dgvStory"
        Me.dgvStory.Size = New System.Drawing.Size(346, 50)
        Me.dgvStory.TabIndex = 5
        '
        'Title
        '
        Me.Title.DataPropertyName = "Title"
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        '
        'Summary
        '
        Me.Summary.DataPropertyName = "Summary"
        Me.Summary.HeaderText = "Summary"
        Me.Summary.Name = "Summary"
        Me.Summary.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Summary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'MaturityID
        '
        Me.MaturityID.DataPropertyName = "MaturityID"
        Me.MaturityID.HeaderText = "MaturityID"
        Me.MaturityID.Name = "MaturityID"
        '
        'dgvFandom
        '
        Me.dgvFandom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFandom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FandomName, Me.CategoryID})
        Me.dgvFandom.Location = New System.Drawing.Point(26, 187)
        Me.dgvFandom.Name = "dgvFandom"
        Me.dgvFandom.Size = New System.Drawing.Size(250, 54)
        Me.dgvFandom.TabIndex = 6
        '
        'FandomName
        '
        Me.FandomName.DataPropertyName = "FandomName"
        Me.FandomName.HeaderText = "Fandom Name"
        Me.FandomName.Name = "FandomName"
        '
        'CategoryID
        '
        Me.CategoryID.DataPropertyName = "CategoryID"
        Me.CategoryID.HeaderText = "CategoryID"
        Me.CategoryID.Name = "CategoryID"
        '
        'dgvGenre
        '
        Me.dgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGenre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.dgvGenre.Location = New System.Drawing.Point(26, 280)
        Me.dgvGenre.Name = "dgvGenre"
        Me.dgvGenre.Size = New System.Drawing.Size(147, 54)
        Me.dgvGenre.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "GenreType"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Genre Type"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'FanataficsDataSet
        '
        Me.FanataficsDataSet.DataSetName = "fanataficsDataSet"
        Me.FanataficsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblUserBindingSource
        '
        Me.TblUserBindingSource.DataMember = "tblUser"
        Me.TblUserBindingSource.DataSource = Me.FanataficsDataSet
        '
        'TblUserTableAdapter
        '
        Me.TblUserTableAdapter.ClearBeforeFill = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1444, 463)
        Me.Controls.Add(Me.dgvGenre)
        Me.Controls.Add(Me.dgvFandom)
        Me.Controls.Add(Me.dgvStory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgvUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUser"
        Me.Text = "frmPerson"
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvStory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFandom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGenre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FanataficsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvUser As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvStory As System.Windows.Forms.DataGridView
    Friend WithEvents UserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecurityQuestion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecurityAnswer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StoryAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Summary As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaturityID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvFandom As System.Windows.Forms.DataGridView
    Friend WithEvents FandomName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvGenre As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FanataficsDataSet As PersonApplication.fanataficsDataSet
    Friend WithEvents TblUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblUserTableAdapter As PersonApplication.fanataficsDataSetTableAdapters.tblUserTableAdapter
End Class
