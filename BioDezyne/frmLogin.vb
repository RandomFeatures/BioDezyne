Public Class frmLogin
    Private m_Password As String
    Private m_UserLogin As String
    Private m_TryLoging As Boolean

    Public ReadOnly Property TryLoging() As Boolean
        Get
            Return m_TryLoging
        End Get
    End Property
    Public ReadOnly Property Password() As String
        Get
            Return m_Password
        End Get
    End Property

    Public ReadOnly Property UserLogin() As String
        Get
            Return m_UserLogin
        End Get
    End Property


    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        m_Password = txtPassword.Text.Trim
        m_UserLogin = txtUserName.Text.Trim.ToLower

        If m_UserLogin = "" Or m_Password = "" Then
            m_TryLoging = False
        Else
            m_TryLoging = True
        End If
        Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        m_TryLoging = False
        Close()
    End Sub

 
    Private Sub txtPassword_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        If txtUserName.Text <> "" And txtPassword.Text <> "" Then
            If btnLogin.Enabled = False Then
                btnLogin.Enabled = True
            End If
        Else
            If btnLogin.Enabled = True Then
                btnLogin.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtUserName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged
        If txtUserName.Text <> "" And txtPassword.Text <> "" Then
            If btnLogin.Enabled = False Then
                btnLogin.Enabled = True
            End If
        Else
            If btnLogin.Enabled = True Then
                btnLogin.Enabled = False
            End If
        End If

    End Sub
End Class
