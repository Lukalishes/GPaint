Public Class Form1
    Dim click As Integer
    Dim myBrush As New SolidBrush(Color.Black)
    Dim thickness As New Integer
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub



    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics

        Dim xPos As Integer = Me.MousePosition.X - Me.Location.X - 15
        Dim yPos As Integer = Me.MousePosition.Y - Me.Location.Y - 40

        Label1.Text = xPos
        Label2.Text = yPos
        If click = 1 Then
            draw.FillEllipse(myBrush, xPos, yPos, thickness, thickness)
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        click = 0
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        click = 1

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        myBrush.Color = Color.Black
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myBrush.Color = Color.Red
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myBrush.Color = Color.Blue

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myBrush.Color = Color.Yellow
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        myBrush.Color = Color.Green
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        myBrush.Color = Color.Orange
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        myBrush.Color = Color.White
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        myBrush.Color = Color.Gray
    End Sub

    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            thickness = thickness + 2
        Else
            thickness = thickness - 2
        End If
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        MsgBox(e.KeyChar)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        MsgBox("hi")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub





End Class

