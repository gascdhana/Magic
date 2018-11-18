using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Core.Database.SQLServer
{
    public class SqlServer : IDatabase
    {
        private readonly string connectionString;

        public SqlServer(string _connectionString)
        {
            connectionString = _connectionString;
        }

        /// <summary>
        /// Return list of tables available user tables
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Table> GetTables()
        {
            IEnumerable<Table> tables = new List<Table>();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    Dictionary<string, Table> tableLookUp = new Dictionary<string, Table>();
                    con.Query<Table, Column, Table>(Resources.SQLServerQuery, (t, c) =>
                    {
                        if (!tableLookUp.TryGetValue(t.Name, out Table table))
                        {
                            table = new Table
                            {
                                Name = t.Name,
                                Schema = t.Schema,
                                Column = new List<Column>()
                            };
                            tableLookUp.Add(table.Name, table);
                        }

                        table.Column.Add(c);

                        return null;
                    }, splitOn: "Name");
                    tables = tableLookUp.Values;
                }
                return tables;
            }
#pragma warning disable CS0168 // The variable 'e' is declared but never used
            catch (Exception e)
#pragma warning restore CS0168 // The variable 'e' is declared but never used
            {
                throw;
            }
        }
    }
}
