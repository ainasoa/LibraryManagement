Imports System.ComponentModel.DataAnnotations
Public Class Book
    <Key> Public Property ID As Integer
    Public Property Title As String
    Public Property Author As String
    Public Property PageNumber As Integer

    Public Sub New(ID As Integer, Name As String, Author As String, PageNumber As Integer)
        Me.ID = ID
        Me.Title = Name
        Me.Author = Author
        Me.PageNumber = PageNumber
    End Sub
End Class
