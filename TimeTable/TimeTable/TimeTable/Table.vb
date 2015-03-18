Imports System.Drawing.Imaging
Public Class Table



    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    'when this form is loaded then the labels are filled from the data used from the admin class
    Private Sub Table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Admin.generateTimeTable()
        ml1.Text = Admin.lecture(0)
        ml2.Text = Admin.lecture(1)
        ml3.Text = Admin.lecture(2)
        tl1.Text = Admin.lecture(3)
        tl2.Text = Admin.lecture(4)
        tl3.Text = Admin.lecture(5)
        wl1.Text = Admin.lecture(6)
        wl2.Text = Admin.lecture(7)
        wl3.Text = Admin.lecture(8)
        thl1.Text = Admin.lecture(9)
        thl2.Text = Admin.lecture(10)
        thl3.Text = Admin.lecture(11)
        fl1.Text = Admin.lecture(12)
        fl2.Text = Admin.lecture(13)
        fl3.Text = Admin.lecture(14)
        mt1.Text = Admin.tutorial(0)
        mt2.Text = Admin.tutorial(1)
        tt1.Text = Admin.tutorial(2)
        tt2.Text = Admin.tutorial(3)
        wt1.Text = Admin.tutorial(4)
        wt2.Text = Admin.tutorial(5)
        tht1.Text = Admin.tutorial(6)
        tht2.Text = Admin.tutorial(7)
        ft1.Text = Admin.tutorial(8)
        ft2.Text = Admin.tutorial(9)
        mlab.Text = Admin.labs(0)
        tlab.Text = Admin.labs(1)
        wlab.Text = Admin.labs(2)
        thlab.Text = Admin.labs(3)
        flab.Text = Admin.labs(4)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
    'to save the time table as a jpeg image for future reference
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bmpScreenshot As Bitmap = New Bitmap(Width, Height, PixelFormat.Format32bppArgb)
        ' Create a graphics object from the bitmap  
        Dim gfxScreenshot As Graphics = Graphics.FromImage(bmpScreenshot)
        ' Take a screenshot of the entire Form1  
        gfxScreenshot.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, Me.Size, CopyPixelOperation.SourceCopy)
        ' Save the screenshot   
        bmpScreenshot.Save("timetable.jpg", ImageFormat.Jpeg)
        MsgBox("Time Table saved successfully!", MsgBoxStyle.Exclamation, "Information")
    End Sub

End Class