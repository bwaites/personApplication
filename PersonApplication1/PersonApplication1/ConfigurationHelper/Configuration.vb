﻿Public Class Configuration

    Public Shared Function GetConnectionString(name As String) As String
        Dim result As String = String.Empty
        Dim xmlDoc As New System.Xml.XmlDocument
        Dim path As String =
            System.Reflection.Assembly.GetExecutingAssembly.Location
        path = System.IO.Path.GetDirectoryName(path)
        path = System.IO.Path.Combine(path, "datasystems.config")
        xmlDoc.Load(path)

        'Create a variable to hold the add nodes
        Dim xmlNodes As System.Xml.XmlNodeList
        'Load the list with the add nodes
        xmlNodes = xmlDoc.SelectNodes("//configuration/connectionStrings/add")
        'loop through the list to find the node name that matches
        'the one passed in
        For Each node As Xml.XmlNode In xmlNodes
            If node.Attributes("name").Value.ToUpper = name.ToUpper Then
                result = node.Attributes("connectionString").Value
                Exit For
            End If
        Next
        Return result



    End Function
End Class
