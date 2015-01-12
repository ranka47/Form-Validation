Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Web
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim control As Control
        For Each control In Controls
            ' Set focus on control
            control.Focus()
            ' Validate causes the control's Validating event to be fired,
            '  If CausesValidation Is True Then
            If (Validate() = False) Then
                DialogResult = DialogResult.None
                Return
            End If
        Next
        'My.Settings.username = TextBox1.Text

        'My.Settings.password = LCase(TextBox2.Text)
        My.Settings.Save()
        '  MsgBox("create form", MsgBoxStyle.Information, "create")

        Form2.Show()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.Validating, TextBox2.TextChanged

        Dim c As String
        c = "^[a-zA-Z]+$"
        If (Regex.IsMatch(TextBox2.Text, c)) Then
            Me.ErrorProvider1.SetError(Me.TextBox2, "")
        Else
            Me.ErrorProvider1.SetError(Me.TextBox2, "Proper Name is required")
        End If

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged, TextBox4.Validating
        'If (Me.TextBox4.Text = "" Or IsalphaNumeric(Me.TextBox4.Text)) Then
        '    Me.ErrorProvider1.SetError(Me.TextBox4, "Institute name is required")
        '    'e.Cancel = True
        '    'TextBox4.Enabled = False
        '    Return
        'Else
        '    Me.ErrorProvider1.SetError(Me.TextBox4, "")
        '    'TextBox2.Enabled = True
        'End If
        Dim c As String
        c = "^[a-zA-Z]+$"
        If (Regex.IsMatch(TextBox4.Text, c)) Then
            Me.ErrorProvider2.SetError(Me.TextBox4, "")
        Else
            Me.ErrorProvider2.SetError(Me.TextBox4, "Proper Institute name is required")
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged, TextBox6.Validating
        Dim pattern As String
        'pattern = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$ " '+ ^(?=.*?[A-Z])(?=(.*[a-z]){1,})(?=(.*[\d]){1,})(?=(.*[\W]){1,})(?!.*\s).{8,}$"
        pattern = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If (Regex.IsMatch(TextBox6.Text, pattern)) Then
            'MsgBox("Valid Email address ")
            Me.ErrorProvider3.SetError(Me.TextBox6, "")
            '  TextBox6.Text = LCase(TextBox6.Text)
        Else
            'MsgBox("Not a valid Email address ")
            Me.ErrorProvider3.SetError(Me.TextBox6, "Proper email address is required")


        End If
    End Sub
End Class
