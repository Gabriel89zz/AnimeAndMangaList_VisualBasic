Imports Newtonsoft.Json
Imports ClosedXML.Excel
Imports System.Xml
Imports Xceed.Words.NET
Imports Xceed.Document.NET
Imports System.IO

Public Class FrmAnime
    Private animes As Anime()

    Public Sub New()
        InitializeComponent()
        animes = New Anime(49) {}
    End Sub
    Private Sub btnLoadDataAnime_Click(sender As Object, e As EventArgs) Handles btnLoadDataAnime.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "TXT files (*.txt)|*.txt"
            openFileDialog.RestoreDirectory = True

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = openFileDialog.FileName
                Try
                    Dim lines() As String = File.ReadAllLines(filePath)

                    For Each line As String In lines
                        Dim fields() As String = line.Split("|"c)
                        Dim emptyIndex As Integer = -1
                        For i As Integer = 0 To animes.Length - 1
                            If animes(i) Is Nothing Then
                                emptyIndex = i
                                Exit For
                            End If
                        Next

                        If emptyIndex = -1 Then
                            MessageBox.Show("The array is full. You need to delete some entries to add new ones.", "Array Full", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If

                        animes(emptyIndex) = New Anime(fields(0), fields(1), fields(2), DateTime.Parse(fields(3)), Convert.ToInt32(fields(4)), fields(5), fields(6), Convert.ToInt32(fields(7)))

                        Dim item As New ListViewItem(animes(emptyIndex).Title)
                        item.SubItems.Add(animes(emptyIndex).Author)
                        item.SubItems.Add(animes(emptyIndex).Genre)
                        item.SubItems.Add(animes(emptyIndex).ReleaseYear.ToShortDateString())
                        item.SubItems.Add(animes(emptyIndex).NumberOfSeasons.ToString())
                        item.SubItems.Add(animes(emptyIndex).ProductionStudio)
                        item.SubItems.Add(animes(emptyIndex).Platform)
                        item.SubItems.Add(animes(emptyIndex).Rating.ToString())

                        lstvDataAnime.Items.Add(item)
                    Next

                    MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnSaveAnime_Click(sender As Object, e As EventArgs) Handles btnSaveAnime.Click
        Try
            If String.IsNullOrWhiteSpace(txtTitleAnime.Text) Or
           String.IsNullOrWhiteSpace(txtAuthorAnime.Text) Or
           String.IsNullOrWhiteSpace(cbGenreAnime.Text) Or
           String.IsNullOrWhiteSpace(txtChaptersAnime.Text) Or
           String.IsNullOrWhiteSpace(cbPlataform.Text) Or
           String.IsNullOrWhiteSpace(txtProductionStudio.Text) Then

                MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If dtpDateAnime.Value > DateTime.Now Then
                MessageBox.Show("The selected date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim chapters As Integer
            If Not Integer.TryParse(txtChaptersAnime.Text, chapters) Or chapters < 0 Then
                MessageBox.Show("Chapters must be a non-negative integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim emptyIndex As Integer = -1
            For i As Integer = 0 To animes.Length - 1
                If animes(i) Is Nothing Then
                    emptyIndex = i
                    Exit For
                End If
            Next

            If emptyIndex = -1 Then
                Dim result As DialogResult = MessageBox.Show("The array is full. Do you want to delete all entries to add new ones?",
                                                         "Array Full", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    For i As Integer = 0 To animes.Length - 1
                        animes(i) = Nothing
                    Next

                    lstvDataAnime.Items.Clear()

                    emptyIndex = 0
                Else
                    Return
                End If
            End If

            animes(emptyIndex) = New Anime(txtTitleAnime.Text,
                                       txtAuthorAnime.Text,
                                       cbGenreAnime.Text,
                                       dtpDateAnime.Value,
                                       Convert.ToInt32(txtChaptersAnime.Text),
                                       txtProductionStudio.Text,
                                       cbPlataform.Text,
                                       Convert.ToInt32(nudRatingAnime.Value))

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
            Dim numberItemsSelected As Integer = lstvDataAnime.SelectedItems.Count
            Dim selectedIndices As Integer() = New Integer(lstvDataAnime.SelectedItems.Count - 1) {}

            For i As Integer = 0 To numberItemsSelected - 1
                selectedIndices(i) = lstvDataAnime.SelectedItems(i).Index
            Next

            Array.Sort(selectedIndices)
            Array.Reverse(selectedIndices)

            For i As Integer = 0 To numberItemsSelected - 1
                lstvDataAnime.Items.RemoveAt(selectedIndices(i))
            Next

            Dim updatedAnimes As Anime() = New Anime(animes.Length - numberItemsSelected - 1) {}

            Dim newIndex As Integer = 0
            For i As Integer = 0 To animes.Length - 1
                If Array.IndexOf(selectedIndices, i) = -1 Then
                    updatedAnimes(newIndex) = animes(i)
                    newIndex += 1
                End If
            Next

            animes = updatedAnimes

            MessageBox.Show("Selected animes have been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please select a anime to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                        ExportAnimeToJson(filePath)
                    Case ".xml"
                        ExportAnimeToXml(filePath)
                    Case ".xlsx"
                        ExportAnimeToExcel(filePath)
                    Case ".docx"
                        ExportAnimeToWord(filePath)
                    Case ".txt"
                        ExportAnimeToTxt(filePath)
                    Case Else
                        MessageBox.Show("Unsupported file format selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select

                MessageBox.Show("Data exported successfully to " & filePath, "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub ExportAnimeToJson(ByVal filePath As String)
        Dim filteredAnimes As Anime() = Array.FindAll(animes, Function(m) m IsNot Nothing)
        Dim json As String = JsonConvert.SerializeObject(filteredAnimes, Newtonsoft.Json.Formatting.Indented)
        File.WriteAllText(filePath, json)
        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
    End Sub

    Private Sub ExportAnimeToXml(filePath As String)
        Dim doc As New XmlDocument()
        Dim root As XmlElement = doc.CreateElement("Animes")
        doc.AppendChild(root)

        For Each anime As Anime In animes.Where(Function(m) m IsNot Nothing)
            Dim animeElement As XmlElement = doc.CreateElement("Anime")

            Dim titleElement As XmlElement = doc.CreateElement("Title")
            titleElement.InnerText = anime.Title
            animeElement.AppendChild(titleElement)

            Dim authorElement As XmlElement = doc.CreateElement("Author")
            authorElement.InnerText = anime.Author
            animeElement.AppendChild(authorElement)

            Dim genreElement As XmlElement = doc.CreateElement("Genre")
            genreElement.InnerText = anime.Genre
            animeElement.AppendChild(genreElement)

            Dim releaseYearElement As XmlElement = doc.CreateElement("ReleaseYear")
            releaseYearElement.InnerText = anime.ReleaseYear.ToShortDateString()
            animeElement.AppendChild(releaseYearElement)

            Dim numberOfSeasonsElements As XmlElement = doc.CreateElement("NumberofChapters")
            numberOfSeasonsElements.InnerText = anime.NumberOfSeasons.ToString()
            animeElement.AppendChild(numberOfSeasonsElements)

            Dim editorialElement As XmlElement = doc.CreateElement("Platform")
            editorialElement.InnerText = anime.Platform
            animeElement.AppendChild(editorialElement)

            Dim ratingElement As XmlElement = doc.CreateElement("Rating")
            ratingElement.InnerText = anime.Rating.ToString()
            animeElement.AppendChild(ratingElement)

            Dim priceElement As XmlElement = doc.CreateElement("ProductionStudio")
            priceElement.InnerText = anime.ProductionStudio.ToString()
            animeElement.AppendChild(priceElement)

            root.AppendChild(animeElement)
        Next

        doc.Save(filePath)
        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
    End Sub

    Private Sub ExportAnimeToExcel(ByVal filePath As String)
        Using workbook As New XLWorkbook()
            Dim worksheet = workbook.Worksheets.Add("Animes")

            worksheet.Cell(1, 1).Value = "Title"
            worksheet.Cell(1, 2).Value = "Author"
            worksheet.Cell(1, 3).Value = "Genre"
            worksheet.Cell(1, 4).Value = "ReleaseYear"
            worksheet.Cell(1, 5).Value = "Number of Chapters"
            worksheet.Cell(1, 6).Value = "Platform"
            worksheet.Cell(1, 7).Value = "Rating"
            worksheet.Cell(1, 8).Value = "Production Studio"

            Dim rowIndex As Integer = 2

            For Each anime As Anime In animes.Where(Function(m) m IsNot Nothing)
                worksheet.Cell(rowIndex, 1).Value = anime.Title
                worksheet.Cell(rowIndex, 2).Value = anime.Author
                worksheet.Cell(rowIndex, 3).Value = anime.Genre
                worksheet.Cell(rowIndex, 4).Value = anime.ReleaseYear.ToShortDateString()
                worksheet.Cell(rowIndex, 5).Value = anime.NumberOfSeasons
                worksheet.Cell(rowIndex, 6).Value = anime.Platform
                worksheet.Cell(rowIndex, 7).Value = anime.Rating
                worksheet.Cell(rowIndex, 8).Value = anime.ProductionStudio

                rowIndex += 1
            Next

            workbook.SaveAs(filePath)
        End Using
        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
    End Sub

    Private Sub ExportAnimeToWord(ByVal filePath As String)
        Using document As DocX = DocX.Create(filePath)
            document.InsertParagraph("Anime List").FontSize(15).Bold().Alignment = Alignment.center

            Dim animeCount As Integer = animes.Count(Function(m) m IsNot Nothing)
            Dim table As Table = document.AddTable(animeCount + 1, 8)

            table.Rows(0).Cells(0).Paragraphs(0).Append("Title")
            table.Rows(0).Cells(1).Paragraphs(0).Append("Author")
            table.Rows(0).Cells(2).Paragraphs(0).Append("Genre")
            table.Rows(0).Cells(3).Paragraphs(0).Append("ReleaseYear")
            table.Rows(0).Cells(4).Paragraphs(0).Append("Number of Chapters")
            table.Rows(0).Cells(5).Paragraphs(0).Append("Platform")
            table.Rows(0).Cells(6).Paragraphs(0).Append("Rating")
            table.Rows(0).Cells(7).Paragraphs(0).Append("Production Studio")

            Dim rowIndex As Integer = 1
            For Each manga As Anime In animes.Where(Function(m) m IsNot Nothing)
                table.Rows(rowIndex).Cells(0).Paragraphs(0).Append(manga.Title)
                table.Rows(rowIndex).Cells(1).Paragraphs(0).Append(manga.Author)
                table.Rows(rowIndex).Cells(2).Paragraphs(0).Append(manga.Genre)
                table.Rows(rowIndex).Cells(3).Paragraphs(0).Append(manga.ReleaseYear.ToShortDateString())
                table.Rows(rowIndex).Cells(4).Paragraphs(0).Append(manga.NumberOfSeasons.ToString())
                table.Rows(rowIndex).Cells(5).Paragraphs(0).Append(manga.Platform)
                table.Rows(rowIndex).Cells(6).Paragraphs(0).Append(manga.Rating.ToString())
                table.Rows(rowIndex).Cells(7).Paragraphs(0).Append(manga.ProductionStudio)
                rowIndex += 1
            Next

            document.InsertTable(table)
            document.Save()
        End Using
        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
    End Sub

    Private Sub ExportAnimeToTxt(ByVal filePath As String)
        Using writer As New StreamWriter(filePath)
            For Each anime As Anime In animes.Where(Function(m) m IsNot Nothing)
                writer.WriteLine(anime.ToString())
            Next
        End Using
        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
    End Sub


    Private Sub btnGetStatsAnime_Click(sender As Object, e As EventArgs) Handles btnGetStatsAnime.Click
        Anime.GetStatsAnime(animes)
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

    Private Sub btnSimilarAnimes_Click(sender As Object, e As EventArgs) Handles btnSimilarAnimes.Click
        If lstvDataAnime.SelectedIndices.Count > 0 Then
            MessageBox.Show(animes(lstvDataAnime.SelectedIndices(0)).ShowSimilarWorks(), "Mangas Similares", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se ha seleccionado ningún manga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class