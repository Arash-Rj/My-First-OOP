bool A = false;
int i = 0;
Book[] Books = new Book[100];
while (!A)
{
    Console.WriteLine("---------Give me your book information.--------");
    Console.Write("  Feild: ");
    string Feild = Console.ReadLine();
    Console.Write("  Author: ");
    string Author = Console.ReadLine();
    Console.Write("  Title: ");
    string Title = Console.ReadLine();
    Console.Write("  Year published: ");
    int Publishedyear = Convert.ToInt32(Console.ReadLine());
    Console.Write("  Edition: ");
    string Edition = Console.ReadLine();
    Console.Write("  Number of pages: ");
    int Pages = Convert.ToInt32(Console.ReadLine());
    Book Book = new(Feild,Author,Title,Publishedyear,Edition,Pages);
    Books[i] = Book;
    i++;
    Console.Write("Do you wanna add new book?(y/n) ");
    string An = Console.ReadLine();
    if (An == "n")
    { 
        break;
    }

}
Book[] Books1 = new Book[i];
for(int b=0;b<i;b++)
{
    Books1[b] = Books[b];
}
Console.Write("witch Author's book do you wish to see? ");
string Author1 = Console.ReadLine();
Book[] AuthorBooks =SearchBookbyAuthor(Author1,Books1); 
    Book[] SearchBookbyAuthor(string Author, Book[] Book)
{
    int count = 0;
    Book[] books = new Book[Book.Length];
    foreach (Book book in Book)
    {
       if (Author == book.Author)
        {
            books[count] = book;
            count++;
        }
    }
    Book[] AuthorBooks = new Book[count];
    for(int b=0;b<count;b++)
    {
        AuthorBooks[b] = books[b];  
    }
    return AuthorBooks;
}

foreach(Book book in AuthorBooks)
{
    Console.WriteLine(book.Title);
}
