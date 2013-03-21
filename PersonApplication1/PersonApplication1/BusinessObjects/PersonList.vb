Imports System.ComponentModel
Imports DatabaseHelper
Imports SQLHelper
Imports DatatypeHelper
Public Class PersonList

#Region " Private Members "
    Private WithEvents _List As New BindingList(Of Person)
    Private _Criteria As Criteria
#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of Person)
        Get
            Return _List
        End Get
    End Property

    Public WriteOnly Property FirstName As String
        Set(value As String)
            If value.Trim <> String.Empty Then
                _Criteria.Fields.Add("FirstName")
                _Criteria.Values.Add(value)
                _Criteria.Types.Add(Type.DataType.String_Contains)
            End If
        End Set
    End Property

    Public WriteOnly Property LastName As String
        Set(value As String)
            If value.Trim <> String.Empty Then
                _Criteria.Fields.Add("LastName")
                _Criteria.Values.Add(value)
                _Criteria.Types.Add(Type.DataType.String_Contains)
            End If
        End Set
    End Property

    Public WriteOnly Property PhoneNumber As String
        Set(value As String)
            If value.Trim <> String.Empty Then
                _Criteria.Fields.Add("Number")
                _Criteria.Values.Add(value)
                _Criteria.Types.Add(DataTypeHelper.Type.DataType.String_Contains)
            End If
        End Set
    End Property
#End Region

#Region " Private Methods "


#End Region

#Region " Public Methods "
    Public Function Save() As PersonList
        Dim result As Boolean = True
        For Each p As Person In _List
            If p.IsSavable = True Then
                p = p.Save
                If p.IsNew = True Then
                    result = False
                    Exit For
                End If
            End If
        Next
        'DONT FORGET TO RETURN THE RESULT
        Return Me
    End Function

    Public Function IsSavable() As Boolean
        Dim result As Boolean = False
        For Each p As Person In _List
            If p.IsSavable = True Then
                result = True
                Exit For
            End If
        Next
        'DONT FORGET TO RETURN THE RESULT
        Return result
    End Function

    Public Function Search() As PersonList
        'crease an instance of the databse class
        Dim database As New Database(My.Settings.ConnectionName)
        Dim ds As New DataSet

        database.ConnectionName = My.Settings.ConnectionName
        database.Command.CommandType = CommandType.Text
        database.Command.CommandText = SQLHelper.Builder.Build(_Criteria)

        ds = database.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim p As New Person
            p.Initialize(dr)
            p.InitializeBusinessData(dr)
            p.IsNew = False
            p.IsDirty = False
            _List.Add(p)
            AddHandler p.evtIsSavable, AddressOf PersonList_evtIsSavable
        Next
        Return Me
    End Function
#End Region

#Region " Public Events "
    Public Delegate Sub eIsSavable(ByVal savable As Boolean)
    Public Event evtIsSavable As eIsSavable
#End Region

#Region " Public Event Handlers "
    Private Sub PersonList_evtIsSavable(savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub _List_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs) Handles _List.AddingNew
        e.NewObject = New Person
        AddHandler CType(e.NewObject, Person).evtIsSavable, AddressOf PersonList_evtIsSavable
    End Sub

#End Region

#Region " Construction "
    Public Sub New()
        _Criteria = New Criteria
        _Criteria.TableName = "tblPerson"
    End Sub
#End Region



End Class
