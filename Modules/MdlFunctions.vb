Module MdlFunctions

    Public Sub DisplayFormPanel(frm As Form, displayPanel As Panel)
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        displayPanel.Controls.Clear()
        displayPanel.Controls.Add(frm)
        frm.Show()
    End Sub

    Public Sub EmptyMessage()
        MessageBox.Show("Please fill in the necessary fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Module
