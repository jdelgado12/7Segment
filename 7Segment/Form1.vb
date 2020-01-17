Public Class Form1
    Private count As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If count = 0 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Gray
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
        End If

        If count = 1 Then
            Button1.BackColor = Color.Gray
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Gray
            Button4.BackColor = Color.Gray
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Gray
            Button7.BackColor = Color.Gray
        ElseIf count = 2 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Gray
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Gray
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
        ElseIf count = 3 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Gray
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Gray
            Button7.BackColor = Color.Red
        ElseIf count = 4 Then
            Button1.BackColor = Color.Gray
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Gray
            Button7.BackColor = Color.Gray
        ElseIf count = 5 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Gray
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Gray
            Button7.BackColor = Color.Red
        ElseIf count = 6 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Gray
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
        ElseIf count = 7 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Gray
            Button4.BackColor = Color.Gray
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Gray
            Button7.BackColor = Color.Gray
        ElseIf count = 8 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
        ElseIf count = 9 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Gray
            Button7.BackColor = Color.Red
        End If


        If count = 9 Then
            count = 0
        Else
            count = count + 1
        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds
        Timer1.Start()
        Button1.BackColor = Color.Red
        Button2.BackColor = Color.Red
        Button3.BackColor = Color.Red
        Button4.BackColor = Color.Gray
        Button5.BackColor = Color.Red
        Button6.BackColor = Color.Red
        Button7.BackColor = Color.Red
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class
