Public Class frmTestWebService


    Private Sub btnGetCityState_Click(sender As System.Object, e As System.EventArgs) Handles btnGetCityState.Click
        Dim zip As New localhost.Batman.ZipcodeService
        Dim zipInfo As New localhost.Batman.ZipInfo

        zipInfo = zip.GetCityByZipcode(Me.txtZip.Text)
        txtCity.Text = zipInfo.City
        txtState.Text = zipInfo.State
        txtZip.Text = zipInfo.Zipcode
    End Sub
End Class