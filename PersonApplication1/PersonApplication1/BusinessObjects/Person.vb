Imports DatabaseHelper
Public Class Person
    Inherits HeaderData
#Region " Private Members "
    Private _FirstName As String = String.Empty
    Private _LastName As String = String.Empty
    '
    'ADD PRIVATE MEMBERS FOR CHILDREN HERE
    '
    Private WithEvents _Phones As PersonPhoneList = Nothing
    Private WithEvents _Emails As PersonEmailList = Nothing
    Private WithEvents _Addresses As PersonAddressList = Nothing

#End Region

#Region " Public Properties "
    Public Property FirstName As String
        Get
            Return _FirstName
        End Get
        Set(value As String)
            If value <> _FirstName Then
                _FirstName = value
                MyBase.IsDirty = True
                'Raise an Event here to notify
                'if the object is savable
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _LastName
        End Get
        Set(value As String)
            If value <> _LastName Then
                _LastName = value
                MyBase.IsDirty = True
                'Raise an Event here to notify
                'if the object is savable
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    '
    'ADD PUBLIC PROPERITES FOR CHILDREN HERE
    '

    Public ReadOnly Property Phones As PersonPhoneList
        Get
            If _Phones Is Nothing Then
                _Phones = New PersonPhoneList
                _Phones = _Phones.GetByPersonId(MyBase.Id)
            End If
            Return _Phones
        End Get
    End Property

    Public ReadOnly Property Emails As PersonEmailList
        Get
            If _Emails Is Nothing Then
                _Emails = New PersonEmailList
                _Emails = _Emails.GetByPersonId(MyBase.Id)
            End If
            Return _Emails
        End Get
    End Property

    Public ReadOnly Property Addresses As PersonAddressList
        Get
            If _Addresses Is Nothing Then
                _Addresses = New PersonAddressList
                _Addresses = _Addresses.GetByPersonId(MyBase.Id)
            End If
            Return _Addresses
        End Get
    End Property

#End Region

#Region " Private Methods "
    Private Function Insert(database As DatabaseHelper.Database) As Boolean

        Try
            'Setting up the Command object
            database.Command.Parameters.Clear()
            database.Command.CommandType = CommandType.StoredProcedure
            database.Command.CommandText = "tblPerson_INSERT"
            'Add the header data parameters
            MyBase.Initialize(database, Guid.Empty)
            'Add the parameter
            database.Command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = _FirstName
            database.Command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = _LastName

            'CHANGE EXECUTE NON QUERY TO EXECUTE NON QUERY WITH TRANSACTION
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
            database.Command.CommandText = "tblPerson_UPDATE"
            'Add the header data parameters
            MyBase.Initialize(database, MyBase.Id)
            'Add the parameter
            database.Command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = _FirstName
            database.Command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = _LastName
            'Execute non query
            database.ExecuteNonQueryWithTransaction()
            '
            'CHANGE EXECUTE NON QUERY TO EXECUTE NON QUERY WITH TRANSACTION
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
            database.Command.CommandText = "tblPerson_DELETE"
            MyBase.Initialize(database, MyBase.Id)
            database.ExecuteNonQueryWithTransaction()
            '
            'DON'T FORGET TO SOFT DELETE THE CHILDREN OF THE PARENT
            '

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

        If _FirstName = String.Empty Then
            result = False
        End If
        If _FirstName.Length > 20 Then
            result = False
        End If

        If _LastName = String.Empty Then
            result = False
        End If
        If _LastName.Length > 20 Then
            result = False
        End If

        Return result

    End Function
#End Region

#Region " Public Methods "
    Public Function Save() As Person
        Dim db As New Database(My.Settings.ConnectionName)
        Dim result As Boolean = True

        If MyBase.IsNew = True AndAlso MyBase.IsDirty = True AndAlso IsValid() = True Then
            result = Insert(db)
        ElseIf MyBase.Deleted = True AndAlso MyBase.IsDirty = True Then
            result = Delete(db)
        ElseIf MyBase.IsNew = False AndAlso MyBase.IsDirty = True AndAlso IsValid() = True Then
            result = Update(db)
        End If

        If result = True Then
            MyBase.IsDirty = False
            MyBase.IsNew = False
        End If
        '
        '
        'Handle the children here'
        '

        If result = True AndAlso Phones.IsSavable = True Then
            result = _Phones.Save(db, MyBase.Id)
        End If

        If result = True AndAlso Emails.IsSavable = True Then
            result = _Emails.Save(db, MyBase.Id)
        End If

        If result = True AndAlso Addresses.IsSavable = True Then
            result = _Addresses.Save(db, MyBase.Id)
        End If
        '
        'Handle the transaction here'
        '
        If result = True Then
            db.EndTransaction()
        Else
            db.RollbackTransaction()
        End If

        Return Me
    End Function
    Public Function IsSavable() As Boolean
        '
        'ADD CHECKS HERE FOR CHILDREN BEING SAVABLE
        '
        If MyBase.IsDirty = True AndAlso IsValid() = True OrElse Phones.IsSavable = True OrElse Emails.IsSavable = True OrElse Addresses.IsSavable = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function GetById(id As Guid) As Person

        Dim db As New Database(My.Settings.ConnectionName)
        Dim ds As DataSet = Nothing
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblPerson_getById"
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
                Throw New Exception(String.Format("Person {0} was not found", id))
            Else
                Throw New Exception(String.Format("Person {0} found multiple records", id))
            End If
        End If

    End Function
    Public Sub InitializeBusinessData(dr As DataRow)
        _FirstName = dr("FirstName")
        _LastName = dr("LastName")
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
