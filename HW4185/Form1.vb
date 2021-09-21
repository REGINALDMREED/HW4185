
Public Class FrmExercise
    Private txtFirstName As Object

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare and initialize the variables
        Dim intDaysYear As Integer = 365
        Dim intDaysMonth As Integer = 30
        Dim intExercise As Integer = 3
        Dim strFirstName As String = ""
        'Declare the variables to get birth date
        Dim intBDDate As Integer
        Dim intBDMonth As Integer
        Dim intBDYear As Integer
        'Declare the variables to get current date
        Dim intCDDate As Integer
        Dim intCDMonth As Integer
        Dim intCDYear As Integer
        'Declare variables for calculations
        Dim intBD_Days, intCD_Days, intTotalDays, intWorkoutHours As Integer

        'Check if all the text boxes are filled
        If txtBDDay.Text = "" Or txtBDMonth.Text = "" Or txtBDYear.Text = "" Or txtCDDay.Text = "" Or
                txtCDMonth.Text = "" Or txtCDYear.Text = "" Or txtFirstName.Text = "" Then
            'Print the error messages
            MsgBox("Fill all the textboxes",, "Input Error")
        Else
            'Get the firstName from user
            strFirstName = txtFirstName.Text
            'Check if day is greater than 0 and less than or equal to 30
            If txtBDDay.Text < 0 Or txtBDDay.Text > 30 Then
                'Print the error message in the message box
                MsgBox("Enter valid date",, 64, "Input Error")
            Else
                'Get the birthdate from user
                intBDDate = txtBDDay.Text
            End If
            'Check if birth month is greater than 0 and less than or  equal to 12
            If txtBDMonth.Text < 0 Or txtBDMonth.Text > 12 Then
                'Print the error message in the message Box
                MsgBox("Enter valid month", 64, "Input Error")
            Else
                'Get the birth Month from user
                intBDMonth = txtBDMonth.Text

            End If
            'Get birth year from user
            intBDMonth = txtBDMonth.Text
        End If
        'Get birth year from user
        intBDYear = txtBDYear.Text
        'Check if day is greater than 0 and less 'than or equal to 30
        If txtCDDay.Text < 0 And txtCDDay.Text > 30 Then
            'Print the error message in the message box
            MsgBox("Enter valid date", 64, "Input Error")
        Else
            'Get the current date from user
            intCDDate = txtCDDay.Text
        End If
        'Check if current month is greater than 0 'and less than or equal to 12
        If txtCDMonth.Text < 0 Or txtCDMonth.Text > 12 Then
            'Print the error message in the message box
            MsgBox("Enter valid month", 64, "Input Error")
        Else
            'Get the current month from user
            intCDMonth = txtCDMonth.Text
        End If
        'Get current year from the user
        intCDYear = txtCDYear.Text
        'Calculate days
        intCD_Days = (intCDYear * 365) + (intBDMonth * 30) + intCDDate
        'Calculate total days
        intTotalDays = intCD_Days - intBD_Days
        'calculate workout hours
        intWorkoutHours = intTotalDays * 3
        'Display the name in total
        lblDisplayName.Text = strFirstName
        'Display the hours in the label
        lblDisplayHours.Text = intWorkoutHours & "hours"
        'Close the application'
        Me.Close()
    End Sub

    Private Sub MsgBox(v1 As String, Optional p As Object = Nothing, Optional v2 As Integer = Nothing, Optional v3 As String = Nothing)
        Throw New NotImplementedException()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear the textboxes
        txtBDDay.Clear()
        txtBDMonth.Clear()
        txtBDYear.Clear()
        txtCDDay.Clear()
        txtCDMonth.Clear()
        txtCDYear.Clear()
        Dim txtFirstName As Object = Nothing
        txtFirstName.Clear()
        'Clear the labels
        lblDisplayHours.Text = ""
        lblDisplayName.Text = ""
    End Sub


End Class
