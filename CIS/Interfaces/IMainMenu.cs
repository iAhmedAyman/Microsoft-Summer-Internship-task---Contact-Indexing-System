using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IMainMenu
    {
        void main(string[] args);
        private void printMenu();
        private void printContacts(LinkedList<Contact> contacts);
    }
}