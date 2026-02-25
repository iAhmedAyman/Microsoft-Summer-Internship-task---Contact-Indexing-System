using CIS.Contacts;
using CIS.Interfaces;
using CIS.Indexing;

namespace CIS.Search {
    class MapSearchEngine : ISearchEngine {
        private IIndexManager IIndexManager;

        public MapSearchEngine(IIndexManager IIndexManager)
        {
            this.IIndexManager = IIndexManager;
        }

        public LinkedList<LinkedListNode<Contact>> Search(DATA_FIELD field, string value)
        {
            return IIndexManager.GetContacts(field, value);
        }
    }
}