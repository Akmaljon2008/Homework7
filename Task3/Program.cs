int day = Convert.ToInt32(Console.ReadLine());
int month = Convert.ToInt32(Console.ReadLine());
int year = Convert.ToInt32(Console.ReadLine());
var d1 = new Date(day, month, year);
System.Console.WriteLine(d1.SetDate);
System.Console.WriteLine(d1.GetMonth());
System.Console.WriteLine(d1.GetDay());
System.Console.WriteLine(d1.GetYear());
System.Console.WriteLine(d1.ToString());
class Date{
    private int day;
    private int month;
    private int year;

    public Date(int day , int month, int year){
        this.day = day;
        this.month = month;
        this.year = year;

    }
    public void SetDate(int day, int month , int year){
        this.day = day;
        this.month = month;
        this.year = year;
    }
    public int GetMonth(){
        return this.month;
    }
    public int GetYear(){
        return this.year;
    }
    public int GetDay(){
        return this.day;
    }
    public string ToString(){
        return $"{this.day}/{this.month}/{this.year}";
    }

}