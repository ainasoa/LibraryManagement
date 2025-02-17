Imports System.Data

Public NotInheritable Class BookForm
    Private dataTable As DataTable
    Private bookId As Long = Nothing
    Private authorId As Long = Nothing
    Private bookIndex As Integer = Nothing

    Public Sub New(ByRef dataTable As DataTable, Optional bookId As Long = Nothing, Optional bookIndex As Integer = Nothing)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.dataTable = dataTable
        Me.bookId = bookId
        Me.bookIndex = bookIndex
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Using appBD = New AppDB()
                Dim book As New Book()
                Dim author As New Author()
                Dim lastInsertedId As Long

                With author
                    .Firstname = FirstnameTextBox.Text
                    .Lastname = LastnameTextBox.Text
                    .Pseudo = PseudoTextBox.Text

                    If Me.authorId <> 0 Then .ID = Me.authorId
                End With

                With book
                    .Title = TitleTextBox.Text
                    .Description = DescriptionTextBox.Text
                    .PageNumber = PageNumberTextBox.Text
                    .Author = author

                    If Me.bookId <> 0 Then .ID = Me.bookId
                End With

                If Me.bookId <> 0 Then
                    appBD.editBook(book)

                    Dim row As DataRow = dataTable.Rows.Item(bookIndex)

                    row("Titre") = book.Title
                    row("Nombre de Page") = book.PageNumber
                    row("Description") = book.Description
                    row("Titre") = book.Title
                    row("Auteur") = book.Author

                    dataTable.AcceptChanges()
                Else
                    lastInsertedId = appBD.addBook(book)
                    dataTable.Rows.Add(lastInsertedId, book.Title, book.Description, author.Pseudo)
                End If

                Close()
            End Using

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub BookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bookId <> 0 Then
            Using appBD = New AppDB()
                Dim book As Book = appBD.getOneBook(bookId)

                TitleTextBox.Text = book.Title
                DescriptionTextBox.Text = book.Description
                PageNumberTextBox.Text = book.PageNumber
                FirstnameTextBox.Text = book.Author.Firstname
                LastnameTextBox.Text = book.Author.Lastname
                PseudoTextBox.Text = book.Author.Pseudo

                Me.authorId = book.Author.ID
            End Using

            SaveButton.Text = "Modifier"
            CloseButton.Text = "Annuler"
        End If
    End Sub
End Class
