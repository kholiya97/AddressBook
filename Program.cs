using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{

    class AddressBook : IPerson
    {
        List<Person> adressBookList = new List<Person>();

        public void AddContact(string firstName, string lastName, string address, string city, string state, string phoneNumber, string email)
        {
            Person person = new Person(firstName, lastName, city, state, email, phoneNumber);
            adressBookList.Add(person);
        }
        public void displayPerson()
        {
            Console.WriteLine("\nEntered Person Details is:");
            foreach (var person in adressBookList)
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}", person.FirstName, person.LastName, person.city, person.state, person.email, person.phoneNumber);
            }
        }
        public void editPerson()
        {
            Console.WriteLine("\n enter First name to edit details:");
            string name = Console.ReadLine();
            foreach (var person in adressBookList)
            {
                if (name.Equals(person.FirstName))
                {
                    Console.WriteLine("Choose one of the following options: ");
                    Console.WriteLine("#1 Phone Number");
                    Console.WriteLine("#2 Email");
                    Console.WriteLine("#3 City");
                    Console.WriteLine("#4 State");
                    Console.WriteLine("#5 Quit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("enter new Mobile number:");
                            string mobileNo = Console.ReadLine();
                            person.setPhoneNumber(mobileNo);
                            Console.WriteLine("mobile no. is updated\n");
                            break;
                        case 2:
                            Console.WriteLine("enter new Email-id:");
                            String email = Console.ReadLine();
                            person.setEmail(email);
                            Console.WriteLine("Email-id is updated\n");
                            break;
                        case 3:
                            Console.WriteLine("enter your city");
                            String city = Console.ReadLine();
                            person.setCity(city);
                            break;
                        case 4:
                            Console.WriteLine("enter your state");
                            String state = Console.ReadLine();
                            person.setState(state);
                            person.setState(state);
                            Console.WriteLine("Address is updated\n");
                            break;
                        default:
                            Console.WriteLine("please enter right choice");
                            break;
                    }
                }
            }
        }

        public void deletePerson()
        {
            Console.WriteLine("Enter firstName of the user you want to remove");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter lastname of the user you want to remove");
            var lastName = Console.ReadLine();
            adressBookList.RemoveAll(item => item.FirstName == firstName && item.LastName == lastName);
        }
    }

    /// <summary>
    /// signature of interface
    /// </summary>
    public interface IPerson
    {
        // void addPerson();
        void displayPerson();
        void editPerson();
        void deletePerson();
    }

    public class Person
    {
        //instance variable
        public string FirstName;
        public string LastName;
        public string city;
        public string state;
        public string email;
        public string phoneNumber;

        //parameterized constructor for initializing instance member
        public Person(string firstName, string lastName, string city, string state, string email, string phoneNumber)//Parameterized Constructor
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.city = city;
            this.state = state;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }
        public String getFirstName() /// get method returns the value of the variable FirstName.
		{
            return FirstName;
        }

        public void setFirstName(String firstName)  // set method assigns a value to the name variable.
        {
            this.FirstName = firstName;
        }

        public String getLastName() //get method returns the value of the variable LastName.
        {
            return LastName;
        }

        public void setLastName(String lastName) //set method assigns a value to the name variable.
        {
            this.LastName = lastName;
        }

        public String getCity()//get method returns the value of the variable city.
        {
            return city;
        }

        public void setCity(String city)//get method returns the value of the variable city.
        {
            this.city = city;
        }

        public String getState()
        {
            return state;
        }

        public void setState(String state)
        {
            this.state = state;
        }
        public String getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setPhoneNumber(String phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;

        }
        class Program
        {
            /// <summary>
            /// Entry ponit
            /// </summary>
            /// <param name="args"></param>
            public static void Main(string[] args)
            {
                Console.WriteLine("Welcome in Address book System");

                ///create dictionary and 
                ///Dict is name of dictionary
                Dictionary<string, AddressBook> Dict = new Dictionary<string, AddressBook>();//string is Tkey and AddressBook is TValue.
                bool ProgramIsRunning = true;

                Console.WriteLine("\nHow many address Book you want to create : ");
                int numAddressBooks = Convert.ToInt32(Console.ReadLine()); //store and convert into int using numAdressBooks variable.

                for (int i = 1; i <= numAddressBooks; i++)
                {
                    Console.WriteLine("Enter the name of address book " + i + ": ");
                    string bookName = Console.ReadLine();
                    AddressBook addressBook = new AddressBook(); //creating object of AddressBook class
                    Dict.Add(bookName, addressBook); //add element in dictionary
                }
                Console.WriteLine("\nYou have created following Address Books : ");
                foreach (var item in Dict) //var is used and it is store any data type value.
                {
                    Console.WriteLine("{0}", item.Key);
                }
                while (ProgramIsRunning)
                {
                    Console.WriteLine("\nChoose option to procced further \n1.Add Contact \n2.Edit Contact \n3.Delete Contact  \n4.Display Contacts \n5.Exit");
                    int choice = Convert.ToInt32(Console.ReadLine()); ///store and convert into int using choice variable
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\nEnter Existing Address Book Name for adding contacts");
                            string contactName = Console.ReadLine();
                            if (Dict.ContainsKey(contactName))
                            {
                                Console.WriteLine("\nEnter the number of contacts you want to add in address book");
                                int numberOfContacts = Convert.ToInt32(Console.ReadLine());
                                for (int i = 1; i <= numberOfContacts; i++)
                                {
                                    addContactBook(Dict[contactName]);
                                }
                                Dict[contactName].displayPerson();
                            }
                            else
                            {
                                Console.WriteLine("No AddressBook exist with name {0}", contactName);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter Address Book Name for edit contact");
                            string editcontactName = Console.ReadLine();
                            if (Dict.ContainsKey(editcontactName))
                            {
                                Dict[editcontactName].editPerson();
                                Dict[editcontactName].displayPerson();
                            }
                            else
                            {
                                Console.WriteLine("No Address book exist with name {0} ", editcontactName);
                            }
                            break;
                        case 3:
                            Console.WriteLine("\nEnter Address Book Name for delete contact");
                            string deleteContact = Console.ReadLine();
                            if (Dict.ContainsKey(deleteContact))
                            {
                                Dict[deleteContact].deletePerson();
                                Dict[deleteContact].displayPerson();
                            }
                            else
                            {
                                Console.WriteLine("No Address book exist with name {0} ", deleteContact);
                            }
                            break;
                        case 4:
                            Console.WriteLine("\nEnter Address Book Name for display contacts");
                            string displayContactsInAddressBook = Console.ReadLine();
                            Dict[displayContactsInAddressBook].displayPerson();
                            break;
                        case 5:
                            ProgramIsRunning = false;
                            break;
                        default:
                            Console.WriteLine("Please enter valid option");
                            break;
                    }
                }

                void addContactBook(AddressBook addressBook)
                {
                    Console.WriteLine("Enter First Name : ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name : ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter Address : ");
                    string address = Console.ReadLine();
                    Console.WriteLine("Enter City : ");
                    string city = Console.ReadLine();
                    Console.WriteLine("Enter State : ");
                    string state = Console.ReadLine();
                    Console.WriteLine("Enter Phone Number : ");
                    string phoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter Email id :");
                    string email = Console.ReadLine();
                    addressBook.AddContact(firstName, lastName, address, city, state, phoneNumber, email);
                }

            }
        }
    }
}

