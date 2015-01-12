Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form3.Show()
    End Sub
End Class