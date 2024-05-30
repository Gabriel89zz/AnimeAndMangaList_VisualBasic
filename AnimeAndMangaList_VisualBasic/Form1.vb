Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub btnAddManga_Click(sender As Object, e As EventArgs) Handles btnAddManga.Click
        Dim FrmManga = New FrmManga
        FrmManga.Show()
    End Sub

    Private Sub btnAddAnime_Click(sender As Object, e As EventArgs) Handles btnAddAnime.Click
        Dim FrmAnime = New FrmAnime
        FrmAnime.Show()
    End Sub
End Class
