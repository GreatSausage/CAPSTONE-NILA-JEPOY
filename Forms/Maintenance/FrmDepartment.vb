Public Class FrmDepartment

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        MdlMaintenance.departmentID = 0
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtDepartment.Text) Then
            EmptyMessage()
            Exit Sub
        Else
            UpdateDepartment(TxtDepartment.Text, MdlMaintenance.departmentID)
            FrmMaintenance.DgDepartment.DataSource = DisplayAllDepartments()

            FrmMaintenance.CbDepartment.DataSource = FilteredDepartments("Active")
            FrmMaintenance.CbDepartment.DisplayMember = "departmentName"
            FrmMaintenance.CbDepartment.ValueMember = "departmentID"
            Me.Close()
        End If
    End Sub
End Class
