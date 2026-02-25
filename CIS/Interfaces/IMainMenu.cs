using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IMainMenu
    {
        void main(string[] args);
        void printMenu();
        void printContacts(LinkedList<Contact> contacts);
    }
}