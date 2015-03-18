<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbAddRoom = New System.Windows.Forms.TextBox()
        Me.tbAddFaculty = New System.Windows.Forms.TextBox()
        Me.btnGenFaculty = New System.Windows.Forms.Button()
        Me.btnSaveFaculty = New System.Windows.Forms.Button()
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGenTimeT = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbRollMax = New System.Windows.Forms.TextBox()
        Me.tbRollMin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblFacPass = New System.Windows.Forms.Label()
        Me.lblFacUN = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.demo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Add a new room"
        '
        'tbAddRoom
        '
        Me.tbAddRoom.Location = New System.Drawing.Point(228, 36)
        Me.tbAddRoom.Name = "tbAddRoom"
        Me.tbAddRoom.Size = New System.Drawing.Size(137, 20)
        Me.tbAddRoom.TabIndex = 8
        '
        'tbAddFaculty
        '
        Me.tbAddFaculty.Location = New System.Drawing.Point(228, 31)
        Me.tbAddFaculty.Name = "tbAddFaculty"
        Me.tbAddFaculty.Size = New System.Drawing.Size(137, 20)
        Me.tbAddFaculty.TabIndex = 8
        '
        'btnGenFaculty
        '
        Me.btnGenFaculty.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenFaculty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGenFaculty.Image = CType(resources.GetObject("btnGenFaculty.Image"), System.Drawing.Image)
        Me.btnGenFaculty.Location = New System.Drawing.Point(407, 23)
        Me.btnGenFaculty.Name = "btnGenFaculty"
        Me.btnGenFaculty.Size = New System.Drawing.Size(119, 44)
        Me.btnGenFaculty.TabIndex = 9
        Me.btnGenFaculty.Text = "Generate "
        Me.btnGenFaculty.UseVisualStyleBackColor = True
        '
        'btnSaveFaculty
        '
        Me.btnSaveFaculty.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveFaculty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSaveFaculty.Image = CType(resources.GetObject("btnSaveFaculty.Image"), System.Drawing.Image)
        Me.btnSaveFaculty.Location = New System.Drawing.Point(407, 89)
        Me.btnSaveFaculty.Name = "btnSaveFaculty"
        Me.btnSaveFaculty.Size = New System.Drawing.Size(119, 42)
        Me.btnSaveFaculty.TabIndex = 9
        Me.btnSaveFaculty.Text = "Save"
        Me.btnSaveFaculty.UseVisualStyleBackColor = True
        '
        'btnAddRoom
        '
        Me.btnAddRoom.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddRoom.Image = CType(resources.GetObject("btnAddRoom.Image"), System.Drawing.Image)
        Me.btnAddRoom.Location = New System.Drawing.Point(407, 22)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(119, 45)
        Me.btnAddRoom.TabIndex = 9
        Me.btnAddRoom.Text = "Save"
        Me.btnAddRoom.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Add a new faculty"
        '
        'btnGenTimeT
        '
        Me.btnGenTimeT.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenTimeT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGenTimeT.Image = CType(resources.GetObject("btnGenTimeT.Image"), System.Drawing.Image)
        Me.btnGenTimeT.Location = New System.Drawing.Point(407, 38)
        Me.btnGenTimeT.Name = "btnGenTimeT"
        Me.btnGenTimeT.Size = New System.Drawing.Size(119, 47)
        Me.btnGenTimeT.TabIndex = 9
        Me.btnGenTimeT.Text = "Generate"
        Me.btnGenTimeT.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Generate Time Table"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tbRollMax)
        Me.Panel1.Controls.Add(Me.tbRollMin)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnGenTimeT)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Location = New System.Drawing.Point(314, 416)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 129)
        Me.Panel1.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(261, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "to"
        '
        'tbRollMax
        '
        Me.tbRollMax.Location = New System.Drawing.Point(283, 53)
        Me.tbRollMax.MaxLength = 9
        Me.tbRollMax.Name = "tbRollMax"
        Me.tbRollMax.Size = New System.Drawing.Size(82, 20)
        Me.tbRollMax.TabIndex = 11
        '
        'tbRollMin
        '
        Me.tbRollMin.Location = New System.Drawing.Point(173, 53)
        Me.tbRollMin.MaxLength = 9
        Me.tbRollMin.Name = "tbRollMin"
        Me.tbRollMin.Size = New System.Drawing.Size(82, 20)
        Me.tbRollMin.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "For Roll Nos:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.lblFacPass)
        Me.Panel2.Controls.Add(Me.lblFacUN)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnSaveFaculty)
        Me.Panel2.Controls.Add(Me.btnGenFaculty)
        Me.Panel2.Controls.Add(Me.tbAddFaculty)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Location = New System.Drawing.Point(314, 256)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(566, 154)
        Me.Panel2.TabIndex = 11
        '
        'lblFacPass
        '
        Me.lblFacPass.AutoSize = True
        Me.lblFacPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacPass.Location = New System.Drawing.Point(48, 114)
        Me.lblFacPass.Name = "lblFacPass"
        Me.lblFacPass.Size = New System.Drawing.Size(71, 16)
        Me.lblFacPass.TabIndex = 11
        Me.lblFacPass.Text = "Password:"
        '
        'lblFacUN
        '
        Me.lblFacUN.AutoSize = True
        Me.lblFacUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacUN.Location = New System.Drawing.Point(48, 89)
        Me.lblFacUN.Name = "lblFacUN"
        Me.lblFacUN.Size = New System.Drawing.Size(74, 16)
        Me.lblFacUN.TabIndex = 11
        Me.lblFacUN.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnAddRoom)
        Me.Panel3.Controls.Add(Me.tbAddRoom)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Location = New System.Drawing.Point(314, 167)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(566, 83)
        Me.Panel3.TabIndex = 12
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(706, 588)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(134, 46)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(434, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(308, 53)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ADMIN PANEL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(591, 455)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 13
        '
        'demo
        '
        Me.demo.AutoSize = True
        Me.demo.BackColor = System.Drawing.Color.Transparent
        Me.demo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.demo.Location = New System.Drawing.Point(639, 463)
        Me.demo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.demo.Name = "demo"
        Me.demo.Size = New System.Drawing.Size(0, 13)
        Me.demo.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, -28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(292, 925)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox1.Location = New System.Drawing.Point(908, 55)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(342, 613)
        Me.TextBox1.TabIndex = 19
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1315, 693)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.demo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbAddRoom As System.Windows.Forms.TextBox
    Friend WithEvents tbAddFaculty As System.Windows.Forms.TextBox
    Friend WithEvents btnGenFaculty As System.Windows.Forms.Button
    Friend WithEvents btnSaveFaculty As System.Windows.Forms.Button
    Friend WithEvents btnAddRoom As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGenTimeT As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFacUN As System.Windows.Forms.Label
    Friend WithEvents lblFacPass As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbRollMax As System.Windows.Forms.TextBox
    Friend WithEvents tbRollMin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents demo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
