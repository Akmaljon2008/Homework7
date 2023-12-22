double radius = Convert.ToDouble(Console.ReadLine());
Circle circle = new Circle(radius);
Console.WriteLine(circle.GetArea());
Console.WriteLine(circle.GetDiameter());
Console.WriteLine(circle.GetCircumference());
class Circle{
    private double radius;
    private double pi = 3.14159;

    public Circle(double radius){
      this.radius = radius;
    }
    public Circle(){
      this.radius = 0.0;
    }
    public void SetRadius(double radius){
     this.radius = radius;
    }
    public double GetRadius(){
        return radius;
    }
    public double GetArea(){
        return pi * radius * radius;
    }
    public double GetDiameter(){
        return radius * 2;
    }
    public double GetCircumference(){
        return 2 * pi * radius;
    }
    
 }