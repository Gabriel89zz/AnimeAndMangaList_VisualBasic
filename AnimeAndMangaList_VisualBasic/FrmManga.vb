Imports Newtonsoft.Json
Imports ClosedXML.Excel
Imports System.Xml
Imports Xceed.Words.NET
Imports Xceed.Document.NET
Imports System.IO


Public Class FrmManga
    Private mangas As Manga()

    Public Sub New()
        InitializeComponent()
        mangas = New Manga(49) {}
    End Sub
    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
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
                        For i As Integer = 0 To mangas.Length - 1
                            If mangas(i) Is Nothing Then
                                emptyIndex = i
                                Exit For
                            End If
                        Next

                        If emptyIndex = -1 Then
                            MessageBox.Show("The array is full. You need to delete some entries to add new ones.", "Array Full", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If

                        mangas(emptyIndex) = New Manga(
                            fields(0),
                            fields(1),
                            fields(2),
                            DateTime.Parse(fields(3)),
                            Convert.ToInt32(fields(4)),
                            fields(5),
                            Convert.ToInt32(fields(6))
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
                    Next

                    MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
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
                        ExportMangaToJson(filePath)
                    Case ".xml"
                        ExportMangaToXml(filePath)
                    Case ".xlsx"
                        ExportMangaToExcel(filePath)
                    Case ".docx"
                        ExportMangaToWord(filePath)
                    Case ".txt"
                        ExportMangaToTxt(filePath)
                    Case Else
                        MessageBox.Show("Unsupported file format selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select

                MessageBox.Show("Data exported successfully to " & filePath, "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub ExportMangaToJson(filePath As String)
        Dim filteredMangas As Manga() = mangas.Where(Function(m) m IsNot Nothing).ToArray()
        Dim json As String = JsonConvert.SerializeObject(filteredMangas, Newtonsoft.Json.Formatting.Indented)
        File.WriteAllText(filePath, json)

        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
    End Sub

    Private Sub ExportMangaToXml(filePath As String)
        Dim doc As New XmlDocument()
        Dim root As XmlElement = doc.CreateElement("Mangas")
        doc.AppendChild(root)

        For Each manga As Manga In mangas.Where(Function(m) m IsNot Nothing)
            Dim mangaElement As XmlElement = doc.CreateElement("Manga")

            Dim titleElement As XmlElement = doc.CreateElement("Title")
            titleElement.InnerText = manga.Title
            mangaElement.AppendChild(titleElement)

            Dim authorElement As XmlElement = doc.CreateElement("Author")
            authorElement.InnerText = manga.Author
            mangaElement.AppendChild(authorElement)

            Dim genreElement As XmlElement = doc.CreateElement("Genre")
            genreElement.InnerText = manga.Genre
            mangaElement.AppendChild(genreElement)

            Dim releaseYearElement As XmlElement = doc.CreateElement("ReleaseYear")
            releaseYearElement.InnerText = manga.ReleaseYear.ToShortDateString()
            mangaElement.AppendChild(releaseYearElement)

            Dim volumeElement As XmlElement = doc.CreateElement("Volume")
            volumeElement.InnerText = manga.Volume.ToString()
            mangaElement.AppendChild(volumeElement)

            Dim editorialElement As XmlElement = doc.CreateElement("Editorial")
            editorialElement.InnerText = manga.Editorial
            mangaElement.AppendChild(editorialElement)

            Dim ratingElement As XmlElement = doc.CreateElement("Rating")
            ratingElement.InnerText = manga.Rating.ToString()
            mangaElement.AppendChild(ratingElement)

            Dim priceElement As XmlElement = doc.CreateElement("Price")
            priceElement.InnerText = manga.Price.ToString()
            mangaElement.AppendChild(priceElement)

            root.AppendChild(mangaElement)
        Next

        doc.Save(filePath)
        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
    End Sub

    Private Sub ExportMangaToExcel(filePath As String)
        Using workbook As New XLWorkbook()
            Dim worksheet = workbook.Worksheets.Add("Mangas")

            worksheet.Cell(1, 1).Value = "Title"
            worksheet.Cell(1, 2).Value = "Author"
            worksheet.Cell(1, 3).Value = "Genre"
            worksheet.Cell(1, 4).Value = "ReleaseYear"
            worksheet.Cell(1, 5).Value = "Volume"
            worksheet.Cell(1, 6).Value = "Editorial"
            worksheet.Cell(1, 7).Value = "Rating"
            worksheet.Cell(1, 8).Value = "Price"

            Dim rowIndex As Integer = 2

            For Each manga As Manga In mangas.Where(Function(m) m IsNot Nothing)
                worksheet.Cell(rowIndex, 1).Value = manga.Title
                worksheet.Cell(rowIndex, 2).Value = manga.Author
                worksheet.Cell(rowIndex, 3).Value = manga.Genre
                worksheet.Cell(rowIndex, 4).Value = manga.ReleaseYear.ToShortDateString()
                worksheet.Cell(rowIndex, 5).Value = manga.Volume
                worksheet.Cell(rowIndex, 6).Value = manga.Editorial
                worksheet.Cell(rowIndex, 7).Value = manga.Rating
                worksheet.Cell(rowIndex, 8).Value = manga.Price

                rowIndex += 1
            Next

            workbook.SaveAs(filePath)
        End Using
        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
    End Sub

    Private Sub ExportMangaToWord(filePath As String)
        Using document As DocX = DocX.Create(filePath)
            document.InsertParagraph("Manga List").FontSize(15).Bold().Alignment = Alignment.center

            Dim mangaCount As Integer = mangas.Count(Function(m) m IsNot Nothing)
            Dim table As Table = document.AddTable(mangaCount + 1, 8)

            table.Rows(0).Cells(0).Paragraphs(0).Append("Title")
            table.Rows(0).Cells(1).Paragraphs(0).Append("Author")
            table.Rows(0).Cells(2).Paragraphs(0).Append("Genre")
            table.Rows(0).Cells(3).Paragraphs(0).Append("ReleaseYear")
            table.Rows(0).Cells(4).Paragraphs(0).Append("Volume")
            table.Rows(0).Cells(5).Paragraphs(0).Append("Editorial")
            table.Rows(0).Cells(6).Paragraphs(0).Append("Rating")
            table.Rows(0).Cells(7).Paragraphs(0).Append("Price")

            Dim rowIndex As Integer = 1
            For Each manga As Manga In mangas.Where(Function(m) m IsNot Nothing)
                table.Rows(rowIndex).Cells(0).Paragraphs(0).Append(manga.Title)
                table.Rows(rowIndex).Cells(1).Paragraphs(0).Append(manga.Author)
                table.Rows(rowIndex).Cells(2).Paragraphs(0).Append(manga.Genre)
                table.Rows(rowIndex).Cells(3).Paragraphs(0).Append(manga.ReleaseYear.ToShortDateString())
                table.Rows(rowIndex).Cells(4).Paragraphs(0).Append(manga.Volume.ToString())
                table.Rows(rowIndex).Cells(5).Paragraphs(0).Append(manga.Editorial)
                table.Rows(rowIndex).Cells(6).Paragraphs(0).Append(manga.Rating.ToString())
                table.Rows(rowIndex).Cells(7).Paragraphs(0).Append(manga.Price.ToString())
                rowIndex += 1
            Next

            document.InsertTable(table)
            document.Save()
        End Using
        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
    End Sub

    Private Sub ExportMangaToTxt(filePath As String)
        Using writer As New StreamWriter(filePath)
            For Each manga As Manga In mangas.Where(Function(m) m IsNot Nothing)
                writer.WriteLine(manga.ToString())
            Next
        End Using
        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
    End Sub

    Private Sub btnSaveManga_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If String.IsNullOrWhiteSpace(txtTitle.Text) OrElse
           String.IsNullOrWhiteSpace(txtAuthor.Text) OrElse
           String.IsNullOrWhiteSpace(cbGenre.Text) OrElse
           String.IsNullOrWhiteSpace(txtChapters.Text) OrElse
           String.IsNullOrWhiteSpace(cbEditorial.Text) Then
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

            Dim emptyIndex As Integer = -1
            For i As Integer = 0 To mangas.Length - 1
                If mangas(i) Is Nothing Then
                    emptyIndex = i
                    Exit For
                End If
            Next

            If emptyIndex = -1 Then
                Dim result As DialogResult = MessageBox.Show("The array is full. Do you want to delete all entries to add new ones?",
                                                          "Array Full", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    For i As Integer = 0 To mangas.Length - 1
                        mangas(i) = Nothing
                    Next

                    lstvDataManga.Items.Clear()

                    emptyIndex = 0
                Else
                    Return
                End If
            End If

            mangas(emptyIndex) = New Manga(txtTitle.Text,
                                       txtAuthor.Text,
                                       cbGenre.Text,
                                       dtpDate.Value,
                                       Convert.ToInt32(txtChapters.Text),
                                       cbEditorial.Text,
                                       Convert.ToInt32(nudRating.Value))

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

    ' METODO QUE NO RECIBE NI REGRESA
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
            Dim numberItemsSelected As Integer = lstvDataManga.SelectedItems.Count
            Dim selectedIndices(numberItemsSelected - 1) As Integer

            For i As Integer = 0 To numberItemsSelected - 1
                selectedIndices(i) = lstvDataManga.SelectedItems(i).Index
            Next

            Array.Sort(selectedIndices)
            Array.Reverse(selectedIndices)

            For i As Integer = 0 To numberItemsSelected - 1
                lstvDataManga.Items.RemoveAt(selectedIndices(i))
            Next

            Dim updatedMangas(mangas.Length - numberItemsSelected - 1) As Manga
            Dim newIndex As Integer = 0

            For i As Integer = 0 To mangas.Length - 1
                If Array.IndexOf(selectedIndices, i) = -1 Then
                    updatedMangas(newIndex) = mangas(i)
                    newIndex += 1
                End If
            Next

            mangas = updatedMangas

            MessageBox.Show("Selected mangas have been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please select a manga to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnGetStatsManga_Click(sender As Object, e As EventArgs) Handles btnGetStatsManga.Click
        MessageBox.Show(Manga.GetStatsManga(mangas), "Stats", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub btnSimilarMangas_Click(sender As Object, e As EventArgs) Handles btnSimilarMangas.Click
        If lstvDataManga.SelectedIndices.Count > 0 Then
            MessageBox.Show(mangas(lstvDataManga.SelectedIndices(0)).ShowSimilarWorks(), "Similar Mangas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No manga has been selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class