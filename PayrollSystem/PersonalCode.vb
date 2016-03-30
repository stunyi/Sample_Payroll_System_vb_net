Module PersonalCode

    Public Class PersonalDetailsService
        Private conn As OleDb.OleDbConnection
        Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Payroll.accdb"

        Public Sub New()
            conn = New OleDb.OleDbConnection(connectionString)
            conn.Open()
        End Sub

        Public Function getAllPersonalDetails() As IList(Of PersonalDetails)
            Dim tempListOfPersonalDetails As New List(Of PersonalDetails)

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT ID, FirstName, LastName, Grade, Gender From PersonalDetails"
            Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader

            While reader.Read
                'Dim perdonalId As String = reader.GetString(0)
                tempListOfPersonalDetails.Add(New PersonalDetails With {
                                              .PersonID = CULng(reader.GetValue(0)),
                                              .FirstName = reader.GetString(1),
                                              .LastName = reader.GetString(2),
                                              .Gender = getGender(reader.GetString(4)),
                                              .Grade = getGrade(reader.GetString(3)),
                                              .TaxBrackets = getAllTaxBrackets(),
                                              .HoursWorked = getAllHoursWorked(CULng(reader.GetValue(0)))
                                          })
            End While

            Return tempListOfPersonalDetails

        End Function

        Public Function getGender(ByVal gender As String) As Gender

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT Gender, HouseAllowance From Gender Where Gender = '" + gender + "'"

            Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                Dim g As Gender = New Gender()
                g.Gender = reader.GetString(0)
                g.HouseAllowance = reader.GetDouble(1)
                Return g
            End While

            Return Nothing

        End Function

        Public Function getAllGenders() As List(Of Gender)
            Dim genders As New List(Of Gender)

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT Gender, HouseAllowance From Gender"

            Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                Dim g As Gender = New Gender()
                g.Gender = reader.GetString(0)
                g.HouseAllowance = reader.GetDouble(1)
                genders.Add(g)
            End While

            Return genders

        End Function

        Public Function getGrade(ByVal grade As String) As Grade

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT Grade, HourlyRate From Grade Where Grade = '" + grade + "'"

            Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                Dim g As Grade = New Grade()
                g.Grade = reader.GetString(0)
                g.HourlyRate = reader.GetDouble(1)
                Return g
            End While

            Return Nothing

        End Function

        Public Function getGrades() As List(Of Grade)
            Dim grades As New List(Of Grade)

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT Grade, HourlyRate From Grade"

            Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                Dim g As Grade = New Grade()
                g.Grade = reader.GetString(0)
                g.HourlyRate = reader.GetDouble(1)
                grades.Add(g)
            End While

            Return grades

        End Function

        Public Function getAllTaxBrackets() As List(Of TaxBracket)

            Dim tempListOfTaxBrackets As New List(Of TaxBracket)

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT ID, AmountFrom, AmountTo, Rate From TaxBrackets Order by ID"
            Dim reader As OleDb.OleDbDataReader
            reader = cmd.ExecuteReader

            If Not reader Is Nothing Then
                While reader.Read
                    'Dim perdonalId As String = reader.GetString(0)
                    tempListOfTaxBrackets.Add(New TaxBracket With {
                                                  .TaxId = CULng(reader.GetValue(0)),
                                                  .AmountFrom = reader.GetDouble(1),
                                                  .AmountTo = reader.GetDouble(2),
                                                  .TaxRate = reader.GetDouble(3)
                                              })
                End While
            End If
            Return tempListOfTaxBrackets

        End Function

        Public Function getAllHoursWorked(ByVal personId As Long) As List(Of HoursWorked)

            Dim tempListOfHoursWorked As New List(Of HoursWorked)

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT ID, PersonID, DateFrom, DateTo, HoursWorked From HoursWorked Where PersonID = " + CStr(personId)
            Dim reader As OleDb.OleDbDataReader
            reader = cmd.ExecuteReader

            If Not reader Is Nothing Then
                While reader.Read
                    'Dim perdonalId As String = reader.GetString(0)
                    tempListOfHoursWorked.Add(New HoursWorked With {
                                                  .HoursWorkedID = CULng(reader.GetValue(0)),
                                                  .PersonID = CULng(reader.GetValue(1)),
                                                  .DateFrom = reader.GetDateTime(2),
                                                  .DateTo = reader.GetDateTime(3),
                                                  .HoursWorked = reader.GetDouble(4)
                                              })
                End While
            End If

            Return tempListOfHoursWorked

        End Function

        Public Function addNewPersonalDetail(ByVal personalDetail As PersonalDetails) As Boolean

            Dim cmd As New OleDb.OleDbCommand
            Dim result As Boolean = True
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Insert into PersonalDetails (ID, FirstName, LastName, Grade, Gender) values (?,?,?,?,?)"
            cmd.Parameters.AddWithValue("ID", personalDetail.PersonID)
            cmd.Parameters.AddWithValue("FirstName", personalDetail.FirstName)
            cmd.Parameters.AddWithValue("LastName", personalDetail.LastName)
            cmd.Parameters.AddWithValue("Grade", personalDetail.Grade.Grade)
            cmd.Parameters.AddWithValue("Gender", personalDetail.Gender.Gender)

            If cmd.ExecuteNonQuery() > 0 Then
                result = result And True
            End If

            If Not personalDetail.HoursWorked Is Nothing Then
                For Each hoursWorked As HoursWorked In personalDetail.HoursWorked
                    result = result And addPersonsHoursWork(hoursWorked)
                Next
            End If
            
            Return result

        End Function

        Public Function addPersonsHoursWork(ByRef hoursWork As HoursWorked) As Boolean

            Dim result As Boolean = True
            Dim cmdHoursWorked As OleDb.OleDbCommand

            cmdHoursWorked = New OleDb.OleDbCommand
            cmdHoursWorked.Connection = conn
            cmdHoursWorked.CommandText = "Insert into HoursWorked (PersonID, DateFrom, DateTo, HoursWorked) values (?,?,?,?)"
            cmdHoursWorked.Parameters.AddWithValue("PersonID", hoursWork.PersonID)
            cmdHoursWorked.Parameters.AddWithValue("DateFrom", hoursWork.DateFrom.ToString)
            cmdHoursWorked.Parameters.AddWithValue("DateTo", hoursWork.DateTo.ToString)
            cmdHoursWorked.Parameters.AddWithValue("HoursWorked", hoursWork.HoursWorked)

            If cmdHoursWorked.ExecuteNonQuery() > 0 Then
                result = result And True
            End If

            Return result

        End Function

        Public Function updatePersonalDetail(ByVal personalDetail As PersonalDetails) As Boolean

            Dim cmd As New OleDb.OleDbCommand
            Dim result As Boolean = True
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Update PersonalDetails Set FirstName = ?, LastName = ?, Grade = ?, Gender = ? Where ID = ?"
            cmd.Parameters.AddWithValue("FirstName", personalDetail.FirstName)
            cmd.Parameters.AddWithValue("LastName", personalDetail.LastName)
            cmd.Parameters.AddWithValue("Grade", personalDetail.Grade.Grade)
            cmd.Parameters.AddWithValue("Gender", personalDetail.Gender.Gender)
            cmd.Parameters.AddWithValue("ID", personalDetail.PersonID)

            If cmd.ExecuteNonQuery() > 0 Then
                result = result And True
            End If

            If Not personalDetail.HoursWorked Is Nothing Then
                For Each hoursWorked As HoursWorked In personalDetail.HoursWorked
                    result = result And updatePersonsHoursWork(hoursWorked)
                Next
            End If

            Return result

        End Function

        Public Function updatePersonsHoursWork(ByRef hoursWork As HoursWorked) As Boolean

            Dim result As Boolean = True
            Dim cmdHoursWorked As OleDb.OleDbCommand
            Dim cmdDelete As OleDb.OleDbCommand

            cmdHoursWorked = New OleDb.OleDbCommand
            cmdDelete = New OleDb.OleDbCommand

            cmdHoursWorked.Connection = conn
            cmdDelete.Connection = conn

            cmdDelete.CommandText = "Delete From HoursWorked Where PersonID = ? and DateFrom = ? and DateTo = ? and HoursWorked = ?"
            cmdDelete.Parameters.AddWithValue("PersonID", hoursWork.PersonID)
            cmdDelete.Parameters.AddWithValue("DateFrom", hoursWork.DateFrom.ToString)
            cmdDelete.Parameters.AddWithValue("DateTo", hoursWork.DateTo.ToString)
            cmdDelete.Parameters.AddWithValue("HoursWorked", hoursWork.HoursWorked)

            cmdDelete.ExecuteNonQuery()

            cmdHoursWorked.CommandText = "Insert into HoursWorked (PersonID, DateFrom, DateTo, HoursWorked) values (?,?,?,?)"
            cmdHoursWorked.Parameters.AddWithValue("PersonID", hoursWork.PersonID)
            cmdHoursWorked.Parameters.AddWithValue("DateFrom", hoursWork.DateFrom.ToString)
            cmdHoursWorked.Parameters.AddWithValue("DateTo", hoursWork.DateTo.ToString)
            cmdHoursWorked.Parameters.AddWithValue("HoursWorked", hoursWork.HoursWorked)

            If cmdHoursWorked.ExecuteNonQuery() > 0 Then
                result = result And True
            End If

            Return result

        End Function

    End Class

    Public Class PersonalDetails
        Private personIdValue As Long
        Private firstNameValue As String = ""
        Private lastNameValue As String = ""
        Private gradeValue As Grade
        Private genderValue As Gender
        Private hoursWorkedValue As New List(Of HoursWorked)
        Private taxBracketsValue As New List(Of TaxBracket)

        Public Property PersonID() As Long
            Get
                Return personIdValue
            End Get
            Set(ByVal value As Long)
                personIdValue = value
            End Set
        End Property
        Public Property FirstName() As String
            Get
                Return firstNameValue
            End Get
            Set(ByVal value As String)
                firstNameValue = value
            End Set
        End Property
        Public Property LastName() As String
            Get
                Return lastNameValue
            End Get
            Set(ByVal value As String)
                lastNameValue = value
            End Set
        End Property
        Public Property Grade() As Grade
            Get
                Return gradeValue
            End Get
            Set(ByVal value As Grade)
                gradeValue = value
            End Set
        End Property
        Public Property Gender() As Gender
            Get
                Return genderValue
            End Get
            Set(ByVal value As Gender)
                genderValue = value
            End Set
        End Property
        Public Property HoursWorked() As List(Of HoursWorked)
            Get
                Return hoursWorkedValue
            End Get
            Set(ByVal value As List(Of HoursWorked))
                hoursWorkedValue = value
            End Set
        End Property
        Public Property TaxBrackets() As List(Of TaxBracket)
            Get
                Return taxBracketsValue
            End Get
            Set(ByVal value As List(Of TaxBracket))
                taxBracketsValue = value
            End Set
        End Property

        Public Function TotalHoursWorked() As Double

            Dim totalValue As Double = 0

            If Not hoursWorkedValue Is Nothing Then

                For Each hr As HoursWorked In hoursWorkedValue
                    totalValue = totalValue + hr.HoursWorked
                Next

            End If

            Return totalValue

        End Function
        Public Function TotalHourlyPay() As Double
            Dim hourlyAmount As Double = 0
            If Not gradeValue Is Nothing Then
                hourlyAmount = TotalHoursWorked() * gradeValue.HourlyRate
            End If
            Return hourlyAmount
        End Function
        Public Function GrossPay() As Double
            Dim houseAllowance As Double = 0
            Dim hourlyAmount As Double = 0

            If Not gradeValue Is Nothing Then
                hourlyAmount = TotalHoursWorked() * gradeValue.HourlyRate
            End If
            If Not genderValue Is Nothing Then
                houseAllowance = genderValue.HouseAllowance
            End If

            Return houseAllowance + hourlyAmount

        End Function
        Public Function CalculateTax(ByVal amount As Double) As Double

            Dim totalTax As Double = 0

            For Each txBracket As TaxBracket In taxBracketsValue

                If Not txBracket.AmountTo = 0 Then
                    'Calculate Other Tax Brackets
                    If amount > txBracket.AmountFrom And amount <= txBracket.AmountTo Then
                        totalTax = totalTax + ((amount - txBracket.AmountFrom) * txBracket.TaxRate)
                    ElseIf amount > txBracket.AmountTo Then
                        totalTax = totalTax + ((txBracket.AmountTo - txBracket.AmountFrom) * txBracket.TaxRate)
                    End If
                Else
                    'Calculate Last Bracket Separately
                    If amount > txBracket.AmountFrom Then
                        totalTax = totalTax + ((amount - txBracket.AmountFrom) * txBracket.TaxRate)
                    End If
                End If
            Next

            Return totalTax

        End Function
        Public Function NetPay() As Double
            Return GrossPay() - CalculateTax(GrossPay())
        End Function
    End Class

    Public Class Grade
        Private gradeValue As String = ""
        Private hourlyRateValue As Double = 0

        Public Property Grade() As String
            Get
                Return gradeValue
            End Get
            Set(ByVal value As String)
                gradeValue = value
            End Set
        End Property
        Public Property HourlyRate() As String
            Get
                Return hourlyRateValue
            End Get
            Set(ByVal value As String)
                hourlyRateValue = value
            End Set
        End Property

    End Class

    Public Class Gender
        Private genderStringValue As String
        Private houseAllowanceValue As Double

        Public Property Gender() As String
            Get
                Return genderStringValue
            End Get
            Set(ByVal value As String)
                genderStringValue = value
            End Set
        End Property
        Public Property HouseAllowance() As Double
            Get
                Return houseAllowanceValue
            End Get
            Set(ByVal value As Double)
                houseAllowanceValue = value
            End Set
        End Property

    End Class

    Public Class HoursWorked

        Private personIdValue As Long
        Private hoursWorkedIdValue As Long
        Private dtFromValue As Date
        Private dtToValue As Date
        Private hoursWorkedValue As Double

        Public Property PersonID() As Long
            Get
                Return personIdValue
            End Get
            Set(ByVal value As Long)
                personIdValue = value
            End Set
        End Property
        Public Property HoursWorkedID() As Long
            Get
                Return hoursWorkedIdValue
            End Get
            Set(ByVal value As Long)
                hoursWorkedIdValue = value
            End Set
        End Property
        Public Property DateFrom() As Date
            Get
                Return dtFromValue
            End Get
            Set(ByVal value As Date)
                dtFromValue = value
            End Set
        End Property
        Public Property DateTo() As Date
            Get
                Return dtToValue
            End Get
            Set(ByVal value As Date)
                dtToValue = value
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

    End Class

    Public Class TaxBracket
        Private taxIdValue As Long
        Private fromValue As Double
        Private toValue As Double
        Private taxRateValue As Double

        Public Property TaxId() As Long
            Get
                Return taxIdValue
            End Get
            Set(ByVal value As Long)
                taxIdValue = value
            End Set
        End Property
        Public Property AmountFrom() As Double
            Get
                Return fromValue
            End Get
            Set(ByVal value As Double)
                fromValue = value
            End Set
        End Property
        Public Property AmountTo() As Double
            Get
                Return toValue
            End Get
            Set(ByVal value As Double)
                toValue = value
            End Set
        End Property
        Public Property TaxRate() As Double
            Get
                Return taxRateValue
            End Get
            Set(ByVal value As Double)
                taxRateValue = value
            End Set
        End Property

    End Class

End Module
