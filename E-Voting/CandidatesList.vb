Imports MySql.Data.MySqlClient

Public Class CandidatesList
    Private Sub CandidatesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPresident.Click
        With President
            .TopLevel = False
            Panel2.Controls.Add(President)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub prcDisplayStudent()
        Try
            sqlAdapter = New MySqlDataAdapter
            datatbl = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "p"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_stud", SstudentLogin.txtStudentIDbox.Text)
                sqlAdapter.SelectCommand = command
                datatbl.Clear()
                sqlAdapter.Fill(datatbl)
            End With
            sqlAdapter.Dispose()
            datatbl.Dispose()

        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class