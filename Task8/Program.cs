var u1 = new User();
u1.firstname = Console.ReadLine();
u1.lastname = Console.ReadLine();
u1.username = Console.ReadLine();
u1.password = Console.ReadLine();
u1.islogined = true;
string username = Console.ReadLine();
string password = Console.ReadLine();

Console.WriteLine(u1.LogIn(username , password));
Console.WriteLine(u1.GetInfo());



class User{
    public string firstname;
    public string lastname;
    public string username
    public string password;
    public bool islogined;

    public void LogIn(string username, string password)
    {
        if (this.username == username && this.password == password){
           Console.WriteLine("User logged in successfully"); 
        }
        else Console.WriteLine("Your password or username is incorrect.");
    }
    public void Logout(){
        this.islogined = false;
    }
    public string GetInfo(){

    }
    
}