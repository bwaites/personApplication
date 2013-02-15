Imports DatabaseHelper

Public Class PersonPhone
    Inherits HeaderData

#Region " Private Members "
    Private _PersonID As Guid = Guid.Empty
    Private _Number As String = String.Empty
    Private _PhoneTypeID As Guid = Guid.Empty

#End Region

#Region " Public Properties "
    Public Property PersonID As Guid
        Get
            Return _PersonID
        End Get
        Set(value As Guid)
            If value <> _PersonID Then
                _PersonID = value
                MyBase.IsDirty = True
                'Raise an Event here to notify
                'if the object is savable
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property Number As String
        Get
            Return _Number
        End Get
        Set(value As String)
            If value <> _Number Then
                _Number = value
                MyBase.IsDirty = True
                'Raise an Event here to notify
                'if the object is savable
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property PhoneTypeID As Guid
        Get
            Return _PhoneTypeID
        End Get
        Set(value As Guid)
            If value <> _PhoneTypeID Then
                _PhoneTypeID = value
                MyBase.IsDirty = True
                'Raise an Event here to notify
                'if the object is savable
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property
#End Region

#Region " Private Methods "
    Private Function Insert(database As DatabaseHelper.Database) As Boolean

        Try
            'Setting up the Command object
            database.Command.Parameters.Clear()
            database.Command.CommandType = CommandType.StoredProcedure
            database.Command.CommandText = "tblPersonPhone_INSERT"
            'Add the header data parameters
            MyBase.Initialize(database, Guid.Empty)
            'Add the parameter
            database.Command.Parameters.Add("@PersonID", SqlDbType.UniqueIdentifier).Value = _PersonID
            database.Command.Parameters.Add("@Number", SqlDbType.VarChar).Value = _Number
            database.Command.Parameters.Add("@PhoneTypeID", SqlDbType.UniqueIdentifier).Value = _PhoneTypeID


            'Execute non query
            database.ExecuteNonQueryWithTransaction()
            'Retrieve the header data values from the command object
            MyBase.Initialize(database.Command)

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Private Function Update(database As DatabaseHelper.Database) As Boolean

        Try
            'Setting up the Command object
            database.Command.Parameters.Clear()
            database.Command.CommandType = CommandType.StoredProcedure
            database.Command.CommandText = "tblPersonPhone_UPDATE"
            'Add the header data parameters
            MyBase.Initialize(database, MyBase.Id)
            'Add the parameter
            database.Command.Parameters.Add("@PersonID", SqlDbType.UniqueIdentifier).Value = _PersonID
            database.Command.Parameters.Add("@Number", SqlDbType.VarChar).Value = _Number
            database.Command.Parameters.Add("@PhoneTypeID", SqlDbType.UniqueIdentifier).Value = _PhoneTypeID

            'Execute non query
            database.ExecuteNonQueryWithTransaction()
            'Retrieve the header data values from the command object
            MyBase.Initialize(database.Command)

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Private Function Delete(database As DatabaseHelper.Database) As Boolean

        Try
            database.Command.Parameters.Clear()
            database.Command.CommandType = CommandType.StoredProcedure
            database.Command.CommandText = "tblPersonPhone_DELETE"
            MyBase.Initialize(database, MyBase.Id)
            database.ExecuteNonQuery()
            MyBase.Initialize(database.Command)

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Private Function IsValid() As Boolean
        'THESE ARE THE BUSINESS RULES
        'ASSUME TRUE UNLESS A RULE IS BROKEN
        Dim result As Boolean = True


        If _Number.Trim = String.Empty Then
            result = False
        End If
        If _Number.Length > 15 Then
            result = False
        End If

        If _PhoneTypeID = Guid.Empty Then
            result = False
        End If

        Return result

    End Function
#End Region

#Region " Public Methods "
    Public Function Save(database As Database, parentId As Guid) As PersonPhone

        _PersonID = parentId

        Dim result As Boolean = True

        If MyBase.IsNew = True AndAlso MyBase.IsDirty = True AndAlso IsValid() = True Then
            result = Insert(database)
        ElseIf MyBase.Deleted = True AndAlso MyBase.IsDirty = True Then
            result = Delete(database)
        ElseIf MyBase.IsNew = False AndAlso MyBase.IsDirty = True AndAlso IsValid() = True Then
            result = Update(database)
        End If

        If result = True Then
            MyBase.IsDirty = False
            MyBase.IsNew = False
        End If

        Return Me
    End Function
    Public Function IsSavable() As Boolean
        If MyBase.IsDirty = True AndAlso IsValid() = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function GetById(id As Guid) As PersonPhone

        Dim db As New Database(My.Settings.ConnectionName)
        Dim ds As DataSet = Nothing
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblPersonPhone_getById"
        db.Command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = id
        ds = db.ExecuteQuery()

        If ds.Tables(0).Rows.Count = 1 Then
            Dim dr As DataRow = ds.Tables(0).Rows(0)
            MyBase.Initialize(dr)
            InitializeBusinessData(dr)
            MyBase.IsNew = False
            MyBase.IsDirty = False

            Return Me
        Else
            If ds.Tables(0).Rows.Count = 0 Then
                Throw New Exception(String.Format("Person Phone # {0} was not fount", id))
            Else
                Throw New Exception(String.Format("Person Phone # {0} found multiple records", id))
            End If
        End If

    End Function
    Public Sub InitializeBusinessData(dr As DataRow)
        _PersonID = dr("PersonID")
        _Number = dr("Number")
        _PhoneTypeID = dr("PhoneTypeID")
    End Sub
#End Region

#Region " Public Events "

    Public Delegate Sub IsSavableArgs(savable As Boolean)
    Public Event evtIsSavable As IsSavableArgs

#End Region

#Region " Public Event Handlers "

#End Region

#Region " Construction "

#End Region
End Class
