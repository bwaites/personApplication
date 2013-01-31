Imports System.ComponentModel
Imports DatabaseHelper

Public Class AddressTypeList

#Region " Private Members "

    Private WithEvents _List As New BindingList(Of AddressType)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List() As BindingList(Of AddressType)
        Get
            Return _List
        End Get
    End Property

#End Region

#Region " Private Methods "

#End Region

#Region " Public Methods "



    Public Function GetAll() As AddressTypeList

        Dim db As New Database(My.Settings.ConnectionName)
        Dim ds As DataSet = Nothing
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblAddressType_getAll"
        ds = db.ExecuteQuery()

        Dim blank As New AddressType
        blank.Id = Guid.Empty
        blank.Type = String.Empty

        _List.Add(blank)

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim at As New AddressType()
            at.Initialize(dr)
            at.InitializeBusinessData(dr)
            at.IsNew = False
            at.IsDirty = False

            AddHandler at.evtIsSavable, AddressOf AddressTypeList_evtIsSavable

            _List.Add(at)
        Next

        Return Me

    End Function

    Public Function Save() As AddressTypeList
        For Each at As AddressType In _List
            If at.IsSavable = True Then
                at = at.Save()
                If at.IsDirty = False Then
                    at = at.Save()
                End If
            End If
        Next
        Return Me
    End Function

    Public Function IsSavable() As Boolean
        Dim result As Boolean = False
        For Each at As AddressType In _List
            If at.IsSavable() = True Then
                result = True
                Exit For
            End If
        Next
        Return result
    End Function
#End Region

#Region " Public Events "

    Public Delegate Sub IsSavableArgs(savable As Boolean)
    Public Event evtIsSavable As IsSavableArgs

#End Region

#Region " Public Event Handlers "

    Private Sub AddressTypeList_evtIsSavable(savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub _List_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs) Handles _List.AddingNew
        e.NewObject = New AddressType
        AddHandler CType(e.NewObject, AddressType).evtIsSavable, AddressOf AddressTypeList_evtIsSavable
    End Sub

#End Region

#Region " Construction "

#End Region

End Class
