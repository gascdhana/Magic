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
            string table = "", poco = "";
            try
            {
                FileOperations.Save(table, poco);
                Assert.Fail();
            }
            catch (Exception e)
            {
            }
        }
        [TestMethod()]
        public void SaveTest_NullParameters()
        {
            string table = null, poco = null;
            try
            {
                FileOperations.Save(table, poco);
                Assert.Fail();
            }
            catch (Exception e)
            {
            }
        }

        [TestMethod()]
        public void SaveTest_MissingPOCO()
        {
            string table = "TestTable", poco = null;
            try
            {
                FileOperations.Save(table, poco);
                Assert.Fail();
            }
            catch (Exception e)
            {
            }
        }

        [TestMethod()]
        public void SaveTest_MissingTable()
        {
            string table = null, poco = "class TestTable {}";
            try
            {
                FileOperations.Save(table, poco);
                Assert.Fail();
            }
            catch (Exception e)
            {
            }
        }

        [TestMethod()]
        public void SaveTest_Success()
        {
            string table = "TestTable", poco = "class TestTable {}";
            try
            {
                var outputPath = FileOperations.Save(table, poco);
                if (!File.Exists(outputPath))
                    Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.Fail();

            }
        }
    }
}