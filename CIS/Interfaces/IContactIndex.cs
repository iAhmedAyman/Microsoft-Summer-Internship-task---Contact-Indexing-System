using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IContactIndex<TKey>
    {
        LinkedList<LinkedListNode<Contact>> GetContacts(TKey value);
        void Add(LinkedListNode<Contact> contactNode);
        public void Remove(LinkedListNode<Contact> contactNode);
    }
}