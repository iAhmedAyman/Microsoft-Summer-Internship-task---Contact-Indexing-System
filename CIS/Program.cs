using CIS.Controller;
using CIS.UI;
using CIS.Presistence;
using CIS.Search;

class Program
{
    static void Main(string[] args)
    {
        IPresistenceManager persistenceManager = new JSONManager();
        IndexManager indexManager = new IndexManager();
        ISearchEngine searchEngine = new MapSearchEngine(indexManager);
        IFilterEngine filterEngine = new SequentialFilterEngine(); 

        var contactService = new ConcreteContactService(persistenceManager, searchEngine, indexManager, filterEngine);

        var menu = new CLIMainMenu(contactService);
        menu.Main();
    }
}