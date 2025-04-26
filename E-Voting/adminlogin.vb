Imports MySql.Data.MySqlClient

Public Class adminlogin
    Dim Attempt As Integer = 0
    Private Sub adminlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If UsernameTextBox.Text = String.Empty Or PasswordTextBox.Text = String.Empty Then
            MsgBox("Missing required field")
        Else
            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "prcPass"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_username", UsernameTextBox.Text)
                    .Parameters.AddWithValue("@p_password", PasswordTextBox.Text)
                    sqlAdapter = New MySqlDataAdapter
                    datatbl = New DataTable
                    sqlAdapter.SelectCommand = command
                    sqlAdapter.Fill(datatbl)

                    If datatbl.Rows.Count > 0 Then
                        Me.Hide()
                        SystemMnagement.ShowDialog()
                    ElseIf Attempt = 3 Then
                        MsgBox("Maximum number of Attempts (3),Program will now close")
                        Me.Dispose()
                        SstudentLogin.Dispose()


                    Else
                        MsgBox("Password and username does not match,please re-enter,You currently have reached attempt " & Attempt & " of 3.")
                        Attempt = Attempt + 1
                        UsernameTextBox.Text = ""
                        PasswordTextBox.Text = ""
                        UsernameTextBox.Focus()
                    End If
                End With

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Hide()
        SstudentLogin.ShowDialog()
        Me.Close()
    End Sub

    Private Sub passwordbox_CheckedChanged(sender As Object, e As EventArgs) Handles passwordbox.CheckedChanged
        Dim passwordholder As String
        passwordholder = PasswordTextBox.Text.ToString
        If passwordbox.Checked = True Then
            PasswordTextBox.PasswordChar = ""
        Else
            PasswordTextBox.PasswordChar = "*"

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cancel.Click

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub
End Class
