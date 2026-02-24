using CIS.Contacts;

namespace CIS.Indexing {
    class HashContactIndex<TKey> : IContactIndex<TKey> {
        private Dictionary<TKey, LinkedList<LinkedListNode<Contact>>> index;
        private Func<Contact, TKey> KeySelector;

        public HashContactIndex(Func<Contact, TKey> keySelector)
        {
            index = new Dictionary<TKey, LinkedList<LinkedListNode<Contact>>>();
            KeySelector = keySelector;
        }

        public LinkedList<LinkedListNode<Contact>> GetContacts(TKey value) {
            if (index.TryGetValue(value, out var contacts))
                return contacts;

            return new LinkedList<LinkedListNode<Contact>>();
        }

        public void Add(LinkedListNode<Contact> contactNode)
        {
            TKey key = KeySelector(contactNode.Value);
            if (!index.ContainsKey(key))
                index[key] = new LinkedList<LinkedListNode<Contact>>();

            index[key].AddLast(contactNode);
        }

        public void Remove(LinkedListNode<Contact> contactNode)
        {
            TKey key = KeySelector(contactNode.Value);
            
            if (index.TryGetValue(key, out var contacts))
            {
                contacts.Remove(contactNode);
                if (contacts.Count == 0)
                    index.Remove(key);
            }
        }

    }
}