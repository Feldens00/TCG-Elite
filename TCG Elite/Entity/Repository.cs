using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCG_Elite.Utilitarios;

namespace TCG_Elite.Entity
{
   public class Repository
    {
        public List<Pokemon> parseJson(string pPath)
        {
            List<Pokemon> pokJson = new List<Pokemon>();
           

            var json = Util.ReadFile(pPath);


            var pokemon = JsonConvert.DeserializeObject<List<Pokemon>>(json);


           return pokemon;
        }

        private static Database GetDataBase()
        {
            Database db = new Database();
            if (db.DatabaseExists() == false)
            {
                //Cria o banco
                db.CreateDatabase();
            }

            return db;
        }

        public void Create(Ygo pJogador)
        {
            Database db = GetDataBase();

            db.jogadorDB.InsertOnSubmit(pJogador);
            db.SubmitChanges();
        }


        public static List<Ygo> Select(string pId)
        {
            Database db = GetDataBase();
            var query = from  jg in db.jogadorDB orderby jg.jogador1 select jg;
            // where c.Id.equals(pId) order by  c.Nome select c;
            List<Ygo> jogador1 = new List<Ygo>(query.AsEnumerable());

            return jogador1;
        }

        public void Delete(Ygo  pJogador)
        {
            Database db = GetDataBase();
            var query = from jg in db.jogadorDB where jg.id == pJogador.id select jg;
            db.jogadorDB.DeleteOnSubmit(query.ToList()[0]);

            db.SubmitChanges();
        }

        public void Update(Ygo pJogador)
        {
            Database db = GetDataBase();
            var query = from jg in db.jogadorDB
                        where jg.id == pJogador.id
                        select jg;
            var jogadorDoBanco = query.ToList()[0];
            jogadorDoBanco.jogador1 = pJogador.jogador1;
            jogadorDoBanco.jogador2 = pJogador.jogador2;
        }



        public List<Ygo> GetAll()
        {
            Database db = GetDataBase();

            var query = from jg in db.jogadorDB orderby jg.jogador1 select jg;

            var jog = new List<Ygo>(query.AsEnumerable());
            return jog;
        }

        private Ygo GetOne(int pId)
        {
            Database db = GetDataBase();

            var jog = from jg in db.jogadorDB
                      where jg.id == pId
                      select jg;
            return jog.FirstOrDefault();

        }
    }
}
