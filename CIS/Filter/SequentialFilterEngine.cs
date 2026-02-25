using CIS.Contacts;
using CIS.Interfaces;

namespace CIS.Filter {
    class SequentialFilterEngine : IFilterEngine {
        public LinkedList<Contact> Filter(DATA_FIELD field, string value)
        {
            // Placeholder implementation for sequential filtering
            return new LinkedList<Contact>();
        }
    }
}
