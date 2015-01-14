Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Web


Public Class Form1
    Dim h_1 As Integer
    Dim w_1 As Integer
    Dim count As Integer
    Dim info As Integer

    Dim attempt As Integer = 0



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Australia")
        ComboBox1.Items.Add("Canada")
        ComboBox1.Items.Add("China")
        ComboBox1.Items.Add("India")
        ComboBox1.Items.Add("USA")
        PictureBox2.Image = generateImage()
        ErrorProvider1.BlinkRate = 0
        ErrorProvider2.BlinkRate = 0
        ErrorProvider3.BlinkRate = 0
        ErrorProvider10.BlinkRate = 0
        ErrorProvider11.BlinkRate = 0
        ErrorProvider4.BlinkRate = 0
        ErrorProvider5.BlinkRate = 0
        ErrorProvider6.BlinkRate = 0
        ErrorProvider7.BlinkRate = 0
        ErrorProvider8.BlinkRate = 0
        ErrorProvider9.BlinkRate = 0
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim control As Control
        'For Each control In Controls
        '    ' Set focus on control
        '    control.Focus()
        '    ' Validate causes the control's Validating event to be fired,
        '    '  If CausesValidation Is True Then
        '    If (Validate() = False) Then
        '        DialogResult = DialogResult.None

        '        Return

        '    End If
        'Next

        If (attempt = 3) Then
            MessageBox.Show("No. of attempts exceeded")
            Me.Close()
        End If
        Dim flag As Integer
        flag = 1
        If (ComboBox1.Text = "") Then
            Me.ErrorProvider8.SetError(Me.ComboBox1, "Select one country from the list")
            flag = 0
        Else
            Me.ErrorProvider8.SetError(Me.ComboBox1, "")
            flag = 1
        End If
        If (ComboBox2.Text = "") Then
            Me.ErrorProvider9.SetError(Me.ComboBox2, "Select one state/province from the list")
            flag = 0
        Else
            Me.ErrorProvider9.SetError(Me.ComboBox2, "")
            flag = 1
        End If
        If (ComboBox3.Text = "") Then
            Me.ErrorProvider10.SetError(Me.ComboBox3, "Select one city from the list")
            flag = 0
        Else
            Me.ErrorProvider10.SetError(Me.ComboBox3, "")
            flag = 1
        End If
        If (CheckBox1.Checked = False Or Not ErrorProvider7.GetError(CheckBox1) = "") Then
            Me.ErrorProvider7.SetError(Me.CheckBox1, "You must agree with our policy")
            flag = 0
        End If
        If (Not checkage()) Then
            flag = 0
       
        End If
        If (TextBox1.Text = "" Or Not ErrorProvider11.GetError(TextBox1) = "") Then
            ErrorProvider11.SetError(TextBox1, "Incorrect captcha typed , refresh if not properly visible")
            flag = 0
        End If
        If (TextBox2.Text = "" Or Not ErrorProvider1.GetError(TextBox2) = "") Then
            Me.ErrorProvider1.SetError(Me.TextBox2, "Proper Name is required")
            flag = 0
        End If
        If (TextBox4.Text = "" Or Not ErrorProvider2.GetError(TextBox4) = "") Then
            Me.ErrorProvider2.SetError(Me.TextBox4, "Proper Institute name is required")
            flag = 0
        End If
        If (PictureBox1.Image Is Nothing Or Not ErrorProvider5.GetError(PictureBox1) = "") Then
            Me.ErrorProvider5.SetError(Me.PictureBox1, "Image is required")
            flag = 0
        End If
        If (TextBox6.Text = "" Or Not ErrorProvider3.GetError(TextBox6) = "") Then
            Me.ErrorProvider3.SetError(Me.TextBox6, "Proper email address is required")
            flag = 0
        End If
        If (mobile.Text = "" Or Not ErrorProvider6.GetError(mobile) = "") Then
            Me.ErrorProvider6.SetError(Me.mobile, "The number you are dialling does not exist")
            flag = 0
        End If
        'This flag is very dangerous to uncomment
        flag = 1
        If (flag = 0) Then
            MessageBox.Show("You lost an attempt. Try Again and you have limited number of attempts.")
            attempt = attempt + 1
        Else
            Form2.Show()
        End If
    End Sub
  

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox2.Validating

        Dim c As String
        c = "^[a-zA-Z ]+$"
        ErrorProvider1.BlinkRate = 250
        If (Regex.IsMatch(TextBox2.Text, c)) Then
            Me.ErrorProvider1.SetError(Me.TextBox2, "")
        Else
            Me.ErrorProvider1.SetError(Me.TextBox2, "Proper Name is required")
        End If

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged, TextBox4.Validating
       
        Dim c As String
        c = "^[a-zA-Z ]+$"
        ErrorProvider2.BlinkRate = 250
        If (Regex.IsMatch(TextBox4.Text, c)) Then
            Me.ErrorProvider2.SetError(Me.TextBox4, "")
        Else
            Me.ErrorProvider2.SetError(Me.TextBox4, "Proper Institute name is required")
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged, TextBox6.Validating
        Dim pattern As String
        pattern = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        ErrorProvider3.BlinkRate = 250
        If (Regex.IsMatch(TextBox6.Text, pattern)) Then
            'MsgBox("Valid Email address ")
            Me.ErrorProvider3.SetError(Me.TextBox6, "")
            TextBox6.Text = LCase(TextBox6.Text)
        Else
            'MsgBox("Not a valid Email address ")
            Me.ErrorProvider3.SetError(Me.TextBox6, "Proper email address is required")


        End If
    End Sub
    Protected Function checkage() As Boolean
        Dim chosenvalue As Date
        chosenvalue = DateTimePicker1.Value
        ErrorProvider4.BlinkRate = 250
        If (chosenvalue > Date.Now.AddYears(-18)) Then
            Me.ErrorProvider4.SetError(Me.DateTimePicker1, "You are too young, buddy")
            Return False
        ElseIf (chosenvalue < Date.Now.AddYears(-21)) Then
            Me.ErrorProvider4.SetError(Me.DateTimePicker1, "Sorry, you have crossed the age limit")
            Return False
        Else
            Me.ErrorProvider4.SetError(Me.DateTimePicker1, "")
            Return True
        End If
    End Function
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        checkage()
    End Sub
    Protected Function ValidateImageSize() As Boolean
        Dim fileSize As Integer = info
        'limit size to approx 2MB and atleast 0.5MB  for image
        ErrorProvider5.BlinkRate = 250
        If (info > 500000 And info < 2097152) Then
            count = 1
            Me.ErrorProvider5.SetError(Me.PictureBox1, "")
            Return True
        ElseIf (info > 2097152) Then
            Me.ErrorProvider5.SetError(Me.PictureBox1, "Image must be of size < 2MB")
            Return False
        Else
            Me.ErrorProvider5.SetError(Me.PictureBox1, "Image is too small. Must be of > 0.5MB")
            Return False
        End If
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        count = 0
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then



            Dim infoReader As System.IO.FileInfo
            infoReader = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName)
            'Console.WriteLine(infoReader.Length)

            info = infoReader.Length
            'Console.WriteLine(info)
            ValidateImageSize()
            'If count = 1 Then
            '    h_1 = Image.FromFile(OpenFileDialog1.FileName).Height
            '    w_1 = Image.FromFile(OpenFileDialog1.FileName).Width
            '    If (h_1 > 100 And h_1 < 123 And w_1 > 130 And w_1 < 158) Then
            '        count = 1
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            'PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            '        'Console.WriteLine(PictureBox1.Height)
            '        'Console.WriteLine(PictureBox1.Width)
            '    Else

            '        MessageBox.Show("Please upload an Image of approx. 9:16 ratio")
            'Else
            '    Me.ErrorProvider5.SetError(Me.PictureBox1, "correct height( >100 and <123) and width (>130 and <158) is required")

            'End If



        End If



        '        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "India" Then
            Me.isd.Text = "+91"
            Me.mobile.MaxLength = "10"
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Andhra Pradesh")
            ComboBox2.Items.Add("Assam")
            ComboBox2.Items.Add("Madhya Pradesh")
            ComboBox2.Items.Add("Maharashtra")
            ComboBox2.Items.Add("Rajasthan")

        ElseIf ComboBox1.Text = "USA" Then
            Me.isd.Text = "+1"
            Me.mobile.MaxLength = "10"
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Alabama")
            ComboBox2.Items.Add("Colorado")
            ComboBox2.Items.Add("Delaware")
            ComboBox2.Items.Add("Florida")
            ComboBox2.Items.Add("Georgia")

        ElseIf ComboBox1.Text = "Canada" Then
            Me.isd.Text = "+1"
            Me.mobile.MaxLength = "10"
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Alberta")
            ComboBox2.Items.Add("British Columbia")
            ComboBox2.Items.Add("Manitoba")
            ComboBox2.Items.Add("Nova Scotia")
            ComboBox2.Items.Add("Ontario")

        ElseIf ComboBox1.Text = "China" Then
            Me.isd.Text = "+86"
            Me.mobile.MaxLength = "11"
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Anhui")
            ComboBox2.Items.Add("Hainan")
            ComboBox2.Items.Add("Jiangsu")
            ComboBox2.Items.Add("Shandong")
            ComboBox2.Items.Add("Taiwan")

        ElseIf ComboBox1.Text = "Australia" Then
            Me.isd.Text = "+61"
            Me.mobile.MaxLength = "9"
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("New South Wales")
            ComboBox2.Items.Add("Queensland")
            ComboBox2.Items.Add("South Australia")
            ComboBox2.Items.Add("Tasmania")
            ComboBox2.Items.Add("Victoria")
        Else
            ComboBox2.Items.Add("")
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Assam" Then
            ' Me.TextBox4.Text = "+91"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Chirang")
            ComboBox3.Items.Add("Dibrugarh")
            ComboBox3.Items.Add("Guwahati")
            ComboBox3.Items.Add("Nalbari")
            ComboBox3.Items.Add("Sivasagar")
          
        ElseIf ComboBox2.Text = "Rajasthan" Then
            'Me.TextBox4.Text = "+1"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Ajmer")
            ComboBox3.Items.Add("Beawer")
            ComboBox3.Items.Add("Jaipur")
            ComboBox3.Items.Add("Kota")
            ComboBox3.Items.Add("Udaipur")
          
        ElseIf ComboBox2.Text = "Maharashtra" Then
            'Me.TextBox4.Text = "+1"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Ahmednagar")
            ComboBox3.Items.Add("Bhiwandi")
            ComboBox3.Items.Add("Dhule")
            ComboBox3.Items.Add("Navi-Mumbai")
            ComboBox3.Items.Add("Thane")
        
        ElseIf ComboBox2.Text = "Madhya Pradesh" Then
            'Me.TextBox4.Text = "+86"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Bhind")
            ComboBox3.Items.Add("Bhopal")
            ComboBox3.Items.Add("Indore")
            ComboBox3.Items.Add("Sagar")
            ComboBox3.Items.Add("Ujjain")
           
        ElseIf ComboBox2.Text = "Andhra Pradesh" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Bhimavaran")
            ComboBox3.Items.Add("Chittoor")
            ComboBox3.Items.Add("Guntur")
            ComboBox3.Items.Add("Nandyal")
            ComboBox3.Items.Add("Visakhapatnam")
      
        ElseIf ComboBox2.Text = "Alabama" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Anniston")
            ComboBox3.Items.Add("Baileyton")
            ComboBox3.Items.Add("Columbiana")
            ComboBox3.Items.Add("Decatur")
            ComboBox3.Items.Add("Elba")
        ElseIf ComboBox2.Text = "Colorado" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Aurora")
            ComboBox3.Items.Add("Durango")
            ComboBox3.Items.Add("Estes Park")
            ComboBox3.Items.Add("Fort Collins")
            ComboBox3.Items.Add("Pueblo")
        ElseIf ComboBox2.Text = "Georgia" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Atlanta")
            ComboBox3.Items.Add("Gainesville")
            ComboBox3.Items.Add("Helen")
            ComboBox3.Items.Add("Kennesaw")
            ComboBox3.Items.Add("Roswell")
        ElseIf ComboBox2.Text = "Delaware" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Dover")
            ComboBox3.Items.Add("Georgetown")
            ComboBox3.Items.Add("Laurel")
            ComboBox3.Items.Add("Ocean")
            ComboBox3.Items.Add("Seaford")
        ElseIf ComboBox2.Text = "Florida" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Jacksonville")
            ComboBox3.Items.Add("Naples")
            ComboBox3.Items.Add("Orlando")
            ComboBox3.Items.Add("St.Petersburg")
            ComboBox3.Items.Add("Tampa")
        ElseIf ComboBox2.Text = "Hainan" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Danzhou")
            ComboBox3.Items.Add("Haikou")
            ComboBox3.Items.Add("Sanya")
            ComboBox3.Items.Add("Wanning")
            ComboBox3.Items.Add("Wuzhishan City")
        ElseIf ComboBox2.Text = "Jiangsu" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Changzhou")
            ComboBox3.Items.Add("Nantong")
            ComboBox3.Items.Add("Taizhou")
            ComboBox3.Items.Add("Wuxi")
            ComboBox3.Items.Add("Zhenjiang")
        ElseIf ComboBox2.Text = "Anhui" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Bengbu")
            ComboBox3.Items.Add("Chuzhou")
            ComboBox3.Items.Add("Fuyang")
            ComboBox3.Items.Add("Wuhu")
            ComboBox3.Items.Add("Xuancheng")
        ElseIf ComboBox2.Text = "Shandong" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Heze")
            ComboBox3.Items.Add("Jinan")
            ComboBox3.Items.Add("Qufu")
            ComboBox3.Items.Add("Weifang")
            ComboBox3.Items.Add("Zibo")
        ElseIf ComboBox2.Text = "Taiwan" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Changhua")
            ComboBox3.Items.Add("Douliu")
            ComboBox3.Items.Add("Magong")
            ComboBox3.Items.Add("Puzi")
            ComboBox3.Items.Add("Taipei")
        ElseIf ComboBox2.Text = "Alberta" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Fort McMurray")
            ComboBox3.Items.Add("Grande Prairie")
            ComboBox3.Items.Add("Lethbridge")
            ComboBox3.Items.Add("Medicine Hat")
            ComboBox3.Items.Add("Red Deer")
        ElseIf ComboBox2.Text = "British Columbia" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Armstrong")
            ComboBox3.Items.Add("Duncan")
            ComboBox3.Items.Add("Fernie")
            ComboBox3.Items.Add("Grand Forks")
            ComboBox3.Items.Add("Greenwood")
        ElseIf ComboBox2.Text = "Manitoba" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Brandon")
            ComboBox3.Items.Add("Dauphin")
            ComboBox3.Items.Add("Morden")
            ComboBox3.Items.Add("Selkirk")
            ComboBox3.Items.Add("Thompson")
        ElseIf ComboBox2.Text = "Nova Scotia" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Antigonish")
            ComboBox3.Items.Add("Berwick")
            ComboBox3.Items.Add("Lockeport")
            ComboBox3.Items.Add("Oxford")
            ComboBox3.Items.Add("Shelburne")
        ElseIf ComboBox2.Text = "Ontario" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Brampton")
            ComboBox3.Items.Add("Kitchener")
            ComboBox3.Items.Add("Mississauga")
            ComboBox3.Items.Add("Ottawa")
            ComboBox3.Items.Add("Toronto")
        ElseIf ComboBox2.Text = "New South Wales" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Dubbo")
            ComboBox3.Items.Add("Grafton")
            ComboBox3.Items.Add("griffith")
            ComboBox3.Items.Add("Maitland")
            ComboBox3.Items.Add("Parramatta")
        ElseIf ComboBox2.Text = "Queensland" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Brisbane")
            ComboBox3.Items.Add("Cairns")
            ComboBox3.Items.Add("Gold Coast")
            ComboBox3.Items.Add("Logan city")
            ComboBox3.Items.Add("Mackay")
        ElseIf ComboBox2.Text = "South Australia" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Avenue Range")
            ComboBox3.Items.Add("Boston")
            ComboBox3.Items.Add("Clinton")
            ComboBox3.Items.Add("Galga")
            ComboBox3.Items.Add("Halidon")
        ElseIf ComboBox2.Text = "Victoria" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Ararat")
            ComboBox3.Items.Add("Bendigo")
            ComboBox3.Items.Add("Geelong")
            ComboBox3.Items.Add("Melbourne")
            ComboBox3.Items.Add("Mildura")
        ElseIf ComboBox2.Text = "Tasmania" Then
            'Me.TextBox4.Text = "+61"
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Burnie")
            ComboBox3.Items.Add("Clarence")
            ComboBox3.Items.Add("Devonport")
            ComboBox3.Items.Add("City of Glenorchy")
            ComboBox3.Items.Add("Hobart")
        Else
            ComboBox3.Items.Add("")
        End If


    End Sub
    Private Captcha As String
    'Dim Captcha As String

    Private Function genQuestion() As String
       
        Captcha = GenerateRandomString(6)
        Return String.Format(Captcha)
    End Function

    Private Sub generateLines(ByVal G As Graphics)
        If Not G Is Nothing Then
            Dim R As New Random()
            Dim lineBrush As New SolidBrush(Color.LightGray)

            For i% = 0 To 9
                G.DrawLines(New Pen(lineBrush, R.Next(1, 2)), New Point() {New Point(0, R.Next(0, 60)), New Point(204, R.Next(0, 100))})

            Next
        End If
    End Sub

    Private Function generateImage() As Image
        Dim B As New Bitmap(204, 100)
        Using G As Graphics = Graphics.FromImage(B)
            With G
                .Clear(Color.White)
                .DrawString(genQuestion(), New Font("Segoe UI", 20), Brushes.Black, New Rectangle(0, 0, 204, 100), New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            End With
            generateLines(G)
        End Using
        Return B
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox1.Validating
        ErrorProvider11.BlinkRate = 250
        Select Case TextBox1.Text
            Case Is = Captcha
                ErrorProvider11.SetError(TextBox1, "")


            Case Else
                ErrorProvider11.SetError(TextBox1, "Incorrect captcha typed, refresh if not properly visible")

        End Select

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox2.Image = generateImage()
    End Sub

    
    Public Function GenerateRandomString(ByRef lenStr As Integer, Optional ByVal upper As Boolean = False) As String
        'use
        'TextBox1.Text = GenerateRandomString(18)
        Dim rand As New Random()
        Dim allowableChars() As Char = _
               "abcdefghighlmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim final As New System.Text.StringBuilder
        Do
            'final += allowableChars(rand.Next(allowableChars.Length - 1))
            final.Append(allowableChars(rand.Next(0, allowableChars.Length)))
        Loop Until final.Length = lenStr
        Debug.WriteLine(final.Length)
        Return If(upper, final.ToString.ToUpper(), final.ToString)
    End Function



    Private Sub mobile_TextChanged(sender As Object, e As EventArgs) Handles mobile.TextChanged
        ErrorProvider6.BlinkRate = 250
        If (IsNumeric(mobile.Text) And mobile.Text.Length = mobile.MaxLength) Then
            Me.ErrorProvider6.SetError(Me.mobile, "")
        ElseIf (Not IsNumeric(mobile.Text) Or mobile.Text = "" Or mobile.Text.Length < mobile.MaxLength) Then
            Me.ErrorProvider6.SetError(Me.mobile, "The number you are dialling does not exist")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ErrorProvider7.BlinkRate = 250
        If CheckBox1.Checked = True Then
            Me.ErrorProvider7.SetError(Me.CheckBox1, "")
        Else
            Me.ErrorProvider7.SetError(Me.CheckBox1, "You must agree with our policy")
        End If
    End Sub

  
End Class

