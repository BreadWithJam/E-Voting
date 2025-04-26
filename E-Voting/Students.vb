Imports System.ComponentModel.Design
Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Students
    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        prcDisplayStudent()

    End Sub

    Private Sub prcDisplayStudent()
        Try
            sqlAdapter = New MySqlDataAdapter
            datatbl = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayAllStudents"
                .CommandType = CommandType.StoredProcedure
                sqlAdapter.SelectCommand = command
                datatbl.Clear()
                sqlAdapter.Fill(datatbl)
                lblTotalRecord.Text = "Total Records: " & datatbl.Rows.Count
                If datatbl.Rows.Count > 0 Then
                    DataGridView1.RowCount = datatbl.Rows.Count
                    row = 0
                    While Not datatbl.Rows.Count - 1 < row
                        DataGridView1.Rows(row).Cells(0).Value = datatbl.Rows(row).Item("id").ToString
                        DataGridView1.Rows(row).Cells(1).Value = datatbl.Rows(row).Item("StudentID").ToString

                        DataGridView1.Rows(row).Cells(2).Value = datatbl.Rows(row).Item("lname") & ", " &
                                                                 datatbl.Rows(row).Item("fname") & " " &
                                                                 datatbl.Rows(row).Item("mname")
                        DataGridView1.Rows(row).Cells(3).Value = datatbl.Rows(row).Item("Gender").ToString
                        DataGridView1.Rows(row).Cells(4).Value = datatbl.Rows(row).Item("Grade").ToString
                        DataGridView1.Rows(row).Cells(5).Value = datatbl.Rows(row).Item("VotingStatus").ToString


                        row = row + 1
                    End While


                Else
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK)
                End If
            End With
            sqlAdapter.Dispose()
            datatbl.Dispose()

        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try
    End Sub
    Private Sub tabAddstudent_Click(sender As Object, e As EventArgs)
        checkDatabaseConnection()
    End Sub

    Private Sub StudentDefault_Click(sender As Object, e As EventArgs) Handles StudentDefault.Click

    End Sub

    Private Sub browsebtn_Click(sender As Object, e As EventArgs) Handles browsebtn.Click
        Try
            With OpenFileDialog3
                .Title = "Select Photo"
                .FileName = ""
                If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    StudentDefault.Image = Image.FromFile(.FileName)
                    studentPhotopath = .FileName
                End If
            End With



        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnAddstudent_Click(sender As Object, e As EventArgs) Handles btnAddstudent.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procStudentRegister"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_Studid", txtStudentid.Text)
                .Parameters.AddWithValue("@p_Lname", txtLastnm.Text)
                .Parameters.AddWithValue("@p_Fname", txtFirstnm.Text)
                .Parameters.AddWithValue("@p_mName", TxtMiddlenm.Text)
                .Parameters.AddWithValue("@p_gender", cmbGender.Text)
                .Parameters.AddWithValue("@p_Year", cmbYearlevel.Text)
                .Parameters.AddWithValue("@p_studentpic", studentPhotopath)
                .Parameters.AddWithValue("@p_status", "Un-Voted")

                .ExecuteNonQuery()
                MsgBox("Student added successfully!", vbInformation)
                txtStudentid.Clear()
                txtLastnm.Clear()
                txtFirstnm.Clear()
                TxtMiddlenm.Clear()
                txtStudentid.Focus()


            End With
        Catch ex As Exception
            MessageBox.Show("record Save Successfully", "Saving records", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Sub xbtn_Click(sender As Object, e As EventArgs) Handles xbtn.Click
        Me.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            sqlAdapter = New MySqlDataAdapter

            datatbl = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayStudentByFilter"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbFilter.Text)
                .Parameters.AddWithValue("@p_search", txtSearch.Text)
                sqlAdapter.SelectCommand = command
                datatbl.Clear()
                sqlAdapter.Fill(datatbl)
                lblTotalRecord.Text = "Total Records: " & datatbl.Rows.Count
                If datatbl.Rows.Count > 0 Then
                    DataGridView1.RowCount = datatbl.Rows.Count
                    row = 0
                    While Not datatbl.Rows.Count - 1 < row
                        DataGridView1.Rows(row).Cells(0).Value = datatbl.Rows(row).Item("id").ToString
                        DataGridView1.Rows(row).Cells(1).Value = datatbl.Rows(row).Item("StudentID").ToString
                        DataGridView1.Rows(row).Cells(2).Value = datatbl.Rows(row).Item("fullname").ToString
                        DataGridView1.Rows(row).Cells(3).Value = datatbl.Rows(row).Item("gender").ToString
                        DataGridView1.Rows(row).Cells(4).Value = datatbl.Rows(row).Item("Grade").ToString
                        DataGridView1.Rows(row).Cells(5).Value = datatbl.Rows(row).Item("Votingstatus").ToString

                        row = row + 1
                    End While

                Else
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK)
                End If


            End With

            sqlAdapter.Dispose()
            datatbl.Dispose()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub prcSearchStudentWithAutoComplete()
        Try
            sqlAdapter = New MySqlDataAdapter
            datatbl = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcSearchStudentWithAutoComplete"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbFilter.Text)
                .Parameters.AddWithValue("@p_search", txtSearch.Text)
                sqlAdapter.SelectCommand = command
                datatbl.Clear()
                sqlAdapter.Fill(datatbl)
                lblTotalRecord.Text = "Total Records: " & datatbl.Rows.Count
                If datatbl.Rows.Count > 0 Then
                    DataGridView1.RowCount = datatbl.Rows.Count
                    row = 0
                    While Not datatbl.Rows.Count - 1 < row
                        DataGridView1.Rows(row).Cells(0).Value = datatbl.Rows(row).Item("id").ToString
                        DataGridView1.Rows(row).Cells(1).Value = datatbl.Rows(row).Item("StudentID").ToString
                        DataGridView1.Rows(row).Cells(2).Value = datatbl.Rows(row).Item("fullname").ToString
                        DataGridView1.Rows(row).Cells(3).Value = datatbl.Rows(row).Item("gender").ToString
                        DataGridView1.Rows(row).Cells(4).Value = datatbl.Rows(row).Item("Grade").ToString
                        DataGridView1.Rows(row).Cells(5).Value = datatbl.Rows(row).Item("VotingStatus").ToString


                        row = row + 1
                    End While

                Else
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK)
                End If


            End With

            sqlAdapter.Dispose()
            datatbl.Dispose()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If chckAutoComplete.Checked = True Then
            prcSearchStudentWithAutoComplete()

        Else

        End If
    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Me.Dispose()

    End Sub

    Private Sub chckAutoComplete_CheckedChanged(sender As Object, e As EventArgs) Handles chckAutoComplete.CheckedChanged

    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        If cmbFilter.SelectedItem = "ALL" Then
            prcDisplayStudent()

        End If
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim confirmMSg = MessageBox.Show("Are you sure you want to delete this data?", "Delete document", MessageBoxButtons.YesNo)
        If confirmMSg = DialogResult.Yes Then
            Dim selected As DataGridViewRow
            selected = DataGridView1.Rows(e.RowIndex)
            Dim studentid As String = selected.Cells(1).Value

            With command
                .Parameters.Clear()
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prcDeleteStudent"
                .Parameters.AddWithValue("@p_id", studentid)
                .ExecuteNonQuery()
                connection.Close()
                MessageBox.Show("Successfully deleted")
                prcDisplayStudent()

            End With
        End If

    End Sub

End Class