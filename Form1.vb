Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.Sql

Public Class Form1
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
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

        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stSubject = comSubject.SelectedItem
        stPeriod = comPeriod.SelectedItem
        stBus1 = comBus1.SelectedItem
        stBus2 = comBus2.SelectedItem

        Using conn As System.Data.SqlClient.SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("tps_write").ConnectionString())




        End Using

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
End Class
