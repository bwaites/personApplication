Imports System.ComponentModel
Imports DatabaseHelper
Public Class PhoneTypeList
#Region " Private Members "

    Private WithEvents _List As New BindingList(Of PhoneType)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List() As BindingList(Of PhoneType)
        Get
            Return _List
        End Get
    End Property

#End Region

#Region " Private Methods "

#End Region

#Region " Public Methods "



    Public Function GetAll() As PhoneTypeList

        Dim db As New Database(My.Settings.ConnectionName)
        Dim ds As DataSet = Nothing
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblPhoneType_getAll"
        ds = db.ExecuteQuery()

        Dim blank As New PhoneType
        blank.Id = Guid.Empty
        blank.Type = String.Empty

        _List.Add(blank)

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim at As New PhoneType()
            at.Initialize(dr)
            at.InitializeBusinessData(dr)
            at.IsNew = False
            at.IsDirty = False

            AddHandler at.evtIsSavable, AddressOf PhoneTypeList_evtIsSavable

            _List.Add(at)
        Next

        Return Me

    End Function

    Public Function Save() As PhoneTypeList
        For Each at As PhoneType In _List
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
        For Each at As PhoneType In _List
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

    Private Sub PhoneTypeList_evtIsSavable(savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub _List_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs) Handles _List.AddingNew
        e.NewObject = New PhoneType
        AddHandler CType(e.NewObject, AddressType).evtIsSavable, AddressOf PhoneTypeList_evtIsSavable
    End Sub

#End Region

#Region " Construction "

#End Region

End Class
