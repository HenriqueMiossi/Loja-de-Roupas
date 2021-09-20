using System;
using System.IO;
using Newtonsoft.Json;

namespace Loja_de_Roupas
{
    class Persistencia
    {
        public string converteEmJson(Object objeto)
        {
            return JsonConvert.SerializeObject(objeto, Formatting.Indented);
        }

        public void salvaJsonEmArquivo(string json)
        {
            File.WriteAllText(@"./teste.json", json);
        }
    }
}
