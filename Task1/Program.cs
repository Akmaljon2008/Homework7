
string title = Console.ReadLine();
string author = Console.ReadLine();
int year = Convert.ToInt32(Console.ReadLine());

var b1 = new Book(title , author , year);
Console.WriteLine(b1.GetInfo());
Console.WriteLine(b1.IsPublishedRecently());




public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public string GetInfo()
    {
        return $"Название: {Title}, Автор: {Author}, Год публикации: {Year}";
    }

    public string IsPublishedRecently()
    {
        if (Year > 2010) return "True";
        else return "False";
    }
}