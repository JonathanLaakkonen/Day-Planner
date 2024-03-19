using System;
using System.Collections.Generic;
using AddMethod.cs;
using DeleteMethod.cs;
using ModifyMethod.cs;

namespace Day_Planner
{
    class Program
    {
        static List<string> events = new List<string>();

        static void Main(string[] args)
        {
            bool exitRequested = false;

            while (!exitRequested)
            {
                Console.WriteLine("Day Planner App");
                Console.WriteLine("1. Add Event");
                Console.WriteLine("2. Modify Event");
                Console.WriteLine("3. Delete Event");
                Console.WriteLine("4. View Events");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEvent();
                        break;
                    case "2":
                        ModifyEvent();
                        break;
                    case "3":
                        DeleteEvent();
                        break;
                    case "4":
                        ViewEvents();
                        break;
                    case "5":
                        exitRequested = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddEvent()
        {
            Console.Write("Enter event details: ");
            string newEvent = Console.ReadLine();
            events.Add(newEvent);
            Console.WriteLine("Event added successfully!");
        }

        static void ModifyEvent()
        {
            Console.Write("Enter the index of the event to modify: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < events.Count)
            {
                Console.Write("Enter new event details: ");
                string newEvent = Console.ReadLine();
                events[index] = newEvent;
                Console.WriteLine("Event modified successfully!");
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
        }

        static void DeleteEvent()
        {
            Console.Write("Enter the index of the event to delete: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < events.Count)
            {
                events.RemoveAt(index);
                Console.WriteLine("Event deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
        }

        static void ViewEvents()
        {
            Console.WriteLine("Events:");
            for (int i = 0; i < events.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {events[i]}");
            }
        }
    }
}
