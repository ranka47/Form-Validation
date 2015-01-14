Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim thisdate As Date
        thisdate = Now

        Dim mnth As Integer
        mnth = 0
        ComboBox1.Items.Add("MasterCard")
        ComboBox1.Items.Add("VISA")
        ComboBox1.Items.Add("American Express")
        ComboBox1.Items.Add("Diners Club")

        While (mnth < 13)
            ComboBox2.Items.Add(mnth)
            mnth = mnth + 1
        End While
        ComboBox2.SelectedIndex = 0
        ComboBox3.Items.Add("0000")

        Dim thisyear As Integer
        thisyear = Year(thisdate)
        While (thisyear < 2050)
            ComboBox3.Items.Add(thisyear)
            thisyear = thisyear + 1
        End While
        ComboBox3.SelectedIndex = 0

    End Sub
    Protected Function textbox1check() As Boolean
        If (IsNumeric(TextBox1.Text) And TextBox1.Text.Length = 16 And ErrorProvider4.GetError(TextBox1) = "") Then
            Me.ErrorProvider2.SetError(Me.TextBox1, "")
            Return True
        Else
            Me.ErrorProvider2.SetError(Me.TextBox1, "Invalid Card Number")
            Return False
        End If
    End Function

    Private Sub TextBox1_textchanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
        textbox1check()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim thisdate As Date
        thisdate = Now
        Dim thisyear As Integer
        Dim thismonth As Integer
        thismonth = ComboBox2.Text.Trim
        thisyear = ComboBox3.Text.Trim
        Dim flag As Integer
        flag = 1

        If (Not visa()) Then
            flag = 0
        End If
        If (Not textbox1check() Or Not ErrorProvider4.GetError(TextBox1) = "" Or Not combobox1check()) Then
            flag = 0
        End If

        If (thisyear < Year(thisdate) Or (thisyear = Year(thisdate) And thismonth < Month(thisdate))) Then
            Me.ErrorProvider3.SetError(Me.ComboBox3, "Your Card has Expired")
            flag = 0
        Else
            Me.ErrorProvider3.SetError(Me.ComboBox3, "")
        End If
        If flag = 1 Then
            'DEBUGGING FORM2, UNCOMMENT NEXT LINE AND COMMENT THE FOLLOWING TWO LINES
            'MessageBox.Show("yes")
            Form3.Show()
            Me.Close()
        End If

    End Sub

   




  
    'IMPORTANT
    'STRING.COMPARE RETURNS 0 WHEN THE STRINGS ARE EQUAL AS PER CONDITIONS PROVIDED; hardcoded due to lack of database table 
    Protected Function visa() As Boolean
        TextBox1.SelectionStart = (0)
        TextBox1.SelectionLength = (1)
        If TextBox1.SelectedText = "4" And String.Compare("visa", ComboBox1.Text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        Else
            Return masteramericandiners2()
        End If
    End Function
    Protected Function masteramericandiners2() As Boolean
        TextBox1.SelectionStart = (0)
        TextBox1.SelectionLength = (2)

        If TextBox1.SelectedText = "51" And String.Compare("mastercard", ComboBox1.Text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        ElseIf TextBox1.SelectedText = "52" And String.Compare("mastercard", ComboBox1.text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        ElseIf TextBox1.SelectedText = "53" And String.Compare("mastercard", ComboBox1.text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        ElseIf TextBox1.SelectedText = "54" And String.Compare("mastercard", ComboBox1.text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        ElseIf TextBox1.SelectedText = "55" And String.Compare("mastercard", ComboBox1.text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        ElseIf TextBox1.SelectedText = "34" And String.Compare("american express", ComboBox1.text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True

        ElseIf TextBox1.SelectedText = "37" And String.Compare("american express", ComboBox1.text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        ElseIf TextBox1.SelectedText = "36" And String.Compare("diners club", ComboBox1.text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        ElseIf TextBox1.SelectedText = "38" And String.Compare("diners club", ComboBox1.text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        Else
            Return diners3()
        End If
    End Function
    Protected Function diners3() As Boolean

        TextBox1.SelectionStart = (0)
        TextBox1.SelectionLength = (3)
        If TextBox1.SelectedText = "300" And String.Compare("diners club", ComboBox1.text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        ElseIf TextBox1.SelectedText = "301" And String.Compare("diners club", ComboBox1.text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        ElseIf TextBox1.SelectedText = "302" And String.Compare("diners club", ComboBox1.text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        ElseIf TextBox1.SelectedText = "303" And String.Compare("diners club", ComboBox1.text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        ElseIf TextBox1.SelectedText = "304" And String.Compare("diners club", ComboBox1.text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        ElseIf TextBox1.SelectedText = "305" And String.Compare("diners club", ComboBox1.text, True) = 0 Then
            Me.ErrorProvider4.SetError(Me.TextBox1, "")
            Return True
        Else
            Me.ErrorProvider4.SetError(Me.TextBox1, "Invalid Card Scheme")
            Return False
        End If
    End Function

    Protected Function combobox1check() As Boolean
        If ComboBox1.Text = "" Then
            Me.ErrorProvider1.SetError(Me.ComboBox1, "Choose the Card Scheme")
            Return False
        Else
            Me.ErrorProvider1.SetError(Me.ComboBox1, "")
            Return True
        End If
    End Function

    'To choose the card scheme
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        combobox1check()
    End Sub
End Class

'ISSUE
'cODE TRIED TO SHOW IMAGE OF THE CARD SCHEME IN PICTUREBOX1 IN FORM2; 
'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
'    Dim len As Integer = 10
'    Dim i As Integer = 0

'    Dim s As String

'    s = TextBox1.Text
'    If s <> Nothing Then

'        Dim answer As String

'        'answer = s.Substring(0, 1)
'        'If answer = "4" Then
'        If s.Substring(0, 1) = "4" Then
'            Dim id As String = "visa"
'            ' MessageBox.Show("visa")
'            Dim folder As String = "C:\Users\"
'            Dim filename As String = System.IO.Path.Combine(folder, id & ".jpg")
'            PictureBox1.Image = Image.FromFile(filename)
'            'Else
'            '    'answer = s.Substring(0, 2)
'            '    'If answer >= "51" And answer <= "55" Then
'            '    If s.Substring(0, 2) >= "51" And s.Substring(0, 2) <= "55" Then
'            '        MessageBox.Show("mastercard")
'            '        'Dim id As String = "visa"
'            '        'Dim folder As String = "\"
'            '        'Dim filename As String = System.IO.Path.Combine(folder, id & ".jpg")
'            '        'PictureBox1.Image = Image.FromFile(filename)

'            ' End If
'        End If
'    End If
'End Sub