using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


