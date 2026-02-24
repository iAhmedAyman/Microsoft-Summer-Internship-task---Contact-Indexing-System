namespace CIS.Contacts
{
    class ContactList : IContactContainer{
        private LinkedList<Contact> contacts { get; set; }

        public ContactList()
        {
            contacts = new LinkedList<Contact>();
        }

        public void Add(Contact contact)
        {
            contacts.AddLast(contact);
        }

        public void Remove(Contact contact)
        {
            contacts.Remove(contact);
        }

        public LinkedList<Contact> GetAllContacts()
        {
            return contacts;
        }
    }
}