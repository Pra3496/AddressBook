using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay10
{
    public class Person         //Creating class
    {
        public string FirstName;
        public string LastName;
        
        public static List<Person> people = new List<Person>();
      
        //Creating contructor for address book
        public Person() { }
        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            
        }
        public static void AddPerson(int numContact)          //Creating method for taking user inputs
        {
            for (int i = 1; i <= numContact; i++)
            {

                Person person = new Person();
                Console.CursorLeft = 70;
                Console.WriteLine("----{0}----",i);
                Console.CursorLeft = 70;
                Console.Write("Enter First Name:     ");
                person.FirstName = Console.ReadLine();
                Console.CursorLeft = 70;
                Console.Write("Enter Last Name:      ");
                person.LastName = Console.ReadLine();
                people.Add(person);
            }
        }
        public static void PrintPerson()            //Creating method to display persons details
        {
            int no = 1;

            Console.Write("\n");

            Console.CursorLeft = 73;
            Console.Write("**************>| All Contacts Present in Address Book |<*************", Console.CursorLeft);
            
            Console.Write("\n\n");

            
            foreach (Person per in people)
            {
                
                Console.CursorLeft = 74;
                Console.WriteLine("-------------------- {0} -------------------",no);
                Console.CursorLeft = 74;
                Console.WriteLine("First Name:   "+per.FirstName);
                Console.CursorLeft = 74;
                Console.WriteLine("Last Name:    " +per.LastName);
                Console.CursorLeft = 74;
                Console.WriteLine("------------------------------------------");
                no++;
            }
            Console.Write("\n");
            Console.CursorLeft = 73;
            Console.Write("******************************>| END |<******************************", Console.CursorLeft);
            Console.Write("\n");
        }
        public static void editContact(string name, int opt)        //Creating Method to edit contact
        {
            bool input = false;
           
            foreach (Person person in people)
            {
                if (person.FirstName == name)
                {
                    Console.CursorLeft = 70;
                    Console.WriteLine("MATCH FOUND !!!", Console.CursorLeft);
                    Console.WriteLine();
                    Console.CursorLeft = 70;
                    Console.WriteLine("Current Details");
                    Console.CursorLeft = 70;
                    Console.WriteLine(person.FirstName);
                    Console.CursorLeft = 70;
                    Console.WriteLine(person.LastName);

                    input = true;
                    switch (opt)         //Switch case for editing parameter
                    {
                        case 1:
                            Console.CursorLeft = 70;
                            Console.Write("Enter current first name:   ");
                            string currentFirstName = Convert.ToString(Console.ReadLine());
                            person.FirstName = currentFirstName;
                            Console.CursorLeft = 88;
                            Console.WriteLine("CHANGE DONE...");
                            break;
                        case 2:
                            Console.CursorLeft = 70;
                            Console.Write("Enter current last name:    ");
                            string currentLastName = Convert.ToString(Console.ReadLine());
                            person.LastName = currentLastName;
                            Console.WriteLine("CHANGE DONE...");
                            break;
                        
                        default:
                            Console.Write("Please enter valid option");
                            break;
                    }
                }
                
            }
            if (input == false)
            {
                Console.CursorLeft = 70;
                Console.WriteLine("Initials not found");
            } 
        }
        public static void deleteContact(string name)      //Creating method for delete contact
        {
            bool flag = false;
            foreach (Person person1 in people)
            {
                if (person1.FirstName == name)
                {
                    flag = true;
                    people.Remove(person1);
                    Console.CursorLeft = 70;
                    Console.WriteLine("The contact is successfully removed");
                    break;
                }
            }
            if (flag == false)
            {
                Console.CursorLeft = 70;
                Console.WriteLine("The contact is not found");
            }
                
        }
    }
}