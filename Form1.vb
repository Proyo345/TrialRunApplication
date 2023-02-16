Imports System.Data.SqlClient


Public Class Form1

    Dim con As New SqlConnection


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFirstName.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblSubject.Click

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim stFirstName As String
        Dim stLastName As String
        Dim stSubject As String
        Dim stPeriod As String
        Dim stBus1 As String
        Dim stBus2 As String

        If txtFirstName.Text = "" Or txtLastName.Text = "" Or comSubject.SelectedItem = "" Or comPeriod.SelectedItem = "" Or comBus1.SelectedItem = "" Or comBus2.SelectedItem = "" Then

            MsgBox("Please fill out all required areas!")

        Else

            stFirstName = txtFirstName.Text
            stLastName = txtLastName.Text
            stSubject = comSubject.SelectedItem
            stPeriod = comPeriod.SelectedItem
            stBus1 = comBus1.SelectedItem
            stBus2 = comBus2.SelectedItem

            con.Open()

            Dim cmd As New SqlCommand("Insert Into StudentInfo Values"("'stFirstName'" & "," & "'stlastname'" & "," & "'Subject'" & "," & "'Period'" & "," & "'Bus1'" & "," & "'Bus2'"))



            cmd.ExecuteNonQuery()

            con.Close()

            MsgBox("Thank you " & stFirstName & " " & stLastName & "!")

            txtFirstName.Clear()
            txtLastName.Clear()
            comBus1.Items.Clear()
            comBus2.Items.Clear()
            comPeriod.Items.Clear()
            comSubject.Items.Clear()



        End If



    End Sub


    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=DESKTOP-L8RLKNM\SQLEXPRESS;Initial Catalog=TrialRun;Integrated Security=True"

    End Sub
    Private Sub txtFirstName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSubject.SelectedIndexChanged

    End Sub
    Private Sub txtLastName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSubject.SelectedIndexChanged

    End Sub
    Private Sub comSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSubject.SelectedIndexChanged

    End Sub
    Private Sub comPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSubject.SelectedIndexChanged

    End Sub
    Private Sub comBus1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSubject.SelectedIndexChanged

    End Sub
    Private Sub comBus2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSubject.SelectedIndexChanged

    End Sub
End Class