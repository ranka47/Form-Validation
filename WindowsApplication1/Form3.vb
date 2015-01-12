Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Web

Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox2.Validating
        Dim pass As String
        pass = "^(?=.*?[A-Z])(?=(.*[a-z]){1,})(?=(.*[\d]){1,})(?=(.*[\W]){1,})(?!.*\s).{8,}$"
        If Regex.IsMatch(TextBox2.Text, pass) Then
            'MsgBox("Valid Email address ")
            Me.ErrorProvider2.SetError(Me.TextBox2, "")
            '  TextBox6.Text = LCase(TextBox6.Text)
        Else
            'MsgBox("Not a valid Email address ")
            Me.ErrorProvider2.SetError(Me.TextBox2, "Proper password is required")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged, TextBox3.Validating
        If (TextBox3.Text = TextBox3.Text) Then
            Me.ErrorProvider3.SetError(Me.TextBox3, "")
        Else
            Me.ErrorProvider3.SetError(Me.TextBox3, "Password not matching")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox3.Validating, TextBox3.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
