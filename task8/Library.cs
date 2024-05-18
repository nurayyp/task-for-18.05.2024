namespace task8
{
    public class Library
    {
        private Book[] books;
        public Book[] Books { get { return books; } }
        public int Limit { get; set; } = 5;
        public string Email { get; set; }
        public string Password { get; set; }
        public Library(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public void AddBook(Book book)
        {
            if (Limit > books.Length)
            {
                Array.Resize(ref books, books.Length + 1);
                books[books.Length - 1] = book;
            }
            else
            {
                Console.WriteLine("sebetde yeni kitaba yer yoxdur");
            }
        }
        public void RemoveBook(Book book)
        {
            int index = Array.IndexOf(books, book);
            if (index != -1)
            {
                for (int i = index; i < books.Length - 1; i++)
                {
                    books[index] = books[index + 1];
                }
                Array.Resize(ref books, books.Length - 1);
            }
            else
            {
                Console.WriteLine("Bu kitab sebetde yoxdur");
            }
        }
        public void GetBooks()
        {
            foreach (var book in books)
            {
                book.GetDetails();
            }
        }
    }
}
