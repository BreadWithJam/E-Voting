<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStudent))
        Me.StudentDefault = New System.Windows.Forms.PictureBox()
        Me.browsebtn = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.cmbYearlevel = New System.Windows.Forms.ComboBox()
        Me.btnAddstudent = New System.Windows.Forms.PictureBox()
        Me.xbtn = New System.Windows.Forms.PictureBox()
        CType(Me.StudentDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.browsebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentDefault
        '
        Me.StudentDefault.Image = CType(resources.GetObject("StudentDefault.Image"), System.Drawing.Image)
        Me.StudentDefault.Location = New System.Drawing.Point(219, 55)
        Me.StudentDefault.Name = "StudentDefault"
        Me.StudentDefault.Size = New System.Drawing.Size(126, 118)
        Me.StudentDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StudentDefault.TabIndex = 0
        Me.StudentDefault.TabStop = False
        '
        'browsebtn
        '
        Me.browsebtn.Image = CType(resources.GetObject("browsebtn.Image"), System.Drawing.Image)
        Me.browsebtn.Location = New System.Drawing.Point(360, 132)
        Me.browsebtn.Name = "browsebtn"
        Me.browsebtn.Size = New System.Drawing.Size(86, 41)
        Me.browsebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.browsebtn.TabIndex = 1
        Me.browsebtn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(54, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Student ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(54, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lastname :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(54, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Firstname :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(54, 353)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Middlename :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(339, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Gender :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Location = New System.Drawing.Point(339, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Grade  :"
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(165, 220)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(149, 24)
        Me.txtStudentID.TabIndex = 10
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(165, 260)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(149, 24)
        Me.txtLastname.TabIndex = 11
        '
        'txtMiddlename
        '
        Me.txtMiddlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.Location = New System.Drawing.Point(165, 347)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(149, 24)
        Me.txtMiddlename.TabIndex = 12
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(165, 303)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(149, 24)
        Me.txtFirstname.TabIndex = 13
        '
        'cmbGender
        '
        Me.cmbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(436, 218)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(139, 26)
        Me.cmbGender.TabIndex = 14
        '
        'cmbYearlevel
        '
        Me.cmbYearlevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYearlevel.FormattingEnabled = True
        Me.cmbYearlevel.Items.AddRange(New Object() {"7", "8", "9", "10", "11", "12"})
        Me.cmbYearlevel.Location = New System.Drawing.Point(436, 258)
        Me.cmbYearlevel.Name = "cmbYearlevel"
        Me.cmbYearlevel.Size = New System.Drawing.Size(139, 26)
        Me.cmbYearlevel.TabIndex = 16
        '
        'btnAddstudent
        '
        Me.btnAddstudent.Image = CType(resources.GetObject("btnAddstudent.Image"), System.Drawing.Image)
        Me.btnAddstudent.Location = New System.Drawing.Point(259, 406)
        Me.btnAddstudent.Name = "btnAddstudent"
        Me.btnAddstudent.Size = New System.Drawing.Size(86, 41)
        Me.btnAddstudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAddstudent.TabIndex = 17
        Me.btnAddstudent.TabStop = False
        '
        'xbtn
        '
        Me.xbtn.Image = CType(resources.GetObject("xbtn.Image"), System.Drawing.Image)
        Me.xbtn.Location = New System.Drawing.Point(559, 12)
        Me.xbtn.Name = "xbtn"
        Me.xbtn.Size = New System.Drawing.Size(34, 22)
        Me.xbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.xbtn.TabIndex = 19
        Me.xbtn.TabStop = False
        '
        'AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(605, 487)
        Me.Controls.Add(Me.xbtn)
        Me.Controls.Add(Me.btnAddstudent)
        Me.Controls.Add(Me.cmbYearlevel)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.txtMiddlename)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.browsebtn)
        Me.Controls.Add(Me.StudentDefault)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddStudent"
        CType(Me.StudentDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.browsebtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddstudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentDefault As PictureBox
    Friend WithEvents browsebtn As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents cmbYearlevel As ComboBox
    Friend WithEvents btnAddstudent As PictureBox
    Friend WithEvents xbtn As PictureBox
End Class
