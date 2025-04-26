Public Class AddStudent
    Private Sub AddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub

    Private Sub xbtn_Click(sender As Object, e As EventArgs) Handles xbtn.Click
        Me.Dispose()

    End Sub
    Private Sub btnAddstudent_Click(sender As Object, e As EventArgs) Handles btnAddstudent.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procStudentRegister"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_Studid", txtStudentID.Text)
                .Parameters.AddWithValue("@p_Lname", txtLastname.Text)
                .Parameters.AddWithValue("@p_Fname", txtFirstname.Text)
                .Parameters.AddWithValue("@p_mName", txtMiddlename.Text)
                .Parameters.AddWithValue("@p_gender", cmbGender.Text)
                .Parameters.AddWithValue("@p_Year", cmbYearlevel.Text)
                .Parameters.AddWithValue("@p_studentpic", studentPhotopath)
                .Parameters.AddWithValue("@p_status", "Un-Voted")

                .ExecuteNonQuery()
                Me.Dispose()

            End With
        Catch ex As Exception
            MessageBox.Show("record Save Successfully", "Saving records", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Sub cmbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGender.SelectedIndexChanged

    End Sub

    Private Sub browsebtn_Click(sender As Object, e As EventArgs) Handles browsebtn.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class