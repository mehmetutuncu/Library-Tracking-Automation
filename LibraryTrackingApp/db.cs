using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace LibraryTrackingApp
{
    class db
    {
        //Projeye sqllite dll ekler. -> Install-Package System.Data.SqLite
        public SQLiteConnection myConnection = new SQLiteConnection("Data Source=../../librarytracking.db;Version=3;");
    }
}
