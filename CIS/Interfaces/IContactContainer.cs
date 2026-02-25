using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IContactContainer
    {
        LinkedListNode<Contact> Add(Contact contact);
        void Remove(LinkedListNode<Contact> contactNode);
        LinkedList<Contact> GetContacts();
        void SetContacts(LinkedList<Contact> contacts);
    }
}