Public Class FrmVoluntary
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtVoluntary.Text) Then
            EmptyMessage()
            Exit Sub
        Else
            UpdateVoluntary(TxtVoluntary.Text)
            FrmMaintenance.DgVoluntary.DataSource = DisplayAllVoluntary()
            Me.Close()
        End If
    End Sub
End Class