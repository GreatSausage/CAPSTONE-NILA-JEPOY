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
        Me.Panel61 = New System.Windows.Forms.Panel()
        Me.Panel62 = New System.Windows.Forms.Panel()
        Me.DgVoluntary = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.employeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfidNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departmentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.positionName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel60 = New System.Windows.Forms.Panel()
        Me.TxtSearchVoluntary = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnAddAssociate = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel57.SuspendLayout()
        CType(Me.DgVoluntary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel60.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel57
        '
        Me.Panel57.Controls.Add(Me.Panel60)
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
        'DgVoluntary
        '
        Me.DgVoluntary.AllowUserToAddRows = False
        Me.DgVoluntary.AllowUserToDeleteRows = False
        Me.DgVoluntary.AllowUserToResizeColumns = False
        Me.DgVoluntary.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgVoluntary.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgVoluntary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgVoluntary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgVoluntary.ColumnHeadersHeight = 40
        Me.DgVoluntary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.employeeID, Me.employeeNumber, Me.rfidNumber, Me.fullName, Me.departmentName, Me.positionName, Me.status})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgVoluntary.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgVoluntary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgVoluntary.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgVoluntary.Location = New System.Drawing.Point(0, 49)
        Me.DgVoluntary.Name = "DgVoluntary"
        Me.DgVoluntary.ReadOnly = True
        Me.DgVoluntary.RowHeadersVisible = False
        Me.DgVoluntary.Size = New System.Drawing.Size(1498, 749)
        Me.DgVoluntary.TabIndex = 5
        Me.DgVoluntary.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgVoluntary.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgVoluntary.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgVoluntary.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgVoluntary.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgVoluntary.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgVoluntary.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgVoluntary.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgVoluntary.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgVoluntary.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgVoluntary.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgVoluntary.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgVoluntary.ThemeStyle.HeaderStyle.Height = 40
        Me.DgVoluntary.ThemeStyle.ReadOnly = True
        Me.DgVoluntary.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgVoluntary.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgVoluntary.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgVoluntary.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgVoluntary.ThemeStyle.RowsStyle.Height = 22
        Me.DgVoluntary.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgVoluntary.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1494, 4)
        Me.Panel1.TabIndex = 2
        '
        'Panel60
        '
        Me.Panel60.Controls.Add(Me.TxtSearchVoluntary)
        Me.Panel60.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel60.Location = New System.Drawing.Point(946, 4)
        Me.Panel60.Name = "Panel60"
        Me.Panel60.Size = New System.Drawing.Size(324, 41)
        Me.Panel60.TabIndex = 7
        '
        'TxtSearchVoluntary
        '
        Me.TxtSearchVoluntary.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtSearchVoluntary.BorderRadius = 5
        Me.TxtSearchVoluntary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSearchVoluntary.DefaultText = ""
        Me.TxtSearchVoluntary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSearchVoluntary.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSearchVoluntary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearchVoluntary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearchVoluntary.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TxtSearchVoluntary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtSearchVoluntary.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtSearchVoluntary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtSearchVoluntary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtSearchVoluntary.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtSearchVoluntary.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtSearchVoluntary.Location = New System.Drawing.Point(0, 1)
        Me.TxtSearchVoluntary.Name = "TxtSearchVoluntary"
        Me.TxtSearchVoluntary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSearchVoluntary.PlaceholderText = "Search Associates"
        Me.TxtSearchVoluntary.SelectedText = ""
        Me.TxtSearchVoluntary.Size = New System.Drawing.Size(324, 40)
        Me.TxtSearchVoluntary.TabIndex = 3
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
        'FrmAssociates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1498, 798)
        Me.ControlBox = False
        Me.Controls.Add(Me.DgVoluntary)
        Me.Controls.Add(Me.Panel57)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAssociates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel57.ResumeLayout(False)
        CType(Me.DgVoluntary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel60.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel57 As Panel
    Friend WithEvents Panel61 As Panel
    Friend WithEvents Panel62 As Panel
    Friend WithEvents DgVoluntary As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents employeeID As DataGridViewTextBoxColumn
    Friend WithEvents employeeNumber As DataGridViewTextBoxColumn
    Friend WithEvents rfidNumber As DataGridViewTextBoxColumn
    Friend WithEvents fullName As DataGridViewTextBoxColumn
    Friend WithEvents departmentName As DataGridViewTextBoxColumn
    Friend WithEvents positionName As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents Panel60 As Panel
    Friend WithEvents TxtSearchVoluntary As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnAddAssociate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
End Class
