<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSetDepartmentHead
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CbDepartments = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbEmployees = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnSetDepartment = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(800, 49)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SET DEPARTMENT HEAD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 238)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(790, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 238)
        Me.Panel2.TabIndex = 3
        '
        'CbDepartments
        '
        Me.CbDepartments.BackColor = System.Drawing.Color.Transparent
        Me.CbDepartments.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CbDepartments.BorderRadius = 5
        Me.CbDepartments.Dock = System.Windows.Forms.DockStyle.Top
        Me.CbDepartments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbDepartments.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbDepartments.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbDepartments.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CbDepartments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbDepartments.ItemHeight = 30
        Me.CbDepartments.Items.AddRange(New Object() {"Daily", "Monthly"})
        Me.CbDepartments.Location = New System.Drawing.Point(10, 94)
        Me.CbDepartments.Name = "CbDepartments"
        Me.CbDepartments.Size = New System.Drawing.Size(780, 36)
        Me.CbDepartments.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(780, 45)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Department:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CbEmployees
        '
        Me.CbEmployees.BackColor = System.Drawing.Color.Transparent
        Me.CbEmployees.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CbEmployees.BorderRadius = 5
        Me.CbEmployees.Dock = System.Windows.Forms.DockStyle.Top
        Me.CbEmployees.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEmployees.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbEmployees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbEmployees.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CbEmployees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbEmployees.ItemHeight = 30
        Me.CbEmployees.Items.AddRange(New Object() {"Daily", "Monthly"})
        Me.CbEmployees.Location = New System.Drawing.Point(10, 175)
        Me.CbEmployees.Name = "CbEmployees"
        Me.CbEmployees.Size = New System.Drawing.Size(780, 36)
        Me.CbEmployees.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(780, 45)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Department Head:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(10, 277)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(780, 10)
        Me.Panel3.TabIndex = 31
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Guna2Button1)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.BtnSetDepartment)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(10, 229)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(780, 48)
        Me.Panel4.TabIndex = 33
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
        Me.BtnSetDepartment.Location = New System.Drawing.Point(630, 0)
        Me.BtnSetDepartment.Name = "BtnSetDepartment"
        Me.BtnSetDepartment.Size = New System.Drawing.Size(150, 48)
        Me.BtnSetDepartment.TabIndex = 33
        Me.BtnSetDepartment.Text = "SET"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(620, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 48)
        Me.Panel5.TabIndex = 34
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(470, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(150, 48)
        Me.Guna2Button1.TabIndex = 35
        Me.Guna2Button1.Text = "CANCEL"
        '
        'FrmSetDepartmentHead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 287)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.CbEmployees)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbDepartments)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmSetDepartmentHead"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CbDepartments As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CbEmployees As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnSetDepartment As Guna.UI2.WinForms.Guna2Button
End Class
