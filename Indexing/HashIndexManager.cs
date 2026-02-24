using CIS.Contacts;

namespace CIS.Indexing {
    class HashIndexManager : IndexManager {
        private HashContactIndex<string> idIndex;
        private HashContactIndex<string> nameIndex;
        private HashContactIndex<string> phoneIndex;
        private HashContactIndex<string> emailIndex;

        public HashIndexManager()
        {
            idIndex = new HashContactIndex<string>(c => c.ID);
            nameIndex = new HashContactIndex<string>(c => c.Name);
            phoneIndex = new HashContactIndex<string>(c => c.PhoneNumber);
            emailIndex = new HashContactIndex<string>(c => c.Email);
        }

        public LinkedList<LinkedListNode<Contact>> GetContacts(DATA_FIELD field, string value)
        {
            switch (field)
            {
                case DATA_FIELD.ID:
                    return idIndex.GetContacts(value);
                case DATA_FIELD.NAME:
                    return nameIndex.GetContacts(value);
                case DATA_FIELD.PHONE:
                    return phoneIndex.GetContacts(value);
                case DATA_FIELD.EMAIL:
                    return emailIndex.GetContacts(value);
                default:
                    throw new ArgumentException("Invalid data field");
            }
        }

        public void Add(LinkedListNode<Contact> contactNode)
        {
            idIndex.Add(contactNode);
            nameIndex.Add(contactNode);
            phoneIndex.Add(contactNode);
            emailIndex.Add(contactNode);
        }

        public void Remove(LinkedListNode<Contact> contactNode)
        {
            idIndex.Remove(contactNode);
            nameIndex.Remove(contactNode);
            phoneIndex.Remove(contactNode);
            emailIndex.Remove(contactNode);
        }

    }
}