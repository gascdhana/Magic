using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Database.SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Database.SQLServer.Tests
{
    [TestClass()]
    public class SqlServerTests
    {
        [TestMethod()]
        public void GetTablesTest_InvalidConnection1()
        {
            SqlServer sqlServer = new SqlServer("");
            try
            {
                var list = sqlServer.GetTables();
                if (list != null && list.Any())
                    Assert.Fail();
            }
            catch (Exception e)
            {

            }
        }

        [TestMethod()]
        public void GetTablesTest_InvalidConnection2()
        {
            SqlServer sqlServer = new SqlServer("zcadvd");
            try
            {
                var list = sqlServer.GetTables();
                if (list != null && list.Any())
                    Assert.Fail();
            }
            catch (Exception e)
            {

            }
        }

        [TestMethod()]
        public void GetTablesTest_ValidConnection()
        {
            SqlServer sqlServer = new SqlServer("Data Source=LAPTOP-QGL6VQ37;Initial Catalog=TestDB;Integrated Security=True");
            try
            {
                var list = sqlServer.GetTables();
                if (list == null)
                    Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.Fail();

            }
        }

        [TestMethod()]
        public void GetTablesTest_MoreThanOneTable()
        {
            SqlServer sqlServer = new SqlServer("Data Source=LAPTOP-QGL6VQ37;Initial Catalog=TestDB;Integrated Security=True");
            try
            {
                var list = sqlServer.GetTables();
                if (list == null || list.Count() <= 1)
                    Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.Fail();

            }
        }
    }
}