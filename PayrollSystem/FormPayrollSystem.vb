Public Class FrmPayrollSystem

    Private personalService As PersonalDetailsService
    Private persons As List(Of PersonalDetails)
    Private recordNumber As Integer = 0
    Private isAddNew As Boolean = False
    Private newHoursWorkedObj As List(Of HoursWorked)


    Private Sub FrmPayrollSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        personalService = New PersonalDetailsService()
        persons = personalService.getAllPersonalDetails
        initFormCombos()
        fillForm(0)
        fillPayrollReport(persons)

        MenuItemAdd.Visible = False
        MenuItemDelete.Visible = False

    End Sub

    Sub initFormCombos()
        For Each gender As Gender In personalService.getAllGenders()
            CboGender.Items.Add(gender.Gender)
        Next
        For Each grade As Grade In personalService.getGrades()
            CboGrade.Items.Add(grade.Grade)
        Next
    End Sub
    Sub fillForm()

        If persons.Count > 0 Then
            Dim maxRecord As Integer = (persons.Count - 1)
            For i As Integer = 0 To maxRecord
                fillForm(i)
            Next
            'For Each person As PersonalDetails In persons
            'TxtFirstName.Text = person.FirstName
            'TxtLastName.Text = person.LastName
            'CboGender.Text = person.Gender.Gender
            'CboGrade.Text = person.Grade.Grade
            'Next
        End If

    End Sub
    Sub fillForm(ByVal recordId As Integer)
        If persons.Capacity > 0 Then

            clearForm()

            Dim person As PersonalDetails = persons(recordId)
            TxtFirstName.Text = person.FirstName
            TxtLastName.Text = person.LastName
            CboGender.Text = person.Gender.Gender
            CboGrade.Text = person.Grade.Grade

            fillDataGrid(person.HoursWorked)

        End If
    End Sub
    Private Sub fillDataGrid(ByRef hoursWorked As List(Of HoursWorked))
        For Each hourWorked As HoursWorked In hoursWorked
            fillDataGrid(hourWorked)
        Next
    End Sub
    Private Sub fillDataGrid(ByRef hourWorked As HoursWorked)
        Dim data As New DataGridViewRow()
        data.Cells.Add(New DataGridViewTextBoxCell With {.Value = CStr(hourWorked.DateFrom)})
        data.Cells.Add(New DataGridViewTextBoxCell With {.Value = CStr(hourWorked.DateTo)})
        data.Cells.Add(New DataGridViewTextBoxCell With {.Value = CStr(hourWorked.HoursWorked)})
        DataGridViewHoursWorked.Rows.Add(data)
    End Sub
    Sub clearForm()

        TxtFirstName.Text = ""
        TxtLastName.Text = ""
        CboGender.Text = ""
        CboGrade.Text = ""
        DataGridViewHoursWorked.Rows.Clear()

    End Sub
    Sub addNewRecord()
        clearForm()
        isAddNew = True
    End Sub
    Private Sub fillPayrollReport(ByRef persons As List(Of PersonalDetails))

        'First Clear all the Items in the DataGridView (Payroll Report)
        DataGridView1.Rows.Clear()

        For Each person As PersonalDetails In persons

            Dim gridRow As New DataGridViewRow

            gridRow.Cells.Add(New DataGridViewTextBoxCell With {.Value = person.FirstName})
            gridRow.Cells.Add(New DataGridViewTextBoxCell With {.Value = person.LastName})
            gridRow.Cells.Add(New DataGridViewTextBoxCell With {.Value = person.Grade.Grade})
            gridRow.Cells.Add(New DataGridViewTextBoxCell With {.Value = person.Gender.Gender})
            gridRow.Cells.Add(New DataGridViewTextBoxCell With {.Value = person.TotalHoursWorked})
            gridRow.Cells.Add(New DataGridViewTextBoxCell With {.Value = person.TotalHourlyPay})
            gridRow.Cells.Add(New DataGridViewTextBoxCell With {.Value = person.Gender.HouseAllowance})
            gridRow.Cells.Add(New DataGridViewTextBoxCell With {.Value = person.GrossPay})
            gridRow.Cells.Add(New DataGridViewTextBoxCell With {.Value = person.CalculateTax(person.GrossPay)})
            gridRow.Cells.Add(New DataGridViewTextBoxCell With {.Value = person.NetPay})

            DataGridView1.Rows.Add(gridRow)

        Next
    End Sub
    Private Function copyFieldInfo() As PersonalDetails

        If isAddNew Then

            Dim personalDetail As New PersonalDetails()

            personalDetail.PersonID = persons.Count + 1
            personalDetail.FirstName = TxtFirstName.Text
            personalDetail.LastName = TxtLastName.Text
            personalDetail.Gender = personalService.getGender(CboGender.Text)
            personalDetail.Grade = personalService.getGrade(CboGrade.Text)
            personalDetail.TaxBrackets = personalService.getAllTaxBrackets()

            personalDetail.HoursWorked = newHoursWorkedObj

            Return personalDetail

        Else

            Dim personalDetail As PersonalDetails

            personalDetail = persons.Item(recordNumber)
            personalDetail.FirstName = TxtFirstName.Text
            personalDetail.LastName = TxtLastName.Text
            personalDetail.Gender = personalService.getGender(CboGender.Text)
            personalDetail.Grade = personalService.getGrade(CboGrade.Text)
            personalDetail.TaxBrackets = personalService.getAllTaxBrackets()

            'personalDetail.HoursWorked.AddRange(newHoursWorkedObj)

            Return personalDetail

        End If



    End Function

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        If recordNumber > 0 Then
            recordNumber = recordNumber - 1
            fillForm(recordNumber)
        End If
    End Sub
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If recordNumber < (persons.Count - 1) Then
            recordNumber = recordNumber + 1
            fillForm(recordNumber)
        End If
    End Sub
    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click

        addNewRecord()

        BtnAddNew.Visible = False
        BtnNext.Visible = False
        BtnPrevious.Visible = False
        BtnEdit.Visible = False
        MenuItemAdd.Visible = True
        MenuItemDelete.Visible = True

    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        If isAddNew Then

            Dim person As PersonalDetails

            person = copyFieldInfo()
            personalService.addNewPersonalDetail(person)
            persons.Add(person)

            newHoursWorkedObj = Nothing

            BtnEdit.Visible = True
            BtnAddNew.Visible = True
            BtnNext.Visible = True
            BtnPrevious.Visible = True
            MenuItemAdd.Visible = False
            MenuItemDelete.Visible = False

            isAddNew = False

        Else

            Dim person As PersonalDetails

            person = copyFieldInfo()

            personalService.updatePersonalDetail(person)

            newHoursWorkedObj = Nothing

            BtnEdit.Visible = True
            BtnAddNew.Visible = True
            BtnNext.Visible = True
            BtnPrevious.Visible = True

            MenuItemDelete.Visible = False
            MenuItemAdd.Visible = False

        End If

        fillPayrollReport(persons)

    End Sub
    Private Sub MenuItemAdd_Click(sender As Object, e As EventArgs) Handles MenuItemAdd.Click

        Dim form As New frmHoursWorked With {.isNewHoursWorked = True}
        form.ShowDialog()

        If isAddNew Then

            Dim hoursWorked As New HoursWorked

            If newHoursWorkedObj Is Nothing Then
                newHoursWorkedObj = New List(Of HoursWorked)
            End If

            hoursWorked.PersonID = persons.Count + 1
            hoursWorked.DateFrom = form.DateFrom
            hoursWorked.DateTo = form.DateTo
            hoursWorked.HoursWorked = form.HoursWorked

            newHoursWorkedObj.Add(hoursWorked)
            fillDataGrid(hoursWorked)

        Else

            Dim hoursWorked As New HoursWorked

            If newHoursWorkedObj Is Nothing Then
                newHoursWorkedObj = New List(Of HoursWorked)
            End If

            hoursWorked.PersonID = persons.Item(recordNumber).PersonID
            hoursWorked.DateFrom = form.DateFrom
            hoursWorked.DateTo = form.DateTo
            hoursWorked.HoursWorked = form.HoursWorked
            newHoursWorkedObj.Add(hoursWorked)
            persons.Item(recordNumber).HoursWorked.Add(hoursWorked)
            fillDataGrid(hoursWorked)

        End If
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        BtnAddNew.Visible = False
        BtnNext.Visible = False
        BtnPrevious.Visible = False
        BtnEdit.Visible = False

        MenuItemAdd.Visible = True
        MenuItemDelete.Visible = True

        isAddNew = False

    End Sub
    Private Sub MenuItemDelete_Click(sender As Object, e As EventArgs) Handles MenuItemDelete.Click
        If DataGridViewHoursWorked.SelectedRows.Count > 0 And Not isAddNew Then
            For Each row As DataGridViewRow In DataGridViewHoursWorked.SelectedRows
                Dim personalDetail As PersonalDetails
                personalDetail = persons.Item(recordNumber)
                If personalDetail.HoursWorked Is Nothing Then
                    personalDetail.HoursWorked.RemoveAt(row.Cells(0).RowIndex)
                End If
                fillForm(recordNumber)
            Next    
        End If
    End Sub

End Class
