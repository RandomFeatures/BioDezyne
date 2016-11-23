
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Text
Imports System.IO

Public Class VisitHistory



    Public Sub New()
        Dim stract As DbProviderFactory
        Dim myReader As StreamReader

        If m_Connection Is Nothing Then
            stract = DbProviderFactories.GetFactory("Local.System.Data.SQLite")
            m_Connection = stract.CreateConnection()
            If File.Exists("config.dat") Then
                myReader = New StreamReader("config.dat")
                m_Connection.ConnectionString = "Data Source=" & myReader.ReadLine() & "\database\bioDezyne.db3"
                myReader.Close()
                myReader = Nothing
            Else
                m_Connection.ConnectionString = "Data Source=database/bioDezyne.db3"
            End If
            m_Connection.Open()
        End If
    End Sub

    Public Function GetPatientVisitHistory(ByVal iPatientID As Integer) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("h.[VisitID], [VisitDate], [DexaVisitID], [Weight], [Height], [BPSystolic], [BPDiastolic], c.[TotalChol], m.[Glucose]")
        strSQL.Append(_FROM)
        strSQL.Append("tblVisitHistory h")
        strSQL.Append(_LJOIN)
        strSQL.Append("tblCholesterol c")
        strSQL.Append(_ON)
        strSQL.Append("c.[VisitID] = h.[VisitID] AND c.[PatientID]=" & iPatientID.ToString)
        strSQL.Append(_LJOIN)
        strSQL.Append("tblMisc m")
        strSQL.Append(_ON)
        strSQL.Append("m.[VisitID] = h.[VisitID] AND m.[PatientID]=" & iPatientID.ToString)
        strSQL.Append(_WHERE)
        strSQL.Append("h.[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("h.[isActive] = 'true'")


        Return ExecuteReader(strSQL.ToString)
    End Function

    Public Function GetVisitDetails(ByVal iPatientID As Integer, ByVal iVisitID As Integer) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[VisitID], [VisitDate], [DexaVisitID], [BodyType], [BMI], [PelvicWidth], [ClavicalWidth], [Weight], [Height], [Waist], [Hip], [BPSystolic], [BPDiastolic], [IBW], [DBWeight], [Exercise]")
        strSQL.Append(_FROM)
        strSQL.Append("tblVisitHistory")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        Return ExecuteReader(strSQL.ToString)

    End Function

    Public Sub DeleteVisit(ByVal iPatientID As Integer, ByVal iVisitID As Integer)
        Dim strSQL As StringBuilder

        'SQL Code here
        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblVisitHistory")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)

        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblBCA")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)


        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblCholesterol")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)

        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblComposition")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)

        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblConditionNotes")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)

        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblPatientConditions")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)

        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblMisc")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)

        strSQL = Nothing
        strSQL = New StringBuilder
        strSQL.Append(_UPDATE)
        strSQL.Append("tblPatientConditions")
        strSQL.Append(_SET)
        strSQL.Append("[isActive]='false'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)

    End Sub

    Public Function InsertVisitDetails(ByVal iPatientID As Integer, ByVal iUserID As Integer, ByVal strDexaVisitID As String, ByVal iBodyType As String, ByVal strBMI As String, ByVal strPelvicWidth As String, ByVal strClavicalWidth As String, ByVal strWeight As String, ByVal strHeight As String, ByVal strWaist As String, ByVal strHip As String, ByVal iBPSystolic As String, ByVal iBPDiastolic As String, ByVal iIBW As String, ByVal iDBWeight As String, ByVal iExercise As Integer) As Integer
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_INSERT)
        strSQL.Append("tblVisitHistory([PatientID], [VisitDate], [UserID], [DexaVisitID], [BodyType], [BMI], [PelvicWidth], [ClavicalWidth], [Weight], [Height], [Waist], [Hip], [BPSystolic], [BPDiastolic], [IBW], [DBWeight], [Exercise], [isActive])")
        strSQL.Append(_VALUES)
        strSQL.Append("(" & iPatientID.ToString & ",'" & Now.ToString("yyyy-MM-dd hh:mm:ss") & "'," & iUserID.ToString & ",'" & strDexaVisitID & "'," & iBodyType & "," & strBMI & "," & strPelvicWidth & "," & strClavicalWidth & "," & strWeight & "," & strHeight & "," & strWaist & "," & strHip & "," & iBPSystolic & "," & iBPDiastolic & "," & iIBW & "," & iDBWeight & "," & iExercise & ", 'true')")
        ExecuteNonQuery(strSQL.ToString)

        Return GetIdentity()
    End Function

    Public Sub UpdateVisitDetails(ByVal iVisitID As Integer, ByVal iBodyType As String, ByVal strBMI As String, ByVal strPelvicWidth As String, ByVal strClavicalWidth As String, ByVal strWeight As String, ByVal strHeight As String, ByVal strWaist As String, ByVal strHip As String, ByVal iBPSystolic As String, ByVal iBPDiastolic As String, ByVal iIBW As String, ByVal iDBWeight As String, ByVal iExercise As Integer)
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_UPDATE)
        strSQL.Append("tblVisitHistory")
        strSQL.Append(_SET)
        strSQL.Append("[BodyType]=" & iBodyType & ",")
        strSQL.Append("[BMI]=" & strBMI & ",")
        strSQL.Append("[PelvicWidth]=" & strPelvicWidth & ",")
        strSQL.Append("[ClavicalWidth]=" & strClavicalWidth & ",")
        strSQL.Append("[Weight]=" & strWeight & ",")
        strSQL.Append("[Height]=" & strHeight & ",")
        strSQL.Append("[Waist]=" & strWaist & ",")
        strSQL.Append("[Hip]=" & strHip & ",")
        strSQL.Append("[BPSystolic]=" & iBPSystolic & ",")
        strSQL.Append("[BPDiastolic]=" & iBPDiastolic & ",")
        strSQL.Append("[IBW]=" & iIBW & ",")
        strSQL.Append("[DBWeight]=" & iDBWeight & ",")
        strSQL.Append("[Exercise]=" & iExercise.ToString)
        strSQL.Append(_WHERE)
        strSQL.Append("[VisitID]=" & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)
    End Sub

    Public Function GetCholesterol(ByVal iPatientID As Integer, ByVal iVisitID As Integer) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[TestDate],[TotalChol],[LDL], [HDL], [Triglyc], [NonHDL], [TCHDL], [AddInfo]")
        strSQL.Append(_FROM)
        strSQL.Append("tblCholesterol")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[isActive] = 'true'")

        Return ExecuteReader(strSQL.ToString)
    End Function

    Public Function InsertCholesterol(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal TestDate As String, ByVal iTC As String, ByVal iLDL As String, ByVal iHDL As String, ByVal iTRG As String, ByVal iNonHDL As String, ByVal iTCHDL As String, ByVal AddInfo As String) As Integer
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_INSERT)
        strSQL.Append("tblCholesterol([PatientID], [VisitID], [TestDate], [TotalChol], [LDL], [HDL], [Triglyc], [NonHDL], [TCHDL], [AddInfo], [isActive])")
        strSQL.Append(_VALUES)
        strSQL.Append("(" & iPatientID.ToString & "," & iVisitID.ToString & ",'" & TestDate & "'," & iTC & "," & iLDL & "," & iHDL & "," & iTRG & "," & iNonHDL & "," & iTCHDL & ",'" & dbSafe(AddInfo) & "', 'true')")
        ExecuteNonQuery(strSQL.ToString)

        Return GetIdentity()

    End Function

    Public Sub UpdateCholesterol(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal TestDate As String, ByVal iTC As String, ByVal iLDL As String, ByVal iHDL As String, ByVal iTRG As String, ByVal iNonHDL As String, ByVal iTCHDL As String, ByVal AddInfo As String)
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_UPDATE)
        strSQL.Append("tblCholesterol")
        strSQL.Append(_SET)
        strSQL.Append("[TestDate]='" & TestDate & "',")
        strSQL.Append("[TotalChol]=" & iTC & ",")
        strSQL.Append("[LDL]=" & iLDL & ",")
        strSQL.Append("[HDL]=" & iHDL & ",")
        strSQL.Append("[Triglyc]=" & iTRG & ",")
        strSQL.Append("[NonHDL]=" & iNonHDL & ",")
        strSQL.Append("[TCHDL]=" & iTCHDL & ",")
        strSQL.Append("[AddInfo]='" & dbSafe(AddInfo) & "'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)
    End Sub

    Public Function GetMiscData(ByVal iPatientID As Integer, ByVal iVisitID As Integer) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[LiverALT], [LiverAST], [GluTestType], [Glucose], [GluTime], [RMR], [VO2]")
        strSQL.Append(_FROM)
        strSQL.Append("tblMisc")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[isActive] = 'true'")


        Return ExecuteReader(strSQL.ToString)
    End Function

    Public Function InsertMiscData(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal iALT As String, ByVal iAST As String, ByVal iGluTest As String, ByVal iGlucos As String, ByVal iGluTime As String, ByVal strRMR As String, ByVal strVO2 As Double) As Integer
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_INSERT)
        strSQL.Append("tblMisc([PatientID], [VisitID], [LiverALT], [LiverAST], [GluTestType], [Glucose], [GluTime], [RMR], [VO2], [isActive])")
        strSQL.Append(_VALUES)
        strSQL.Append("(" & iPatientID.ToString & "," & iVisitID.ToString & "," & iALT & "," & iAST & "," & iGluTest & "," & iGlucos & "," & iGluTime & "," & strRMR & "," & strVO2 & ", 'true')")
        ExecuteNonQuery(strSQL.ToString)

        Return GetIdentity()
    End Function

    Public Sub UpdateMiscData(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal iALT As String, ByVal iAST As String, ByVal iGluTest As String, ByVal iGlucose As String, ByVal iGluTime As String, ByVal strRMR As String, ByVal strVO2 As Double)
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_UPDATE)
        strSQL.Append("tblMisc")
        strSQL.Append(_SET)
        strSQL.Append("[LiverALT]=" & iALT & ",")
        strSQL.Append("[LiverAST]=" & iAST & ",")
        strSQL.Append("[GluTestType]=" & iGluTest & ",")
        strSQL.Append("[Glucose]=" & iGlucose & ",")
        strSQL.Append("[GluTime]=" & iGluTime & ",")
        strSQL.Append("[RMR]=" & strRMR & ",")
        strSQL.Append("[VO2]=" & strVO2.ToString)
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)
    End Sub

    Public Function GetBCAData(ByVal iPatientID As Integer, ByVal iVisitID As Integer) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[BCM], [FAT], [ECM], [FFM], [BMR], [ICW], [ECW], [TBW], [PhaseAngle], [Capacitance], [FatPounds], [BCMPounds], [ECMPounds], [FFMPounds], [TBWLiters], [ICWLiters], [ECWLiters], [Resistance], [Reactance]")
        strSQL.Append(_FROM)
        strSQL.Append("tblBCA")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[isActive] = 'true'")

        Return ExecuteReader(strSQL.ToString)
    End Function

    Public Function InsertBCAData(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal strFat As String, ByVal strBCM As String, ByVal strECM As String, ByVal strFFM As String, ByVal strBMR As String, ByVal strICW As String, ByVal strECW As String, ByVal strTBW As String, ByVal strPhaseAngle As String, ByVal strCapacitance As String, ByVal strFatPounds As String, ByVal strBCMPounds As String, ByVal strECMPounds As String, ByVal strFFMPounds As String, ByVal strTBWLiters As String, ByVal strICWLiters As String, ByVal strECWLiters As String, ByVal strResistance As String, ByVal strReactance As Double) As Integer

        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_INSERT)
        strSQL.Append("tblBCA([VisitID], [PatientID], [BCM], [FAT], [ECM], [FFM], [BMR], [ICW], [ECW], [TBW], [PhaseAngle], [Capacitance], [FatPounds], [BCMPounds], [ECMPounds], [FFMPounds], [TBWLiters], [ICWLiters], [ECWLiters], [Resistance], [Reactance], [isActive])")
        strSQL.Append(_VALUES)
        strSQL.Append("(" & iVisitID.ToString & "," & iPatientID.ToString & "," & strBCM & "," & strFat & "," & strECM & "," & strFFM & "," & strBMR & "," & strICW & "," & strECW & "," & strTBW & "," & strPhaseAngle & "," & strCapacitance & "," & strFatPounds & "," & strBCMPounds & "," & strECMPounds & "," & strFFMPounds & "," & strTBWLiters & "," & strICWLiters & "," & strECWLiters & "," & strResistance & "," & strReactance & ", 'true')")
        ExecuteNonQuery(strSQL.ToString)

        Return GetIdentity()
    End Function

    Public Function UpdateBCAData(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal strFat As String, ByVal strBCM As String, ByVal strECM As String, ByVal strFFM As String, ByVal strBMR As String, ByVal strICW As String, ByVal strECW As String, ByVal strTBW As String, ByVal strPhaseAngle As String, ByVal strCapacitance As String, ByVal strFatPounds As String, ByVal strBCMPounds As String, ByVal strECMPounds As String, ByVal strFFMPounds As String, ByVal strTBWLiters As String, ByVal strICWLiters As String, ByVal strECWLiters As String, ByVal strResistance As String, ByVal strReactance As Double) As Integer
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_UPDATE)
        strSQL.Append("tblBCA")
        strSQL.Append(_SET)
        '[[Resistance], [Reactance]
        strSQL.Append("[BCM]=" & strBCM & ",")
        strSQL.Append("[FAT]=" & strFat & ",")
        strSQL.Append("[ECM]=" & strECM & ",")
        strSQL.Append("[FFM]=" & strFFM & ",")
        strSQL.Append("[BMR]=" & strBMR & ",")
        strSQL.Append("[ICW]=" & strICW & ",")
        strSQL.Append("[ECW]=" & strECW & ",")
        strSQL.Append("[TBW]=" & strTBW & ",")
        strSQL.Append("[PhaseAngle]=" & strPhaseAngle & ",")
        strSQL.Append("[Capacitance]=" & strCapacitance & ",")
        strSQL.Append("[FatPounds]=" & strFatPounds & ",")
        strSQL.Append("[BCMPounds]=" & strBCMPounds & ",")
        strSQL.Append("[ECMPounds]=" & strECMPounds & ",")
        strSQL.Append("[FFMPounds]=" & strFFMPounds & ",")
        strSQL.Append("[TBWLiters]=" & strTBWLiters & ",")
        strSQL.Append("[ICWLiters]=" & strICWLiters & ",")
        strSQL.Append("[ECWLiters]=" & strECWLiters & ",")
        strSQL.Append("[Resistance]=" & strResistance & ",")
        strSQL.Append("[Reactance]=" & strReactance)
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)
    End Function

    Public Function GetComposition(ByVal iPatientID As Integer, ByVal iVisitID As Integer) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[Fat], [Bone], [Muscle], [Fluid], [Density]")
        strSQL.Append(_FROM)
        strSQL.Append("tblComposition")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[isActive] = 'true'")

        Return ExecuteReader(strSQL.ToString)
    End Function

    Public Function InsertComposition(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal strFat As String, ByVal strBone As String, ByVal strMuscle As String, ByVal strFluid As String, ByVal strDensity As String) As Integer

        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_INSERT)
        strSQL.Append("tblComposition([VisitID], [PatientID], [Fat], [Bone], [Muscle], [Fluid], [Density], [isActive])")
        strSQL.Append(_VALUES)
        strSQL.Append("(" & iVisitID.ToString & "," & iPatientID.ToString & "," & strFat & "," & strBone & "," & strMuscle & "," & strFluid & "," & strDensity & ", 'true')")
        ExecuteNonQuery(strSQL.ToString)

        Return GetIdentity()
    End Function


    Public Sub UpdateComposition(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal strFat As String, ByVal strBone As String, ByVal strMuscle As String, ByVal strFluid As String, ByVal strDensity As String)

        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_UPDATE)
        strSQL.Append("tblComposition")
        strSQL.Append(_SET)
        strSQL.Append("[Fat]=" & strFat & ",")
        strSQL.Append("[Bone]=" & strBone & ",")
        strSQL.Append("[Muscle]=" & strMuscle & ",")
        strSQL.Append("[Fluid]=" & strFluid & ",")
        strSQL.Append("[Density]=" & strDensity.ToString)
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)

    End Sub

    Public Function GetQuestions(ByVal iPatientID As Integer, ByVal iVisitID As Integer) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[XMLShort]")
        strSQL.Append(_FROM)
        strSQL.Append("tblQuestions")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        Return ExecuteReader(strSQL.ToString)
    End Function

    Public Function InsertQuestions(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal strXMLShort As String)
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_INSERT)
        strSQL.Append("tblQuestions([VisitID], [PatientID], [XMLShort])")
        strSQL.Append(_VALUES)
        strSQL.Append("(" & iVisitID.ToString & "," & iPatientID.ToString & ",'" & dbSafe(strXMLShort) & "')")
        ExecuteNonQuery(strSQL.ToString)

        Return GetIdentity()
    End Function

    Public Sub UpdateQuestions(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal strXMLShort As String)
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_UPDATE)
        strSQL.Append("tblQuestions")
        strSQL.Append(_SET)
        strSQL.Append("[XMLShort]='" & dbSafe(strXMLShort) & "'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)

    End Sub

    Public Function GetPhaseConditions(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal iBodyType As Integer) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("p.[ConditionID], c.[Phase]")
        strSQL.Append(_FROM)
        strSQL.Append("tblPatientConditions p")
        strSQL.Append(_JOIN)
        strSQL.Append("tblConditionList c")
        strSQL.Append(_ON)
        strSQL.Append("c.[ID] = p.[ConditionID]")
        strSQL.Append(_WHERE)
        strSQL.Append("p.[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("p.[VisitID] = " & iVisitID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("p.[Past] = 0")
        strSQL.Append(_AND)
        strSQL.Append("[isActive] = 'true'")


        Select Case iBodyType
            Case 1
                strSQL.Append(_AND)
                strSQL.Append("c.[Body1] = 1")
            Case 2
                strSQL.Append(_AND)
                strSQL.Append("c.[Body2] = 1")
            Case 3
                strSQL.Append(_AND)
                strSQL.Append("c.[Body3] = 1")
            Case 4
                strSQL.Append(_AND)
                strSQL.Append("c.[Body4] = 1")
        End Select

        Return ExecuteReader(strSQL.ToString)
    End Function

    Public Function GetConditions(ByVal iPatientID As Integer, ByVal iVisitID As Integer) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[ConditionID], [Past]")
        strSQL.Append(_FROM)
        strSQL.Append("tblPatientConditions")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[isActive] = 'true'")


        Return ExecuteReader(strSQL.ToString)
    End Function

    Public Sub InsertCondition(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal iCond As Integer, ByVal bPast As Boolean)
        Dim strSQL As New StringBuilder
        Dim iPast As Integer = 0

        If bPast Then iPast = 1

        'SQL Code here
        strSQL.Append(_INSERT)
        strSQL.Append("tblPatientConditions([VisitID], [PatientID], [ConditionID], [Past], [isActive])")
        strSQL.Append(_VALUES)
        strSQL.Append("(" & iVisitID.ToString & "," & iPatientID.ToString & "," & iCond & "," & iPast.ToString & ", 'true')")
        ExecuteNonQuery(strSQL.ToString)
    End Sub


    Public Sub DeleteCondition(ByVal iPatientID As Integer, ByVal iVisitID As Integer)
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_DELETE)
        strSQL.Append(_FROM)
        strSQL.Append("tblPatientConditions")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)
    End Sub


    Public Function GetConditionNotes(ByVal iPatientID As Integer, ByVal iVisitID As Integer) As DataSet
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_SELECT)
        strSQL.Append("[Notes]")
        strSQL.Append(_FROM)
        strSQL.Append("tblConditionNotes")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[isActive] = 'true'")


        Return ExecuteReader(strSQL.ToString)
    End Function

    Public Sub InsertConditionNotes(ByVal iPatientID As Integer, ByVal iVisitID As Integer, ByVal strNotes As String)
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_INSERT)
        strSQL.Append("tblConditionNotes([VisitID], [PatientID], [Notes], [isActive])")
        strSQL.Append(_VALUES)
        strSQL.Append("(" & iVisitID.ToString & "," & iPatientID.ToString & ",'" & dbSafe(strNotes) & "', 'true')")
        ExecuteNonQuery(strSQL.ToString)
    End Sub

    Public Sub UpdateConditionNotes(ByVal iVisitID As String, ByVal iPatientID As String, ByVal strNotes As String)
        Dim strSQL As New StringBuilder

        'SQL Code here
        strSQL.Append(_UPDATE)
        strSQL.Append("tblConditionNotes")
        strSQL.Append(_SET)
        strSQL.Append("[Notes]='" & strNotes & "'")
        strSQL.Append(_WHERE)
        strSQL.Append("[PatientID] = " & iPatientID.ToString)
        strSQL.Append(_AND)
        strSQL.Append("[VisitID] = " & iVisitID.ToString)

        ExecuteNonQuery(strSQL.ToString)

    End Sub
End Class
