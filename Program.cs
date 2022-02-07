using AddressBook_Using_Collexction;
using System;

       //uc-1 creating a contact
Console.WriteLine("Welcome to Address Book using Collection");
       //uc-2 adding of first and last names, address,city, state, zip, phone number and email...
AddressBookCollection.AddContact();
Console.WriteLine("\n");
AddressBookCollection.ContactsDisplay();
Console.WriteLine("\n");
       //Uc- edit existing contact person using their name
AddressBookCollection.EditContact();
Console.WriteLine("\n");
AddressBookCollection.ContactsDisplay();
Console.WriteLine("\n");
       //uc-4 delete a person using person's name 
AddressBookCollection.DeleteContact();
Console.WriteLine("\n");
AddressBookCollection.ContactsDisplay();
