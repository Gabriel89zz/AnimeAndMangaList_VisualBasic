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

    ' Propiedad de solo lectura
    Public ReadOnly Property Price As Double
        Get
            Return _price
        End Get
    End Property

    ' Constructor sin parámetros
    Public Sub New()
        Volume = 0
        Editorial = ""
        _price = DeterminePrice()
    End Sub

    ' Constructor con parámetros
    Public Sub New(volume As Integer, editorial As String)
        _volume = volume
        _editorial = editorial
        _price = DeterminePrice()
    End Sub

    ' Método privado para determinar el precio
    Private Function DeterminePrice() As Double
        Select Case _editorial
            Case "Panini"
                Return 145
            Case "Norma"
                Return 139
            Case "Kamite"
                Return 189
            Case "Ivrea"
                Return 120
            Case Else
                Return 100
        End Select
    End Function
End Class
