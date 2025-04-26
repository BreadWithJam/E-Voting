Public Class Deleteanadmin
    Private Sub Deleteanadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim confirmMSg = MessageBox.Show("Are you sure you want to delete this data?", "Delete document", MessageBoxButtons.YesNo)
        If confirmMSg = DialogResult.Yes Then
            With command
                .Parameters.Clear()
                .CommandText = "prcDeleteAdmin"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_name", TextBox1.Text)
                .ExecuteNonQuery()
                MsgBox("Deleted successfully", vbInformation)
                TextBox1.Clear()
                TextBox1.Focus()


            End With
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class