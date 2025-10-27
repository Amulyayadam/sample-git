Public Class Form2
    Private Sub HittingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles HittingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HittingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.YankeesDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'YankeesDataSet.Hitting' table. You can move, or remove it, as needed.
        Me.HittingTableAdapter.Fill(Me.YankeesDataSet.Hitting)

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        lastPosition = Me.HittingBindingSource.Position
        lastname = Last_NameTextBox.Text
        atbats = CInt(ABTextBox.Text)
        singles = CInt(SinglesTextBox.Text)
        doubles = CInt(DoublesTextBox.Text)
        triples = CInt(TriplesTextBox.Text)
        homeruns = CInt(HomerunsTextBox.Text)
        intrecordposition = Me.HittingBindingSource.Position
        'Always put this calculate part at last

        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub First_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles First_NameTextBox.TextChanged

    End Sub
End Class