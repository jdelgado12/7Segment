Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        If Timer1.Interval = 0 Then
            Button1.ForeColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Gray
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
        ElseIf Timer1.Interval = 2000 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red

        End If





    End Sub
End Class
