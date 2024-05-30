Imports System.IO

Public Class FrmAnime
    Private animes As Anime()

    Public Sub New()
        InitializeComponent()
        animes = New Anime(49) {}
        cbGenreAnime.DataSource = Manga.GetMangaGenres()
    End Sub
    Private Sub btnLoadDataAnime_Click(sender As Object, e As EventArgs) Handles btnLoadDataAnime.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "TXT files (*.txt)|*.txt"
            openFileDialog.RestoreDirectory = True

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = openFileDialog.FileName
                Anime.LoadAnimeDataFromTextFile(filePath, animes, lstvDataAnime)
            End If
        End Using

    End Sub

    Private Sub btnSaveAnime_Click(sender As Object, e As EventArgs) Handles btnSaveAnime.Click
        Try
            If String.IsNullOrWhiteSpace(txtTitleAnime.Text) OrElse
        String.IsNullOrWhiteSpace(txtAuthorAnime.Text) OrElse
        String.IsNullOrWhiteSpace(cbGenreAnime.Text) OrElse
        String.IsNullOrWhiteSpace(txtChaptersAnime.Text) OrElse
        String.IsNullOrWhiteSpace(cbPlataform.Text) OrElse
        String.IsNullOrWhiteSpace(txtProductionStudio.Text) Then

                MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If dtpDateAnime.Value > DateTime.Now Then
                MessageBox.Show("The selected date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim chapters As Integer
            If Not Integer.TryParse(txtChaptersAnime.Text, chapters) OrElse chapters < 0 Then
                MessageBox.Show("Chapters must be a non-negative integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim emptyIndex As Integer = Array.FindIndex(animes, Function(m) m Is Nothing)

            If emptyIndex = -1 Then
                MessageBox.Show("The array is full. You need to delete some entries to add new ones.", "Array Full", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            animes(emptyIndex) = New Anime(
        txtTitleAnime.Text,
        txtAuthorAnime.Text,
        cbGenreAnime.Text,
        dtpDateAnime.Value,
        Convert.ToInt32(txtChaptersAnime.Text),
        txtProductionStudio.Text,
        cbPlataform.Text,
        Convert.ToInt32(nudRatingAnime.Value)
    )

            Dim item As New ListViewItem(animes(emptyIndex).Title)
            item.SubItems.Add(animes(emptyIndex).Author)
            item.SubItems.Add(animes(emptyIndex).Genre)
            item.SubItems.Add(animes(emptyIndex).ReleaseYear.ToShortDateString())
            item.SubItems.Add(animes(emptyIndex).NumberOfSeasons.ToString())
            item.SubItems.Add(animes(emptyIndex).ProductionStudio)
            item.SubItems.Add(animes(emptyIndex).Platform)
            item.SubItems.Add(animes(emptyIndex).Rating.ToString())

            lstvDataAnime.Items.Add(item)
            ClearInputsAnime()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ClearInputsAnime()
        txtAuthorAnime.Text = ""
        txtChaptersAnime.Text = ""
        cbPlataform.Text = ""
        txtProductionStudio.Text = ""
        txtTitleAnime.Text = ""
        nudRatingAnime.Value = 0
        dtpDateAnime.Value = DateTime.Now
    End Sub

    Private Sub btnDeleteAnime_Click(sender As Object, e As EventArgs) Handles btnDeleteAnime.Click
        If lstvDataAnime.SelectedItems.Count > 0 Then
            For i As Integer = lstvDataAnime.SelectedItems.Count - 1 To 0 Step -1
                Dim selectedAnime As ListViewItem = lstvDataAnime.SelectedItems(i)
                Dim selectedIndex As Integer = selectedAnime.Index
                lstvDataAnime.Items.RemoveAt(selectedIndex)
                animes(selectedIndex) = Nothing
            Next

            MessageBox.Show("Selected animes have been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please select an anime to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnExportAnime_Click(sender As Object, e As EventArgs) Handles btnExportAnime.Click
        Using sfd As New SaveFileDialog()
            sfd.Filter = "JSON Files|*.json|XML Files|*.xml|Excel Files|*.xlsx|Word Files|*.docx|Text Files|*.txt"
            sfd.Title = "Save an Export File"
            sfd.FileName = "ExportedData"

            If sfd.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = sfd.FileName
                Dim extension As String = Path.GetExtension(filePath)

                Select Case extension.ToLower()
                    Case ".json"
                        Anime.ExportAnimeToJson(filePath, animes)
                    Case ".xml"
                        Anime.ExportAnimeToXml(filePath, animes)
                    Case ".xlsx"
                        Anime.ExportAnimeToExcel(filePath, animes)
                    Case ".docx"
                        Anime.ExportAnimeToWord(filePath, animes)
                    Case ".txt"
                        Anime.ExportAnimeToTxt(filePath, animes)
                    Case Else
                        MessageBox.Show("Unsupported file format selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select

                MessageBox.Show("Data exported successfully to " & filePath, "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using

    End Sub

    Private Sub btnGetStatsAnime_Click(sender As Object, e As EventArgs) Handles btnGetStatsAnime.Click
        MessageBox.Show(Anime.GetStatsAnime(animes))

    End Sub

    Private Sub SaveReviewAnime_Click(sender As Object, e As EventArgs) Handles SaveReviewAnime.Click
        Try
            Dim saveFileDialog1 As New SaveFileDialog()

            saveFileDialog1.Title = "Save Review Anime File"
            saveFileDialog1.DefaultExt = "txt"
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveFileDialog1.FileName

                File.WriteAllText(filePath, txtReviewAnime.Text)

                MessageBox.Show("Review saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the review: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class