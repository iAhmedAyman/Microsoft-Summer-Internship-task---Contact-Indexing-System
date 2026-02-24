using CIS.Contacts;
using CIS.Controller;
using System;
using System.Collections.Generic;

namespace CIS.UI
{
    class CLIMainMenu
    {
        private ConcreteContactService contactService;

        public CLIMainMenu(ConcreteContactService contactService)
        {
            this.contactService = contactService;
        }

        public void Main()
        {
            bool running = true;

            while (running)
            {
                PrintMenu();
                Console.Write("Select an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddContactMenu();
                        break;
                    case "2":
                        RemoveContactMenu();
                        break;
                    case "3":
                        UpdateContactMenu();
                        break;
                    case "4":
                        ViewContactMenu();
                        break;
                    case "5":
                        ListAllContacts();
                        break;
                    case "6":
                        SearchContactMenu();
                        break;
                    case "7":
                        SaveContactsMenu();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("=== Contact Manager ===");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Remove Contact");
            Console.WriteLine("3. Update Contact");
            Console.WriteLine("4. View Contact");
            Console.WriteLine("5. List All Contacts");
            Console.WriteLine("6. Search Contact");
            Console.WriteLine("7. Save Contacts");
            Console.WriteLine("0. Exit");
        }

        private void AddContactMenu()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Contact newContact = new Contact
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Phone = phone,
                Email = email,
                CreationDate = DateTime.Now
            };

            contactService.Add(newContact);
            Console.WriteLine("Contact added successfully!");
        }

        private void RemoveContactMenu()
        {
            Console.WriteLine("Remove by: 1-Id, 2-Name, 3-Phone, 4-Email");
            string option = Console.ReadLine();
            DATA_FIELD field = GetFieldFromOption(option);

            Console.Write("Enter value: ");
            string value = Console.ReadLine();

            contactService.Remove(field, value);
            Console.WriteLine("Contact(s) removed successfully!");
        }

        private void UpdateContactMenu()
        {
            Console.WriteLine("Update by: 1-Id, 2-Name, 3-Phone, 4-Email");
            string option = Console.ReadLine();
            DATA_FIELD field = GetFieldFromOption(option);

            Console.Write("Enter old value: ");
            string oldValue = Console.ReadLine();

            Console.Write("Enter new Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter new Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Enter new Email: ");
            string email = Console.ReadLine();

            Contact updatedContact = new Contact
            {
                Name = name,
                Phone = phone,
                Email = email
            };

            contactService.Update(field, oldValue, updatedContact);
            Console.WriteLine("Contact updated successfully!");
        }

        private void ViewContactMenu()
        {
            Console.WriteLine("View by: 1-Id, 2-Name, 3-Phone, 4-Email");
            string option = Console.ReadLine();
            DATA_FIELD field = GetFieldFromOption(option);

            Console.Write("Enter value: ");
            string value = Console.ReadLine();

            var nodes = contactService.ViewContact(field, value);
            PrintContactNodes(nodes);
        }

        private void ListAllContacts()
        {
            var contacts = contactService.GetAllContacts();
            foreach (var c in contacts)
            {
                Console.WriteLine($"{c.Id} | {c.Name} | {c.Phone} | {c.Email} | {c.CreationDate}");
            }
        }

        private void SearchContactMenu()
        {
            Console.WriteLine("Search by: 1-Id, 2-Name, 3-Phone, 4-Email");
            string option = Console.ReadLine();
            DATA_FIELD field = GetFieldFromOption(option);

            Console.Write("Enter value: ");
            string value = Console.ReadLine();

            var nodes = contactService.Search(field, value);
            PrintContactNodes(nodes);
        }

        private void SaveContactsMenu()
        {
            Console.Write("Enter file path to save: ");
            string path = Console.ReadLine();
            contactService.SaveData(path);
            Console.WriteLine("Contacts saved successfully!");
        }

        private void PrintContactNodes(LinkedList<LinkedListNode<Contact>> nodes)
        {
            foreach (var node in nodes)
            {
                var c = node.Value;
                Console.WriteLine($"{c.Id} | {c.Name} | {c.Phone} | {c.Email} | {c.CreationDate}");
            }
        }

        private DATA_FIELD GetFieldFromOption(string option)
        {
            return option switch
            {
                "1" => DATA_FIELD.ID,
                "2" => DATA_FIELD.NAME,
                "3" => DATA_FIELD.PHONE,
                "4" => DATA_FIELD.EMAIL,
                _ => throw new Exception("Invalid field")
            };
        }
    }
}