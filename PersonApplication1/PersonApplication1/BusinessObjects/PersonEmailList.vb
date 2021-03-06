﻿Imports System.ComponentModel
Imports DatabaseHelper
Public Class PersonEmailList
#Region " Private Members "

    Private WithEvents _List As New BindingList(Of PersonEmail)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List() As BindingList(Of PersonEmail)
        Get
            Return _List
        End Get
    End Property

#End Region

#Region " Private Methods "

#End Region

#Region " Public Methods "

    Public Function GetByPersonId(id As Guid) As PersonEmailList

        Dim db As New Database(My.Settings.ConnectionName)
        Dim ds As DataSet = Nothing
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblPersonEmail_getByPersonId"
        db.Command.Parameters.Add("@PersonID", SqlDbType.UniqueIdentifier).Value = id
        ds = db.ExecuteQuery()


        For Each dr As DataRow In ds.Tables(0).Rows
            Dim pe As New PersonEmail()
            pe.Initialize(dr)
            pe.InitializeBusinessData(dr)
            pe.IsNew = False
            pe.IsDirty = False

            AddHandler pe.evtIsSavable, AddressOf PersonEmailList_evtIsSavable

            _List.Add(pe)
        Next

        Return Me

    End Function

    Public Function Save(database As Database, parentId As Guid) As Boolean
        Dim result As Boolean = True
        For Each at As PersonEmail In _List
            If at.IsSavable = True Then
                at = at.Save(database, parentId)
                If at.IsNew = True Then
                    result = False
                    Exit For
                End If
            End If
        Next
        Return result
    End Function

    Public Function IsSavable() As Boolean
        Dim result As Boolean = False
        For Each at As PersonEmail In _List
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

    Private Sub PersonEmailList_evtIsSavable(savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub _List_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs) Handles _List.AddingNew
        e.NewObject = New PersonEmail
        AddHandler CType(e.NewObject, PersonEmail).evtIsSavable, AddressOf PersonEmailList_evtIsSavable
    End Sub

#End Region

#Region " Construction "

#End Region
End Class
