Imports System.Text.RegularExpressions


Module Common
    Const My_TAB = &H9
    Const MY_SHIFT = &H10

    Public Declare Function GetKeyState Lib "user32" Alias "GetKeyState" (ByVal nVirtKey As Integer) As Short

#Region "Navigation"
    Public Function MoveNext() As Boolean
        Dim iRetVal As Integer
        Dim rtn As Boolean

        rtn = False
        Try
            iRetVal = GetKeyState(MY_SHIFT)
            ' If the shift was NOT on, check the tab
            If iRetVal <> -128 And iRetVal <> -127 And iRetVal <> 65409 And iRetVal <> 65408 Then
                iRetVal = GetKeyState(My_TAB)
                If iRetVal = -128 Or iRetVal = -127 Or iRetVal = 65409 Or iRetVal = 65408 Then ' tab key pressed
                    rtn = True
                End If
            End If
        Catch ex As Exception
        End Try
        Return rtn
    End Function

    Public Function MovePrev() As Boolean
        Dim iRetVal As Integer
        Dim rtn As Boolean

        rtn = False
        iRetVal = GetKeyState(MY_SHIFT)
        If iRetVal = -128 Or iRetVal = -127 Or iRetVal = 65409 Or iRetVal = 65408 Then
            iRetVal = GetKeyState(My_TAB)
            If iRetVal = -128 Or iRetVal = -127 Or iRetVal = 65409 Or iRetVal = 65408 Then ' tab key pressed
                rtn = True
            End If
        End If
        Return rtn
    End Function
#End Region

    '**********************************************************
    ' FormatPhoneNum: Format the phone number so that it is nice 
    '                 and readable
    '**********************************************************
    Function FormatPhoneNum(ByVal Num As String) As String
        'format the phone number (###) ###-####
        Dim rtnStr As String = Num
        Try
            If Num.Length = 10 Then
                rtnStr = "(" & Num.Substring(0, 3) & ") " & Num.Substring(3, 3) & "-" & Num.Substring(6)
            End If
            If Num.Length > 10 Then
                rtnStr = "(" & Num.Substring(0, 3) & ") " & Num.Substring(3, 3) & "-" & Num.Substring(6, 4) & " ext " & Num.Substring(10)
            End If
            Return rtnStr
        Catch ex As Exception
            Throw New Exception(ex.ToString, ex)
        End Try
    End Function

    '**********************************************************
    ' UnFormatPhoneNum: Take out the phone number formationg
    '                 to make it easier to edit
    '**********************************************************
    Function UnFormatPhoneNum(ByVal num As String) As String
        Dim rtnstr As String
        Try
            'strip the phone number formating from the string
            rtnstr = num
            rtnstr = rtnstr.Replace("ext", "")
            rtnstr = rtnstr.Replace(" ", "")
            rtnstr = rtnstr.Replace("(", "")
            rtnstr = rtnstr.Replace(")", "")
            rtnstr = rtnstr.Replace("-", "")

            Return rtnstr
        Catch ex As Exception
            Throw New Exception(ex.ToString, ex)
        End Try
    End Function

    Public Function ValidEmail(ByVal emailAddress As String) As Boolean
        Dim pattern As String
        Dim RegMatch As Match

        pattern = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        RegMatch = Regex.Match(emailAddress, pattern)

        Return RegMatch.Success
    End Function

    Public Function FormatDouble(ByVal strDouble As String) As String
        Dim val As Double
        Dim rtn As String = strDouble

        Try
            If strDouble <> "" Then
                val = Double.Parse(strDouble)
                rtn = val.ToString("##0.00")
            End If
        Catch ex As Exception

        End Try

        Return rtn
    End Function

    Public Function GetAge(ByVal Birthdate As System.DateTime) As String

        'Don't set second parameter if you want Age as of today

        'Demo 1: get age of person born 2/11/1954
        'Dim objDate As New System.DateTime(1954, 2, 11)
        'Debug.WriteLine(GetAge(objDate))

        'Demo 1: get same person's age 10 years from now
        'Dim objDate As New System.DateTime(1954, 2, 11)
        'Dim objdate2 As System.DateTime
        'objdate2 = Now.AddYears(10)
        'Debug.WriteLine(GetAge(objDate, objdate2))

        Dim iMonths As Integer
        Dim iYears As Integer
        Dim dYears As Decimal
        Dim lDayOfBirth As Long
        Dim lAsOf As Long
        Dim iBirthMonth As Integer
        Dim iAsOFMonth As Integer

        lDayOfBirth = DatePart(DateInterval.Day, Birthdate)
        lAsOf = DatePart(DateInterval.Day, Now)

        iBirthMonth = DatePart(DateInterval.Month, Birthdate)
        iAsOFMonth = DatePart(DateInterval.Month, Now)

        iMonths = DateDiff(DateInterval.Month, Birthdate, Now)

        dYears = iMonths / 12

        iYears = Math.Floor(dYears)

        If iBirthMonth = iAsOFMonth Then
            If lAsOf < lDayOfBirth Then
                iYears = iYears - 1
            End If
        End If

        Return iYears
    End Function
End Module
