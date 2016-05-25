using System;

class StudentClass
{
    static void Main()
    {
        Student someStudent = new Student();

        someStudent.FirstName = "Pesho";
        someStudent.LastName = "Peshov";

        Student anotherStudent = new Student();

        anotherStudent.FirstName = "Ivo";
        anotherStudent.LastName = "Ivov";

        Console.WriteLine(someStudent.FirstName);
        Console.WriteLine(anotherStudent.FirstName);
    }
}

class Student
{
    // public => can be accessed from another class
    public string FirstName;

    public string LastName;

    public int Age;
}