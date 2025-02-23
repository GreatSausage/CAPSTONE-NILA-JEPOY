Imports MySql.Data.MySqlClient
Module MdlMaintenance

    Public ds As New DataSet
    Public adp As New MySqlDataAdapter

#Region "Department"

    Public departmentID As Integer = 0

#Region "INSERT AND UPDATE"
    Public Sub NewDepartment(departmentName As String)
        Dim command As New MySqlCommand("INSERT INTO tblDepartment (departmentName, status) VALUES (@departmentName, 'Active')", FrmMain.conn)
        command.Parameters.AddWithValue("@departmentName", departmentName)
        command.ExecuteNonQuery()

        Dim getID As Integer
        Dim getIDCommand As New MySqlCommand("SELECT LAST_INSERT_ID()", FrmMain.conn)
        getID = Convert.ToInt32(getIDCommand.ExecuteScalar())

        Dim commandTwo As New MySqlCommand("INSERT INTO tblPosition (positionName, departmentID, status) VALUES (@positionName, @departmentID, 'Active')", FrmMain.conn)
        commandTwo.Parameters.AddWithValue("@positionName", "Department Head")
        commandTwo.Parameters.AddWithValue("@departmentID", getID)
        commandTwo.ExecuteNonQuery()

        MessageBox.Show("Department added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub SelectDepartment(dg As DataGridView)
        Try
            If dg.SelectedRows.Count > 0 Then
                departmentID = dg.SelectedRows(0).Cells(0).Value
                FrmDepartment.TxtDepartment.Text = dg.SelectedRows(0).Cells("departmentName").Value
                FrmDepartment.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateDepartment(departmentName As String, departmentID As Integer)
        Dim command As New MySqlCommand("UPDATE tblDepartment SET departmentName = @departmentName WHERE departmentID = @departmentID", FrmMain.conn)
        command.Parameters.AddWithValue("@departmentName", departmentName)
        command.Parameters.AddWithValue("@departmentID", departmentID)
        command.ExecuteNonQuery()
        MessageBox.Show("Department updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region

#Region "READ"

    Public Function DisplayAllDepartments() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblDepartment", FrmMain.conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function FilteredDepartments(keyword As String) As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblDepartment WHERE status LIKE @keyword", FrmMain.conn)
        command.Parameters.AddWithValue("@keyword", keyword)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function SearchDepartment(keyword As String) As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblDepartment WHERE departmentName LIKE @keyword", FrmMain.conn)
        command.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function
#End Region

#End Region

#Region "Position"

    Public positionID As Integer = 0

#Region "INSERT AND UPDATE"

    Public Sub NewPosition(positionName As String, departmentID As Integer)
        Dim command As New MySqlCommand("INSERT INTO tblPosition (positionName, departmentID, status) VALUES (@positionName, @departmentID, 'Active')", FrmMain.conn)
        command.Parameters.AddWithValue("@positionName", positionName)
        command.Parameters.AddWithValue("@departmentID", departmentID)
        command.ExecuteNonQuery()
        MessageBox.Show("Position added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'pahelp dine
    Public Sub SelectPosition(dg As DataGridView)
        If dg.SelectedRows.Count > 0 Then
            positionID = dg.SelectedRows(0).Cells(0).Value
            FrmPosition.TxtPosition.Text = dg.SelectedRows(0).Cells("positionName").Value
            FrmPosition.CbDepartment.Text = dg.SelectedRows(0).Cells("positiondepartmentName").Value.ToString
        End If
    End Sub

#End Region

#Region "READ"

    Public Function DisplayAllPosition() As DataTable
        Dim command As New MySqlCommand("SELECT p.positionID, p.positionName, d.departmentName, p.status  
                                         FROM tblPosition p 
                                         JOIN tblDepartment d ON p.departmentID = d.departmentID", FrmMain.conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function FilteredPositions(status As String) As DataTable
        Dim command As New MySqlCommand("SELECT p.positionID, p.positionName, d.departmentName, p.status 
                                         FROM tblPosition p 
                                         JOIN tblDepartment d ON p.departmentID = d.departmentID 
                                         WHERE p.status LIKE @status", FrmMain.conn)
        command.Parameters.AddWithValue("@status", status)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function SearchPosition(keyword As String) As DataTable
        Dim command As New MySqlCommand("SELECT p.positionID, p.positionName, d.departmentName, p.status 
                                         FROM tblPosition p 
                                         JOIN tblDepartment d ON p.departmentID = d.departmentID 
                                         WHERE p.positionName LIKE @keyword OR d.departmentName LIKE @keyword", FrmMain.conn)
        command.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

#End Region

#End Region

#Region "Leave"

    Public leaveID As Integer = 0

#Region "INSERT AND UPDATE"

    Public Sub NewLeave(leaveType As String)
        Dim command As New MySqlCommand("INSERT INTO tblLeave (leaveType) VALUES (@leaveType)", FrmMain.conn)
        command.Parameters.AddWithValue("@leaveType", leaveType)
        command.ExecuteNonQuery()
        MessageBox.Show("Leave added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub SelectLeave(dg As DataGridView)
        If dg.SelectedRows.Count > 0 Then
            leaveID = dg.SelectedRows(0).Cells(0).Value
            FrmLeave.TxtLeave.Text = dg.SelectedRows(0).Cells(1).Value
            FrmLeave.ShowDialog()
        End If
    End Sub
#End Region

#Region "READ"

    Public Function DisplayAllLeave() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblLeave", FrmMain.conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function FilteredLeave(status As String) As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblLeave WHERE status LIKE @status", FrmMain.conn)
        command.Parameters.AddWithValue("@status", status)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function SearchLeave(keyword As String) As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblLeave WHERE leaveType LIKE @keyword", FrmMain.conn)
        command.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

#End Region

#End Region

#Region "Incentive"

#Region "INSERT AND UPDATE"

    Public Sub NewIncentive(incentiveName As String)
        Dim command As New MySqlCommand("INSERT INTO tblIncentives (incentiveName) VALUES (@incentiveName)", FrmMain.conn)
        command.Parameters.AddWithValue("@incentiveName", incentiveName)
        command.ExecuteNonQuery()
        MessageBox.Show("Incentive added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region

#Region "READ"

    Public Function DisplayAllIncentive() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblIncentives", FrmMain.conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function FilteredIncentive(status As String) As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblIncentives WHERE status LIKE @status", FrmMain.conn)
        command.Parameters.AddWithValue("@status", status)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function SearchIncentive(keyword As String) As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblIncentives WHERE incentiveName LIKE @keyword", FrmMain.conn)
        command.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

#End Region

#End Region

#Region "Holiday"

    Public holidayID As Integer = 0

#Region "INSERT AND UPDATE"
    Public Sub NewHoliday(holidayName As String, holidayDate As Date, classification As String)
        Dim command As New MySqlCommand("INSERT INTO tblHoliday (holidayName, classification, date) VALUES (@holidayName, @classification, @date)", FrmMain.conn)
        command.Parameters.AddWithValue("@holidayName", holidayName)
        command.Parameters.AddWithValue("@date", holidayDate)
        command.Parameters.AddWithValue("@classification", classification)
        command.ExecuteNonQuery()
        MessageBox.Show("Holiday added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub SelectHoliday(dg As DataGridView)
        If dg.SelectedRows.Count > 0 Then
            holidayID = dg.SelectedRows(0).Cells("holidayID").Value
            FrmHoliday.TxtHolidayName.Text = dg.SelectedRows(0).Cells("holidayName").Value
            FrmHoliday.DtHoliday.Value = dg.SelectedRows(0).Cells("holidayDate").Value
            FrmHoliday.TxtClassification.Text = dg.SelectedRows(0).Cells("holidayClassification").Value.ToString
            FrmHoliday.ShowDialog()
        End If
    End Sub
#End Region

#Region "READ"

    Public Function DisplayAllHoliday() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblHoliday", FrmMain.conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function SearchHoliday(keyword As String) As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblHoliday WHERE holidayName LIKE @keyword", FrmMain.conn)
        command.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

#End Region

#End Region

#Region "Rates"

    Public rateID As Integer = 0

#Region "INSERT AND UPDATE"

    Public Sub UpdateRates(rate As Integer, rateID As Integer)
        Dim command As New MySqlCommand("UPDATE tblRates SET rate = @rate WHERE rateID = @rateID", FrmMain.conn)
        command.Parameters.AddWithValue("@rate", rate)
        command.Parameters.AddWithValue("@rateID", rateID)
        command.ExecuteNonQuery()
        MessageBox.Show("Rate updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub SelectRates(dg As DataGridView)
        If dg.SelectedRows.Count > 0 Then
            rateID = dg.SelectedRows(0).Cells("rateID").Value
            FrmRates.TxtRates.Text = dg.SelectedRows(0).Cells("rate").Value
            FrmRates.TxtRateClassification.Text = dg.SelectedRows(0).Cells("rateClassification").Value
            FrmRates.ShowDialog()
        End If
    End Sub

#End Region

#Region "READ"

    Public Function DisplayAllRates() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblRates", FrmMain.conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

#End Region


#End Region

#Region "Contributions"

#Region "Tax"


#Region "INSERT AND UPDATE"

    Public Sub NewTaxDaily(minimumSalary As Decimal, maximumSalary As Decimal, fixedAmount As Decimal, percentage As Integer)
        Dim command As New MySqlCommand("INSERT INTO tblTaxDaily (minSalary, maxSalary, fixedAmount, percentage) 
                                         VALUES (@minSalary, @maxSalary, @fixedAmount, @percentage)", FrmMain.conn)
        With command.Parameters
            .AddWithValue("@minSalary", minimumSalary)
            .AddWithValue("@maxSalary", maximumSalary)
            .AddWithValue("@fixedAmount", fixedAmount)
            .AddWithValue("@percentage", percentage)
        End With
        command.ExecuteNonQuery()
        MessageBox.Show("Tax added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub NewTaxMonthly(minimumSalary As Decimal, maximumSalary As Decimal, fixedAmount As Decimal, percentage As Integer)
        Dim command As New MySqlCommand("INSERT INTO tblTaxMonthly (minSalary, maxSalary, fixedAmount, percentage) 
                                          VALUES (@minSalary, @maxSalary, @fixedAmount, @percentage)", FrmMain.conn)
        With command.Parameters
            .AddWithValue("@minSalary", minimumSalary)
            .AddWithValue("@maxSalary", maximumSalary)
            .AddWithValue("@fixedAmount", fixedAmount)
            .AddWithValue("@percentage", percentage)
        End With
        command.ExecuteNonQuery()
        MessageBox.Show("Tax added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub DeleteTaxDaily()
        Try
            Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblTaxDaily", FrmMain.conn)
            Dim count As Integer = checkCommand.ExecuteScalar()
            If count = 0 Then
                MessageBox.Show("This tax cannot deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim command As New MySqlCommand("DELETE FROM tblTaxDaily ORDER BY taxID DESC LIMIT 1", FrmMain.conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Tax deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub DeleteTaxMonthly()
        Try
            Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblTaxMonthly", FrmMain.conn)
            Dim count As Integer = checkCommand.ExecuteScalar()
            If count = 0 Then
                MessageBox.Show("This tax cannot deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim command As New MySqlCommand("DELETE FROM tblTaxMonthly ORDER BY taxID DESC LIMIT 1", FrmMain.conn)
            command.ExecuteNonQuery()
            MessageBox.Show("Tax deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "READ"

    Public Function DisplayTaxDaily() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblTaxDaily", FrmMain.conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function DisplayTaxMonthly() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblTaxMonthly", FrmMain.conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function


    Public Sub RunQuery(ByVal querystatement As String)
        Try
            adp = New MySqlDataAdapter(querystatement, FrmMain.conn)
            ds = New DataSet
            adp.Fill(ds, "querytable")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function TaxGetMaxSalary(tableName As String) As Decimal
        Try
            Dim max As Decimal = 0
            RunQuery($"Select maxSalary from {tableName} order by taxID DESC LIMIT 1")
            If ds.Tables("querytable").Rows.Count > 0 Then
                Dim result = ds.Tables("querytable").Rows(0)(0)
                If Not IsDBNull(result) Then
                    max = Convert.ToDecimal(result) + 0.01
                End If
            Else
                max = 0
            End If
            Return max
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return 0
        End Try
    End Function

#End Region

#End Region

#Region "SSS"

#Region "INSERT AND UPDATE"
    Public Sub NewSSS(minSalary As Decimal, maxSalary As Decimal, EE As Decimal, er As Decimal)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblSSS (minSalary, maxSalary, ee, er) 
                                         VALUES (@minSalary, @maxSalary, @ee, @er)", FrmMain.conn)
            With command.Parameters
                .AddWithValue("@minSalary", minSalary)
                .AddWithValue("@maxSalary", maxSalary)
                .AddWithValue("@ee", EE)
                .AddWithValue("@er", er)
            End With

            command.ExecuteNonQuery()
            MessageBox.Show("SSS added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DeleteSSS()
        Try
            Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblSSS", FrmMain.conn)
            Dim count As Integer = checkCommand.ExecuteScalar()
            If count = 0 Then
                MessageBox.Show("This SSS cannot deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim command As New MySqlCommand("DELETE FROM tblSSS ORDER BY sssID DESC LIMIT 1", FrmMain.conn)
            command.ExecuteNonQuery()
            MessageBox.Show("SSS deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "READ"
    Public Function DisplaySSS() As DataTable
        Dim datatable As New DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblSSS", FrmMain.conn)
            Dim adapter As New MySqlDataAdapter(command)

            adapter.Fill(datatable)
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return datatable
    End Function

    Public Function SSSGetMaxSalary() As Decimal
        Try
            Dim max As Decimal = 0
            RunQuery("Select max(maxSalary) from tblsss")
            If ds.Tables("querytable").Rows.Count > 0 Then
                Dim result = ds.Tables("querytable").Rows(0)(0)
                If Not IsDBNull(result) Then
                    max = Convert.ToDecimal(result) + 0.01
                End If
            Else
                max = 0
            End If
            Return max
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return 0
        End Try
    End Function
#End Region

#End Region

#Region "PAG-IBIG"

    Public Function DisplayPagIbig() As DataTable
        Dim datatable As New DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblpagibig ORDER BY date DESC", FrmMain.conn)
            Dim adapter As New MySqlDataAdapter(command)

            adapter.Fill(datatable)
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return datatable
    End Function

    Public Sub NewPagibig(rate As Integer)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblpagibig (rate, date) VALUES (@rate, current_timestamp)", FrmMain.conn)
            With command.Parameters
                .AddWithValue("@rate", rate)
            End With

            command.ExecuteNonQuery()

            MessageBox.Show("New Pag-Ibig rate updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "PhilHealth"

    Public Function DisplayPhilhealth() As DataTable
        Dim datatable As New DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblPhilhealth ORDER BY date DESC", FrmMain.conn)
            Dim adapter As New MySqlDataAdapter(command)

            adapter.Fill(datatable)
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return datatable
    End Function

    Public Sub NewPhilhealth(rate As Integer)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblPhilHealth (rate, date) VALUES (@rate, NOW())", FrmMain.conn)
            command.Parameters.AddWithValue("@rate", rate)
            command.ExecuteNonQuery()
            MessageBox.Show("PhilHealth rate added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
#End Region

#Region "Voluntary"

    Public voluntaryID As Integer = 0

#Region "INSERT AND UPDATE"

    Public Sub NewVoluntary(voluntaryName As String)
        Dim command As New MySqlCommand("INSERT INTO tblVoluntary (voluntaryName) VALUES (@voluntaryName)", FrmMain.conn)
        command.Parameters.AddWithValue("@voluntaryName", voluntaryName)
        command.ExecuteNonQuery()
        MessageBox.Show("Voluntary added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub SelectVoluntaryID(dg As DataGridView)
        If dg.SelectedRows.Count > 0 Then
            voluntaryID = dg.SelectedRows(0).Cells(0).Value
            FrmVoluntary.TxtVoluntary.Text = dg.SelectedRows(0).Cells(1).Value
            FrmVoluntary.ShowDialog()
        End If
    End Sub

    Public Sub UpdateVoluntary(voluntaryName As String)
        Dim command As New MySqlCommand("UPDATE tblVoluntary SET voluntaryName = @voluntaryName WHERE voluntaryID = @voluntaryID", FrmMain.conn)
        command.Parameters.AddWithValue("@voluntaryName", voluntaryName)
        command.Parameters.AddWithValue("@voluntaryID", voluntaryID)
        command.ExecuteNonQuery()
        MessageBox.Show("Voluntary added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region

#Region "READ"

    Public Function DisplayAllVoluntary() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblVoluntary", FrmMain.conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function FilteredVoluntary(status As String) As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblVoluntary WHERE status LIKE @status", FrmMain.conn)
        command.Parameters.AddWithValue("@status", status)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function SearchVoluntary(keyword As String) As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblVoluntary WHERE voluntaryName LIKE @keyword", FrmMain.conn)
        command.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

#End Region

#End Region
End Module
