using System;
using System.IO;
using Newtonsoft.Json;

namespace Loja_de_Roupas
{
    class Persistencia : IPersistencia
    {
        string converteEmJson(Object objeto)
        {
            return JsonConvert.SerializeObject(objeto, Formatting.Indented);
        }

        void salvaJsonEmArquivo(string json)
        {
            File.WriteAllText(@"./teste.json", json);
        }

        public void salvaObjetoEmArquivo(Object objeto)
        {
            string jsonString = converteEmJson(objeto);
            salvaJsonEmArquivo(jsonString);
        }
    }
}
