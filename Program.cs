using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{

    class AddressBook : IPerson
    {
        List<Person> adressBookList = new List<Person>(); //creating list
        public void addPerson()
        {
            Console.WriteLine("Enter firstName:");//take input  user
            string firstName = Console.ReadLine();//store input firstname variable

            Console.WriteLine("Enter lastName:");//take input  user
            string lastName = Console.ReadLine();//store input lastname variable

            Console.WriteLine("Enter city:");//take input  user
            string city = Console.ReadLine();//store input city variable

            Console.WriteLine("Enter state:");//take input  user
            string state = Console.ReadLine();//store input state variable

            Console.WriteLine("Enter email:");//take input  user
            string email = Console.ReadLine();//store input email variable

            Console.WriteLine("Enter phoneNumber:");//take input  user
            string phoneNumber = Console.ReadLine();//store input phonenumber variable


            Person person = new Person(firstName, lastName, city, state, email, phoneNumber);
            adressBookList.Add(person);   //adding list data person
        }

        public void displayPerson()//body of displayperson interface method
        {
            Console.WriteLine("\nEntered Person Details is:");
            foreach (var person in adressBookList)
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}", person.FirstName, person.LastName, person.City, person.State, person.Email, person.PhoneNumber);
            }

        }
        public void editPerson()//body of editperson interface method
        {

            Console.WriteLine("\n enter First name to edit details:");//take input
            string name = Console.ReadLine();//store input name variable
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
                    int choice = Convert.ToInt32(Console.ReadLine()); //converting into int with the help of ToInt32()

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
                else
                    Console.WriteLine("Person is not registered");
            }
        }

        public void deletePerson()//body of deleteperson interface method
        {

            Console.WriteLine("Enter firstName of the user you want to remove");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter lastname of the user you want to remove");
            string lastName = Console.ReadLine();

            adressBookList.RemoveAll(item => item.FirstName == firstName && item.LastName == lastName);


        }
    }
    interface IPerson
    {
        void addPerson();
        void displayPerson();
        void editPerson();
        void deletePerson();
    }

    public class Person
    {

        public string FirstName;
        public string LastName;
        public string City;
        public string State;
        public string Email;
        public string PhoneNumber;
        //parameterized constructor for initializing instance member
        public Person(string firstName, string lastName, string city, string state, string email, string phoneNumber)//Parameterized Constructor
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            State = state;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public String getFirstName() /// get method returns the value of the variable FirstName.
		{
            return FirstName;
        }

        public void setFirstName(String firstName)  // set method assigns a value to the name variable.
        {
            FirstName = firstName;
        }

        public String getLastName() //get method returns the value of the variable LastName.
        {
            return LastName;
        }

        public void setLastName(String lastName) //set method assigns a value to the name variable.
        {
           LastName = lastName;
        }

        public String getCity()
        {
            return City;
        }

        public void setCity(String city)
        {
            City = city;
        }

        public String getState()
        {
            return State;
        }

        public void setState(String state)
        {
            State = state;
        }
        public String getPhoneNumber()
        {
            return PhoneNumber;
        }

        public void setPhoneNumber(String phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public String getEmail()
        {
            return Email;
        }

        public void setEmail(String email)
        {
            Email = email;
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("-------------Welcome to Address Book Program------------ ");
            AddressBook addressBook = new AddressBook(); //object of AddessBook class

            bool ProgramIsRunning = true;
            while (ProgramIsRunning)
            {
                Console.WriteLine("Choose one of the following options: ");
                Console.WriteLine("#1 Add new user");
                Console.WriteLine("#2 Display user information");
                Console.WriteLine("#3 Edit user information");
                Console.WriteLine("#4 Delete existing user");
                Console.WriteLine("#5 Exit");
                int num = Convert.ToInt32(Console.ReadLine());//convert into int with the help of ToInt32()

                switch (num)//using switch case
                {
                    case 1:
                        addressBook.addPerson();
                        break;
                    case 2:
                        addressBook.displayPerson();
                        break;
                    case 3:
                        addressBook.editPerson();
                        break;
                    case 4:
                        addressBook.deletePerson();
                        break;
                    case 5:
                        ProgramIsRunning = false;
                        break;
                }//end switch case
            }
        }
    }
}






