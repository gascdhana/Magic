using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Enum
{
	//Database provider names
    public enum DBName
    {
        None = 0,
        SqlServer = 1,
        Cassandra = 2,
        Oracle = 3,
        MySql = 4,
        DB2 = 5,
        postgresql = 6,

    }

    public enum Extn
    {
        cs,
        txt,
    }

    public class Constants
    {
        public static readonly string Dot_Cs = ".cs";
        public static readonly string Dot_Txt = ".txt";
    }
}
