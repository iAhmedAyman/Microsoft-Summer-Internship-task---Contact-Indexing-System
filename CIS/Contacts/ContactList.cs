using CIS.Interfaces;

namespace CIS.Contacts
{
    class ContactList : IContactContainer{
        private LinkedList<Contact> contacts { get; set; }

        public ContactList()
        {
            contacts = new LinkedList<Contact>();
        }

        public LinkedListNode<Contact> Add(Contact contact)
        {
            return contacts.AddLast(contact);
        }

        public void Remove(LinkedListNode<Contact> contactNode)
        {
            contacts.Remove(contactNode);
        }

        public LinkedList<Contact> GetContacts()
        {
            return contacts;
        }

        public void SetContacts(LinkedList<Contact> contacts)
        {
            this.contacts = contacts;
        }
    }
}