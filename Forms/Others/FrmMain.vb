Imports MySql.Data.MySqlClient
Public Class FrmMain

    Public connection As String = "Server=localhost;Database=dbmcpms;Uid=root;pwd=;"
    Public conn As MySqlConnection
    Private Sub FrmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y - (y - Screen.PrimaryScreen.WorkingArea.Height)
        Me.Left = 0
        Me.Top = 0
    End Sub

    Private Sub BtnMaintenance_Click(sender As Object, e As EventArgs) Handles BtnMaintenance.Click
        DisplayFormPanel(FrmMaintenance, panelDisplay)
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connect()
        DisplayFormPanel(FrmMaintenance, panelDisplay)
    End Sub

    Public Sub Connect()
        Try
            conn = New MySqlConnection(connection)
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub BtnAssociate_Click(sender As Object, e As EventArgs) Handles BtnAssociate.Click
        DisplayFormPanel(FrmAssociates, panelDisplay)
    End Sub

    Private Sub BtnDepartment_Click(sender As Object, e As EventArgs) Handles BtnDepartment.Click
        DisplayFormPanel(FrmDepartments, panelDisplay)
    End Sub

    Private Sub BtnPayrollCalculation_Click(sender As Object, e As EventArgs) Handles BtnPayrollCalculation.Click
        DisplayFormPanel(FrmCalculation, panelDisplay)
    End Sub
End Class