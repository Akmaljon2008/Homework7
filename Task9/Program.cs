string name = Console.ReadLine();
int age = Convert.ToInt32(Console.ReadLine());
string nationality = Console.ReadLine();
var a1 = new Author(name, age , nationality);
Console.WriteLine(a1.Introduce());


class Author{
    public string name;
    public int age;
    public string nationality;


    public Author(){}

    public Author(string name, int age){
    this.name = name;
    this.age = age; 
    }
    public Author(string name, int age, string nationality){
    this.name = name;
    this.age = age; 
    this.nationality = nationality;
    }
    public string GetName(){
        return name;
    }
    
    public int GetAge(){
        return age;
    }
    public string Nationality(){
        return nationality;
    }
    public string Introduce(){
        return $"My name is {this.name}. I'm {this.age} years old . I'm from {this.nationality} ";
    }
}