using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCG_Elite.Entity;

namespace TCG_Elite.Utilitarios
{
    public class Database : DataContext
    {
        private static string StringConnection = "Data Source='isostore:ygo.sdf'";

        public Database()
            : base(StringConnection)
        { }

        public Table<Ygo> jogadorDB
        {
            get { return this.GetTable<Ygo>(); }
        }


    }
}
