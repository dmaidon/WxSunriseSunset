Imports System.IO
Imports System.Net
Imports WxSunriseSunset.suninformation

Public Class Form1

    Private ReadOnly _tmp As String = Path.Combine(Application.StartupPath, "$tmp")
    Private ReadOnly _ssf As String = Path.Combine(_tmp, "sunrise-set.json")

    ''set the object to read the json data into
    Private ssNfo As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With Me
            .Text = Application.ProductName
        End With

        ''create a temporary folder to hold the datafile
        Try
            If Not Directory.Exists(_tmp) Then
                Directory.CreateDirectory(_tmp)
            End If
        Catch ex As Exception
            MsgBox($"   Error: {ex.Message}{vbCrLf}   Location: {ex.TargetSite.ToString}{vbCrLf}   Trace: { ex.StackTrace.ToString}{vbCrLf}")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtLatitude.Text.Trim() <> "" And TxtLongitude.Text.Trim() <> "" Then
            DownloadSunriseSunset()
        Else
            MsgBox($"You must enter your latitude and{vbCrLf}longitude before you proceed.")
        End If
    End Sub

    Private Sub DownloadSunriseSunset()
        Dim cLatitude As String = TxtLatitude.Text
        Dim cLongitude As String = TxtLongitude.Text
        ''fetch file with formatted date strings
        Dim url = $"https://api.sunrise-sunset.org/json?lat={cLatitude}&lng={cLongitude}&formatted=1&date=today"

        Try
            Dim Request = CType(WebRequest.Create(url), HttpWebRequest)
            Dim Response = CType(Request.GetResponse(), HttpWebResponse)
            Dim dStr = Response.GetResponseStream()
            Dim reader As New StreamReader(dStr)
            Dim resp = reader.ReadToEnd()
            File.WriteAllText(_ssf, resp)
            RtbRaw.LoadFile(_ssf, RichTextBoxStreamType.PlainText)
            ssNfo = SunClass.FromJson(resp)
            reader.Close()

            DisplayInformation()
        Catch ex As Exception
            MsgBox($"   Error: {ex.Message}{vbCrLf}   Location: {ex.TargetSite.ToString}{vbCrLf}   Trace: { ex.StackTrace.ToString}{vbCrLf}")
        Finally
            ''
        End Try

    End Sub

    Private Sub DisplayInformation()
        ''check to see if the data fetch was successful.  The status will return "OK" if successful.
        'Dim ab As Date = New DateTime(ssNfo.results.day_length.ToString)
        Dim ab As String = ssNfo.results.day_length
        If ssNfo.status = "OK" Then
            Try
                RtbInfo.AppendText($"Sunrise: {ssNfo.results.sunrise.tolocaltime:T}{vbCrLf}")
                RtbInfo.AppendText($"Sunset: {ssNfo.results.sunset.tolocaltime:T}{vbCrLf}")
                RtbInfo.AppendText($"Solar Noon: {ssNfo.results.solar_noon.tolocaltime:T}{vbCrLf}")
                RtbInfo.AppendText($"Length of day: {Hour(ab)} hours {Minute(ab)} minutes {Second(ab)} seconds{vbCrLf}")
                RtbInfo.AppendText($"Civil Twilight Begins: {ssNfo.results.civil_twilight_begin.tolocaltime:T}{vbCrLf}")
                RtbInfo.AppendText($"Civil Twilight Ends: {ssNfo.results.civil_twilight_end.tolocaltime:T}{vbCrLf}")
                RtbInfo.AppendText($"Nautical Twilight Begins: {ssNfo.results.nautical_twilight_begin.tolocaltime:T}{vbCrLf}")
                RtbInfo.AppendText($"Nautical Twilight Ends: {ssNfo.results.nautical_twilight_end.tolocaltime:T}{vbCrLf}")
                RtbInfo.AppendText($"Astronomical Twilight Begins: {ssNfo.results.astronomical_twilight_begin.tolocaltime:T}{vbCrLf}")
                RtbInfo.AppendText($"Astronomical Twilight Ends: {ssNfo.results.astronomical_twilight_end.tolocaltime:T}{vbCrLf}")
            Catch ex As Exception
                MsgBox($"   Error: {ex.Message}{vbCrLf}   Location: {ex.TargetSite.ToString}{vbCrLf}   Trace: { ex.StackTrace.ToString}{vbCrLf}")
            End Try
        Else
            MsgBox($"Sunrise-Sunset data fetch failed.")
        End If

    End Sub

End Class