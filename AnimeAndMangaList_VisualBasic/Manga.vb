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
    Public Property Author As String Implements IJapaneseWork.Author
        Get
            Return _author
        End Get
        Set(ByVal value As String)
            _author = value
        End Set
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
    Public Sub New(title As String, autor As String, genre As String, releaseyear As Date, chaptersnumber As Integer, editorial As String, rating As Integer)
        MyBase.New(chaptersnumber, editorial)
        _title = title
        _author = autor
        _genre = genre
        _releaseyear = releaseyear
        _rating = rating
    End Sub

    Public Overrides Function ToString() As String
        Return "Title: " & _title & ", Author: " & _author & ", Genre: " & _genre & ", Acquisition Date: " & _releaseyear.ToString() & ", Volume: " & _volume.ToString().ToString() & ", Editorial: " + _editorial.ToString() & ", Price: " + _price.ToString() & ", Rating:" + _rating.ToString()
    End Function
    'METODO  QUE REGRESA Y RECIBE
    Public Shared Function GetStatsManga(mangas As Manga()) As String
        Dim sumPrice As Double = 0
        Dim Kamite As Integer = 0
        Dim Panini As Integer = 0
        Dim Ivrea As Integer = 0
        Dim Norma As Integer = 0
        Dim shonen As Integer = 0
        Dim seinen As Integer = 0
        Dim comedy As Integer = 0
        Dim scifi As Integer = 0
        Dim romcom As Integer = 0
        Dim isekai As Integer = 0

        For Each manga As Manga In mangas
            If manga IsNot Nothing Then
                sumPrice += manga.Price
                Select Case manga.Editorial
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

                Select Case manga.Genre
                    Case "Shonen"
                        shonen += 1
                    Case "Seinen"
                        seinen += 1
                    Case "Comedy"
                        comedy += 1
                    Case "Sci-Fi"
                        scifi += 1
                    Case "Romcom"
                        romcom += 1
                    Case "Isekai"
                        isekai += 1
                    Case Else
                        Continue For
                End Select
            End If
        Next

        Return "The cost of your collection of mangas: " & Math.Round(sumPrice, 2) & " MXN" & vbCrLf & vbCrLf &
           "Mangas by editorial: " & vbCrLf & "Panini: " & Panini & vbCrLf & "Norma: " & Norma & vbCrLf &
           "Kamite: " & Kamite & vbCrLf & "Ivrea: " & Ivrea & vbCrLf & vbCrLf &
           "Mangas by genre: " & vbCrLf & "Shonen: " & shonen & vbCrLf & "Seinen: " & seinen & vbCrLf &
           "Comedy: " & comedy & vbCrLf & "Sci-Fi: " & scifi & vbCrLf & "Romcom: " & romcom & vbCrLf &
           "Isekai: " & isekai
    End Function

    Public Function ShowSimilarWorks() As String Implements IJapaneseWork.ShowSimilarWorks
        Dim similarWorksMessage As String = ""

        Select Case Genre
            Case "Shonen"
                Dim shonenGenre As String() = {"One Piece", "Naruto", "Bleach", "Black Clover", "Fairy Tail",
            "Dragon Ball", "My Hero Academia", "Attack on Titan", "Hunter x Hunter", "Demon Slayer",
            "One Punch Man", "Haikyuu!!", "Yu Yu Hakusho", "The Seven Deadly Sins", "JoJo's Bizarre Adventure",
            "Fullmetal Alchemist", "Mob Psycho 100", "Tokyo Ghoul", "Assassination Classroom", "Dragon Ball Z"}

                For i As Integer = 0 To shonenGenre.Length - 1
                    If _title = shonenGenre(i) Then
                        shonenGenre(i) = ""
                    Else
                        similarWorksMessage &= shonenGenre(i) & vbCrLf
                    End If
                Next
            Case "Seinen"
                Dim seinenGenre As String() = {"Tokyo Ghoul", "Attack on Titan", "Death Note", "Berserk", "Monster",
            "Parasyte", "Elfen Lied", "Akira", "Claymore", "Psycho-Pass",
            "Vinland Saga", "Neon Genesis Evangelion", "The Promised Neverland", "Gantz", "Black Lagoon",
            "Hellsing", "Vagabond", "Blame!", "Deadman Wonderland", "Dorohedoro"}

                For i As Integer = 0 To seinenGenre.Length - 1
                    If _title = seinenGenre(i) Then
                        seinenGenre(i) = ""
                    Else
                        similarWorksMessage &= seinenGenre(i) & vbCrLf
                    End If
                Next
            Case "Comedey"
                Dim comedyGenre As String() = {"Gintama", "Nichijou", "One Punch Man", "Konosuba", "Grand Blue",
            "Daily Lives of High School Boys", "The Disastrous Life of Saiki K.", "KonoSuba: God's Blessing on This Wonderful World!", "Great Teacher Onizuka", "Arakawa Under the Bridge",
            "Nichibros", "Prison School", "Danshi Koukousei no Nichijou", "Azumanga Daioh", "K-On!",
            "Cromartie High School", "Sakamoto desu ga?", "Seto no Hanayome", "Shimoneta", "Lucky Star"}

                For i As Integer = 0 To comedyGenre.Length - 1
                    If _title = comedyGenre(i) Then
                        comedyGenre(i) = ""
                    Else
                        similarWorksMessage &= comedyGenre(i) & vbCrLf
                    End If
                Next
            Case "Sci-Fi"
                Dim scifiGenre As String() = {"Steins;Gate", "Ghost in the Shell", "Cowboy Bebop", "Neon Genesis Evangelion", "Psycho-Pass",
            "Serial Experiments Lain", "Trigun", "Planetes", "Aldnoah.Zero", "Ergo Proxy",
            "Legend of the Galactic Heroes", "Texhnolyze", "No. 6", "Outlaw Star", "Space Dandy",
            "Astra Lost in Space", "Mobile Suit Gundam", "Robotech", "Armitage III", "Blue Gender"}

                For i As Integer = 0 To scifiGenre.Length - 1
                    If _title = scifiGenre(i) Then
                        scifiGenre(i) = ""
                    Else
                        similarWorksMessage &= scifiGenre(i) & vbCrLf
                    End If
                Next
            Case "Romcom"
                Dim romcomGenre As String() = {"Toradora!", "My Youth Romantic Comedy Is Wrong, As I Expected", "Love, Chunibyo & Other Delusions", "Nisekoi", "Golden Time",
            "Ore Monogatari!!", "Sakurasou no Pet na Kanojo", "Clannad", "Lovely★Complex", "Kaguya-sama: Love is War",
            "The Pet Girl of Sakurasou", "Monthly Girls' Nozaki-kun", "The Quintessential Quintuplets", "My Little Monster", "School Rumble",
            "Love Hina", "Kimi ni Todoke", "Tonikaku Kawaii", "Ouran High School Host Club", "Kaichou wa Maid-sama!"}

                For i As Integer = 0 To romcomGenre.Length - 1
                    If _title = romcomGenre(i) Then
                        romcomGenre(i) = ""
                    Else
                        similarWorksMessage &= romcomGenre(i) & vbCrLf
                    End If
                Next
            Case "Isekai"
                Dim isekaiGenre As String() = {"Re:Zero", "Sword Art Online", "Overlord", "The Rising of the Shield Hero", "Log Horizon",
            "No Game No Life", "That Time I Got Reincarnated as a Slime", "Konosuba", "The Devil is a Part-Timer!", "Grimgar, Ashes and Illusions",
            "In Another World with My Smartphone", "The Saga of Tanya the Evil", "The Familiar of Zero", "Gate: Thus the JSDF Fought There!", "Isekai Quartet",
            "Accel World", "Problem Children Are Coming from Another World, Aren't They?", "Digimon Adventure", "Restaurant to Another World", "How Not to Summon a Demon Lord"}

                For i As Integer = 0 To isekaiGenre.Length - 1
                    If _title = isekaiGenre(i) Then
                        isekaiGenre(i) = ""
                    Else
                        similarWorksMessage &= isekaiGenre(i) & vbCrLf
                    End If
                Next
            Case Else
                Return "Genre not specified"
        End Select

        Return similarWorksMessage
    End Function


End Class
