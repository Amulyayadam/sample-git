<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim NumberLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim ABLabel As System.Windows.Forms.Label
        Dim SinglesLabel As System.Windows.Forms.Label
        Dim DoublesLabel As System.Windows.Forms.Label
        Dim TriplesLabel As System.Windows.Forms.Label
        Dim HomerunsLabel As System.Windows.Forms.Label
        Dim TotalbasesLabel As System.Windows.Forms.Label
        Me.YankeesDataSet = New MockFinal.yankeesDataSet()
        Me.HittingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HittingTableAdapter = New MockFinal.yankeesDataSetTableAdapters.HittingTableAdapter()
        Me.TableAdapterManager = New MockFinal.yankeesDataSetTableAdapters.TableAdapterManager()
        Me.HittingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.HittingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NumberTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.ABTextBox = New System.Windows.Forms.TextBox()
        Me.SinglesTextBox = New System.Windows.Forms.TextBox()
        Me.DoublesTextBox = New System.Windows.Forms.TextBox()
        Me.TriplesTextBox = New System.Windows.Forms.TextBox()
        Me.HomerunsTextBox = New System.Windows.Forms.TextBox()
        Me.TotalbasesTextBox = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        NumberLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        ABLabel = New System.Windows.Forms.Label()
        SinglesLabel = New System.Windows.Forms.Label()
        DoublesLabel = New System.Windows.Forms.Label()
        TriplesLabel = New System.Windows.Forms.Label()
        HomerunsLabel = New System.Windows.Forms.Label()
        TotalbasesLabel = New System.Windows.Forms.Label()
        CType(Me.YankeesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HittingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HittingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HittingBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'YankeesDataSet
        '
        Me.YankeesDataSet.DataSetName = "yankeesDataSet"
        Me.YankeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HittingBindingSource
        '
        Me.HittingBindingSource.DataMember = "Hitting"
        Me.HittingBindingSource.DataSource = Me.YankeesDataSet
        '
        'HittingTableAdapter
        '
        Me.HittingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HittingTableAdapter = Me.HittingTableAdapter
        Me.TableAdapterManager.UpdateOrder = MockFinal.yankeesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HittingBindingNavigator
        '
        Me.HittingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HittingBindingNavigator.BindingSource = Me.HittingBindingSource
        Me.HittingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HittingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HittingBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.HittingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HittingBindingNavigatorSaveItem})
        Me.HittingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HittingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HittingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HittingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HittingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HittingBindingNavigator.Name = "HittingBindingNavigator"
        Me.HittingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HittingBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.HittingBindingNavigator.TabIndex = 0
        Me.HittingBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'HittingBindingNavigatorSaveItem
        '
        Me.HittingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HittingBindingNavigatorSaveItem.Image = CType(resources.GetObject("HittingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HittingBindingNavigatorSaveItem.Name = "HittingBindingNavigatorSaveItem"
        Me.HittingBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.HittingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NumberLabel
        '
        NumberLabel.AutoSize = True
        NumberLabel.Location = New System.Drawing.Point(186, 99)
        NumberLabel.Name = "NumberLabel"
        NumberLabel.Size = New System.Drawing.Size(62, 17)
        NumberLabel.TabIndex = 1
        NumberLabel.Text = "Number:"
        '
        'NumberTextBox
        '
        Me.NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HittingBindingSource, "Number", True))
        Me.NumberTextBox.Location = New System.Drawing.Point(274, 96)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NumberTextBox.TabIndex = 2
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(186, 127)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(80, 17)
        First_NameLabel.TabIndex = 3
        First_NameLabel.Text = "First Name:"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HittingBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(274, 124)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(252, 22)
        Me.First_NameTextBox.TabIndex = 4
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(186, 155)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(80, 17)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HittingBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(274, 152)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(252, 22)
        Me.Last_NameTextBox.TabIndex = 6
        '
        'ABLabel
        '
        ABLabel.AutoSize = True
        ABLabel.Location = New System.Drawing.Point(186, 183)
        ABLabel.Name = "ABLabel"
        ABLabel.Size = New System.Drawing.Size(30, 17)
        ABLabel.TabIndex = 7
        ABLabel.Text = "AB:"
        '
        'ABTextBox
        '
        Me.ABTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HittingBindingSource, "AB", True))
        Me.ABTextBox.Location = New System.Drawing.Point(274, 180)
        Me.ABTextBox.Name = "ABTextBox"
        Me.ABTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ABTextBox.TabIndex = 8
        '
        'SinglesLabel
        '
        SinglesLabel.AutoSize = True
        SinglesLabel.Location = New System.Drawing.Point(186, 211)
        SinglesLabel.Name = "SinglesLabel"
        SinglesLabel.Size = New System.Drawing.Size(58, 17)
        SinglesLabel.TabIndex = 9
        SinglesLabel.Text = "Singles:"
        '
        'SinglesTextBox
        '
        Me.SinglesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HittingBindingSource, "Singles", True))
        Me.SinglesTextBox.Location = New System.Drawing.Point(274, 208)
        Me.SinglesTextBox.Name = "SinglesTextBox"
        Me.SinglesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SinglesTextBox.TabIndex = 10
        '
        'DoublesLabel
        '
        DoublesLabel.AutoSize = True
        DoublesLabel.Location = New System.Drawing.Point(186, 239)
        DoublesLabel.Name = "DoublesLabel"
        DoublesLabel.Size = New System.Drawing.Size(64, 17)
        DoublesLabel.TabIndex = 11
        DoublesLabel.Text = "Doubles:"
        '
        'DoublesTextBox
        '
        Me.DoublesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HittingBindingSource, "Doubles", True))
        Me.DoublesTextBox.Location = New System.Drawing.Point(274, 236)
        Me.DoublesTextBox.Name = "DoublesTextBox"
        Me.DoublesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DoublesTextBox.TabIndex = 12
        '
        'TriplesLabel
        '
        TriplesLabel.AutoSize = True
        TriplesLabel.Location = New System.Drawing.Point(186, 267)
        TriplesLabel.Name = "TriplesLabel"
        TriplesLabel.Size = New System.Drawing.Size(55, 17)
        TriplesLabel.TabIndex = 13
        TriplesLabel.Text = "Triples:"
        '
        'TriplesTextBox
        '
        Me.TriplesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HittingBindingSource, "Triples", True))
        Me.TriplesTextBox.Location = New System.Drawing.Point(274, 264)
        Me.TriplesTextBox.Name = "TriplesTextBox"
        Me.TriplesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TriplesTextBox.TabIndex = 14
        '
        'HomerunsLabel
        '
        HomerunsLabel.AutoSize = True
        HomerunsLabel.Location = New System.Drawing.Point(186, 295)
        HomerunsLabel.Name = "HomerunsLabel"
        HomerunsLabel.Size = New System.Drawing.Size(77, 17)
        HomerunsLabel.TabIndex = 15
        HomerunsLabel.Text = "Homeruns:"
        '
        'HomerunsTextBox
        '
        Me.HomerunsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HittingBindingSource, "Homeruns", True))
        Me.HomerunsTextBox.Location = New System.Drawing.Point(274, 292)
        Me.HomerunsTextBox.Name = "HomerunsTextBox"
        Me.HomerunsTextBox.Size = New System.Drawing.Size(100, 22)
        Me.HomerunsTextBox.TabIndex = 16
        '
        'TotalbasesLabel
        '
        TotalbasesLabel.AutoSize = True
        TotalbasesLabel.Location = New System.Drawing.Point(186, 323)
        TotalbasesLabel.Name = "TotalbasesLabel"
        TotalbasesLabel.Size = New System.Drawing.Size(82, 17)
        TotalbasesLabel.TabIndex = 17
        TotalbasesLabel.Text = "Totalbases:"
        '
        'TotalbasesTextBox
        '
        Me.TotalbasesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HittingBindingSource, "Totalbases", True))
        Me.TotalbasesTextBox.Location = New System.Drawing.Point(274, 320)
        Me.TotalbasesTextBox.Name = "TotalbasesTextBox"
        Me.TotalbasesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TotalbasesTextBox.TabIndex = 18
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(616, 381)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(132, 57)
        Me.btnSelect.TabIndex = 19
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(NumberLabel)
        Me.Controls.Add(Me.NumberTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(ABLabel)
        Me.Controls.Add(Me.ABTextBox)
        Me.Controls.Add(SinglesLabel)
        Me.Controls.Add(Me.SinglesTextBox)
        Me.Controls.Add(DoublesLabel)
        Me.Controls.Add(Me.DoublesTextBox)
        Me.Controls.Add(TriplesLabel)
        Me.Controls.Add(Me.TriplesTextBox)
        Me.Controls.Add(HomerunsLabel)
        Me.Controls.Add(Me.HomerunsTextBox)
        Me.Controls.Add(TotalbasesLabel)
        Me.Controls.Add(Me.TotalbasesTextBox)
        Me.Controls.Add(Me.HittingBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.YankeesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HittingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HittingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HittingBindingNavigator.ResumeLayout(False)
        Me.HittingBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents YankeesDataSet As yankeesDataSet
    Friend WithEvents HittingBindingSource As BindingSource
    Friend WithEvents HittingTableAdapter As yankeesDataSetTableAdapters.HittingTableAdapter
    Friend WithEvents TableAdapterManager As yankeesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HittingBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents HittingBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NumberTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents ABTextBox As TextBox
    Friend WithEvents SinglesTextBox As TextBox
    Friend WithEvents DoublesTextBox As TextBox
    Friend WithEvents TriplesTextBox As TextBox
    Friend WithEvents HomerunsTextBox As TextBox
    Friend WithEvents TotalbasesTextBox As TextBox
    Friend WithEvents btnSelect As Button
End Class
