Public Class Form1

    Function a() As Long
        a = CInt(Math.Ceiling(Rnd() * 30)) + 20
    End Function
    Function b() As Long
        b = CInt(Math.Ceiling(Rnd() * 30)) + 20
    End Function
    Function c() As Long
        c = CInt(Math.Ceiling(Rnd() * 100)) + 90
    End Function
    Function d() As Long
        d = CInt(Math.Ceiling(Rnd() * 100)) + 90
    End Function

    Private my_rectangle As Rectangle = New Rectangle(a(), b(), c(), d())
    Private my_result As Long

    Private Sub Form1_paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawRectangle(New Pen(Color.Blue), my_rectangle)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        If (my_rectangle.Contains(e.X, e.Y)) AndAlso (e.X.ToString() = e.Y.ToString()) Then
            Label6.Text = "Check!"
            my_result += 1
            MsgBox("Bravo!", MsgBoxStyle.Critical, "VitoshAcademy.Com")
        End If

        Label1.Text = "X=" & e.X.ToString()
        Label2.Text = "Y=" & e.Y.ToString()
        Label3.Text = e.Y * e.X
        Label4.Text = e.Y + e.X
        Label5.Text = Math.Abs(e.X - e.Y)
        Label6.Text = e.X / e.Y
        Label7.Text = Math.Sqrt(e.X)
        Label8.Text = "Score is " & my_result
        
    End Sub
End Class
