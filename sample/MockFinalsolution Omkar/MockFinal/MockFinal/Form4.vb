Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim total_homeruns As Integer
        Dim rows As yankeesDataSet.HittingRow
        For Each row In Form2.YankeesDataSet.Hitting.Rows
            total_homeruns += row.Homeruns
        Next
        Label2.Text = total_homeruns
        ToolStripStatusLabel1.Text = Now.ToLongDateString()
        ToolStripStatusLabel2.Text = Now.ToLongTimeString()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = Now.ToLongDateString
        ToolStripStatusLabel2.Text = Now.ToLongTimeString
    End Sub
    Private Sub GoToForm2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToForm2ToolStripMenuItem.Click, ToolStripButton1.Click, Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        End
    End Sub

    Private Sub Form4_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, ExitToolStripMenuItem.Click, ToolStripButton2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, ExitToolStripMenuItem.Click, ToolStripButton2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class