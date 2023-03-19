using System;

namespace Udemy_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int availableRooms = 10;
            Tenant[] rooms = new Tenant[availableRooms];

            Console.Write("How many rooms will be rented? ");
            int rentedRooms = int.Parse(Console.ReadLine());
            if (rentedRooms > 10)
            {
                Console.WriteLine("Sorry, We have just 10 availables rooms :(");
                return;
            }

            Console.WriteLine();

            for (int i = 0; i < rentedRooms; i++)
            {
                Console.WriteLine($"Rent #{i+1}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room (0 - 9): ");
                int room = int.Parse(Console.ReadLine());
                if (room > 9)
                {
                    Console.WriteLine("Please, select a room between 0 and 9");
                    room = int.Parse(Console.ReadLine());
                    
                    if (room > 9)
                    {
                        Console.WriteLine("Sorry, We do not have so many rooms :(");
                        return;
                    }
                }

                Console.WriteLine();

                Tenant student = new Tenant(name, email, room);
                rooms[room] = student;
            }

            Console.WriteLine();

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < availableRooms; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine(rooms[i]);
                }
            }
        }
    }
}