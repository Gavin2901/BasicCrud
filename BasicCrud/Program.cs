using System;
using System.Collections.Generic;

namespace SimpleCrudSystem
{
    class Program
    {
        static List<User> users = new List<User>(); // A list called User to store user data

        static void Main(string[] args)
        {
            // This gets the user input for name and email
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();
            Console.Write("Enter user email: ");
            string email = Console.ReadLine();

            // Adds email and name to the user 
            User newUser = new User(name, email);

            // Adds user to the list
            users.Add(newUser);

            Console.WriteLine("User created successfully");

            static void ReadUser()
            {
                // Get user input
                Console.Write("Enter user email: ");
                string email = Console.ReadLine();

                // Find user in the list by email
                User user = users.Find(u => u.Email == email);

                if (user != null)
                {
                    // Display user information
                    Console.WriteLine("Name: {0}", user.Name);
                    Console.WriteLine("Email: {0}", user.Email);
                }
                else
                {
                    Console.WriteLine("User not found");
                }
            }
        }

        
    }

    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}