using System;

namespace Loja_de_Roupas
{
    class Loja
    {
        public string _cnpj { get; set; }
        public string _nomeFantasia { get; set; }
        public Endereco _endereco { get; set; }
        public Estoque _estoque { get; }

        public Loja(string cnpj, string nomeFantasia, Endereco endereco, Estoque estoque) {
            this._cnpj = cnpj;
            this._nomeFantasia = nomeFantasia;
            this._endereco = endereco;
            this._estoque = estoque;
        }
    }
}
