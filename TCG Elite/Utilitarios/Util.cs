using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG_Elite.Utilitarios
{
    public class Util
    {
        /// <summary>
        /// Le um arquivo json
        /// </summary>
        /// <param name="path">passa o caminho onde o arquivo se encontra</param>
        /// <returns>o conteudo do arquivo</returns>
        public static String ReadFile(String path)
        {
            var resource = App.GetResourceStream(new Uri(path, UriKind.Relative));
            if (resource == null)
            {
                //Arquivo  n  encontrado
                return null;
            }
            StreamReader reader = new StreamReader(resource.Stream);
            string arquivo = reader.ReadToEnd();
            return arquivo;
        }
    }
}
