using System.Collections.Generic;

namespace Core
{
    /// <summary>
    /// Indicate database table
    /// </summary>
    public class Table
    {
        private string _name, _schema;

        /// <summary>
        /// Table name
        /// </summary>
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Schema name
        /// </summary>
        public string Schema
        {
            set
            {
                _schema = value;
            }
            get
            {
                return _schema;
            }
        }

        /// <summary>
        /// Available columns
        /// </summary>
        public List<Column> Column { set; get; }
    }

    /// <summary>
    /// Indicate a column in a table
    /// </summary>
    public class Column
    {
        private string _name, _dataType;
        private int _size;
        private bool _allowNull;

        /// <summary>
        /// Column Name
        /// </summary>
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// DB data type
        /// </summary>
        public string DataType
        {
            set
            {
                _dataType = value;
            }
            get
            {
                return _dataType;
            }
        }

        /// <summary>
        /// Compatible CLR type
        /// </summary>
        public string CLRType
        {
            get
            {
                return GetCLRType(_dataType);
            }
        }

        /// <summary>
        /// Size of a column
        /// </summary>
        public int Size
        {
            set
            {
                _size = value;
            }
            get
            {
                return _size;
            }
        }

        /// <summary>
        /// Is a nullable column
        /// </summary>
        public bool AllowNull
        {
            set
            {
                _allowNull = value;
            }
            get
            {
                return _allowNull;
            }
        }

        /// <summary>
        /// Return compatible CLR type for a BD type
        /// </summary>
        /// <param name="SqlDbType"></param>
        /// <returns></returns>
        private string GetCLRType(string SqlDbType)
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
}

