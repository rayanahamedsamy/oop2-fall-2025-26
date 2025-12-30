using System;
namespace StudentRecordSystem;

interface IStudent
{
    void Display();
}

class Student : IStudent
{
    private string name;
    private int[] marks = new int[3];

    public Student(string name)
    {
        this.name = name;
    }

    public int this[int index]
    {
        get { return marks[index]; }
        set { marks[index] = value; }
    }

    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine($"Subject " + (i + 1) + ": " + marks[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student stu = new Student("Rayan Ahamed Samy");
        stu[0] = 85;
        stu[1] = 90;
        stu[2] = 78;
        stu.Display();
    }
}
