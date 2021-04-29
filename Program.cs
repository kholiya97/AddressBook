using System;

namespace Address_Book_System
{   
    class Person
    {
        private String lname, address, city, state, phone, zip, email; //Declaring (Creating) Variables
        public Person(String fname, String lname, String address, String city, String state, String phone, String zip, string email)
        {                                                   //constructor
            this.FirstName = fname;
            this.LastName = lname;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.PhoneNo = phone;
            this.ZipCode = zip;
            this.email = email;
        }

        public string FirstName { get; set; }         // get method returns the value of the variable FirstName.
                                                      // set method assigns a value to the name variable.
        public string LastName { get => lname; set => lname = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string PhoneNo { get => phone; set => phone = value; }
        public string ZipCode { get => zip; set => zip = value; }
        public string Email { get => email; set => email = value; }
        public override string ToString() //Tostring  method store value
        {
            return "FirstName:- " + FirstName + "\nLastName:- " + LastName + " \nAddress:- " + Address + " \nCity:- " + City
                 + "\nState:- " + State + "\nZipCode:- " + ZipCode + "\nPhoneNo:- " + PhoneNo + "\nEmail:- " + email + " " + "\n";
        }
         static void Main(string[]args)
        {
namespace Addres
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
        private Dictionary<string, Person> addressBook = new Dictionary<string, Person>(); //create addressBook Dictionary and string is (Key)(string=datatype) and person is (value)

        //method of interface
        public void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber)// addcontact method implemented from interface IPERSON
        public void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber)//addcontact method implemented from interface IPERSON

        {
            Person contact = new Person(); // creating object of person class
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.Address = address;
            contact.City = city;
            contact.State = state;
            contact.Email = email;
            int Zip = zip;
            contact.PhoneNumber = phoneNumber;
            addressBook.Add(contact.FirstName, contact);
        }
        public void ViewContact()
        {
            //all Tvalues in dictionary access by KeyValuePair Class
            foreach (KeyValuePair<string, Person> item in addressBook) //print all values using foreach  in addressBook Dictionary
            {
                Console.WriteLine("First Name : " + item.Value.FirstName);
                Console.WriteLine("Last Name : " + item.Value.LastName);
                Console.WriteLine("Address : " + item.Value.Address);
                Console.WriteLine("City : " + item.Value.City);
                Console.WriteLine("State : " + item.Value.State);
                Console.WriteLine("Email : " + item.Value.Email);
                Console.WriteLine("Zip : " + item.Value.Zip);
                Console.WriteLine("Phone Number : " + item.Value.PhoneNumber + "\n");

            }
        }
      
        public void EditContact(string name) //method in inteface pass argument name
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
        public void DeleteContact(string name)
        {
            Console.WriteLine("Enter firstName of the user you want to remove");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter lastname of the user you want to remove");
            string lastName = Console.ReadLine();

            adressBookList.RemoveAll(item => item.FirstName == firstName && item.LastName == lastName);

            if (addressBook.ContainsKey(name))
            {
                addressBook.Remove(name);
                Console.WriteLine("\nDeleted Succesfully.\n");
            }
            else
            {
                Console.WriteLine("\nIt Is Not Found.\n");
            }
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
        //creating properties 

    public class Person
    {
        public string FirstName { get; set; } // getters and seeters for 1st name and likewise for others 
        public string FirstName { get; set; } // getters and seters for 1st name and likewise for others 
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Welcome to Address Book Program------------ ");
            AddressBook addressBook = new AddressBook(); //object of AddessBook class
            bool ProgramIsRunning = true;
            while (ProgramIsRunning)

            Console.WriteLine("Enter First Name :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address :");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City :");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State :");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Email :");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Zip :");
            int zip = Convert.ToInt32(Console.ReadLine());//conver into int using ToInt32()
            Console.WriteLine("Enter Phone Number :");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            addressBook.AddContact(firstName, lastName, address, city, state, email, zip, phoneNumber);
            addressBook.ViewContact();//calling method
            addressBook.EditContact(firstName);
            addressBook.ViewContact();//calling method
            Console.Read();

            int Choice = Convert.ToInt32(Console.ReadLine());
            do

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
            } while (Choice != 4);

    class Contacts
    {
        static void Main(string[] args)  //Main method
        {
            Console.WriteLine("******* Welcome To AddressBook *******");

            Console.Write("Enter First Name:- ");  // Take input 
            string firstName = Console.ReadLine(); //Store input in firstName variable
            Console.Write("Enter Last Name:- ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Address:- ");
            string address = Console.ReadLine();
            Console.Write("Enter City:- ");
            string city = Console.ReadLine();
            Console.Write("Enter State:- ");
            string state = Console.ReadLine();
            Console.Write("Enter Zip Code :- ");
            string zip = Console.ReadLine();
            Console.Write("Enter Phone Number:- ");
            string pNumber = Console.ReadLine();
            Console.Write("Enter Email:- ");
            string Email = Console.ReadLine();
            Person person = new Person(firstName, lastName, address, city, state, pNumber,zip, Email);
            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}

