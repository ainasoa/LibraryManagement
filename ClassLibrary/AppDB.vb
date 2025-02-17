Imports System.Data.SQLite
Imports System.Windows.Forms

Public Class AppDB : Implements IDisposable
    Public Sub New()
        Try
            Using connection = connect()
                Using cmd = New SQLiteCommand()
                    With cmd
                        .Connection = connection
                        'create all tables
                        .CommandText = "PRAGMA foreign_keys = ON;
                        -- DROP TABLE IF EXISTS Author;
                        -- DROP TABLE IF EXISTS Book;

                        CREATE TABLE IF NOT EXISTS Author(
	                        id INTEGER PRIMARY KEY AUTOINCREMENT,
	                        firstname VARCHAR(80),
                            lastname VARCHAR(80),
                            pseudo VARCHAR(20)
                        );

                        CREATE TABLE IF NOT EXISTS Book(
	                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                            photo Text,
	                        title VARCHAR(80),
	                        pageNumber INT,
                            description VARCHAR(80),
                            authorId INT,
                            FOREIGN KEY (authorId) REFERENCES Author(Id) ON DELETE CASCADE
                        );"

                        .ExecuteNonQuery()

                        Console.WriteLine("tables created")

                        'fetch table sql for verification
                        .CommandText = "SELECT sql FROM sqlite_master;"

                        Using reader = .ExecuteReader()
                            With reader
                                While .Read()
                                    Console.WriteLine(!sql)
                                End While
                            End With
                        End Using

                    End With
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("New Error")
            Console.WriteLine(ex)
        End Try
    End Sub

    Public Function AddBook(book As Book) As Long
        Dim LastInsertRowId As Long

        Try
            Using connection = connect()
                Using cmd = New SQLiteCommand()
                    Dim author As Author = book.Author

                    With cmd
                        .Connection = connection

                        'new author
                        .CommandText = "INSERT INTO 
                        Author(firstname, lastname, pseudo) 
                        VALUES(@firstname, @lastname, @pseudo);"

                        With .Parameters
                            .AddWithValue("@firstname", author.Firstname)
                            .AddWithValue("@lastname", author.Lastname)
                            .AddWithValue("@pseudo", author.Pseudo)
                        End With
                        .ExecuteNonQuery()

                        Console.WriteLine("Author created with ID =" & connection.LastInsertRowId)

                        Dim authorId = connection.LastInsertRowId

                        'new book
                        .CommandText = "INSERT INTO 
                        Book(photo, title, description, pageNumber, authorId) 
                        VALUES(@photo, @title, @description, @pageNumber, @authorId);"

                        With .Parameters
                            .AddWithValue("@photo", book.Photo)
                            .AddWithValue("@title", book.Title)
                            .AddWithValue("@description", book.Description)
                            .AddWithValue("@pageNumber", book.PageNumber)
                            .AddWithValue("@authorId", authorId)
                        End With

                        .ExecuteNonQuery()

                        LastInsertRowId = connection.LastInsertRowId
                        Console.WriteLine("LastInsertRowId ID - " & LastInsertRowId)
                    End With
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("addBook Error")
            Console.WriteLine(ex)
        End Try

        Return LastInsertRowId
    End Function

    Public Function GetOneBook(bookId As Long) As Book
        Console.WriteLine("getOneBook....." & bookId)
        Dim book As New Book()
        Dim author As New Author()

        Try
            Using connection = connect()
                Using bookCmd = New SQLiteCommand()
                    bookCmd.Connection = connection
                    bookCmd.CommandText = "SELECT * FROM Book WHERE id=@bookId;"
                    bookCmd.Parameters.AddWithValue("@bookId", bookId)

                    Using bookReader = bookCmd.ExecuteReader()
                        If bookReader.HasRows Then

                            While bookReader.Read()
                                Using authorCmd = New SQLiteCommand()
                                    authorCmd.Connection = Connect()
                                    authorCmd.CommandText = "SELECT * FROM Author WHERE id=@authorId;"
                                    authorCmd.Parameters.AddWithValue("@authorId", CInt(bookReader!authorId))

                                    Using authorReader = authorCmd.ExecuteReader()
                                        If authorReader.HasRows Then
                                            While authorReader.Read()
                                                With author
                                                    .ID = CInt(authorReader!id)
                                                    .Pseudo = CStr(authorReader!pseudo)
                                                    .Firstname = CStr(authorReader!firstname)
                                                    .Lastname = CStr(authorReader!lastname)
                                                End With

                                                With book
                                                    .ID = CInt(bookReader!id)
                                                    .Title = CStr(bookReader!title)
                                                    .Description = CStr(bookReader!description)
                                                    .PageNumber = CInt(bookReader!pageNumber)
                                                    .Author = author
                                                End With
                                                Console.WriteLine("bookReader!title" & CStr(bookReader!title))
                                            End While
                                        End If
                                    End Using
                                End Using
                            End While
                        End If

                    End Using
                End Using
            End Using

        Catch ex As Exception
            Console.WriteLine("getBook Error")
            Console.WriteLine(ex)
        End Try
        Return book
    End Function

    Public Function GetAllBooks() As DataTable
        Console.WriteLine("getAllBooks.....")
        Dim booksDataTable As New DataTable()

        Try
            Using connection = connect()
                Using bookCmd = New SQLiteCommand()
                    bookCmd.Connection = connection
                    bookCmd.CommandText = "SELECT * FROM Book;"

                    With booksDataTable.Columns
                        .Add("ID", GetType(Long))
                        .Add("Titre", GetType(String))
                        .Add("Nombre de Page", GetType(String))
                        .Add("Description", GetType(String))
                        .Add("Auteur", GetType(String))
                    End With

                    Using bookReader = bookCmd.ExecuteReader()

                        If (bookReader.HasRows) Then
                            While bookReader.Read()
                                Using authorCmd = New SQLiteCommand()
                                    authorCmd.Connection = Connect()
                                    authorCmd.CommandText = "SELECT * FROM Author WHERE id=@authorId;"
                                    authorCmd.Parameters.AddWithValue("@authorId", bookReader!authorId)

                                    Using authorReader = authorCmd.ExecuteReader()
                                        While authorReader.Read()

                                            booksDataTable.Rows.Add(
                                            bookReader!id,
                                            bookReader!title,
                                            bookReader!pageNumber,
                                            bookReader!description,
                                            String.Format(
                                                    "{0} ({1} {2})",
                                                    authorReader!pseudo,
                                                    authorReader!firstname,
                                                    authorReader!lastname
                                                )
                                            )
                                        End While
                                    End Using
                                End Using
                            End While
                        End If

                    End Using
                End Using
            End Using

        Catch ex As Exception
            Console.WriteLine("getAllBooks Error")
            Console.WriteLine(ex)
        End Try

        Return booksDataTable
    End Function

    Public Sub DeleteBook(id As Long)
        Using connection = connect()
            Using cmd = New SQLiteCommand()
                With cmd
                    .Connection = connection
                    .CommandText = "DELETE FROM Book WHERE id=@id"
                    .Parameters.AddWithValue("@id", id)
                    .ExecuteNonQuery()
                End With
                'un auteur peut avoir beaucoup de livre alors on ne le supprime pas
            End Using
        End Using
    End Sub

    Public Sub EditBook(book As Book)
        Using connection = connect()
            Using cmd = New SQLiteCommand()
                With cmd
                    .Connection = connection

                    'update book
                    .CommandText = "UPDATE book SET title=@title, description=@description, pageNumber=@pageNumber WHERE id=@id"
                    .Parameters.AddWithValue("@id", book.ID)
                    .Parameters.AddWithValue("@title", book.Title)
                    .Parameters.AddWithValue("@description", book.Description)
                    .Parameters.AddWithValue("@pageNumber", book.PageNumber)
                    .ExecuteNonQuery()

                    'update author
                    .CommandText = "UPDATE author SET firstname=@firstname, lastname=@lastname, pseudo=@pseudo WHERE id=@id"
                    .Parameters.AddWithValue("@id", book.Author.ID)
                    .Parameters.AddWithValue("@firstname", book.Author.Firstname)
                    .Parameters.AddWithValue("@lastname", book.Author.Lastname)
                    .Parameters.AddWithValue("@pseudo", book.Author.Pseudo)
                    .ExecuteNonQuery()
                End With
            End Using
        End Using
    End Sub

    Public Sub AddFakeBooks()
        Dim book As New Book()
        Dim author As New Author()

        For index = 1 To 20
            With author
                .Firstname = "Firstname" & index
                .Lastname = "Lastname" & index
                .Pseudo = "Pseudo" & index
            End With

            With book
                .Title = "Title-" & index
                .Description = "Description-" & index & vbNewLine & "Lorem ipsum dolor sit amet consectetur adipisicing elit. Unde ex nostrum distinctio ipsum. Maxime, aliquid possimus. Porro exercitationem, perferendis neque repellendus ducimus minima atque expedita. Pariatur ab aspernatur tempore sunt."
                .Photo = "Photo" & index
                .PageNumber = index * 10
                .Author = author
            End With

            AddBook(book)
        Next

    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    Private Function Connect() As SQLiteConnection
        Dim connection As New SQLiteConnection("Data Source=database.v4.db;")

        connection.Open()
        Console.WriteLine("database opened")

        Return connection
    End Function

End Class
