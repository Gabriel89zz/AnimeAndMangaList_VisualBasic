Public Class TvShow
    Protected _productionstudio As String
    Public Property ProductionStudio As String
        Get
            Return _productionstudio
        End Get
        Set(value As String)
            _productionstudio = value
        End Set
    End Property

    Protected _numberofseasons As Integer
    Public Property NumberOfSeasons As Integer
        Get
            Return _numberofseasons
        End Get
        Set(value As Integer)
            _numberofseasons = value
        End Set
    End Property

    Protected _platform As String
    Public Property Platform As String
        Get
            Return _platform
        End Get
        Set(value As String)
            _platform = value
        End Set
    End Property

    Public Sub New()
        _productionstudio = ""
        _numberofseasons = 0
        _platform = ""
    End Sub

    Public Sub New(productionstudio As String, numberofseasons As Integer, platform As String)
        _productionstudio = productionstudio
        _numberofseasons = numberofseasons
        _platform = platform
    End Sub
End Class
