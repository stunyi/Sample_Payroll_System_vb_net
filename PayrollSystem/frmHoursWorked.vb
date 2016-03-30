Public Class frmHoursWorked

    'Constants 
    Private Const NEW_HOURS_WORKED_TITLE As String = "New Hours Worked"
    Private Const UPDATE_HOURS_WORKED_TITLE As String = "Edit Hours Worked"

    Private dateWorkedFrom As Date
    Private dateWorkedTo As Date
    Private hoursWorkedValue As Double
    Private newHoursWorked As Boolean
    Private dataChanged As Boolean
    Private containsData As Boolean = False

    Public Property DateFrom() As Date
        Get
            Return dateWorkedFrom
        End Get
        Set(ByVal value As Date)
            dateWorkedFrom = value
        End Set
    End Property
    Public Property DateTo() As Date
        Get
            Return dateWorkedTo
        End Get
        Set(ByVal value As Date)
            dateWorkedTo = value
        End Set
    End Property
    Public Property HoursWorked() As Double
        Get
            Return hoursWorkedValue
        End Get
        Set(ByVal value As Double)
            hoursWorkedValue = value
        End Set
    End Property
    Public Property isNewHoursWorked() As Boolean
        Get
            Return newHoursWorked
        End Get
        Set(ByVal value As Boolean)
            newHoursWorked = value
        End Set
    End Property
    Public Property HasDataChanged() As Boolean
        Get
            Return dataChanged
        End Get
        Set(ByVal value As Boolean)
            dataChanged = value
        End Set
    End Property
    Public Property HasData() As Boolean
        Get
            Return containsData
        End Get
        Set(ByVal value As Boolean)
            containsData = value
        End Set
    End Property


    Private Sub frmHoursWorked_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If newHoursWorked = False Then
            DtpWorkedFrom.Value = dateWorkedFrom
            DtpWorkedTo.Value = dateWorkedTo
            TxtHoursWorked.Text = hoursWorkedValue
        End If

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        If newHoursWorked Then
            dateWorkedFrom = DtpWorkedFrom.Value
            dateWorkedTo = DtpWorkedTo.Value
            hoursWorkedValue = TxtHoursWorked.Text
        End If

        Me.Close()

    End Sub
End Class