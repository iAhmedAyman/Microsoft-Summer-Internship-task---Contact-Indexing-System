using CIS.Contacts;

namespace CIS.Indexing {
    class HashContactIndex<k> : IContactIndex {
        private Dictionary<k, LinkedList<LinkedListNode<Contact>>> index;
        private Func<Contact, k> KeySelector;

        public HashContactIndex(Func<Contact, k> keySelector)
        {
            index = new Dictionary<k, LinkedList<LinkedListNode<Contact>>>();
            KeySelector = keySelector;
        }

        public LinkedList<LinkedListNode<Contact>> GetContacts(k value) {
            if (index.TryGetValue(value, out var contacts))
                return contacts;

            return new LinkedList<LinkedListNode<Contact>>();
        }

        public void Add(LinkedListNode<Contact> contactNode)
        {
            k key = KeySelector(contactNode.Value);

            if (!index.ContainsKey(key))
                index[key] = new LinkedList<LinkedListNode<Contact>>();

            index[key].AddLast(contactNode);
        }

        public void Remove(LinkedListNode<Contact> contactNode)
        {
            k key = KeySelector(contactNode.Value);
            
            if (index.TryGetValue(key, out var contacts))
            {
                contacts.Remove(contactNode);
                if (contacts.Count == 0)
                    index.Remove(key);
            }
        }

    }
}