using System.Collections.Generic;

namespace Core
{
    internal static class Extensions
    {
        public static string GetCLRType(this string SqlDbType)
        {
            string ClrType;
            if (!string.IsNullOrEmpty(SqlDbType))
            {
                switch (SqlDbType.ToLower())
                {
                    case "bigint":
                        ClrType = "Int64";
                        break;
                    case "binary":
                        ClrType = "Byte[]";
                        break;
                    case "bit":
                        ClrType = "Boolean";
                        break;
                    case "char":
                        ClrType = "String";
                        break;
                    case "date":
                        ClrType = "DateTime";
                        break;
                    case "datetime2":
                        ClrType = "DateTime";
                        break;
                    case "DateTimeOffset":
                        ClrType = "DateTimeOffset";
                        break;
                    case "Decimal":
                        ClrType = "Decimal";
                        break;
                    case "FILESTREAM":
                        ClrType = "Byte[]";
                        break;
                    case "float":
                        ClrType = "Double";
                        break;
                    case "image":
                        ClrType = "Byte[]";
                        break;
                    case "int":
                        ClrType = "Int32";
                        break;
                    case "money":
                        ClrType = "Decimal";
                        break;
                    case "nchar":
                        ClrType = "String";
                        break;
                    case "ntext":
                        ClrType = "String";
                        break;
                    case "numeric":
                        ClrType = "Decimal";
                        break;
                    case "nvarchar":
                        ClrType = "String";
                        break;
                    case "real":
                        ClrType = "Single";
                        break;
                    case "rowversion":
                        ClrType = "Byte[]";
                        break;
                    case "smalldatetime":
                        ClrType = "DateTime";
                        break;
                    case "smallint":
                        ClrType = "Int16";
                        break;
                    case "smallmoney":
                        ClrType = "Decimal";
                        break;
                    case "sql_variant":
                        ClrType = "Object";
                        break;
                    case "text":
                        ClrType = "String";
                        break;
                    case "time":
                        ClrType = "TimeSpan";
                        break;
                    case "timestamp":
                        ClrType = "Byte[]";
                        break;
                    case "tinyint":
                        ClrType = "Byte";
                        break;
                    case "uniqueidentifier":
                        ClrType = "Guid";
                        break;
                    case "varbinary":
                        ClrType = "Byte[]";
                        break;
                    case "varchar":
                        ClrType = "String";
                        break;
                    case "xml":
                        ClrType = "Xml";
                        break;
                    default:
                        ClrType = null;
                        break;
                }
                return ClrType;
            }
            else
            {
                return null;
            }
        }
    }

    public class Table
    {
        public string Name { set; get; }
        public string Schemaname { set; get; }
        public List<Column> Column { set; get; }
    }

    public class Column
    {
        public string Name { set; get; }
        public string DataType { set; get; }
        public string CLRType { get { return DataType.GetCLRType(); } }
        public int Size { set; get; }
        public bool AllowNull { set; get; }
    }
}

