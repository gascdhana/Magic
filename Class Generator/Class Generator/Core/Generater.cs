using System;
using System.Linq;

namespace Core
{
    public static class Generater
    {
        public static string GenerateClass(Table table)
        {
            string classTemplate = Resources.ClassTemplate;
            string fieldTemplate = Resources.FieldTemplate;
            string fields = "", @class;

            if (String.IsNullOrEmpty(table.Name) || String.IsNullOrEmpty(table.Schema))
            {
                throw new ArgumentNullException("Table name or namespace can not be null or empty");
            }

            if (table.Column != null && table.Column.Any())
            {
                try
                {
                    foreach (var column in table.Column)
                    {
                        fields = String.Concat(fields, '\t', String.Format(fieldTemplate, column.CLRType, column.Name));
                    }
                    @class = String.Format(classTemplate, table.Schema, table.Name, fields);
                    return @class.Remove(@class.Length - 3, 2); ;
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            else
            {
                throw new ArgumentException("A table must contains column");
            }
        }
    }
}
