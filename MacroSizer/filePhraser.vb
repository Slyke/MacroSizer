Module filePhraser

    Public Const KV_Separate As String = ":"
    Public Const KV_EndKey As String = ";"
    Public Const KV_EoL As String = vbCrLf
    Public Const KV_ArraySeparate As String = ","

    Public Function getValueFromString(ByVal inputString As String, ByVal dataName As String, Optional ByVal defaultValue As String = "")

        Dim startPoint As Integer = inputString.IndexOf(dataName)

        If (startPoint <= -1) Then
            Return defaultValue
        End If

        startPoint += (dataName & KV_Separate).Length

        Dim stringFromStringPoint = inputString.Substring(startPoint)

        Dim theReturn() As String = Split(stringFromStringPoint, KV_EndKey)

        If theReturn.Count >= 1 Then
            Return theReturn(0)
        Else
            Return defaultValue
        End If

    End Function

    Public Function generateDataString(ByVal keyArray As String(), ByVal valueArray As String(), Optional ByVal dataNewLine As Boolean = False, Optional ByVal runNewLine As Boolean = False) As String

        If keyArray.Count = valueArray.Count Then
            Return ""
        End If

        Dim returnString As String = ""

        For i As Integer = 0 To (keyArray.Count - 1)
            returnString &= keyArray(i) & KV_Separate & valueArray(i) & KV_EndKey
            If dataNewLine Then
                returnString &= KV_EoL
            End If
        Next

        If runNewLine Then
            returnString &= KV_EoL
        End If

        Return returnString

    End Function

    Public Function saveSettingsFile(fileName As String, settingsString As String) As Boolean

        Try
            My.Computer.FileSystem.WriteAllText(fileName, settingsString, False)
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Public Function loadSettingsFile(fileName As String) As String

        Try
            Return My.Computer.FileSystem.ReadAllText(fileName)
        Catch ex As Exception

        End Try

        Return False

    End Function

End Module
