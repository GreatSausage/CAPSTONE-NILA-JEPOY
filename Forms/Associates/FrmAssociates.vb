Public Class FrmAssociates
    Private Sub BtnAddAssociate_Click(sender As Object, e As EventArgs) Handles BtnAddAssociate.Click
        FrmAddAssociates.ShowDialog()
    End Sub

    Private Sub FrmAssociates_Load(sender As Object, e As EventArgs) Handles Me.Load
        DgEmployee.DataSource = DisplayAllEmployees()
        CbEmployeeStatus.SelectedIndex = 0
    End Sub

    Private Sub CbEmployeeStatus_SelectedIndexChanged(sender As Object, e As EventArgs)
        If CbEmployeeStatus.SelectedIndex = 0 Then
            DgEmployee.DataSource = DisplayAllEmployees()
            Exit Sub
        ElseIf CbEmployeeStatus.SelectedIndex = 1 Then
            DgEmployee.DataSource = FilteredEmployees("Probationary")
            Exit Sub
        ElseIf CbEmployeeStatus.SelectedIndex = 2 Then
            DgEmployee.DataSource = FilteredEmployees("Regular")
            Exit Sub
        ElseIf CbEmployeeStatus.SelectedIndex = 3 Then
            DgEmployee.DataSource = FilteredEmployees("Resigned")
            Exit Sub
        End If
    End Sub

    Private Sub TxtSearchEmployees_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchEmployees.TextChanged
        DgEmployee.DataSource = SearchEmployees(TxtSearchEmployees.Text)
    End Sub

End Class