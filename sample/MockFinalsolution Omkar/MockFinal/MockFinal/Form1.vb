Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Static XInteger As Integer = PictureBox1.Left
        Static YInteger As Integer = PictureBox1.Top
        Static WidthInteger As Integer = PictureBox1.Width
        Static HeightInteger As Integer = PictureBox1.Height

        XInteger += 10
        YInteger += 4

        If XInteger > Me.Width And YInteger >= Me.Height Then
            XInteger = Me.Width - PictureBox1.Width
            YInteger = 0
            Timer2.Enabled = False
            Timer1.Interval = 2500
        End If
        PictureBox1.SetBounds(XInteger, YInteger, WidthInteger, HeightInteger)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        Form2.show()
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
