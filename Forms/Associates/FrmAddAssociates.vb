Public Class FrmAddAssociates
    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub FrmAddAssociates_Load(sender As Object, e As EventArgs) Handles Me.Load
        DGVoluntary.DataSource = DisplayAllVoluntary()

        CbDepartment.DataSource = DisplayActiveDepartment()
        CbDepartment.DisplayMember = "departmentName"
        CbDepartment.ValueMember = "departmentID"

        Dim departmentID As Integer = CbDepartment.SelectedValue
        CbPosition.DataSource = DisplayActivePosition(departmentID)
        CbPosition.DisplayMember = "positionName"
        CbPosition.ValueMember = "positionID"

        CbAssociateStatus.SelectedIndex = 0
        CbCompensationType.SelectedIndex = 0
    End Sub

    Private Sub CbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDepartment.SelectedIndexChanged
        Dim selectedRow As DataRowView = TryCast(CbDepartment.SelectedItem, DataRowView)

        If selectedRow IsNot Nothing Then
            Dim departmentID As Integer = Convert.ToInt32(selectedRow("departmentID"))
            CbPosition.DataSource = DisplayActivePosition(departmentID)
            CbPosition.DisplayMember = "positionName"
            CbPosition.ValueMember = "positionID"
        End If
    End Sub

    Private Sub BtnSaveAssociate_Click(sender As Object, e As EventArgs) Handles BtnSaveAssociate.Click
        If String.IsNullOrEmpty(TxtFirstName.Text) OrElse
            String.IsNullOrEmpty(TxtLastname.Text) OrElse
            String.IsNullOrEmpty(TxtRfidNumber.Text) Then
            EmptyMessage()
            Exit Sub
        Else
            Dim selectedDepartment As DataRowView = TryCast(CbDepartment.SelectedItem, DataRowView)
            Dim selectedPosition As DataRowView = TryCast(CbPosition.SelectedItem, DataRowView)
            Dim departmentID As Integer = Convert.ToInt32(selectedDepartment("departmentID"))
            Dim positionID As Integer = Convert.ToInt32(selectedPosition("positionID"))
            NewAssociate(TxtRfidNumber.Text, TxtFirstName.Text, TxtLastname.Text, departmentID, positionID, CbAssociateStatus.SelectedItem, TxtSalary.Text, CbCompensationType.SelectedItem)
            FrmAssociates.DgEmployee.DataSource = DisplayAllEmployees()
            Me.Close()
            TxtFirstName.Clear()
            TxtLastname.Clear()
            TxtRfidNumber.Clear()
            TxtSalary.Clear()
            CbAssociateStatus.SelectedIndex = 0
            CbCompensationType.SelectedIndex = 0
        End If
    End Sub
End Class