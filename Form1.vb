Public Class Form1


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

            MsgBox("Thank you " & stFirstName & " " & stLastName & "!")

        End If



    End Sub


    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

End Class
