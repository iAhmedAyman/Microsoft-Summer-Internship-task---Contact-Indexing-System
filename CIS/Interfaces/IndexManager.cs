using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IIndexManager
    {
        LinkedList<LinkedListNode<Contact>> GetContacts(DATA_FIELD field, string value);
        void Add(LinkedListNode<Contact> contactNode);
        void Remove(LinkedListNode<Contact> contactNode);
    }
}