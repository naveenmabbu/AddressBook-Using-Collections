using AddressBook_Using_Collexction;
using System;

namespace Address_Book_Using_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //uc-1 adding of first and last names, address,city, state, zip, phone number and email...
            Console.WriteLine("Welcome to Address Book using Collection");
            AddressBookCollection.AddContact();
            AddressBookCollection.ContactsDisplay();
        }
    }
}