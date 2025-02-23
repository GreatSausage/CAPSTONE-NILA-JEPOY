Public Class FrmMaintenance

    Private Sub FrmMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        DgDepartment.DataSource = DisplayAllDepartments()
        DgPosition.DataSource = DisplayAllPosition()
        DgLeave.DataSource = DisplayAllLeave()
        DgIncentive.DataSource = DisplayAllIncentive()
        DgHoliday.DataSource = DisplayAllHoliday()
        DgRates.DataSource = DisplayAllRates()
        dgTax.DataSource = DisplayTaxDaily()
        dgSSS.DataSource = DisplaySSS()
        dgPagibig.DataSource = DisplayPagIbig()
        dgPhilhealth.DataSource = DisplayPhilhealth()
        DgVoluntary.DataSource = DisplayAllVoluntary()

        CbDepartmentStatus.SelectedIndex = 0
        CbPositionStatus.SelectedIndex = 0
        cbLeaveStatus.SelectedIndex = 0
        CbIncentiveStatus.SelectedIndex = 0
        TxtClassification.SelectedIndex = 0
        CbTaxClassification.SelectedIndex = 0
        CbVoluntaryStatus.SelectedIndex = 0

        CbDepartment.DataSource = FilteredDepartments("Active")
        CbDepartment.ValueMember = "departmentID"
        CbDepartment.DisplayMember = "departmentName"
    End Sub


#Region "Department"
    Private Sub BtnSaveDepartment_Click(sender As Object, e As EventArgs) Handles BtnSaveDepartment.Click
        Try
            If String.IsNullOrEmpty(TxtDepartment.Text) Then
                EmptyMessage()
                Exit Sub
            Else
                NewDepartment(TxtDepartment.Text)
                DgDepartment.DataSource = DisplayAllDepartments()

                CbDepartment.DataSource = FilteredDepartments("Active")
                TxtDepartment.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CbDepartmentStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDepartmentStatus.SelectedIndexChanged
        If CbDepartmentStatus.SelectedIndex = 1 Then
            DgDepartment.DataSource = FilteredDepartments("Active")
        ElseIf CbDepartmentStatus.SelectedIndex = 2 Then
            DgDepartment.DataSource = FilteredDepartments("Inactive")
        ElseIf CbDepartmentStatus.SelectedIndex = 0 Then
            DgDepartment.DataSource = DisplayAllDepartments()
        End If
    End Sub

    Private Sub TxtSearchDepartment_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchDepartment.TextChanged
        DgDepartment.DataSource = SearchDepartment(TxtSearchDepartment.Text)
    End Sub

    Private Sub DgDepartment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgDepartment.CellClick
        SelectDepartment(DgDepartment)
    End Sub

#End Region

#Region "Position"

    Private Sub BtnSavePosition_Click(sender As Object, e As EventArgs) Handles BtnSavePosition.Click
        If String.IsNullOrEmpty(TxtPosition.Text) OrElse String.IsNullOrEmpty(CbDepartment.Text) Then
            EmptyMessage()
            Exit Sub
        Else
            NewPosition(TxtPosition.Text, CbDepartment.SelectedValue)
            TxtPosition.Clear()
            CbDepartment.SelectedIndex = 0
        End If
    End Sub

    Private Sub CbPositionStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPositionStatus.SelectedIndexChanged
        If CbPositionStatus.SelectedIndex = 0 Then
            DgPosition.DataSource = DisplayAllPosition()
            Exit Sub
        ElseIf CbPositionStatus.SelectedIndex = 1 Then
            DgPosition.DataSource = FilteredPositions("Active")
            Exit Sub
        ElseIf CbPositionStatus.SelectedIndex = 2 Then
            DgPosition.DataSource = FilteredPositions("Inactive")
            Exit Sub
        End If
    End Sub

    Private Sub TxtSearchPosition_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchPosition.TextChanged
        DgPosition.DataSource = SearchPosition(TxtSearchPosition.Text)
    End Sub

    Private Sub DgPosition_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgPosition.CellClick
        SelectPosition(DgPosition)
    End Sub

#End Region

#Region "Leave"

    Private Sub BtnLeave_Click(sender As Object, e As EventArgs) Handles BtnLeave.Click
        If String.IsNullOrEmpty(TxtLeave.Text) Then
            EmptyMessage()
            Exit Sub
        Else
            NewLeave(TxtLeave.Text)
            DgLeave.DataSource = DisplayAllLeave()
        End If
    End Sub

    Private Sub CbLeaveStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLeaveStatus.SelectedIndexChanged
        If cbLeaveStatus.SelectedIndex = 0 Then
            DgLeave.DataSource = DisplayAllLeave()
            Exit Sub
        ElseIf cbLeaveStatus.SelectedIndex = 1 Then
            DgLeave.DataSource = FilteredLeave("Active")
            Exit Sub
        ElseIf cbLeaveStatus.SelectedIndex = 2 Then
            DgLeave.DataSource = FilteredLeave("Inactive")
        End If
    End Sub

    Private Sub TxtSearchLeave_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchLeave.TextChanged
        DgLeave.DataSource = SearchLeave(TxtSearchLeave.Text)
    End Sub

    Private Sub DgLeave_CellClick(sender As Object, e As EventArgs) Handles DgLeave.CellClick
        SelectLeave(DgLeave)
    End Sub

#End Region

#Region "Incentive"

    Private Sub BtnIncentive_Click(sender As Object, e As EventArgs) Handles BtnIncentive.Click
        If String.IsNullOrEmpty(TxtIncentive.Text) Then
            EmptyMessage()
            Exit Sub
        Else
            NewIncentive(TxtIncentive.Text)
            DgIncentive.DataSource = DisplayAllIncentive()
        End If
    End Sub

    Private Sub CbIncentiveStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbIncentiveStatus.SelectedIndexChanged
        If CbIncentiveStatus.SelectedIndex = 0 Then
            DgIncentive.DataSource = DisplayAllIncentive()
            Exit Sub
        ElseIf CbIncentiveStatus.SelectedIndex = 1 Then
            DgIncentive.DataSource = FilteredIncentive("Active")
            Exit Sub
        ElseIf CbIncentiveStatus.SelectedIndex = 2 Then
            DgIncentive.DataSource = FilteredIncentive("Inactive")
            Exit Sub
        End If
    End Sub

    Private Sub TxtSearchIncentive_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchIncentive.TextChanged
        DgIncentive.DataSource = SearchIncentive(TxtSearchIncentive.Text)
    End Sub
#End Region

#Region "Holiday"

    Private Sub BtnHoliday_Click(sender As Object, e As EventArgs) Handles BtnHoliday.Click
        If String.IsNullOrEmpty(TxtHoliday.Text) OrElse String.IsNullOrEmpty(TxtClassification.Text) Then
            EmptyMessage()
            Exit Sub
        Else
            NewHoliday(TxtHoliday.Text, DtHoliday.Value, TxtClassification.Text)
            DgHoliday.DataSource = DisplayAllHoliday()
        End If
    End Sub

    Private Sub TxtSearchHoliday_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchHoliday.TextChanged
        DgHoliday.DataSource = SearchHoliday(TxtSearchHoliday.Text)
    End Sub

    Private Sub DgHoliday_CellClick(sender As Object, e As EventArgs) Handles DgHoliday.CellClick
        SelectHoliday(DgHoliday)
    End Sub

#End Region

#Region "Rates"

    Private Sub DgRates_CellClick(sender As Object, e As EventArgs) Handles DgRates.CellClick
        SelectRates(DgRates)
    End Sub

#End Region

#Region "Contributions"

#Region "Tax"
    Private Sub CbTaxClassification_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTaxClassification.SelectedIndexChanged
        If CbTaxClassification.SelectedIndex = 0 Then
            dgTax.DataSource = DisplayTaxDaily()
            Exit Sub
        ElseIf CbTaxClassification.SelectedIndex = 1 Then
            dgTax.DataSource = DisplayTaxMonthly()
        End If
    End Sub

    Private Sub BtnSaveTax_Click(sender As Object, e As EventArgs) Handles BtnSaveTax.Click

        If CbTaxClassification.SelectedIndex = 0 Then
            If String.IsNullOrEmpty(TxtTaxFixedAmount.Text) OrElse
                String.IsNullOrEmpty(TxtTaxMaxSalary.Text) OrElse
                String.IsNullOrEmpty(TxtTaxPercentage.Text) Then
                EmptyMessage()
                Exit Sub
            Else
                Dim maxSalary As Decimal = Val(TxtTaxMaxSalary.Text)
                Dim minSalary As Decimal = Val(TxtTaxMinSalary.Text)
                Dim fixedAmount As Decimal = Val(TxtTaxFixedAmount.Text)
                Dim taxPercentage As Integer = Val(TxtTaxPercentage.Text)
                NewTaxDaily(minSalary, maxSalary, fixedAmount, taxPercentage)
                CbTaxClassification.SelectedIndex = 0
                dgTax.DataSource = DisplayTaxDaily()
                Dim maxSalaryOne As Decimal = TaxGetMaxSalary("tblTaxDaily")
                TxtTaxMinSalary.Text = maxSalaryOne
                TxtTaxMaxSalary.Clear()
                TxtTaxFixedAmount.Clear()
                TxtTaxPercentage.Clear()
            End If
        ElseIf CbTaxClassification.SelectedIndex = 1 Then
            If String.IsNullOrEmpty(TxtTaxFixedAmount.Text) OrElse
            String.IsNullOrEmpty(TxtTaxMaxSalary.Text) OrElse
            String.IsNullOrEmpty(TxtTaxPercentage.Text) Then
                EmptyMessage()
                Exit Sub
            Else
                Dim maxSalary As Decimal = Val(TxtTaxMaxSalary.Text)
                Dim minSalary As Decimal = Val(TxtTaxMinSalary.Text)
                Dim fixedAmount As Decimal = Val(TxtTaxFixedAmount.Text)
                Dim taxPercentage As Integer = Val(TxtTaxPercentage.Text)
                NewTaxMonthly(minSalary, maxSalary, fixedAmount, taxPercentage)
                CbTaxClassification.SelectedIndex = 1
                dgTax.DataSource = DisplayTaxMonthly()
                Dim maxSalaryOne As Decimal = TaxGetMaxSalary("tblTaxMonthly")
                TxtTaxMinSalary.Text = maxSalaryOne
                TxtTaxMaxSalary.Clear()
                TxtTaxFixedAmount.Clear()
                TxtTaxPercentage.Clear()
            End If
        End If
    End Sub

    Private Sub BtnDeleteTax_Click(sender As Object, e As EventArgs) Handles BtnDeleteTax.Click
        If CbTaxClassification.SelectedIndex = 0 Then
            DeleteTaxDaily()
            CbTaxClassification.SelectedIndex = 0
            dgTax.DataSource = DisplayTaxDaily()
            Dim maxSalaryOne As Decimal = TaxGetMaxSalary("tblTaxDaily")
            TxtTaxMinSalary.Text = maxSalaryOne
            TxtTaxMaxSalary.Clear()
            TxtTaxFixedAmount.Clear()
            TxtTaxPercentage.Clear()
            Exit Sub
        ElseIf CbTaxClassification.SelectedIndex = 1 Then
            DeleteTaxMonthly()
            CbTaxClassification.SelectedIndex = 1
            dgTax.DataSource = DisplayTaxMonthly()
            Dim maxSalaryOne As Decimal = TaxGetMaxSalary("tblTaxMonthly")
            TxtTaxMinSalary.Text = maxSalaryOne
            TxtTaxMaxSalary.Clear()
            TxtTaxFixedAmount.Clear()
            TxtTaxPercentage.Clear()
        End If
    End Sub
#End Region

#Region "SSS"

    Private Sub BtnSaveSSS_Click(sender As Object, e As EventArgs) Handles BtnSaveSSS.Click
        Try
            If String.IsNullOrEmpty(TxtSSSMaxSalary.Text) OrElse
                    String.IsNullOrEmpty(TxtSSSEE.Text) OrElse
                    String.IsNullOrEmpty(TxtSSSER.Text) Then
                EmptyMessage()
                Exit Sub
            ElseIf Val(TxtSSSEE.Text > 10000) Then
                MessageBox.Show("Invalid amount of EE")
                Exit Sub
            Else
                Dim minSalary As Decimal
                If String.IsNullOrEmpty(TxtSSSMinSalary.Text) Then
                    minSalary = 0
                Else
                    minSalary = Val(TxtSSSMinSalary.Text)
                End If
                NewSSS(minSalary, Val(TxtSSSMaxSalary.Text), Val(TxtSSSEE.Text), Val(TxtSSSER.Text))
                dgSSS.DataSource = DisplaySSS()
                Dim sssMaxSalary As Decimal = SSSGetMaxSalary()
                TxtSSSMinSalary.Text = sssMaxSalary
                TxtSSSMaxSalary.Clear()
                TxtSSSEE.Clear()
                TxtSSSER.Clear()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnDeleteSSS_Click(sender As Object, e As EventArgs) Handles BtnDeleteSSS.Click
        If dgSSS.Rows.Count = 0 Then
            MessageBox.Show("Invalid deletion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to delete this SSS?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            DeleteSSS()
            dgSSS.DataSource = DisplaySSS()
            TxtSSSMinSalary.Text = SSSGetMaxSalary()
            Exit Sub
        End If
    End Sub
#End Region

#Region "PAG-IBIG"

    Private Sub BtnSavePagIbig_Click(sender As Object, e As EventArgs) Handles BtnSavePagibig.Click
        Try
            If String.IsNullOrEmpty(TxtPagibigRate.Text) Then
                MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                NewPagibig(TxtPagibigRate.Text)
                dgPagibig.DataSource = DisplayPagIbig()
                TxtPagibigRate.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "PhilHealth"

    Private Sub BtnSavePhilHealth_Click(sender As Object, e As EventArgs) Handles BtnSavePhilhealth.Click
        Try
            If String.IsNullOrEmpty(txtPhilhealthRate.Text) Then
                EmptyMessage()
                Exit Sub

            Else
                NewPhilhealth(Convert.ToInt32(txtPhilhealthRate.Text))
                dgPhilhealth.DataSource = DisplayPhilhealth()
                txtPhilhealthRate.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#End Region

#Region "Voluntary"

    Private Sub BtnVoluntary_Click(sender As Object, e As EventArgs) Handles BtnVoluntary.Click
        If String.IsNullOrEmpty(TxtVoluntary.Text) Then
            EmptyMessage()
            Exit Sub
        Else
            NewVoluntary(TxtVoluntary.Text)
            DgVoluntary.DataSource = DisplayAllVoluntary()
            TxtVoluntary.Clear()
        End If
    End Sub

    Private Sub CbVoluntaryStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbVoluntaryStatus.SelectedIndexChanged
        If CbVoluntaryStatus.SelectedIndex = 0 Then
            DgVoluntary.DataSource = DisplayAllVoluntary()
            Exit Sub
        ElseIf CbVoluntaryStatus.SelectedIndex = 1 Then
            DgVoluntary.DataSource = FilteredVoluntary("Active")
            Exit Sub
        ElseIf CbVoluntaryStatus.SelectedIndex = 2 Then
            DgVoluntary.DataSource = FilteredVoluntary("Inactive")
            Exit Sub
        End If
    End Sub

    Private Sub TxtSearchVoluntary_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchVoluntary.TextChanged
        DgVoluntary.DataSource = SearchVoluntary(TxtSearchVoluntary.Text)
    End Sub

    Private Sub DgVoluntary_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgVoluntary.CellClick
        SelectVoluntaryID(DgVoluntary)
    End Sub


#End Region
End Class