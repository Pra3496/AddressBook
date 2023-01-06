using System;
using System.Diagnostics.Contracts;

namespace AddressBookDay10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // setting the window size


            // setting buffer size of console


            // using the method
            

            // Get the CursorLeft position
            


            Console.SetWindowSize(210,50);


            
            //Start
            Main_Menu:
                        Console.Write("\n\n\n\n");
                        Console.CursorLeft = 70;
                        Console.WriteLine("__________________________________________________________________");
                        Console.WriteLine();
                        Console.CursorLeft = 90;
                        Console.WriteLine("WELCOME TO ADDRESS BOOK PROGRAM",Console.CursorLeft);
                        
                        Console.CursorLeft = 70;
                        Console.Write("__________________________________________________________________", Console.CursorLeft);
                        Console.Write("\n\n");
                        Console.CursorLeft = 80;
                        Console.WriteLine("|  1: Ability to create Contacts in AddressBook  |", Console.CursorLeft);
                        Console.CursorLeft = 80;
                        Console.WriteLine("|  2: Ability to add new coontact to AddressBook |",Console.CursorLeft);

                        Console.CursorLeft = 80;
                        Console.WriteLine("|  3: Edit contact in AddressBook                |", Console.CursorLeft);

                        Console.CursorLeft = 80;
                        Console.WriteLine("|  4: Remove contact from AddressBook            |", Console.CursorLeft);

                        Console.CursorLeft = 80;
                        Console.WriteLine("|  5: Display All Contacts                       |", Console.CursorLeft);

                        Console.CursorLeft = 80;
                        Console.WriteLine("|  6: Exit from Application                      |", Console.CursorLeft);


                        Console.WriteLine();
                        Console.CursorLeft = 70;
                        Console.Write("__________________________________________________________________");
                        Console.Write("\n");
                        Console.CursorLeft = 70;
                        Console.Write("Enter Your Choice : ", Console.CursorLeft);
                        int option = Convert.ToInt32(Console.ReadLine());   
                        //Taking user input
                        //Calling methods using Switch case for UC1,UC2, UC3, UC4 and UC5
                        Console.Clear();
            
                        switch (option)
                        {
                            case 1:
                                {
                                    Console.Write("\n\n\n\n");
                                    
                                    Console.CursorLeft = 87;
                                    Console.Write("CREATE CONTACTS IN ADDRESS-BOOK");
                                    Console.WriteLine();
                                    Console.CursorLeft = 70;
                                    Console.WriteLine("__________________________________________________________________");
                                    Console.WriteLine();
                                    Console.CursorLeft = 70;


                                    Console.Write("Enter the number of contact you wanted to Make : ",Console.CursorLeft);
                                    int numContact = Convert.ToInt32(Console.ReadLine());
                                    Person.AddPerson(numContact);
                                    Console.Write("\n");
                                    Console.CursorLeft = 90;
                                    Console.WriteLine("Successfully Added Contact...!!");
                                    Console.Write("\n");
                                    Console.CursorLeft = 70;
                                    Console.WriteLine("__________________________________________________________________");
                                    Console.CursorLeft = 70;
                                    Console.Write("Press any key to Main menu..");
                                    
                                    Console.ReadKey();
                                    Console.Clear();
                                    goto Main_Menu;
                                }
            
                               
                            case 2:
                                {
                                    Console.Write("\n\n\n\n");
                      
                                    Console.CursorLeft = 98;
                                    Console.Write("ADD CONTACT", Console.CursorLeft);
                                    Console.Write("\n");
                                    Console.CursorLeft = 70;
                                    Console.WriteLine("__________________________________________________________________");
                                    Console.Write("\n");
                                    Console.CursorLeft = 70;
                                    Console.Write("Enter the first name of contact you wanted to Make : ");
                                    int numContact = Convert.ToInt32(Console.ReadLine());
                                    Person.AddPerson(numContact);
                                    Console.Write("\n");
                                    Console.CursorLeft = 90;
                                    Console.WriteLine("Successfully Added Contact...!!");
                                    Console.Write("\n");
                                    
                                    Console.CursorLeft = 70;
                                    Console.WriteLine("__________________________________________________________________");
                                    Console.CursorLeft = 70;
                                    Console.Write("Press any key to Main menu..");
                                    
                                    Console.ReadKey();
                                    Console.Clear();
                                    goto Main_Menu;
                    }
                                
                            case 3:
                                {
                                    Console.Write("\n\n\n\n");
                                    
                                    Console.CursorLeft = 87;
                                    Console.Write("SEARCH or EDIT IN ADDRESS BOOK");
                                    Console.WriteLine();
                                    Console.CursorLeft = 70;
                                    Console.WriteLine("__________________________________________________________________");
                        
                                    Console.Write("\n\n");
                                    Console.CursorLeft = 70;
                                    Console.WriteLine("|  1: Edit for Firstname  |");
                                    Console.CursorLeft = 70;
                                    Console.WriteLine("|  2: Edit for LastName   |");
                                    Console.Write("\n");
                                    Console.CursorLeft = 70;
                                    Console.Write("Enter your choice :  ");
                                    int opt = Convert.ToInt32(Console.ReadLine());
                                    
                                    Console.CursorLeft = 70;
                                    Console.Write("Enter the Initials(name or last):   ");
                                    string name = Convert.ToString(Console.ReadLine());
                                    Person.editContact(name,opt);
                                    Console.WriteLine();
                                    Console.CursorLeft = 70;
                                    Console.WriteLine("__________________________________________________________________");
                                    Console.CursorLeft = 70;
                                    Console.Write("Press any key to Main menu..");

                                    Console.ReadKey();
                                    Console.Clear();
                                    goto Main_Menu;
                                }
                                
                            case 4:
                                {
                                    Console.Write("\n\n\n\n");
                       
                                    Console.CursorLeft = 87;
                                    Console.Write("DELETE CONTACT FROM ADDRESS BOOK ", Console.CursorLeft);
                                    Console.Write("\n");
                                    Console.CursorLeft = 70;
                                    Console.WriteLine("******************************************************************", Console.CursorLeft);
                                    Console.Write("\n");
                                    Console.CursorLeft = 70;
                                    Console.Write("Enter the first name of contact you wanted to remove : ");
                                    string name = Convert.ToString(Console.ReadLine());
                                    Person.deleteContact(name);
                                    Console.WriteLine();
                                    Console.CursorLeft = 70;
                                    Console.WriteLine("__________________________________________________________________");
                                    Console.CursorLeft = 70;
                                    Console.Write("Press any key to Main menu..");

                                    Console.ReadKey();
                                    Console.Clear();
                                    goto Main_Menu;
                                }
                               
                            case 5:
                                {
                                    Console.Write("\n\n\n\n");
                       
                                    Console.CursorLeft = 98;
                                    Console.Write("DISPLAY ALL CONTACTS", Console.CursorLeft);
                                    Console.Write("\n");
                                    Console.CursorLeft = 70;
                                    Console.WriteLine("____________________________________________________________________________");
                                    Console.Write("\n");
                                    Person.PrintPerson();
                                    Console.Write("\n");
                                    Console.WriteLine();
                                    Console.CursorLeft = 70;
                                    Console.WriteLine("____________________________________________________________________________");
                                    Console.CursorLeft = 70;
                                    Console.Write("Press any key to Main menu..");
                                    Console.ReadKey();
                                    Console.Clear();
                                    goto Main_Menu;
                    }
                            case 6:
                                {
                                    Console.Write("\n\n\n\n");
                                    Console.Write("\n");
                                    Console.CursorLeft = 70;
                                    Console.WriteLine("_______________________________________________________________________");
                                    Console.Write("\n");
                                    Console.CursorLeft = 87;
                                    Console.WriteLine("THANK YOU FOR USING APPLICATION..!!!");
                                    
                                    Console.CursorLeft = 70;
                                    Console.WriteLine("_______________________________________________________________________");
                                    Console.Write("\n\n");
                                }
                            break;
                                
                            default:
                                Console.Write("\n\n\n\n");
                                Console.CursorLeft = 87;
                                Console.WriteLine("Please enter valid option", Console.CursorLeft);
                                Console.Write("\n");
                                Console.CursorLeft = 87;
                                Console.Write("Press any key to Main menu...", Console.CursorLeft);
                                Console.ReadKey();
                                Console.Clear();
                                goto Main_Menu;
                                
                        }

        }
    }
}