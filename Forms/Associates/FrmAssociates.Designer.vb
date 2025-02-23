<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAssociates
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
        Me.Panel57 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbEmployeeStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TxtSearchEmployees = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnAddAssociate = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel61 = New System.Windows.Forms.Panel()
        Me.Panel62 = New System.Windows.Forms.Panel()
        Me.DgEmployee = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.employeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfidNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departmentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.positionName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel57.SuspendLayout()
        CType(Me.DgEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel57
        '
        Me.Panel57.Controls.Add(Me.Label4)
        Me.Panel57.Controls.Add(Me.CbEmployeeStatus)
        Me.Panel57.Controls.Add(Me.Panel9)
        Me.Panel57.Controls.Add(Me.TxtSearchEmployees)
        Me.Panel57.Controls.Add(Me.Panel2)
        Me.Panel57.Controls.Add(Me.BtnAddAssociate)
        Me.Panel57.Controls.Add(Me.Panel1)
        Me.Panel57.Controls.Add(Me.Panel61)
        Me.Panel57.Controls.Add(Me.Panel62)
        Me.Panel57.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel57.Location = New System.Drawing.Point(0, 0)
        Me.Panel57.Name = "Panel57"
        Me.Panel57.Size = New System.Drawing.Size(1498, 49)
        Me.Panel57.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(617, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 41)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Status:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbEmployeeStatus
        '
        Me.CbEmployeeStatus.BackColor = System.Drawing.Color.Transparent
        Me.CbEmployeeStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.CbEmployeeStatus.BorderRadius = 5
        Me.CbEmployeeStatus.Dock = System.Windows.Forms.DockStyle.Right
        Me.CbEmployeeStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbEmployeeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEmployeeStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.CbEmployeeStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.CbEmployeeStatus.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.CbEmployeeStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CbEmployeeStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.CbEmployeeStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.CbEmployeeStatus.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.CbEmployeeStatus.ItemHeight = 33
        Me.CbEmployeeStatus.Items.AddRange(New Object() {"All", "Probationary", "Regular", "Resigned"})
        Me.CbEmployeeStatus.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.CbEmployeeStatus.Location = New System.Drawing.Point(773, 4)
        Me.CbEmployeeStatus.Name = "CbEmployeeStatus"
        Me.CbEmployeeStatus.Size = New System.Drawing.Size(169, 39)
        Me.CbEmployeeStatus.TabIndex = 10
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(942, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(4, 41)
        Me.Panel9.TabIndex = 8
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
        Me.TxtSearchEmployees.PlaceholderText = "Search Employees"
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
        'BtnAddAssociate
        '
        Me.BtnAddAssociate.BorderRadius = 5
        Me.BtnAddAssociate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddAssociate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddAssociate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAddAssociate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAddAssociate.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnAddAssociate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAddAssociate.ForeColor = System.Drawing.Color.White
        Me.BtnAddAssociate.Location = New System.Drawing.Point(1275, 4)
        Me.BtnAddAssociate.Name = "BtnAddAssociate"
        Me.BtnAddAssociate.Size = New System.Drawing.Size(219, 41)
        Me.BtnAddAssociate.TabIndex = 5
        Me.BtnAddAssociate.Text = "NEW ASSOCIATE"
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
        Me.DgEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.employeeID, Me.employeeNumber, Me.rfidNumber, Me.fullName, Me.departmentName, Me.positionName, Me.status})
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
        Me.DgEmployee.TabIndex = 5
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
        'employeeID
        '
        Me.employeeID.DataPropertyName = "employeeID"
        Me.employeeID.HeaderText = "Employee ID"
        Me.employeeID.Name = "employeeID"
        Me.employeeID.ReadOnly = True
        '
        'employeeNumber
        '
        Me.employeeNumber.DataPropertyName = "employeeNumber"
        Me.employeeNumber.HeaderText = "Employee No."
        Me.employeeNumber.Name = "employeeNumber"
        Me.employeeNumber.ReadOnly = True
        '
        'rfidNumber
        '
        Me.rfidNumber.DataPropertyName = "rfidNumber"
        Me.rfidNumber.HeaderText = "RFID"
        Me.rfidNumber.Name = "rfidNumber"
        Me.rfidNumber.ReadOnly = True
        '
        'fullName
        '
        Me.fullName.DataPropertyName = "fullName"
        Me.fullName.HeaderText = "Full Name"
        Me.fullName.Name = "fullName"
        Me.fullName.ReadOnly = True
        '
        'departmentName
        '
        Me.departmentName.DataPropertyName = "departmentName"
        Me.departmentName.HeaderText = "Department"
        Me.departmentName.Name = "departmentName"
        Me.departmentName.ReadOnly = True
        '
        'positionName
        '
        Me.positionName.DataPropertyName = "positionName"
        Me.positionName.HeaderText = "Position"
        Me.positionName.Name = "positionName"
        Me.positionName.ReadOnly = True
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1493, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 749)
        Me.Panel3.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 49)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 749)
        Me.Panel4.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(5, 793)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1488, 5)
        Me.Panel5.TabIndex = 8
        '
        'FrmAssociates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1498, 798)
        Me.ControlBox = False
        Me.Controls.Add(Me.DgEmployee)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel57)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAssociates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel57.ResumeLayout(False)
        CType(Me.DgEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel57 As Panel
    Friend WithEvents Panel61 As Panel
    Friend WithEvents Panel62 As Panel
    Friend WithEvents DgEmployee As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents employeeID As DataGridViewTextBoxColumn
    Friend WithEvents employeeNumber As DataGridViewTextBoxColumn
    Friend WithEvents rfidNumber As DataGridViewTextBoxColumn
    Friend WithEvents fullName As DataGridViewTextBoxColumn
    Friend WithEvents departmentName As DataGridViewTextBoxColumn
    Friend WithEvents positionName As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnAddAssociate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TxtSearchEmployees As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CbEmployeeStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel9 As Panel
End Class
