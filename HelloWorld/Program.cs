using System;
using System.Collections;
using System.Diagnostics;
using System.IO;

public class Program {
    public static void Main(string[] args)
    {
        Boolean running = true;
        ArrayList Fruits = new ArrayList();

        while (running)
        { 
            if (running == true)
            {
                Console.WriteLine();
                Console.WriteLine("Simple Fruit Management System");
                Console.WriteLine("1. Add new Fruit.");
                Console.WriteLine("2. Remove Fruit.");
                Console.WriteLine("3. Show All Fruits.");
                Console.WriteLine("4. ");
                Console.WriteLine("5. ");
                Console.WriteLine("6. Exit.");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Write("Enter Fruit Name: ");
                        string FruitAdd = Console.ReadLine();
                        Fruits.Add(FruitAdd);
                        Console.WriteLine();
                        Console.WriteLine("Add " + FruitAdd + " To the list");
                        break;
                    case "2":
                        Console.Write("Enter Fruit Name: ");
                        string FruitRemove = Console.ReadLine();
                        Fruits.Remove(FruitRemove);
                        Console.WriteLine();
                        Console.WriteLine("Remove " + FruitRemove + " From the list");
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("Number of Fruits in the list: " + Fruits.Count);
                        Console.Write("Output: ");
                        foreach (string i in Fruits)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        break;
                    case "4":
                        string filePath1 = @"C:\Users\6752301336\Desktop\New folder\HelloWorld\Output.txt";
                        using (StreamWriter writer = new StreamWriter(filePath1))
                        {
                            foreach (object item in Fruits)
                            {          
                                writer.WriteLine(item.ToString()); // Convert each item to its string representation
                            }
                        }
                        Console.WriteLine($"ArrayList successfully written to {filePath1}");
                        break;
                    case "5":
                        string filePath2 = @"C:\Users\6752301336\Desktop\New folder\HelloWorld\Output.txt";

                        using (StreamReader reader = new StreamReader(filePath2))
                        {
                            string line;
                            Fruits.Clear();
                            while ((line = reader.ReadLine()) != null)
                            {
                                Fruits.Add(line);
                            }
                        }
                        Console.WriteLine("Contents read from file:");
                            foreach (var item in Fruits)
                            {
                                Console.WriteLine(item);
                            }
                        break;
                    case "6":
                        Console.WriteLine("Exit the Program.");
                        running = false;
                        break;
                }
            }
        }
    }
}