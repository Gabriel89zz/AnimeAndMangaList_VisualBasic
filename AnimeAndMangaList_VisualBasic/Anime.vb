Imports Newtonsoft.Json
Imports ClosedXML.Excel
Imports System.Xml
Imports Xceed.Words.NET
Imports Xceed.Document.NET
Imports System.IO
Public Class Anime
    Inherits TvShow
    Implements IJapaneseWork
    Private _title As String
    Public Property Title As String Implements IJapaneseWork.Title
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Private _author As String
    Public ReadOnly Property Author As String Implements IJapaneseWork.Author
        Get
            Return _author
        End Get
    End Property

    Private _genre As String
    Public Property Genre As String Implements IJapaneseWork.Genre
        Get
            Return _genre
        End Get
        Set(value As String)
            _genre = value
        End Set
    End Property

    Private _releaseyear As Date
    Public Property ReleaseYear As Date Implements IJapaneseWork.ReleaseYear
        Get
            Return _releaseyear
        End Get
        Set(value As Date)
            _releaseyear = value
        End Set
    End Property

    Private _rating As Integer
    Public Property Rating As Integer Implements IJapaneseWork.Rating
        Get
            Return _rating
        End Get
        Set(value As Integer)
            _rating = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        _title = ""
        _author = ""
        _genre = ""
        _releaseyear = Date.MinValue
        _rating = 0
    End Sub

    Public Sub New(title As String, autor As String, genre As String, releaseyear As Date, numberofseasons As Integer, production As String, platform As String, rating As Integer)
        MyBase.New(production, numberofseasons, platform)
        _title = title
        _author = autor
        _genre = genre
        _releaseyear = releaseyear
        _rating = rating
    End Sub

    Public Overrides Function ToString() As String
        Return "Title: " & _title & ", Author: " & _author & ", Genre: " & _genre & ", Release Date: " & _releaseyear.ToString().ToString() & ", Number of Seasons: " + _numberofseasons.ToString() & ", Production Studio: " + _productionstudio.ToString() & ", Platform: " + _platform.ToString() & ", Rating:" + _rating.ToString()
    End Function

    Public Shared Function GetStatsAnime(animes As Anime()) As String
        Dim crunchyroll = 0
        Dim netflix = 0
        Dim disneyplus = 0
        Dim primevideo = 0
        Dim sumSubs = 0
        For Each anime In animes
            If anime IsNot Nothing Then
                Select Case anime.Platform
                    Case "Crunchyroll"
                        crunchyroll = 145
                    Case "Netflix"
                        netflix = 219
                    Case "Disney Plus"
                        disneyplus = 200
                    Case "Prime Video"
                        primevideo = 99
                    Case Else
                        Continue For
                End Select
            End If
        Next
        sumSubs = crunchyroll + disneyplus + netflix + primevideo
        Return "Your monthly subscription cost is: " & sumSubs.ToString() & " MXN"
    End Function


    Public Shared Sub ExportAnimeToJson(filePath As String, animes As Anime())
        Dim filteredMangas = Array.FindAll(animes, Function(m) m IsNot Nothing)
        Dim json As String = JsonConvert.SerializeObject(filteredMangas, Newtonsoft.Json.Formatting.Indented)
        File.WriteAllText(filePath, json)
    End Sub

    Public Shared Sub ExportAnimeToXml(filePath As String, animes As Anime())
        Dim doc As XmlDocument = New XmlDocument()
        Dim root As XmlElement = doc.CreateElement("Animes")
        doc.AppendChild(root)

        For Each anime In animes.Where(Function(m) m IsNot Nothing)
            Dim animeElement As XmlElement = doc.CreateElement("Manga")

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

    End Sub

    Public Shared Sub ExportAnimeToExcel(filePath As String, animes As Anime())
        Using workbook = New XLWorkbook()
            Dim worksheet = workbook.Worksheets.Add("Animes")

            worksheet.Cell(1, 1).Value = "Title"
            worksheet.Cell(1, 2).Value = "Author"
            worksheet.Cell(1, 3).Value = "Genre"
            worksheet.Cell(1, 4).Value = "ReleaseYear"
            worksheet.Cell(1, 5).Value = "Number of Chapters"
            worksheet.Cell(1, 6).Value = "Platform"
            worksheet.Cell(1, 7).Value = "Rating"
            worksheet.Cell(1, 8).Value = "Production Studio"

            Dim rowIndex = 2

            For Each anime In animes.Where(Function(m) m IsNot Nothing)
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
    End Sub


    Public Shared Sub ExportAnimeToWord(filePath As String, animes As Anime())
        Using document = DocX.Create(filePath)
            document.InsertParagraph("Anime List").FontSize(15).Bold().Alignment = Alignment.center

            Dim animeCount = animes.Count(Function(m) m IsNot Nothing)
            Dim table = document.AddTable(animeCount + 1, 8)

            table.Rows(0).Cells(0).Paragraphs(0).Append("Title")
            table.Rows(0).Cells(1).Paragraphs(0).Append("Author")
            table.Rows(0).Cells(2).Paragraphs(0).Append("Genre")
            table.Rows(0).Cells(3).Paragraphs(0).Append("ReleaseYear")
            table.Rows(0).Cells(4).Paragraphs(0).Append("Number of Chapters")
            table.Rows(0).Cells(5).Paragraphs(0).Append("Platform")
            table.Rows(0).Cells(6).Paragraphs(0).Append("Rating")
            table.Rows(0).Cells(7).Paragraphs(0).Append("Production Studio")

            Dim rowIndex = 1
            For Each manga In animes.Where(Function(m) m IsNot Nothing)
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

    End Sub

    Public Shared Sub ExportAnimeToTxt(filePath As String, animes As Anime())
        Using writer As StreamWriter = New StreamWriter(filePath)
            For Each anime In animes.Where(Function(m) m IsNot Nothing)
                writer.WriteLine(anime.ToString())
            Next
        End Using
    End Sub

    Public Shared Sub LoadAnimeDataFromTextFile(filePath As String, animes As Anime(), lstvData As ListView)
        Try
            Dim lines = File.ReadAllLines(filePath)

            For Each line In lines
                Dim fields = line.Split("|"c)

                Dim emptyIndex = Array.FindIndex(animes, Function(m) m Is Nothing)

                If emptyIndex = -1 Then
                    MessageBox.Show("The array is full. You need to delete some entries to add new ones.", "Array Full", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                animes(emptyIndex) = New Anime(fields(0), fields(1), fields(2), Date.Parse(fields(3)), Convert.ToInt32(fields(4)), fields(5), fields(6), Convert.ToInt32(fields(7)))

                Dim item As ListViewItem = New ListViewItem(animes(emptyIndex)._title)
                item.SubItems.Add(animes(emptyIndex)._author)
                item.SubItems.Add(animes(emptyIndex)._genre)
                item.SubItems.Add(animes(emptyIndex)._releaseyear.ToShortDateString())
                item.SubItems.Add(animes(emptyIndex).NumberOfSeasons.ToString())
                item.SubItems.Add(animes(emptyIndex).ProductionStudio)
                item.SubItems.Add(animes(emptyIndex).Platform)
                item.SubItems.Add(animes(emptyIndex)._rating.ToString())

                lstvData.Items.Add(item)
            Next

            MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
End Class
