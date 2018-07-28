using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Core.Tests
{
    [TestClass()]
    public class FileOperationsTests
    {
        [TestMethod()]
        public void SaveTest_EmptyParameters()
        {
            string table = "", poco = "", schema = "";
            try
            {
                FileOperations fileOperations = new FileOperations("", false);
                fileOperations.Save(schema,table, poco);
                Assert.Fail();
            }
            catch (Exception e)
            {
            }
        }
        [TestMethod()]
        public void SaveTest_NullParameters()
        {
            string table = null, poco = null, schema = null;
            try
            {
                FileOperations fileOperations = new FileOperations("", false);
                fileOperations.Save(schema, table, poco);
                Assert.Fail();
            }
            catch (Exception e)
            {
            }
        }

        [TestMethod()]
        public void SaveTest_MissingPOCO()
        {
            string table = "TestTable", poco = null, schema = null;
            try
            {
                FileOperations fileOperations = new FileOperations("", false);
                fileOperations.Save(schema, table, poco);
                Assert.Fail();
            }
            catch (Exception e)
            {
            }
        }

        [TestMethod()]
        public void SaveTest_MissingTable()
        {
            string table = null, poco = "class TestTable {}", schema= null;
            try
            {
                FileOperations fileOperations = new FileOperations("", false);
                fileOperations.Save(schema, table, poco);
                Assert.Fail();
            }
            catch (Exception e)
            {
            }
        }

        [TestMethod()]
        public void SaveTest_MissingSchema()
        {
            string table = "TestTable", poco = "class TestTable {}", schema = "";
            try
            {
                FileOperations fileOperations = new FileOperations("", false);
                var outputPath = fileOperations.Save(schema, table, poco);
                if (!File.Exists(outputPath))
                    Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.Fail();

            }
        }

        [TestMethod()]
        public void SaveTest_Success()
        {
            string table = "TestTable", poco = "class TestTable {}", schema = "dbo";
            try
            {
                FileOperations fileOperations = new FileOperations("", false);
                var outputPath = fileOperations.Save(schema, table, poco);
                if (!File.Exists(outputPath))
                    Assert.Fail();
                else
                    File.Delete(outputPath);
            }
            catch (Exception e)
            {
                Assert.Fail();

            }
        }
    }
}