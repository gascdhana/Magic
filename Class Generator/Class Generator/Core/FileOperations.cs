using Core.Enum;
using System;
using System.IO;

namespace Core
{
    public class FileOperations
    {
        private string _path;
        public FileOperations(string path, bool isAbsolutePath)
        {
            if(!isAbsolutePath)
            {
                _path = Path.Combine(Directory.GetCurrentDirectory(), path ?? "");
            }
            else
            {
                _path = path;
            }
        }

        public string Save(string schema, string table, string poco)
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
                
                var output_Path = Path.Combine(_path, schema, string.Concat(table, Constants.Dot_Cs));
                if (File.Exists(output_Path))
                {
                    File.Delete(output_Path);
                }
                if (!Directory.Exists(Path.Combine(_path, schema)))
                {
                    Directory.CreateDirectory((Path.Combine(_path, schema)));
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
