Imports System.IO


Public Class frmPrintDocs

#Region "Private Members"
    Private m_UserID As Integer
    Private m_UserLogin As String
    Private objDALDocs As DAL.Documents
    Private m_DocPath As String
    Private m_FileList As List(Of String)
    Private bPrinting As Boolean = False


#End Region

#Region "Public Properties"
    Public Property UserID() As Integer
        Get
            Return m_UserID
        End Get
        Set(ByVal value As Integer)
            m_UserID = value
        End Set
    End Property

    Public Property UserLogin() As String
        Get
            Return m_UserLogin
        End Get
        Set(ByVal value As String)
            m_UserLogin = value
        End Set
    End Property
#End Region


    '*******************************************************************************
    ' Create New Objects
    '*******************************************************************************
    Public Sub Init()
        Dim myReader As StreamReader
        objDALDocs = New DAL.Documents

        If File.Exists(Path.GetDirectoryName(Application.ExecutablePath) & "\config.dat") Then
            myReader = New StreamReader(Path.GetDirectoryName(Application.ExecutablePath) & "\config.dat")
            m_DocPath = myReader.ReadLine() & My.Settings.docpath
            myReader.Close()
            myReader = Nothing
        Else
            m_DocPath = Path.GetDirectoryName(Application.ExecutablePath) & My.Settings.docpath
        End If
        m_FileList = New List(Of String)

    End Sub

    '*******************************************************************************
    ' Setup and show this form
    '*******************************************************************************
    Public Sub ShowMe()
        LoadDocumentList()
        Me.Show()
    End Sub

    '*******************************************************************************
    ' Load the current Document list
    '*******************************************************************************
    Public Sub LoadDocumentList()
        Dim objDS As DataSet
        Dim objDSRow As DataRow

        chbDocList.Items.Clear()
        m_FileList.Clear()
        objDS = objDALDocs.GetDocumentList()

        For Each objDSRow In objDS.Tables(0).Rows
            chbDocList.Items.Add(objDSRow.Item("DocTitle").ToString, False)
            m_FileList.Add(objDSRow.Item("FileName").ToString)
        Next

        objDS.Clear()
        objDS.Dispose()
        objDS = Nothing
    End Sub

    Private Sub frmPrintDocs_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        m_FileList.Clear()
        m_FileList = Nothing
        objDALDocs = Nothing
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim strOptions As String
        Dim FileName As String = ""
        Dim iLoop As Integer
        Dim tmpStr As String
        If Not bPrinting Then
            bPrinting = True
            If PrintDiag.ShowDialog = Windows.Forms.DialogResult.OK Then
                strOptions = " -p """ & PrintDiag.PrinterSettings.PrinterName & """"
                strOptions += " -c " & PrintDiag.PrinterSettings.Copies.ToString
                strOptions += " -o 1"

                For iLoop = 0 To chbDocList.Items.Count - 1
                    If chbDocList.GetItemChecked(iLoop) Then
                        tmpStr = m_FileList(iLoop).ToString()
                        FileName += """" & m_DocPath & "\" & tmpStr & " """
                    End If
                Next
                Shell("pdfp " & strOptions & " " & FileName, AppWinStyle.Hide, False)
            End If
            bPrinting = False
        End If

    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim FileName As String = ""
        Dim iLoop As Integer
        Dim tmpStr As String
        Dim objCreateproc As System.Diagnostics.Process


        For iLoop = 0 To chbDocList.Items.Count - 1
            If chbDocList.GetItemChecked(iLoop) Then
                tmpStr = m_FileList(iLoop).ToString()

                FileName = m_DocPath & "\" & tmpStr
                If File.Exists(FileName) Then
                    objCreateproc = New System.Diagnostics.Process
                    objCreateproc.StartInfo.UseShellExecute = True
                    objCreateproc.StartInfo.FileName = FileName
                    objCreateproc.Start()
                    objCreateproc = Nothing
                Else
                    MsgBox(FileName & " couldn't not be found")
                End If

                'Shell(FileName, AppWinStyle.NormalFocus, False)
            End If
        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()

    End Sub
End Class
