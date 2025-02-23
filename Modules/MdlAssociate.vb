Imports MySql.Data.MySqlClient

Module MdlAssociate


#Region "INSERT"

    Private Function GenerateEmployeeNumber() As String
        Dim currentYear As String = DateTime.Now.Year.ToString()
        Dim newNumber As Integer = 1
        Dim lastEmployeeNumber As String = ""

        Dim command As New MySqlCommand("SELECT employeeNumber FROM tblEmployee WHERE employeeNumber LIKE @year ORDER BY employeeNumber DESC LIMIT 1", FrmMain.conn)
        command.Parameters.AddWithValue("@year", currentYear & "%")

        Dim reader As MySqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            lastEmployeeNumber = reader("employeeNumber").ToString()
            Dim lastNumber As Integer = Convert.ToInt32(lastEmployeeNumber.Substring(4))
            newNumber = lastNumber + 1
        End If
        reader.Close()

        Return currentYear & newNumber.ToString("D4")
    End Function

    Public Function GetPositionName(positionID As Integer) As String
        Dim command As New MySqlCommand("SELECT positionName FROM tblPosition WHERE positionID = @positionID", FrmMain.conn)
        command.Parameters.AddWithValue("@positionID", positionID)
        Return Convert.ToString(command.ExecuteScalar())
    End Function

    Public Sub NewAssociate(rfidNumber As String, firstName As String, lastName As String, departmentID As Integer, positionID As Integer, status As String, salary As Decimal, type As String)
        Dim newEmployeeNumber As String = GenerateEmployeeNumber()
        Dim position As String = GetPositionName(positionID)

        If position = "Department Head" Then
            Dim checkHeadCommand As New MySqlCommand("SELECT COUNT(*) FROM tblEmployee WHERE departmentID = @departmentID AND positionID = @positionID", FrmMain.conn)
            With checkHeadCommand.Parameters
                .AddWithValue("@departmentID", departmentID)
                .AddWithValue("@positionID", positionID)
            End With
            Dim existingHeads As Integer = Convert.ToInt32(checkHeadCommand.ExecuteScalar())

            ' If a department head already exists, prevent adding another
            If existingHeads > 0 Then
                MessageBox.Show("An employee already exists for this position in this department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        'personal info
        Dim command As New MySqlCommand("INSERT INTO tblEmployee (employeeNumber, rfidNumber, firstName, lastName, departmentID, positionID, status, password, logged) 
                                     VALUES (@employeeNumber, @rfidNumber, @firstName, @lastName, @departmentID, @positionID, @status, 'password', 'No')", FrmMain.conn)
        With command.Parameters
            .AddWithValue("@employeeNumber", newEmployeeNumber)
            .AddWithValue("@rfidNumber", rfidNumber)
            .AddWithValue("@firstName", firstName)
            .AddWithValue("@lastName", lastName)
            .AddWithValue("@departmentID", departmentID)
            .AddWithValue("@positionID", positionID)
            .AddWithValue("@status", status)
        End With
        command.ExecuteNonQuery()

        'last inserted employee ID
        Dim employeeID As Integer
        Dim commandGetID As New MySqlCommand("SELECT LAST_INSERT_ID()", FrmMain.conn)
        employeeID = Convert.ToInt32(commandGetID.ExecuteScalar())

        'salary info
        Dim commandSalary As New MySqlCommand("INSERT INTO tblSalary (employeeID, salary, type) VALUES (@employeeID, @salary, @type)", FrmMain.conn)
        With commandSalary.Parameters
            .AddWithValue("@employeeID", employeeID)
            .AddWithValue("@salary", salary)
            .AddWithValue("@type", type)
        End With
        commandSalary.ExecuteNonQuery()

        'voluntary info

        For Each row As DataGridViewRow In FrmAddAssociates.DGVoluntary.Rows
            Dim volID As Integer = row.Cells("voluntaryID").Value
            Dim amount As Decimal = If(String.IsNullOrEmpty(row.Cells("amount").Value), 0, row.Cells("amount").Value)

            Dim voluntaryCommand As New MySqlCommand("INSERT INTO tblempvoluntary (employeeID, voluntaryID, amount) VALUES (@employeeID, @voluntaryID, @amount) ON DUPLICATE KEY UPDATE amount = @amount", FrmMain.conn)
            With voluntaryCommand.Parameters
                .AddWithValue("@voluntaryID", volID)
                .AddWithValue("@employeeID", employeeID)
                .AddWithValue("@amount", amount)
            End With
            voluntaryCommand.ExecuteNonQuery()
        Next

        MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


#End Region

#Region "READ"

    Public Function DisplayActiveDepartment() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblDepartment WHERE status LIKE 'Active'", FrmMain.conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function DisplayActivePosition(departmentID As Integer) As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblPosition WHERE departmentID = @departmentID", FrmMain.conn)
        command.Parameters.AddWithValue("@departmentID", departmentID)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function


    Public Function DisplayAllEmployees() As DataTable
        Dim command As New MySqlCommand("SELECT a.employeeID, a.employeeNumber, a.rfidNumber, CONCAT(a.firstName, ' ', a.lastName) AS Fullname, d.departmentName, p.positionName, a.status 
                                         FROM tblEmployee a 
                                         JOIN tblDepartment d ON d.departmentID = a.departmentID 
                                         JOIN tblPosition p ON p.positionID = a.positionID", FrmMain.conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function FilteredEmployees(status As String) As DataTable
        Dim command As New MySqlCommand("SELECT a.employeeID, a.employeeNumber, a.rfidNumber, CONCAT(a.firstName, ' ', a.lastName) AS Fullname, d.departmentName, p.positionName, a.status 
                                         FROM tblEmployee a 
                                         JOIN tblDepartment d ON d.departmentID = a.departmentID 
                                         JOIN tblPosition p ON p.positionID = a.positionID
                                         WHERE a.status LIKE @status", FrmMain.conn)
        command.Parameters.AddWithValue("@status", status)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function SearchEmployees(keyword As String) As DataTable
        Dim command As New MySqlCommand("SELECT a.employeeID, a.employeeNumber, a.rfidNumber, CONCAT(a.firstName, ' ', a.lastName) AS Fullname, d.departmentName, p.positionName, a.status 
                                         FROM tblEmployee a 
                                         JOIN tblDepartment d ON d.departmentID = a.departmentID 
                                         JOIN tblPosition p ON p.positionID = a.positionID
                                         WHERE a.employeeNumber LIKE @keyword OR a.firstName LIKE @keyword OR a.lastName LIKE @keyword OR d.departmentName LIKE @keyword OR p.positionName LIKE @keyword OR a.rfidNumber LIKE @keyword", FrmMain.conn)
        command.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function
#End Region

End Module
