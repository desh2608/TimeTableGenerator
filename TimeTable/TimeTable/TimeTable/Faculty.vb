Public Class Faculty

    Dim no_of_lec As Integer
    Dim no_of_tut As Integer

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Dim val As Integer = NumericUpDown1.Value
        no_of_lec = val
        If val = 0 Then 'if no. of lectures selected is 0 then all boxes will be disabled and unchecked
            chklm1.Checked = False
            chklm2.Checked = False
            chklm3.Checked = False
            chklt1.Checked = False
            chklt2.Checked = False
            chklt3.Checked = False
            chklw1.Checked = False
            chklw2.Checked = False
            chklw3.Checked = False
            chklth1.Checked = False
            chklth2.Checked = False
            chklth3.Checked = False
            chklf1.Checked = False
            chklf2.Checked = False
            chklf3.Checked = False
            chklm1.Enabled = False
            chklm2.Enabled = False
            chklm3.Enabled = False
            chklt1.Enabled = False
            chklt2.Enabled = False
            chklt3.Enabled = False
            chklw1.Enabled = False
            chklw2.Enabled = False
            chklw3.Enabled = False
            chklth1.Enabled = False
            chklth2.Enabled = False
            chklth3.Enabled = False
            chklf1.Enabled = False
            chklf2.Enabled = False
            chklf3.Enabled = False
        ElseIf val = 1 Or val = 2 Or val = 3 Or val = 4 Then 'if no. of lectures selected is not 0 then all boxes will be enabled
            chklm1.Checked = False
            chklm2.Checked = False
            chklm3.Checked = False
            chklt1.Checked = False
            chklt2.Checked = False
            chklt3.Checked = False
            chklw1.Checked = False
            chklw2.Checked = False
            chklw3.Checked = False
            chklth1.Checked = False
            chklth2.Checked = False
            chklth3.Checked = False
            chklf1.Checked = False
            chklf2.Checked = False
            chklf3.Checked = False
            chklm1.Enabled = True
            chklm2.Enabled = True
            chklm3.Enabled = True
            chklt1.Enabled = True
            chklt2.Enabled = True
            chklt3.Enabled = True
            chklw1.Enabled = True
            chklw2.Enabled = True
            chklw3.Enabled = True
            chklth1.Enabled = True
            chklth2.Enabled = True
            chklth3.Enabled = True
            chklf1.Enabled = True
            chklf2.Enabled = True
            chklf3.Enabled = True
        End If
    End Sub
    'for monday lecture 1 slot
    Private Sub chklm1_CheckedChanged(sender As Object, e As EventArgs) Handles chklm1.CheckedChanged
        If chklm1.Checked = True Then
            If no_of_lec = 0 Then 'if no of lectures is 0 then it will get unchecked and it will be displayed 
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklm1.Checked = False
                no_of_lec -= 1
            Else
                no_of_lec -= 1 'if one lecture of the day is selected ,another can't be selected
                chklm2.Enabled = False
                chklm3.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklm2.Enabled = True
            chklm3.Enabled = True
        End If
    End Sub
    'for monday lecture 2 slot
    Private Sub chklm2_CheckedChanged(sender As Object, e As EventArgs) Handles chklm2.CheckedChanged
        If chklm2.Checked = True Then
            If no_of_lec = 0 Then 'if no of lectures is 0 then it will get unchecked and it will be displayed 
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklm2.Checked = False
                no_of_lec -= 1
            Else
                no_of_lec -= 1
                chklm1.Enabled = False
                chklm3.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklm1.Enabled = True
            chklm3.Enabled = True
        End If
    End Sub
    'for monday lecture 3 slot
    Private Sub chklm3_CheckedChanged(sender As Object, e As EventArgs) Handles chklm3.CheckedChanged
        If chklm3.Checked = True Then
            If no_of_lec = 0 Then
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklm3.Checked = False
                no_of_lec -= 1
            Else
                no_of_lec -= 1
                chklm2.Enabled = False
                chklm1.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklm2.Enabled = True
            chklm1.Enabled = True
        End If
    End Sub
    'for tuesday lecture 1 slot
    Private Sub chklt1_CheckedChanged(sender As Object, e As EventArgs) Handles chklt1.CheckedChanged
        If chklt1.Checked = True Then
            If no_of_lec = 0 Then
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklt1.Checked = False
                no_of_lec -= 1
            Else
                no_of_lec -= 1
                chklt2.Enabled = False
                chklt3.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklt2.Enabled = True
            chklt3.Enabled = True
        End If
    End Sub
    'for tuesday lecture 2 slot
    Private Sub chklt2_CheckedChanged(sender As Object, e As EventArgs) Handles chklt2.CheckedChanged
        If chklt2.Checked = True Then
            If no_of_lec = 0 Then
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklt2.Checked = False
                no_of_lec -= 1
            Else
                no_of_lec -= 1
                chklt1.Enabled = False
                chklt3.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklt1.Enabled = True
            chklt3.Enabled = True
        End If
    End Sub
    'for tuesday lecture 3 slot
    Private Sub chklt3_CheckedChanged(sender As Object, e As EventArgs) Handles chklt3.CheckedChanged
        If chklt3.Checked = True Then
            If no_of_lec = 0 Then
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklt3.Checked = False
                no_of_lec -= 1
            Else
                no_of_lec -= 1
                chklt2.Enabled = False
                chklt1.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklt2.Enabled = True
            chklt1.Enabled = True
        End If
    End Sub
    'for wednesday lecture 1 slot
    Private Sub chklw1_CheckedChanged(sender As Object, e As EventArgs) Handles chklw1.CheckedChanged
        If chklw1.Checked = True Then
            If no_of_lec = 0 Then
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklw1.Checked = False
                no_of_lec -= 1
            Else
                no_of_lec -= 1
                chklw2.Enabled = False
                chklw3.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklw2.Enabled = True
            chklw3.Enabled = True
        End If
    End Sub
    'for wednesday lecture 2 slot
    Private Sub chklw2_CheckedChanged(sender As Object, e As EventArgs) Handles chklw2.CheckedChanged
        If chklw2.Checked = True Then
            If no_of_lec = 0 Then
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklw2.Checked = False
                no_of_lec -= 1
            Else
                no_of_lec -= 1
                chklw1.Enabled = False
                chklw3.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklw1.Enabled = True
            chklw3.Enabled = True
        End If
    End Sub
    'for wednesday lecture 3 slot
    Private Sub chklw3_CheckedChanged(sender As Object, e As EventArgs) Handles chklw3.CheckedChanged
        If chklw3.Checked = True Then
            If no_of_lec = 0 Then
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklw3.Checked = False
                no_of_lec -= 1
            Else
                no_of_lec -= 1
                chklw2.Enabled = False
                chklw1.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklw2.Enabled = True
            chklw1.Enabled = True
        End If
    End Sub

    Private Sub chklth1_CheckedChanged(sender As Object, e As EventArgs) Handles chklth1.CheckedChanged
        If chklth1.Checked = True Then
            If no_of_lec = 0 Then
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklth1.Checked = False
                no_of_lec -= 1
            Else
                no_of_lec -= 1
                chklth2.Enabled = False
                chklth3.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklth2.Enabled = True
            chklth3.Enabled = True
        End If
    End Sub

    Private Sub chklth2_CheckedChanged(sender As Object, e As EventArgs) Handles chklth2.CheckedChanged
        If chklth2.Checked = True Then
            If no_of_lec = 0 Then
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklth2.Checked = False
                no_of_lec -= 1
            Else
                no_of_lec -= 1
                chklth1.Enabled = False
                chklth3.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklth1.Enabled = True
            chklth3.Enabled = True
        End If
    End Sub

  

    Private Sub chklf1_CheckedChanged(sender As Object, e As EventArgs) Handles chklf1.CheckedChanged
        If chklf1.Checked = True Then
            If no_of_lec = 0 Then
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklf1.Checked = False
                no_of_lec -= 1
            Else
                no_of_lec -= 1
                chklf2.Enabled = False
                chklf3.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklf2.Enabled = True
            chklf3.Enabled = True
        End If
    End Sub

    Private Sub chklf2_CheckedChanged(sender As Object, e As EventArgs) Handles chklf2.CheckedChanged
        If chklf2.Checked = True Then
            If no_of_lec = 0 Then
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklf2.Checked = False
                no_of_lec -= 1
            Else
                no_of_lec -= 1
                chklf1.Enabled = False
                chklf3.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklf1.Enabled = True
            chklf3.Enabled = True
        End If
    End Sub

    Private Sub chklf3_CheckedChanged(sender As Object, e As EventArgs) Handles chklf3.CheckedChanged
        If chklf3.Checked = True Then
            If no_of_lec = 0 Then
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklf3.Checked = False
                no_of_lec -= 1
            Else
                no_of_lec -= 1
                chklf2.Enabled = False
                chklf1.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklf2.Enabled = True
            chklf1.Enabled = True
        End If
    End Sub

    
    Private Sub chklth3_CheckedChanged(sender As Object, e As EventArgs) Handles chklth3.CheckedChanged
        If chklth3.Checked = True Then
            If no_of_lec = 0 Then
                MsgBox("You have already selected maximum no. of lecture slots.", MsgBoxStyle.Information, "Information")
                chklth3.Checked = False
            Else
                no_of_lec -= 1
                chklth2.Enabled = False
                chklth1.Enabled = False
            End If
        Else
            no_of_lec += 1
            chklth2.Enabled = True
            chklth1.Enabled = True
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        Dim val As Integer = NumericUpDown2.Value()
        no_of_tut = val
        If val = 0 Then 'if no. of tutorials selected is 0 then all boxes will be disabled and unchecked
            chkTutm1.Checked = False
            chkTutm2.Checked = False
            chkTutt1.Checked = False
            chkTutt2.Checked = False
            chkTutw1.Checked = False
            chkTutw2.Checked = False
            chkTutth1.Checked = False
            chkTutth2.Checked = False
            chkTutf1.Checked = False
            chkTutf2.Checked = False
            chkTutm1.Enabled = False
            chkTutm2.Enabled = False
            chkTutt1.Enabled = False
            chkTutt2.Enabled = False
            chkTutw1.Enabled = False
            chkTutw2.Enabled = False
            chkTutth1.Enabled = False
            chkTutth2.Enabled = False
            chkTutf1.Enabled = False
            chkTutf2.Enabled = False
        ElseIf val = 1 Or val = 2 Then 'if no. of tutorials selected is not 0 then all boxes will be enabled
            chkTutm1.Checked = False
            chkTutm2.Checked = False
            chkTutt1.Checked = False
            chkTutt2.Checked = False
            chkTutw1.Checked = False
            chkTutw2.Checked = False
            chkTutth1.Checked = False
            chkTutth2.Checked = False
            chkTutf1.Checked = False
            chkTutf2.Checked = False
            chkTutm1.Enabled = True
            chkTutm2.Enabled = True
            chkTutt1.Enabled = True
            chkTutt2.Enabled = True
            chkTutw1.Enabled = True
            chkTutw2.Enabled = True
            chkTutth1.Enabled = True
            chkTutth2.Enabled = True
            chkTutf1.Enabled = True
            chkTutf2.Enabled = True
        End If
    End Sub

    Private Sub chkTutm1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTutm1.CheckedChanged
        If chkTutm1.Checked = True Then
            If no_of_tut = 0 Then
                MsgBox("You have already selected maximum no. of tutorial slots.", MsgBoxStyle.Information, "Information")
                chkTutm1.Checked = False
                no_of_tut -= 1
            Else
                no_of_tut -= 1
                chkTutm2.Enabled = False
            End If
        Else
            no_of_tut += 1
            chkTutm2.Enabled = True
        End If
    End Sub

    Private Sub chkTutm2_CheckedChanged(sender As Object, e As EventArgs) Handles chkTutm2.CheckedChanged
        If chkTutm2.Checked = True Then
            If no_of_tut = 0 Then
                MsgBox("You have already selected maximum no. of tutorial slots.", MsgBoxStyle.Information, "Information")
                chkTutm2.Checked = False
                no_of_tut -= 1
            Else
                no_of_tut -= 1
                chkTutm1.Enabled = False
            End If
        Else
            no_of_tut += 1
            chkTutm1.Enabled = True
        End If
    End Sub

    Private Sub chkTutt1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTutt1.CheckedChanged
        If chkTutt1.Checked = True Then
            If no_of_tut = 0 Then
                MsgBox("You have already selected maximum no. of tutorial slots.", MsgBoxStyle.Information, "Information")
                chkTutt1.Checked = False
                no_of_tut -= 1
            Else
                no_of_tut -= 1
                chkTutt2.Enabled = False
            End If
        Else
            no_of_tut += 1
            chkTutt2.Enabled = True
        End If
    End Sub

    Private Sub chkTutt2_CheckedChanged(sender As Object, e As EventArgs) Handles chkTutt2.CheckedChanged
        If chkTutt2.Checked = True Then
            If no_of_tut = 0 Then
                MsgBox("You have already selected maximum no. of tutorial slots.", MsgBoxStyle.Information, "Information")
                chkTutt2.Checked = False
                no_of_tut -= 1
            Else
                no_of_tut -= 1
                chkTutt1.Enabled = False
            End If
        Else
            no_of_tut += 1
            chkTutt1.Enabled = True
        End If
    End Sub

    Private Sub chkTutw1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTutw1.CheckedChanged
        If chkTutw1.Checked = True Then
            If no_of_tut = 0 Then
                MsgBox("You have already selected maximum no. of tutorial slots.", MsgBoxStyle.Information, "Information")
                chkTutw1.Checked = False
                no_of_tut -= 1
            Else
                no_of_tut -= 1
                chkTutw2.Enabled = False
            End If
        Else
            no_of_tut += 1
            chkTutw2.Enabled = True
        End If
    End Sub

    Private Sub chkTutw2_CheckedChanged(sender As Object, e As EventArgs) Handles chkTutw2.CheckedChanged
        If chkTutw2.Checked = True Then
            If no_of_tut = 0 Then
                MsgBox("You have already selected maximum no. of tutorial slots.", MsgBoxStyle.Information, "Information")
                chkTutw2.Checked = False
                no_of_tut -= 1
            Else
                no_of_tut -= 1
                chkTutw1.Enabled = False
            End If
        Else
            no_of_tut += 1
            chkTutw1.Enabled = True
        End If
    End Sub

    Private Sub chkTutth1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTutth1.CheckedChanged
        If chkTutth1.Checked = True Then
            If no_of_tut = 0 Then
                MsgBox("You have already selected maximum no. of tutorial slots.", MsgBoxStyle.Information, "Information")
                chkTutth1.Checked = False
                no_of_tut -= 1
            Else
                no_of_tut -= 1
                chkTutth2.Enabled = False
            End If
        Else
            no_of_tut += 1
            chkTutth2.Enabled = True
        End If
    End Sub

    Private Sub chkTutth2_CheckedChanged(sender As Object, e As EventArgs) Handles chkTutth2.CheckedChanged
        If chkTutth2.Checked = True Then
            If no_of_tut = 0 Then
                MsgBox("You have already selected maximum no. of tutorial slots.", MsgBoxStyle.Information, "Information")
                chkTutth2.Checked = False
                no_of_tut -= 1
            Else
                no_of_tut -= 1
                chkTutth1.Enabled = False
            End If
        Else
            no_of_tut += 1
            chkTutth1.Enabled = True
        End If
    End Sub

    Private Sub chkTutf1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTutf1.CheckedChanged
        If chkTutf1.Checked = True Then
            If no_of_tut = 0 Then
                MsgBox("You have already selected maximum no. of tutorial slots.", MsgBoxStyle.Information, "Information")
                chkTutf1.Checked = False
                no_of_tut -= 1
            Else
                no_of_tut -= 1
                chkTutf2.Enabled = False
            End If
        Else
            no_of_tut += 1
            chkTutf2.Enabled = True
        End If
    End Sub

    Private Sub chkTutf2_CheckedChanged(sender As Object, e As EventArgs) Handles chkTutf2.CheckedChanged
        If chkTutf2.Checked = True Then
            If no_of_tut = 0 Then
                MsgBox("You have already selected maximum no. of tutorial slots.", MsgBoxStyle.Information, "Information")
                chkTutf2.Checked = False
                no_of_tut -= 1
            Else
                no_of_tut -= 1
                chkTutf1.Enabled = False
            End If
        Else
            no_of_tut += 1
            chkTutf1.Enabled = True
        End If
    End Sub

    Private Sub chkLab_CheckedChanged(sender As Object, e As EventArgs) Handles chkLab.CheckedChanged
        If chkLab.Checked = True Then
            rbLabMon.Enabled = True
            rbLabTue.Enabled = True
            rbLabWed.Enabled = True
            rbLabThur.Enabled = True
            rbLabFri.Enabled = True
            rbLabMon.Checked = False
            rbLabTue.Checked = False
            rbLabWed.Checked = False
            rbLabThur.Checked = False
            rbLabFri.Checked = False
        Else
            rbLabMon.Enabled = False
            rbLabTue.Enabled = False
            rbLabWed.Enabled = False
            rbLabThur.Enabled = False
            rbLabFri.Enabled = False
            rbLabMon.Checked = False
            rbLabTue.Checked = False
            rbLabWed.Checked = False
            rbLabThur.Checked = False
            rbLabFri.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lec_code As String = GenerateLectureCode()
        Dim tut_code As String = GenerateTutorialCode()
        Dim lab_code As String = GenerateLabCode()
        If tbCourseName.Text = "" Then 'if course name is empty cursor will redirect to it
            tbCourseName.Focus()
        ElseIf tbCourseNo.Text = "" Then 'if course no. is empty cursor will redirect to it
            tbCourseNo.Focus()
        ElseIf CheckEquals(lec_code, NumericUpDown1.Value) = False Then
            MsgBox("Please select specified number of lecture slots.", MsgBoxStyle.Information, "Information")
        ElseIf CheckEquals(tut_code, NumericUpDown2.Value) = False Then
            MsgBox("Please select specified number of tutorial slots.", MsgBoxStyle.Information, "Information")
        Else
            Dim check As Boolean = False 'now we will check if the course is already added
            Try
                Dim file As New System.IO.StreamReader("courses.dat")
                Dim oneLine As String
                oneLine = file.ReadLine()
                While (oneLine <> "")
                    Dim course() As String = oneLine.Split(",".ToCharArray)
                    Dim courseno As String
                    courseno = course(0).Trim
                    If (courseno = tbCourseNo.Text) Then
                        check = True
                    End If
                    oneLine = file.ReadLine()
                End While
                file.Close()
            Catch ex As Exception
                Console.Write(ex)
            Finally
                If check = True Then
                    MsgBox("This course has already been added. Please contact administrator to modify.", MsgBoxStyle.Critical, "Information")
                Else
                    MsgBox("Course added succesfully!", MsgBoxStyle.Exclamation, "Information")
                    My.Computer.FileSystem.WriteAllText("courses.dat", tbCourseNo.Text + "," + lec_code + "," + tut_code + "," + lab_code + vbNewLine, True)
                End If
            End Try

        End If
    End Sub
    ' this function writes a 0 for unchecked box and 1 for checked box and appends it to the string
    Public Function GenerateLectureCode() As String
        Dim code As String = ""
        code = code + Convert.ToInt32(chklm1.Checked).ToString
        code = code + Convert.ToInt32(chklm2.Checked).ToString
        code = code + Convert.ToInt32(chklm3.Checked).ToString
        code = code + Convert.ToInt32(chklt1.Checked).ToString
        code = code + Convert.ToInt32(chklt2.Checked).ToString
        code = code + Convert.ToInt32(chklt3.Checked).ToString
        code = code + Convert.ToInt32(chklw1.Checked).ToString
        code = code + Convert.ToInt32(chklw2.Checked).ToString
        code = code + Convert.ToInt32(chklw3.Checked).ToString
        code = code + Convert.ToInt32(chklth1.Checked).ToString
        code = code + Convert.ToInt32(chklth2.Checked).ToString
        code = code + Convert.ToInt32(chklth3.Checked).ToString
        code = code + Convert.ToInt32(chklf1.Checked).ToString
        code = code + Convert.ToInt32(chklf2.Checked).ToString
        code = code + Convert.ToInt32(chklf3.Checked).ToString
        Return code
    End Function
    ' this function writes a 0 for unchecked box and 1 for checked box and appends it to the string
    Public Function GenerateTutorialCode() As String
        Dim code As String = ""
        code = code + Convert.ToInt32(chkTutm1.Checked).ToString
        code = code + Convert.ToInt32(chkTutm2.Checked).ToString
        code = code + Convert.ToInt32(chkTutt1.Checked).ToString
        code = code + Convert.ToInt32(chkTutt2.Checked).ToString
        code = code + Convert.ToInt32(chkTutw1.Checked).ToString
        code = code + Convert.ToInt32(chkTutw2.Checked).ToString
        code = code + Convert.ToInt32(chkTutth1.Checked).ToString
        code = code + Convert.ToInt32(chkTutth2.Checked).ToString
        code = code + Convert.ToInt32(chkTutf1.Checked).ToString
        code = code + Convert.ToInt32(chkTutf2.Checked).ToString
        Return code
    End Function
    ' this function writes a 0 for unchecked box and 1 for checked box and appends it to the string
    Public Function GenerateLabCode() As String
        Dim code As String = ""
        code = code + Convert.ToInt32(rbLabMon.Checked).ToString
        code = code + Convert.ToInt32(rbLabTue.Checked).ToString
        code = code + Convert.ToInt32(rbLabWed.Checked).ToString
        code = code + Convert.ToInt32(rbLabThur.Checked).ToString
        code = code + Convert.ToInt32(rbLabFri.Checked).ToString
        Return code
    End Function
    'this function checks if the no. of ticks matches the no. of preffered slots
    Public Function CheckEquals(ByRef code As String, ByRef num As Integer) As Boolean
        Dim res As Boolean = False
        Dim a As Integer
        Dim sum As Integer = 0
        For a = 0 To code.Length - 1
            sum += Convert.ToInt16(code.Chars(a)) - 48  'subtracting the ascii value of 0 from the sum each time
        Next
        If sum = num Then
            res = True
        Else
            res = False
        End If
        Return res
    End Function

    
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Faculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        Me.Visible = True
        Me.ResumeLayout()
        Me.WindowState = FormWindowState.Maximized
        Button1.FlatStyle = FlatStyle.Flat
        btnBack.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        btnBack.FlatAppearance.BorderSize = 0
        tbCourseName.Focus()
    End Sub

    Private Sub tbCourseName_Leave(sender As Object, e As EventArgs) Handles tbCourseName.Leave
        tbCourseNo.Focus()
    End Sub

    Private Sub tbCourseNo_Leave(sender As Object, e As EventArgs) Handles tbCourseNo.Leave
        NumericUpDown1.Focus()
    End Sub

    Private Sub NumericUpDown1_Leave(sender As Object, e As EventArgs) Handles NumericUpDown1.Leave
        NumericUpDown2.Focus()
    End Sub
End Class