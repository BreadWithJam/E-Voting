Imports Mysqlx.XDevAPI.Common

Public Class SystemMnagement
    Private Sub SystemMnagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


    Private Sub btbAddCandidate_Click(sender As Object, e As EventArgs) Handles btbAddCandidate.Click
        With Addcandidate
            .TopLevel = False
            Panel2.Controls.Add(Addcandidate)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnAddadmin_Click(sender As Object, e As EventArgs) Handles btnAddadmin.Click
        With Registeradmin
            .TopLevel = False
            Panel2.Controls.Add(Registeradmin)
            .BringToFront()
            .Show()

        End With

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        SstudentLogin.ShowDialog()


    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        With Students
            .TopLevel = False
            Panel2.Controls.Add(Students)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss:tt")
        lblDate.Text = Date.Now.ToString("ddd,yyyy-MM-dd")
    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        With Result
            .TopLevel = False
            Panel2.Controls.Add(Result)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With DeleteCandidate
            .TopLevel = False
            Panel2.Controls.Add(DeleteCandidate)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Deleteanadmin
            .TopLevel = False
            Panel2.Controls.Add(Deleteanadmin)
            .BringToFront()
            .Show()

        End With
    End Sub
End Class