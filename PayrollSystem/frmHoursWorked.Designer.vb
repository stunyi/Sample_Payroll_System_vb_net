<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoursWorked
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpWorkedFrom = New System.Windows.Forms.DateTimePicker()
        Me.DtpWorkedTo = New System.Windows.Forms.DateTimePicker()
        Me.TxtHoursWorked = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Worked From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Worked To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hours Worked"
        '
        'DtpWorkedFrom
        '
        Me.DtpWorkedFrom.Location = New System.Drawing.Point(128, 29)
        Me.DtpWorkedFrom.Name = "DtpWorkedFrom"
        Me.DtpWorkedFrom.Size = New System.Drawing.Size(200, 20)
        Me.DtpWorkedFrom.TabIndex = 3
        '
        'DtpWorkedTo
        '
        Me.DtpWorkedTo.Location = New System.Drawing.Point(128, 73)
        Me.DtpWorkedTo.Name = "DtpWorkedTo"
        Me.DtpWorkedTo.Size = New System.Drawing.Size(200, 20)
        Me.DtpWorkedTo.TabIndex = 4
        '
        'TxtHoursWorked
        '
        Me.TxtHoursWorked.Location = New System.Drawing.Point(128, 112)
        Me.TxtHoursWorked.Name = "TxtHoursWorked"
        Me.TxtHoursWorked.Size = New System.Drawing.Size(200, 20)
        Me.TxtHoursWorked.TabIndex = 5
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(143, 158)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 6
        Me.BtnAdd.Text = "&Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(243, 158)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'frmHoursWorked
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 202)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtHoursWorked)
        Me.Controls.Add(Me.DtpWorkedTo)
        Me.Controls.Add(Me.DtpWorkedFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(366, 241)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(366, 241)
        Me.Name = "frmHoursWorked"
        Me.Text = "Add Hours Worked"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpWorkedFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpWorkedTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
