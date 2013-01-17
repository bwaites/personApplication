Imports System.Data.SqlClient
Imports DatabaseHelper
Imports System.Drawing
Imports System.ComponentModel
Public Class HeaderData

#Region " Private Members "

    Private _Id As Guid = Guid.Empty
    Private _Version As Integer = 0
    Private _LastUpdated As DateTime = DateTime.MaxValue
    Private _Deleted As Boolean = False
    Private _IsDirty As Boolean = False
    Private _IsNew As Boolean = True
    Private _Status As Image = Nothing
    Private _Success As Image = Nothing
    Private _Fail As Image = Nothing
    Private _Empty As Image = Nothing

#End Region

#Region " Public Properties "
    Public Property Id() As Guid
        Get
            Return _Id
        End Get
        Set(value As Guid)
            _Id = value
        End Set
    End Property

    Public Property Version() As Integer
        Get
            Return _Version
        End Get
        Set(ByVal value As Integer)
            _Version = value
        End Set
    End Property

    Public Property LastUpdated() As DateTime
        Get
            Return _LastUpdated
        End Get
        Set(ByVal value As DateTime)
            _LastUpdated = value
        End Set
    End Property

    Public Property Deleted() As Boolean
        Get
            Return _Deleted
        End Get
        Set(ByVal value As Boolean)
            _Deleted = value
            _IsDirty = True
        End Set
    End Property

    Public Property IsDirty() As Boolean
        Get
            Return _IsDirty
        End Get
        Set(ByVal value As Boolean)
            _IsDirty = value
        End Set
    End Property

    Public Property IsNew() As Boolean
        Get
            Return _IsNew
        End Get
        Set(ByVal value As Boolean)
            _IsNew = value
        End Set
    End Property

    Public Property Status As Image
        Get
            Return _Status
        End Get
        Set(value As Image)
            _Status = value
        End Set
    End Property

    <Browsable(False)>
    Public ReadOnly Property Success As Image
        Get
            Return _Success
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property Fail As Image
        Get
            Return _Fail
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property Empty As Image
        Get
            Return _Empty
        End Get
    End Property
#End Region

#Region " Private Methods "

#End Region

#Region " Public Methods "

    Public Sub Initialize(cmd As SqlCommand)
        _Id = cmd.Parameters("@Id").Value
        _Version = cmd.Parameters("@Version").Value
        _LastUpdated = cmd.Parameters("@LastUpdated").Value
        _Deleted = cmd.Parameters("@Deleted").Value
    End Sub

    Public Sub Initialize(dr As DataRow)
        _Id = dr("Id")
        _Version = dr("Version")
        _LastUpdated = dr("LastUpdated")
        _Deleted = dr("Deleted")
    End Sub

    Public Sub Initialize(o As Object)
        _Id = o.Id
        _Version = o.Version
        _LastUpdated = o.LastUpdated
        _Deleted = o.Deleted
    End Sub

    Public Sub Initialize(database As Database, id As Guid)

        Dim parm As New SqlParameter
        parm.Direction = ParameterDirection.InputOutput
        parm.SqlDbType = SqlDbType.UniqueIdentifier
        parm.ParameterName = "@Id"
        parm.Value = id
        database.Command.Parameters.Add(parm)

        parm = New SqlParameter
        parm.Direction = ParameterDirection.Output
        parm.SqlDbType = SqlDbType.Int
        parm.ParameterName = "@Version"
        parm.Value = 0
        database.Command.Parameters.Add(parm)

        parm = New SqlParameter
        parm.Direction = ParameterDirection.Output
        parm.SqlDbType = SqlDbType.DateTime
        parm.ParameterName = "@LastUpdated"
        parm.Value = DateTime.MaxValue
        database.Command.Parameters.Add(parm)

        parm = New SqlParameter
        parm.Direction = ParameterDirection.Output
        parm.SqlDbType = SqlDbType.Bit
        parm.ParameterName = "@Deleted"
        parm.Value = False
        database.Command.Parameters.Add(parm)
    End Sub

#End Region

#Region " Public Events "

#End Region

#Region " Public Event Handlers "

#End Region

#Region " Construction "
    Public Sub New()
        _Success = New Bitmap("images\check.jpg")
        _Fail = New Bitmap("images\fail.jpg")
        _Empty = New Bitmap("images\empty.jpg")
        _Status = _Empty
    End Sub
#End Region

End Class
