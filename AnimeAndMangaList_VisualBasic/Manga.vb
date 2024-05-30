Imports Newtonsoft.Json
Imports ClosedXML.Excel
Imports System.Xml
Imports Xceed.Words.NET
Imports Xceed.Document.NET
Imports System.IO


Public Class Manga
    Inherits Book
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

    'PROPIEADAD DE SOLO LECTURA
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

    'CONSTRUCTOR SIN PARAMETROS
    Public Sub New()
        MyBase.New()
        _title = ""
        _author = ""
        _genre = ""
        _releaseyear = Date.MinValue
        _rating = 0
    End Sub

    'CONSTRUCTOR CON PARAMETROS
    Public Sub New(title As String, autor As String, genre As String, releaseyear As Date, chaptersnumber As Integer, editorial As String, rating As Integer, price As Double)
        MyBase.New(chaptersnumber, editorial, price)
        _title = title
        _author = autor
        _genre = genre
        _releaseyear = releaseyear
        _rating = rating
    End Sub

    'Polimorfimso
    Public Overrides Function ToString() As String
        Return "Title: " & _title & ", Author: " & _author & ", Genre: " & _genre & ", Acquisition Date: " & _releaseyear.ToString() & ", Volume: " & _volume.ToString().ToString() & ", Editorial: " + _editorial.ToString() & ", Price: " + _price.ToString() & ", Rating:" + _rating.ToString()
    End Function
    'METODO  QUE REGRESA Y RECIBE
    Public Shared Function GetStats(mangas As Manga()) As String
        Dim sumPrice As Double = 0
        For Each manga As Manga In mangas
            If manga IsNot Nothing Then
                sumPrice += manga.price
            End If
        Next

        Dim Kamite = 0
        Dim Panini = 0
        Dim Ivrea = 0
        Dim Norma = 0

        For Each manga In mangas
            If manga IsNot Nothing Then
                Select Case manga.editorial
                    Case "Panini"
                        Panini += 1
                    Case "Norma"
                        Norma += 1
                    Case "Ivrea"
                        Ivrea += 1
                    Case "Kamite"
                        Kamite += 1
                    Case Else
                        Continue For
                End Select
            End If
        Next
        Return "The ost of your collection of mangas: " & Math.Round(sumPrice, 2).ToString() & vbLf & "Mangas by editorial: Panini:" & Panini.ToString() & "Norma: " & Norma.ToString() & " Kamite: " & Kamite.ToString() & " Ivrea: " & Ivrea.ToString()
    End Function

    ' METODO QUE REGRESA PERO NO RECIBE
    Public Shared Function GetMangaGenres() As String()
        Dim MangaGenres = {"Shonen", "Seinen", "Comedy", "Drama", "Sci-Fi", "Romcom", "Slice of Life", "Isekai"}
        Return MangaGenres
    End Function

    'METODO QUE RECIBE PERO NO REGRESA
    Public Shared Sub ExportMangaToJson(filePath As String, mangas As Manga())
        Dim filteredMangas As Manga() = Array.FindAll(mangas, Function(m) m IsNot Nothing)
        Dim json As String = JsonConvert.SerializeObject(filteredMangas, Newtonsoft.Json.Formatting.Indented)
        File.WriteAllText(filePath, json)
    End Sub

    Public Shared Sub ExportMangaToXml(filePath As String, mangas As Manga())
        Dim doc As XmlDocument = New XmlDocument()
        Dim root As XmlElement = doc.CreateElement("Mangas")
        doc.AppendChild(root)

        For Each manga In mangas.Where(Function(m) m IsNot Nothing)
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
            volumeElement.InnerText = manga.volume.ToString()
            mangaElement.AppendChild(volumeElement)

            Dim editorialElement As XmlElement = doc.CreateElement("Editorial")
            editorialElement.InnerText = manga.editorial
            mangaElement.AppendChild(editorialElement)

            Dim ratingElement As XmlElement = doc.CreateElement("Rating")
            ratingElement.InnerText = manga.Rating.ToString()
            mangaElement.AppendChild(ratingElement)

            Dim priceElement As XmlElement = doc.CreateElement("Price")
            priceElement.InnerText = manga.price.ToString()
            mangaElement.AppendChild(priceElement)

            root.AppendChild(mangaElement)
        Next

        doc.Save(filePath)

    End Sub
    Public Shared Sub ExportMangaToExcel(filePath As String, mangas As Manga())
        Using workbook = New XLWorkbook()
            Dim worksheet = workbook.Worksheets.Add("Mangas")

            worksheet.Cell(1, 1).Value = "Title"
            worksheet.Cell(1, 2).Value = "Author"
            worksheet.Cell(1, 3).Value = "Genre"
            worksheet.Cell(1, 4).Value = "ReleaseYear"
            worksheet.Cell(1, 5).Value = "Volume"
            worksheet.Cell(1, 6).Value = "Editorial"
            worksheet.Cell(1, 7).Value = "Rating"
            worksheet.Cell(1, 8).Value = "Price"

            Dim rowIndex = 2

            For Each manga In mangas.Where(Function(m) m IsNot Nothing)
                worksheet.Cell(rowIndex, 1).Value = manga.Title
                worksheet.Cell(rowIndex, 2).Value = manga.Author
                worksheet.Cell(rowIndex, 3).Value = manga.Genre
                worksheet.Cell(rowIndex, 4).Value = manga.ReleaseYear.ToShortDateString()
                worksheet.Cell(rowIndex, 5).Value = manga.volume
                worksheet.Cell(rowIndex, 6).Value = manga.editorial
                worksheet.Cell(rowIndex, 7).Value = manga.Rating
                worksheet.Cell(rowIndex, 8).Value = manga.price

                rowIndex += 1
            Next

            workbook.SaveAs(filePath)
        End Using
    End Sub


    Public Shared Sub ExportMangaToWord(filePath As String, mangas As Manga())
        Using document = DocX.Create(filePath)
            document.InsertParagraph("Manga List").FontSize(15).Bold().Alignment = Alignment.center

            Dim mangaCount = mangas.Count(Function(m) m IsNot Nothing)
            Dim table = document.AddTable(mangaCount + 1, 8)

            table.Rows(0).Cells(0).Paragraphs(0).Append("Title")
            table.Rows(0).Cells(1).Paragraphs(0).Append("Author")
            table.Rows(0).Cells(2).Paragraphs(0).Append("Genre")
            table.Rows(0).Cells(3).Paragraphs(0).Append("ReleaseYear")
            table.Rows(0).Cells(4).Paragraphs(0).Append("Volume")
            table.Rows(0).Cells(5).Paragraphs(0).Append("Editorial")
            table.Rows(0).Cells(6).Paragraphs(0).Append("Rating")
            table.Rows(0).Cells(7).Paragraphs(0).Append("Price")

            Dim rowIndex = 1
            For Each manga In mangas.Where(Function(m) m IsNot Nothing)
                table.Rows(rowIndex).Cells(0).Paragraphs(0).Append(manga.Title)
                table.Rows(rowIndex).Cells(1).Paragraphs(0).Append(manga.Author)
                table.Rows(rowIndex).Cells(2).Paragraphs(0).Append(manga.Genre)
                table.Rows(rowIndex).Cells(3).Paragraphs(0).Append(manga.ReleaseYear.ToShortDateString())
                table.Rows(rowIndex).Cells(4).Paragraphs(0).Append(manga.volume.ToString())
                table.Rows(rowIndex).Cells(5).Paragraphs(0).Append(manga.editorial)
                table.Rows(rowIndex).Cells(6).Paragraphs(0).Append(manga.Rating.ToString())
                table.Rows(rowIndex).Cells(7).Paragraphs(0).Append(manga.price.ToString())
                rowIndex += 1
            Next

            document.InsertTable(table)
            document.Save()
        End Using

    End Sub

    Public Shared Sub ExportMangaToTxt(filePath As String, mangas As Manga())
        Using writer As StreamWriter = New StreamWriter(filePath)
            For Each manga In mangas.Where(Function(m) m IsNot Nothing)
                writer.WriteLine(manga.ToString())
            Next
        End Using
    End Sub

    Public Shared Sub LoadMangaDataFromTextFile(filePath As String, mangas As Manga(), lstvData As ListView)
        Try
            Dim lines = File.ReadAllLines(filePath)

            For Each line In lines
                Dim fields = line.Split("|"c)

                Dim emptyIndex = Array.FindIndex(mangas, Function(m) m Is Nothing)

                If emptyIndex = -1 Then
                    MessageBox.Show("The array is full. You need to delete some entries to add new ones.", "Array Full", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                mangas(emptyIndex) = New Manga(fields(0), fields(1), fields(2), Date.Parse(fields(3)), Convert.ToInt32(fields(4)), fields(5), Convert.ToInt32(fields(6)), Convert.ToDouble(fields(7)))

                Dim item As ListViewItem = New ListViewItem(mangas(emptyIndex).Title)
                item.SubItems.Add(mangas(emptyIndex).Author)
                item.SubItems.Add(mangas(emptyIndex).Genre)
                item.SubItems.Add(mangas(emptyIndex).ReleaseYear.ToShortDateString())
                item.SubItems.Add(mangas(emptyIndex).volume.ToString())
                item.SubItems.Add(mangas(emptyIndex).editorial)
                item.SubItems.Add(mangas(emptyIndex).Rating.ToString())
                item.SubItems.Add(mangas(emptyIndex).price.ToString())

                lstvData.Items.Add(item)
            Next

            MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
End Class
