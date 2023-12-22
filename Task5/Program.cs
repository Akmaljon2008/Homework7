using System;

public class User
{
    public string FirstName;
    public string LastName;
    public string UserName;
    public string Password;

    public void GetInfo()
    {
        Console.WriteLine($"Имя: {FirstName}, Фамилия: {LastName}, Имя пользователя: {UserName}");
    }

   
}

class Program
{
    static void Main(string[] args)
    {
        User[] users = new User[]
        {
            new User { FirstName = "Иван", LastName = "Иванов", UserName = "user1", Password = "pass1" },
            new User { FirstName = "Петр", LastName = "Петров", UserName = "user2", Password = "pass2" },
            new User { FirstName = "Александр", LastName = "Сидоров", UserName = "user3", Password = "pass3" },
            new User { FirstName = "Мария", LastName = "Козлова", UserName = "user4", Password = "pass4" },
            new User { FirstName = "Анна", LastName = "Васильева", UserName = "user5", Password = "pass5" }
        };

        Console.Write("Enter username : ");
        string userName = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        foreach (var us in users)
        {
            if (us.UserName == userName && us.Password == password)
            {
                Console.WriteLine($"Login successful! Welcome, Mr./Ms. {us.FirstName} {us.LastName}");
            }
            else Console.WriteLine("Error of login"); break;
        }
    }
}