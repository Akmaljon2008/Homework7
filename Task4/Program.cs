var c1 = new Calculator();
c1.num1 = Convert.ToInt32(Console.ReadLine());
c1.char1 = Convert.ToChar(Console.ReadLine());
c1.num2 = Convert.ToInt32(Console.ReadLine());
if(c1.char1 == '+')System.Console.WriteLine(c1.Sum());
if(c1.char1 == '-')System.Console.WriteLine(c1.Substract());
if(c1.char1 == '*')System.Console.WriteLine(c1.Multiply());
if(c1.char1 == '/')System.Console.WriteLine(c1.Devide());
class Calculator{
    public int num1;
    public int num2;
    public char char1;


    public int Sum(){
        return num1 + num2;
    }
    public int Substract(){
        return num1 - num2;
    }
    public int Multiply(){
        return num1 * num2;
    }
    public int Devide(){
        return num1 / num2;
    }
}