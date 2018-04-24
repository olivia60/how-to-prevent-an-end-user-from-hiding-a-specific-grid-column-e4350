Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Collections.ObjectModel

Namespace DXSample
    Public NotInheritable Class DataHelper

        Private Sub New()
        End Sub

        Public Shared Function GetData() As ObservableCollection(Of Customer)
            Dim rand As New Random()
            Dim customers As New ObservableCollection(Of Customer)()
            For i As Integer = 0 To 24

                customers.Add(New Customer(String.Format("FirstName{0}", rand.Next(1, 6)), String.Format("LastName{0}", rand.Next(1,6)), String.Format("City{0}", rand.Next(1,99)), String.Format("Country{0}", rand.Next(1,4))))
            Next i
            Return customers
        End Function
    End Class

    Public Class Customer
        Public Sub New(ByVal _firstName As String, ByVal _lastName As String, ByVal _city As String, ByVal _country As String)
            FirstName = _firstName
            LastName = _lastName
            City = _city
            Country = _country
        End Sub

        Public Sub New()
            FirstName = ""
            LastName = ""
            City = ""
            Country = ""
        End Sub
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property City() As String
        Public Property Country() As String
    End Class
End Namespace
