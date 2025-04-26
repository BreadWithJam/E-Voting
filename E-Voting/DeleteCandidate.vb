Public Class DeleteCandidate


    Private Sub DeleteCandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim confirmMSg = MessageBox.Show("Are you sure you want to delete this data?", "Delete document", MessageBoxButtons.YesNo)
        If confirmMSg = DialogResult.Yes Then
            With command
                .Parameters.Clear()
                .CommandText = "prcDeleteCandidate"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_studentid", TextBox1.Text)
                .ExecuteNonQuery()
                MsgBox("Deleted Successfully", vbInformation)
                TextBox1.Clear()
                TextBox1.Focus()


            End With
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class