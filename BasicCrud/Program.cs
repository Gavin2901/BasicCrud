using System;
using System.Collections.Generic;

namespace SimpleCrudSystem
{
    class Program
    {
        static List<User> users = new List<User>(); // A list called User to store user data

        static void Main(string[] args)
        {

            while (true)
            {
                // Display prompt with options
                Console.WriteLine("We got options to spare bruv, choose one innit bruv:");
                Console.WriteLine("1. Add user");
                Console.WriteLine("2. List user by email");
                Console.WriteLine("3. List all users");
                Console.WriteLine("4. Update a User");

                // Get user input
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // Option to add a new user
                        AddUser();
                        break;
                    case "2":
                        // Option to list a user by email
                        ReadUser();
                        break;
                    case "3":
                        // Option to list all users
                        ListAllUsers();
                        break;
                    case "4":
                        // Option to Update a user
                        UpdateUser();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }

        static void AddUser()
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

            Console.WriteLine("User created successfully, Holy shit this works");

        }

        static void ReadUser()
        {
            // Asks to search user by email
            Console.Write("Enter user email: ");
            string email = Console.ReadLine();

            // Find user in the list by email
            User user = users.Find(u => u.Email == email);

            if (user != null)
            {
                // Displays the users name and email
                Console.WriteLine("Name: {0}", user.Name);
                Console.WriteLine("Email: {0}", user.Email);
            }
            else
            {
                Console.WriteLine("User not found, try again dummy"); //error if no user found by that email
            }
        }



        static void ListAllUsers() //list all users
        {
            Console.WriteLine("List of all users:");

            foreach (User user in users)
            {
                Console.WriteLine($"Name: {user.Name}, Email: {user.Email}");
            }
        }

        static void UpdateUser()
        {
            // List all the users
            ListAllUsers();

            // Get user's email address to update
            Console.Write("Enter email address of user to update: ");
            string email = Console.ReadLine();

            // Find user with matching email address
            User userToUpdate = users.Find(u => u.Email == email);

            // If user is found, prompt for new name and email address and update user
            if (userToUpdate != null)
            {
                Console.Write("Enter new name (press Enter to keep existing name): ");
                string name = Console.ReadLine();

                Console.Write("Enter new email address (press Enter to keep existing email address): ");
                string newEmail = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                {
                    userToUpdate.Name = name;
                }

                if (!string.IsNullOrWhiteSpace(newEmail))
                {
                    userToUpdate.Email = newEmail;
                }

                Console.WriteLine("User updated successfully");
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
