using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IContactIndex
    {
        LinkedList<LinkedListNode<Contact>> GetContacts(k value);
        void Add(LinkedListNode<Contact> contactNode, k key);
        public void Remove(LinkedListNode<Contact> contactNode, k key);
    }
}