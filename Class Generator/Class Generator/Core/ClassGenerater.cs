using Core.Database;
using Core.Database.SQLServer;
using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class ClassGenerater
    {
        IDatabase _database;

        ClassGenerater(DBName dBName, string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString) || String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("Connection can not be null or empty.");

            switch (dBName)
            {
                case DBName.SqlServer:
                    _database = new SqlServer(connectionString);
                    break;
                case DBName.Cassandra:
                case DBName.DB2:
                case DBName.MySql:
                case DBName.Oracle:
                case DBName.postgresql:
                    throw new NotImplementedException("Mentioned database is not implemented.");
                case DBName.None:
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Database not exists.");

            }
        }

        public void Process()
        {
            try
            {
                FileOperations fileOperations = new FileOperations("", false);
                List<string> outputPath = new List<string>();
                var tables = _database.GetTables();
                if (tables != null && tables.Any())
                {
                    foreach (var table in tables)
                    {
                        var output = fileOperations.Save(table.Schema, table.Name, Generater.GenerateClass(table));
                        outputPath.Add(output);
                        Console.WriteLine(output);
                    }
                }
            }
            catch (Exception e)
            {
                //supress the exception for testing
            }
        }

    }
}
