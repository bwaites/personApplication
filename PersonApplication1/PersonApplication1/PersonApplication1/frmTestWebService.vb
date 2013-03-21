Public Class frmTestWebService


    Private Sub btnGetCityState_Click(sender As System.Object, e As System.EventArgs) Handles btnGetCityState.Click
        Dim zip As New localhost.ZipcodeService
        Dim zipInfo As New localhost.ZipInfo

        zipInfo = zip.GetCityStateByZipcode(Me.txtZip.Text)
        txtCity.Text = zipInfo.City
        txtState.Text = zipInfo.State

    End Sub

    Private Sub txtCity_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCity.TextChanged

    End Sub
End Class