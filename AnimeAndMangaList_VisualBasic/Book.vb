Public Class Book
    Protected _volume As Integer

    Public Property Volume As Integer
        Get
            Return _volume
        End Get
        Set(value As Integer)
            _volume = value
        End Set
    End Property

    Protected _editorial As String

    Public Property Editorial As String
        Get
            Return _editorial
        End Get
        Set(value As String)
            _editorial = value
        End Set
    End Property

    Protected _price As Double
    Public Property Price As Double
        Set(value As Double)
            _price = value
        End Set
        Get
            Return _price
        End Get
    End Property

    Public Sub New()
        _volume = 0
        _editorial = ""
        _price = 0
    End Sub

    Public Sub New(chaptersnumber As Integer, editorial As String, price As Double)
        _volume = chaptersnumber
        _editorial = editorial
        _price = price
    End Sub
End Class
