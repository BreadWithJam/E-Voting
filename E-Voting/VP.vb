Imports System.IO
Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe



Public Class VP

    Private Sub VP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        DisplayVP()

    End Sub

    Private Sub DisplayVP()
        Try
            sqlAdapter = New MySqlDataAdapter
            datatbl = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "prdDisplayCandidates"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_positionlabel", Label38.Text)
                sqlAdapter.SelectCommand = command
                datatbl.Clear()

                sqlAdapter.Fill(datatbl)
                datatbl.Columns.Add("CandidatePhoto", GetType(Byte()))
                For Each grow As DataRow In datatbl.Rows
                    grow("CandidatePhoto") = File.ReadAllBytes(CStr(grow("Candidatepic")))
                Next
                DataGridView1.DataSource = datatbl

            End With
            datatbl.Dispose()
            sqlAdapter.Dispose()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selected As DataGridViewRow
        selected = DataGridView1.Rows(e.RowIndex)
        Dim lname As String = selected.Cells(0).Value
        With command
            .Parameters.Clear()
            .CommandText = "prccandidatePic"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_lname", lname)

            Dim VPphoto As String = command.ExecuteScalar()
            Dim pathstring As String = System.IO.Path.Combine(VPphoto)
            President.PictureBox3.Image = Image.FromFile(pathstring)
        End With
        President.TextBox4.Text = selected.Cells(0).Value.ToString
        President.TextBox3.Text = selected.Cells(1).Value.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcStoreVotes"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_StudentID", SstudentLogin.txtStudentIDbox.Text)
                .Parameters.AddWithValue("@p_CandidateLN", President.TextBox4.Text)
                .Parameters.AddWithValue("@p_CandidateFN", President.TextBox3.Text)
                .Parameters.AddWithValue("@p_VoteDateTime", Date.Now.ToString("yyyy-MM-dd hh::mm::ss tt"))
                .ExecuteNonQuery()

                With Secretary
                    .TopLevel = False
                    Panel1.Controls.Add(Secretary)
                    .BringToFront()
                    .Show()
                End With

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class