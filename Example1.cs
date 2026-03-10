public class Student
{
    private int id;
    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }
    
    
}
public class Example1
{
    public static void Main(string[] args)
    {
        Student obj = new Student();
        obj.Id=11;
        Console.Write(obj.Id);
    }
}