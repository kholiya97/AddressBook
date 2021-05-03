using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================Welcome to Address Book System======================================");
            AddPersonDetails personDetailsOBJ = new AddPersonDetails(); // created object of class  AddPersonDetails
            personDetailsOBJ.CreateMultipleUniqueAddressBook(); // call method CreateMultipleUniqueAddressBook with the help of object personDetailsOBJ


            /*

                        InterfaceDetails details = new AddPersonDetails(); // used concept of polymorphism 1 class having different forms
                        bool check = true;
                        while (check == true)
                        {
                            Console.WriteLine("=============================Welcome ToAddress Book Program==========================");
                            Console.WriteLine("==========Please Enter Your Choice==========");
                            Console.WriteLine("1. Add Details");
                            Console.WriteLine("2. Display Details");
                            Console.WriteLine("3. Edit Details");
                            Console.WriteLine("4. Delete Details");
                            Console.WriteLine("5. Exit");
                            Console.WriteLine("=============================================");


                            string choice = Console.ReadLine();
                            int ch = Convert.ToInt32(choice);

                            switch (ch)
                            {
                                case 1:
                                    details.AddDetails();
                                    break;
                                case 2:
                                    details.Display();
                                    break;
                                case 3:
                                    Console.WriteLine("Please Enter First Name : ");
                                    string name = Console.ReadLine();
                                    details.Edit(name);
                                    break;
                                case 4:
                                    Console.WriteLine("Please Enter First Name : ");
                                    string nameForDeletion = Console.ReadLine();
                                    details.Delete(nameForDeletion);
                                    break;
                                case 5:
                                    return;
                            }
                        }

                        */

        }
    }

    /// <summary>
    /// Inheriting InterfaceDetails into AddPersonDetails
    /// </summary>
    public class AddPersonDetails : InterfaceDetails // implement interface for data abstraction
    {
        //List is used to store contacts details
        private readonly List<Contacts> list = new List<Contacts>(); // cannot update only to view the contact list

        Dictionary<string, AddPersonDetails> dictionary = new Dictionary<string, AddPersonDetails>(); //  to save person details in  for  of string , object 

        private Contacts person = null; // defined null class 



        public void CreateMultipleUniqueAddressBook()
        {
            while (true)
            {
                Console.WriteLine("Please enter your Choice.......");
                Console.WriteLine("1.Add Address Book");
                Console.WriteLine("2.Use Existing Address Book");
                Console.WriteLine("3.Exit");

                String choice = Console.ReadLine();
                int choice1 = Convert.ToInt32(choice);
                switch (choice1) // only read integer value 
                {
                    case 1:
                        Console.WriteLine("Please Enter The Name Of Your Address Book : ");
                        string name = Console.ReadLine();
                        if (dictionary.ContainsKey(name)) // checking if key exixt in add book.
                        {
                            Console.WriteLine("Address Book Already exists!!!");
                        }
                        else
                        {
                            AddPersonDetails addressBook = new AddPersonDetails(); // it will add new addressbokk
                            dictionary.Add(name, addressBook);
                            Console.WriteLine("Your Address Book is Created.");
                            addressBook.Menu(); // calling menu method
                        }
                        break;
                    case 2:
                        Console.WriteLine("Please enter Address book name : ");
                        string addressBookName = Console.ReadLine();
                        if (dictionary.ContainsKey(addressBookName)) //checking if dictionary exixt in add book.
                        {
                            dictionary[addressBookName].Menu(); // if exixts call menu method
                        }
                        else
                        {
                            Console.WriteLine("Address book does not exists!!!");
                        }
                        break;
                    case 3:
                        return; // method terminate
                }
            }
        }

        /// <summary>
        /// AddressBook Menu to show multiple choice
        /// </summary>
        public void Menu()
        {
            InterfaceDetails addressBookDetails = new AddPersonDetails(); // used concept of polymorphism 1 class having different forms // created object of InterfaceDetails using interface detail
            bool check = true; // variable check by default value true
            while (check == true)
            {
                Console.WriteLine("*************PLEASE SELECT YOUR CHOICE**************");
                Console.WriteLine("1. Add Details");
                Console.WriteLine("2. Display Details");
                Console.WriteLine("3. Edit Details");
                Console.WriteLine("4. Delete Details");
                Console.WriteLine("5. Search Person in the State or City");
                Console.WriteLine("6. Exit");

                string choice = Console.ReadLine();
                int ch = Convert.ToInt32(choice);

                switch (ch)
                {
                    case 1:
                        addressBookDetails.AddDetails();
                        break;
                    case 2:
                        addressBookDetails.Display();
                        break;
                    case 3:
                        Console.WriteLine("Please Enter Your First Name : ");
                        string firstName = Console.ReadLine();
                        addressBookDetails.Edit(firstName);
                        break;
                    case 4:
                        Console.WriteLine("Please Enter Your First Name : ");
                        string firstname = Console.ReadLine();
                        addressBookDetails.Delete(firstname);
                        break;
                    case 5:
                        addressBookDetails.SearchPersonInStateOrCity();
                        break;
                    case 6:
                        return;
                }
            }
        }



        /// <summary>
        /// Adding details like first name,last name,address , pincode etc.
        /// </summary>
        public void AddDetails()
        {
            Console.WriteLine("Please enter your first name : ");
            string firstName = Console.ReadLine();
            if (!Regex.Match(firstName, "^[A-Z][a-z]{2,}$").Success)
                Console.WriteLine("Please enter first letter in Capital!!");
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    Console.WriteLine("You have entered a duplicate name!!");
                }
            }

            Console.WriteLine("Please enter your last name : ");
            string lastName = Console.ReadLine();
            if (!Regex.Match(lastName, "^[A-Z][a-z]{2,}$").Success)
                Console.WriteLine("Please enter first letter in Capital!!");

            //Check for duplicate name
            foreach (Contacts addressBook in list.FindAll(name => name.LastName.Equals(lastName))) // using lambda function to check the dublicate of last name
            {
                Console.WriteLine("You have entered a duplicate name!!");
                return;
            }

            Console.WriteLine("Please enter your address : ");
            string address = Console.ReadLine();

            Console.WriteLine("Please enter your city : ");
            string city = Console.ReadLine();

            Console.WriteLine("Please enter your state : ");
            string state = Console.ReadLine();

            Console.WriteLine("Please enter your Pin Code : ");
            int zipCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your Mobile number : ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Please enter your email id : ");
            string emailID = Console.ReadLine();
            if (!Regex.Match(emailID, "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+[.]+([a-zA-Z]{2,4})+[.]*([a-zA-Z]{2})*$").Success)
                Console.WriteLine("You have entered invalid email id.\n");

            Console.WriteLine("Your entered details are added Successfully!!!");

            this.person = new Contacts(firstName, lastName, address, city, state, zipCode, phoneNumber, emailID);
            this.list.Add(this.person);
        }

        /// <summary>
        /// To display all the contacts from list.
        /// </summary>
        public void Display()
        {
            foreach (Contacts biodata in this.list)
            {
                Console.WriteLine(biodata);
            }
            if (list.Count == 0)
            {
                Console.WriteLine("There is no records in address book.");
            }
        }

        /// <summary>
        /// This method is used to edit person's details using their first name
        /// </summary>
        /// <param name="firstName"></param>
        public void Edit(string firstName)
        {
            int check = 0;
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    while (check == 0)
                    {
                        Contacts addressBook = this.list[i];
                        Console.WriteLine(addressBook);
                        Console.WriteLine("Enter your choice for editing: ");
                        Console.WriteLine("1.Address 2.City 3.State 4.Zip Code 5.Phone Number 6.Email ID 7.Exit");
                        string choice = Console.ReadLine();
                        int ch = Convert.ToInt32(choice);
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("Please enter new address : ");
                                string address = Console.ReadLine();
                                addressBook.Address = address;
                                break;
                            case 2:
                                Console.WriteLine("Please enter new city : ");
                                string city = Console.ReadLine();
                                addressBook.City = city;
                                break;
                            case 3:
                                Console.WriteLine("Please enter new state : ");
                                string state = Console.ReadLine();
                                addressBook.State = state;
                                break;

                            case 4:
                                Console.WriteLine("Please enter new zip code : ");
                                int zipCode = Convert.ToInt32(Console.ReadLine());
                                addressBook.ZipCode = zipCode;
                                break;

                            case 5:
                                Console.WriteLine("Please enter new mobile number : ");
                                long phoneNumber = Convert.ToInt64(Console.ReadLine());
                                addressBook.MobileNumber = phoneNumber;
                                break;

                            case 6:
                                Console.WriteLine("Please enter new email id  : ");
                                string emailID = Console.ReadLine();
                                addressBook.EmailID = emailID;
                                break;

                            case 7:
                                check = 1;
                                break;
                        }
                    }
                }
            }
        }




        /// <summary>
        /// delete() method is used to delete records from address book using their first name.
        /// </summary>
        /// <param name="firstName"></param>
        public void Delete(string firstName)
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    this.list[i] = null;
                }
            }
            Console.WriteLine("You have deleted record successfully!!!");
        }

        /// <summary>
        /// Search a person by city or state
        /// </summary>
        public void SearchPersonInStateOrCity()
        {
            Console.WriteLine("Please Enter Your Choice Which You Want To search...");
            Console.WriteLine("1. State 2. City");
            string option = Console.ReadLine();
            int select = Convert.ToInt32(option);
            switch (select)
            {
                case 1:
                    Console.WriteLine("Please Enter Your First Name : ");
                    String nameToSearchInState = Console.ReadLine();
                    foreach (Contacts addressBook in list.FindAll(e => e.FirstName == nameToSearchInState)) // lambda expression used to search first name in the list using the user input nameToSearchInState
                    {
                        Console.WriteLine("State of " + nameToSearchInState + " is : " + addressBook.State + "\n");
                    }
                    break;
                case 2:
                    Console.WriteLine("Please Enter Your First Name : ");
                    string searchFirstNameInStateOrCity = Console.ReadLine();
                    foreach (Contacts addressBook in list.FindAll(e => e.FirstName == searchFirstNameInStateOrCity)) lambda expression used to search first name in the list using the user input searchFirstNameInStateOrCity
                    {
                        Console.WriteLine("City of " + searchFirstNameInStateOrCity + " is : " + addressBook.City + "\n");
                    }
                    break;
            }

        }

    }
    public interface InterfaceDetails
    {
        public void AddDetails();

        public void Display();

        public void Edit(string firstName);

        public void Delete(string firstName);

        public void SearchPersonInStateOrCity();
    }

    /// <summary>
    /// Variables declarations
    /// </summary>
    public class Contacts
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private int zipCode;
        private long mobileNumber;
        private string emailID;


        /// <summary>
        /// Passing value through constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zipCode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="emailID"></param>
        public Contacts(string firstName, string lastName, string address, string city, string state, int zipCode, long mobileNumber, string emailID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.ZipCode = zipCode;
            this.mobileNumber = mobileNumber;
            this.emailID = emailID;
        }

        /// <summary>
        /// Using lmbda expression to get and set values
        /// </summary>
        public string FirstName { get => this.firstName; set => this.firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public string Address { get => this.address; set => this.address = value; }
        public string City { get => this.city; set => this.city = value; }
        public string State { get => this.state; set => this.state = value; }
        public int ZipCode { get => this.zipCode; set => this.zipCode = value; }
        public long MobileNumber { get => this.mobileNumber; set => this.mobileNumber = value; }
        public string EmailID { get => this.emailID; set => this.emailID = value; }



        /// <summary>
        /// toString method is used to read object into string format.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return

            "/***********************************************/"
                 + "\n   FirstName    : " + this.firstName
                 + "\n  LastName     : " + this.lastName
                 + "\n  Address      : " + this.address
                 + "\n  City         : " + this.city
                 + "\n  State        : " + this.state
                 + "\n  ZipCode      : " + this.zipCode
                 + "\n  MobileNumber : " + this.mobileNumber
                 + "\n  EmailID      : " + this.emailID + "\n" +
                 "/*********************************************/";
        }
    }
}





