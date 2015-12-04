using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG_Elite.Entity
{
    [Table(Name = "Ygos")]
    public class Ygo
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id { get; set; }

        [Column(CanBeNull = false)]
        public string  jogador1 { get; set; }

        [Column(CanBeNull = false)]
        public string jogador2 { get; set; }

        [Column(CanBeNull = true)]
        public int pontosVida  { get; set; }

        public int operation { get; set; }



        public Ygo()
        {

        }

        public Ygo(int pPontosVida, string pJogador1, string pJogador2, int pOperation )
        { 
            jogador1 = pJogador1;
            jogador2 = pJogador2;
            pontosVida = pPontosVida;
            operation = pOperation;
           
        }
    }
}
