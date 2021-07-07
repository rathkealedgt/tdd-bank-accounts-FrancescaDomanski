Imports System.Runtime.Remoting.Messaging
Imports System.Text
Public Class BankAccount

    Private Name As String
    Private Number As String
    Private InterestRate As Double
    Private CountryOfOrigin As String
    Private Balance As Double

    Public Sub New(Namex As String, Numberx As String, InterestRatex As Double, CountryOfOriginx As String, Balancex As Double)
        Me.Name = Namex
        Me.Number = Numberx
        Me.InterestRate = InterestRatex
        Me.CountryOfOrigin = CountryOfOriginx
        Me.Balance = Balancex

    End Sub



    'Public Sub New(Name As String, Number As String, InterestRate As Double, CountryOfOrigin As String)
    '    Me.Name = Name
    '    Me.Number = Number
    '    Me.InterestRate = InterestRate
    '    Me.CountryOfOrigin = CountryOfOrigin

    'End Sub

    'Public Sub New(Name As String, Number As String, InterestRate As Double)
    '    Me.Name = Name
    '    Me.Number = Number
    '    Me.InterestRate = InterestRate
    'End Sub

    Public Function GetName() As String
        Return Me.Name
    End Function

    'Public Function SetName(Namex As String)
    '    Me.Name = Namex
    '    Return Nothing

    'End Function

    Public Function GetInterestRate() As Double
        Return Me.InterestRate

    End Function
    Public Function SetInterestRate(InterestRatex As Double)
        Me.InterestRate = InterestRatex
        Return Nothing

    End Function
    Public Function GetNumber() As String
        Return Me.Number

    End Function
    'Public Function SetNumber(Numberx As String)
    '    Me.Number = Numberx
    '    Return Nothing

    'End Function

    Public Function GetCountryOfOrigin() As String
        Return Me.CountryOfOrigin

    End Function
    'Public Function SetCountryOfOrigin(CountryOfOriginx As String)
    '    Me.CountryOfOrigin = CountryOfOriginx
    '    Return Nothing

    'End Function
    Public Function GetBalance() As Double
        Return Me.Balance

    End Function
    'Public Function SetBalance(Balancex As Double)
    '    Me.Balance = Balancex
    '    Return Nothing

    'End Function
End Class