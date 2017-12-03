using System;
using System.IO;

namespace Core
{
    public class FileOperations
    {

        public static string Save(string table, string poco)
        {

            if (string.IsNullOrEmpty(table))
            {
                throw new ArgumentException("Table name can not be null or empty");
            }

            if (string.IsNullOrEmpty(poco))
            {
                throw new ArgumentException("POCO can not ne null or empty");
            }

            try
            {
                var current_Path = Directory.GetCurrentDirectory();
                var output_Path = Path.Combine(current_Path, "Output", table + ".cs");
                if (File.Exists(output_Path))
                {
                    File.Delete(output_Path);
                }
                if (!Directory.Exists(Path.Combine(current_Path, "Output")))
                {
                    Directory.CreateDirectory((Path.Combine(current_Path, "Output")));
                }
                File.WriteAllText(output_Path, poco);
                return output_Path;
            }
            catch (IOException e)
            {
                throw;
            }
        }
    }
}
