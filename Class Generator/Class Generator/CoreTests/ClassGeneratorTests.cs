using Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Tests
{
    [TestClass()]
    public class ClassGeneratorTests
    {
        [TestMethod()]
        public void GenerateClassTest_NullColumn()
        {
            try
            {
                Table t = new Table
                {
                    Name = "TestTable",
                    Schema = "dbo"
                };
                Generater.GenerateClass(t);
                Assert.Fail();
            }
            catch (Exception e)
            {

            }
        }

        [TestMethod()]
        public void GenerateClassTest_NoColumn()
        {
            try
            {
                Table t = new Table
                {
                    Name = "TestTable",
                    Schema = "dbo",
                    Column = new System.Collections.Generic.List<Column>()
                };
                Generater.GenerateClass(t);
                Assert.Fail();
            }
            catch (ArgumentException e)
            {

            }
        }

        [TestMethod()]
        public void GenerateClassTest_NoTableName()
        {
            try
            {
                Table t = new Table
                {
                    Name = "TestTable",
                    Schema = "dbo",
                    Column = new System.Collections.Generic.List<Column>()
                };
                Generater.GenerateClass(t);
                Assert.Fail();
            }
            catch (ArgumentException e)
            {

            }
        }

        [TestMethod()]
        public void GenerateClassTest_Success()
        {
            try
            {
                Table t = new Table
                {
                    Name = "TestTable",
                    Schema = "dbo",
                    Column = new System.Collections.Generic.List<Column>
                    {
                        new Column
                        {
                            Name = "ID",
                            DataType = "bigint",
                            AllowNull = false
                        },

                        new Column
                        {
                            Name = "Name",
                            DataType = "varchar",
                            AllowNull = false,
                            Size = 255
                        },

                        new Column
                        {
                            Name = "Address",
                            DataType = "varchar",
                            AllowNull = false,
                            Size = 255
                        }
                    }
                };
                string result = Generater.GenerateClass(t);
                if(result == null || result == "")
                {
                    Assert.Fail();
                }
            }
            catch (ArgumentException e)
            {
                Assert.Fail();
            }
        }
    }
}