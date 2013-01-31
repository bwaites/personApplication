Imports BusinessObjects

Public Class frmAddressType

    Private WithEvents _addressTypes As AddressTypeList

    Private Sub frmAddressType_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _addressTypes = New AddressTypeList
        _addressTypes = _addressTypes.GetAll()
        Me.dgvAddressType.DataSource = _addressTypes.List
        Me.mnuSave.Enabled = False
    End Sub

    Private Sub mnuSave_Click(sender As System.Object, e As System.EventArgs) Handles mnuSave.Click
        If _addressTypes.IsSavable() Then
            _addressTypes = _addressTypes.Save
            Me.dgvAddressType.Refresh()
            Me.mnuSave.Enabled = False
        End If
    End Sub

    Private Sub addressTypes_evtIsSavable(savable As Boolean) Handles _addressTypes.evtIsSavable
        Me.mnuSave.Enabled = savable
    End Sub
End Class