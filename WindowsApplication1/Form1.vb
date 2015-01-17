'Importing classes for regular expressions, drawing, drawing.imaging, .web
Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Web


Public Class Form1
    Dim h_1 As Integer 'Height og the Image
    Dim w_1 As Integer 'Width of the Image
    Dim count As Integer
    Dim info As Integer

    Dim attempt As Integer = 0


    'Values of Combobox1.items.add(countries) when form gets loaded and generation of captcha image in picturebox2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Australia")
        ComboBox1.Items.Add("Canada")
        ComboBox1.Items.Add("China")
        ComboBox1.Items.Add("India")
        ComboBox1.Items.Add("USA")
        PictureBox2.Image = generateImage()
    End Sub

    'On button1click (next button) message to show number of attempts, flag declaration and init to 1 to check the errors
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        If (attempt = 3) Then        'Checks the number of attempts
            MessageBox.Show("No. of attempts exceeded , You have to wait for next 10 seconds for making changes")
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox6.Enabled = False
            mobile.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            DateTimePicker1.Enabled = False
            CheckBox1.Enabled = False
            Timer1.Start()
            'Me.Close()
        End If
        Dim flag As Integer
        flag = 1
        If (ComboBox1.Text = "") Then
            Me.ErrorProvider8.SetError(Me.ComboBox1, "Select one country from the list")
            flag = 0
        Else
            Me.ErrorProvider8.SetError(Me.ComboBox1, "")

        End If
        If (ComboBox2.Text = "") Then
            Me.ErrorProvider9.SetError(Me.ComboBox2, "Select one state/province from the list")
            flag = 0
        Else
            Me.ErrorProvider9.SetError(Me.ComboBox2, "")

        End If
        If (ComboBox3.Text = "") Then
            Me.ErrorProvider10.SetError(Me.ComboBox3, "Select one city from the list")
            flag = 0
        Else
            Me.ErrorProvider10.SetError(Me.ComboBox3, "")

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
        If (TextBox3.Text = "" Or Not ErrorProvider12.GetError(TextBox6) = "") Then
            Me.ErrorProvider12.SetError(Me.TextBox3, "Email Address not matching")
            flag = 0
        End If
        If (TextBox6.Text = "" Or Not ErrorProvider3.GetError(TextBox6) = "") Then
            Me.ErrorProvider3.SetError(Me.TextBox6, "Proper email address is required")
            flag = 0
        End If
        If (mobile.Text = "" Or Not ErrorProvider6.GetError(mobile) = "" Or Not mobile.Text.Length = mobile.MaxLength) Then
            Me.ErrorProvider6.SetError(Me.mobile, "The number you are dialling does not exist")
            flag = 0
        End If
        'This flag is very dangerous to uncomment DEBUGGING LINE
        'flag = 1
        If (flag = 0 And attempt < 3) Then
            MessageBox.Show("You lost an attempt. Try Again and you have limited number of attempts.")
            attempt = attempt + 1
        ElseIf (flag = 1) Then
            Form2.Show()
        End If
    End Sub
  
    'Textbox2 -- NAME on textchanged and validating (errorprovider1), used regex to match alphabets and space \ "^[a-zA-Z ]+$" \
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox2.Validating

        Dim c As String
        c = "^[a-zA-Z ]+$"
        If (Regex.IsMatch(TextBox2.Text, c) And TextBox2.Text.Length >= 2) Then
            Me.ErrorProvider1.SetError(Me.TextBox2, "")
        ElseIf (TextBox2.Text.Length < 2 And Regex.IsMatch(TextBox2.Text, c)) Then
            Me.ErrorProvider1.SetError(Me.TextBox2, "Minimum length of Name should be 2")
        ElseIf (TextBox2.Text.Length < 2 And Not Regex.IsMatch(TextBox2.Text, c)) Then
            Me.ErrorProvider1.SetError(Me.TextBox2, "Proper name with minimum length 2 is required")
        Else
            Me.ErrorProvider1.SetError(Me.TextBox2, "Proper name is required")
        End If

    End Sub
    'Textbox4 -- INSTITUTE on textchanged and validating (errorprovider2), used regex to match alphabets and space \ "^[a-zA-Z ]+$" \
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged, TextBox4.Validating
       
        Dim c As String
        c = "^[a-zA-Z., ]+$"
        If (Regex.IsMatch(TextBox4.Text, c) And TextBox4.Text.Length >= 2) Then
            Me.ErrorProvider2.SetError(Me.TextBox4, "")
        ElseIf (TextBox4.Text.Length < 2 And Regex.IsMatch(TextBox4.Text, c)) Then
            Me.ErrorProvider2.SetError(Me.TextBox4, "Minimum length of Institute Name should be 2")
        ElseIf (TextBox4.Text.Length < 2 And Not Regex.IsMatch(TextBox4.Text, c)) Then
            Me.ErrorProvider2.SetError(Me.TextBox4, "Proper Institute name with minimum length 2 is required")
        Else
            Me.ErrorProvider2.SetError(Me.TextBox4, "Proper Institute name is required")
        End If
    End Sub
    Protected Function checkmail() As Boolean


        Dim pattern As String
        pattern = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If (Regex.IsMatch(TextBox6.Text, pattern)) Then
            'MsgBox("Valid Email address ")
            Me.ErrorProvider3.SetError(Me.TextBox6, "")
            TextBox6.Text = LCase(TextBox6.Text)
        Else
            'MsgBox("Not a valid Email address ")
            Me.ErrorProvider3.SetError(Me.TextBox6, "Proper email address is required")
        End If
        'Textbox6 -- EMAIL on textchanged and validating (errorprovider3), used regex to match alphabets and space \ "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$" \
    End Function
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged, TextBox6.Validating
        checkmail()
    End Sub

    'Protected function to check the age through DOB; date.now.addyears changes the value of year in the date of variable
    Protected Function checkage() As Boolean
        Dim chosenvalue As Date
        chosenvalue = DateTimePicker1.Value
        If (chosenvalue > Date.Now.AddYears(-18) And Year(chosenvalue) <= Year(Now)) Then
            Me.ErrorProvider4.SetError(Me.DateTimePicker1, "You are too young, buddy")
            Return False
        ElseIf (chosenvalue < Date.Now.AddYears(-21)) Then
            Me.ErrorProvider4.SetError(Me.DateTimePicker1, "Sorry, you have crossed the age limit")
            Return False
        ElseIf (Year(chosenvalue) > Year(Now)) Then
            Me.ErrorProvider4.SetError(Me.DateTimePicker1, "Oh! You haven't born yet. Sorry")
            Return False
        Else
            Me.ErrorProvider4.SetError(Me.DateTimePicker1, "")
            Return True
        End If
    End Function

    'On valuechange calls checkage() function to validate
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        checkage()
    End Sub

    'protected function to validate the image size; takes <info> variable from button3 sub. Called by Button3
    Protected Function ValidateImageSize() As Boolean
        Dim fileSize As Integer = info
        'limit size to approx 2MB and atleast 0.5MB  for image
        If (info > 5000 And info < 2097152) Then
            count = 1
            Me.ErrorProvider5.SetError(Me.PictureBox1, "")
            Return True
        ElseIf (info > 2097152) Then
            Me.ErrorProvider5.SetError(Me.PictureBox1, "Image must be of size < 2MB")
            Return False
        Else
            Me.ErrorProvider5.SetError(Me.PictureBox1, "Image is too small. Must be of > 5KB")
            Return False
        End If
    End Function

    'Button3 on click uploads picture, declared variable as <new openfiledialog>, filters <Picture Files (*)|*.bmp;*.gif;*.jpg>
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
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    ' IMPORTANT Hardcoded for the hierarchy of Country, State, City due to lack of Database Tables 
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "" Then
            Me.ErrorProvider8.SetError(Me.ComboBox1, "Please select the country")
        Else
            Me.ErrorProvider8.SetError(Me.ComboBox1, "")
        End If
        If ComboBox1.Text = "India" Then
            Me.isd.Text = "+91"
            Me.mobile.MaxLength = "10"
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()
            ComboBox2.Items.Add("Andhra Pradesh")
            ComboBox2.Items.Add("Assam")
            ComboBox2.Items.Add("Madhya Pradesh")
            ComboBox2.Items.Add("Maharashtra")
            ComboBox2.Items.Add("Rajasthan")

        ElseIf ComboBox1.Text = "USA" Then
            Me.isd.Text = "+1"
            Me.mobile.MaxLength = "10"
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()
            ComboBox2.Items.Add("Alabama")
            ComboBox2.Items.Add("Colorado")
            ComboBox2.Items.Add("Delaware")
            ComboBox2.Items.Add("Florida")
            ComboBox2.Items.Add("Georgia")

        ElseIf ComboBox1.Text = "Canada" Then
            Me.isd.Text = "+1"
            Me.mobile.MaxLength = "10"
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()
            ComboBox2.Items.Add("Alberta")
            ComboBox2.Items.Add("British Columbia")
            ComboBox2.Items.Add("Manitoba")
            ComboBox2.Items.Add("Nova Scotia")
            ComboBox2.Items.Add("Ontario")

        ElseIf ComboBox1.Text = "China" Then
            Me.isd.Text = "+86"
            Me.mobile.MaxLength = "11"
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()
            ComboBox2.Items.Add("Anhui")
            ComboBox2.Items.Add("Hainan")
            ComboBox2.Items.Add("Jiangsu")
            ComboBox2.Items.Add("Shandong")
            ComboBox2.Items.Add("Taiwan")

        ElseIf ComboBox1.Text = "Australia" Then
            Me.isd.Text = "+61"
            Me.mobile.MaxLength = "9"
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()
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
        If ComboBox2.Text = "" Then
            Me.ErrorProvider9.SetError(Me.ComboBox2, "Please select the state/province")
        Else
            Me.ErrorProvider9.SetError(Me.ComboBox2, "")
        End If
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

    'Source Code taken from "https://www.dropbox.com/s/9190ys3wgt9jt2/Simple%20Captcha%20Application.rar" ;Changes in source code: <to fit into the size; to have alphanumeric as captcha>
    Private Captcha As String
    Private Function genQuestion() As String

        Captcha = GenerateRandomString(6)
        Return String.Format(Captcha)
    End Function

    'Generates lines in the captcha, called by generateimage()
    Private Sub generateLines(ByVal G As Graphics)
        If Not G Is Nothing Then
            Dim R As New Random()
            Dim lineBrush As New SolidBrush(Color.LightGray)

            For i% = 0 To 9
                G.DrawLines(New Pen(lineBrush, R.Next(1, 2)), New Point() {New Point(0, R.Next(0, 60)), New Point(204, R.Next(0, 100))})

            Next
        End If
    End Sub

    'Generates images of alphanumeric; captcha refreshed by button2click
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

    'Captcha text input box
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox1.Validating
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
        If (IsNumeric(mobile.Text) And mobile.Text.Length = mobile.MaxLength) Then
            Me.ErrorProvider6.SetError(Me.mobile, "")
        ElseIf (Not IsNumeric(mobile.Text) Or mobile.Text = "" Or mobile.Text.Length < mobile.MaxLength) Then
            Me.ErrorProvider6.SetError(Me.mobile, "The number you are dialling does not exist")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.ErrorProvider7.SetError(Me.CheckBox1, "")
        Else
            Me.ErrorProvider7.SetError(Me.CheckBox1, "You must agree with our policy")
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox6.Enabled = True
        mobile.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        DateTimePicker1.Enabled = True
        CheckBox1.Enabled = True
        attempt = 0
        'Dim control As Control
        'For Each control In Me.Controls
        '    ' Set focus on control
        '    If TypeOf control Is TextBox Then
        '        control.Enabled = True
        '    End If

        ' Validate causes the control's Validating event to be fired,
        '  If CausesValidation Is True Then
        ' If (Validate() = False) Then
        'DialogResult = DialogResult.None

        'Return

        'End If
        ' Next

        MessageBox.Show("You can make the changes now")
    End Sub



    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        checkmail()
        If Not TextBox3.Text = TextBox6.Text Then
            Me.ErrorProvider12.SetError(Me.TextBox3, "Email Address not matching")
        Else
            Me.ErrorProvider12.SetError(Me.TextBox3, "")
        End If
    End Sub
    
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "" Then
            Me.ErrorProvider10.SetError(Me.ComboBox3, "Please select the country")
        Else
            Me.ErrorProvider10.SetError(Me.ComboBox3, "")
        End If
    End Sub
End Class

