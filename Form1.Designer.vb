<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim State_nameLabel As System.Windows.Forms.Label
        Dim State_idLabel As System.Windows.Forms.Label
        Dim Singer_idLabel As System.Windows.Forms.Label
        Dim Singer_nameLabel As System.Windows.Forms.Label
        Dim City_idLabel As System.Windows.Forms.Label
        Dim Banda_idLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Post_idLabel As System.Windows.Forms.Label
        Dim Group_idLabel As System.Windows.Forms.Label
        Dim Image_idLabel As System.Windows.Forms.Label
        Dim Video_idLabel As System.Windows.Forms.Label
        Dim Album_idLabel As System.Windows.Forms.Label
        Dim Musicgenre_idLabel As System.Windows.Forms.Label
        Dim Musicgenre_nameLabel As System.Windows.Forms.Label
        Dim Music_idLabel As System.Windows.Forms.Label
        Dim Music_nameLabel As System.Windows.Forms.Label
        Dim Musicgenre_idLabel1 As System.Windows.Forms.Label
        Dim Group_idLabel1 As System.Windows.Forms.Label
        Dim Group_nameLabel As System.Windows.Forms.Label
        Dim City_idLabel1 As System.Windows.Forms.Label
        Dim City_nameLabel As System.Windows.Forms.Label
        Dim State_idLabel1 As System.Windows.Forms.Label
        Dim Banda_idLabel1 As System.Windows.Forms.Label
        Dim Banda_nameLabel As System.Windows.Forms.Label
        Dim Album_idLabel1 As System.Windows.Forms.Label
        Dim Album_nameLabel As System.Windows.Forms.Label
        Dim Music_idLabel1 As System.Windows.Forms.Label
        Dim Banda_idLabel2 As System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.StateBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.StateBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.State_nameTextBox = New System.Windows.Forms.TextBox()
        Me.State_idTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Singer_idTextBox = New System.Windows.Forms.TextBox()
        Me.Singer_nameTextBox = New System.Windows.Forms.TextBox()
        Me.City_idTextBox = New System.Windows.Forms.TextBox()
        Me.Banda_idTextBox = New System.Windows.Forms.TextBox()
        Me.StateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTM2DataSet = New BTM3.BTM2DataSet()
        Me.SingerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StateTableAdapter = New BTM3.BTM2DataSetTableAdapters.StateTableAdapter()
        Me.TableAdapterManager = New BTM3.BTM2DataSetTableAdapters.TableAdapterManager()
        Me.SingerTableAdapter = New BTM3.BTM2DataSetTableAdapters.SingerTableAdapter()
        Me.SingerTableAdapter1 = New BTM3.BTM2DataSetTableAdapters.SingerTableAdapter()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PostTableAdapter = New BTM3.BTM2DataSetTableAdapters.PostTableAdapter()
        Me.Post_idTextBox = New System.Windows.Forms.TextBox()
        Me.Group_idTextBox = New System.Windows.Forms.TextBox()
        Me.Image_idTextBox = New System.Windows.Forms.TextBox()
        Me.Video_idTextBox = New System.Windows.Forms.TextBox()
        Me.Album_idTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.MusicGenreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MusicGenreTableAdapter = New BTM3.BTM2DataSetTableAdapters.MusicGenreTableAdapter()
        Me.Musicgenre_idTextBox = New System.Windows.Forms.TextBox()
        Me.Musicgenre_nameTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem3 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem3 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.MusicBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MusicTableAdapter = New BTM3.BTM2DataSetTableAdapters.MusicTableAdapter()
        Me.Music_idTextBox = New System.Windows.Forms.TextBox()
        Me.Music_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Musicgenre_idTextBox1 = New System.Windows.Forms.TextBox()
        Me.BindingNavigator4 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem4 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem4 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ImagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImagesTableAdapter = New BTM3.BTM2DataSetTableAdapters.ImagesTableAdapter()
        Me.ImagesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.GroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupsTableAdapter = New BTM3.BTM2DataSetTableAdapters.GroupsTableAdapter()
        Me.Group_idTextBox1 = New System.Windows.Forms.TextBox()
        Me.Group_nameTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator5 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem5 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem5 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem5 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem5 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem5 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem5 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.CityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CityTableAdapter = New BTM3.BTM2DataSetTableAdapters.CityTableAdapter()
        Me.City_idTextBox1 = New System.Windows.Forms.TextBox()
        Me.City_nameTextBox = New System.Windows.Forms.TextBox()
        Me.State_idTextBox1 = New System.Windows.Forms.TextBox()
        Me.BindingNavigator6 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem6 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem6 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem6 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem6 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem6 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem6 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.BandaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BandaTableAdapter = New BTM3.BTM2DataSetTableAdapters.BandaTableAdapter()
        Me.Banda_idTextBox1 = New System.Windows.Forms.TextBox()
        Me.Banda_nameTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator7 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem7 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem7 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem7 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem7 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem7 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem7 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem2 = New System.Windows.Forms.ToolStripButton()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.AlbumBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlbumTableAdapter = New BTM3.BTM2DataSetTableAdapters.AlbumTableAdapter()
        Me.Album_idTextBox1 = New System.Windows.Forms.TextBox()
        Me.Album_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Music_idTextBox1 = New System.Windows.Forms.TextBox()
        Me.Banda_idTextBox2 = New System.Windows.Forms.TextBox()
        Me.BindingNavigator8 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem8 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem8 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator24 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem8 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem8 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator25 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem8 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem8 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator26 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem3 = New System.Windows.Forms.ToolStripButton()
        State_nameLabel = New System.Windows.Forms.Label()
        State_idLabel = New System.Windows.Forms.Label()
        Singer_idLabel = New System.Windows.Forms.Label()
        Singer_nameLabel = New System.Windows.Forms.Label()
        City_idLabel = New System.Windows.Forms.Label()
        Banda_idLabel = New System.Windows.Forms.Label()
        Post_idLabel = New System.Windows.Forms.Label()
        Group_idLabel = New System.Windows.Forms.Label()
        Image_idLabel = New System.Windows.Forms.Label()
        Video_idLabel = New System.Windows.Forms.Label()
        Album_idLabel = New System.Windows.Forms.Label()
        Musicgenre_idLabel = New System.Windows.Forms.Label()
        Musicgenre_nameLabel = New System.Windows.Forms.Label()
        Music_idLabel = New System.Windows.Forms.Label()
        Music_nameLabel = New System.Windows.Forms.Label()
        Musicgenre_idLabel1 = New System.Windows.Forms.Label()
        Group_idLabel1 = New System.Windows.Forms.Label()
        Group_nameLabel = New System.Windows.Forms.Label()
        City_idLabel1 = New System.Windows.Forms.Label()
        City_nameLabel = New System.Windows.Forms.Label()
        State_idLabel1 = New System.Windows.Forms.Label()
        Banda_idLabel1 = New System.Windows.Forms.Label()
        Banda_nameLabel = New System.Windows.Forms.Label()
        Album_idLabel1 = New System.Windows.Forms.Label()
        Album_nameLabel = New System.Windows.Forms.Label()
        Music_idLabel1 = New System.Windows.Forms.Label()
        Banda_idLabel2 = New System.Windows.Forms.Label()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.StateBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StateBindingNavigator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.StateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTM2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SingerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.MusicGenreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.MusicBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.ImagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.GroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator5.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator6.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        CType(Me.BandaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator7.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        CType(Me.AlbumBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BindingNavigator1)
        Me.TabPage2.Controls.Add(Singer_idLabel)
        Me.TabPage2.Controls.Add(Me.Singer_idTextBox)
        Me.TabPage2.Controls.Add(Singer_nameLabel)
        Me.TabPage2.Controls.Add(Me.Singer_nameTextBox)
        Me.TabPage2.Controls.Add(City_idLabel)
        Me.TabPage2.Controls.Add(Me.City_idTextBox)
        Me.TabPage2.Controls.Add(Banda_idLabel)
        Me.TabPage2.Controls.Add(Me.Banda_idTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(742, 369)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(State_idLabel)
        Me.TabPage1.Controls.Add(Me.State_idTextBox)
        Me.TabPage1.Controls.Add(Me.State_nameTextBox)
        Me.TabPage1.Controls.Add(State_nameLabel)
        Me.TabPage1.Controls.Add(Me.StateBindingNavigator)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(948, 518)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'StateBindingNavigator
        '
        Me.StateBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StateBindingNavigator.BindingSource = Me.StateBindingSource
        Me.StateBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StateBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StateBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StateBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StateBindingNavigatorSaveItem})
        Me.StateBindingNavigator.Location = New System.Drawing.Point(3, 3)
        Me.StateBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StateBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StateBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StateBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StateBindingNavigator.Name = "StateBindingNavigator"
        Me.StateBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StateBindingNavigator.Size = New System.Drawing.Size(942, 27)
        Me.StateBindingNavigator.TabIndex = 5
        Me.StateBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 24)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'StateBindingNavigatorSaveItem
        '
        Me.StateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StateBindingNavigatorSaveItem.Image = CType(resources.GetObject("StateBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StateBindingNavigatorSaveItem.Name = "StateBindingNavigatorSaveItem"
        Me.StateBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.StateBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'State_nameTextBox
        '
        Me.State_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StateBindingSource, "state_name", True))
        Me.State_nameTextBox.Location = New System.Drawing.Point(115, 91)
        Me.State_nameTextBox.Name = "State_nameTextBox"
        Me.State_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.State_nameTextBox.TabIndex = 9
        '
        'State_nameLabel
        '
        State_nameLabel.AutoSize = True
        State_nameLabel.Location = New System.Drawing.Point(27, 94)
        State_nameLabel.Name = "State_nameLabel"
        State_nameLabel.Size = New System.Drawing.Size(82, 17)
        State_nameLabel.TabIndex = 8
        State_nameLabel.Text = "state name:"
        '
        'State_idTextBox
        '
        Me.State_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StateBindingSource, "state_id", True))
        Me.State_idTextBox.Location = New System.Drawing.Point(115, 63)
        Me.State_idTextBox.Name = "State_idTextBox"
        Me.State_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.State_idTextBox.TabIndex = 7
        '
        'State_idLabel
        '
        State_idLabel.AutoSize = True
        State_idLabel.Location = New System.Drawing.Point(27, 66)
        State_idLabel.Name = "State_idLabel"
        State_idLabel.Size = New System.Drawing.Size(58, 17)
        State_idLabel.TabIndex = 6
        State_idLabel.Text = "state id:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Location = New System.Drawing.Point(21, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(956, 547)
        Me.TabControl1.TabIndex = 0
        '
        'Singer_idLabel
        '
        Singer_idLabel.AutoSize = True
        Singer_idLabel.Location = New System.Drawing.Point(40, 122)
        Singer_idLabel.Name = "Singer_idLabel"
        Singer_idLabel.Size = New System.Drawing.Size(66, 17)
        Singer_idLabel.TabIndex = 0
        Singer_idLabel.Text = "singer id:"
        '
        'Singer_idTextBox
        '
        Me.Singer_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SingerBindingSource, "singer_id", True))
        Me.Singer_idTextBox.Location = New System.Drawing.Point(136, 119)
        Me.Singer_idTextBox.Name = "Singer_idTextBox"
        Me.Singer_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Singer_idTextBox.TabIndex = 1
        '
        'Singer_nameLabel
        '
        Singer_nameLabel.AutoSize = True
        Singer_nameLabel.Location = New System.Drawing.Point(40, 150)
        Singer_nameLabel.Name = "Singer_nameLabel"
        Singer_nameLabel.Size = New System.Drawing.Size(90, 17)
        Singer_nameLabel.TabIndex = 2
        Singer_nameLabel.Text = "singer name:"
        '
        'Singer_nameTextBox
        '
        Me.Singer_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SingerBindingSource, "singer_name", True))
        Me.Singer_nameTextBox.Location = New System.Drawing.Point(136, 147)
        Me.Singer_nameTextBox.Name = "Singer_nameTextBox"
        Me.Singer_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Singer_nameTextBox.TabIndex = 3
        '
        'City_idLabel
        '
        City_idLabel.AutoSize = True
        City_idLabel.Location = New System.Drawing.Point(40, 178)
        City_idLabel.Name = "City_idLabel"
        City_idLabel.Size = New System.Drawing.Size(48, 17)
        City_idLabel.TabIndex = 4
        City_idLabel.Text = "city id:"
        '
        'City_idTextBox
        '
        Me.City_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SingerBindingSource, "city_id", True))
        Me.City_idTextBox.Location = New System.Drawing.Point(136, 175)
        Me.City_idTextBox.Name = "City_idTextBox"
        Me.City_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.City_idTextBox.TabIndex = 5
        '
        'Banda_idLabel
        '
        Banda_idLabel.AutoSize = True
        Banda_idLabel.Location = New System.Drawing.Point(40, 206)
        Banda_idLabel.Name = "Banda_idLabel"
        Banda_idLabel.Size = New System.Drawing.Size(67, 17)
        Banda_idLabel.TabIndex = 6
        Banda_idLabel.Text = "banda id:"
        '
        'Banda_idTextBox
        '
        Me.Banda_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SingerBindingSource, "banda_id", True))
        Me.Banda_idTextBox.Location = New System.Drawing.Point(136, 203)
        Me.Banda_idTextBox.Name = "Banda_idTextBox"
        Me.Banda_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Banda_idTextBox.TabIndex = 7
        '
        'StateBindingSource
        '
        Me.StateBindingSource.DataMember = "State"
        Me.StateBindingSource.DataSource = Me.BTM2DataSet
        '
        'BTM2DataSet
        '
        Me.BTM2DataSet.DataSetName = "BTM2DataSet"
        Me.BTM2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SingerBindingSource
        '
        Me.SingerBindingSource.DataMember = "Singer"
        Me.SingerBindingSource.DataSource = Me.BTM2DataSet
        '
        'StateTableAdapter
        '
        Me.StateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlbumTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BandaTableAdapter = Nothing
        Me.TableAdapterManager.CityTableAdapter = Nothing
        Me.TableAdapterManager.GroupsTableAdapter = Nothing
        Me.TableAdapterManager.GroupUserRTTableAdapter = Nothing
        Me.TableAdapterManager.ImagesTableAdapter = Nothing
        Me.TableAdapterManager.MusicGenreTableAdapter = Nothing
        Me.TableAdapterManager.MusicTableAdapter = Nothing
        Me.TableAdapterManager.PostTableAdapter = Nothing
        Me.TableAdapterManager.SingerTableAdapter = Me.SingerTableAdapter
        Me.TableAdapterManager.StateTableAdapter = Me.StateTableAdapter
        Me.TableAdapterManager.UnivercityTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BTM3.BTM2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.VideoTableAdapter = Nothing
        '
        'SingerTableAdapter
        '
        Me.SingerTableAdapter.ClearBeforeFill = True
        '
        'SingerTableAdapter1
        '
        Me.SingerTableAdapter1.ClearBeforeFill = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(736, 27)
        Me.BindingNavigator1.TabIndex = 8
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem1.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem1.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(55, 24)
        Me.BindingNavigatorCountItem1.Text = "для {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem1.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem1.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.BindingNavigator2)
        Me.TabPage3.Controls.Add(Post_idLabel)
        Me.TabPage3.Controls.Add(Me.Post_idTextBox)
        Me.TabPage3.Controls.Add(Group_idLabel)
        Me.TabPage3.Controls.Add(Me.Group_idTextBox)
        Me.TabPage3.Controls.Add(Image_idLabel)
        Me.TabPage3.Controls.Add(Me.Image_idTextBox)
        Me.TabPage3.Controls.Add(Video_idLabel)
        Me.TabPage3.Controls.Add(Me.Video_idTextBox)
        Me.TabPage3.Controls.Add(Album_idLabel)
        Me.TabPage3.Controls.Add(Me.Album_idTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(742, 369)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PostBindingSource
        '
        Me.PostBindingSource.DataMember = "Post"
        Me.PostBindingSource.DataSource = Me.BTM2DataSet
        '
        'PostTableAdapter
        '
        Me.PostTableAdapter.ClearBeforeFill = True
        '
        'Post_idLabel
        '
        Post_idLabel.AutoSize = True
        Post_idLabel.Location = New System.Drawing.Point(28, 144)
        Post_idLabel.Name = "Post_idLabel"
        Post_idLabel.Size = New System.Drawing.Size(54, 17)
        Post_idLabel.TabIndex = 0
        Post_idLabel.Text = "post id:"
        '
        'Post_idTextBox
        '
        Me.Post_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostBindingSource, "post_id", True))
        Me.Post_idTextBox.Location = New System.Drawing.Point(99, 141)
        Me.Post_idTextBox.Name = "Post_idTextBox"
        Me.Post_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Post_idTextBox.TabIndex = 1
        '
        'Group_idLabel
        '
        Group_idLabel.AutoSize = True
        Group_idLabel.Location = New System.Drawing.Point(28, 172)
        Group_idLabel.Name = "Group_idLabel"
        Group_idLabel.Size = New System.Drawing.Size(64, 17)
        Group_idLabel.TabIndex = 2
        Group_idLabel.Text = "group id:"
        '
        'Group_idTextBox
        '
        Me.Group_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostBindingSource, "group_id", True))
        Me.Group_idTextBox.Location = New System.Drawing.Point(99, 169)
        Me.Group_idTextBox.Name = "Group_idTextBox"
        Me.Group_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Group_idTextBox.TabIndex = 3
        '
        'Image_idLabel
        '
        Image_idLabel.AutoSize = True
        Image_idLabel.Location = New System.Drawing.Point(28, 200)
        Image_idLabel.Name = "Image_idLabel"
        Image_idLabel.Size = New System.Drawing.Size(65, 17)
        Image_idLabel.TabIndex = 4
        Image_idLabel.Text = "image id:"
        '
        'Image_idTextBox
        '
        Me.Image_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostBindingSource, "image_id", True))
        Me.Image_idTextBox.Location = New System.Drawing.Point(99, 197)
        Me.Image_idTextBox.Name = "Image_idTextBox"
        Me.Image_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Image_idTextBox.TabIndex = 5
        '
        'Video_idLabel
        '
        Video_idLabel.AutoSize = True
        Video_idLabel.Location = New System.Drawing.Point(28, 228)
        Video_idLabel.Name = "Video_idLabel"
        Video_idLabel.Size = New System.Drawing.Size(61, 17)
        Video_idLabel.TabIndex = 6
        Video_idLabel.Text = "video id:"
        '
        'Video_idTextBox
        '
        Me.Video_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostBindingSource, "video_id", True))
        Me.Video_idTextBox.Location = New System.Drawing.Point(99, 225)
        Me.Video_idTextBox.Name = "Video_idTextBox"
        Me.Video_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Video_idTextBox.TabIndex = 7
        '
        'Album_idLabel
        '
        Album_idLabel.AutoSize = True
        Album_idLabel.Location = New System.Drawing.Point(28, 256)
        Album_idLabel.Name = "Album_idLabel"
        Album_idLabel.Size = New System.Drawing.Size(65, 17)
        Album_idLabel.TabIndex = 8
        Album_idLabel.Text = "album id:"
        '
        'Album_idTextBox
        '
        Me.Album_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostBindingSource, "album_id", True))
        Me.Album_idTextBox.Location = New System.Drawing.Point(99, 253)
        Me.Album_idTextBox.Name = "Album_idTextBox"
        Me.Album_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Album_idTextBox.TabIndex = 9
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.BindingSource = Me.PostBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem2
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8})
        Me.BindingNavigator2.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem2
        Me.BindingNavigator2.Size = New System.Drawing.Size(736, 27)
        Me.BindingNavigator2.TabIndex = 10
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem2.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem2.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(55, 24)
        Me.BindingNavigatorCountItem2.Text = "для {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem2.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem2.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 27)
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.BindingNavigator3)
        Me.TabPage4.Controls.Add(Musicgenre_idLabel)
        Me.TabPage4.Controls.Add(Me.Musicgenre_idTextBox)
        Me.TabPage4.Controls.Add(Musicgenre_nameLabel)
        Me.TabPage4.Controls.Add(Me.Musicgenre_nameTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(742, 369)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'MusicGenreBindingSource
        '
        Me.MusicGenreBindingSource.DataMember = "MusicGenre"
        Me.MusicGenreBindingSource.DataSource = Me.BTM2DataSet
        '
        'MusicGenreTableAdapter
        '
        Me.MusicGenreTableAdapter.ClearBeforeFill = True
        '
        'Musicgenre_idLabel
        '
        Musicgenre_idLabel.AutoSize = True
        Musicgenre_idLabel.Location = New System.Drawing.Point(6, 97)
        Musicgenre_idLabel.Name = "Musicgenre_idLabel"
        Musicgenre_idLabel.Size = New System.Drawing.Size(100, 17)
        Musicgenre_idLabel.TabIndex = 0
        Musicgenre_idLabel.Text = "musicgenre id:"
        '
        'Musicgenre_idTextBox
        '
        Me.Musicgenre_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MusicGenreBindingSource, "musicgenre_id", True))
        Me.Musicgenre_idTextBox.Location = New System.Drawing.Point(136, 94)
        Me.Musicgenre_idTextBox.Name = "Musicgenre_idTextBox"
        Me.Musicgenre_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Musicgenre_idTextBox.TabIndex = 1
        '
        'Musicgenre_nameLabel
        '
        Musicgenre_nameLabel.AutoSize = True
        Musicgenre_nameLabel.Location = New System.Drawing.Point(6, 125)
        Musicgenre_nameLabel.Name = "Musicgenre_nameLabel"
        Musicgenre_nameLabel.Size = New System.Drawing.Size(124, 17)
        Musicgenre_nameLabel.TabIndex = 2
        Musicgenre_nameLabel.Text = "musicgenre name:"
        '
        'Musicgenre_nameTextBox
        '
        Me.Musicgenre_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MusicGenreBindingSource, "musicgenre_name", True))
        Me.Musicgenre_nameTextBox.Location = New System.Drawing.Point(136, 122)
        Me.Musicgenre_nameTextBox.Name = "Musicgenre_nameTextBox"
        Me.Musicgenre_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Musicgenre_nameTextBox.TabIndex = 3
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Nothing
        Me.BindingNavigator3.CountItem = Me.BindingNavigatorCountItem3
        Me.BindingNavigator3.DeleteItem = Nothing
        Me.BindingNavigator3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem3, Me.BindingNavigatorMovePreviousItem3, Me.BindingNavigatorSeparator9, Me.BindingNavigatorPositionItem3, Me.BindingNavigatorCountItem3, Me.BindingNavigatorSeparator10, Me.BindingNavigatorMoveNextItem3, Me.BindingNavigatorMoveLastItem3, Me.BindingNavigatorSeparator11})
        Me.BindingNavigator3.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator3.MoveFirstItem = Me.BindingNavigatorMoveFirstItem3
        Me.BindingNavigator3.MoveLastItem = Me.BindingNavigatorMoveLastItem3
        Me.BindingNavigator3.MoveNextItem = Me.BindingNavigatorMoveNextItem3
        Me.BindingNavigator3.MovePreviousItem = Me.BindingNavigatorMovePreviousItem3
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.BindingNavigatorPositionItem3
        Me.BindingNavigator3.Size = New System.Drawing.Size(736, 27)
        Me.BindingNavigator3.TabIndex = 4
        Me.BindingNavigator3.Text = "BindingNavigator3"
        '
        'BindingNavigatorMoveFirstItem3
        '
        Me.BindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem3.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem3.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem3.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem3.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem3
        '
        Me.BindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem3.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem3.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem3.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem3.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator9
        '
        Me.BindingNavigatorSeparator9.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator9.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem3
        '
        Me.BindingNavigatorPositionItem3.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem3.AutoSize = False
        Me.BindingNavigatorPositionItem3.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem3.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem3.Text = "0"
        Me.BindingNavigatorPositionItem3.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem3
        '
        Me.BindingNavigatorCountItem3.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem3.Size = New System.Drawing.Size(55, 24)
        Me.BindingNavigatorCountItem3.Text = "для {0}"
        Me.BindingNavigatorCountItem3.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator10
        '
        Me.BindingNavigatorSeparator10.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator10.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem3
        '
        Me.BindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem3.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem3.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem3.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem3.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem3
        '
        Me.BindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem3.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem3.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem3.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem3.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator11
        '
        Me.BindingNavigatorSeparator11.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator11.Size = New System.Drawing.Size(6, 27)
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.BindingNavigator4)
        Me.TabPage5.Controls.Add(Music_idLabel)
        Me.TabPage5.Controls.Add(Me.Music_idTextBox)
        Me.TabPage5.Controls.Add(Music_nameLabel)
        Me.TabPage5.Controls.Add(Me.Music_nameTextBox)
        Me.TabPage5.Controls.Add(Musicgenre_idLabel1)
        Me.TabPage5.Controls.Add(Me.Musicgenre_idTextBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(742, 369)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'MusicBindingSource
        '
        Me.MusicBindingSource.DataMember = "Music"
        Me.MusicBindingSource.DataSource = Me.BTM2DataSet
        '
        'MusicTableAdapter
        '
        Me.MusicTableAdapter.ClearBeforeFill = True
        '
        'Music_idLabel
        '
        Music_idLabel.AutoSize = True
        Music_idLabel.Location = New System.Drawing.Point(73, 128)
        Music_idLabel.Name = "Music_idLabel"
        Music_idLabel.Size = New System.Drawing.Size(63, 17)
        Music_idLabel.TabIndex = 0
        Music_idLabel.Text = "music id:"
        '
        'Music_idTextBox
        '
        Me.Music_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MusicBindingSource, "music_id", True))
        Me.Music_idTextBox.Location = New System.Drawing.Point(179, 125)
        Me.Music_idTextBox.Name = "Music_idTextBox"
        Me.Music_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Music_idTextBox.TabIndex = 1
        '
        'Music_nameLabel
        '
        Music_nameLabel.AutoSize = True
        Music_nameLabel.Location = New System.Drawing.Point(73, 156)
        Music_nameLabel.Name = "Music_nameLabel"
        Music_nameLabel.Size = New System.Drawing.Size(87, 17)
        Music_nameLabel.TabIndex = 2
        Music_nameLabel.Text = "music name:"
        '
        'Music_nameTextBox
        '
        Me.Music_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MusicBindingSource, "music_name", True))
        Me.Music_nameTextBox.Location = New System.Drawing.Point(179, 153)
        Me.Music_nameTextBox.Name = "Music_nameTextBox"
        Me.Music_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Music_nameTextBox.TabIndex = 3
        '
        'Musicgenre_idLabel1
        '
        Musicgenre_idLabel1.AutoSize = True
        Musicgenre_idLabel1.Location = New System.Drawing.Point(73, 184)
        Musicgenre_idLabel1.Name = "Musicgenre_idLabel1"
        Musicgenre_idLabel1.Size = New System.Drawing.Size(100, 17)
        Musicgenre_idLabel1.TabIndex = 4
        Musicgenre_idLabel1.Text = "musicgenre id:"
        '
        'Musicgenre_idTextBox1
        '
        Me.Musicgenre_idTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MusicBindingSource, "musicgenre_id", True))
        Me.Musicgenre_idTextBox1.Location = New System.Drawing.Point(179, 181)
        Me.Musicgenre_idTextBox1.Name = "Musicgenre_idTextBox1"
        Me.Musicgenre_idTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.Musicgenre_idTextBox1.TabIndex = 5
        '
        'BindingNavigator4
        '
        Me.BindingNavigator4.AddNewItem = Nothing
        Me.BindingNavigator4.CountItem = Me.BindingNavigatorCountItem4
        Me.BindingNavigator4.DeleteItem = Nothing
        Me.BindingNavigator4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem4, Me.BindingNavigatorMovePreviousItem4, Me.BindingNavigatorSeparator12, Me.BindingNavigatorPositionItem4, Me.BindingNavigatorCountItem4, Me.BindingNavigatorSeparator13, Me.BindingNavigatorMoveNextItem4, Me.BindingNavigatorMoveLastItem4, Me.BindingNavigatorSeparator14})
        Me.BindingNavigator4.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator4.MoveFirstItem = Me.BindingNavigatorMoveFirstItem4
        Me.BindingNavigator4.MoveLastItem = Me.BindingNavigatorMoveLastItem4
        Me.BindingNavigator4.MoveNextItem = Me.BindingNavigatorMoveNextItem4
        Me.BindingNavigator4.MovePreviousItem = Me.BindingNavigatorMovePreviousItem4
        Me.BindingNavigator4.Name = "BindingNavigator4"
        Me.BindingNavigator4.PositionItem = Me.BindingNavigatorPositionItem4
        Me.BindingNavigator4.Size = New System.Drawing.Size(736, 27)
        Me.BindingNavigator4.TabIndex = 6
        Me.BindingNavigator4.Text = "BindingNavigator4"
        '
        'BindingNavigatorMoveFirstItem4
        '
        Me.BindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem4.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem4.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem4.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem4.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem4
        '
        Me.BindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem4.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem4.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem4.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem4.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator12
        '
        Me.BindingNavigatorSeparator12.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator12.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem4
        '
        Me.BindingNavigatorPositionItem4.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem4.AutoSize = False
        Me.BindingNavigatorPositionItem4.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem4.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem4.Text = "0"
        Me.BindingNavigatorPositionItem4.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem4
        '
        Me.BindingNavigatorCountItem4.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem4.Size = New System.Drawing.Size(55, 24)
        Me.BindingNavigatorCountItem4.Text = "для {0}"
        Me.BindingNavigatorCountItem4.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator13
        '
        Me.BindingNavigatorSeparator13.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator13.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem4
        '
        Me.BindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem4.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem4.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem4.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem4.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem4
        '
        Me.BindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem4.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem4.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem4.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem4.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator14
        '
        Me.BindingNavigatorSeparator14.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator14.Size = New System.Drawing.Size(6, 27)
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.ImagesDataGridView)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(742, 369)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "TabPage6"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'ImagesBindingSource
        '
        Me.ImagesBindingSource.DataMember = "Images"
        Me.ImagesBindingSource.DataSource = Me.BTM2DataSet
        '
        'ImagesTableAdapter
        '
        Me.ImagesTableAdapter.ClearBeforeFill = True
        '
        'ImagesDataGridView
        '
        Me.ImagesDataGridView.AutoGenerateColumns = False
        Me.ImagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ImagesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ImagesDataGridView.DataSource = Me.ImagesBindingSource
        Me.ImagesDataGridView.Location = New System.Drawing.Point(22, 77)
        Me.ImagesDataGridView.Name = "ImagesDataGridView"
        Me.ImagesDataGridView.RowHeadersWidth = 51
        Me.ImagesDataGridView.RowTemplate.Height = 24
        Me.ImagesDataGridView.Size = New System.Drawing.Size(664, 220)
        Me.ImagesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "image_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "image_id"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "create_date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "create_date"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "image_url"
        Me.DataGridViewTextBoxColumn3.HeaderText = "image_url"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.BindingNavigator5)
        Me.TabPage7.Controls.Add(Group_idLabel1)
        Me.TabPage7.Controls.Add(Me.Group_idTextBox1)
        Me.TabPage7.Controls.Add(Group_nameLabel)
        Me.TabPage7.Controls.Add(Me.Group_nameTextBox)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(742, 369)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "TabPage7"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'GroupsBindingSource
        '
        Me.GroupsBindingSource.DataMember = "Groups"
        Me.GroupsBindingSource.DataSource = Me.BTM2DataSet
        '
        'GroupsTableAdapter
        '
        Me.GroupsTableAdapter.ClearBeforeFill = True
        '
        'Group_idLabel1
        '
        Group_idLabel1.AutoSize = True
        Group_idLabel1.Location = New System.Drawing.Point(62, 90)
        Group_idLabel1.Name = "Group_idLabel1"
        Group_idLabel1.Size = New System.Drawing.Size(64, 17)
        Group_idLabel1.TabIndex = 0
        Group_idLabel1.Text = "group id:"
        '
        'Group_idTextBox1
        '
        Me.Group_idTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GroupsBindingSource, "group_id", True))
        Me.Group_idTextBox1.Location = New System.Drawing.Point(156, 87)
        Me.Group_idTextBox1.Name = "Group_idTextBox1"
        Me.Group_idTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.Group_idTextBox1.TabIndex = 1
        '
        'Group_nameLabel
        '
        Group_nameLabel.AutoSize = True
        Group_nameLabel.Location = New System.Drawing.Point(62, 118)
        Group_nameLabel.Name = "Group_nameLabel"
        Group_nameLabel.Size = New System.Drawing.Size(88, 17)
        Group_nameLabel.TabIndex = 2
        Group_nameLabel.Text = "group name:"
        '
        'Group_nameTextBox
        '
        Me.Group_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GroupsBindingSource, "group_name", True))
        Me.Group_nameTextBox.Location = New System.Drawing.Point(156, 115)
        Me.Group_nameTextBox.Name = "Group_nameTextBox"
        Me.Group_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Group_nameTextBox.TabIndex = 3
        '
        'BindingNavigator5
        '
        Me.BindingNavigator5.AddNewItem = Nothing
        Me.BindingNavigator5.BindingSource = Me.GroupsBindingSource
        Me.BindingNavigator5.CountItem = Me.BindingNavigatorCountItem5
        Me.BindingNavigator5.DeleteItem = Nothing
        Me.BindingNavigator5.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem5, Me.BindingNavigatorMovePreviousItem5, Me.BindingNavigatorSeparator15, Me.BindingNavigatorPositionItem5, Me.BindingNavigatorCountItem5, Me.BindingNavigatorSeparator16, Me.BindingNavigatorMoveNextItem5, Me.BindingNavigatorMoveLastItem5, Me.BindingNavigatorSeparator17})
        Me.BindingNavigator5.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator5.MoveFirstItem = Me.BindingNavigatorMoveFirstItem5
        Me.BindingNavigator5.MoveLastItem = Me.BindingNavigatorMoveLastItem5
        Me.BindingNavigator5.MoveNextItem = Me.BindingNavigatorMoveNextItem5
        Me.BindingNavigator5.MovePreviousItem = Me.BindingNavigatorMovePreviousItem5
        Me.BindingNavigator5.Name = "BindingNavigator5"
        Me.BindingNavigator5.PositionItem = Me.BindingNavigatorPositionItem5
        Me.BindingNavigator5.Size = New System.Drawing.Size(736, 27)
        Me.BindingNavigator5.TabIndex = 4
        Me.BindingNavigator5.Text = "BindingNavigator5"
        '
        'BindingNavigatorMoveFirstItem5
        '
        Me.BindingNavigatorMoveFirstItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem5.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem5.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem5.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem5.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem5.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem5.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem5
        '
        Me.BindingNavigatorMovePreviousItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem5.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem5.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem5.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem5.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem5.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem5.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator15
        '
        Me.BindingNavigatorSeparator15.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator15.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem5
        '
        Me.BindingNavigatorPositionItem5.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem5.AutoSize = False
        Me.BindingNavigatorPositionItem5.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem5.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem5.Text = "0"
        Me.BindingNavigatorPositionItem5.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem5
        '
        Me.BindingNavigatorCountItem5.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem5.Size = New System.Drawing.Size(55, 24)
        Me.BindingNavigatorCountItem5.Text = "для {0}"
        Me.BindingNavigatorCountItem5.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator16
        '
        Me.BindingNavigatorSeparator16.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator16.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem5
        '
        Me.BindingNavigatorMoveNextItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem5.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem5.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem5.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem5.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem5.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem5.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem5
        '
        Me.BindingNavigatorMoveLastItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem5.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem5.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem5.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem5.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem5.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem5.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator17
        '
        Me.BindingNavigatorSeparator17.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator17.Size = New System.Drawing.Size(6, 27)
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.BindingNavigator6)
        Me.TabPage8.Controls.Add(City_idLabel1)
        Me.TabPage8.Controls.Add(Me.City_idTextBox1)
        Me.TabPage8.Controls.Add(City_nameLabel)
        Me.TabPage8.Controls.Add(Me.City_nameTextBox)
        Me.TabPage8.Controls.Add(State_idLabel1)
        Me.TabPage8.Controls.Add(Me.State_idTextBox1)
        Me.TabPage8.Location = New System.Drawing.Point(4, 25)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(742, 369)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "TabPage8"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'CityBindingSource
        '
        Me.CityBindingSource.DataMember = "City"
        Me.CityBindingSource.DataSource = Me.BTM2DataSet
        '
        'CityTableAdapter
        '
        Me.CityTableAdapter.ClearBeforeFill = True
        '
        'City_idLabel1
        '
        City_idLabel1.AutoSize = True
        City_idLabel1.Location = New System.Drawing.Point(57, 121)
        City_idLabel1.Name = "City_idLabel1"
        City_idLabel1.Size = New System.Drawing.Size(48, 17)
        City_idLabel1.TabIndex = 0
        City_idLabel1.Text = "city id:"
        '
        'City_idTextBox1
        '
        Me.City_idTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CityBindingSource, "city_id", True))
        Me.City_idTextBox1.Location = New System.Drawing.Point(135, 118)
        Me.City_idTextBox1.Name = "City_idTextBox1"
        Me.City_idTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.City_idTextBox1.TabIndex = 1
        '
        'City_nameLabel
        '
        City_nameLabel.AutoSize = True
        City_nameLabel.Location = New System.Drawing.Point(57, 149)
        City_nameLabel.Name = "City_nameLabel"
        City_nameLabel.Size = New System.Drawing.Size(72, 17)
        City_nameLabel.TabIndex = 2
        City_nameLabel.Text = "city name:"
        '
        'City_nameTextBox
        '
        Me.City_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CityBindingSource, "city_name", True))
        Me.City_nameTextBox.Location = New System.Drawing.Point(135, 146)
        Me.City_nameTextBox.Name = "City_nameTextBox"
        Me.City_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.City_nameTextBox.TabIndex = 3
        '
        'State_idLabel1
        '
        State_idLabel1.AutoSize = True
        State_idLabel1.Location = New System.Drawing.Point(57, 177)
        State_idLabel1.Name = "State_idLabel1"
        State_idLabel1.Size = New System.Drawing.Size(58, 17)
        State_idLabel1.TabIndex = 4
        State_idLabel1.Text = "state id:"
        '
        'State_idTextBox1
        '
        Me.State_idTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CityBindingSource, "state_id", True))
        Me.State_idTextBox1.Location = New System.Drawing.Point(135, 174)
        Me.State_idTextBox1.Name = "State_idTextBox1"
        Me.State_idTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.State_idTextBox1.TabIndex = 5
        '
        'BindingNavigator6
        '
        Me.BindingNavigator6.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BindingNavigator6.BindingSource = Me.CityBindingSource
        Me.BindingNavigator6.CountItem = Me.BindingNavigatorCountItem6
        Me.BindingNavigator6.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator6.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem6, Me.BindingNavigatorMovePreviousItem6, Me.BindingNavigatorSeparator18, Me.BindingNavigatorPositionItem6, Me.BindingNavigatorCountItem6, Me.BindingNavigatorSeparator19, Me.BindingNavigatorMoveNextItem6, Me.BindingNavigatorMoveLastItem6, Me.BindingNavigatorSeparator20, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.BindingNavigator6.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator6.MoveFirstItem = Me.BindingNavigatorMoveFirstItem6
        Me.BindingNavigator6.MoveLastItem = Me.BindingNavigatorMoveLastItem6
        Me.BindingNavigator6.MoveNextItem = Me.BindingNavigatorMoveNextItem6
        Me.BindingNavigator6.MovePreviousItem = Me.BindingNavigatorMovePreviousItem6
        Me.BindingNavigator6.Name = "BindingNavigator6"
        Me.BindingNavigator6.PositionItem = Me.BindingNavigatorPositionItem6
        Me.BindingNavigator6.Size = New System.Drawing.Size(736, 27)
        Me.BindingNavigator6.TabIndex = 6
        Me.BindingNavigator6.Text = "BindingNavigator6"
        '
        'BindingNavigatorMoveFirstItem6
        '
        Me.BindingNavigatorMoveFirstItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem6.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem6.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem6.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem6.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem6.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem6.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem6
        '
        Me.BindingNavigatorMovePreviousItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem6.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem6.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem6.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem6.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem6.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem6.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator18
        '
        Me.BindingNavigatorSeparator18.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator18.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem6
        '
        Me.BindingNavigatorPositionItem6.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem6.AutoSize = False
        Me.BindingNavigatorPositionItem6.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem6.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem6.Text = "0"
        Me.BindingNavigatorPositionItem6.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem6
        '
        Me.BindingNavigatorCountItem6.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem6.Size = New System.Drawing.Size(55, 24)
        Me.BindingNavigatorCountItem6.Text = "для {0}"
        Me.BindingNavigatorCountItem6.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator19
        '
        Me.BindingNavigatorSeparator19.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator19.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem6
        '
        Me.BindingNavigatorMoveNextItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem6.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem6.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem6.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem6.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem6.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem6.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem6
        '
        Me.BindingNavigatorMoveLastItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem6.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem6.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem6.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem6.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem6.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem6.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator20
        '
        Me.BindingNavigatorSeparator20.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator20.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem1.Text = "Добавить"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem1.Text = "Удалить"
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.BindingNavigator7)
        Me.TabPage9.Controls.Add(Banda_idLabel1)
        Me.TabPage9.Controls.Add(Me.Banda_idTextBox1)
        Me.TabPage9.Controls.Add(Banda_nameLabel)
        Me.TabPage9.Controls.Add(Me.Banda_nameTextBox)
        Me.TabPage9.Location = New System.Drawing.Point(4, 25)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(742, 369)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "TabPage9"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'BandaBindingSource
        '
        Me.BandaBindingSource.DataMember = "Banda"
        Me.BandaBindingSource.DataSource = Me.BTM2DataSet
        '
        'BandaTableAdapter
        '
        Me.BandaTableAdapter.ClearBeforeFill = True
        '
        'Banda_idLabel1
        '
        Banda_idLabel1.AutoSize = True
        Banda_idLabel1.Location = New System.Drawing.Point(46, 125)
        Banda_idLabel1.Name = "Banda_idLabel1"
        Banda_idLabel1.Size = New System.Drawing.Size(67, 17)
        Banda_idLabel1.TabIndex = 0
        Banda_idLabel1.Text = "banda id:"
        '
        'Banda_idTextBox1
        '
        Me.Banda_idTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BandaBindingSource, "banda_id", True))
        Me.Banda_idTextBox1.Location = New System.Drawing.Point(143, 122)
        Me.Banda_idTextBox1.Name = "Banda_idTextBox1"
        Me.Banda_idTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.Banda_idTextBox1.TabIndex = 1
        '
        'Banda_nameLabel
        '
        Banda_nameLabel.AutoSize = True
        Banda_nameLabel.Location = New System.Drawing.Point(46, 153)
        Banda_nameLabel.Name = "Banda_nameLabel"
        Banda_nameLabel.Size = New System.Drawing.Size(91, 17)
        Banda_nameLabel.TabIndex = 2
        Banda_nameLabel.Text = "banda name:"
        '
        'Banda_nameTextBox
        '
        Me.Banda_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BandaBindingSource, "banda_name", True))
        Me.Banda_nameTextBox.Location = New System.Drawing.Point(143, 150)
        Me.Banda_nameTextBox.Name = "Banda_nameTextBox"
        Me.Banda_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Banda_nameTextBox.TabIndex = 3
        '
        'BindingNavigator7
        '
        Me.BindingNavigator7.AddNewItem = Me.BindingNavigatorAddNewItem2
        Me.BindingNavigator7.BindingSource = Me.BandaBindingSource
        Me.BindingNavigator7.CountItem = Me.BindingNavigatorCountItem7
        Me.BindingNavigator7.DeleteItem = Me.BindingNavigatorDeleteItem2
        Me.BindingNavigator7.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem7, Me.BindingNavigatorMovePreviousItem7, Me.BindingNavigatorSeparator21, Me.BindingNavigatorPositionItem7, Me.BindingNavigatorCountItem7, Me.BindingNavigatorSeparator22, Me.BindingNavigatorMoveNextItem7, Me.BindingNavigatorMoveLastItem7, Me.BindingNavigatorSeparator23, Me.BindingNavigatorAddNewItem2, Me.BindingNavigatorDeleteItem2})
        Me.BindingNavigator7.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator7.MoveFirstItem = Me.BindingNavigatorMoveFirstItem7
        Me.BindingNavigator7.MoveLastItem = Me.BindingNavigatorMoveLastItem7
        Me.BindingNavigator7.MoveNextItem = Me.BindingNavigatorMoveNextItem7
        Me.BindingNavigator7.MovePreviousItem = Me.BindingNavigatorMovePreviousItem7
        Me.BindingNavigator7.Name = "BindingNavigator7"
        Me.BindingNavigator7.PositionItem = Me.BindingNavigatorPositionItem7
        Me.BindingNavigator7.Size = New System.Drawing.Size(736, 27)
        Me.BindingNavigator7.TabIndex = 4
        Me.BindingNavigator7.Text = "BindingNavigator7"
        '
        'BindingNavigatorMoveFirstItem7
        '
        Me.BindingNavigatorMoveFirstItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem7.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem7.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem7.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem7.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem7.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem7.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem7
        '
        Me.BindingNavigatorMovePreviousItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem7.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem7.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem7.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem7.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem7.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem7.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator21
        '
        Me.BindingNavigatorSeparator21.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator21.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem7
        '
        Me.BindingNavigatorPositionItem7.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem7.AutoSize = False
        Me.BindingNavigatorPositionItem7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem7.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem7.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem7.Text = "0"
        Me.BindingNavigatorPositionItem7.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem7
        '
        Me.BindingNavigatorCountItem7.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem7.Size = New System.Drawing.Size(55, 24)
        Me.BindingNavigatorCountItem7.Text = "для {0}"
        Me.BindingNavigatorCountItem7.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator22
        '
        Me.BindingNavigatorSeparator22.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator22.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem7
        '
        Me.BindingNavigatorMoveNextItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem7.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem7.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem7.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem7.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem7.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem7.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem7
        '
        Me.BindingNavigatorMoveLastItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem7.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem7.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem7.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem7.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem7.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem7.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator23
        '
        Me.BindingNavigatorSeparator23.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator23.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorAddNewItem2
        '
        Me.BindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem2.Image = CType(resources.GetObject("BindingNavigatorAddNewItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem2.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem2.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem2.Text = "Добавить"
        '
        'BindingNavigatorDeleteItem2
        '
        Me.BindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem2.Image = CType(resources.GetObject("BindingNavigatorDeleteItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem2.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem2.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem2.Text = "Удалить"
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.BindingNavigator8)
        Me.TabPage10.Controls.Add(Album_idLabel1)
        Me.TabPage10.Controls.Add(Me.Album_idTextBox1)
        Me.TabPage10.Controls.Add(Album_nameLabel)
        Me.TabPage10.Controls.Add(Me.Album_nameTextBox)
        Me.TabPage10.Controls.Add(Music_idLabel1)
        Me.TabPage10.Controls.Add(Me.Music_idTextBox1)
        Me.TabPage10.Controls.Add(Banda_idLabel2)
        Me.TabPage10.Controls.Add(Me.Banda_idTextBox2)
        Me.TabPage10.Location = New System.Drawing.Point(4, 25)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(948, 518)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "TabPage10"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'AlbumBindingSource1
        '
        Me.AlbumBindingSource1.DataMember = "Album"
        Me.AlbumBindingSource1.DataSource = Me.BTM2DataSet
        '
        'AlbumTableAdapter
        '
        Me.AlbumTableAdapter.ClearBeforeFill = True
        '
        'Album_idLabel1
        '
        Album_idLabel1.AutoSize = True
        Album_idLabel1.Location = New System.Drawing.Point(48, 137)
        Album_idLabel1.Name = "Album_idLabel1"
        Album_idLabel1.Size = New System.Drawing.Size(65, 17)
        Album_idLabel1.TabIndex = 0
        Album_idLabel1.Text = "album id:"
        '
        'Album_idTextBox1
        '
        Me.Album_idTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlbumBindingSource1, "album_id", True))
        Me.Album_idTextBox1.Location = New System.Drawing.Point(143, 134)
        Me.Album_idTextBox1.Name = "Album_idTextBox1"
        Me.Album_idTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.Album_idTextBox1.TabIndex = 1
        '
        'Album_nameLabel
        '
        Album_nameLabel.AutoSize = True
        Album_nameLabel.Location = New System.Drawing.Point(48, 165)
        Album_nameLabel.Name = "Album_nameLabel"
        Album_nameLabel.Size = New System.Drawing.Size(89, 17)
        Album_nameLabel.TabIndex = 2
        Album_nameLabel.Text = "album name:"
        '
        'Album_nameTextBox
        '
        Me.Album_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlbumBindingSource1, "album_name", True))
        Me.Album_nameTextBox.Location = New System.Drawing.Point(143, 162)
        Me.Album_nameTextBox.Name = "Album_nameTextBox"
        Me.Album_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Album_nameTextBox.TabIndex = 3
        '
        'Music_idLabel1
        '
        Music_idLabel1.AutoSize = True
        Music_idLabel1.Location = New System.Drawing.Point(48, 193)
        Music_idLabel1.Name = "Music_idLabel1"
        Music_idLabel1.Size = New System.Drawing.Size(63, 17)
        Music_idLabel1.TabIndex = 4
        Music_idLabel1.Text = "music id:"
        '
        'Music_idTextBox1
        '
        Me.Music_idTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlbumBindingSource1, "music_id", True))
        Me.Music_idTextBox1.Location = New System.Drawing.Point(143, 190)
        Me.Music_idTextBox1.Name = "Music_idTextBox1"
        Me.Music_idTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.Music_idTextBox1.TabIndex = 5
        '
        'Banda_idLabel2
        '
        Banda_idLabel2.AutoSize = True
        Banda_idLabel2.Location = New System.Drawing.Point(48, 221)
        Banda_idLabel2.Name = "Banda_idLabel2"
        Banda_idLabel2.Size = New System.Drawing.Size(67, 17)
        Banda_idLabel2.TabIndex = 6
        Banda_idLabel2.Text = "banda id:"
        '
        'Banda_idTextBox2
        '
        Me.Banda_idTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlbumBindingSource1, "banda_id", True))
        Me.Banda_idTextBox2.Location = New System.Drawing.Point(143, 218)
        Me.Banda_idTextBox2.Name = "Banda_idTextBox2"
        Me.Banda_idTextBox2.Size = New System.Drawing.Size(100, 22)
        Me.Banda_idTextBox2.TabIndex = 7
        '
        'BindingNavigator8
        '
        Me.BindingNavigator8.AddNewItem = Me.BindingNavigatorAddNewItem3
        Me.BindingNavigator8.BindingSource = Me.AlbumBindingSource1
        Me.BindingNavigator8.CountItem = Me.BindingNavigatorCountItem8
        Me.BindingNavigator8.DeleteItem = Me.BindingNavigatorDeleteItem3
        Me.BindingNavigator8.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem8, Me.BindingNavigatorMovePreviousItem8, Me.BindingNavigatorSeparator24, Me.BindingNavigatorPositionItem8, Me.BindingNavigatorCountItem8, Me.BindingNavigatorSeparator25, Me.BindingNavigatorMoveNextItem8, Me.BindingNavigatorMoveLastItem8, Me.BindingNavigatorSeparator26, Me.BindingNavigatorAddNewItem3, Me.BindingNavigatorDeleteItem3})
        Me.BindingNavigator8.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator8.MoveFirstItem = Me.BindingNavigatorMoveFirstItem8
        Me.BindingNavigator8.MoveLastItem = Me.BindingNavigatorMoveLastItem8
        Me.BindingNavigator8.MoveNextItem = Me.BindingNavigatorMoveNextItem8
        Me.BindingNavigator8.MovePreviousItem = Me.BindingNavigatorMovePreviousItem8
        Me.BindingNavigator8.Name = "BindingNavigator8"
        Me.BindingNavigator8.PositionItem = Me.BindingNavigatorPositionItem8
        Me.BindingNavigator8.Size = New System.Drawing.Size(942, 27)
        Me.BindingNavigator8.TabIndex = 8
        Me.BindingNavigator8.Text = "BindingNavigator8"
        '
        'BindingNavigatorMoveFirstItem8
        '
        Me.BindingNavigatorMoveFirstItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem8.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem8.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem8.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem8.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem8.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem8.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem8
        '
        Me.BindingNavigatorMovePreviousItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem8.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem8.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem8.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem8.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem8.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem8.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator24
        '
        Me.BindingNavigatorSeparator24.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator24.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem8
        '
        Me.BindingNavigatorPositionItem8.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem8.AutoSize = False
        Me.BindingNavigatorPositionItem8.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem8.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem8.Text = "0"
        Me.BindingNavigatorPositionItem8.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem8
        '
        Me.BindingNavigatorCountItem8.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem8.Size = New System.Drawing.Size(55, 24)
        Me.BindingNavigatorCountItem8.Text = "для {0}"
        Me.BindingNavigatorCountItem8.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator25
        '
        Me.BindingNavigatorSeparator25.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator25.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem8
        '
        Me.BindingNavigatorMoveNextItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem8.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem8.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem8.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem8.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem8.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem8.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem8
        '
        Me.BindingNavigatorMoveLastItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem8.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem8.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem8.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem8.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem8.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem8.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator26
        '
        Me.BindingNavigatorSeparator26.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator26.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorAddNewItem3
        '
        Me.BindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem3.Image = CType(resources.GetObject("BindingNavigatorAddNewItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem3.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem3.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem3.Text = "Добавить"
        '
        'BindingNavigatorDeleteItem3
        '
        Me.BindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem3.Image = CType(resources.GetObject("BindingNavigatorDeleteItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem3.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem3.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem3.Text = "Удалить"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 550)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.StateBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StateBindingNavigator.ResumeLayout(False)
        Me.StateBindingNavigator.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.StateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTM2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SingerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.MusicGenreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.MusicBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator4.ResumeLayout(False)
        Me.BindingNavigator4.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.ImagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.GroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator5.ResumeLayout(False)
        Me.BindingNavigator5.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator6.ResumeLayout(False)
        Me.BindingNavigator6.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        CType(Me.BandaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator7.ResumeLayout(False)
        Me.BindingNavigator7.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        CType(Me.AlbumBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator8.ResumeLayout(False)
        Me.BindingNavigator8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTM2DataSet As BTM2DataSet
    Friend WithEvents StateBindingSource As BindingSource
    Friend WithEvents StateTableAdapter As BTM2DataSetTableAdapters.StateTableAdapter
    Friend WithEvents TableAdapterManager As BTM2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents State_idTextBox As TextBox
    Friend WithEvents State_nameTextBox As TextBox
    Friend WithEvents StateBindingNavigator As BindingNavigator
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
    Friend WithEvents StateBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents SingerTableAdapter As BTM2DataSetTableAdapters.SingerTableAdapter
    Friend WithEvents SingerBindingSource As BindingSource
    Friend WithEvents Singer_idTextBox As TextBox
    Friend WithEvents Singer_nameTextBox As TextBox
    Friend WithEvents City_idTextBox As TextBox
    Friend WithEvents Banda_idTextBox As TextBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents SingerTableAdapter1 As BTM2DataSetTableAdapters.SingerTableAdapter
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PostBindingSource As BindingSource
    Friend WithEvents PostTableAdapter As BTM2DataSetTableAdapters.PostTableAdapter
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem2 As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As ToolStripSeparator
    Friend WithEvents Post_idTextBox As TextBox
    Friend WithEvents Group_idTextBox As TextBox
    Friend WithEvents Image_idTextBox As TextBox
    Friend WithEvents Video_idTextBox As TextBox
    Friend WithEvents Album_idTextBox As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents MusicGenreBindingSource As BindingSource
    Friend WithEvents MusicGenreTableAdapter As BTM2DataSetTableAdapters.MusicGenreTableAdapter
    Friend WithEvents BindingNavigator3 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem3 As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator9 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem3 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator10 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator11 As ToolStripSeparator
    Friend WithEvents Musicgenre_idTextBox As TextBox
    Friend WithEvents Musicgenre_nameTextBox As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents MusicBindingSource As BindingSource
    Friend WithEvents MusicTableAdapter As BTM2DataSetTableAdapters.MusicTableAdapter
    Friend WithEvents BindingNavigator4 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem4 As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem4 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem4 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator12 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem4 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator13 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem4 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem4 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator14 As ToolStripSeparator
    Friend WithEvents Music_idTextBox As TextBox
    Friend WithEvents Music_nameTextBox As TextBox
    Friend WithEvents Musicgenre_idTextBox1 As TextBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents ImagesBindingSource As BindingSource
    Friend WithEvents ImagesTableAdapter As BTM2DataSetTableAdapters.ImagesTableAdapter
    Friend WithEvents ImagesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents GroupsBindingSource As BindingSource
    Friend WithEvents GroupsTableAdapter As BTM2DataSetTableAdapters.GroupsTableAdapter
    Friend WithEvents BindingNavigator5 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem5 As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem5 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem5 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator15 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem5 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator16 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem5 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem5 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator17 As ToolStripSeparator
    Friend WithEvents Group_idTextBox1 As TextBox
    Friend WithEvents Group_nameTextBox As TextBox
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents CityBindingSource As BindingSource
    Friend WithEvents CityTableAdapter As BTM2DataSetTableAdapters.CityTableAdapter
    Friend WithEvents BindingNavigator6 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem6 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem6 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem6 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator18 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem6 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator19 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem6 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem6 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator20 As ToolStripSeparator
    Friend WithEvents City_idTextBox1 As TextBox
    Friend WithEvents City_nameTextBox As TextBox
    Friend WithEvents State_idTextBox1 As TextBox
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents BandaBindingSource As BindingSource
    Friend WithEvents BandaTableAdapter As BTM2DataSetTableAdapters.BandaTableAdapter
    Friend WithEvents BindingNavigator7 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem7 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem7 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem7 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator21 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem7 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator22 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem7 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem7 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator23 As ToolStripSeparator
    Friend WithEvents Banda_idTextBox1 As TextBox
    Friend WithEvents Banda_nameTextBox As TextBox
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents AlbumBindingSource1 As BindingSource
    Friend WithEvents AlbumTableAdapter As BTM2DataSetTableAdapters.AlbumTableAdapter
    Friend WithEvents BindingNavigator8 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem8 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem8 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem8 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator24 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem8 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator25 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem8 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem8 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator26 As ToolStripSeparator
    Friend WithEvents Album_idTextBox1 As TextBox
    Friend WithEvents Album_nameTextBox As TextBox
    Friend WithEvents Music_idTextBox1 As TextBox
    Friend WithEvents Banda_idTextBox2 As TextBox
End Class
