Public Class Form1
    Private Sub AlbumBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AlbumBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BTM2DataSet)

    End Sub

    Private Function AlbumBindingSource() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub StateBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BTM2DataSet)

    End Sub

    Private Sub StateBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BTM2DataSet)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StateBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BTM2DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.State". При необходимости она может быть перемещена или удалена.
        Me.StateTableAdapter.Fill(Me.BTM2DataSet.State)

    End Sub

    Private Sub StateBindingNavigator_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub StateBindingNavigatorSaveItem_Click_3(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BTM2DataSet)

    End Sub

    Private Sub StateBindingNavigatorSaveItem_Click_4(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BTM2DataSet)

    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Album". При необходимости она может быть перемещена или удалена.
        Me.AlbumTableAdapter.Fill(Me.BTM2DataSet.Album)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Banda". При необходимости она может быть перемещена или удалена.
        Me.BandaTableAdapter.Fill(Me.BTM2DataSet.Banda)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.City". При необходимости она может быть перемещена или удалена.
        Me.CityTableAdapter.Fill(Me.BTM2DataSet.City)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Groups". При необходимости она может быть перемещена или удалена.
        Me.GroupsTableAdapter.Fill(Me.BTM2DataSet.Groups)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Groups". При необходимости она может быть перемещена или удалена.
        Me.GroupsTableAdapter.Fill(Me.BTM2DataSet.Groups)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Images". При необходимости она может быть перемещена или удалена.
        Me.ImagesTableAdapter.Fill(Me.BTM2DataSet.Images)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Music". При необходимости она может быть перемещена или удалена.
        Me.MusicTableAdapter.Fill(Me.BTM2DataSet.Music)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Music". При необходимости она может быть перемещена или удалена.
        Me.MusicTableAdapter.Fill(Me.BTM2DataSet.Music)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Music". При необходимости она может быть перемещена или удалена.
        Me.MusicTableAdapter.Fill(Me.BTM2DataSet.Music)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.MusicGenre". При необходимости она может быть перемещена или удалена.
        Me.MusicGenreTableAdapter.Fill(Me.BTM2DataSet.MusicGenre)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.MusicGenre". При необходимости она может быть перемещена или удалена.
        Me.MusicGenreTableAdapter.Fill(Me.BTM2DataSet.MusicGenre)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Post". При необходимости она может быть перемещена или удалена.
        Me.PostTableAdapter.Fill(Me.BTM2DataSet.Post)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Post". При необходимости она может быть перемещена или удалена.
        Me.PostTableAdapter.Fill(Me.BTM2DataSet.Post)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Post". При необходимости она может быть перемещена или удалена.
        Me.PostTableAdapter.Fill(Me.BTM2DataSet.Post)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Singer". При необходимости она может быть перемещена или удалена.
        Me.SingerTableAdapter.Fill(Me.BTM2DataSet.Singer)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Post". При необходимости она может быть перемещена или удалена.
        Me.PostTableAdapter.Fill(Me.BTM2DataSet.Post)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Singer". При необходимости она может быть перемещена или удалена.
        Me.SingerTableAdapter.Fill(Me.BTM2DataSet.Singer)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Singer". При необходимости она может быть перемещена или удалена.
        Me.SingerTableAdapter.Fill(Me.BTM2DataSet.Singer)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Singer". При необходимости она может быть перемещена или удалена.
        Me.SingerTableAdapter.Fill(Me.BTM2DataSet.Singer)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Singer". При необходимости она может быть перемещена или удалена.
        Me.SingerTableAdapter.Fill(Me.BTM2DataSet.Singer)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Singer". При необходимости она может быть перемещена или удалена.
        Me.SingerTableAdapter.Fill(Me.BTM2DataSet.Singer)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Singer". При необходимости она может быть перемещена или удалена.
        Me.SingerTableAdapter.Fill(Me.BTM2DataSet.Singer)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Singer". При необходимости она может быть перемещена или удалена.
        Me.SingerTableAdapter.Fill(Me.BTM2DataSet.Singer)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.Singer". При необходимости она может быть перемещена или удалена.
        Me.SingerTableAdapter.Fill(Me.BTM2DataSet.Singer)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BTM2DataSet.State". При необходимости она может быть перемещена или удалена.
        Me.StateTableAdapter.Fill(Me.BTM2DataSet.State)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub StateBindingNavigator_RefreshItems_1(sender As Object, e As EventArgs) Handles StateBindingNavigator.RefreshItems

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingNavigator7_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator7.RefreshItems

    End Sub

    Private Sub TabPage10_Click(sender As Object, e As EventArgs) Handles TabPage10.Click

    End Sub
End Class
