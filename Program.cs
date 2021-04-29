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
            foreach (KeyValuePair<string, Person> item in addressBook) //use loop foreach
            {
                if (item.Key.Equals(name))
                {

                    Console.WriteLine("Choose What to Edit \n 1. FirstName\n2. LastName\n3. Address\n4. city\n5. State\n6. Email\n7. Zip \n8. PhoneNumber\n");

                    int choice = Convert.ToInt32(Console.ReadLine()); //convert string and store choice
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter First Name :"); //take input
                            item.Value.FirstName = Console.ReadLine(); //store firstName string in iten.value
                            break;
                        case 2:
                            Console.WriteLine("Enter Last Name :");//take input
                            item.Value.LastName = Console.ReadLine();//store last name in value
                            break;
                        case 3:
                            Console.WriteLine("Enter Address :");
                            item.Value.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter City :");
                            item.Value.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter State :");
                            item.Value.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter Email :");
                            item.Value.Email = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter Zip :");
                            item.Value.Zip = Convert.ToInt32(Console.ReadLine()); //convert string into int and store it
                            break;
                        case 8:
                            Console.WriteLine("Enter Phone Number :");
                            item.Value.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
            }
        }
      
        public void DeleteContact(string name)
        {
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
        void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber);
        void EditContact(string name);
        void DeleteContact(string name);
        // void ViewContact();
    }
  
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


                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Enter First Name Of Contact To Edit :");
                        string nameToEdit = Console.ReadLine();
                        addressBook.EditContact(nameToEdit);
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name Of Contact To Delete :");
                        string nameToDelete = Console.ReadLine();
                        addressBook.DeleteContact(nameToDelete);
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name Of Contact To View :");
                        string nameToView = Console.ReadLine();
                        addressBook.ViewContact();
                        break;

                    case 4:
                        Console.WriteLine("It is Not Found Any Information.");
                        break;
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

