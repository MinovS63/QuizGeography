using System;
class HelloWorld
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to geography test");
        Console.WriteLine("----------------------------");
        Console.WriteLine("The questions are 10");
        Console.WriteLine("For the grading scale write SCALE");
        Console.WriteLine("To continue with the test write START");
        Console.WriteLine("Your choice is? "); string choice = Console.ReadLine();
        if (choice == "START")
        {
            PrintTest();
        }
        if (choice == "SCALE")
        {
            PrintScale();
        }
    }
    static void PrintTest()
    {
        string correct1 = "Moscow";
        string correct2 = "Brazil";
        string correct3 = "Germany";
        string correct4 = "Southern";
        string correct5 = "Everest";
        string correct6 = "India";
        string correct7 = "Tokyo";
        string correct8 = "Bulgarian";
        string correct9 = "English";
        string correct10 = "Serbia";

        int point1 = 1;
        int point2 = 2;
        double point0 = 0.5;

        Console.Write("Question1: Whats the capital of Russia?: "); string answer1= Console.ReadLine();
        Console.Write("Question2: Whats the biggest country in South America?: "); string answer2 = Console.ReadLine();
        Console.Write("Question3: Which country speaks german?: "); string answer3 = Console.ReadLine();
        Console.Write("Question4: In which globe is South Africa located?: "); string answer4 = Console.ReadLine();
        Console.Write("Question5: Whats the highest mountain?: "); string answer5 = Console.ReadLine();
        Console.Write("Question6: Whats the most populated country?: "); string answer6 = Console.ReadLine();
        Console.Write("Question7: Whats the most populated city?: "); string answer7 = Console.ReadLine();
        Console.Write("Question8: Whats the language spoken in Bulgaria?: "); string answer8 = Console.ReadLine();
        Console.Write("Question9: Whats the language spoken in Pakistan?: "); string answer9 = Console.ReadLine();
        Console.Write("Question10: Which country's capital is Belgrade?: "); string answer10 = Console.ReadLine();
        for (int i = 0; i <= 10; i++)
        {
            if (answer1==correct1)
            {
                i++;
            }
            if (answer2==correct2)
            {
                i++;
            }
            if (answer3 == correct3)
            {
                i++;
            }
            if (answer4 == correct4)
            {
                i++;
            }
            if (answer5 == correct5)
            {
                i++;
            }
            if (answer6 == correct6)
            {
                i++;
            }
            if (answer7 == correct7)
            {
                i++;
            }
            if (answer8 == correct8)
            {
                i++;
            }
            if (answer9 == correct9)
            {
                i++;
            }
            if (answer10 == correct10)
            {
                i++;
            }
            Console.WriteLine("Points"+i);
            if (i < 5)
            {
                Console.WriteLine("Your result is F, you fail dumb fuck");
            }
            else if (i>=5 && i<6)
            {
                Console.WriteLine("Your result is D, still dumb");
            }
            else if (i>=6 && i<7)
            {
                Console.WriteLine("Your result is C, average 9-5");
            }
            else if (i>=7 && i<8)
            {
                Console.WriteLine("Your result is B, you are getting there.. probably");
            }
            else if (i>=8 && i<=10)
            {
                Console.WriteLine("Your result is A, there is hope for you");
            }
        }
    }
    static void PrintScale()
    {
        Console.WriteLine("---------------SCALE-----------------");
        Console.WriteLine("From 0-4 is F");
        Console.WriteLine("From 5-6 is D");
        Console.WriteLine("From 6-7 is C");
        Console.WriteLine("From 7-8 is B");
        Console.WriteLine("From 8-10 is A");
        Console.Write("Do you want to start now?: "); string choicescale = Console.ReadLine();
        if (choicescale=="YES")
        {
            PrintTest();
        }
        if (choicescale=="NO")
        {
            
        }
    }
}