// See https://aka.ms/new-console-template for more information

using classOOP;

class Program
{
    public static void Main()
    {
        students st1 = new students();
        st1.name = "A";
        st1.age = 20;
        st1.address = "HN";
        Console.WriteLine("Student Information:");
        Console.WriteLine("Name: " + st1.name);
        Console.WriteLine("Age: " + st1.age);
        Console.WriteLine("Address: " + st1.address);
        st1.eat();
        st1.sleep();
        students[] student = new students[10];
    }
}