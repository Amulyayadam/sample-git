Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        lblLastName.Text = lastname
        lblAtBat.Text = atbats
        lblDoubles.Text = doubles
        lblHomeRuns.Text = homeruns
        lblTriples.Text = triples
        totalbases = (1 * singles) + (2 * doubles) + (3 * triples) + (4 * homeruns)
        lblTotalBases.Text = totalbases
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rows As DataRow
        rows = Form2.YankeesDataSet.Hitting.Rows(lastPosition)
        rows.Item("TotalBases") = totalbases
        Me.Validate()
        Form2.HittingBindingSource.EndEdit()
        Form2.TableAdapterManager.UpdateAll(Form2.YankeesDataSet)
    End Sub

    Private Sub Form3_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class