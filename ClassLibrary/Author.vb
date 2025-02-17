Public Class Author : Inherits Person

    Public Property Pseudo As String

    Public Overrides Function ToString() As String
        Return String.Format(
            "{0} ({1} {2})",
            Pseudo,
            MyBase.Firstname,
            MyBase.Lastname
        )
    End Function
End Class

