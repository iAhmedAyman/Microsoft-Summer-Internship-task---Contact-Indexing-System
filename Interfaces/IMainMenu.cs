using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IMainMenu
    {
        static void main(string[] args);
        private void printMenu();
        private void printContacts(LinkedList<Contact> contacts);
    }
}