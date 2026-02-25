using CIS.Contacts;
using CIS.Interfaces;
using CIS.Presistence;
using CIS.Search;

namespace CIS.Controller {
    class ConcreteContactService : IContactService {
        private IPresistenceManager persistenceManager;
        private ISearchEngine searchEngine;
        private IIndexManager indexManager;
        private IContactContainer contactContainer;
        private IFilterEngine filterEngine;

        public ConcreteContactService(IPresistenceManager persistenceManager, ISearchEngine searchEngine, IIndexManager indexManager, IFilterEngine filterEngine)
        {
            this.persistenceManager = persistenceManager;
            this.searchEngine = searchEngine;
            this.indexManager = indexManager;
            this.contactContainer = new ContactList();
            this.filterEngine = filterEngine;
        }

        public void LoadData(string filePath) {
            LinkedList<Contact> contacts = persistenceManager.LoadData(filePath);
            contactContainer.SetContacts(contacts);
        }

        public void SaveData(string filePath) {
            persistenceManager.SaveData(filePath, contactContainer.GetContacts());
        }

        public void Add(Contact contact) {
            LinkedListNode<Contact> contactNode = contactContainer.Add(contact);
            indexManager.Add(contactNode);
        }

        public void Remove(DATA_FIELD field, string value) {
            LinkedList<LinkedListNode<Contact>> contactNodes = indexManager.GetContacts(field, value);
            foreach (LinkedListNode<Contact> contactNode in contactNodes)
            {
                contactContainer.Remove(contactNode);
                indexManager.Remove(contactNode);
            }
        }

        public void Update(DATA_FIELD field, string oldValue, Contact newContact) {
            LinkedList<LinkedListNode<Contact>> contactNodes = indexManager.GetContacts(field, oldValue);
            foreach (LinkedListNode<Contact> contactNode in contactNodes)
            {
                Contact oldContact = contactNode.Value;
                contactNode.Value = newContact;
            }
        }

        public LinkedList<LinkedListNode<Contact>> ViewContact(DATA_FIELD field, string value) {
            LinkedList<LinkedListNode<Contact>> contactNodes = indexManager.GetContacts(field, value);
            return contactNodes;
        }

        public LinkedList<Contact> GetAllContacts() {
            return contactContainer.GetContacts();
        }

        public LinkedList<LinkedListNode<Contact>> Search(DATA_FIELD field, string value) {
            LinkedList<LinkedListNode<Contact>> contactNodes = searchEngine.Search(field, value);
            return contactNodes;
        }

        public LinkedList<Contact> Filter(DATA_FIELD field, string value) {
            throw new NotImplementedException();
        }
    }
}