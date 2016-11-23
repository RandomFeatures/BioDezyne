Public Class frmSettings

    Private Sub btnRequire_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRequire.CheckedChanged
        If Not btnRequire.Checked Then
            btnLog.Enabled = True
        Else
            btnLog.Enabled = False
            btnLog.Checked = True

        End If
    End Sub

    Private Sub frmSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        btnRequire.Checked = My.Settings.sy510g
        btnLog.Enabled = Not btnRequire.Checked
        btnLog.Checked = My.Settings.logevent

        txtName.Text = My.Settings.ClinicName
        txtSlogan.Text = My.Settings.Slogan
        txtAddress.Text = My.Settings.Address
        txtPhone.Text = FormatPhoneNum(My.Settings.Phone)
        txtFax.Text = FormatPhoneNum(My.Settings.Fax)
        txtWeb.Text = My.Settings.Web
        chkDexa.Checked = My.Settings.UseDexa
        txtDexa.Text = My.Settings.DexaLocation

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click

        My.Settings.ClinicName = txtName.Text.Trim
        My.Settings.Slogan = txtSlogan.Text.Trim
        My.Settings.Address = txtAddress.Text.Trim
        My.Settings.Phone = UnFormatPhoneNum(txtPhone.Text.Trim)
        My.Settings.Fax = UnFormatPhoneNum(txtFax.Text.Trim)
        My.Settings.Web = txtWeb.Text.Trim
        My.Settings.DexaLocation = txtDexa.Text
        My.Settings.sy510g = btnRequire.Checked
        My.Forms.frmMain.btnManageUsers.Enabled = btnRequire.Checked
        My.Forms.frmMain.btnNewUser.Enabled = btnRequire.Checked
        My.Forms.frmMain.LoginToolStripMenuItem.Visible = btnRequire.Checked
        My.Forms.frmPatient.LogEvents = btnRequire.Checked
        My.Forms.frmPatient.UseDexa = chkDexa.Checked
        My.Settings.logevent = btnLog.Checked
        My.Settings.UseDexa = chkDexa.Checked
        Me.Close()
    End Sub

    Private Sub Text_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPhone.Enter, txtFax.Enter
        sender.Text = UnFormatPhoneNum(sender.Text)
    End Sub

    Private Sub Text_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPhone.Leave, txtFax.Leave
        sender.Text = FormatPhoneNum(sender.Text)
    End Sub

    Private Sub chkDexa_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDexa.CheckedChanged
        txtDexa.Enabled = chkDexa.Checked
        btnDexa.Enabled = chkDexa.Checked
    End Sub

    Private Sub btnDexa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDexa.Click
        If OpenFile.ShowDialog Then
            txtDexa.Text = OpenFile.FileName
        End If
    End Sub

End Class
