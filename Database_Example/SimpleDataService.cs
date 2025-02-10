using Database_Example.Database;
using Database_Example.Model;
using System.Text.RegularExpressions;

namespace Database_Example
{
    public class SimpleDataService
    {
        private readonly DatabaseContext databaseContext;
        public SimpleDataService(DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }

        public async Task AddSimpleData(SimpleData simpleData)
        {
            databaseContext.simpleDatas.Add(simpleData);
            await databaseContext.SaveChangesAsync();
        }
    }
}
