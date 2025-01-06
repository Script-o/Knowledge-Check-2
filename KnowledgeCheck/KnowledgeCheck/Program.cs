using System;
using System.Reflection;

namespace KnowledgeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInputCheck userInputCheck = new UserInputCheck();

            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<MagicCard>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myClass = new MagicCard();

                Console.WriteLine($"Enter the value for Name of card {i+1}");
                Console.Write("Name: ");
                myClass.Name = Console.ReadLine();

                Console.WriteLine($"Enter the value for Price of card {i+1}");
                Console.Write("$: ");
                string input = Console.ReadLine();
                myClass.Price = UserInputCheck.DecimalCheck(input);

                Console.WriteLine($"Enter the value for Mana Cost of card {i + 1}");
                Console.Write("Mana Cost: ");
                input = Console.ReadLine();
                myClass.ManaCost = UserInputCheck.IntegerCheck(input);

                Console.WriteLine($"Enter the value for Power of card {i + 1}");
                Console.Write("Power: ");
                input = Console.ReadLine();
                myClass.Power = UserInputCheck.IntegerCheck(input);

                Console.WriteLine($"Enter the value for Toughness of card {i + 1}");
                Console.Write("Toughness: ");
                input = Console.ReadLine();
                myClass.Toughness = UserInputCheck.IntegerCheck(input);

                recordList.Add(myClass);
                Console.WriteLine($"\n");
            }

            // Print out the list of records using Console.WriteLine()
            foreach (var record in recordList) 
            {
                Console.WriteLine($"\nName: {record.Name}, Price: {record.Price}, Mana Cost: {record.ManaCost}");
                Console.WriteLine($"Power: {record.Power}, Toughness: {record.Toughness}");
            }
        }
    }
}