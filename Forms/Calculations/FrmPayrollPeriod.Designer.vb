<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayrollPeriod
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtPayout = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFrom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CbPayrollPeriod = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TxtPayout
        '
        Me.TxtPayout.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPayout.DefaultText = ""
        Me.TxtPayout.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPayout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPayout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPayout.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPayout.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPayout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPayout.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPayout.Location = New System.Drawing.Point(524, 106)
        Me.TxtPayout.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtPayout.Name = "TxtPayout"
        Me.TxtPayout.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPayout.PlaceholderText = ""
        Me.TxtPayout.ReadOnly = True
        Me.TxtPayout.SelectedText = ""
        Me.TxtPayout.Size = New System.Drawing.Size(197, 27)
        Me.TxtPayout.TabIndex = 96
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(546, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 100)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Payout Period"
        '
        'TxtTo
        '
        Me.TxtTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTo.DefaultText = ""
        Me.TxtTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTo.Location = New System.Drawing.Point(261, 106)
        Me.TxtTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtTo.Name = "TxtTo"
        Me.TxtTo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTo.PlaceholderText = ""
        Me.TxtTo.ReadOnly = True
        Me.TxtTo.SelectedText = ""
        Me.TxtTo.Size = New System.Drawing.Size(197, 27)
        Me.TxtTo.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(533, 100)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "To"
        '
        'TxtFrom
        '
        Me.TxtFrom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFrom.DefaultText = ""
        Me.TxtFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtFrom.Location = New System.Drawing.Point(10, 106)
        Me.TxtFrom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtFrom.Name = "TxtFrom"
        Me.TxtFrom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFrom.PlaceholderText = ""
        Me.TxtFrom.ReadOnly = True
        Me.TxtFrom.SelectedText = ""
        Me.TxtFrom.Size = New System.Drawing.Size(214, 27)
        Me.TxtFrom.TabIndex = 92
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 100)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "From"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(698, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(38, 13)
        Me.LinkLabel1.TabIndex = 90
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "[close]"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.White
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(10, 185)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(780, 32)
        Me.Guna2Button2.TabIndex = 89
        Me.Guna2Button2.Text = "SELECT"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(10, 217)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(780, 8)
        Me.Panel3.TabIndex = 88
        '
        'CbPayrollPeriod
        '
        Me.CbPayrollPeriod.BackColor = System.Drawing.Color.Transparent
        Me.CbPayrollPeriod.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbPayrollPeriod.Dock = System.Windows.Forms.DockStyle.Top
        Me.CbPayrollPeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbPayrollPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPayrollPeriod.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbPayrollPeriod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbPayrollPeriod.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbPayrollPeriod.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbPayrollPeriod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbPayrollPeriod.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbPayrollPeriod.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbPayrollPeriod.ItemHeight = 35
        Me.CbPayrollPeriod.Location = New System.Drawing.Point(10, 44)
        Me.CbPayrollPeriod.Margin = New System.Windows.Forms.Padding(2)
        Me.CbPayrollPeriod.Name = "CbPayrollPeriod"
        Me.CbPayrollPeriod.Size = New System.Drawing.Size(780, 41)
        Me.CbPayrollPeriod.TabIndex = 87
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 181)
        Me.Panel2.TabIndex = 86
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(790, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 181)
        Me.Panel1.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(800, 44)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Please select payroll period:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FrmPayrollPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 225)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtPayout)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.CbPayrollPeriod)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmPayrollPeriod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPayout As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFrom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CbPayrollPeriod As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
