Imports BusinessObjects

Public Class frmAddressType

    Private _addressTypes As AddressTypeList

    Private Sub frmAddressType_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _addressTypes = New AddressTypeList
        _addressTypes = _addressTypes.GetAll()
        Me.dgvAddressType.DataSource = _addressTypes.List
    End Sub

    Private Sub mnuSave_Click(sender As System.Object, e As System.EventArgs) Handles mnuSave.Click
        If _addressTypes.IsSavable Then
            _addressTypes = _addressTypes.Save
            dgvAddressType.Refresh()
        End If
    End Sub
End Class