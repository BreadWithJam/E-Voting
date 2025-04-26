<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Students
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Students))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.exitbutton = New System.Windows.Forms.PictureBox()
        Me.lblTotalRecord = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chckAutoComplete = New System.Windows.Forms.CheckBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.xbtn = New System.Windows.Forms.PictureBox()
        Me.btnAddstudent = New System.Windows.Forms.PictureBox()
        Me.cmbYearlevel = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtFirstnm = New System.Windows.Forms.TextBox()
        Me.TxtMiddlenm = New System.Windows.Forms.TextBox()
        Me.txtLastnm = New System.Windows.Forms.TextBox()
        Me.txtStudentid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.browsebtn = New System.Windows.Forms.PictureBox()
        Me.StudentDefault = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.exitbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.xbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.browsebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 510)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.exitbutton)
        Me.TabPage1.Controls.Add(Me.lblTotalRecord)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.btnSearch)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.chckAutoComplete)
        Me.TabPage1.Controls.Add(Me.txtSearch)
        Me.TabPage1.Controls.Add(Me.cmbFilter)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 476)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Students list"
        '
        'exitbutton
        '
        Me.exitbutton.Image = CType(resources.GetObject("exitbutton.Image"), System.Drawing.Image)
        Me.exitbutton.Location = New System.Drawing.Point(733, 6)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(29, 19)
        Me.exitbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitbutton.TabIndex = 23
        Me.exitbutton.TabStop = False
        '
        'lblTotalRecord
        '
        Me.lblTotalRecord.AutoSize = True
        Me.lblTotalRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalRecord.Location = New System.Drawing.Point(26, 439)
        Me.lblTotalRecord.Name = "lblTotalRecord"
        Me.lblTotalRecord.Size = New System.Drawing.Size(85, 15)
        Me.lblTotalRecord.TabIndex = 20
        Me.lblTotalRecord.Text = "Total records :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(752, 346)
        Me.DataGridView1.TabIndex = 19
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Student ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Fullname"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Gender"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Grade"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Voting Status"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(281, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(37, 24)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(304, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Auto complete"
        '
        'chckAutoComplete
        '
        Me.chckAutoComplete.AutoSize = True
        Me.chckAutoComplete.Location = New System.Drawing.Point(281, 50)
        Me.chckAutoComplete.Name = "chckAutoComplete"
        Me.chckAutoComplete.Size = New System.Drawing.Size(89, 19)
        Me.chckAutoComplete.TabIndex = 16
        Me.chckAutoComplete.Text = "CheckBox1"
        Me.chckAutoComplete.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(102, 45)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(173, 24)
        Me.txtSearch.TabIndex = 15
        '
        'cmbFilter
        '
        Me.cmbFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"ALL", "Lastname"})
        Me.cmbFilter.Location = New System.Drawing.Point(102, 13)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(173, 26)
        Me.cmbFilter.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Search type :"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.Controls.Add(Me.xbtn)
        Me.TabPage2.Controls.Add(Me.btnAddstudent)
        Me.TabPage2.Controls.Add(Me.cmbYearlevel)
        Me.TabPage2.Controls.Add(Me.cmbGender)
        Me.TabPage2.Controls.Add(Me.txtFirstnm)
        Me.TabPage2.Controls.Add(Me.TxtMiddlenm)
        Me.TabPage2.Controls.Add(Me.txtLastnm)
        Me.TabPage2.Controls.Add(Me.txtStudentid)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.browsebtn)
        Me.TabPage2.Controls.Add(Me.StudentDefault)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 476)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add student"
        '
        'xbtn
        '
        Me.xbtn.Image = CType(resources.GetObject("xbtn.Image"), System.Drawing.Image)
        Me.xbtn.Location = New System.Drawing.Point(718, 6)
        Me.xbtn.Name = "xbtn"
        Me.xbtn.Size = New System.Drawing.Size(28, 24)
        Me.xbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.xbtn.TabIndex = 33
        Me.xbtn.TabStop = False
        '
        'btnAddstudent
        '
        Me.btnAddstudent.Image = CType(resources.GetObject("btnAddstudent.Image"), System.Drawing.Image)
        Me.btnAddstudent.Location = New System.Drawing.Point(332, 381)
        Me.btnAddstudent.Name = "btnAddstudent"
        Me.btnAddstudent.Size = New System.Drawing.Size(86, 41)
        Me.btnAddstudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAddstudent.TabIndex = 32
        Me.btnAddstudent.TabStop = False
        '
        'cmbYearlevel
        '
        Me.cmbYearlevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYearlevel.FormattingEnabled = True
        Me.cmbYearlevel.Items.AddRange(New Object() {"7", "8", "9", "10", "11", "12"})
        Me.cmbYearlevel.Location = New System.Drawing.Point(509, 238)
        Me.cmbYearlevel.Name = "cmbYearlevel"
        Me.cmbYearlevel.Size = New System.Drawing.Size(139, 26)
        Me.cmbYearlevel.TabIndex = 31
        '
        'cmbGender
        '
        Me.cmbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(509, 193)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(139, 26)
        Me.cmbGender.TabIndex = 29
        '
        'txtFirstnm
        '
        Me.txtFirstnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstnm.Location = New System.Drawing.Point(238, 278)
        Me.txtFirstnm.Name = "txtFirstnm"
        Me.txtFirstnm.Size = New System.Drawing.Size(149, 24)
        Me.txtFirstnm.TabIndex = 28
        '
        'TxtMiddlenm
        '
        Me.TxtMiddlenm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMiddlenm.Location = New System.Drawing.Point(238, 322)
        Me.TxtMiddlenm.Name = "TxtMiddlenm"
        Me.TxtMiddlenm.Size = New System.Drawing.Size(149, 24)
        Me.TxtMiddlenm.TabIndex = 27
        '
        'txtLastnm
        '
        Me.txtLastnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastnm.Location = New System.Drawing.Point(238, 235)
        Me.txtLastnm.Name = "txtLastnm"
        Me.txtLastnm.Size = New System.Drawing.Size(149, 24)
        Me.txtLastnm.TabIndex = 26
        '
        'txtStudentid
        '
        Me.txtStudentid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentid.Location = New System.Drawing.Point(238, 195)
        Me.txtStudentid.Name = "txtStudentid"
        Me.txtStudentid.Size = New System.Drawing.Size(149, 24)
        Me.txtStudentid.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Location = New System.Drawing.Point(412, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 18)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Grade :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(412, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Gender :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(127, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Middlename :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(127, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Firstname :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label8.Location = New System.Drawing.Point(127, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 18)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Lastname :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label9.Location = New System.Drawing.Point(127, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Student ID :"
        '
        'browsebtn
        '
        Me.browsebtn.Image = CType(resources.GetObject("browsebtn.Image"), System.Drawing.Image)
        Me.browsebtn.Location = New System.Drawing.Point(426, 126)
        Me.browsebtn.Name = "browsebtn"
        Me.browsebtn.Size = New System.Drawing.Size(77, 37)
        Me.browsebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.browsebtn.TabIndex = 1
        Me.browsebtn.TabStop = False
        '
        'StudentDefault
        '
        Me.StudentDefault.Image = CType(resources.GetObject("StudentDefault.Image"), System.Drawing.Image)
        Me.StudentDefault.Location = New System.Drawing.Point(291, 43)
        Me.StudentDefault.Name = "StudentDefault"
        Me.StudentDefault.Size = New System.Drawing.Size(127, 120)
        Me.StudentDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StudentDefault.TabIndex = 0
        Me.StudentDefault.TabStop = False
        '
        'OpenFileDialog3
        '
        Me.OpenFileDialog3.FileName = "OpenFileDialog3"
        '
        'Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 514)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Students"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.exitbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.xbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddstudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.browsebtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDefault, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chckAutoComplete As CheckBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblTotalRecord As Label
    Friend WithEvents exitbutton As PictureBox
    Friend WithEvents browsebtn As PictureBox
    Friend WithEvents StudentDefault As PictureBox
    Friend WithEvents btnAddstudent As PictureBox
    Friend WithEvents cmbYearlevel As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtFirstnm As TextBox
    Friend WithEvents TxtMiddlenm As TextBox
    Friend WithEvents txtLastnm As TextBox
    Friend WithEvents txtStudentid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents xbtn As PictureBox
    Friend WithEvents OpenFileDialog3 As OpenFileDialog
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
