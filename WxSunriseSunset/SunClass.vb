Imports System.Runtime.CompilerServices
Imports Newtonsoft.Json

Namespace suninformation
#Disable Warning IDE1006 ' Naming Styles

    Partial Public Class SunClass
        Public Property results As Results
        Public Property status As String
    End Class

    Partial Public Class Results
        Public Property sunrise As Date
        Public Property sunset As Date
        Public Property solar_noon As Date
        Public Property day_length As Date
        Public Property civil_twilight_begin As Date
        Public Property civil_twilight_end As Date
        Public Property nautical_twilight_begin As Date
        Public Property nautical_twilight_end As Date
        Public Property astronomical_twilight_begin As Date
        Public Property astronomical_twilight_end As Date
    End Class

    Partial Public Class SunClass

        Public Shared Function FromJson(json As String) As SunClass
            Return JsonConvert.DeserializeObject(Of SunClass)(json, Converter.Settings)
        End Function

    End Class

    Module Serialize

        <Extension> Function ToJson(self As SunClass) As String
            Return JsonConvert.SerializeObject(self, Converter.Settings)
        End Function

    End Module

    Public Class Converter

        Public Shared ReadOnly _
            Settings As JsonSerializerSettings = New JsonSerializerSettings _
            With {.MetadataPropertyHandling = MetadataPropertyHandling.Ignore, .DateParseHandling = DateParseHandling.None}

    End Class

End Namespace