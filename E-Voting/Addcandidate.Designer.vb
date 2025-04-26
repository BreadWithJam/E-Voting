<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addcandidate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Addcandidate))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Candidatedefault = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStudid = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.cmbYearlevel = New System.Windows.Forms.ComboBox()
        Me.Buttonbrowse = New System.Windows.Forms.PictureBox()
        Me.btnRegisterCandidate = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Candidatedefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buttonbrowse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRegisterCandidate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(246, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Candidatedefault
        '
        Me.Candidatedefault.Image = CType(resources.GetObject("Candidatedefault.Image"), System.Drawing.Image)
        Me.Candidatedefault.Location = New System.Drawing.Point(295, 79)
        Me.Candidatedefault.Name = "Candidatedefault"
        Me.Candidatedefault.Size = New System.Drawing.Size(135, 122)
        Me.Candidatedefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Candidatedefault.TabIndex = 1
        Me.Candidatedefault.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(87, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(87, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lastname :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(87, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Firstname :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(84, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Middlename :"
        '
        'txtStudid
        '
        Me.txtStudid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudid.Location = New System.Drawing.Point(197, 222)
        Me.txtStudid.Name = "txtStudid"
        Me.txtStudid.Size = New System.Drawing.Size(189, 24)
        Me.txtStudid.TabIndex = 6
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(197, 268)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(189, 24)
        Me.txtLastname.TabIndex = 7
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(197, 315)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(189, 24)
        Me.txtFirstname.TabIndex = 8
        '
        'txtMiddlename
        '
        Me.txtMiddlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.Location = New System.Drawing.Point(197, 357)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(189, 24)
        Me.txtMiddlename.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(431, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Position :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Location = New System.Drawing.Point(431, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Grade :"
        '
        'cmbPosition
        '
        Me.cmbPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Items.AddRange(New Object() {"President", "Vice President", "Secretary", "Assistant Secretary", "Treasurer", "Assistant Treasurer", "Auditor", "Assistant Auditor", "P.I.O"})
        Me.cmbPosition.Location = New System.Drawing.Point(532, 225)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(173, 26)
        Me.cmbPosition.TabIndex = 13
        '
        'cmbYearlevel
        '
        Me.cmbYearlevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYearlevel.FormattingEnabled = True
        Me.cmbYearlevel.Items.AddRange(New Object() {"7", "8", "9", "10", "11", "12"})
        Me.cmbYearlevel.Location = New System.Drawing.Point(533, 266)
        Me.cmbYearlevel.Name = "cmbYearlevel"
        Me.cmbYearlevel.Size = New System.Drawing.Size(173, 26)
        Me.cmbYearlevel.TabIndex = 15
        '
        'Buttonbrowse
        '
        Me.Buttonbrowse.Image = CType(resources.GetObject("Buttonbrowse.Image"), System.Drawing.Image)
        Me.Buttonbrowse.Location = New System.Drawing.Point(448, 160)
        Me.Buttonbrowse.Name = "Buttonbrowse"
        Me.Buttonbrowse.Size = New System.Drawing.Size(79, 41)
        Me.Buttonbrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Buttonbrowse.TabIndex = 16
        Me.Buttonbrowse.TabStop = False
        '
        'btnRegisterCandidate
        '
        Me.btnRegisterCandidate.Image = CType(resources.GetObject("btnRegisterCandidate.Image"), System.Drawing.Image)
        Me.btnRegisterCandidate.Location = New System.Drawing.Point(352, 405)
        Me.btnRegisterCandidate.Name = "btnRegisterCandidate"
        Me.btnRegisterCandidate.Size = New System.Drawing.Size(118, 43)
        Me.btnRegisterCandidate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRegisterCandidate.TabIndex = 17
        Me.btnRegisterCandidate.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(716, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(34, 22)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnExit.TabIndex = 18
        Me.btnExit.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Addcandidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(762, 475)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRegisterCandidate)
        Me.Controls.Add(Me.Buttonbrowse)
        Me.Controls.Add(Me.cmbYearlevel)
        Me.Controls.Add(Me.cmbPosition)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMiddlename)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtStudid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Candidatedefault)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Addcandidate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addcandidate"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Candidatedefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Buttonbrowse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRegisterCandidate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Candidatedefault As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStudid As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents cmbYearlevel As ComboBox
    Friend WithEvents Buttonbrowse As PictureBox
    Friend WithEvents btnRegisterCandidate As PictureBox
    Friend WithEvents btnExit As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
