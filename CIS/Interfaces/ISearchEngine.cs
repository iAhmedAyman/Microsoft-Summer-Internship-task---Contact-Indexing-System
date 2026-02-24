using CIS.Contacts;

namespace CIS.Interfaces {
    public interface ISearchEngine
    {
        LinkedList<LinkedListNode<Contact>> Search(DATA_FIELD field, string value);
    }
}