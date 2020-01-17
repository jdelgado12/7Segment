Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Timer1.Interval = 1000 Then
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = False
            Button5.Visible = True
            Button6.Visible = True
            Button7.Visible = True
        ElseIf Timer1.Interval = 2000 Then
            Button1.Visible = False
            Button2.Visible = True
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = True
            Button6.Visible = False
            Button7.Visible = False

        End If





    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class
