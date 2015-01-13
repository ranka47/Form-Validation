Public Class Form2




    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim thisdate As Date
        thisdate = Now

        Dim mnth As Integer
        mnth = 1
        ComboBox1.Items.Add("MasterCard")
        ComboBox1.Items.Add("VISA")
        ComboBox1.Items.Add("RuPay")
        ComboBox1.Items.Add("Maestro")
        While (mnth < 13)
            ComboBox2.Items.Add(mnth)
            mnth = mnth + 1
        End While
        Dim thisyear As Integer
        thisyear = Year(thisdate)
        While (thisyear < 2050)
            ComboBox3.Items.Add(thisyear)
            thisyear = thisyear + 1
        End While
        

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            Me.ErrorProvider1.SetError(Me.TextBox1, "No Alphabets")
        End If

    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim thisdate As Date
        thisdate = Now
        Dim thisyear As Integer
        Dim thismonth As Integer
        thismonth = ComboBox2.Text.Trim
        thisyear = ComboBox3.Text.Trim


        If (thisyear < Year(thisdate) Or (thisyear = Year(thisdate) And thismonth < Month(thisdate))) Then
            Me.ErrorProvider3.SetError(Me.ComboBox3, "Your Card has Expired")
        Else
            Me.Close()
            Form3.Show()
        End If
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim len As Integer = 10
        Dim i As Integer = 0

        Dim s As String

        s = TextBox1.Text
        If s <> Nothing Then

            Dim answer As String

            'answer = s.Substring(0, 1)
            'If answer = "4" Then
            If s.Substring(0, 1) = "4" Then
                Dim id As String = "visa"
                Dim folder As String = "/Resources/"
                Dim filename As String = System.IO.Path.Combine(folder, id & ".jpg")
                PictureBox1.Image = Image.FromFile(filename)
            Else
                'answer = s.Substring(0, 2)
                'If answer >= "51" And answer <= "55" Then
                If s.Substring(0, 2) >= "51" And s.Substring(0, 2) <= "55" Then
                    Dim id As String = "visa"
                    Dim folder As String = "\"
                    Dim filename As String = System.IO.Path.Combine(folder, id & ".jpg")
                    PictureBox1.Image = Image.FromFile(filename)
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class