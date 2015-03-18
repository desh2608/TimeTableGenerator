Imports System.IO
Imports System.String

Public Class Admin
    Public lecture(15) As String 'defined globally because it has been used in another class
    Public tutorial(10) As String
    Public labs(5) As String
    Public rollMax, rollMin As Integer
    Public checkAvailable As Boolean = False
    Private facUN As String
    Private facPass As String
    Private Shared _lecture As Object
    'If either name of faculty is blank or length of name is less than 3 characters no username and password remain blank
    Private Sub btnGenFaculty_Click(sender As Object, e As EventArgs) Handles btnGenFaculty.Click
        If tbAddFaculty.Text = "" Or tbAddFaculty.Text.ToString.Length < 3 Then
            lblFacUN.Text = "Username:"
            lblFacPass.Text = "Password:"
            facUN = ""
            facPass = ""
        Else
            facUN = tbAddFaculty.Text.ToString().ToLower().Substring(0, 3) 'tanking first 3 characters from the name to use in username
            Dim randomValue As Integer 'adding 4 random digits to username
            randomValue = CInt(Math.Floor((9999 - 1000 + 1) * Rnd())) + 1000
            facUN = facUN + "" + randomValue.ToString
            facPass = GenerateRandomString(6, False) 'function is called to generate random password
            lblFacUN.Text = "Username: " + facUN
            lblFacPass.Text = "Password: " + facPass
        End If
    End Sub
    'function will generate a random password
    Public Function GenerateRandomString(ByRef len As Integer, ByRef upper As Boolean) As String
        Dim rand As New Random()
        Dim allowableChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim final As String = String.Empty
        For i As Integer = 0 To len - 1
            final += allowableChars(rand.Next(allowableChars.Length - 1))
        Next

        Return IIf(upper, final.ToUpper(), final)
    End Function
    'takes the user to home page
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub
    'it takes care if empty login name and password are generated
    Private Sub btnSaveFaculty_Click(sender As Object, e As EventArgs) Handles btnSaveFaculty.Click
        If facUN.Equals("") Or facPass.Equals("") Then
            MsgBox("Please generate a Username and Password first.", MsgBoxStyle.Critical, "Information")
        Else
            My.Computer.FileSystem.WriteAllText("facAuth.dat", tbAddFaculty.Text + "," + facUN + "," + facPass + vbNewLine, True)
            MsgBox("Username and Password saved successfully.", MsgBoxStyle.Information, "Information")
        End If
    End Sub
    'to add a room and check if it is already added
    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        Dim room As String = tbAddRoom.Text.ToString()
        Dim check As Boolean = False
        Try
            Dim file As New System.IO.StreamReader("roomList.dat")
            Dim oneLine As String
            oneLine = file.ReadLine()
            While (oneLine <> "")
                If oneLine.Equals(room) Then 'to check if room has already been added it turns check to true
                    MsgBox("The room you are trying to add already exists.", MsgBoxStyle.Information, "Information")
                    tbAddRoom.Text = ""
                    check = True
                    Exit While
                End If
                oneLine = file.ReadLine()
            End While
            file.Close()
        Catch ex As Exception
            Console.Write(ex)
        Finally
            If check = False Then 'if room is freshly added then write it to file
                My.Computer.FileSystem.WriteAllText("roomList.dat", room + vbNewLine, True)
                MsgBox("Room added successfully.", MsgBoxStyle.Information, "Information")
                tbAddRoom.Text = ""
            End If
        End Try
    End Sub
    ' for simplicity max roll no. is copied from min roll no. so that user can cahnge only last few digits
    Private Sub tbRollMin_Leave(sender As Object, e As EventArgs) Handles tbRollMin.Leave
        If Not (tbRollMin.Text.ToString.Length() = 0) Then
            tbRollMax.Text = Convert.ToInt32(tbRollMin.Text).ToString
        End If
        tbRollMax.Focus()
    End Sub

    'this function checks that only integers are taken as input in the text box
    Private Sub tbRollMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbRollMin.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then
            If tbRollMin.Text.Length > 0 Then
                tbRollMin.Text = tbRollMin.Text.Substring(0, tbRollMin.TextLength - 1)
                tbRollMin.SelectionStart = tbRollMin.Text.Length
            End If
        ElseIf (Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "."))) Then
            e.Handled = True
        End If
    End Sub
    'this function checks that only integers are taken as input in the text box
    Private Sub tbRollMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbRollMax.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then
            If tbRollMax.Text.Length > 0 Then
                tbRollMax.Text = tbRollMax.Text.Substring(0, tbRollMax.TextLength - 1)
                tbRollMax.SelectionStart = tbRollMax.Text.Length
            End If
        ElseIf (Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "."))) Then
            e.Handled = True
        End If

        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then
            btnGenTimeT.PerformClick()
        End If
    End Sub

    Private Sub btnGenTimeT_Click(sender As Object, e As EventArgs) Handles btnGenTimeT.Click
        If tbRollMax.Text = "" Or tbRollMin.Text = "" Then 'to check the condition of empty input
            MsgBox("Please enter a range of Roll nos.", MsgBoxStyle.Information, "Information")
        Else
            rollMax = Convert.ToInt32(tbRollMax.Text)
            rollMin = Convert.ToInt32(tbRollMin.Text)
            If rollMin > rollMax Then 'to check the condition of invalid input
                MsgBox("Please enter a valid range of Roll Nos.", MsgBoxStyle.Information, "Information")
            Else
                Dim roll_file As StreamWriter = New StreamWriter("rolls.dat")
                roll_file.WriteLine(rollMin.ToString + "," + rollMax.ToString)
                roll_file.Close()
                generateTimeTable()
            End If
        End If
    End Sub
    'this function will generate time table for the roll numbers specified and the courses present in the text file
    Public Sub generateTimeTable()
        For i = 0 To 14
            lecture(i) = ""
        Next
        For i = 0 To 9
            tutorial(i) = ""
        Next
        For i = 0 To 4
            labs(i) = ""
        Next
        Try
            Dim sum_lec As Integer = 0 'these variables will check if extra courses are selected
            Dim sum_tut As Integer = 0
            Dim sum_lab As Integer = 0
            Dim file As New System.IO.StreamReader("courses.dat")
            Dim oneLine As String
            oneLine = file.ReadLine()
            While (oneLine <> "")
                Dim course() As String = oneLine.Split(",".ToCharArray)
                Dim courseno As String
                Dim lec As String
                Dim tut As String
                Dim lab As String
                courseno = course(0).Trim
                lec = course(1).Trim
                tut = course(2).Trim
                lab = course(3).Trim
                For a = 0 To lec.Length - 1
                    sum_lec += Convert.ToInt16(lec.Chars(a)) - 48 'subtracting the ascii value of 0 from the sum each time
                Next
                For a = 0 To tut.Length - 1
                    sum_tut += Convert.ToInt16(tut.Chars(a)) - 48 'subtracting the ascii value of 0 from the sum each time
                Next
                For a = 0 To lab.Length - 1
                    sum_lab += Convert.ToInt16(lab.Chars(a)) - 48 'subtracting the ascii value of 0 from the sum each time
                Next
                If sum_lec > 15 Then
                    MsgBox("Total lecture slots required are more than available slots. Please remove some to continue.", MsgBoxStyle.Critical, "Error")
                    Exit Try
                ElseIf sum_tut > 10 Then
                    MsgBox("Total tutorial slots required are more than available slots. Please remove some to continue.", MsgBoxStyle.Critical, "Error")
                    Exit Try
                ElseIf sum_lab > 5 Then
                    MsgBox("Total lab slots required are more than available slots. Please remove some to continue.", MsgBoxStyle.Critical, "Error")
                    Exit Try
                Else
                    lecture = optimizeLecSlots(coureSlot(lecture, lec, courseno))
                    tutorial = coureSlot(tutorial, tut, courseno)
                    labs = coureSlot(labs, lab, courseno)
                    oneLine = file.ReadLine()
                End If
            End While
            file.Close()
        Catch ex As Exception
            Console.Write(ex)
        Finally
            Table.Show()
            Me.Hide()
        End Try
    End Sub

    Public rand As New Random()
    Public Function coureSlot(ByRef div As String(), ByRef code As String, ByRef courseno As String) As String()
        Dim file As New System.IO.StreamReader("roomList.dat")
        Dim oneLine As String
        Dim count As Integer = 0 'this variable will count the number of rooms in the text file
        oneLine = file.ReadLine()
        While (oneLine <> Nothing)
            count += 1
            oneLine = file.ReadLine()
        End While
        Dim index As Integer = rand.Next(-1, count) 'it will generate a random no. between 0 and count
        file.Close()
        file = New System.IO.StreamReader("roomList.dat")
        oneLine = file.ReadLine()
        Dim i = 0
        While (i < index)
            i += 1
            oneLine = file.ReadLine()
        End While
        Dim room As String = oneLine
        Dim slot As String() = div
        Dim len As Integer = code.Length()
        For i = 0 To len - 1
            If code.Chars(i).ToString.Equals("0") Then
                Continue For
            Else
                Dim j As Integer = i
                While Not IsNullOrEmpty(slot(j)) 'it checks if our parent array is having 0 so it will replace it by 1
                    j += 1
                    If j = len Then
                        j = 0
                    End If
                End While
                If code.Length = 10 Or code.Length = 15 Then
                    slot(j) = courseno + " in " + room
                Else
                    slot(j) = courseno + " Lab"
                End If
            End If
        Next
        Return slot
    End Function
    'this function will see if a middle slot is free in the lectures ,if found free it will shift the previos slot to this one
    Public Function optimizeLecSlots(ByRef div As String()) As String()
        Dim slot As String() = div
        Dim length As Integer = div.Length()
        For a = 2 To 14 Step 3
            If slot(a).Equals("") And Not IsNullOrEmpty(slot(a - 1)) And Not IsNullOrEmpty(slot(a + 1)) Then
                slot(a) = slot(a - 1)
                slot(a - 1) = String.Empty
            End If
        Next
        Return slot
    End Function

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Shown
        Me.WindowState = FormWindowState.Maximized
        tbAddRoom.Text = ""
        tbAddFaculty.Text = ""
        tbRollMax.Text = ""
        tbRollMin.Text = ""
    End Sub

    Private Sub tbAddRoom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbAddRoom.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then
            btnAddRoom.PerformClick()
        End If
    End Sub

    Private Sub tbAddFaculty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbAddFaculty.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then
            btnGenFaculty.PerformClick()
        End If
    End Sub

    Private Sub tbAddRoom_Leave(sender As Object, e As EventArgs) Handles tbAddRoom.Leave
        tbAddFaculty.Focus()
    End Sub

    Private Sub tbAddFaculty_Leave(sender As Object, e As EventArgs) Handles tbAddFaculty.Leave
        tbRollMin.Focus()
    End Sub
End Class

