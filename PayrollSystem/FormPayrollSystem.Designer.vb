<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayrollSystem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPersonalDetails = New System.Windows.Forms.TabPage()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.DataGridViewHoursWorked = New System.Windows.Forms.DataGridView()
        Me.ColumnBeginPeriod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnEndPeriod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnHoursWorked = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuItemAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboGrade = New System.Windows.Forms.ComboBox()
        Me.CboGender = New System.Windows.Forms.ComboBox()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.TabPayrollReport = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnGrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTotalHoursWorked = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTotalHourlyPay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnHouseAllowance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnGrossPay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTotalTax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNetPay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuItemDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPersonalDetails.SuspendLayout()
        CType(Me.DataGridViewHoursWorked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPayrollReport.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(8, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 461)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPersonalDetails)
        Me.TabControl1.Controls.Add(Me.TabPayrollReport)
        Me.TabControl1.Location = New System.Drawing.Point(12, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(704, 438)
        Me.TabControl1.TabIndex = 1
        '
        'TabPersonalDetails
        '
        Me.TabPersonalDetails.Controls.Add(Me.BtnEdit)
        Me.TabPersonalDetails.Controls.Add(Me.BtnUpdate)
        Me.TabPersonalDetails.Controls.Add(Me.BtnAddNew)
        Me.TabPersonalDetails.Controls.Add(Me.BtnNext)
        Me.TabPersonalDetails.Controls.Add(Me.BtnPrevious)
        Me.TabPersonalDetails.Controls.Add(Me.DataGridViewHoursWorked)
        Me.TabPersonalDetails.Controls.Add(Me.Label4)
        Me.TabPersonalDetails.Controls.Add(Me.Label3)
        Me.TabPersonalDetails.Controls.Add(Me.Label2)
        Me.TabPersonalDetails.Controls.Add(Me.Label1)
        Me.TabPersonalDetails.Controls.Add(Me.CboGrade)
        Me.TabPersonalDetails.Controls.Add(Me.CboGender)
        Me.TabPersonalDetails.Controls.Add(Me.TxtLastName)
        Me.TabPersonalDetails.Controls.Add(Me.TxtFirstName)
        Me.TabPersonalDetails.Location = New System.Drawing.Point(4, 22)
        Me.TabPersonalDetails.Name = "TabPersonalDetails"
        Me.TabPersonalDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPersonalDetails.Size = New System.Drawing.Size(696, 412)
        Me.TabPersonalDetails.TabIndex = 0
        Me.TabPersonalDetails.Text = "Personal Details"
        Me.TabPersonalDetails.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Location = New System.Drawing.Point(485, 347)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 14
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnUpdate.Location = New System.Drawing.Point(566, 347)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 13
        Me.BtnUpdate.Text = "Update Changes"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAddNew.Location = New System.Drawing.Point(402, 347)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddNew.TabIndex = 12
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnNext.Location = New System.Drawing.Point(94, 347)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(52, 23)
        Me.BtnNext.TabIndex = 11
        Me.BtnNext.Text = ">"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnPrevious.Location = New System.Drawing.Point(38, 347)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(50, 23)
        Me.BtnPrevious.TabIndex = 10
        Me.BtnPrevious.Text = "<"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'DataGridViewHoursWorked
        '
        Me.DataGridViewHoursWorked.AllowUserToAddRows = False
        Me.DataGridViewHoursWorked.AllowUserToDeleteRows = False
        Me.DataGridViewHoursWorked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewHoursWorked.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewHoursWorked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewHoursWorked.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnBeginPeriod, Me.ColumnEndPeriod, Me.ColumnHoursWorked})
        Me.DataGridViewHoursWorked.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewHoursWorked.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewHoursWorked.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewHoursWorked.Location = New System.Drawing.Point(38, 133)
        Me.DataGridViewHoursWorked.Name = "DataGridViewHoursWorked"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewHoursWorked.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewHoursWorked.Size = New System.Drawing.Size(613, 198)
        Me.DataGridViewHoursWorked.TabIndex = 8
        '
        'ColumnBeginPeriod
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ColumnBeginPeriod.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColumnBeginPeriod.HeaderText = "Begin Period"
        Me.ColumnBeginPeriod.Name = "ColumnBeginPeriod"
        '
        'ColumnEndPeriod
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ColumnEndPeriod.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColumnEndPeriod.HeaderText = "End Period"
        Me.ColumnEndPeriod.Name = "ColumnEndPeriod"
        '
        'ColumnHoursWorked
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.ColumnHoursWorked.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColumnHoursWorked.HeaderText = "Hours Worked"
        Me.ColumnHoursWorked.Name = "ColumnHoursWorked"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemAdd, Me.MenuItemDelete})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 70)
        '
        'MenuItemAdd
        '
        Me.MenuItemAdd.Name = "MenuItemAdd"
        Me.MenuItemAdd.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemAdd.Text = "Add"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(438, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "G&rade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(435, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "&Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "&First Name"
        '
        'CboGrade
        '
        Me.CboGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboGrade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGrade.FormattingEnabled = True
        Me.CboGrade.Location = New System.Drawing.Point(504, 72)
        Me.CboGrade.Name = "CboGrade"
        Me.CboGrade.Size = New System.Drawing.Size(121, 21)
        Me.CboGrade.TabIndex = 3
        '
        'CboGender
        '
        Me.CboGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGender.FormattingEnabled = True
        Me.CboGender.Location = New System.Drawing.Point(504, 35)
        Me.CboGender.Name = "CboGender"
        Me.CboGender.Size = New System.Drawing.Size(121, 21)
        Me.CboGender.TabIndex = 2
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(102, 70)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(254, 20)
        Me.TxtLastName.TabIndex = 1
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(102, 33)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(254, 20)
        Me.TxtFirstName.TabIndex = 0
        '
        'TabPayrollReport
        '
        Me.TabPayrollReport.Controls.Add(Me.Panel2)
        Me.TabPayrollReport.Location = New System.Drawing.Point(4, 22)
        Me.TabPayrollReport.Name = "TabPayrollReport"
        Me.TabPayrollReport.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPayrollReport.Size = New System.Drawing.Size(696, 412)
        Me.TabPayrollReport.TabIndex = 1
        Me.TabPayrollReport.Text = "Payroll Report"
        Me.TabPayrollReport.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(15, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(664, 368)
        Me.Panel2.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnFirstName, Me.ColumnLastName, Me.ColumnGrade, Me.ColumnGender, Me.ColumnTotalHoursWorked, Me.ColumnTotalHourlyPay, Me.ColumnHouseAllowance, Me.ColumnGrossPay, Me.ColumnTotalTax, Me.ColumnNetPay})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView1.Location = New System.Drawing.Point(12, 16)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView1.Size = New System.Drawing.Size(641, 336)
        Me.DataGridView1.TabIndex = 1
        '
        'ColumnFirstName
        '
        Me.ColumnFirstName.HeaderText = "First Name"
        Me.ColumnFirstName.Name = "ColumnFirstName"
        Me.ColumnFirstName.ReadOnly = True
        '
        'ColumnLastName
        '
        Me.ColumnLastName.HeaderText = "Last Name"
        Me.ColumnLastName.Name = "ColumnLastName"
        Me.ColumnLastName.ReadOnly = True
        '
        'ColumnGrade
        '
        Me.ColumnGrade.HeaderText = "Grade"
        Me.ColumnGrade.Name = "ColumnGrade"
        Me.ColumnGrade.ReadOnly = True
        '
        'ColumnGender
        '
        Me.ColumnGender.HeaderText = "Gender"
        Me.ColumnGender.Name = "ColumnGender"
        Me.ColumnGender.ReadOnly = True
        '
        'ColumnTotalHoursWorked
        '
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.ColumnTotalHoursWorked.DefaultCellStyle = DataGridViewCellStyle8
        Me.ColumnTotalHoursWorked.HeaderText = "Hours Worked"
        Me.ColumnTotalHoursWorked.Name = "ColumnTotalHoursWorked"
        Me.ColumnTotalHoursWorked.ReadOnly = True
        '
        'ColumnTotalHourlyPay
        '
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.ColumnTotalHourlyPay.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColumnTotalHourlyPay.HeaderText = "Total Hourly Pay"
        Me.ColumnTotalHourlyPay.Name = "ColumnTotalHourlyPay"
        Me.ColumnTotalHourlyPay.ReadOnly = True
        '
        'ColumnHouseAllowance
        '
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.ColumnHouseAllowance.DefaultCellStyle = DataGridViewCellStyle10
        Me.ColumnHouseAllowance.HeaderText = "House Allowance"
        Me.ColumnHouseAllowance.Name = "ColumnHouseAllowance"
        Me.ColumnHouseAllowance.ReadOnly = True
        '
        'ColumnGrossPay
        '
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = "0"
        Me.ColumnGrossPay.DefaultCellStyle = DataGridViewCellStyle11
        Me.ColumnGrossPay.HeaderText = "Gross Pay"
        Me.ColumnGrossPay.Name = "ColumnGrossPay"
        Me.ColumnGrossPay.ReadOnly = True
        '
        'ColumnTotalTax
        '
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = "0"
        Me.ColumnTotalTax.DefaultCellStyle = DataGridViewCellStyle12
        Me.ColumnTotalTax.HeaderText = "Total Tax"
        Me.ColumnTotalTax.Name = "ColumnTotalTax"
        Me.ColumnTotalTax.ReadOnly = True
        '
        'ColumnNetPay
        '
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = "0"
        Me.ColumnNetPay.DefaultCellStyle = DataGridViewCellStyle13
        Me.ColumnNetPay.HeaderText = "Net Pay"
        Me.ColumnNetPay.Name = "ColumnNetPay"
        Me.ColumnNetPay.ReadOnly = True
        '
        'MenuItemDelete
        '
        Me.MenuItemDelete.Name = "MenuItemDelete"
        Me.MenuItemDelete.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemDelete.Text = "Delete"
        '
        'FrmPayrollSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 476)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmPayrollSystem"
        Me.Text = "Payroll System"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPersonalDetails.ResumeLayout(False)
        Me.TabPersonalDetails.PerformLayout()
        CType(Me.DataGridViewHoursWorked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPayrollReport.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPersonalDetails As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewHoursWorked As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboGrade As System.Windows.Forms.ComboBox
    Friend WithEvents CboGender As System.Windows.Forms.ComboBox
    Friend WithEvents TxtLastName As System.Windows.Forms.TextBox
    Friend WithEvents TxtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents TabPayrollReport As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents ColumnBeginPeriod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnEndPeriod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnHoursWorked As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuItemAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents ColumnFirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnLastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnGrade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnGender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTotalHoursWorked As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTotalHourlyPay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnHouseAllowance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnGrossPay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTotalTax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnNetPay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuItemDelete As System.Windows.Forms.ToolStripMenuItem

End Class
