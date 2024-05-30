
Imports System.IO

Public Class FrmManga
    Private mangas As Manga()

    Public Sub New()
        InitializeComponent()
        mangas = New Manga(49) {}
        cbGenre.DataSource = Manga.GetMangaGenres()
    End Sub
    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "TXT files (*.txt)|*.txt"
            openFileDialog.RestoreDirectory = True

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = openFileDialog.FileName
                Manga.LoadMangaDataFromTextFile(filePath, mangas, lstvDataManga)
            End If
        End Using
    End Sub

    Private Sub btnExportManga_Click(sender As Object, e As EventArgs) Handles btnExportManga.Click
        Using sfd As New SaveFileDialog()
            sfd.Filter = "JSON Files|*.json|XML Files|*.xml|Excel Files|*.xlsx|Word Files|*.docx|Text Files|*.txt"
            sfd.Title = "Save an Export File"
            sfd.FileName = "ExportedData"

            If sfd.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = sfd.FileName
                Dim extension As String = Path.GetExtension(filePath).ToLower()

                Select Case extension
                    Case ".json"
                        Manga.ExportMangaToJson(filePath, mangas)
                    Case ".xml"
                        Manga.ExportMangaToXml(filePath, mangas)
                    Case ".xlsx"
                        Manga.ExportMangaToExcel(filePath, mangas)
                    Case ".docx"
                        Manga.ExportMangaToWord(filePath, mangas)
                    Case ".txt"
                        Manga.ExportMangaToTxt(filePath, mangas)
                    Case Else
                        MessageBox.Show("Unsupported file format selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select

                MessageBox.Show("Data exported successfully to " & filePath, "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub btnSaveManga_Click(sender As Object, e As EventArgs) Handles btnSaveManga.Click
        Try
            If String.IsNullOrWhiteSpace(txtTitle.Text) OrElse
        String.IsNullOrWhiteSpace(txtAuthor.Text) OrElse
        String.IsNullOrWhiteSpace(cbGenre.Text) OrElse
        String.IsNullOrWhiteSpace(txtChapters.Text) OrElse
        String.IsNullOrWhiteSpace(cbEditorial.Text) OrElse
        String.IsNullOrWhiteSpace(txtPrice.Text) Then

                MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If dtpDate.Value > DateTime.Now Then
                MessageBox.Show("The selected date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim chapters As Integer
            If Not Integer.TryParse(txtChapters.Text, chapters) OrElse chapters < 0 Then
                MessageBox.Show("Chapters must be a non-negative integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim price As Double
            If Not Double.TryParse(txtPrice.Text, price) OrElse price < 0 Then
                MessageBox.Show("Check that the price does not contain letters and that it does not contain a negative value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim emptyIndex As Integer = Array.FindIndex(mangas, Function(m) m Is Nothing)

            If emptyIndex = -1 Then
                MessageBox.Show("The array is full. You need to delete some entries to add new ones.", "Array Full", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            mangas(emptyIndex) = New Manga(
        txtTitle.Text,
        txtAuthor.Text,
        cbGenre.Text,
        dtpDate.Value,
        Convert.ToInt32(txtChapters.Text),
        cbEditorial.Text,
        Convert.ToInt32(nudRating.Value),
        Convert.ToDouble(txtPrice.Text)
    )

            Dim item As New ListViewItem(mangas(emptyIndex).Title)
            item.SubItems.Add(mangas(emptyIndex).Author)
            item.SubItems.Add(mangas(emptyIndex).Genre)
            item.SubItems.Add(mangas(emptyIndex).ReleaseYear.ToShortDateString())
            item.SubItems.Add(mangas(emptyIndex).Volume.ToString())
            item.SubItems.Add(mangas(emptyIndex).Editorial)
            item.SubItems.Add(mangas(emptyIndex).Rating.ToString())
            item.SubItems.Add(mangas(emptyIndex).Price.ToString())

            lstvDataManga.Items.Add(item)
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ClearInputs()
        txtAuthor.Text = ""
        txtChapters.Text = ""
        cbGenre.Text = ""
        txtPrice.Text = ""
        txtTitle.Text = ""
        nudRating.Value = 0
        dtpDate.Value = DateTime.Now
        cbEditorial.Text = ""
    End Sub

    Private Sub btnDeleteManga_Click(sender As Object, e As EventArgs) Handles btnDeleteManga.Click
        If lstvDataManga.SelectedItems.Count > 0 Then
            For i As Integer = lstvDataManga.SelectedItems.Count - 1 To 0 Step -1
                Dim selectedManga As ListViewItem = lstvDataManga.SelectedItems(i)
                Dim selectedIndex As Integer = selectedManga.Index
                lstvDataManga.Items.RemoveAt(selectedIndex)
                mangas(selectedIndex) = Nothing
            Next

            MessageBox.Show("Selected mangas have been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please select a manga to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnGetStatsManga_Click(sender As Object, e As EventArgs) Handles btnGetStatsManga.Click
        MessageBox.Show(Manga.GetStats(mangas))
    End Sub

    Private Sub SaveReviewManga_Click(sender As Object, e As EventArgs) Handles SaveReviewManga.Click
        Try
            Dim saveFileDialog1 As New SaveFileDialog()

            saveFileDialog1.Title = "Save Review File"
            saveFileDialog1.DefaultExt = "txt"
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveFileDialog1.FileName

                File.WriteAllText(filePath, txtReviewManga.Text)

                MessageBox.Show("Review saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the review: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class