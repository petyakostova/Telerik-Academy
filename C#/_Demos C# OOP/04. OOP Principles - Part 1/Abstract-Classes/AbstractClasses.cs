using System;

class AbstractClasses
{
    static void Main()
    {
        Turtle turtle = new Turtle();
        Console.WriteLine(turtle);//I am turtle
		Console.WriteLine("The {0} can go {1} km/h ",
            turtle.GetName(), turtle.Speed);//The turtle can go 1 km/h

		Console.WriteLine();

		Cheetah cheetah = new Cheetah();
		Console.WriteLine(cheetah);//I am cheetah
		Console.WriteLine("The {0} can go {1} km/h ",
            cheetah.GetName(), cheetah.Speed);//The cheetah can go 100 km/h

		Console.WriteLine();

		Tomcat tomcat = new Tomcat();
        Console.WriteLine(tomcat);//I am tomcat
		Console.WriteLine("The {0} can go {1} km/h ",
            tomcat.GetName(), tomcat.Speed);//The tomcat can go 20 km/h
        tomcat.SayMyaau();//Tomcat muaaaaaaaau

		Console.WriteLine();

		Kitten kitten = new Kitten();
        Console.WriteLine(kitten);//I am kitten
		Console.WriteLine("The {0} can go {1} km/h ",
			kitten.GetName(), kitten.Speed);//The kitten can go 5 km/h
        kitten.SayMyaau();//Kitten miau, miaau

		// This wil not compile (Cat is abstract -> cannot be instantiated)
		//Cat cat = new Cat();
	}
}
