using System.Collections.Generic;

namespace Core.Database
{
    internal interface IDatabase
    {
        IEnumerable<Table> GetTables();
    }
}
