﻿' TIME TABLE GENERATOR
' Windows Form Application - First Page
' Authors: Desh Raj, Mrinal Tak, Abhinav Sonkar, Mandar Kale, Narendra Choudhary
Imports System.Char

Public Class Form1

    Public roll As Integer 'defined globally because it has been used in another class

    'Functionality for Login button
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim un As String = tbAdminun.Text
        Dim pw As String = tbAdminpw.Text
        Dim check As Boolean = False

        'Case 1: Both Username and Password fields are empty.
        If un = "" And pw = "" Then
            tbAdminun.Focus()

            'Case 2: Login as Admin. Admin username and password has been hard-coded.
        ElseIf un = "admin" And pw = "12345678" Then
            Admin.Show()
            Me.Hide()
            Exit Sub

        Else

            'Case 3: Checking if the username and password belong to a faculty
            Dim isFac As Boolean = False
            'Note: Try-Catch block is used so that error generated due to non-availability of file can be handled without crashing.
            Try
                Dim file As New System.IO.StreamReader("facAuth.dat")
                Dim oneLine As String
                oneLine = file.ReadLine()   'the first line of the file is stored in the variable 'oneLine'

                'In this While loop, we check each line of the file for the entered Username and Password.
                While (oneLine <> "")
                    Dim strScores() As String = oneLine.Split(",".ToCharArray) 'Implodes the string at commas and stores in a string array
                    Dim strName As String
                    Dim strUN As String
                    Dim strPW As String

                    'The first, second and third terms in each line are Name, Username and Password respectively.
                    strName = strScores(0).Trim
                    strUN = strScores(1).Trim
                    strPW = strScores(2).Trim
                    If (un = strUN And pw = strPW) Then
                        check = True
                        isFac = True
                        Faculty.lblFacName.Text = "Welcome, " + strName 'lblFacName control is in the class Faculty
                        Faculty.Show()
                        Me.Hide()
                        Exit Sub
                    End If
                    oneLine = file.ReadLine()
                End While
                file.Close()
            Catch ex As Exception
                Console.Write(ex)

                'If no match is found, then a message informing the same will be displayed.

            End Try

            If isFac = False Then
                'Case 4: To check if it is a roll number
                Dim isRoll As Boolean = False
                If Not (un.Length() = 0) And pw = "" Then
                    isRoll = True
                    For i = 0 To un.Length() - 1
                        If IsNumber(un.Chars(i)) Then
                            Continue For
                        Else
                            isRoll = False
                            Exit For
                        End If
                    Next
                End If

                If isRoll = True Then
                    'We read the range of roll nos. generated by the Admin which is stored in the file "rolls.dat"
                    Try
                        Dim file As New System.IO.StreamReader("rolls.dat")
                        Dim line As String = file.ReadLine()
                        Dim rolls() As String = line.Split(",".ToCharArray)
                        Dim rmin As Integer = Convert.ToInt32(rolls(0).Trim)
                        Dim rmax As Integer = Convert.ToInt32(rolls(1).Trim)
                        roll = Convert.ToInt32(un)

                        'If entered roll no is in the given range (between the rollMin and rollMax) then Time Table will be displayed.
                        If roll >= rmin And roll <= rmax Then
                            Student.Show()
                            Me.Hide()
                            Exit Sub
                            check = True
                        Else
                            MsgBox("Time Table has not yet been generated for your Roll No.", MsgBoxStyle.Critical, "Error!")
                        End If
                        file.Close()
                    Catch ex As Exception
                        MsgBox("Time Table has not yet been generated for your Roll No.", MsgBoxStyle.Critical, "Error!")
                    End Try

                Else
                    MsgBox("Invalid Roll Number.", MsgBoxStyle.Information, "Information")
                End If
            End If
        End If
    End Sub

    

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Shown
        Me.SuspendLayout()
        Me.Visible = True
        Me.ResumeLayout()
        Me.WindowState = FormWindowState.Maximized
        btnAdmin.FlatStyle = FlatStyle.Flat
        tbAdminun.Focus()
        tbAdminun.Text = ""
        tbAdminpw.Text = ""
    End Sub

    Private Sub tbAdminun_Leave(sender As Object, e As EventArgs) Handles tbAdminun.Leave
        tbAdminpw.Focus()
    End Sub

    Private Sub tbAdminun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbAdminun.KeyPress, tbAdminpw.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then
            btnAdmin.PerformClick()
        End If
    End Sub
End Class