namespace School_Classes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class TestingSchoolClasses
    {
        static void Main()
        {
            Console.BufferHeight = 70;

            // Creating school
            School telerik = new School("Telerik Academy");

            // Creating students
            Student[] studentsFirstClass = new Student[]
            {
                new Student("Petya Yordanova", 7025001, "5,5,6,6,6"),
                new Student("Lazar Hristov", 7025002, "5,5,5,5,5"),
                new Student("Hristina Kostova", 7025003, "5,5,5,6,6"),                
                new Student("Ivan Todorov", 7025004, "6,6,5,5,5,5")
            };

            Student[] studentsSecondClass = new Student[]
            {
                new Student("Pavlina Ivanova", 7025005, "4,5,6,5,5"),
                new Student("Kalina Stoyanova", 7025006, "5,5,5,5,5"),
                new Student("Georgi Petrov", 7025007, "5,5,4,4,4"),
                new Student("Albena Malinova", 7025008, "4,5,4,5,4"),
                new Student("Hristo Georgiev", 7025009, "5,5,6,5,5"),
                new Student("Stanislav Mihailov", 7025010, "5,4,5,4,5"),
            };

            // Creating disciplines
            Discipline cSharp1 = new Discipline("C#1", 6, 6, "CSharp Part 1");
            Discipline cSharp2 = new Discipline("C#2", 8, 8, "CSharp Part 2");
            Discipline oOP = new Discipline("OOP", 6, 6);
            Discipline hTML = new Discipline("HTML", 4, 4);

            // Creating teachers
            Teacher ivaylo = new Teacher("Ivaylo Kenov", "Trainer");
            Teacher nikolay = new Teacher("Nikolay Kostov", "Trainer");            
            Teacher doncho = new Teacher("Doncho Minkov", "Trainer");
            Teacher evlogi = new Teacher("Evlogi Hristov", "Trainer");

            // Adding disciplines
            ivaylo.AddDiscipline(cSharp1, cSharp2, oOP);
            nikolay.AddDiscipline(cSharp1, cSharp2, hTML);            
            doncho.AddDiscipline(hTML);
            evlogi.AddDiscipline(oOP);

            // Creating classes of students
            ClassOfStudents firstClass = new ClassOfStudents("Class Morning", "from 10:00");
            ClassOfStudents secondClass = new ClassOfStudents("Class Evening", "from 16:30");

            // Adding teachers
            firstClass.AddTeacher(ivaylo, nikolay);
            secondClass.AddTeacher(nikolay, ivaylo, doncho, evlogi);

            // Adding students
            firstClass.AddStudent(studentsFirstClass);
            secondClass.AddStudent(studentsSecondClass);

            // Adding classes
            telerik.AddClass(firstClass);
            telerik.AddClass(secondClass);

            Console.WriteLine(telerik);          

        }
    }
}