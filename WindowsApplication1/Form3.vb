Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Web

'Generates random enrolment ID. First three letters come from the country you belong to.
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim letters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim letters As String = UCase(Form1.ComboBox1.Text)
        Dim count = 0
        Dim rand As New Random
        Dim strpos = ""
        While count < 3
            strpos = rand.Next(0, letters.Length)
            TextBox1.Text = TextBox1.Text & letters(strpos)
            count = count + 1
        End While
        Dim numbers As String = "0123456789"
        count = 0
        strpos = ""
        While count < 7
            strpos = rand.Next(0, numbers.Length)
            TextBox1.Text = TextBox1.Text & numbers(strpos)
            count = count + 1
        End While
        ComboBox3.Items.Add("Who was the first person you admired?")
        ComboBox3.Items.Add("Who was the first professor you thought would fail you puroposely?")
        ComboBox3.Items.Add("What was the least marks/least grade you ever scored?")
        ComboBox3.Items.Add("Which was the most wildest dream you ever had? Give some special feature about it.")
        ComboBox3.Items.Add("Where were you born?")
    End Sub
    Protected Function textbox2check() As Boolean
        Dim pass As String
        pass = "^(?=.*?[A-Z])(?=(.*[a-z]){1,})(?=(.*[\d]){1,})(?=(.*[\W]){1,})(?!.*\s).{8,}$"
        If Regex.IsMatch(TextBox2.Text, pass) Then
            Me.ErrorProvider2.SetError(Me.TextBox2, "")
            Return True
        Else
            Me.ErrorProvider2.SetError(Me.TextBox2, "Atleast one uppercase, lowercase, number and special character is required. Minimum length is 8")
            Return False
        End If
    End Function
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox2.Validating
        textbox2check()
    End Sub
    Protected Function textbox3check() As Boolean
        If (TextBox2.Text = TextBox3.Text) Then
            Me.ErrorProvider3.SetError(Me.TextBox3, "")
            Return True
        Else
            Me.ErrorProvider3.SetError(Me.TextBox3, "Password not matching")
            Return False
        End If
    End Function
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged, TextBox3.Validating
        textbox3check()
    End Sub
    Protected Function textbox4check() As Boolean
        If (TextBox4.Text = "" Or TextBox4.Text.Length < 4) Then
            Me.ErrorProvider4.SetError(Me.TextBox4, "Minimum length should be 4")
            Return False
        Else
            Me.ErrorProvider4.SetError(Me.TextBox4, "")
            Return True
        End If
    End Function
    Private Sub textbox4_textchanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged, TextBox4.Validating
        textbox4check()
    End Sub
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        textbox2check()
        textbox3check()
        textbox4check()
        Dim flag As Integer
        flag = 1
        If (ComboBox3.Text = "") Then
            flag = 0
            Me.ErrorProvider5.SetError(Me.ComboBox3, "Choose the security question for recovery of password")
        Else
            flag = 1
            Me.ErrorProvider5.SetError(Me.ComboBox3, "")
        End If

        If (ComboBox3.Text = "" Or Not ErrorProvider3.GetError(TextBox3) = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or Not ErrorProvider2.GetError(TextBox2) = "" Or TextBox4.Text = "" Or Not ErrorProvider4.GetError(TextBox4) = "") Then
            flag = 0
        Else
            MessageBox.Show("Thank you for applying. You will receive an email regarding the exam centre details. All the Best for the exam.")
            Form1.Close()
        End If
    End Sub
End Class
