Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient


Public Class Print
    Public Shared info As String

    Private Sub Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()

        Load_Result()

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Sub Load_Result()
        Try
            sqlAdapter = New MySqlDataAdapter
            datatbl = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcPrint"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_studid", SstudentLogin.txtStudentIDbox.Text)
                sqlAdapter.SelectCommand = command
                datatbl.Clear()
                sqlAdapter.Fill(datatbl)
                DataGridView1.DataSource = datatbl
                sqlAdapter.Update(datatbl)
            End With

        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pf As New PrintForm
        Dim crys As New CrystalReport4

        sqlAdapter = New MySqlDataAdapter
        datatbl = New DataTable
        Dim dgv As DataGridViewRow

        With command
            datatbl.Columns.Add("Candidate Name")
            datatbl.Columns.Add("Position")
            datatbl.Columns.Add("Grade")


            For Each dgv In DataGridView1.Rows
                datatbl.Rows.Add(dgv.Cells(0).Value, dgv.Cells(1).Value, dgv.Cells(2).Value)
            Next
            ds.Tables.Add(datatbl)
            ds.WriteXmlSchema("users.xml")


            crys.SetDataSource(ds)
            pf.CrystalReportViewer1.ReportSource = crys
            pf.CrystalReportViewer1.Refresh()
            pf.Show()


        End With





    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class