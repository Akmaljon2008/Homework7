var r1 = new Rectangle();
r1.width = Convert.ToInt32(Console.ReadLine());
r1.height = Convert.ToInt32(Console.ReadLine());
r1.color= Console.ReadLine();
Console.WriteLine(r1.GetArea());
Console.WriteLine(r1.GetPerimeter());

class Rectangle{
    public int width;
    public int height;
    public string color;

   public int GetArea(){
    return width * height;
   }
   public int GetPerimeter(){
    return (width + height) * 2;
   }
   
}