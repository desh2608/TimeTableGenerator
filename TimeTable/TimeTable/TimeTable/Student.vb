Public Class Student
    'when page is loaded , a greeting message is shown
    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStud.Text = "Time Table for Roll: " + Form1.roll.ToString
        Me.WindowState = FormWindowState.Maximized
    End Sub
    'when date is changed it sets the value of the labels from the class admin
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim dateVal As Date = MonthCalendar1.SelectionRange.Start
        Dim day As Integer = dateVal.DayOfWeek

        Select Case day
            Case 1
                tbDay.Text = "MONDAY"
                tut1.Text = Admin.tutorial(0)
                tut2.Text = Admin.tutorial(1)
                lec1.Text = Admin.lecture(0)
                lec2.Text = Admin.lecture(1)
                lec3.Text = Admin.lecture(2)
                lab.Text = Admin.labs(0)

            Case 2
                tbDay.Text = "TUESDAY"
                tut1.Text = Admin.tutorial(2)
                tut2.Text = Admin.tutorial(3)
                lec1.Text = Admin.lecture(3)
                lec2.Text = Admin.lecture(4)
                lec3.Text = Admin.lecture(5)
                lab.Text = Admin.labs(1)

            Case 3
                tbDay.Text = "WEDNESDAY"
                tut1.Text = Admin.tutorial(4)
                tut2.Text = Admin.tutorial(5)
                lec1.Text = Admin.lecture(6)
                lec2.Text = Admin.lecture(7)
                lec3.Text = Admin.lecture(8)
                lab.Text = Admin.labs(2)

            Case 4
                tbDay.Text = "THURSDAY"
                tut1.Text = Admin.tutorial(6)
                tut2.Text = Admin.tutorial(7)
                lec1.Text = Admin.lecture(9)
                lec2.Text = Admin.lecture(10)
                lec3.Text = Admin.lecture(11)
                lab.Text = Admin.labs(3)

            Case 5
                tbDay.Text = "FRIDAY"
                tut1.Text = Admin.tutorial(8)
                tut2.Text = Admin.tutorial(9)
                lec1.Text = Admin.lecture(12)
                lec2.Text = Admin.lecture(13)
                lec3.Text = Admin.lecture(14)
                lab.Text = Admin.labs(4)

            Case 6 'it just checks the case for holidays
                tbDay.Text = "SATURDAY"
                tut1.Text = ""
                tut2.Text = ""
                lec1.Text = ""
                lec2.Text = ""
                lec3.Text = ""
                lab.Text = ""
            Case 0 'it just checks the case for holidays
                tbDay.Text = "SUNDAY"
                tut1.Text = ""
                tut2.Text = ""
                lec1.Text = ""
                lec2.Text = ""
                lec3.Text = ""
                lab.Text = ""
        End Select
    End Sub
    'it will generate the table form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Table.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class