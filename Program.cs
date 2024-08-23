using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice_1
{
    internal class Program
    {
        // Create your Data Base Here : 
        static Dictionary<string, string> Contacts = new Dictionary<string, string>();
        // A dictionary 
        static void Main(string[] args)
        {
            // Simple Contact Manager
            // Use a Simple Dictionary Based DataBase
            // The Data That Are Going to Save : contact, Contact number
            // Functions : Add, Delete, Search, DisplayAll
            // Add the Exeptions (try catch)

            while (true)
            {
                try
                {
                    Console.WriteLine("Welcome to the Contact Manager App");
                    Console.WriteLine("Enter 1 for Displaying Contacts");
                    Console.WriteLine("Enter 2 for Adding Contact");
                    Console.WriteLine("Enter 3 for Searching");
                    Console.WriteLine("Enter 4 for Delete a contact");
                    Console.WriteLine("Enter 0 to Exit");
                    Console.WriteLine("............................");

                    char choice = Convert.ToChar(Console.ReadLine());
                    if (choice == '1')
                    {
                        Console.Clear();
                        displayContacts();
                        Console.Write("Press Enter To Back To the Menu");
                        Console.ReadLine();
                    }
                    else if (choice == '2')
                    {
                        Console.Clear();
                        Console.Write("Enter the Name : ");
                        string name = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("name Cannot be Empty");
                            return;
                        }
                        Console.Write("Enter the Contact : ");
                        string contact = Console.ReadLine();
                        if (contact.Containskey(name))
                        {
                            Console.WriteLine("This Contact Already Exist!!!");
                            return;
                        }
                        addContact(name, contact);
                        Console.WriteLine("Contact Added SuccessFully");
                        Console.Write("Press Enter To Back To the Menu");
                        Console.ReadLine();
                    }
                    else if (choice == '3')
                    {
                        Console.Clear();
                        Console.Write("Enter a name to search : ");
                        string searchName = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(searchName))
                        {
                            searchContact(searchName);
                        }
                        else
                        {
                            Console.WriteLine("Please Enter a valid Name");
                            return;
                        }
                        Console.Write("Press Enter To Back To the Menu");
                        Console.ReadLine();
                    }
                    else if (choice == '4')
                    {
                        Console.Clear();
                        Console.Write("Enter a name to Delete");
                        string deleteName = Console.ReadLine();
                        deleteContact(deleteName);

                    }

                    Console.WriteLine("An Error Has Ocourd!!! Restart the App");
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

            }
        }
        static void displayContacts()
        {
            foreach (KeyValuePair<string, string> Pair in Contacts)
            {
                Console.WriteLine($"{Pair.Key},{Pair.Value}");
            }
            // Show All The Contacts : 
        }

        static void addContact(string name, string contact)
        {
            Contacts.Add(name, contact);
            // Add a New Contact
        }
        static void searchContact(string searchName)
        {
            foreach (KeyValuePair<string, string> Pair in Contacts)
            {
                if (searchName == Pair.Key)
                {
                    Console.WriteLine($"{Pair.Value}");
                }
            }
            // Search a Contact via its Name
        }

        static void deleteContact(string fullName)
        {
            foreach (KeyValuePair<string, string> Pair in Contacts)
            {
                if (fullName == Pair.Key)
                {
                    Contacts.Remove(Pair.Key);
                }
            }
            // Delete a Contact Via its name
        }
    }
}
