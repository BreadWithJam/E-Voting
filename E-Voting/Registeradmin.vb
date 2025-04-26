Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class Registeradmin
    Private Tripledes As New TripleDESCryptoServiceProvider
    Private Sub Registeradmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub

    Private Sub Buttonx_Click(sender As Object, e As EventArgs) Handles Buttonx.Click
        Me.Dispose()

    End Sub


    Public Function EncryptData(ByVal plaintext As String) As String
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)
        Dim ms As New System.IO.MemoryStream
        Dim EncSTream As New CryptoStream(ms, Tripledes.CreateEncryptor(),
System.Security.Cryptography.CryptoStreamMode.Write)
        EncSTream.Write(plaintextBytes, 0, plaintextBytes.Length)
        EncSTream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)

    End Function
    Private Sub btnregisteradmin_Click(sender As Object, e As EventArgs) Handles btnregisteradmin.Click

        If TextBox1.Text = String.Empty Then
            lblAdminpass.Text = "Password required!!"
            lblAdminpass.ForeColor = Color.Red
        Else

            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "prcAddAdmin"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_username", txtUsername.Text)
                    .Parameters.AddWithValue("@p_Lastname", txtLastname.Text)
                    .Parameters.AddWithValue("@p_Firstname", txtFirstname.Text)
                    .Parameters.AddWithValue("@p_Middlename", txtMiddlename.Text)
                    .Parameters.AddWithValue("@p_picture", studentPhotopath)
                    .Parameters.AddWithValue("@p_password", TextBox1.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Record saved successfully")
                txtUsername.Clear()
                txtLastname.Clear()
                txtFirstname.Clear()
                txtMiddlename.Clear()
                TextBox1.Clear()
                txtUsername.Focus()

            Catch ex As Exception
                MessageBox.Show("Something went wrong", "You're all set!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            With OpenFileDialog2
                .Title = "Select Photo"
                .FileName = ""
                If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Admindefault.Image = Image.FromFile(.FileName)
                    studentPhotopath = .FileName
                End If
            End With



        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class