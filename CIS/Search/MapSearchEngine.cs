using CIS.Contacts;
using CIS.Interfaces;
using CIS.Indexing;

namespace CIS.Search {
    class MapSearchEngine : ISearchEngine {
        private IndexManager indexManager;

        public MapSearchEngine(IndexManager indexManager)
        {
            this.indexManager = indexManager;
        }

        public LinkedList<LinkedListNode<Contact>> Search(DATA_FIELD field, string value)
        {
            return indexManager.GetIndex(field).GetContacts(value);
        }
    }
}