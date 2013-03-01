Imports BusinessObjects
Public Class frmPerson

    Private WithEvents people As PersonList

    Private phoneTypes As New PhoneTypeList
    Private emailTypes As New EmailTypeList
    Private addressTypes As New AddressTypeList

    Private Sub frmPerson_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        people = New PersonList
        Me.dgvPerson.AutoGenerateColumns = False
        Me.dgvPerson.DataSource = people.List
        Me.dgvPersonPhone.AutoGenerateColumns = False
        Me.dgvPersonEmail.AutoGenerateColumns = False
        Me.dgvPersonAddress.AutoGenerateColumns = False
        phoneTypes = phoneTypes.GetAll
        emailTypes = emailTypes.GetAll
        addressTypes = addressTypes.GetAll

    End Sub


    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        people = New PersonList
        people.FirstName = Me.txtFirstName.Text
        people = people.Search
        Me.dgvPerson.DataSource = people.List

    End Sub

    Private Sub mnuSave_Click(sender As System.Object, e As System.EventArgs) Handles mnuSave.Click
        If people.IsSavable = True Then
            people = people.Save()

        End If
    End Sub

    Private Sub dgvPerson_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPerson.CellContentClick

    End Sub

    Private Sub dgvPerson_RowHeaderMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvPerson.RowHeaderMouseClick
        Dim person As Person = dgvPerson.SelectedRows(0).DataBoundItem
        If person IsNot Nothing Then
            dgvPersonPhone.DataSource = person.Phones.List
            dgvPersonEmail.DataSource = person.Emails.List
            dgvPersonAddress.DataSource = person.Addresses.List
        End If
    End Sub

    Private Sub SetPhoneTypes(ByVal column As DataGridViewComboBoxColumn)
        With column
            If .DataSource Is Nothing Then
                .DataSource = phoneTypes.List
                .DisplayMember = "Type"
                .ValueMember = "Id"
            End If
        End With
    End Sub


    Private Sub dgvPersonPhone_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvPersonPhone.CellFormatting
        If e.ColumnIndex = 1 AndAlso dgvPersonPhone IsNot Nothing Then
            SetPhoneTypes(dgvPersonPhone.Columns(1))
        End If


    End Sub


    Private Sub dgvPersonPhone_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvPersonPhone.DataError

    End Sub

    Private Sub SetEmailTypes(ByVal column As DataGridViewComboBoxColumn)
        With column
            If .DataSource Is Nothing Then
                .DataSource = emailTypes.List
                .DisplayMember = "Type"
                .ValueMember = "Id"
            End If
        End With
    End Sub

    Private Sub dgvPersonEmail_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvPersonEmail.CellFormatting
        If e.ColumnIndex = 1 AndAlso dgvPersonEmail IsNot Nothing Then
            SetEmailTypes(dgvPersonEmail.Columns(1))
        End If
    End Sub








    Private Sub SetAddressTypes(ByVal column As DataGridViewComboBoxColumn)
        With column
            If .DataSource Is Nothing Then
                .DataSource = addressTypes.List
                .DisplayMember = "Type"
                .ValueMember = "Id"
            End If
        End With
    End Sub


    Private Sub dgvPersonAddress_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvPersonAddress.CellFormatting
        If e.ColumnIndex = 1 AndAlso dgvPersonAddress IsNot Nothing Then
            SetAddressTypes(dgvPersonAddress.Columns(4))
        End If
    End Sub


    Private Sub dgvPersonAddress_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub




    Private Sub dgvPersonEmail_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvPersonEmail.DataError

    End Sub


End Class