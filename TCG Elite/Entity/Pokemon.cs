using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG_Elite.Entity
{
   public class Pokemon
    {

        //public string id { get; set; }
        //public string typeTwo { get; set; }
        //public string name { get; set; }
        //public string type { get; set; }

        public string name { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int evolveLevel { get; set; }
        public string evolveTo { get; set; }
        public string type { get; set; }
        public List<string> moves { get; set; }
        public double curve { get; set; }
        public List<int> levels { get; set; }
        public int probability { get; set; }


     
    }
}
