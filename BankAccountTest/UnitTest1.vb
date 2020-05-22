Imports System.Text
'Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestConstructors()


        'Arrange
        Dim Name As String = "Ms Ammon Calypso"
        Dim Number As String = "CH93 0076 2001 6734 8790 2"
        Dim InterestRate As Double = 3.0
        Dim CountryOfOrigin As String = "Switzerland"
        Dim Balance As Double = 2300000.32


        'Act
        Dim Account1 As New BankAccounts.BankAccount(Name, Number, InterestRate, CountryOfOrigin, Balance)
        'Dim Account2 As New BankAccounts.BankAccount(Namex, Numberx, InterestRatex, CountryOfOriginx)
        'Dim Account3 As New BankAccounts.BankAccount(Namex, Numberx, InterestRatex)

        'Assert
        Assert.IsNotNull(Account1)
        'Assert.IsNotNull(Account2)
        'Assert.IsNotNull(Account3)

    End Sub
    Private Function NewAccount() As BankAccounts.BankAccount
        Dim Name As String = "Ms Ammon Calypso"
        Dim Number As String = "CH93 0076 2001 6734 8790 2"
        Dim InterestRate As Double = 3.0
        Dim CountryOfOrigin As String = "Switzerland"
        Dim Balance As Double = 2300000.32
        Dim Account1 As New BankAccounts.BankAccount(Name, Number, InterestRate, CountryOfOrigin, Balance)
        Return Account1
    End Function

    <TestMethod()> Public Sub TestGetName()

        'Arrange

        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'Act
        Dim Namex As String = Account1.GetName()

        'Assert
        Assert.AreEqual(Namex, "Ms Ammon Calypso")
    End Sub
    <TestMethod()> Public Sub TestGetInterestRate()

        'Arrange

        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'Act
        Dim InterestRatex As Double = Account1.GetInterestRate

        'Assert
        Assert.AreEqual(InterestRatex, 3.0)

    End Sub
    <TestMethod()> Public Sub TestSetInterestRate()
        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()
        'Act
        Account1.SetInterestRate(4.0)

        'Assert
        Assert.AreEqual(4.0, Account1.GetInterestRate())

    End Sub


    <TestMethod()> Public Sub TestGetNumber()

        'Arrange

        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'Act
        Dim Numberx As String = Account1.GetNumber

        'Assert
        Assert.AreEqual(Numberx, "CH93 0076 2001 6734 8790 2")

    End Sub

    '<TestMethod()> Public Sub TestSetNumber()
    '    'Arrange
    '    Dim Account1 As BankAccounts.BankAccount = Me.NewAccount
    '    'Act
    '    Account1.SetNumber("CH93 0076 2001 6734 8790 2")

    '    'Assert
    '    Assert.AreEqual("CH93 0076 2001 6734 8790 2", Account1.GetNumber())

    'End Sub

    <TestMethod()> Public Sub TestGetCountryOfOrigin()

        'Arrange

        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'Act
        Dim CountryOfOriginx As String = Account1.GetCountryOfOrigin

        'Assert
        Assert.AreEqual(CountryOfOriginx, "Switzerland")

    End Sub

    '<TestMethod()> Public Sub TestSetCountryOfOrigin()
    '    'Arrange
    '    Dim Account1 As BankAccounts.BankAccount = Me.NewAccount
    '    'Act
    '    Account1.SetCountryOfOrigin("Switzerland")

    '    'Assert
    '    Assert.AreEqual("Switzerland", Account1.GetNumber())

    'End Sub

    <TestMethod()> Public Sub TestGetBalance()

        'Arrange

        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'Act
        Dim Balancex As Double = Account1.GetBalance

        'Assert
        Assert.AreEqual(Balancex, 2300000.32)

    End Sub

End Class
'<TestMethod()> Public Sub TestSetCountryOfOrigin()
'    'Arrange
'    Dim Account1 As BankAccounts.BankAccount = Me.NewAccount
'    'Act
'    Account1.SetBalance(2300000.32)

'    'Assert
'    Assert.AreEqual(2300000.32, Account1.GetBalance())

'End Sub