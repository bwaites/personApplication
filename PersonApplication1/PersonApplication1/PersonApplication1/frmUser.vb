Imports BusinessObjects

Public Class frmUser

    Private WithEvents user As UserList
    Private WithEvents stories As StoryList
    Private WithEvents fandoms As StoryFandomList
    Private WithEvents genres As GenreList
   
    

    Private Sub frmUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
        user = New UserList
        Me.dgvUser.AutoGenerateColumns = False
        Me.dgvUser.DataSource = user.Search().List
        Me.dgvStory.AutoGenerateColumns = False


        Me.dgvFandom.AutoGenerateColumns = False

        Me.dgvGenre.AutoGenerateColumns = False




    End Sub


    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        user = New UserList
        user.UserName = Me.txtUserName.Text
        user = user.Search
        Me.dgvUser.DataSource = user.List

    End Sub

    Private Sub mnuSave_Click(sender As System.Object, e As System.EventArgs) Handles mnuSave.Click
        If user.IsSavable = True Then
            user = user.Save()

        End If
    End Sub



    Private Sub dgvUser_RowHeaderMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvUser.RowHeaderMouseClick
        Dim user As User = dgvUser.SelectedRows(0).DataBoundItem
        If user IsNot Nothing Then

            dgvStory.DataSource = stories.List
            dgvFandom.DataSource = fandoms.List
            dgvGenre.DataSource = genres.List
        End If
    End Sub

    Private Sub SetStories(ByVal column As DataGridViewTextBoxColumn)
        With column
            If column Is Nothing Then
                dgvStory.DataSource = stories.List
                
            End If
        End With
    End Sub


    Private Sub dgvStory_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvStory.CellFormatting
        If e.ColumnIndex = 1 AndAlso dgvStory IsNot Nothing Then
            SetStories(dgvStory.Columns(1))
        End If


    End Sub


    Private Sub dgvStory_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvStory.DataError

    End Sub

    Private Sub SetFandoms(ByVal column As DataGridViewComboBoxColumn)
        With column
            If .DataSource Is Nothing Then
                .DataSource = fandoms.List
                .DisplayMember = "FandomName"
                .ValueMember = "ID"
            End If
        End With
    End Sub

    Private Sub dgvFandom_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If e.ColumnIndex = 1 AndAlso dgvFandom IsNot Nothing Then
            SetFandoms(dgvFandom.Columns(1))
        End If
    End Sub

    Private Sub dgvFandom_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvFandom.DataError

    End Sub






    Private Sub SetGenres(ByVal column As DataGridViewComboBoxColumn)
        With column
            If .DataSource Is Nothing Then
                .DataSource = genres.List
                .DisplayMember = "GenreType"
                .ValueMember = "ID"
            End If
        End With
    End Sub


    Private Sub dgvGenre_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If e.ColumnIndex = 1 AndAlso dgvGenre IsNot Nothing Then
            SetGenres(dgvGenre.Columns(4))
        End If
    End Sub




End Class