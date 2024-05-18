using task8;

public static class Group
{
    public static void Main()
    {
        Library library = new Library("nuray@gmail.com", "1234");
        Account account = new Account("nuray@gmail.com","1234","Nuray","Pashayeva",18);
        Book book1 = new Book("Da Vinci Kodu", "Dan Braun", 402);
        Book book2 = new Book("Power", "Robert Green", 178);
        Book book3 = new Book("Deep work", "Cal Newport", 356);
        Book book4 = new Book("Zero to one", "Peter Thiel", 280);
        account.GetAccount();
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);
        library.RemoveBook(book1);
        library.GetBooks();

    }
}