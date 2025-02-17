Imports System.Data

Class MainWindow
    Dim appDB As New AppDB()
    Dim dataTable As DataTable

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim myBookForm As New BookForm(dataTable)

        myBookForm.ShowDialog()
    End Sub

    Private Sub LibraryWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles LibraryWindow.Loaded
        appDB.addFakeBooks()
        dataTable = appDB.getAllBooks()

        BooksDatagrid.ItemsSource = dataTable.DefaultView
    End Sub

    Private Sub LibraryWindow_Activated(sender As Object, e As EventArgs) Handles LibraryWindow.Activated, LibraryWindow.Activated
        WindowState = WindowState.Maximized
    End Sub

    Private Sub Bibliothèque_Loaded(sender As Object, e As RoutedEventArgs) Handles Bibliothèque.Loaded
        'appDB.addFakeBooks()
    End Sub

    Private Sub EditRow_Click(sender As Object, e As RoutedEventArgs)
        With BooksDatagrid
            Dim myBookForm As New BookForm(dataTable, .SelectedItem()!ID, .SelectedIndex)
            myBookForm.ShowDialog()
        End With
    End Sub
    Private Sub DeleteRow_Click(sender As Object, e As RoutedEventArgs)
        If MsgBox("Voulez-vous vraiement supprimer ce livre ?", vbYesNo) = vbYes Then
            With BooksDatagrid
                appDB.deleteBook(.SelectedItem()!ID)
                dataTable.Rows.RemoveAt(.SelectedIndex)
            End With
        End If
    End Sub
End Class
