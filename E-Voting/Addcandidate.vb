Public Class Addcandidate
    Private Sub Addcandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()

    End Sub

    Private Sub btnRegisterCandidate_Click(sender As Object, e As EventArgs) Handles btnRegisterCandidate.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcAddCandidate"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_StudentID", txtStudid.Text)
                .Parameters.AddWithValue("@p_lastname", txtLastname.Text)
                .Parameters.AddWithValue("@p_Mname", txtMiddlename.Text)
                .Parameters.AddWithValue("@p_Fname", txtFirstname.Text)
                .Parameters.AddWithValue("@p_Position", cmbPosition.Text)
                .Parameters.AddWithValue("@p_Yearlvl", cmbYearlevel.Text)
                .Parameters.AddWithValue("@p_Candidatepic", studentPhotopath)
                .ExecuteNonQuery()
                MsgBox("Candidate registered successfully!", vbInformation)
                txtStudid.Clear()
                txtLastname.Clear()
                txtMiddlename.Clear()
                txtFirstname.Clear()
                txtStudid.Focus()
            End With


        Catch ex As Exception
            MessageBox.Show("record Save Successfully", "Saving records", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Sub Buttonbrowse_Click(sender As Object, e As EventArgs) Handles Buttonbrowse.Click
        Try
            With OpenFileDialog1
                .Title = "Select Photo"
                .FileName = ""
                If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Candidatedefault.Image = Image.FromFile(.FileName)
                    studentPhotopath = .FileName
                End If
            End With



        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub Candidatedefault_Click(sender As Object, e As EventArgs) Handles Candidatedefault.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class