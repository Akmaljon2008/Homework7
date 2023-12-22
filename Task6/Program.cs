var st1 = new Student();
st1.name = Console.ReadLine();
st1.age = Convert.ToInt32(Console.ReadLine());
st1.averageGrade = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(st1.GetInfo());
Console.WriteLine(st1.IsExcellentStudent());
class Student {
    public string name;
    public int age;
    public double averageGrade;

    public string GetInfo(){
        return $"Name : {this.name}, Age : {this.age}, Average : {this.averageGrade}";
    }
    public string IsExcellentStudent(){
        if (this.averageGrade > 4.0)return "He is excelent student";
        else return "He isn't excelent student";
    }
}