Imports MySql.Data.MySqlClient

Public Class Result
    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        Load_Result()


    End Sub

    Sub Load_Result()
        Try
            sqlAdapter = New MySqlDataAdapter
            datatbl = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcVoteCount"
                .CommandType = CommandType.StoredProcedure
                sqlAdapter.SelectCommand = command
                datatbl.Clear()
                sqlAdapter.Fill(datatbl)
                DataGridView1.DataSource = datatbl
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class