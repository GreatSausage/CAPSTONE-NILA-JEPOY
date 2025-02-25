<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDepartments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtSearchEmployees = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnSetDepartment = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel61 = New System.Windows.Forms.Panel()
        Me.Panel62 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel57 = New System.Windows.Forms.Panel()
        Me.DgEmployee = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.departmentHeadID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departmentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departmentHead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numberOfEmployees = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel57.SuspendLayout()
        CType(Me.DgEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(5, 793)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1488, 5)
        Me.Panel5.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1493, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 749)
        Me.Panel3.TabIndex = 11
        '
        'TxtSearchEmployees
        '
        Me.TxtSearchEmployees.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtSearchEmployees.BorderRadius = 5
        Me.TxtSearchEmployees.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSearchEmployees.DefaultText = ""
        Me.TxtSearchEmployees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSearchEmployees.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSearchEmployees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearchEmployees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearchEmployees.Dock = System.Windows.Forms.DockStyle.Right
        Me.TxtSearchEmployees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtSearchEmployees.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtSearchEmployees.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtSearchEmployees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtSearchEmployees.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtSearchEmployees.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtSearchEmployees.Location = New System.Drawing.Point(946, 4)
        Me.TxtSearchEmployees.Name = "TxtSearchEmployees"
        Me.TxtSearchEmployees.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSearchEmployees.PlaceholderText = "Search Departments"
        Me.TxtSearchEmployees.SelectedText = ""
        Me.TxtSearchEmployees.Size = New System.Drawing.Size(324, 41)
        Me.TxtSearchEmployees.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1270, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 41)
        Me.Panel2.TabIndex = 6
        '
        'BtnSetDepartment
        '
        Me.BtnSetDepartment.BorderRadius = 5
        Me.BtnSetDepartment.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSetDepartment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSetDepartment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSetDepartment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSetDepartment.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSetDepartment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSetDepartment.ForeColor = System.Drawing.Color.White
        Me.BtnSetDepartment.Location = New System.Drawing.Point(1275, 4)
        Me.BtnSetDepartment.Name = "BtnSetDepartment"
        Me.BtnSetDepartment.Size = New System.Drawing.Size(219, 41)
        Me.BtnSetDepartment.TabIndex = 5
        Me.BtnSetDepartment.Text = "SET DEPARTMENT HEAD"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1494, 4)
        Me.Panel1.TabIndex = 2
        '
        'Panel61
        '
        Me.Panel61.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel61.Location = New System.Drawing.Point(0, 45)
        Me.Panel61.Name = "Panel61"
        Me.Panel61.Size = New System.Drawing.Size(1494, 4)
        Me.Panel61.TabIndex = 1
        '
        'Panel62
        '
        Me.Panel62.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel62.Location = New System.Drawing.Point(1494, 0)
        Me.Panel62.Name = "Panel62"
        Me.Panel62.Size = New System.Drawing.Size(4, 49)
        Me.Panel62.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 49)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 749)
        Me.Panel4.TabIndex = 12
        '
        'Panel57
        '
        Me.Panel57.Controls.Add(Me.TxtSearchEmployees)
        Me.Panel57.Controls.Add(Me.Panel2)
        Me.Panel57.Controls.Add(Me.BtnSetDepartment)
        Me.Panel57.Controls.Add(Me.Panel1)
        Me.Panel57.Controls.Add(Me.Panel61)
        Me.Panel57.Controls.Add(Me.Panel62)
        Me.Panel57.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel57.Location = New System.Drawing.Point(0, 0)
        Me.Panel57.Name = "Panel57"
        Me.Panel57.Size = New System.Drawing.Size(1498, 49)
        Me.Panel57.TabIndex = 9
        '
        'DgEmployee
        '
        Me.DgEmployee.AllowUserToAddRows = False
        Me.DgEmployee.AllowUserToDeleteRows = False
        Me.DgEmployee.AllowUserToResizeColumns = False
        Me.DgEmployee.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgEmployee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgEmployee.ColumnHeadersHeight = 40
        Me.DgEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.departmentHeadID, Me.departmentName, Me.departmentHead, Me.numberOfEmployees})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgEmployee.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgEmployee.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgEmployee.Location = New System.Drawing.Point(5, 49)
        Me.DgEmployee.Name = "DgEmployee"
        Me.DgEmployee.ReadOnly = True
        Me.DgEmployee.RowHeadersVisible = False
        Me.DgEmployee.Size = New System.Drawing.Size(1488, 744)
        Me.DgEmployee.TabIndex = 10
        Me.DgEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgEmployee.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgEmployee.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgEmployee.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgEmployee.ThemeStyle.HeaderStyle.Height = 40
        Me.DgEmployee.ThemeStyle.ReadOnly = True
        Me.DgEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgEmployee.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgEmployee.ThemeStyle.RowsStyle.Height = 22
        Me.DgEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'departmentHeadID
        '
        Me.departmentHeadID.HeaderText = "Department Head ID"
        Me.departmentHeadID.Name = "departmentHeadID"
        Me.departmentHeadID.ReadOnly = True
        '
        'departmentName
        '
        Me.departmentName.HeaderText = "Department"
        Me.departmentName.Name = "departmentName"
        Me.departmentName.ReadOnly = True
        '
        'departmentHead
        '
        Me.departmentHead.HeaderText = "Department Head"
        Me.departmentHead.Name = "departmentHead"
        Me.departmentHead.ReadOnly = True
        '
        'numberOfEmployees
        '
        Me.numberOfEmployees.HeaderText = "No. of Employees"
        Me.numberOfEmployees.Name = "numberOfEmployees"
        Me.numberOfEmployees.ReadOnly = True
        '
        'FrmDepartments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1498, 798)
        Me.ControlBox = False
        Me.Controls.Add(Me.DgEmployee)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel57)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDepartments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel57.ResumeLayout(False)
        CType(Me.DgEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtSearchEmployees As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnSetDepartment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel61 As Panel
    Friend WithEvents Panel62 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel57 As Panel
    Friend WithEvents DgEmployee As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents departmentHeadID As DataGridViewTextBoxColumn
    Friend WithEvents departmentName As DataGridViewTextBoxColumn
    Friend WithEvents departmentHead As DataGridViewTextBoxColumn
    Friend WithEvents numberOfEmployees As DataGridViewTextBoxColumn
End Class
