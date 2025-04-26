Imports System.Diagnostics.Eventing.Reader
Imports System.Reflection.Emit
Imports K4os.Compression.LZ4.Encoders
Imports MySql.Data.MySqlClient

Public Class SstudentLogin
    Private Sub SstudentLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label.Text = Date.Now.ToString("hh:mm:ss:tt")
        Label2.Text = Date.Now.ToString("ddd,yyyy-MM-dd")
    End Sub

    Private Sub txtStudentIDbox_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button2Exit_Click(sender As Object, e As EventArgs) Handles Button2Exit.Click
        adminlogin.Close()
        Me.Close()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Hide()
        adminlogin.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Login_Click_2(sender As Object, e As EventArgs) Handles Login.Click
        If txtStudentIDbox.Text = String.Empty Then
            Label1.Text = "Please enter student ID!"
            Label1.ForeColor = Color.OrangeRed
        Else
            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "prcStudentLogin"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_studentid", txtStudentIDbox.Text)
                    sqlAdapter = New MySqlDataAdapter
                    datatbl = New DataTable
                    sqlAdapter.SelectCommand = command
                    sqlAdapter.Fill(datatbl)

                    If datatbl.Rows.Count > 0 Then
                        .Parameters.Clear()
                        .CommandText = "prcStudentstatus"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_studentid", txtStudentIDbox.Text)
                        .Parameters.AddWithValue("@p_status", "Un-Voted")
                        sqlAdapter = New MySqlDataAdapter
                        datatbl = New DataTable
                        sqlAdapter.SelectCommand = command
                        sqlAdapter.Fill(datatbl)

                        If datatbl.Rows.Count > 0 Then
                            With CandidatesList
                                .TopLevel = False
                                Panel1.Controls.Add(CandidatesList)
                                .BringToFront()
                                .Show()

                            End With
                        Else
                            Label1.Text = "Already Voted"
                            Label1.ForeColor = Color.OrangeRed
                            txtStudentIDbox.Text = " "

                        End If
                    Else
                        Label1.Text = "Student not found!"
                        Label1.ForeColor = Color.OrangeRed
                        txtStudentIDbox.Text = " "
                        .Parameters.Clear()



                    End If

                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub


    Private Sub txtStudentIDbox_TextChanged_1(sender As Object, e As EventArgs) Handles txtStudentIDbox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label.Click
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class