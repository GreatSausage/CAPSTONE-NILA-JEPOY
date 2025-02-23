Public Class FrmRates
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtRates.Text) Then
            EmptyMessage()
            Exit Sub
        Else
            UpdateRates(TxtRates.Text, MdlMaintenance.rateID)
            Me.Close()
            FrmMaintenance.DgRates.DataSource = DisplayAllRates()
        End If
    End Sub
End Class