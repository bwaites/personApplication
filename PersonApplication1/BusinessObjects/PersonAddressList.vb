﻿Imports System.ComponentModel
Imports DatabaseHelper
Public Class PersonAddressList
#Region " Private Members "

    Private WithEvents _List As New BindingList(Of PersonAddress)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List() As BindingList(Of PersonAddress)
        Get
            Return _List
        End Get
    End Property

#End Region

#Region " Private Methods "

#End Region

#Region " Public Methods "



    Public Function GetByPersonId(id As Guid) As PersonAddressList

        Dim db As New Database(My.Settings.ConnectionName)
        Dim ds As DataSet = Nothing
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblPersonAddress_getByPersonId"
        db.Command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value.id()
        ds = db.ExecuteQuery()


        For Each dr As DataRow In ds.Tables(0).Rows
            Dim at As New PersonAddress()
            at.Initialize(dr)
            at.InitializeBusinessData(dr)
            at.IsNew = False
            at.IsDirty = False

            AddHandler at.evtIsSavable, AddressOf PersonAddressList_evtIsSavable

            _List.Add(at)
        Next

        Return Me

    End Function

    Public Function Save(database As Database, parentId As Guid) As Boolean
        Dim result As Boolean = True
        For Each at As PersonAddress In _List
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
        For Each at As PersonAddress In _List
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

    Private Sub PersonAddressList_evtIsSavable(savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub _List_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs) Handles _List.AddingNew
        e.NewObject = New PersonAddress
        AddHandler CType(e.NewObject, PersonAddress).evtIsSavable, AddressOf PersonAddressList_evtIsSavable
    End Sub

#End Region

#Region " Construction "

#End Region
End Class
