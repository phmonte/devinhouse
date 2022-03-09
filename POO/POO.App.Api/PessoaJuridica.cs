using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.App.Api
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }

        public PessoaJuridica(string nome) :base(nome + "Eu sou pj")
        {

        }
        public override void PagarImposto(string tipoImposto = "ICMS")
        {
            base.PagarImposto(tipoImposto);
        }
    }
}
