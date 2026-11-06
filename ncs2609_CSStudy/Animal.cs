public class Animal()
{
    public string Name{get; set;}
    public int Age{get; set;}
}

public class Dog: Animal()
{
    public void HowOld()
    {
        Console.WriteLine("나이: {0}", Age);
    }
}

public class Bird: Animal()
{
    public void Fly()
    {
        Console.WriteLine($"{this.Name}가 날다");
    }
}
public class MyBase
{
    public string Name{get; set;}
    protected int Age{get; set;}
}
public class MyDerived: MyBase
{
    public void Run()
    {
        Console.WriteLine("나이{0}", Age);
    }
}