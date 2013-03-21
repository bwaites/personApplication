Imports DatabaseHelper
Public Class PersonAddress
    Inherits HeaderData

#Region " Private Members "
    Private _PersonID As Guid = Guid.Empty
    Private _Street As String = String.Empty
    Private _City As String = String.Empty
    Private _State As String = String.Empty
    Private _Zipcode As String = String.Empty
    Private _AddressTypeID As Guid = Guid.Empty

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

    Public Property Street As String
        Get
            Return _Street
        End Get
        Set(value As String)
            If value <> _Street Then
                _Street = value
                MyBase.IsDirty = True
                'Raise an Event here to notify
                'if the object is savable
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property City As String
        Get
            Return _City
        End Get
        Set(value As String)
            If value <> _City Then
                _City = value
                MyBase.IsDirty = True
                'Raise an Event here to notify
                'if the object is savable
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property
    Public Property State As String
        Get
            Return _State
        End Get
        Set(value As String)
            If value <> _State Then
                _State = value
                MyBase.IsDirty = True
                'Raise an Event here to notify
                'if the object is savable
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property
    Public Property Zipcode As String
        Get
            Return _Zipcode
        End Get
        Set(value As String)
            If value <> _Zipcode Then
                _Zipcode = value
                MyBase.IsDirty = True
                'Raise an Event here to notify
                'if the object is savable
                Dim zip As New localhost.ZipcodeWebService.ZipcodeService
                Dim zipInfo As New localhost.ZipcodeWebService.ZipInfo

                zipInfo = zip.GetCityStateByZipcode(_Zipcode)
                _City = zipInfo.City
                _State = zipInfo.State
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property


    Public Property AddressTypeID As Guid
        Get
            Return _AddressTypeID
        End Get
        Set(value As Guid)
            If value <> _AddressTypeID Then
                _AddressTypeID = value
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
            database.Command.CommandText = "tblPersonAddress_INSERT"
            'Add the header data parameters
            MyBase.Initialize(database, Guid.Empty)
            'Add the parameter
            database.Command.Parameters.Add("@PersonID", SqlDbType.UniqueIdentifier).Value = _PersonID
            database.Command.Parameters.Add("@Street", SqlDbType.VarChar).Value = _Street
            database.Command.Parameters.Add("@City", SqlDbType.VarChar).Value = _City
            database.Command.Parameters.Add("@State", SqlDbType.VarChar).Value = _State
            database.Command.Parameters.Add("@Zipcode", SqlDbType.VarChar).Value = _Zipcode
            database.Command.Parameters.Add("@AddressTypeID", SqlDbType.UniqueIdentifier).Value = _AddressTypeID


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
            database.Command.CommandText = "tblPersonAddress_UPDATE"
            'Add the header data parameters
            MyBase.Initialize(database, MyBase.Id)
            'Add the parameter
            database.Command.Parameters.Add("@PersonID", SqlDbType.UniqueIdentifier).Value = _PersonID
            database.Command.Parameters.Add("@Street", SqlDbType.VarChar).Value = _Street
            database.Command.Parameters.Add("@City", SqlDbType.VarChar).Value = _City
            database.Command.Parameters.Add("@State", SqlDbType.VarChar).Value = _State
            database.Command.Parameters.Add("@Zipcode", SqlDbType.VarChar).Value = _Zipcode
            database.Command.Parameters.Add("@AddressTypeID", SqlDbType.UniqueIdentifier).Value = _AddressTypeID

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
            database.Command.CommandText = "tblPersonAddress_DELETE"
            MyBase.Initialize(database, MyBase.Id)
            database.ExecuteNonQueryWithTransaction()
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


        If _Street.Trim = String.Empty Then
            result = False
        End If
        If _Street.Length > 30 Then
            result = False
        End If

        If _City.Trim = String.Empty Then
            result = False
        End If

        If _City.Length > 30 Then
            result = False
        End If

        If _State.Trim = String.Empty Then
            result = False
        End If

        If _State.Length > 2 Then
            result = False
        End If

        If _Zipcode.Trim = String.Empty Then
            result = False
        End If

        If _Zipcode.Length > 12 Then
            result = False
        End If
        If _AddressTypeID = Guid.Empty Then
            result = False
        End If

        Return result

    End Function
#End Region

#Region " Public Methods "
    Public Function Save(database As Database, parentId As Guid) As PersonAddress

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
    Public Function GetById(id As Guid) As PersonAddress

        Dim db As New Database(My.Settings.ConnectionName)
        Dim ds As DataSet = Nothing
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblPersonAddress_getById"
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
                Throw New Exception(String.Format("Person Address {0} was not fount", id))
            Else
                Throw New Exception(String.Format("Person Address {0} found multiple records", id))
            End If
        End If

    End Function
    Public Sub InitializeBusinessData(dr As DataRow)
        _PersonID = dr("PersonID")
        _Street = dr("Street")
        _City = dr("City")
        _State = dr("State")
        _Zipcode = dr("Zipcode")
        _AddressTypeID = dr("AddressTypeID")

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
