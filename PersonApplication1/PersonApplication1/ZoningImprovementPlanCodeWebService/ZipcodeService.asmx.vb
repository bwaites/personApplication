Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class ZipcodeService
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String
       Return "Hello World"
    End Function

    <WebMethod()> _
    Public Function GetCityStateByZipcode(zipcode As String) As ZipInfo
        Dim zip As New ZipInfo
        'GO TO THE REAL ZIP CODE DATABASE
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("Zipcode").ConnectionString
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "tblZipcode_getCityStateByZipcode"
        cmd.Parameters.Add("@Zipcode", SqlDbType.VarChar).Value = zipcode

        da.SelectCommand = cmd
        da.Fill(ds)
        If ds.Tables(0).Rows.Count = 1 Then
            Dim dr As DataRow = ds.Tables(0).Rows(0)
            zip.City = dr("City")
            zip.State = dr("State")
            zip.Zipcode = dr("Zipcode")

        End If
        cn.Close()
        Return zip
    End Function

End Class

Public Class ZipInfo
    Private _City As String = String.Empty
    Private _State As String = String.Empty
    Private _ZipCode As String = String.Empty

    Public Property City As String
        Get
            Return _City
        End Get
        Set(value As String)
            _City = value
        End Set
    End Property

    Public Property State As String
        Get
            Return _State
        End Get
        Set(value As String)
            _State = value
        End Set
    End Property

    Public Property ZipCode As String
        Get
            Return _ZipCode
        End Get
        Set(value As String)
            _ZipCode = value
        End Set
    End Property
End Class