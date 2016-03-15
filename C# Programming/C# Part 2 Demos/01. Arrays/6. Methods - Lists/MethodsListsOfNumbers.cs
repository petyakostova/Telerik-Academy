using System;
using System.Collections.Generic;

class MethodsLists
{
    static void Main()
    {
        // първи начин за добавяне на колекция
        List<int> listOfNumbers = new List<int>();
        listOfNumbers.AddRange(new[] {1, 2, 3, 4}); // добавяме някаква колекция
        
        // втори начин за добавяне на колекция
        int[] array = { 1, 2, 3, 4 };
        List<int> listOfNumbers2 = new List<int>();
        listOfNumbers2.AddRange(array); // добавяме някаква колекция

        // добавяне на друг лист
        List<int> listOfOtherNumbers = new List<int>();
        List<int> listOfNumbers3 = new List<int>();
        listOfNumbers3.AddRange(listOfOtherNumbers); // добавяме някакъв лист (конкатенираме)

        listOfNumbers.Add(5);   // 1 2 3 4 5 

        foreach (var item in listOfNumbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(listOfNumbers[3]);    // 4
        Console.WriteLine(listOfNumbers[4]);    // 5
        //Console.WriteLine(listOfNumbers[5]);    // ArgumentOutOfRangeException - не е добавен такъв елемент

        Console.WriteLine(new string('-', 20));

        List<List<int>> listOfNumbers4 = new List<List<int>>();
        // първият списък от числа - listOfNumbers4[0]
        // първият елемент от първия списък от числа - listOfNumbers4[0][0] - има по-лесен начин затова, нар. назъбени масиви

        // нямаме нулев списък (в първия списък няма никакви списъци), затова не можем да пипаме по индекси (да присвояваме стойност например):
        // listOfNumbers4[0][0] = 7; // дава ArgumentOutOfRangeException
        listOfNumbers4.Add(new List<int>()); //затова в списъка от списъци добавяме списък, но трябва да добавим и елементи в този списък:
        listOfNumbers4[0].Add(7);   // добавяме елемента 7
        Console.WriteLine(listOfNumbers4[0][0]); // тогава вече можем да го изпишем на конзолата

        listOfNumbers2.Clear();  // изчистваме всички елементи => празен списък в нула елемента
        //Console.WriteLine(listOfNumbers2[0]); // дава ArgumentOutOfRangeException

        Console.WriteLine(listOfNumbers.Contains(4));   // True
        Console.WriteLine(listOfNumbers.Contains(123)); // False

        Console.WriteLine(listOfNumbers.Count); // връща размера на листа
        Console.WriteLine(listOfNumbers.IndexOf(4)); // връща индекса, на който е намерено дадено число => 3
        Console.WriteLine(listOfNumbers.IndexOf(123)); // ако не го намери дава -1

        List<int> listOfNumbers5 = new List<int>();
        listOfNumbers5.AddRange(new[] { 3, 1, 2, 3, 4, 3 });
        Console.WriteLine("listOfNumbers5.Remove(3)= " + listOfNumbers5.Remove(3));    // маха първото срещане на числото 3
        foreach (var item in listOfNumbers5)
        {
            Console.Write(item + " ");  // 1 2 3 4 3
        }
        Console.WriteLine();

        listOfNumbers5.RemoveAll(x => x == 3); // маха всички числа 3
        foreach (var item in listOfNumbers5)
        {
            Console.Write(item + " ");  // 1 2 4
        }
        Console.WriteLine();

        listOfNumbers5.Reverse();   // обръща списъка наобратно
        foreach (var item in listOfNumbers5)
        {
            Console.Write(item + " ");  // 4 2 1
        }
        Console.WriteLine();

        List<int> listOfNumbers6 = new List<int>();
        listOfNumbers6.AddRange(new[] { 7, 2, 3, 6, 5, 1, 4 });
        listOfNumbers6.Sort();  // сортира списъка
        foreach (var item in listOfNumbers6)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}